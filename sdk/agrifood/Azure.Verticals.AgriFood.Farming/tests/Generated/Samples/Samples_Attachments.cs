// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Verticals.AgriFood.Farming;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    public partial class Samples_Attachments
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAttachment_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetAttachment("<partyId>", "<attachmentId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAttachment_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetAttachmentAsync("<partyId>", "<attachmentId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAttachment_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetAttachment("<partyId>", "<attachmentId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("originalFileName").ToString());
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAttachment_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetAttachmentAsync("<partyId>", "<attachmentId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("originalFileName").ToString());
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = null;
            Response response = client.CreateOrUpdate("<partyId>", "<attachmentId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = null;
            Response response = await client.CreateOrUpdateAsync("<partyId>", "<attachmentId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = client.CreateOrUpdate("<partyId>", "<attachmentId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("originalFileName").ToString());
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(File.OpenRead("<filePath>"));
            Response response = await client.CreateOrUpdateAsync("<partyId>", "<attachmentId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("originalFileName").ToString());
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<partyId>", "<attachmentId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<partyId>", "<attachmentId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<partyId>", "<attachmentId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<partyId>", "<attachmentId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Download_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Download("<partyId>", "<attachmentId>", null);

            if (response.ContentStream != null)
            {
                using Stream outFileStream = File.OpenWrite("<filepath>");
                response.ContentStream.CopyTo(outFileStream);
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Download_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DownloadAsync("<partyId>", "<attachmentId>", null);

            if (response.ContentStream != null)
            {
                using Stream outFileStream = File.OpenWrite("<filepath>");
                response.ContentStream.CopyTo(outFileStream);
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Download_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Download("<partyId>", "<attachmentId>", null);

            if (response.ContentStream != null)
            {
                using Stream outFileStream = File.OpenWrite("<filepath>");
                response.ContentStream.CopyTo(outFileStream);
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Download_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DownloadAsync("<partyId>", "<attachmentId>", null);

            if (response.ContentStream != null)
            {
                using Stream outFileStream = File.OpenWrite("<filepath>");
                response.ContentStream.CopyTo(outFileStream);
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAttachmentsByPartyId_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetAttachmentsByPartyId("<partyId>", null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAttachmentsByPartyId_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetAttachmentsByPartyIdAsync("<partyId>", null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAttachmentsByPartyId_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetAttachmentsByPartyId("<partyId>", new string[] { "<resourceIds>" }, new string[] { "<resourceTypes>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("resourceId").ToString());
                Console.WriteLine(result.GetProperty("resourceType").ToString());
                Console.WriteLine(result.GetProperty("originalFileName").ToString());
                Console.WriteLine(result.GetProperty("partyId").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("source").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAttachmentsByPartyId_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Attachments client = new FarmBeatsClient(credential).GetAttachmentsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetAttachmentsByPartyIdAsync("<partyId>", new string[] { "<resourceIds>" }, new string[] { "<resourceTypes>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("resourceId").ToString());
                Console.WriteLine(result.GetProperty("resourceType").ToString());
                Console.WriteLine(result.GetProperty("originalFileName").ToString());
                Console.WriteLine(result.GetProperty("partyId").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("source").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
            }
        }
    }
}
