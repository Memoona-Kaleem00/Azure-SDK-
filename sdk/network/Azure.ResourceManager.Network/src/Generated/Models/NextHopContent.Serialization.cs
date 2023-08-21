// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NextHopContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetResourceId"u8);
            writer.WriteStringValue(TargetResourceId);
            writer.WritePropertyName("sourceIPAddress"u8);
            writer.WriteStringValue(SourceIPAddress);
            writer.WritePropertyName("destinationIPAddress"u8);
            writer.WriteStringValue(DestinationIPAddress);
            if (Core.Optional.IsDefined(TargetNicResourceId))
            {
                writer.WritePropertyName("targetNicResourceId"u8);
                writer.WriteStringValue(TargetNicResourceId);
            }
            writer.WriteEndObject();
        }
    }
}
