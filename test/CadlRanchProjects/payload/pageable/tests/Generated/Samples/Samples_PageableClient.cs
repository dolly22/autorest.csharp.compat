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
using Payload.Pageable;
using Payload.Pageable.Models;

namespace Payload.Pageable.Samples
{
    public partial class Samples_PageableClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPageables_ShortVersion()
        {
            PageableClient client = new PageableClient();

            foreach (BinaryData item in client.GetPageables(null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPageables_ShortVersion_Async()
        {
            PageableClient client = new PageableClient();

            await foreach (BinaryData item in client.GetPageablesAsync(null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPageables_ShortVersion_Convenience()
        {
            PageableClient client = new PageableClient();

            foreach (User item in client.GetPageables())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPageables_ShortVersion_Convenience_Async()
        {
            PageableClient client = new PageableClient();

            await foreach (User item in client.GetPageablesAsync())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPageables_AllParameters()
        {
            PageableClient client = new PageableClient();

            foreach (BinaryData item in client.GetPageables(1234, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPageables_AllParameters_Async()
        {
            PageableClient client = new PageableClient();

            await foreach (BinaryData item in client.GetPageablesAsync(1234, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPageables_AllParameters_Convenience()
        {
            PageableClient client = new PageableClient();

            foreach (User item in client.GetPageables(maxpagesize: 1234))
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPageables_AllParameters_Convenience_Async()
        {
            PageableClient client = new PageableClient();

            await foreach (User item in client.GetPageablesAsync(maxpagesize: 1234))
            {
            }
        }
    }
}
