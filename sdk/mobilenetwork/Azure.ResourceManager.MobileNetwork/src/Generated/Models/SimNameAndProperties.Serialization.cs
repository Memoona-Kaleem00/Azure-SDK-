// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class SimNameAndProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("internationalMobileSubscriberIdentity"u8);
            writer.WriteStringValue(InternationalMobileSubscriberIdentity);
            if (Core.Optional.IsDefined(IntegratedCircuitCardIdentifier))
            {
                writer.WritePropertyName("integratedCircuitCardIdentifier"u8);
                writer.WriteStringValue(IntegratedCircuitCardIdentifier);
            }
            if (Core.Optional.IsDefined(DeviceType))
            {
                writer.WritePropertyName("deviceType"u8);
                writer.WriteStringValue(DeviceType);
            }
            if (Core.Optional.IsDefined(SimPolicy))
            {
                writer.WritePropertyName("simPolicy"u8);
                JsonSerializer.Serialize(writer, SimPolicy);
            }
            if (Core.Optional.IsCollectionDefined(StaticIPConfiguration))
            {
                writer.WritePropertyName("staticIpConfiguration"u8);
                writer.WriteStartArray();
                foreach (var item in StaticIPConfiguration)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(AuthenticationKey))
            {
                writer.WritePropertyName("authenticationKey"u8);
                writer.WriteStringValue(AuthenticationKey);
            }
            if (Core.Optional.IsDefined(OperatorKeyCode))
            {
                writer.WritePropertyName("operatorKeyCode"u8);
                writer.WriteStringValue(OperatorKeyCode);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
