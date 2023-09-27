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
using custom_baseUrl_paging_LowLevel;

namespace custom_baseUrl_paging_LowLevel.Samples
{
    public class Samples_PagingClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPagesPartialUrl_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PagingClient client = new PagingClient("host", credential);

            foreach (BinaryData item in client.GetPagesPartialUrl("<accountName>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPagesPartialUrl_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PagingClient client = new PagingClient("host", credential);

            await foreach (BinaryData item in client.GetPagesPartialUrlAsync("<accountName>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPagesPartialUrl_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PagingClient client = new PagingClient("host", credential);

            foreach (BinaryData item in client.GetPagesPartialUrl("<accountName>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPagesPartialUrl_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PagingClient client = new PagingClient("host", credential);

            await foreach (BinaryData item in client.GetPagesPartialUrlAsync("<accountName>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPagesPartialUrlOperation_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PagingClient client = new PagingClient("host", credential);

            foreach (BinaryData item in client.GetPagesPartialUrlOperation("<accountName>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPagesPartialUrlOperation_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PagingClient client = new PagingClient("host", credential);

            await foreach (BinaryData item in client.GetPagesPartialUrlOperationAsync("<accountName>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPagesPartialUrlOperation_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PagingClient client = new PagingClient("host", credential);

            foreach (BinaryData item in client.GetPagesPartialUrlOperation("<accountName>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPagesPartialUrlOperation_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PagingClient client = new PagingClient("host", credential);

            await foreach (BinaryData item in client.GetPagesPartialUrlOperationAsync("<accountName>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPagesPartialUrlOperationNext_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PagingClient client = new PagingClient("host", credential);

            foreach (BinaryData item in client.GetPagesPartialUrlOperationNext("<accountName>", "<nextLink>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPagesPartialUrlOperationNext_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PagingClient client = new PagingClient("host", credential);

            await foreach (BinaryData item in client.GetPagesPartialUrlOperationNextAsync("<accountName>", "<nextLink>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPagesPartialUrlOperationNext_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PagingClient client = new PagingClient("host", credential);

            foreach (BinaryData item in client.GetPagesPartialUrlOperationNext("<accountName>", "<nextLink>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPagesPartialUrlOperationNext_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PagingClient client = new PagingClient("host", credential);

            await foreach (BinaryData item in client.GetPagesPartialUrlOperationNextAsync("<accountName>", "<nextLink>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("name").ToString());
            }
        }
    }
}
