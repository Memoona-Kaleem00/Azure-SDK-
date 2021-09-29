﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.AI.Language.Conversations.Models;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.Language.Conversations.Tests
{
    public class ConversationAnalysisClientLiveTests : ConversationAnalysisTestBase<ConversationAnalysisClient>
    {
        public ConversationAnalysisClientLiveTests(bool isAsync, ConversationAnalysisClientOptions.ServiceVersion serviceVersion)
            : base(isAsync, serviceVersion, null /* RecordedTestMode.Record /* to record */)
        {
        }
        private static string EnglishText = "We'll have 2 plates of seared salmon nigiri.";
        private static string SpanishText = "Tendremos 2 platos de nigiri de salmón braseado.";
        private static List<string> ExpectedOutput = new List<string>()
        {
            "2 plates",
            "seared salmon nigiri",
            "2 plates of seared salmon nigiri"
        };

        [RecordedTest]
        public async Task AnalyzeConversation()
        {
            ConversationAnalysisClient client = Client;

            AnalyzeConversationOptions options = new AnalyzeConversationOptions(
               TestEnvironment.ProjectName,
               TestEnvironment.DeploymentName,
               EnglishText);

            Response<AnalyzeConversationResult> response = await client.AnalyzeConversationAsync(options);

            Assert.That(response.GetRawResponse().Status, Is.EqualTo(200));
            Assert.That(response.Value.Prediction.TopIntent, Is.EqualTo("Order"));
            Assert.That(response.Value.Prediction.ProjectKind, Is.EqualTo(ProjectKind.Conversation));
        }

        [RecordedTest]
        public async Task AnalyzeConversationWithLanguage()
        {
            ConversationAnalysisClient client = Client;

            AnalyzeConversationOptions options = new AnalyzeConversationOptions(
               TestEnvironment.ProjectName,
               TestEnvironment.DeploymentName,
               SpanishText)
            {
                Language = "es"
            };

            Response<AnalyzeConversationResult> response = await client.AnalyzeConversationAsync(options);

            Assert.That(response.GetRawResponse().Status, Is.EqualTo(200));
            Assert.That(response.Value.Prediction.TopIntent, Is.EqualTo("Order"));
            Assert.That(response.Value.Prediction.ProjectKind, Is.EqualTo(ProjectKind.Conversation));
        }

        [RecordedTest]
        public async Task AnalyzeConversationsDeepstack()
        {
            ConversationAnalysisClient client = Client;

            AnalyzeConversationOptions options = new AnalyzeConversationOptions(
               TestEnvironment.ProjectName,
               TestEnvironment.DeploymentName,
               EnglishText);

            Response<AnalyzeConversationResult> response = await client.AnalyzeConversationAsync(options);

            DeepstackPrediction deepstackPrediction = response.Value.Prediction as DeepstackPrediction;

            Assert.That(response.GetRawResponse().Status, Is.EqualTo(200));
            Assert.That(response.Value.Prediction.ProjectKind, Is.EqualTo(ProjectKind.Conversation));

            Assert.That(deepstackPrediction.TopIntent, Is.EqualTo("Order"));

            IList<string> entitiesText = deepstackPrediction.Entities.Select(entity => entity.Text).ToList();
            Assert.That(entitiesText, Has.Count.AtLeast(1));
            Assert.That(entitiesText, Is.SubsetOf(ExpectedOutput));
        }

        [RecordedTest]
        public void AnalyzeConversationsInvalidArgument()
        {
            ConversationAnalysisClient client = Client;

            AnalyzeConversationOptions options = new AnalyzeConversationOptions(
              TestEnvironment.ProjectName,
              TestEnvironment.DeploymentName,
              "");

            RequestFailedException ex = Assert.ThrowsAsync<RequestFailedException>(async () =>
            {
                await client.AnalyzeConversationAsync(options);
            });

            Assert.That(ex.Status, Is.EqualTo(400));
            Assert.That(ex.ErrorCode, Is.EqualTo("InvalidArgument"));
        }
    }
}
