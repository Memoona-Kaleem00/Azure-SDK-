// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;

namespace Azure.Maps.Search.Tests
{
    public class SearchClientTestEnvironment : TestEnvironment
    {
        public Uri Endpoint {
            get {
                var endpoint = GetRecordedOptionalVariable("ENDPOINT_URL");
                return endpoint != null ? new Uri(endpoint) : null;
            }
        }
        public string MapAccountClientId => GetRecordedOptionalVariable("AZMAPS_CLIENT_ID");
        public MapsSearchClient CreateClient()
        {
            var subscriptionKey = System.Environment.GetEnvironmentVariable("MAPS_SUBSCRIPTION_KEY") ?? "<My Subscrption Key>";
            return new MapsSearchClient(new AzureKeyCredential(subscriptionKey));
        }
    }
}
