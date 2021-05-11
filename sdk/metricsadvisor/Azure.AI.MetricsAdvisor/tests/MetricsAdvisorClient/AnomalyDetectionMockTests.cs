﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Threading.Tasks;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.MetricsAdvisor.Tests
{
    public class AnomalyDetectionMockTests : MockClientTestBase
    {
        public AnomalyDetectionMockTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        public async Task GetAnomaliesSetsValue()
        {
            double originalValue = 3.14;

            using Stream responseBody = CreateAnomalyJsonStream(value: originalValue);
            MockResponse mockResponse = new MockResponse(200) { ContentStream = responseBody };

            MetricsAdvisorClient client = CreateInstrumentedClient(mockResponse);

            var options = new GetAnomaliesForDetectionConfigurationOptions(default, default);

            await foreach (DataPointAnomaly anomaly in client.GetAnomaliesAsync(FakeGuid, options))
            {
                Assert.That(anomaly.Value, Is.EqualTo(originalValue));
            }
        }

        [Test]
        public async Task GetAnomaliesSetsNullExpectedValue()
        {
            using Stream responseBody = CreateAnomalyJsonStream(expectedValue: null);
            MockResponse mockResponse = new MockResponse(200) { ContentStream = responseBody };

            MetricsAdvisorClient client = CreateInstrumentedClient(mockResponse);

            var options = new GetAnomaliesForDetectionConfigurationOptions(default, default);

            await foreach (DataPointAnomaly anomaly in client.GetAnomaliesAsync(FakeGuid, options))
            {
                Assert.That(anomaly.ExpectedValue, Is.Null);
            }
        }

        [Test]
        public async Task GetAnomaliesSetsExpectedValue()
        {
            double originalExpectedValue = 1.62;

            using Stream responseBody = CreateAnomalyJsonStream(expectedValue: originalExpectedValue);
            MockResponse mockResponse = new MockResponse(200) { ContentStream = responseBody };

            MetricsAdvisorClient client = CreateInstrumentedClient(mockResponse);

            var options = new GetAnomaliesForDetectionConfigurationOptions(default, default);

            await foreach (DataPointAnomaly anomaly in client.GetAnomaliesAsync(FakeGuid, options))
            {
                Assert.That(anomaly.ExpectedValue, Is.EqualTo(originalExpectedValue));
            }
        }
    }
}
