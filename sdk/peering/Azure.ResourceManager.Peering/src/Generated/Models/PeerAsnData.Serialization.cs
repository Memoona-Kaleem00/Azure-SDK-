// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    public partial class PeerAsnData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(PeerAsn))
            {
                writer.WritePropertyName("peerAsn"u8);
                writer.WriteNumberValue(PeerAsn.Value);
            }
            if (Core.Optional.IsCollectionDefined(PeerContactDetail))
            {
                writer.WritePropertyName("peerContactDetail"u8);
                writer.WriteStartArray();
                foreach (var item in PeerContactDetail)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(PeerName))
            {
                writer.WritePropertyName("peerName"u8);
                writer.WriteStringValue(PeerName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PeerAsnData DeserializePeerAsnData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<int> peerAsn = default;
            Core.Optional<IList<PeerAsnContactDetail>> peerContactDetail = default;
            Core.Optional<string> peerName = default;
            Core.Optional<PeerAsnValidationState> validationState = default;
            Core.Optional<string> errorMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("peerAsn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peerAsn = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("peerContactDetail"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PeerAsnContactDetail> array = new List<PeerAsnContactDetail>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PeerAsnContactDetail.DeserializePeerAsnContactDetail(item));
                            }
                            peerContactDetail = array;
                            continue;
                        }
                        if (property0.NameEquals("peerName"u8))
                        {
                            peerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("validationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validationState = new PeerAsnValidationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errorMessage"u8))
                        {
                            errorMessage = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PeerAsnData(id, name, type, systemData.Value, Core.Optional.ToNullable(peerAsn), Core.Optional.ToList(peerContactDetail), peerName.Value, Core.Optional.ToNullable(validationState), errorMessage.Value);
        }
    }
}
