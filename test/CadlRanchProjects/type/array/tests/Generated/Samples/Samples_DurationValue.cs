// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using _Type._Array;

namespace _Type._Array.Samples
{
    public partial class Samples_DurationValue
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDurationValue_ShortVersion()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            Response response = client.GetDurationValue(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDurationValue_ShortVersion_Async()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            Response response = await client.GetDurationValueAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDurationValue_ShortVersion_Convenience()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<TimeSpan>> response = client.GetDurationValue();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDurationValue_ShortVersion_Convenience_Async()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<TimeSpan>> response = await client.GetDurationValueAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDurationValue_AllParameters()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            Response response = client.GetDurationValue(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDurationValue_AllParameters_Async()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            Response response = await client.GetDurationValueAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDurationValue_AllParameters_Convenience()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<TimeSpan>> response = client.GetDurationValue();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDurationValue_AllParameters_Convenience_Async()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<TimeSpan>> response = await client.GetDurationValueAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_ShortVersion()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object[]
            {
"PT1H23M45S"
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_ShortVersion_Async()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object[]
            {
"PT1H23M45S"
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_ShortVersion_Convenience()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            Response response = client.Put(new TimeSpan[] { XmlConvert.ToTimeSpan("PT1H23M45S") });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_ShortVersion_Convenience_Async()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            Response response = await client.PutAsync(new TimeSpan[] { XmlConvert.ToTimeSpan("PT1H23M45S") });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object[]
            {
"PT1H23M45S"
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Async()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object[]
            {
"PT1H23M45S"
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters_Convenience()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            Response response = client.Put(new TimeSpan[] { XmlConvert.ToTimeSpan("PT1H23M45S") });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Convenience_Async()
        {
            DurationValue client = new ArrayClient().GetDurationValueClient(apiVersion: "1.0.0");

            Response response = await client.PutAsync(new TimeSpan[] { XmlConvert.ToTimeSpan("PT1H23M45S") });
        }
    }
}
