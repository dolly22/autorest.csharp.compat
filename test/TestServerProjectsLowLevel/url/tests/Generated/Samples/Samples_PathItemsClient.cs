// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;
using url_LowLevel;

namespace url_LowLevel.Samples
{
    public class Samples_PathItemsClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllWithValues_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = client.GetAllWithValues("<pathItemStringPath>", "<localStringPath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllWithValues_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = await client.GetAllWithValuesAsync("<pathItemStringPath>", "<localStringPath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllWithValues_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = client.GetAllWithValues("<pathItemStringPath>", "<localStringPath>", pathItemStringQuery: "<pathItemStringQuery>", localStringQuery: "<localStringQuery>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllWithValues_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = await client.GetAllWithValuesAsync("<pathItemStringPath>", "<localStringPath>", pathItemStringQuery: "<pathItemStringQuery>", localStringQuery: "<localStringQuery>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetGlobalQueryNull_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = client.GetGlobalQueryNull("<pathItemStringPath>", "<localStringPath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetGlobalQueryNull_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = await client.GetGlobalQueryNullAsync("<pathItemStringPath>", "<localStringPath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetGlobalQueryNull_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = client.GetGlobalQueryNull("<pathItemStringPath>", "<localStringPath>", pathItemStringQuery: "<pathItemStringQuery>", localStringQuery: "<localStringQuery>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetGlobalQueryNull_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = await client.GetGlobalQueryNullAsync("<pathItemStringPath>", "<localStringPath>", pathItemStringQuery: "<pathItemStringQuery>", localStringQuery: "<localStringQuery>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetGlobalAndLocalQueryNull_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = client.GetGlobalAndLocalQueryNull("<pathItemStringPath>", "<localStringPath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetGlobalAndLocalQueryNull_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = await client.GetGlobalAndLocalQueryNullAsync("<pathItemStringPath>", "<localStringPath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetGlobalAndLocalQueryNull_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = client.GetGlobalAndLocalQueryNull("<pathItemStringPath>", "<localStringPath>", pathItemStringQuery: "<pathItemStringQuery>", localStringQuery: "<localStringQuery>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetGlobalAndLocalQueryNull_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = await client.GetGlobalAndLocalQueryNullAsync("<pathItemStringPath>", "<localStringPath>", pathItemStringQuery: "<pathItemStringQuery>", localStringQuery: "<localStringQuery>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetLocalPathItemQueryNull_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = client.GetLocalPathItemQueryNull("<pathItemStringPath>", "<localStringPath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetLocalPathItemQueryNull_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = await client.GetLocalPathItemQueryNullAsync("<pathItemStringPath>", "<localStringPath>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetLocalPathItemQueryNull_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = client.GetLocalPathItemQueryNull("<pathItemStringPath>", "<localStringPath>", pathItemStringQuery: "<pathItemStringQuery>", localStringQuery: "<localStringQuery>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetLocalPathItemQueryNull_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            PathItemsClient client = new PathItemsClient("<GlobalStringPath>", credential);

            Response response = await client.GetLocalPathItemQueryNullAsync("<pathItemStringPath>", "<localStringPath>", pathItemStringQuery: "<pathItemStringQuery>", localStringQuery: "<localStringQuery>");
            Console.WriteLine(response.Status);
        }
    }
}
