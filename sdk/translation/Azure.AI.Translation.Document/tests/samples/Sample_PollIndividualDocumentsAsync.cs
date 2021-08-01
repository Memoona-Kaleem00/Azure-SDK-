﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.AI.Translation.Document.Tests;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.Translation.Document.Samples
{
    [LiveOnly]
    public partial class DocumentTranslationSamples : SamplesBase<DocumentTranslationTestEnvironment>
    {
        [Test]
        public async Task PollIndividualDocumentsAsync()
        {
            string endpoint = TestEnvironment.Endpoint;
            string apiKey = TestEnvironment.ApiKey;

            var client = new DocumentTranslationClient(new Uri(endpoint), new AzureKeyCredential(apiKey));

            #region Snippet:PollIndividualDocumentsAsync
#if SNIPPET
            Uri sourceUri = new Uri("<source SAS URI>");
            Uri targetUri = new Uri("<target SAS URI>")
#else
            DocumentTranslationSampleHelper.TestEnvironment = TestEnvironment;
            Uri sourceUri = await DocumentTranslationSampleHelper.CreateSourceContainerAsync(DocumentTranslationSampleHelper.oneTestDocuments);
            Uri targetUri = await DocumentTranslationSampleHelper.CreateTargetContainerAsync();
#endif

            var input = new DocumentTranslationInput(sourceUri, targetUri, "es");

            DocumentTranslationOperation operation = await client.StartTranslationAsync(input);

            TimeSpan pollingInterval = new(1000);

            await foreach (DocumentStatus document in operation.GetAllDocumentStatusesAsync())
            {
                Console.WriteLine($"Polling Status for document{document.SourceDocumentUri}");

                Response<DocumentStatus> responseDocumentStatus = await operation.GetDocumentStatusAsync(document.Id);

                while (responseDocumentStatus.Value.Status != DocumentTranslationStatus.Failed &&
                          responseDocumentStatus.Value.Status != DocumentTranslationStatus.Succeeded)
                {
                    if (responseDocumentStatus.GetRawResponse().Headers.TryGetValue("Retry-After", out string value))
                    {
                        pollingInterval = TimeSpan.FromSeconds(Convert.ToInt32(value));
                    }

                    await Task.Delay(pollingInterval);
                    responseDocumentStatus = await operation.GetDocumentStatusAsync(document.Id);
                }

                if (responseDocumentStatus.Value.Status == DocumentTranslationStatus.Succeeded)
                {
                    Console.WriteLine($"  Translated Document Uri: {document.TranslatedDocumentUri}");
                    Console.WriteLine($"  Translated to language: {document.TranslatedTo}.");
                    Console.WriteLine($"  Document source Uri: {document.SourceDocumentUri}");
                }
                else
                {
                    Console.WriteLine($"  Document source Uri: {document.SourceDocumentUri}");
                    Console.WriteLine($"  Error Code: {document.Error.ErrorCode}");
                    Console.WriteLine($"  Message: {document.Error.Message}");
                }
            }

            #endregion
        }
    }
}
