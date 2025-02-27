using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoRest.TestServer.Tests.Infrastructure;
using Azure;
using Azure.Core;
using Encode.Bytes;
using Encode.Bytes.Models;
using Encode.Datetime.Models;
using NUnit.Framework;

namespace CadlRanchProjects.Tests
{
    public class EncodeBytesTests : CadlRanchTestBase
    {
        [Test]
        public Task Encode_Bytes_Query_default() => Test(async (host) =>
        {
            BinaryData data = BinaryData.FromString("test");

            Response response = await new BytesClient(host, null).GetQueryClient().DefaultAsync(data);
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Encode_Bytes_Query_base64() => Test(async (host) =>
        {
            BinaryData data = BinaryData.FromString("test");
            Response response = await new BytesClient(host, null).GetQueryClient().Base64Async(data);
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Encode_Bytes_Query_base64url() => Test(async (host) =>
        {
            BinaryData data = BinaryData.FromString("test");
            Response response = await new BytesClient(host, null).GetQueryClient().Base64urlAsync(data);
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Encode_Bytes_Query_base64urlArray() => Test(async (host) =>
        {
            BinaryData data1 = BinaryData.FromString("test");
            BinaryData data2 = BinaryData.FromString("test");
            Response response = await new BytesClient(host, null).GetQueryClient().Base64urlArrayAsync(new[] { data1, data2 });
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Encode_Bytes_Property_default() => Test(async (host) =>
        {
            BinaryData data = BinaryData.FromString("test");
            var body = new DefaultBytesProperty(data);
            Response<DefaultBytesProperty> response = await new BytesClient(host, null).GetPropertyClient().DefaultAsync(body);
            Assert.AreEqual(body.Value.ToString(), response.Value.Value.ToString());
        });

        [Test]
        public Task Encode_Bytes_Property_base64() => Test(async (host) =>
        {
            BinaryData data = BinaryData.FromString("test");
            var body = new Base64BytesProperty(data);
            Response<Base64BytesProperty> response = await new BytesClient(host, null).GetPropertyClient().Base64Async(body);
            Assert.AreEqual(body.Value.ToString(), response.Value.Value.ToString());
        });

        [Test]
        public Task Encode_Bytes_Property_base64url() => Test(async (host) =>
        {
            BinaryData data = BinaryData.FromString("test");
            var body = new Base64urlBytesProperty(data);
            Response<Base64urlBytesProperty> response = await new BytesClient(host, null).GetPropertyClient().Base64urlAsync(body);
            Assert.AreEqual(body.Value.ToString(), response.Value.Value.ToString());
        });

        [Test]
        public Task Base64urlArrayBytesProperty() => Test(async (host) =>
        {
            BinaryData data1 = BinaryData.FromString("test");
            BinaryData data2 = BinaryData.FromString("test");
            var body = new Base64urlArrayBytesProperty(new[] {data1,data2});
            Response<Base64urlArrayBytesProperty> response = await new BytesClient(host, null).GetPropertyClient().Base64urlArrayAsync(body);
            Assert.AreEqual(body.Value[0].ToString(), response.Value.Value[0].ToString());
            Assert.AreEqual(body.Value[1].ToString(), response.Value.Value[1].ToString());
        });

        [Test]
        public Task Encode_Bytes_Header_default() => Test(async (host) =>
        {
            BinaryData data = BinaryData.FromString("test");

            Response response = await new BytesClient(host, null).GetHeaderClient().DefaultAsync(data);
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Encode_Bytes_Header_base64() => Test(async (host) =>
        {
            BinaryData data = BinaryData.FromString("test");
            Response response = await new BytesClient(host, null).GetHeaderClient().Base64Async(data);
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Encode_Bytes_Header_base64url() => Test(async (host) =>
        {
            BinaryData data = BinaryData.FromString("test");
            Response response = await new BytesClient(host, null).GetHeaderClient().Base64urlAsync(data);
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Encode_Bytes_Header_base64urlArray() => Test(async (host) =>
        {
            BinaryData data1 = BinaryData.FromString("test");
            BinaryData data2 = BinaryData.FromString("test");
            Response response = await new BytesClient(host, null).GetHeaderClient().Base64urlArrayAsync(new[] { data1, data2 });
            Assert.AreEqual(204, response.Status);
        });
    }
}
