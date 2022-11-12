// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Linq;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Requests;
using AutoRest.CSharp.Output.Models.Responses;
using AutoRest.CSharp.Output.Models.Shared;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AutoRest.CSharp.Generation.Writers
{
    internal static class ResponseWriterHelpers
    {
        public static void WriteStatusCodeSwitch(CodeWriter writer, string messageVariableName, RestClientMethod operation, bool async, FieldDeclaration? clientDiagnosticsField)
        {
            string responseVariable = $"{messageVariableName}.Response";

            var returnType = operation.ReturnType;
            var headersModelType = operation.HeaderModel?.Type;

            ReturnKind kind;

            if (returnType != null && headersModelType != null)
            {
                kind = ReturnKind.HeadersAndValue;
            }
            else if (headersModelType != null)
            {
                kind = ReturnKind.Headers;
            }
            else if (returnType != null)
            {
                kind = ReturnKind.Value;
            }
            else
            {
                kind = ReturnKind.Response;
            }

            if (headersModelType != null)
            {
                writer.Line($"var headers = new {headersModelType}({responseVariable});");
            }

            using (writer.Scope($"switch ({responseVariable}.Status)"))
            {
                // We process default error response (represented as status code = 0) as last
                // to levarage existing code generation without refactoring to much code.
                var orderedResponses = operation.Responses.OrderBy(r => r.StatusCodes.All(c => c.Code == 0) ? 1 : 0);
                var defaultResponseDone = false;

                foreach (var response in orderedResponses)
                {
                    var responseBody = response.ResponseBody;
                    var statusCodes = response.StatusCodes;

                    foreach (var statusCode in statusCodes)
                    {
                        if (statusCode.Code != null)
                        {
                            if (statusCode.Code == 0)
                            {
                                writer.Line($"default:");
                                defaultResponseDone = true;
                            }
                            else
                                writer.Line($"case {statusCode.Code}:");
                        }
                        else
                        {
                            writer.Line($"case int s when s >= {statusCode.Family * 100:L} && s < {statusCode.Family * 100 + 100:L}:");
                        }
                    }

                    using (responseBody != null ? writer.Scope() : default)
                    {
                        ReferenceOrConstant value = default;

                        var valueVariable = new CodeWriterDeclaration("value");
                        switch (responseBody)
                        {
                            case ObjectResponseBody objectResponseBody:
                                writer.Line($"{responseBody.Type} {valueVariable:D} = default;");
                                writer.WriteDeserializationForMethods(
                                    objectResponseBody.Serialization,
                                    async,
                                    v => writer.Line($"{valueVariable} = {v};"),
                                    responseVariable,
                                    objectResponseBody.Type);
                                value = new Reference(valueVariable.ActualName, responseBody.Type);
                                break;
                            case StreamResponseBody _:
                                writer.Line($"var {valueVariable:D} = {messageVariableName}.ExtractResponseContent();");
                                value = new Reference(valueVariable.ActualName, responseBody.Type);
                                break;
                            case ConstantResponseBody body:
                                writer.Append($"{returnType} {valueVariable:D} = ");
                                writer.WriteReferenceOrConstant(body.Value);
                                writer.Line($";");
                                value = new Reference(valueVariable.ActualName, responseBody.Type);
                                break;
                            case StringResponseBody _:
                                var streamReaderVariable = new CodeWriterDeclaration("streamReader");
                                writer.Line($"{typeof(StreamReader)} {streamReaderVariable:D} = new {typeof(StreamReader)}({messageVariableName}.Response.ContentStream);");
                                writer.Append($"{returnType} {valueVariable:D} = ");
                                if (async)
                                {
                                    writer.Line($"await {streamReaderVariable}.ReadToEndAsync().ConfigureAwait(false);");
                                }
                                else
                                {
                                    writer.Line($"{streamReaderVariable}.ReadToEnd();");
                                }
                                value = new Reference(valueVariable.ActualName, responseBody.Type);
                                break;
                            default:
                                {
                                    if (returnType != null)
                                    {
                                        value = Constant.Default(returnType.WithNullable(true));
                                    }

                                    break;
                                }
                        }

                        // Error responses are retuned as thrown exceptions
                        if (response.IsErrorResponse)
                        {
                            switch (responseBody)
                            {
                                case ObjectResponseBody objectResponseBody:
                                    writer.Append($"throw ErrorResponseExceptionFactory.Create<{value.Type}>(");
                                    writer.WriteReferenceOrConstant(value);
                                    writer.Line($", {responseVariable});");
                                    break;

                                default:
                                    throw new InvalidOperationException("Error response must by of ObjectResponseBody type");
                            }
                            continue;
                        }

                        switch (kind)
                        {
                            case ReturnKind.Response:
                                writer.Append($"return {responseVariable};");
                                break;
                            case ReturnKind.Headers:
                                writer.Append($"return {typeof(ResponseWithHeaders)}.FromValue(headers, {responseVariable});");
                                break;
                            case ReturnKind.HeadersAndValue:
                                writer.Append($"return {typeof(ResponseWithHeaders)}.FromValue");
                                if (!Equals(responseBody?.Type, operation.ReturnType))
                                {
                                    writer.Append($"<{operation.ReturnType}, {headersModelType}>");
                                }
                                writer.Append($"(");
                                writer.WriteReferenceOrConstant(value);
                                writer.Append($", headers, {responseVariable});");
                                break;
                            case ReturnKind.Value:
                                writer.Append($"return {typeof(Azure.Response)}.FromValue");
                                if (!Equals(responseBody?.Type, operation.ReturnType))
                                {
                                    writer.Append($"<{operation.ReturnType}>");
                                }
                                writer.Append($"(");
                                writer.WriteReferenceOrConstant(value);
                                writer.Append($", {responseVariable});");
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }
                }

                // Default case already written, no need to continue
                if (defaultResponseDone)
                    return;

                if (clientDiagnosticsField != null)
                {
                    writer.Line($"default:");
                    if (async)
                    {
                        writer.Line($"throw await {clientDiagnosticsField.Name}.{nameof(ClientDiagnostics.CreateRequestFailedExceptionAsync)}({responseVariable}).ConfigureAwait(false);");
                    }
                    else
                    {
                        writer.Line($"throw {clientDiagnosticsField.Name}.{nameof(ClientDiagnostics.CreateRequestFailedException)}({responseVariable});");
                    }
                }
                else
                {
                    writer
                        .Line($"default:")
                        .Line($"throw new {typeof(RequestFailedException)}({responseVariable});");
                }
            }
        }

        private enum ReturnKind
        {
            Response,
            Headers,
            HeadersAndValue,
            Value
        }
    }
}
