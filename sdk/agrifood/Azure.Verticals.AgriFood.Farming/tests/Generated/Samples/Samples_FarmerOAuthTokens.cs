// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Verticals.AgriFood.Farming;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    internal class Samples_FarmerOAuthTokens
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetOAuthConnectionLink()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new Dictionary<string, object>()
            {
                ["partyId"] = "<partyId>",
                ["oAuthProviderId"] = "<oAuthProviderId>",
                ["userRedirectLink"] = "<userRedirectLink>",
            });
            Response response = client.GetOAuthConnectionLink(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetOAuthConnectionLink_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new Dictionary<string, object>()
            {
                ["partyId"] = "<partyId>",
                ["oAuthProviderId"] = "<oAuthProviderId>",
                ["userRedirectLink"] = "<userRedirectLink>",
                ["userRedirectState"] = "<userRedirectState>",
            });
            Response response = client.GetOAuthConnectionLink(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetOAuthConnectionLink_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new Dictionary<string, object>()
            {
                ["partyId"] = "<partyId>",
                ["oAuthProviderId"] = "<oAuthProviderId>",
                ["userRedirectLink"] = "<userRedirectLink>",
            });
            Response response = await client.GetOAuthConnectionLinkAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetOAuthConnectionLink_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new Dictionary<string, object>()
            {
                ["partyId"] = "<partyId>",
                ["oAuthProviderId"] = "<oAuthProviderId>",
                ["userRedirectLink"] = "<userRedirectLink>",
                ["userRedirectState"] = "<userRedirectState>",
            });
            Response response = await client.GetOAuthConnectionLinkAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCascadeDeleteJobDetails()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetCascadeDeleteJobDetails("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCascadeDeleteJobDetails_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetCascadeDeleteJobDetails("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCascadeDeleteJobDetails_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetCascadeDeleteJobDetailsAsync("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCascadeDeleteJobDetails_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetCascadeDeleteJobDetailsAsync("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAuthenticatedFarmersDetails()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetAuthenticatedFarmersDetails(null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("partyId").ToString());
                Console.WriteLine(result[0].GetProperty("authProviderId").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAuthenticatedFarmersDetails_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetAuthenticatedFarmersDetails(new List<string>()
{
"<authProviderIds>"
}, new List<string>()
{
"<partyIds>"
}, true, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("partyId").ToString());
                Console.WriteLine(result[0].GetProperty("authProviderId").ToString());
                Console.WriteLine(result[0].GetProperty("isValid").ToString());
                Console.WriteLine(result[0].GetProperty("eTag").ToString());
                Console.WriteLine(result[0].GetProperty("createdDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedDateTime").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAuthenticatedFarmersDetails_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetAuthenticatedFarmersDetailsAsync(null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("partyId").ToString());
                Console.WriteLine(result[0].GetProperty("authProviderId").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAuthenticatedFarmersDetails_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetAuthenticatedFarmersDetailsAsync(new List<string>()
{
"<authProviderIds>"
}, new List<string>()
{
"<partyIds>"
}, true, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("partyId").ToString());
                Console.WriteLine(result[0].GetProperty("authProviderId").ToString());
                Console.WriteLine(result[0].GetProperty("isValid").ToString());
                Console.WriteLine(result[0].GetProperty("eTag").ToString());
                Console.WriteLine(result[0].GetProperty("createdDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedDateTime").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateCascadeDeleteJob()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = client.CreateCascadeDeleteJob(WaitUntil.Completed, "<jobId>", "<partyId>", "<oauthProviderId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateCascadeDeleteJob_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = client.CreateCascadeDeleteJob(WaitUntil.Completed, "<jobId>", "<partyId>", "<oauthProviderId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateCascadeDeleteJob_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = await client.CreateCascadeDeleteJobAsync(WaitUntil.Completed, "<jobId>", "<partyId>", "<oauthProviderId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateCascadeDeleteJob_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            FarmerOAuthTokens client = new FarmBeatsClient(credential).GetFarmerOAuthTokensClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = await client.CreateCascadeDeleteJobAsync(WaitUntil.Completed, "<jobId>", "<partyId>", "<oauthProviderId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }
    }
}
