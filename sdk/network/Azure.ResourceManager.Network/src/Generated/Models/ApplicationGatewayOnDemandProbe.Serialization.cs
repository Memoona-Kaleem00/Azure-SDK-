// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayOnDemandProbe : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Core.Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host"u8);
                writer.WriteStringValue(Host);
            }
            if (Core.Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Core.Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteNumberValue(Timeout.Value);
            }
            if (Core.Optional.IsDefined(PickHostNameFromBackendHttpSettings))
            {
                writer.WritePropertyName("pickHostNameFromBackendHttpSettings"u8);
                writer.WriteBooleanValue(PickHostNameFromBackendHttpSettings.Value);
            }
            if (Core.Optional.IsDefined(Match))
            {
                writer.WritePropertyName("match"u8);
                writer.WriteObjectValue(Match);
            }
            if (Core.Optional.IsDefined(BackendAddressPool))
            {
                writer.WritePropertyName("backendAddressPool"u8);
                JsonSerializer.Serialize(writer, BackendAddressPool);
            }
            if (Core.Optional.IsDefined(BackendHttpSettings))
            {
                writer.WritePropertyName("backendHttpSettings"u8);
                JsonSerializer.Serialize(writer, BackendHttpSettings);
            }
            writer.WriteEndObject();
        }
    }
}
