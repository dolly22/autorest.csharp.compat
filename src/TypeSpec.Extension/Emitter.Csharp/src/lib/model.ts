// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

import { isFixed } from "@azure-tools/typespec-azure-core";
import {
    EncodeData,
    Enum,
    EnumMember,
    IntrinsicType,
    Model,
    ModelProperty,
    Namespace,
    NeverType,
    Operation,
    Program,
    Scalar,
    Type,
    Union,
    UsageFlags,
    getDeprecated,
    getDiscriminator,
    getDoc,
    getEffectiveModelType,
    getEncode,
    getFormat,
    getKnownValues,
    getProjectedNames,
    getVisibility,
    isArrayModelType,
    isRecordModelType,
    isGlobalNamespace,
    navigateTypesInNamespace,
    isVoidType,
    resolveUsages
} from "@typespec/compiler";
import {
    HttpOperation,
    getHeaderFieldName,
    getPathParamName,
    getQueryParamName,
    isStatusCode
} from "@typespec/http";
import { getResourceOperation } from "@typespec/rest";
import {
    projectedNameCSharpKey,
    projectedNameClientKey,
    projectedNameJsonKey
} from "../constants.js";
import { FormattedType } from "../type/formattedType.js";
import { InputEnumTypeValue } from "../type/inputEnumTypeValue.js";
import { InputModelProperty } from "../type/inputModelProperty.js";
import {
    InputDictionaryType,
    InputEnumType,
    InputIntrinsicType,
    InputListType,
    InputLiteralType,
    InputModelType,
    InputNullType,
    InputPrimitiveType,
    InputType,
    InputUnionType,
    InputUnknownType,
    isInputEnumType,
    isInputLiteralType,
    isInputModelType
} from "../type/inputType.js";
import { InputTypeKind } from "../type/inputTypeKind.js";
import { LiteralTypeContext } from "../type/literalTypeContext.js";
import { Usage } from "../type/usage.js";
import { logger } from "./logger.js";
import {
    SdkContext,
    getAccess,
    getClientType,
    getUsageOverride,
    isInternal
} from "@azure-tools/typespec-client-generator-core";
import { capitalize, getSerializeName, getTypeName } from "./utils.js";
/**
 * Map calType to csharp InputTypeKind
 */
export function mapTypeSpecTypeToCSharpInputTypeKind(
    context: SdkContext,
    typespecType: Type,
    format?: string,
    encode?: EncodeData
): InputTypeKind {
    const kind = typespecType.kind;
    switch (kind) {
        case "Model":
            return getCSharpInputTypeKindByIntrinsicModelName(
                typespecType.name,
                format,
                encode
            );
        case "ModelProperty":
            return InputTypeKind.Object;
        case "Enum":
            return InputTypeKind.Enum;
        case "Number":
            let numberValue = typespecType.value;
            if (numberValue % 1 === 0) {
                return InputTypeKind.Int32;
            }
            return InputTypeKind.Float64;
        case "Boolean":
            return InputTypeKind.Boolean;
        case "String":
            if (format === "date") return InputTypeKind.DateTime;
            if (format === "uri") return InputTypeKind.Uri;
            return InputTypeKind.String;
        default:
            return InputTypeKind.UnKnownKind;
    }
}

function getCSharpInputTypeKindByIntrinsicModelName(
    name: string,
    format?: string,
    encode?: EncodeData
): InputTypeKind {
    switch (name) {
        case "bytes":
            switch (encode?.encoding) {
                case undefined:
                case "base64":
                    return InputTypeKind.Bytes;
                case "base64url":
                    return InputTypeKind.BytesBase64Url;
                default:
                    logger.warn(
                        `invalid encode ${encode?.encoding} for bytes.`
                    );
                    return InputTypeKind.Bytes;
            }
        case "int8":
            return InputTypeKind.SByte;
        case "unit8":
            return InputTypeKind.Byte;
        case "int32":
            return InputTypeKind.Int32;
        case "int64":
            return InputTypeKind.Int64;
        case "float32":
            return InputTypeKind.Float32;
        case "float64":
            return InputTypeKind.Float64;
        case "uri":
        case "url":
            return InputTypeKind.Uri;
        case "uuid":
            return InputTypeKind.Guid;
        case "etag":
            return InputTypeKind.String;
        case "string":
            switch (format?.toLowerCase()) {
                case "date":
                    return InputTypeKind.DateTime;
                case "uri":
                case "url":
                    return InputTypeKind.Uri;
                case "uuid":
                    return InputTypeKind.Guid;
                default:
                    if (format) {
                        logger.warn(`invalid format ${format}`);
                    }
                    return InputTypeKind.String;
            }
        case "boolean":
            return InputTypeKind.Boolean;
        case "date":
            return InputTypeKind.Date;
        case "datetime":
            switch (encode?.encoding) {
                case undefined:
                    return InputTypeKind.DateTime;
                case "rfc3339":
                    return InputTypeKind.DateTimeRFC3339;
                case "rfc7231":
                    return InputTypeKind.DateTimeRFC7231;
                case "unixTimestamp":
                    return InputTypeKind.DateTimeUnix;
                default:
                    logger.warn(
                        `invalid encode ${encode?.encoding} for date time.`
                    );
                    return InputTypeKind.DateTime;
            }
        case "time":
            return InputTypeKind.Time;
        case "duration":
            switch (encode?.encoding) {
                case undefined:
                case "ISO8601":
                    return InputTypeKind.DurationISO8601;
                case "seconds":
                    if (
                        encode.type?.name === "float" ||
                        encode.type?.name === "float32"
                    ) {
                        return InputTypeKind.DurationSecondsFloat;
                    } else {
                        return InputTypeKind.DurationSeconds;
                    }
                default:
                    logger.warn(
                        `invalid encode ${encode?.encoding} for duration.`
                    );
                    return InputTypeKind.DurationISO8601;
            }
        default:
            return InputTypeKind.Object;
    }
}

/**
 * If type is an anonymous model, tries to find a named model that has the same
 * set of properties when non-schema properties are excluded.
 */
export function getEffectiveSchemaType(context: SdkContext, type: Type): Type {
    let target = type;
    if (type.kind === "Model" && !type.name) {
        const effective = getEffectiveModelType(
            context.program,
            type,
            isSchemaPropertyInternal
        );
        if (effective.name) {
            target = effective;
        }
    }

    return target;

    function isSchemaPropertyInternal(property: ModelProperty) {
        return isSchemaProperty(context, property);
    }
}

/**
 * A "schema property" here is a property that is emitted to OpenAPI schema.
 *
 * Headers, parameters, status codes are not schema properties even they are
 * represented as properties in TypeSpec.
 */
function isSchemaProperty(context: SdkContext, property: ModelProperty) {
    const program = context.program;
    const headerInfo = getHeaderFieldName(program, property);
    const queryInfo = getQueryParamName(program, property);
    const pathInfo = getPathParamName(program, property);
    const statusCodeInfo = isStatusCode(program, property);
    return !(headerInfo || queryInfo || pathInfo || statusCodeInfo);
}

export function getDefaultValue(type: Type): any {
    switch (type.kind) {
        case "String":
            return type.value;
        case "Number":
            return type.value;
        case "Boolean":
            return type.value;
        case "Tuple":
            return type.values.map(getDefaultValue);
        default:
            return undefined;
    }
}

export function isNeverType(type: Type): type is NeverType {
    return type.kind === "Intrinsic" && type.name === "never";
}

export function getInputType(
    context: SdkContext,
    formattedType: FormattedType,
    models: Map<string, InputModelType>,
    enums: Map<string, InputEnumType>,
    literalTypeContext?: LiteralTypeContext
): InputType {
    const type = formattedType.type;
    logger.debug(`getInputType for kind: ${type.kind}`);
    const program = context.program;
    if (type.kind === "Model") {
        return getInputModelType(type);
    } else if (
        type.kind === "String" ||
        type.kind === "Number" ||
        type.kind === "Boolean"
    ) {
        return getInputLiteralType(formattedType, literalTypeContext);
    } else if (type.kind === "Enum") {
        return getInputTypeForEnum(type);
    } else if (type.kind === "EnumMember") {
        return getInputTypeForEnum(type.enum);
    } else if (type.kind === "Intrinsic") {
        return getInputModelForIntrinsicType(type);
    } else if (type.kind === "Scalar") {
        let effectiveType = type;
        while (!program.checker.isStdType(effectiveType)) {
            if (type.baseScalar) {
                effectiveType = type.baseScalar;
            } else {
                break;
            }
        }
        const intrinsicName = effectiveType.name;
        switch (intrinsicName) {
            case "string":
                const values = getKnownValues(program, type);
                if (values) {
                    return getInputModelForEnumByKnowValues(type, values);
                }
            // if the model is one of the typespec Intrinsic type.
            // it's a base typespec "primitive" that corresponds directly to an c# data type.
            // In such cases, we don't want to emit a ref and instead just
            // emit the base type directly.
            default:
                const sdkType = getClientType(context, type);
                return {
                    Name: getTypeName(context, type),
                    Kind: getCSharpInputTypeKindByIntrinsicModelName(
                        sdkType.kind,
                        formattedType.format,
                        formattedType.encode
                    ),
                    IsNullable: false
                } as InputPrimitiveType;
        }
    } else if (type.kind === "Union") {
        return getInputTypeForUnion(type);
    } else if (type.kind === "Tuple") {
        return {
            Name: "Intrinsic",
            Kind: "unknown",
            IsNullable: false
        } as InputUnknownType;
    } else {
        throw new Error(`Unsupported type ${type.kind}`);
    }

    function getInputModelType(m: Model): InputType {
        /* Array and Map Type. */
        if (!isNeverType(m)) {
            if (isArrayModelType(program, m)) {
                return getInputTypeForArray(m.indexer.value);
            } else if (isRecordModelType(program, m)) {
                return getInputTypeForMap(m.indexer.key, m.indexer.value);
            }
        }
        return getInputModelForModel(m);
    }

    function getInputModelForEnumByKnowValues(
        m: Model | Scalar,
        e: Enum
    ): InputEnumType {
        const name = getTypeName(context, m);
        let extensibleEnum = enums.get(name);
        if (!extensibleEnum) {
            const innerEnum: InputEnumType = getInputTypeForEnum(e, false);
            if (!innerEnum) {
                throw new Error(
                    `Extensible enum type '${e.name}' has no values defined.`
                );
            }
            extensibleEnum = {
                Name: name,
                EnumValueType: innerEnum.EnumValueType, //EnumValueType and  AllowedValues should be the first field after id and name, so that it can be corrected serialized.
                AllowedValues: innerEnum.AllowedValues,
                Namespace: getFullNamespaceString(e.namespace),
                Accessibility: undefined, //TODO: need to add accessibility
                Deprecated: getDeprecated(program, m),
                Description: getDoc(program, m),
                IsExtensible: !isFixed(program, e),
                IsNullable: false
            } as InputEnumType;
            enums.set(name, extensibleEnum);
        }
        return extensibleEnum;
    }

    function getInputLiteralType(
        formattedType: FormattedType,
        literalContext?: LiteralTypeContext
    ): InputLiteralType {
        // For literal types, we just want to emit them directly as well.
        const type = formattedType.type;
        const builtInKind: InputTypeKind = mapTypeSpecTypeToCSharpInputTypeKind(
            context,
            type,
            formattedType.format,
            formattedType.encode
        );
        const rawValueType = {
            Name: type.kind,
            Kind: builtInKind,
            IsNullable: false
        } as InputPrimitiveType;
        const literalValue = getDefaultValue(type);
        const newValueType = getLiteralValueType();

        if (isInputEnumType(newValueType)) {
            enums.set(newValueType.Name, newValueType);
        }

        return {
            Name: "Literal",
            LiteralValueType: newValueType,
            Value: literalValue,
            IsNullable: false
        } as InputLiteralType;

        function getLiteralValueType(): InputPrimitiveType | InputEnumType {
            // we will not wrap it if it comes from outside a model or it is a boolean
            if (literalContext === undefined || rawValueType.Kind === "Boolean")
                return rawValueType;

            // otherwise we need to wrap this into an extensible enum
            // we use the model name followed by the property name as the enum name to ensure it is unique
            const enumName = `${literalContext.ModelName}_${literalContext.PropertyName}`;
            const enumValueType =
                rawValueType.Kind === "String" ? "String" : "Float32";
            const allowValues: InputEnumTypeValue[] = [
                {
                    Name: literalValue.toString(),
                    Value: literalValue,
                    Description: literalValue.toString()
                } as InputEnumTypeValue
            ];
            const enumType = {
                Name: enumName,
                EnumValueType: enumValueType, //EnumValueType and  AllowedValues should be the first field after id and name, so that it can be corrected serialized.
                AllowedValues: allowValues,
                Namespace: literalContext.Namespace,
                Accessibility: undefined,
                Deprecated: undefined,
                Description: `The ${enumName}`, // TODO -- what should we put here?
                IsExtensible: true,
                IsNullable: false
            } as InputEnumType;
            return enumType;
        }
    }

    function getInputTypeForEnum(
        e: Enum,
        addToCollection: boolean = true
    ): InputEnumType {
        const name = getTypeName(context, e);
        let enumType = enums.get(name);
        if (!enumType) {
            if (e.members.size === 0) {
                throw new Error(
                    `Enum type '${e.name}' doesn't define any values.`
                );
            }
            const allowValues: InputEnumTypeValue[] = [];
            const enumValueType = enumMemberType(
                e.members.entries().next().value[1]
            );

            for (const key of e.members.keys()) {
                const option = e.members.get(key);
                if (!option) {
                    throw Error(`No member value for $key`);
                }
                if (enumValueType !== enumMemberType(option)) {
                    throw new Error(
                        "The enum member value type is not consistent."
                    );
                }
                const member = {
                    Name: getTypeName(context, option),
                    Value: option.value ?? option?.name,
                    Description: getDoc(program, option)
                } as InputEnumTypeValue;
                allowValues.push(member);
            }

            enumType = {
                Name: name,
                EnumValueType: enumValueType, //EnumValueType and  AllowedValues should be the first field after id and name, so that it can be corrected serialized.
                AllowedValues: allowValues,
                Namespace: getFullNamespaceString(e.namespace),
                Accessibility: getAccess(context, e),
                Deprecated: getDeprecated(program, e),
                Description: getDoc(program, e) ?? "",
                IsExtensible: !isFixed(program, e),
                IsNullable: false
            } as InputEnumType;
            setUsage(context, e, enumType);
            if (addToCollection) enums.set(name, enumType);
        }
        return enumType;

        function enumMemberType(member: EnumMember): string {
            if (typeof member.value === "number") {
                return "Float32";
            }
            return "String";
        }
    }

    function getInputTypeForArray(elementType: Type): InputListType {
        return {
            Name: "Array",
            ElementType: getInputType(
                context,
                getFormattedType(program, elementType),
                models,
                enums
            ),
            IsNullable: false
        } as InputListType;
    }

    function getInputTypeForMap(key: Type, value: Type): InputDictionaryType {
        return {
            Name: "Dictionary",
            KeyType: getInputType(
                context,
                getFormattedType(program, key),
                models,
                enums
            ),
            ValueType: getInputType(
                context,
                getFormattedType(program, value),
                models,
                enums
            ),
            IsNullable: false
        } as InputDictionaryType;
    }

    function getInputModelForModel(m: Model): InputModelType {
        m = getEffectiveSchemaType(context, m) as Model;
        const name = getTypeName(context, m);
        let model = models.get(name);
        if (!model) {
            const baseModel = getInputModelBaseType(m.baseModel);
            const properties: InputModelProperty[] = [];

            const discriminator = getDiscriminator(program, m);
            model = {
                Name: name,
                Namespace: getFullNamespaceString(m.namespace),
                Accessibility: isInternal(context, m)
                    ? "internal"
                    : getAccess(context, m),
                Deprecated: getDeprecated(program, m),
                Description: getDoc(program, m),
                IsNullable: false,
                DiscriminatorPropertyName: discriminator?.propertyName,
                DiscriminatorValue: getDiscriminatorValue(m, baseModel),
                BaseModel: baseModel,
                Usage: Usage.None,
                Properties: properties // DerivedModels should be the last assigned to model, if no derived models, properties should be the last
            } as InputModelType;
            setUsage(context, m, model);

            // open generic type model which has un-instanced template parameter will not be generated. e.g.
            // model GenericModel<T> { value: T }
            if (m.isFinished) {
                models.set(name, model);
            }

            // Resolve properties after model is added to the map to resolve possible circular dependencies
            addModelProperties(model, m.properties, properties);

            // add the derived models into the list
            if (m.derivedModels !== undefined && m.derivedModels.length > 0) {
                model.DerivedModels = [];
                for (const dm of m.derivedModels) {
                    // skip open generic type model which has un-instanced template parameter. e.g.
                    // model GenericModel<T> { value: T }
                    if (dm.isFinished) {
                        const derivedModel = getInputType(
                            context,
                            getFormattedType(program, dm),
                            models,
                            enums
                        );
                        model.DerivedModels.push(
                            derivedModel as InputModelType
                        );
                    }
                }
            }
        }

        return model;
    }

    function getDiscriminatorValue(
        m: Model,
        baseModel?: InputModelType
    ): string | undefined {
        const discriminatorPropertyName = baseModel?.DiscriminatorPropertyName;

        if (discriminatorPropertyName) {
            const discriminatorProperty = m.properties.get(
                discriminatorPropertyName
            );
            if (
                discriminatorProperty?.type.kind === "String" ||
                // discriminator property cannot be number, but enum support number values
                // typespec compiler will do the check, but here we do a double check just in case
                (discriminatorProperty?.type.kind === "EnumMember" &&
                    typeof discriminatorProperty?.type.value !== "number")
            ) {
                return String(
                    discriminatorProperty.type.value ??
                        discriminatorProperty.type.name
                );
            }
        }

        return undefined;
    }

    function addModelProperties(
        model: InputModelType,
        inputProperties: Map<string, ModelProperty>,
        outputProperties: InputModelProperty[]
    ): void {
        let discriminatorPropertyDefined = false;
        inputProperties.forEach((value: ModelProperty, key: string) => {
            if (
                value.name !== model.BaseModel?.DiscriminatorPropertyName &&
                isSchemaProperty(context, value)
            ) {
                const vis = getVisibility(program, value);
                let isReadOnly: boolean = false;
                if (vis && vis.includes("read") && vis.length === 1) {
                    isReadOnly = true;
                }
                if (isNeverType(value.type) || isVoidType(value.type)) return;
                const name = getTypeName(context, value);
                const serializedName = getSerializeName(context, value);
                const literalTypeContext = {
                    ModelName: model.Name,
                    PropertyName: name,
                    Namespace: model.Namespace
                } as LiteralTypeContext;
                const inputType = getInputType(
                    context,
                    getFormattedType(program, value),
                    models,
                    enums,
                    literalTypeContext
                );
                if (
                    model.Namespace === "Azure.Core.Foundations" &&
                    model.Name === "Error" &&
                    isInputModelType(inputType)
                ) {
                    inputType.Accessibility = undefined;
                }
                const inputProp = {
                    Name: name,
                    SerializedName: serializedName,
                    Description: getDoc(program, value) ?? "",
                    Type: inputType,
                    IsRequired: !value.optional,
                    IsReadOnly: isReadOnly
                } as InputModelProperty;

                if (name === model.DiscriminatorPropertyName) {
                    inputProp.IsDiscriminator = true;
                    discriminatorPropertyDefined = true;
                }
                outputProperties.push(inputProp);
            }
        });

        if (model.DiscriminatorPropertyName && !discriminatorPropertyDefined) {
            logger.info(
                `No specified type for discriminator property '${model.DiscriminatorPropertyName}'. Assume it is a string.`
            );
            const discriminatorProperty = {
                Name: model.DiscriminatorPropertyName,
                SerializedName: model.DiscriminatorPropertyName,
                Description: "Discriminator",
                IsRequired: true,
                IsReadOnly: false,
                IsNullable: false,
                Type: {
                    Name: "string",
                    Kind: InputTypeKind.String,
                    IsNullable: false
                } as InputPrimitiveType,
                IsDiscriminator: true
            } as InputModelProperty;
            // put default discriminator property as the first property to keep previous behavior
            outputProperties.unshift(discriminatorProperty);
        }
    }
    function getInputModelBaseType(m?: Model): InputModelType | undefined {
        if (!m) {
            return undefined;
        }

        // Arrays and dictionaries can't be a base type
        if (m.indexer) {
            return undefined;
        }

        // TypeSpec "primitive" types can't be base types for models
        if (program.checker.isStdType(m)) {
            return undefined;
        }

        return getInputModelForModel(m);
    }

    function getFullNamespaceString(namespace: Namespace | undefined): string {
        if (!namespace || !namespace.name) {
            return "";
        }

        let namespaceString: string = namespace.name;
        let current: Namespace | undefined = namespace.namespace;
        while (current && current.name) {
            namespaceString = `${current.name}.${namespaceString}`;
            current = current.namespace;
        }
        return namespaceString;
    }

    function getInputModelForIntrinsicType(type: IntrinsicType): InputType {
        switch (type.name) {
            case "unknown":
                return {
                    Name: "Intrinsic",
                    Kind: "unknown",
                    IsNullable: false
                } as InputUnknownType;
            case "null":
                return {
                    Name: "Intrinsic",
                    Kind: "null",
                    IsNullable: false
                } as InputNullType;
            default:
                throw new Error(`Unsupported type ${type.name}`);
        }
    }

    function getInputTypeForUnion(union: Union): InputType {
        let ItemTypes: InputType[] = [];
        const variants = Array.from(union.variants.values());

        let hasNullType = false;
        for (const variant of variants) {
            const inputType = getInputType(
                context,
                getFormattedType(program, variant.type),
                models,
                enums
            );
            if (
                inputType.Name === "Intrinsic" &&
                (inputType as InputIntrinsicType).Kind === "null"
            ) {
                hasNullType = true;
                continue;
            }
            ItemTypes.push(inputType);
        }

        if (hasNullType) {
            ItemTypes = ItemTypes.map((i) => {
                i.IsNullable = true;
                return i;
            });
        }

        return ItemTypes.length > 1
            ? ({
                  Name: "Union",
                  UnionItemTypes: ItemTypes,
                  IsNullable: false
              } as InputUnionType)
            : ItemTypes[0];
    }
}

function setUsage(
    context: SdkContext,
    source: Model | Enum,
    target: InputModelType | InputEnumType
) {
    const sourceUsage = getUsageOverride(context, source);
    if (sourceUsage === UsageFlags.Input) {
        target.Usage = Usage.Input;
    } else if (sourceUsage === UsageFlags.Output) {
        target.Usage = Usage.Output;
    } else if (sourceUsage === (UsageFlags.Input | UsageFlags.Output)) {
        target.Usage = Usage.RoundTrip;
    }
}

export function getUsages(
    context: SdkContext,
    ops?: HttpOperation[],
    modelMap?: Map<string, InputModelType>
): { inputs: string[]; outputs: string[]; roundTrips: string[] } {
    const program = context.program;
    const result: {
        inputs: string[];
        outputs: string[];
        roundTrips: string[];
    } = { inputs: [], outputs: [], roundTrips: [] };
    if (!ops) {
        return result;
    }

    const operations: Operation[] = ops.map((op) => op.operation);
    const usages = resolveUsages(operations);
    const usagesMap: Map<string, UsageFlags> = new Map<string, UsageFlags>();
    for (const type of usages.types) {
        let typeName = "";
        if ("name" in type) typeName = type.name ?? "";
        let effectiveType = type;
        if (type.kind === "Model") {
            effectiveType = getEffectiveSchemaType(context, type) as Model;
            typeName = getTypeName(context, effectiveType);
        }
        const affectTypes: Set<string> = new Set<string>();
        if (typeName !== "") {
            affectTypes.add(typeName);
            if (
                effectiveType.kind === "Model" &&
                (!modelMap || modelMap.has(typeName))
            ) {
                /*propagate to sub models and composite models*/
                getAllEffectedModels(effectiveType, new Set<string>()).forEach(
                    (element) => {
                        affectTypes.add(element);
                    }
                );
            }
        }

        for (const name of affectTypes) {
            let value = usagesMap.get(name);
            if (!value) value = UsageFlags.None;
            if (usages.isUsedAs(type, UsageFlags.Input))
                value = value | UsageFlags.Input;
            if (usages.isUsedAs(type, UsageFlags.Output))
                value = value | UsageFlags.Output;
            usagesMap.set(name, value);
        }
    }

    for (const op of ops) {
        const resourceOperation = getResourceOperation(program, op.operation);
        if (!op.parameters.body?.parameter && op.parameters.body?.type) {
            var effectiveBodyType = undefined;
            const affectTypes: Set<string> = new Set<string>();
            effectiveBodyType = getEffectiveSchemaType(
                context,
                op.parameters.body.type
            );
            if (effectiveBodyType.kind === "Model") {
                /* handle spread. */
                if (effectiveBodyType.name === "") {
                    effectiveBodyType.name = `${capitalize(
                        op.operation.name
                    )}Request`;
                }
            }
            if (effectiveBodyType.kind === "Model") {
                /*propagate to sub models and composite models*/
                getAllEffectedModels(
                    effectiveBodyType,
                    new Set<string>()
                ).forEach((element) => {
                    affectTypes.add(element);
                });
            }
            for (const name of affectTypes) {
                appendUsage(name, UsageFlags.Input);
            }
        }
        /* handle response type usage. */
        const affectedReturnTypes: Set<string> = new Set<string>();
        for (const res of op.responses) {
            const resBody = res.responses[0]?.body;
            if (resBody?.type) {
                let returnType = "";
                const effectiveReturnType = getEffectiveSchemaType(
                    context,
                    resBody.type
                );
                if (
                    effectiveReturnType.kind === "Model" &&
                    effectiveReturnType.name !== ""
                ) {
                    returnType = getTypeName(context, effectiveReturnType);
                }
                /*propagate to sub models and composite models*/
                if (effectiveReturnType.kind === "Model") {
                    getAllEffectedModels(
                        effectiveReturnType,
                        new Set<string>()
                    ).forEach((element) => {
                        affectedReturnTypes.add(element);
                    });
                }
                affectedReturnTypes.add(returnType);
                for (const name of affectedReturnTypes) {
                    appendUsage(name, UsageFlags.Output);
                }
            }
        }
    }

    // handle the types introduces by us
    if (modelMap) {
        // iterate all models to find if it contains literal type properties
        for (const [name, model] of modelMap) {
            // get the usage of this model
            let usage = usagesMap.get(name);
            for (const prop of model.Properties) {
                const type = prop.Type;
                if (!isInputLiteralType(type)) continue;
                // now type should be a literal type
                // find its corresponding enum type
                const literalValueType = type.LiteralValueType;
                if (!isInputEnumType(literalValueType)) continue;
                // now literalValueType should be an enum type
                // apply the usage on this model to the usagesMap
                appendUsage(literalValueType.Name, usage!);
            }
        }
    }

    for (const [key, value] of usagesMap) {
        if (value === (UsageFlags.Input | UsageFlags.Output)) {
            result.roundTrips.push(key);
        } else if (value === UsageFlags.Input) {
            result.inputs.push(key);
        } else if (value === UsageFlags.Output) {
            result.outputs.push(key);
        }
    }
    return result;

    function appendUsage(name: string, flag: UsageFlags) {
        let value = usagesMap.get(name);
        if (!value) value = flag;
        else value = value | flag;
        usagesMap.set(name, value);
    }

    function getAllEffectedModels(
        model: Model,
        visited: Set<string>
    ): string[] {
        const result: string[] = [];
        if (
            (isArrayModelType(program, model) ||
                isRecordModelType(program, model)) &&
            model.indexer.value.kind === "Model"
        ) {
            result.push(...getAllEffectedModels(model.indexer.value, visited));
        } else {
            const name = getTypeName(context, model);
            if (model.kind !== "Model" || visited.has(name)) return result;
            result.push(name);
            visited.add(name);
            const derivedModels = model.derivedModels;
            for (const derivedModel of derivedModels) {
                result.push(getTypeName(context, derivedModel));
                result.push(...getAllEffectedModels(derivedModel, visited));
            }
            for (const [_, prop] of model.properties) {
                if (prop.type.kind === "Model") {
                    result.push(...getAllEffectedModels(prop.type, visited));
                }
            }
        }

        return result;
    }
}

export function getFormattedType(program: Program, type: Type): FormattedType {
    let targetType = type;
    let format = getFormat(program, type);
    if (type.kind === "ModelProperty") {
        targetType = type.type;
    }
    let encodeData = undefined;
    if (type.kind === "Scalar" || type.kind === "ModelProperty") {
        encodeData = getEncode(program, type);
    }

    return {
        type: targetType,
        format: format,
        encode: encodeData
    } as FormattedType;
}

// This is a temporary solution. After we uptake getAllModels we should delete this.
export function navigateModels(
    context: SdkContext,
    namespace: Namespace,
    models: Map<string, InputModelType>,
    enums: Map<string, InputEnumType>
) {
    const computeModel = (x: Type) =>
        getInputType(
            context,
            getFormattedType(context.program, x),
            models,
            enums
        ) as any;
    const skipSubNamespaces = isGlobalNamespace(context.program, namespace);
    navigateTypesInNamespace(
        namespace,
        {
            model: (x) =>
                x.name !== "" && x.kind === "Model" && computeModel(x),
            enum: computeModel
        },
        { skipSubNamespaces }
    );
}
