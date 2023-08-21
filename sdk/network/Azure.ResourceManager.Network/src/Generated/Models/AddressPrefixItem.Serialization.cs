// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AddressPrefixItem : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix"u8);
                writer.WriteStringValue(AddressPrefix);
            }
            if (Core.Optional.IsDefined(AddressPrefixType))
            {
                writer.WritePropertyName("addressPrefixType"u8);
                writer.WriteStringValue(AddressPrefixType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AddressPrefixItem DeserializeAddressPrefixItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> addressPrefix = default;
            Core.Optional<AddressPrefixType> addressPrefixType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressPrefix"u8))
                {
                    addressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressPrefixType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    addressPrefixType = new AddressPrefixType(property.Value.GetString());
                    continue;
                }
            }
            return new AddressPrefixItem(addressPrefix.Value, Core.Optional.ToNullable(addressPrefixType));
        }
    }
}
