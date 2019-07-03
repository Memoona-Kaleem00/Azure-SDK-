﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Core.Extensions.Tests
{
    internal static class TestClientsBuilderExtensions
    {
        public static IAzureClientBuilder<TestClient, TestClientOptions> AddTestClient<TBuilder>(this TBuilder builder, string connectionString)
            where TBuilder: IAzureClientsBuilder
        {
            return builder.RegisterClient<TestClient, TestClientOptions>(options => new TestClient(connectionString, options));
        }

        public static IAzureClientBuilder<TestClient, TestClientOptions> AddTestClient<TBuilder>(this TBuilder builder, Uri uri)
            where TBuilder: IAzureClientsBuilder
        {
            return builder.RegisterClient<TestClient, TestClientOptions>(options => new TestClient(uri, options));
        }

        public static IAzureClientBuilder<TestClient, TestClientOptions> AddTestClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
            where TBuilder: IAzureClientsBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClient<TestClient, TestClientOptions>(configuration);
        }

        public static IAzureClientBuilder<TestClientWithCredentials, TestClientOptions> AddTestClientWithCredentials<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
            where TBuilder: IAzureClientsBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClient<TestClientWithCredentials, TestClientOptions>(configuration);
        }

        public static IAzureClientBuilder<TestClientWithCredentials, TestClientOptions> AddTestClientWithCredentials<TBuilder>(this TBuilder builder, Uri uri)
            where TBuilder: IAzureClientsBuilderWithCredential
        {
            return builder.RegisterClient<TestClientWithCredentials, TestClientOptions>((options, cred) => new TestClientWithCredentials(uri, cred, options));
        }

    }
}