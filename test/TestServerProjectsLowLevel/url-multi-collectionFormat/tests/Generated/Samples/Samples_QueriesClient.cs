// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;
using url_multi_collectionFormat_LowLevel;

namespace url_multi_collectionFormat_LowLevel.Samples
{
    public class Samples_QueriesClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ArrayStringMultiNull_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            QueriesClient client = new QueriesClient(credential);

            Response response = client.ArrayStringMultiNull();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ArrayStringMultiNull_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            QueriesClient client = new QueriesClient(credential);

            Response response = await client.ArrayStringMultiNullAsync();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ArrayStringMultiNull_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            QueriesClient client = new QueriesClient(credential);

            Response response = client.ArrayStringMultiNull(arrayQuery: new List<string>()
{
"<arrayQuery>"
});
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ArrayStringMultiNull_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            QueriesClient client = new QueriesClient(credential);

            Response response = await client.ArrayStringMultiNullAsync(arrayQuery: new List<string>()
{
"<arrayQuery>"
});
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ArrayStringMultiEmpty_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            QueriesClient client = new QueriesClient(credential);

            Response response = client.ArrayStringMultiEmpty();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ArrayStringMultiEmpty_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            QueriesClient client = new QueriesClient(credential);

            Response response = await client.ArrayStringMultiEmptyAsync();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ArrayStringMultiEmpty_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            QueriesClient client = new QueriesClient(credential);

            Response response = client.ArrayStringMultiEmpty(arrayQuery: new List<string>()
{
"<arrayQuery>"
});
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ArrayStringMultiEmpty_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            QueriesClient client = new QueriesClient(credential);

            Response response = await client.ArrayStringMultiEmptyAsync(arrayQuery: new List<string>()
{
"<arrayQuery>"
});
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ArrayStringMultiValid_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            QueriesClient client = new QueriesClient(credential);

            Response response = client.ArrayStringMultiValid();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ArrayStringMultiValid_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            QueriesClient client = new QueriesClient(credential);

            Response response = await client.ArrayStringMultiValidAsync();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ArrayStringMultiValid_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            QueriesClient client = new QueriesClient(credential);

            Response response = client.ArrayStringMultiValid(arrayQuery: new List<string>()
{
"<arrayQuery>"
});
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ArrayStringMultiValid_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            QueriesClient client = new QueriesClient(credential);

            Response response = await client.ArrayStringMultiValidAsync(arrayQuery: new List<string>()
{
"<arrayQuery>"
});
            Console.WriteLine(response.Status);
        }
    }
}
