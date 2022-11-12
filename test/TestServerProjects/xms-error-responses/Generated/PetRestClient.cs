// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using xms_error_responses.Models;

namespace xms_error_responses
{
    internal partial class PetRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of PetRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public PetRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("http://localhost:3000");
        }

        internal HttpMessage CreateGetPetByIdRequest(string petId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/errorStatusCodes/Pets/", false);
            uri.AppendPath(petId, true);
            uri.AppendPath("/GetPet", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets pets by id. </summary>
        /// <param name="petId"> pet id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="petId"/> is null. </exception>
        public async Task<Response<Pet>> GetPetByIdAsync(string petId, CancellationToken cancellationToken = default)
        {
            if (petId == null)
            {
                throw new ArgumentNullException(nameof(petId));
            }

            using var message = CreateGetPetByIdRequest(petId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 400:
                    {
                        string value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = document.RootElement.GetString();
                        throw ErrorResponseExceptionFactory.Create(value, message.Response);
                    }
                case 404:
                    {
                        NotFoundErrorBase value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = NotFoundErrorBase.DeserializeNotFoundErrorBase(document.RootElement);
                        throw ErrorResponseExceptionFactory.Create(value, message.Response);
                    }
                case 501:
                    {
                        int value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = document.RootElement.GetInt32();
                        throw ErrorResponseExceptionFactory.Create(value, message.Response);
                    }
                case 200:
                    {
                        Pet value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Pet.DeserializePet(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 202:
                    return Response.FromValue((Pet)null, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets pets by id. </summary>
        /// <param name="petId"> pet id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="petId"/> is null. </exception>
        public Response<Pet> GetPetById(string petId, CancellationToken cancellationToken = default)
        {
            if (petId == null)
            {
                throw new ArgumentNullException(nameof(petId));
            }

            using var message = CreateGetPetByIdRequest(petId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 400:
                    {
                        string value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = document.RootElement.GetString();
                        throw ErrorResponseExceptionFactory.Create(value, message.Response);
                    }
                case 404:
                    {
                        NotFoundErrorBase value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = NotFoundErrorBase.DeserializeNotFoundErrorBase(document.RootElement);
                        throw ErrorResponseExceptionFactory.Create(value, message.Response);
                    }
                case 501:
                    {
                        int value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = document.RootElement.GetInt32();
                        throw ErrorResponseExceptionFactory.Create(value, message.Response);
                    }
                case 200:
                    {
                        Pet value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Pet.DeserializePet(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 202:
                    return Response.FromValue((Pet)null, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDoSomethingRequest(string whatAction)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/errorStatusCodes/Pets/doSomething/", false);
            uri.AppendPath(whatAction, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Asks pet to do something. </summary>
        /// <param name="whatAction"> what action the pet should do. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="whatAction"/> is null. </exception>
        public async Task<Response<PetAction>> DoSomethingAsync(string whatAction, CancellationToken cancellationToken = default)
        {
            if (whatAction == null)
            {
                throw new ArgumentNullException(nameof(whatAction));
            }

            using var message = CreateDoSomethingRequest(whatAction);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 500:
                    {
                        PetActionError value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PetActionError.DeserializePetActionError(document.RootElement);
                        throw ErrorResponseExceptionFactory.Create(value, message.Response);
                    }
                case 200:
                    {
                        PetAction value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PetAction.DeserializePetAction(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    {
                        PetActionError value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PetActionError.DeserializePetActionError(document.RootElement);
                        throw ErrorResponseExceptionFactory.Create(value, message.Response);
                    }
            }
        }

        /// <summary> Asks pet to do something. </summary>
        /// <param name="whatAction"> what action the pet should do. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="whatAction"/> is null. </exception>
        public Response<PetAction> DoSomething(string whatAction, CancellationToken cancellationToken = default)
        {
            if (whatAction == null)
            {
                throw new ArgumentNullException(nameof(whatAction));
            }

            using var message = CreateDoSomethingRequest(whatAction);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 500:
                    {
                        PetActionError value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PetActionError.DeserializePetActionError(document.RootElement);
                        throw ErrorResponseExceptionFactory.Create(value, message.Response);
                    }
                case 200:
                    {
                        PetAction value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PetAction.DeserializePetAction(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    {
                        PetActionError value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PetActionError.DeserializePetActionError(document.RootElement);
                        throw ErrorResponseExceptionFactory.Create(value, message.Response);
                    }
            }
        }

        internal HttpMessage CreateHasModelsParamRequest(string models)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/errorStatusCodes/Pets/hasModelsParam", false);
            if (models != null)
            {
                uri.AppendQuery("models", models, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Ensure you can correctly deserialize the returned PetActionError and deserialization doesn&apos;t conflict with the input param name &apos;models&apos;. </summary>
        /// <param name="models"> Make sure model deserialization doesn&apos;t conflict with this param name, which has input name &apos;models&apos;. Use client default value in call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> HasModelsParamAsync(string models = "value1", CancellationToken cancellationToken = default)
        {
            using var message = CreateHasModelsParamRequest(models);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 500:
                    {
                        PetActionError value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PetActionError.DeserializePetActionError(document.RootElement);
                        throw ErrorResponseExceptionFactory.Create(value, message.Response);
                    }
                case 200:
                    return message.Response;
                default:
                    {
                        PetActionError value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PetActionError.DeserializePetActionError(document.RootElement);
                        throw ErrorResponseExceptionFactory.Create(value, message.Response);
                    }
            }
        }

        /// <summary> Ensure you can correctly deserialize the returned PetActionError and deserialization doesn&apos;t conflict with the input param name &apos;models&apos;. </summary>
        /// <param name="models"> Make sure model deserialization doesn&apos;t conflict with this param name, which has input name &apos;models&apos;. Use client default value in call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response HasModelsParam(string models = "value1", CancellationToken cancellationToken = default)
        {
            using var message = CreateHasModelsParamRequest(models);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 500:
                    {
                        PetActionError value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PetActionError.DeserializePetActionError(document.RootElement);
                        throw ErrorResponseExceptionFactory.Create(value, message.Response);
                    }
                case 200:
                    return message.Response;
                default:
                    {
                        PetActionError value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PetActionError.DeserializePetActionError(document.RootElement);
                        throw ErrorResponseExceptionFactory.Create(value, message.Response);
                    }
            }
        }
    }
}
