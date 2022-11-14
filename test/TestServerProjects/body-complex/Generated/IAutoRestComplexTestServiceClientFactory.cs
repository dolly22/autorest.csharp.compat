// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace body_complex
{
    public interface IAutoRestComplexTestServiceClientFactory
    {
        /// <summary> Creates BasicClient instance. </summary>
        IBasicClient Basic();

        /// <summary> Creates PrimitiveClient instance. </summary>
        IPrimitiveClient Primitive();

        /// <summary> Creates ArrayClient instance. </summary>
        IArrayClient Array();

        /// <summary> Creates DictionaryClient instance. </summary>
        IDictionaryClient Dictionary();

        /// <summary> Creates InheritanceClient instance. </summary>
        IInheritanceClient Inheritance();

        /// <summary> Creates PolymorphismClient instance. </summary>
        IPolymorphismClient Polymorphism();

        /// <summary> Creates PolymorphicrecursiveClient instance. </summary>
        IPolymorphicrecursiveClient Polymorphicrecursive();

        /// <summary> Creates ReadonlypropertyClient instance. </summary>
        IReadonlypropertyClient Readonlyproperty();

        /// <summary> Creates FlattencomplexClient instance. </summary>
        IFlattencomplexClient Flattencomplex();
    }
}
