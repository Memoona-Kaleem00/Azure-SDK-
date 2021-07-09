﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Text;
using System.Threading;
using Azure.AI.MetricsAdvisor.Administration;
using Azure.Core;
using Azure.Core.TestFramework;
using Newtonsoft.Json;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Azure.AI.MetricsAdvisor.Tests
{
    public class MockClientTestBase : ClientTestBase
    {
        public MockClientTestBase(bool isAsync) : base(isAsync)
        {
        }

        public string FakeGuid => "00000000-0000-0000-0000-000000000000";

        public MetricsAdvisorClient CreateInstrumentedClient(MockResponse response) =>
            CreateInstrumentedClient(new MockTransport(response));

        public MetricsAdvisorClient CreateInstrumentedClient(MockTransport transport, MetricsAdvisorKeyCredential credential = null)
        {
            var fakeEndpoint = new Uri("http://notreal.azure.com");
            var fakeCredential = credential ?? new MetricsAdvisorKeyCredential("fakeSubscriptionKey", "fakeApiKey");
            var options = new MetricsAdvisorClientsOptions() { Transport = transport };

            return InstrumentClient(new MetricsAdvisorClient(fakeEndpoint, fakeCredential, options));
        }

        public MetricsAdvisorAdministrationClient CreateInstrumentedAdministrationClient(MockResponse response) =>
            CreateInstrumentedAdministrationClient(new MockTransport(response));

        public MetricsAdvisorAdministrationClient CreateInstrumentedAdministrationClient(MockTransport transport, MetricsAdvisorKeyCredential credential = null)
        {
            var fakeEndpoint = new Uri("http://notreal.azure.com");
            var fakeCredential = credential ?? new MetricsAdvisorKeyCredential("fakeSubscriptionKey", "fakeApiKey");
            var options = new MetricsAdvisorClientsOptions() { Transport = transport };

            return InstrumentClient(new MetricsAdvisorAdministrationClient(fakeEndpoint, fakeCredential, options));
        }

        public Stream CreateAnomalyJsonStream(double value = default, double? expectedValue = default)
        {
            string jsonStr = JsonConvert.SerializeObject(new
            {
                value = new[]
                {
                    new
                    {
                        dimension = new {},
                        property = new { anomalySeverity = "low", value = value, expectedValue = expectedValue }
                    }
                }
            });

            return new MemoryStream(Encoding.UTF8.GetBytes(jsonStr));
        }

        public Stream CreateIncidentJsonStream(double valueOfRootNode = default, double? expectedValueOfRootNode = default)
        {
            string jsonStr = JsonConvert.SerializeObject(new
            {
                value = new[]
                {
                    new
                    {
                        rootNode = new { dimension = new {} },
                        property = new { valueOfRootNode = valueOfRootNode, expectedValueOfRootNode = expectedValueOfRootNode }
                    }
                }
            });

            return new MemoryStream(Encoding.UTF8.GetBytes(jsonStr));
        }

        public string ReadContent(Request request)
        {
            using MemoryStream stream = new MemoryStream();
            request.Content.WriteTo(stream, CancellationToken.None);

            return Encoding.UTF8.GetString(stream.ToArray());
        }

        public SubstringConstraint ContainsJsonString(string propertyName, string propertyValue) =>
            Contains.Substring($"\"{propertyName}\":\"{propertyValue}\"");

        // Currently only supports a single-element array.
        public SubstringConstraint ContainsJsonStringArray(string propertyName, string elementValue) =>
            Contains.Substring($"\"{propertyName}\":[\"{elementValue}\"]");
    }
}
