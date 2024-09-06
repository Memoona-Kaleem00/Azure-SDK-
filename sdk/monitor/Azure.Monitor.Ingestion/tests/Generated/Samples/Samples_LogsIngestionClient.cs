// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Monitor.Ingestion.Samples
{
    public partial class Samples_LogsIngestionClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Upload_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            LogsIngestionClient client = new LogsIngestionClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new object[]
            {
new object()
            });
            Response response = client.Upload("<ruleId>", "<streamName>", content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Upload_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            LogsIngestionClient client = new LogsIngestionClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new object[]
            {
new object()
            });
            Response response = await client.UploadAsync("<ruleId>", "<streamName>", content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Upload_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            LogsIngestionClient client = new LogsIngestionClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new object[]
            {
new object()
            });
            Response response = client.Upload("<ruleId>", "<streamName>", content, contentEncoding: "<contentEncoding>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Upload_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            LogsIngestionClient client = new LogsIngestionClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new object[]
            {
new object()
            });
            Response response = await client.UploadAsync("<ruleId>", "<streamName>", content, contentEncoding: "<contentEncoding>");

            Console.WriteLine(response.Status);
        }
    }
}
