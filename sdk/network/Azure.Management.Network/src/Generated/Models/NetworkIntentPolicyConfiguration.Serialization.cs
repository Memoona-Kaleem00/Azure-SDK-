// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class NetworkIntentPolicyConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (NetworkIntentPolicyName != null)
            {
                writer.WritePropertyName("networkIntentPolicyName");
                writer.WriteStringValue(NetworkIntentPolicyName);
            }
            if (SourceNetworkIntentPolicy != null)
            {
                writer.WritePropertyName("sourceNetworkIntentPolicy");
                writer.WriteObjectValue(SourceNetworkIntentPolicy);
            }
            writer.WriteEndObject();
        }
    }
}
