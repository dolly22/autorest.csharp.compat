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
using _Type.Model.Usage;
using _Type.Model.Usage.Models;

namespace _Type.Model.Usage.Samples
{
    public partial class Samples_UsageClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Input_ShortVersion()
        {
            UsageClient client = new UsageClient();

            RequestContent content = RequestContent.Create(new
            {
                requiredProp = "<requiredProp>",
            });
            Response response = client.Input(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Input_ShortVersion_Async()
        {
            UsageClient client = new UsageClient();

            RequestContent content = RequestContent.Create(new
            {
                requiredProp = "<requiredProp>",
            });
            Response response = await client.InputAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Input_ShortVersion_Convenience()
        {
            UsageClient client = new UsageClient();

            InputRecord input = new InputRecord("<requiredProp>");
            Response response = client.Input(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Input_ShortVersion_Convenience_Async()
        {
            UsageClient client = new UsageClient();

            InputRecord input = new InputRecord("<requiredProp>");
            Response response = await client.InputAsync(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Input_AllParameters()
        {
            UsageClient client = new UsageClient();

            RequestContent content = RequestContent.Create(new
            {
                requiredProp = "<requiredProp>",
            });
            Response response = client.Input(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Input_AllParameters_Async()
        {
            UsageClient client = new UsageClient();

            RequestContent content = RequestContent.Create(new
            {
                requiredProp = "<requiredProp>",
            });
            Response response = await client.InputAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Input_AllParameters_Convenience()
        {
            UsageClient client = new UsageClient();

            InputRecord input = new InputRecord("<requiredProp>");
            Response response = client.Input(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Input_AllParameters_Convenience_Async()
        {
            UsageClient client = new UsageClient();

            InputRecord input = new InputRecord("<requiredProp>");
            Response response = await client.InputAsync(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Output_ShortVersion()
        {
            UsageClient client = new UsageClient();

            Response response = client.Output(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("requiredProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Output_ShortVersion_Async()
        {
            UsageClient client = new UsageClient();

            Response response = await client.OutputAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("requiredProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Output_ShortVersion_Convenience()
        {
            UsageClient client = new UsageClient();

            Response<OutputRecord> response = client.Output();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Output_ShortVersion_Convenience_Async()
        {
            UsageClient client = new UsageClient();

            Response<OutputRecord> response = await client.OutputAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Output_AllParameters()
        {
            UsageClient client = new UsageClient();

            Response response = client.Output(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("requiredProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Output_AllParameters_Async()
        {
            UsageClient client = new UsageClient();

            Response response = await client.OutputAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("requiredProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Output_AllParameters_Convenience()
        {
            UsageClient client = new UsageClient();

            Response<OutputRecord> response = client.Output();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Output_AllParameters_Convenience_Async()
        {
            UsageClient client = new UsageClient();

            Response<OutputRecord> response = await client.OutputAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_InputAndOutput_ShortVersion()
        {
            UsageClient client = new UsageClient();

            RequestContent content = RequestContent.Create(new
            {
                requiredProp = "<requiredProp>",
            });
            Response response = client.InputAndOutput(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("requiredProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_InputAndOutput_ShortVersion_Async()
        {
            UsageClient client = new UsageClient();

            RequestContent content = RequestContent.Create(new
            {
                requiredProp = "<requiredProp>",
            });
            Response response = await client.InputAndOutputAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("requiredProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_InputAndOutput_ShortVersion_Convenience()
        {
            UsageClient client = new UsageClient();

            InputOutputRecord body = new InputOutputRecord("<requiredProp>");
            Response<InputOutputRecord> response = client.InputAndOutput(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_InputAndOutput_ShortVersion_Convenience_Async()
        {
            UsageClient client = new UsageClient();

            InputOutputRecord body = new InputOutputRecord("<requiredProp>");
            Response<InputOutputRecord> response = await client.InputAndOutputAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_InputAndOutput_AllParameters()
        {
            UsageClient client = new UsageClient();

            RequestContent content = RequestContent.Create(new
            {
                requiredProp = "<requiredProp>",
            });
            Response response = client.InputAndOutput(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("requiredProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_InputAndOutput_AllParameters_Async()
        {
            UsageClient client = new UsageClient();

            RequestContent content = RequestContent.Create(new
            {
                requiredProp = "<requiredProp>",
            });
            Response response = await client.InputAndOutputAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("requiredProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_InputAndOutput_AllParameters_Convenience()
        {
            UsageClient client = new UsageClient();

            InputOutputRecord body = new InputOutputRecord("<requiredProp>");
            Response<InputOutputRecord> response = client.InputAndOutput(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_InputAndOutput_AllParameters_Convenience_Async()
        {
            UsageClient client = new UsageClient();

            InputOutputRecord body = new InputOutputRecord("<requiredProp>");
            Response<InputOutputRecord> response = await client.InputAndOutputAsync(body);
        }
    }
}
