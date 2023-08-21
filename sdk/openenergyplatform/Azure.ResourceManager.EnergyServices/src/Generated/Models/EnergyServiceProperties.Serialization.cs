// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EnergyServices.Models
{
    public partial class EnergyServiceProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(AuthAppId))
            {
                writer.WritePropertyName("authAppId"u8);
                writer.WriteStringValue(AuthAppId);
            }
            if (Core.Optional.IsCollectionDefined(DataPartitionNames))
            {
                writer.WritePropertyName("dataPartitionNames"u8);
                writer.WriteStartArray();
                foreach (var item in DataPartitionNames)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static EnergyServiceProperties DeserializeEnergyServiceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> dnsName = default;
            Core.Optional<ProvisioningState> provisioningState = default;
            Core.Optional<string> authAppId = default;
            Core.Optional<IList<DataPartitionName>> dataPartitionNames = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dnsName"u8))
                {
                    dnsName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authAppId"u8))
                {
                    authAppId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataPartitionNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataPartitionName> array = new List<DataPartitionName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataPartitionName.DeserializeDataPartitionName(item));
                    }
                    dataPartitionNames = array;
                    continue;
                }
            }
            return new EnergyServiceProperties(dnsName.Value, Core.Optional.ToNullable(provisioningState), authAppId.Value, Core.Optional.ToList(dataPartitionNames));
        }
    }
}
