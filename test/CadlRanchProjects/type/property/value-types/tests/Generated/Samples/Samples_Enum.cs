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
using _Type.Property.ValueTypes;
using _Type.Property.ValueTypes.Models;

namespace _Type.Property.ValueTypes.Samples
{
    public partial class Samples_Enum
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetEnum_ShortVersion()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            Response response = client.GetEnum(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetEnum_ShortVersion_Async()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            Response response = await client.GetEnumAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetEnum_ShortVersion_Convenience()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            Response<EnumProperty> response = client.GetEnum();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetEnum_ShortVersion_Convenience_Async()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            Response<EnumProperty> response = await client.GetEnumAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetEnum_AllParameters()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            Response response = client.GetEnum(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetEnum_AllParameters_Async()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            Response response = await client.GetEnumAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetEnum_AllParameters_Convenience()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            Response<EnumProperty> response = client.GetEnum();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetEnum_AllParameters_Convenience_Async()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            Response<EnumProperty> response = await client.GetEnumAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_ShortVersion()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = "ValueOne",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_ShortVersion_Async()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = "ValueOne",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_ShortVersion_Convenience()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            EnumProperty body = new EnumProperty(FixedInnerEnum.ValueOne);
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_ShortVersion_Convenience_Async()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            EnumProperty body = new EnumProperty(FixedInnerEnum.ValueOne);
            Response response = await client.PutAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = "ValueOne",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Async()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = "ValueOne",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters_Convenience()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            EnumProperty body = new EnumProperty(FixedInnerEnum.ValueOne);
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Convenience_Async()
        {
            Enum client = new ValueTypesClient().GetEnumClient(apiVersion: "1.0.0");

            EnumProperty body = new EnumProperty(FixedInnerEnum.ValueOne);
            Response response = await client.PutAsync(body);
        }
    }
}
