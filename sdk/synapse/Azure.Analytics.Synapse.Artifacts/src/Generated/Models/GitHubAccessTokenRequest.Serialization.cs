// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class GitHubAccessTokenRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("gitHubClientId");
            writer.WriteStringValue(GitHubClientId);
            writer.WritePropertyName("gitHubAccessCode");
            writer.WriteStringValue(GitHubAccessCode);
            writer.WritePropertyName("gitHubAccessTokenBaseUrl");
            writer.WriteStringValue(GitHubAccessTokenBaseUrl);
            writer.WriteEndObject();
        }
    }
}
