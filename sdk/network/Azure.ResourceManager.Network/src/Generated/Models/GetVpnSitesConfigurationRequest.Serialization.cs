// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class GetVpnSitesConfigurationRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (VpnSites != null)
            {
                writer.WritePropertyName("vpnSites");
                writer.WriteStartArray();
                foreach (var item in VpnSites)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("outputBlobSasUrl");
            writer.WriteStringValue(OutputBlobSasUrl);
            writer.WriteEndObject();
        }
    }
}
