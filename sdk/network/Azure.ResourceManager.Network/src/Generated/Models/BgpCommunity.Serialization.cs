// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class BgpCommunity : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ServiceSupportedRegion))
            {
                writer.WritePropertyName("serviceSupportedRegion"u8);
                writer.WriteStringValue(ServiceSupportedRegion);
            }
            if (Core.Optional.IsDefined(CommunityName))
            {
                writer.WritePropertyName("communityName"u8);
                writer.WriteStringValue(CommunityName);
            }
            if (Core.Optional.IsDefined(CommunityValue))
            {
                writer.WritePropertyName("communityValue"u8);
                writer.WriteStringValue(CommunityValue);
            }
            if (Core.Optional.IsCollectionDefined(CommunityPrefixes))
            {
                writer.WritePropertyName("communityPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in CommunityPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(IsAuthorizedToUse))
            {
                writer.WritePropertyName("isAuthorizedToUse"u8);
                writer.WriteBooleanValue(IsAuthorizedToUse.Value);
            }
            if (Core.Optional.IsDefined(ServiceGroup))
            {
                writer.WritePropertyName("serviceGroup"u8);
                writer.WriteStringValue(ServiceGroup);
            }
            writer.WriteEndObject();
        }

        internal static BgpCommunity DeserializeBgpCommunity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> serviceSupportedRegion = default;
            Core.Optional<string> communityName = default;
            Core.Optional<string> communityValue = default;
            Core.Optional<IList<string>> communityPrefixes = default;
            Core.Optional<bool> isAuthorizedToUse = default;
            Core.Optional<string> serviceGroup = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceSupportedRegion"u8))
                {
                    serviceSupportedRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityName"u8))
                {
                    communityName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityValue"u8))
                {
                    communityValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    communityPrefixes = array;
                    continue;
                }
                if (property.NameEquals("isAuthorizedToUse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAuthorizedToUse = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("serviceGroup"u8))
                {
                    serviceGroup = property.Value.GetString();
                    continue;
                }
            }
            return new BgpCommunity(serviceSupportedRegion.Value, communityName.Value, communityValue.Value, Core.Optional.ToList(communityPrefixes), Core.Optional.ToNullable(isAuthorizedToUse), serviceGroup.Value);
        }
    }
}
