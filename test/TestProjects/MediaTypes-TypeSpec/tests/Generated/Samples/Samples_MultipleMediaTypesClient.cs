// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using MultipleMediaTypes;
using MultipleMediaTypes.Models;
using NUnit.Framework;

namespace MultipleMediaTypes.Samples
{
    public class Samples_MultipleMediaTypesClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OneBinaryBodyTwoContentTypes_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            RequestContent content = RequestContent.Create(new object());
            Response response = client.OneBinaryBodyTwoContentTypes(content, new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OneBinaryBodyTwoContentTypes_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            RequestContent content = RequestContent.Create(new object());
            Response response = await client.OneBinaryBodyTwoContentTypesAsync(content, new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OneBinaryBodyTwoContentTypes_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            Response response = client.OneBinaryBodyTwoContentTypes(BinaryData.FromObjectAsJson(new object()), new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OneBinaryBodyTwoContentTypes_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            Response response = await client.OneBinaryBodyTwoContentTypesAsync(BinaryData.FromObjectAsJson(new object()), new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OneBinaryBodyTwoContentTypes_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            RequestContent content = RequestContent.Create(new object());
            Response response = client.OneBinaryBodyTwoContentTypes(content, new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OneBinaryBodyTwoContentTypes_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            RequestContent content = RequestContent.Create(new object());
            Response response = await client.OneBinaryBodyTwoContentTypesAsync(content, new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OneBinaryBodyTwoContentTypes_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            Response response = client.OneBinaryBodyTwoContentTypes(BinaryData.FromObjectAsJson(new object()), new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OneBinaryBodyTwoContentTypes_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            Response response = await client.OneBinaryBodyTwoContentTypesAsync(BinaryData.FromObjectAsJson(new object()), new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OneStringBodyThreeContentTypes_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            RequestContent content = RequestContent.Create("<body>");
            Response response = client.OneStringBodyThreeContentTypes(content, new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OneStringBodyThreeContentTypes_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            RequestContent content = RequestContent.Create("<body>");
            Response response = await client.OneStringBodyThreeContentTypesAsync(content, new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OneStringBodyThreeContentTypes_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            Response response = client.OneStringBodyThreeContentTypes("<body>", new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OneStringBodyThreeContentTypes_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            Response response = await client.OneStringBodyThreeContentTypesAsync("<body>", new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OneStringBodyThreeContentTypes_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            RequestContent content = RequestContent.Create("<body>");
            Response response = client.OneStringBodyThreeContentTypes(content, new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OneStringBodyThreeContentTypes_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            RequestContent content = RequestContent.Create("<body>");
            Response response = await client.OneStringBodyThreeContentTypesAsync(content, new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OneStringBodyThreeContentTypes_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            Response response = client.OneStringBodyThreeContentTypes("<body>", new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OneStringBodyThreeContentTypes_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            Response response = await client.OneStringBodyThreeContentTypesAsync("<body>", new ContentType("application/json"));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OneModelBodyOneContentType_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
            });
            Response response = client.OneModelBodyOneContentType(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OneModelBodyOneContentType_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
            });
            Response response = await client.OneModelBodyOneContentTypeAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OneModelBodyOneContentType_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            Body body = new Body("<id>");
            Response response = client.OneModelBodyOneContentType(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OneModelBodyOneContentType_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            Body body = new Body("<id>");
            Response response = await client.OneModelBodyOneContentTypeAsync(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OneModelBodyOneContentType_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
            });
            Response response = client.OneModelBodyOneContentType(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OneModelBodyOneContentType_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
            });
            Response response = await client.OneModelBodyOneContentTypeAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OneModelBodyOneContentType_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            Body body = new Body("<id>");
            Response response = client.OneModelBodyOneContentType(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OneModelBodyOneContentType_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            MultipleMediaTypesClient client = new MultipleMediaTypesClient(endpoint);

            Body body = new Body("<id>");
            Response response = await client.OneModelBodyOneContentTypeAsync(body);
            Console.WriteLine(response.Status);
        }
    }
}
