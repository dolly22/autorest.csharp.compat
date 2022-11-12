// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using AutoRest.TestServer.Tests.Infrastructure;
using Azure;
using NUnit.Framework;
using xms_error_responses;
using xms_error_responses.Models;

namespace AutoRest.TestServer.Tests
{
    public class XMsErrorResponsesTest : TestServerTestBase
    {
        [Test]
        public Task AnimalNotFoundError() => Test((host, pipeline) =>
        {
            var value = "coyoteUgly";
            var exception = Assert.ThrowsAsync<RequestFailedException<NotFoundErrorBase>>(async () => await new PetClient(ClientDiagnostics, pipeline, host).GetPetByIdAsync(value));
            Assert.AreEqual(404, exception.Status);

            Assert.NotNull(exception.Model);
            Assert.IsAssignableFrom<AnimalNotFound>(exception.Model, "Must be assignable from AnimalNotFound");

            if (exception.Model is AnimalNotFound notFound)
            {
                Assert.AreEqual("problem finding animal", notFound.SomeBaseProp);
                Assert.AreEqual("the type of animal requested is not available", notFound.Reason);
                Assert.AreEqual("coyote", notFound.Name);
                Assert.AreEqual("AnimalNotFound", notFound.WhatNotFound);
            }
        });

        [Test]
        public Task ExpectedNoErrors() => Test(async (host, pipeline) =>
        {
            var value = "tommy";
            var petResponse = await new PetClient(ClientDiagnostics, pipeline, host).GetPetByIdAsync(value);
            Assert.AreEqual(200, petResponse.GetRawResponse().Status);
            Assert.AreEqual("Tommy Tomson", petResponse.Value.Name);
            Assert.AreEqual("Dog", petResponse.Value.AniType);

            value = "stay";
            var petActionResponse = await new PetClient(ClientDiagnostics, pipeline, host).DoSomethingAsync(value);
            Assert.AreEqual(200, petActionResponse.GetRawResponse().Status);
            Assert.IsNull(petActionResponse.Value.ActionResponse);
        });

        [Test]
        public Task ExpectedPetHungryError() => Test((host, pipeline) =>
        {
            var value = "fetch";
            var exception = Assert.ThrowsAsync<RequestFailedException<PetActionError>>(async () => await new PetClient(ClientDiagnostics, pipeline, host).DoSomethingAsync(value));
            Assert.AreEqual(404, exception.Status);

            Assert.NotNull(exception.Model);
            Assert.IsAssignableFrom<PetHungryOrThirstyError>(exception.Model, "Must be assignable from PetHungryOrThirstyError");

            if (exception.Model is PetHungryOrThirstyError hungryOrThirstyError)
            {
                Assert.AreEqual("howl", hungryOrThirstyError.ActionResponse);
                Assert.AreEqual("PetHungryOrThirstyError", hungryOrThirstyError.ErrorType);
                Assert.AreEqual("scooby is low", hungryOrThirstyError.ErrorMessage);
                Assert.AreEqual("need more everything", hungryOrThirstyError.Reason);
                Assert.AreEqual("hungry and thirsty", hungryOrThirstyError.HungryOrThirsty);
            }
        });

        [Test]
        public Task ExpectedPetSadError() => Test((host, pipeline) =>
        {
            var value = "jump";
            var exception = Assert.ThrowsAsync<RequestFailedException<PetActionError>>(async () => await new PetClient(ClientDiagnostics, pipeline, host).DoSomethingAsync(value));
            Assert.AreEqual(500, exception.Status);

            Assert.NotNull(exception.Model);
            Assert.IsAssignableFrom<PetSadError>(exception.Model, "Must be assignable from PetSadError");

            if (exception.Model is PetSadError petSadError)
            {
                Assert.AreEqual("grrrr", petSadError.ActionResponse);
                Assert.AreEqual("PetSadError", petSadError.ErrorType);
                Assert.AreEqual("casper aint happy", petSadError.ErrorMessage);
                Assert.AreEqual("need more treats", petSadError.Reason);
            }
        });

        [Test]
        public Task IntError() => Test((host, pipeline) =>
        {
            var value = "alien123";
            var exception = Assert.ThrowsAsync<RequestFailedException<int>>(async () => await new PetClient(ClientDiagnostics, pipeline, host).GetPetByIdAsync(value));
            Assert.AreEqual(501, exception.Status);

            Assert.AreEqual(typeof(int), exception.Model.GetType());
            Assert.AreEqual(123, exception.Model);
        });

        [Test]
        public Task LinkNotFoundError() => Test((host, pipeline) =>
        {
            var value = "weirdAlYankovic";
            var exception = Assert.ThrowsAsync<RequestFailedException<NotFoundErrorBase>>(async () => await new PetClient(ClientDiagnostics, pipeline, host).GetPetByIdAsync(value));
            Assert.AreEqual(404, exception.Status);

            Assert.NotNull(exception.Model);
            Assert.IsAssignableFrom<LinkNotFound>(exception.Model, "Must be assignable from LinkNotFound");

            if (exception.Model is LinkNotFound linkNotFound)
            {
                Assert.AreEqual("problem finding pet", linkNotFound.SomeBaseProp);
                Assert.AreEqual("link to pet not found", linkNotFound.Reason);
                Assert.AreEqual("pet/yourpet was not found", linkNotFound.WhatSubAddress);
                Assert.AreEqual("InvalidResourceLink", linkNotFound.WhatNotFound);
            }
        });

        [Test]
        public Task StringError() => Test((host, pipeline) =>
        {
            var value = "ringo";
            var content = $"{value} is missing";
            var exception = Assert.ThrowsAsync<RequestFailedException<string>>(async () => await new PetClient(ClientDiagnostics, pipeline, host).GetPetByIdAsync(value));
            Assert.AreEqual(400, exception.Status);

            Assert.AreEqual(typeof(string), exception.Model.GetType());
            Assert.AreEqual(content, exception.Model);
        });

        [Test]
        public Task SendErrorWithParamNameModels() => Test((host, pipeline) =>
        {
            var exception = Assert.ThrowsAsync<RequestFailedException<PetActionError>>(async () => await new PetClient(ClientDiagnostics, pipeline, host).HasModelsParamAsync());
            Assert.AreEqual(500, exception.Status);

            Assert.NotNull(exception.Model);
            Assert.IsAssignableFrom<PetSadError>(exception.Model, "Must be assignable from PetSadError");

            if (exception.Model is PetSadError petSadError)
            {
                Assert.AreEqual("grrrr", petSadError.ActionResponse);
                Assert.AreEqual("PetSadError", petSadError.ErrorType);
                Assert.AreEqual("casper aint happy", petSadError.ErrorMessage);
                Assert.AreEqual("need more treats", petSadError.Reason);
            }
        });
    }
}
