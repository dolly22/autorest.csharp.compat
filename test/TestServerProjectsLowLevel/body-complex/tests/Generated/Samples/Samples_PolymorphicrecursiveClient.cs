// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using body_complex_LowLevel;

namespace body_complex_LowLevel.Samples
{
    public partial class Samples_PolymorphicrecursiveClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetValid_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PolymorphicrecursiveClient client = new PolymorphicrecursiveClient(credential);

            Response response = client.GetValid(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("fishtype").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetValid_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PolymorphicrecursiveClient client = new PolymorphicrecursiveClient(credential);

            Response response = await client.GetValidAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("fishtype").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetValid_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PolymorphicrecursiveClient client = new PolymorphicrecursiveClient(credential);

            Response response = client.GetValid(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("fishtype").ToString());
            Console.WriteLine(result.GetProperty("species").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
            Console.WriteLine(result.GetProperty("siblings")[0].GetProperty("fishtype").ToString());
            Console.WriteLine(result.GetProperty("siblings")[0].GetProperty("species").ToString());
            Console.WriteLine(result.GetProperty("siblings")[0].GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetValid_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PolymorphicrecursiveClient client = new PolymorphicrecursiveClient(credential);

            Response response = await client.GetValidAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("fishtype").ToString());
            Console.WriteLine(result.GetProperty("species").ToString());
            Console.WriteLine(result.GetProperty("length").ToString());
            Console.WriteLine(result.GetProperty("siblings")[0].GetProperty("fishtype").ToString());
            Console.WriteLine(result.GetProperty("siblings")[0].GetProperty("species").ToString());
            Console.WriteLine(result.GetProperty("siblings")[0].GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutValid_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PolymorphicrecursiveClient client = new PolymorphicrecursiveClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                fishtype = "salmon",
                length = 123.45F,
            });
            Response response = client.PutValid(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutValid_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PolymorphicrecursiveClient client = new PolymorphicrecursiveClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                fishtype = "salmon",
                length = 123.45F,
            });
            Response response = await client.PutValidAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutValid_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PolymorphicrecursiveClient client = new PolymorphicrecursiveClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                location = "<location>",
                iswild = true,
                fishtype = "salmon",
                species = "<species>",
                length = 123.45F,
                siblings = new object[]
            {
null
            },
            });
            Response response = client.PutValid(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutValid_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PolymorphicrecursiveClient client = new PolymorphicrecursiveClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                location = "<location>",
                iswild = true,
                fishtype = "salmon",
                species = "<species>",
                length = 123.45F,
                siblings = new object[]
            {
null
            },
            });
            Response response = await client.PutValidAsync(content);

            Console.WriteLine(response.Status);
        }
    }
}
