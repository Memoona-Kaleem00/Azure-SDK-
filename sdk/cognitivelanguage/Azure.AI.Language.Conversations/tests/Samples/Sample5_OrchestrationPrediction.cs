﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.AI.Language.Conversations.Models;
using Azure.Core.TestFramework;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Azure.AI.Language.Conversations.Tests.Samples
{
    public partial class ConversationAnalysisClientSamples
    {
        [SyncOnly]
        [RecordedTest]
        public void AnalyzeConversationOrchestrationPredictionQuestionAnswering()
        {
            ConversationAnalysisClient client = Client;

            #region Snippet:ConversationAnalysis_AnalyzeConversationOrchestrationPrediction

#if SNIPPET
            Response<AnalyzeConversationResult> response = client.AnalyzeConversation(
                "DomainOrchestrator",
                "production",
                "Where are the calories per recipe?");
#else
            Response<AnalyzeConversationResult> response = client.AnalyzeConversation(
                "DomainOrchestrator",
                "production",
                "where are the calories per recipe?");
#endif

            OrchestratorPrediction orchestratorPrediction = response.Value.Prediction as OrchestratorPrediction;
            #endregion
            #region Snippet:ConversationAnalysis_AnalyzeConversationOrchestrationPredictionQnA
            string respondingProjectName = orchestratorPrediction.TopIntent;
            TargetIntentResult targetIntentResult = orchestratorPrediction.Intents[respondingProjectName];

            if (targetIntentResult.TargetKind == TargetKind.QuestionAnswering)
            {
                QuestionAnsweringTargetIntentResult qnaTargetIntentResult = targetIntentResult as QuestionAnsweringTargetIntentResult;

                KnowledgeBaseAnswers qnaAnswers = qnaTargetIntentResult.Result;

                Console.WriteLine("Answers: \n");
                foreach (KnowledgeBaseAnswer answer in qnaAnswers.Answers)
                {
                    Console.WriteLine($"Answer: {answer.Answer}");
                    Console.WriteLine($"Confidence Score: {answer.ConfidenceScore}");
                    Console.WriteLine($"Source: {answer.Source}");
                    Console.WriteLine();
                }
            }
            #endregion
            Assert.That(targetIntentResult.TargetKind, Is.EqualTo(TargetKind.QuestionAnswering));
            Assert.That(orchestratorPrediction.TopIntent, Is.EqualTo("RecipeFAQ"));
        }

        [SyncOnly]
        [RecordedTest]
        public void AnalyzeConversationOrchestrationPredictionConversation()
        {
            ConversationAnalysisClient client = Client;

            Response<AnalyzeConversationResult> response = client.AnalyzeConversation(
                "DomainOrchestrator",
                "production",
                "send an email to carol about the demo");

            OrchestratorPrediction orchestratorPrediction = response.Value.Prediction as OrchestratorPrediction;

            #region Snippet:ConversationAnalysis_AnalyzeConversationOrchestrationPredictionConversation
            string respondingProjectName = orchestratorPrediction.TopIntent;
            TargetIntentResult targetIntentResult = orchestratorPrediction.Intents[respondingProjectName];

            if (targetIntentResult.TargetKind == TargetKind.Conversation)
            {
                ConversationTargetIntentResult cluTargetIntentResult = targetIntentResult as ConversationTargetIntentResult;

                ConversationResult conversationResult = cluTargetIntentResult.Result;
                ConversationPrediction conversationPrediction = conversationResult.Prediction;

                if (!String.IsNullOrEmpty(conversationResult.DetectedLanguage))
                    Console.WriteLine($"Detected Language: {conversationResult.DetectedLanguage}");

                Console.WriteLine($"Top Intent: {conversationResult.Prediction.TopIntent}");
                Console.WriteLine($"Intents:");
                foreach (ConversationIntent intent in conversationPrediction.Intents)
                {
                    Console.WriteLine($"Intent Category: {intent.Category}");
                    Console.WriteLine($"Confidence Score: {intent.ConfidenceScore}");
                    Console.WriteLine();
                }

                Console.WriteLine($"Entities:");
                foreach (ConversationEntity entitiy in conversationPrediction.Entities)
                {
                    Console.WriteLine($"Entity Text: {entitiy.Text}");
                    Console.WriteLine($"Entity Category: {entitiy.Category}");
                    Console.WriteLine($"Confidence Score: {entitiy.ConfidenceScore}");
                    Console.WriteLine($"Starting Position: {entitiy.Offset}");
                    Console.WriteLine($"Length: {entitiy.Length}");
                    Console.WriteLine();
                }
            }
            #endregion
            Assert.That(targetIntentResult.TargetKind, Is.EqualTo(TargetKind.Conversation));
            Assert.That(orchestratorPrediction.TopIntent, Is.EqualTo("Email"));
        }

        [SyncOnly]
        [RecordedTest]
        public void AnalyzeConversationOrchestrationPredictionLuis()
        {
            ConversationAnalysisClient client = Client;

            Response<AnalyzeConversationResult> response = client.AnalyzeConversation(
                "DomainOrchestrator",
                "production",
                "reserve a restaurant at the egyptian place for 2 people");

            OrchestratorPrediction orchestratorPrediction = response.Value.Prediction as OrchestratorPrediction;

            #region Snippet:ConversationAnalysis_AnalyzeConversationOrchestrationPredictionLuis
            string respondingProjectName = orchestratorPrediction.TopIntent;
            TargetIntentResult targetIntentResult = orchestratorPrediction.Intents[respondingProjectName];

            if (targetIntentResult.TargetKind == TargetKind.Luis)
            {
                LuisTargetIntentResult luisTargetIntentResult = targetIntentResult as LuisTargetIntentResult;

                // JsonDocument
                // SystemTextJson
                JObject luisResult = JObject.FromObject(luisTargetIntentResult.Result);
                Console.WriteLine($"LUIS Response: {luisResult.ToString()}");
            }
            #endregion

            Assert.That(targetIntentResult.TargetKind, Is.EqualTo(TargetKind.Luis));
            Assert.That(orchestratorPrediction.TopIntent, Is.EqualTo("Restaurant"));
        }

        [SyncOnly]
        [RecordedTest]
        public async Task AnalyzeConversationOrchestrationPredictionQuestionAnsweringAsync()
        {
            ConversationAnalysisClient client = Client;

            #region Snippet:ConversationAnalysis_AnalyzeConversationOrchestrationPredictionAsync

#if SNIPPET
            Response<AnalyzeConversationResult> response = client.AnalyzeConversation(
                "DomainOrchestrator",
                "production",
                "Where are the calories per recipe?");
#else
            Response<AnalyzeConversationResult> response = await client.AnalyzeConversationAsync(
                "DomainOrchestrator",
                "production",
                "where are the calories per recipe?");
#endif

            OrchestratorPrediction orchestratorPrediction = response.Value.Prediction as OrchestratorPrediction;
            #endregion

            string respondingProjectName = orchestratorPrediction.TopIntent;
            TargetIntentResult targetIntentResult = orchestratorPrediction.Intents[respondingProjectName];

            if (targetIntentResult.TargetKind == TargetKind.QuestionAnswering)
            {
                QuestionAnsweringTargetIntentResult qnaTargetIntentResult = targetIntentResult as QuestionAnsweringTargetIntentResult;

                KnowledgeBaseAnswers qnaAnswers = qnaTargetIntentResult.Result;

                Console.WriteLine("Answers: \n");
                foreach (KnowledgeBaseAnswer answer in qnaAnswers.Answers)
                {
                    Console.WriteLine($"Answer: {answer.Answer}");
                    Console.WriteLine($"Confidence Score: {answer.ConfidenceScore}");
                    Console.WriteLine($"Source: {answer.Source}");
                    Console.WriteLine();
                }
            }
            Assert.That(targetIntentResult.TargetKind, Is.EqualTo(TargetKind.QuestionAnswering));
            Assert.That(orchestratorPrediction.TopIntent, Is.EqualTo("RecipeFAQ"));
        }

        [SyncOnly]
        [RecordedTest]
        public async Task AnalyzeConversationOrchestrationPredictionConversationAsync()
        {
            ConversationAnalysisClient client = Client;

            Response<AnalyzeConversationResult> response = await client.AnalyzeConversationAsync(
                "DomainOrchestrator",
                "production",
                "send an email to carol about the demo");

            OrchestratorPrediction orchestratorPrediction = response.Value.Prediction as OrchestratorPrediction;

            string respondingProjectName = orchestratorPrediction.TopIntent;
            TargetIntentResult targetIntentResult = orchestratorPrediction.Intents[respondingProjectName];

            if (targetIntentResult.TargetKind == TargetKind.Conversation)
            {
                ConversationTargetIntentResult cluTargetIntentResult = targetIntentResult as ConversationTargetIntentResult;

                ConversationResult conversationResult = cluTargetIntentResult.Result;
                ConversationPrediction conversationPrediction = conversationResult.Prediction;

                if (!String.IsNullOrEmpty(conversationResult.DetectedLanguage))
                    Console.WriteLine($"Detected Language: {conversationResult.DetectedLanguage}");

                Console.WriteLine($"Top Intent: {conversationResult.Prediction.TopIntent}");
                Console.WriteLine($"Intents:");
                foreach (ConversationIntent intent in conversationPrediction.Intents)
                {
                    Console.WriteLine($"Intent Category: {intent.Category}");
                    Console.WriteLine($"Confidence Score: {intent.ConfidenceScore}");
                    Console.WriteLine();
                }

                Console.WriteLine($"Entities:");
                foreach (ConversationEntity entitiy in conversationPrediction.Entities)
                {
                    Console.WriteLine($"Entity Text: {entitiy.Text}");
                    Console.WriteLine($"Entity Category: {entitiy.Category}");
                    Console.WriteLine($"Confidence Score: {entitiy.ConfidenceScore}");
                    Console.WriteLine($"Starting Position: {entitiy.Offset}");
                    Console.WriteLine($"Length: {entitiy.Length}");
                    Console.WriteLine();
                }
            }

            Assert.That(targetIntentResult.TargetKind, Is.EqualTo(TargetKind.Conversation));
            Assert.That(orchestratorPrediction.TopIntent, Is.EqualTo("Email"));
        }

        [SyncOnly]
        [RecordedTest]
        public async Task AnalyzeConversationOrchestrationPredictionLuisAsync()
        {
            ConversationAnalysisClient client = Client;

            Response<AnalyzeConversationResult> response = await client.AnalyzeConversationAsync(
                "DomainOrchestrator",
                "production",
                "reserve a restaurant at the egyptian place for 2 people");

            OrchestratorPrediction orchestratorPrediction = response.Value.Prediction as OrchestratorPrediction;

            string respondingProjectName = orchestratorPrediction.TopIntent;
            TargetIntentResult targetIntentResult = orchestratorPrediction.Intents[respondingProjectName];

            if (targetIntentResult.TargetKind == TargetKind.Luis)
            {
                LuisTargetIntentResult luisTargetIntentResult = targetIntentResult as LuisTargetIntentResult;

                JObject luisResult = JObject.FromObject(luisTargetIntentResult.Result);
                Console.WriteLine($"Luis Response: {luisResult.ToString()}");
            }

            Assert.That(targetIntentResult.TargetKind, Is.EqualTo(TargetKind.Luis));
            Assert.That(orchestratorPrediction.TopIntent, Is.EqualTo("Restaurant"));
        }
    }
}
