// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;
using _Specs_.Azure.ClientGenerator.Core.Access;
using _Specs_.Azure.ClientGenerator.Core.Access.Models;

namespace _Specs_.Azure.ClientGenerator.Core.Access.Samples
{
    public partial class Samples_PublicOperation
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NoDecoratorInPublic_ShortVersion()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response response = client.NoDecoratorInPublic("<name>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NoDecoratorInPublic_ShortVersion_Async()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response response = await client.NoDecoratorInPublicAsync("<name>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NoDecoratorInPublic_ShortVersion_Convenience()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response<NoDecoratorModelInPublic> response = client.NoDecoratorInPublic("<name>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NoDecoratorInPublic_ShortVersion_Convenience_Async()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response<NoDecoratorModelInPublic> response = await client.NoDecoratorInPublicAsync("<name>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NoDecoratorInPublic_AllParameters()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response response = client.NoDecoratorInPublic("<name>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NoDecoratorInPublic_AllParameters_Async()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response response = await client.NoDecoratorInPublicAsync("<name>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NoDecoratorInPublic_AllParameters_Convenience()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response<NoDecoratorModelInPublic> response = client.NoDecoratorInPublic("<name>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NoDecoratorInPublic_AllParameters_Convenience_Async()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response<NoDecoratorModelInPublic> response = await client.NoDecoratorInPublicAsync("<name>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PublicDecoratorInPublic_ShortVersion()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response response = client.PublicDecoratorInPublic("<name>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PublicDecoratorInPublic_ShortVersion_Async()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response response = await client.PublicDecoratorInPublicAsync("<name>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PublicDecoratorInPublic_ShortVersion_Convenience()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response<PublicDecoratorModelInPublic> response = client.PublicDecoratorInPublic("<name>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PublicDecoratorInPublic_ShortVersion_Convenience_Async()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response<PublicDecoratorModelInPublic> response = await client.PublicDecoratorInPublicAsync("<name>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PublicDecoratorInPublic_AllParameters()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response response = client.PublicDecoratorInPublic("<name>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PublicDecoratorInPublic_AllParameters_Async()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response response = await client.PublicDecoratorInPublicAsync("<name>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PublicDecoratorInPublic_AllParameters_Convenience()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response<PublicDecoratorModelInPublic> response = client.PublicDecoratorInPublic("<name>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PublicDecoratorInPublic_AllParameters_Convenience_Async()
        {
            PublicOperation client = new AccessClient().GetPublicOperationClient(apiVersion: "1.0.0");

            Response<PublicDecoratorModelInPublic> response = await client.PublicDecoratorInPublicAsync("<name>");
        }
    }
}
