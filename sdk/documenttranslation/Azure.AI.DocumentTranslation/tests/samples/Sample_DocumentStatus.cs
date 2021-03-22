﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.DocumentTranslation.Tests.Samples
{
    [LiveOnly]
    public partial class DocumentTranslationSamples : SamplesBase<DocumentTranslationTestEnvironment>
    {
        [Test]
        public void DocumentStatus()
        {
            string endpoint = TestEnvironment.Endpoint;
            string apiKey = TestEnvironment.ApiKey;
            Uri sourceUri = new Uri("");
            Uri targetUri = new Uri("");

            var client = new DocumentTranslationClient(new Uri(endpoint), new AzureKeyCredential(apiKey));

            var input = new TranslationConfiguration(sourceUri, targetUri, "es");
            DocumentTranslationOperation operation = client.StartTranslation(input);

            var documentscompleted = new HashSet<string>();

            while (!operation.HasCompleted)
            {
                operation.UpdateStatus();

                Pageable<DocumentStatusDetail> documentsStatus = operation.GetAllDocumentsStatus();
                foreach (DocumentStatusDetail docStatus in documentsStatus)
                {
                    if (documentscompleted.Contains(docStatus.DocumentId))
                        continue;
                    if (docStatus.Status == TranslationStatus.Succeeded || docStatus.Status == TranslationStatus.Failed)
                    {
                        documentscompleted.Add(docStatus.DocumentId);
                        Console.WriteLine($"Document {docStatus.LocationUri} completed with status ${docStatus.Status}");
                    }
                }
            }
        }
    }
}
