﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Base.Http;
using Azure.Base.Http.Pipeline;
using Azure.Base.Testing;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Base.Tests
{
    public class PipelineTests
    {
        [Test]
        public async Task Basics()
        {
            var mockTransport = new MockTransport(
                new MockResponse(500),
                new MockResponse(1));

            var pipeline = new HttpPipeline(mockTransport, new [] { new CustomRetryPolicy() });

            var request = pipeline.CreateRequest();
            request.SetRequestLine(HttpVerb.Get, new Uri("https://contoso.a.io"));
            var response = await pipeline.SendRequestAsync(request, CancellationToken.None);

            Assert.AreEqual(1, response.Status);
        }

        [Test]
        public async Task ComponentNameAndVersionReadFromAssembly()
        {
            string userAgent = null;

            var mockTransport = new MockTransport(
                req => {
                    Assert.True(req.TryGetHeader("User-Agent", out userAgent));
                    return new MockResponse(200);
                });

            var pipeline = HttpPipeline.Build(new TestClientOptions() { Transport = mockTransport }, _ => { });

            var request = pipeline.CreateRequest();
            request.SetRequestLine(HttpVerb.Get, new Uri("https://contoso.a.io"));
            await pipeline.SendRequestAsync(request, CancellationToken.None);

            var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            Assert.AreEqual(userAgent, $"azsdk-net-base-test/{assemblyVersion} ({RuntimeInformation.FrameworkDescription}; {RuntimeInformation.OSDescription})");
        }

        class CustomRetryPolicy : RetryPolicy
        {
            protected override bool ShouldRetry(HttpPipelineMessage message, Exception exception, int retry, out TimeSpan delay)
            {
                delay = TimeSpan.Zero;
                if (retry > 5) return false;
                if (message.Response.Status == 1) return false;
                return true;
            }
        }

        class TestClientOptions : HttpPipelineOptions
        {
        }

        class NullPipelineContext : HttpPipelineRequest
        {
            public override void AddHeader(HttpHeader header)
            {
            }

            public override bool TryGetHeader(string name, out string value)
            {
                value = null;
                return false;
            }

            public override IEnumerable<HttpHeader> Headers
            {
                get
                {
                    yield break;
                }
            }

            public override string RequestId { get; set; }

            public override void Dispose()
            {
            }
        }
    }
}
