// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Purview.Sharing.Samples
{
    public partial class Samples_ShareResourcesClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllShareResources_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ShareResourcesClient client = new ShareResourcesClient(endpoint, credential);

            foreach (BinaryData item in client.GetAllShareResources(null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllShareResources_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ShareResourcesClient client = new ShareResourcesClient(endpoint, credential);

            await foreach (BinaryData item in client.GetAllShareResourcesAsync(null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllShareResources_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ShareResourcesClient client = new ShareResourcesClient(endpoint, credential);

            foreach (BinaryData item in client.GetAllShareResources("<filter>", "<orderby>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("receivedSharesCount").ToString());
                Console.WriteLine(result.GetProperty("sentSharesCount").ToString());
                Console.WriteLine(result.GetProperty("storeKind").ToString());
                Console.WriteLine(result.GetProperty("storeReference").GetProperty("referenceName").ToString());
                Console.WriteLine(result.GetProperty("storeReference").GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllShareResources_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ShareResourcesClient client = new ShareResourcesClient(endpoint, credential);

            await foreach (BinaryData item in client.GetAllShareResourcesAsync("<filter>", "<orderby>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("receivedSharesCount").ToString());
                Console.WriteLine(result.GetProperty("sentSharesCount").ToString());
                Console.WriteLine(result.GetProperty("storeKind").ToString());
                Console.WriteLine(result.GetProperty("storeReference").GetProperty("referenceName").ToString());
                Console.WriteLine(result.GetProperty("storeReference").GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }
    }
}
