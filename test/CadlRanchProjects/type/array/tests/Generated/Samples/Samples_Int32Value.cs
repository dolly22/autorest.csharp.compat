// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using _Type._Array;

namespace _Type._Array.Samples
{
    internal class Samples_Int32Value
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetInt32Value()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            Response response = client.GetInt32Value(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetInt32Value_Async()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            Response response = await client.GetInt32ValueAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetInt32Value_Convenience()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<int>> response = client.GetInt32Value();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetInt32Value_Convenience_Async()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<int>> response = await client.GetInt32ValueAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetInt32Value_AllParameters()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            Response response = client.GetInt32Value(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetInt32Value_AllParameters_Async()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            Response response = await client.GetInt32ValueAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetInt32Value_AllParameters_Convenience()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<int>> response = client.GetInt32Value();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetInt32Value_AllParameters_Convenience_Async()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<int>> response = await client.GetInt32ValueAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new List<object>()
{
1234
});
            Response response = client.Put(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_Async()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new List<object>()
{
1234
});
            Response response = await client.PutAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_Convenience()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            Response response = client.Put(new List<int>()
{
1234
});
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_Convenience_Async()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            Response response = await client.PutAsync(new List<int>()
{
1234
});
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new List<object>()
{
1234
});
            Response response = client.Put(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Async()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new List<object>()
{
1234
});
            Response response = await client.PutAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters_Convenience()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            Response response = client.Put(new List<int>()
{
1234
});
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Convenience_Async()
        {
            Int32Value client = new ArrayClient().GetInt32ValueClient(apiVersion: "1.0.0");

            Response response = await client.PutAsync(new List<int>()
{
1234
});
            Console.WriteLine(response.Status);
        }
    }
}
