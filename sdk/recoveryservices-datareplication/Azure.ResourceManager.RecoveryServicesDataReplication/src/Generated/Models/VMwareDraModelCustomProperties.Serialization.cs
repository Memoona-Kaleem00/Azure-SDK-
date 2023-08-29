// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class VMwareDraModelCustomProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("biosId"u8);
            writer.WriteStringValue(BiosId);
            writer.WritePropertyName("marsAuthenticationIdentity"u8);
            writer.WriteObjectValue(MarsAuthenticationIdentity);
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }

        internal static VMwareDraModelCustomProperties DeserializeVMwareDraModelCustomProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string biosId = default;
            IdentityModel marsAuthenticationIdentity = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("biosId"u8))
                {
                    biosId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("marsAuthenticationIdentity"u8))
                {
                    marsAuthenticationIdentity = IdentityModel.DeserializeIdentityModel(property.Value);
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new VMwareDraModelCustomProperties(instanceType, biosId, marsAuthenticationIdentity);
        }
    }
}
