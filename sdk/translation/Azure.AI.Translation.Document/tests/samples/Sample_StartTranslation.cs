﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using Azure.AI.Translation.Document.Tests;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.Translation.Document.Samples
{
    [LiveOnly]
    public partial class DocumentTranslationSamples : SamplesBase<DocumentTranslationTestEnvironment>
    {
        [Test]
        public void StartTranslation()
        {
            string endpoint = TestEnvironment.Endpoint;
            string apiKey = TestEnvironment.ApiKey;

            var client = new DocumentTranslationClient(new Uri(endpoint), new AzureKeyCredential(apiKey));

            #region Snippet:StartTranslation
#if SNIPPET
            Uri sourceUri = new Uri("<source SAS URI>");
            Uri targetUri = new Uri("<target SAS URI>")
#else
            DocumentTranslationSampleHelper.TestEnvironment = TestEnvironment;
            Uri sourceUri = DocumentTranslationSampleHelper.CreateSourceContainer(DocumentTranslationSampleHelper.oneTestDocuments);
            Uri targetUri = DocumentTranslationSampleHelper.CreateTargetContainer();
#endif
            var input = new DocumentTranslationInput(sourceUri, targetUri, "es");

            DocumentTranslationOperation operation = client.StartTranslation(input);

            TimeSpan pollingInterval = new(1000);

            while (true)
            {
                operation.UpdateStatus();

                Console.WriteLine($"  Status: {operation.Status}");
                Console.WriteLine($"  Created on: {operation.CreatedOn}");
                Console.WriteLine($"  Last modified: {operation.LastModified}");
                Console.WriteLine($"  Total documents: {operation.DocumentsTotal}");
                Console.WriteLine($"    Succeeded: {operation.DocumentsSucceeded}");
                Console.WriteLine($"    Failed: {operation.DocumentsFailed}");
                Console.WriteLine($"    In Progress: {operation.DocumentsInProgress}");
                Console.WriteLine($"    Not started: {operation.DocumentsNotStarted}");

                if (operation.HasCompleted)
                {
                    break;
                }
                else
                {
                    if (operation.GetRawResponse().Headers.TryGetValue("Retry-After", out string value))
                    {
                        pollingInterval = TimeSpan.FromSeconds(Convert.ToInt32(value));
                    }
                    Thread.Sleep(pollingInterval);
                }
            }

#if !SNIPPET
            Assert.IsTrue(operation.HasCompleted);
            Assert.IsTrue(operation.HasValue);
            Assert.AreEqual(1, operation.DocumentsTotal);
            Assert.AreEqual(1, operation.DocumentsSucceeded);
            Assert.AreEqual(0, operation.DocumentsFailed);
            Assert.AreEqual(0, operation.DocumentsCancelled);
            Assert.AreEqual(0, operation.DocumentsInProgress);
            Assert.AreEqual(0, operation.DocumentsNotStarted);
#endif
            foreach (DocumentStatus document in operation.GetValues())
            {
                Console.WriteLine($"Document with Id: {document.Id}");
                Console.WriteLine($"  Status:{document.Status}");
                if (document.Status == DocumentTranslationStatus.Succeeded)
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
