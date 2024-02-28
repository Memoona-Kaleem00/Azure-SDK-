// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class RelationshipLinkResourceFormatData : IUtf8JsonSerializable, IJsonModel<RelationshipLinkResourceFormatData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RelationshipLinkResourceFormatData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RelationshipLinkResourceFormatData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipLinkResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RelationshipLinkResourceFormatData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (!(DisplayName is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStartObject();
                foreach (var item in DisplayName)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Description is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStartObject();
                foreach (var item in Description)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (InteractionType != null)
            {
                writer.WritePropertyName("interactionType"u8);
                writer.WriteStringValue(InteractionType);
            }
            if (options.Format != "W" && LinkName != null)
            {
                writer.WritePropertyName("linkName"u8);
                writer.WriteStringValue(LinkName);
            }
            if (!(Mappings is ChangeTrackingList<RelationshipLinkFieldMapping> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("mappings"u8);
                writer.WriteStartArray();
                foreach (var item in Mappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ProfilePropertyReferences is ChangeTrackingList<ParticipantProfilePropertyReference> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("profilePropertyReferences"u8);
                writer.WriteStartArray();
                foreach (var item in ProfilePropertyReferences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (!(RelatedProfilePropertyReferences is ChangeTrackingList<ParticipantProfilePropertyReference> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("relatedProfilePropertyReferences"u8);
                writer.WriteStartArray();
                foreach (var item in RelatedProfilePropertyReferences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (RelationshipName != null)
            {
                writer.WritePropertyName("relationshipName"u8);
                writer.WriteStringValue(RelationshipName);
            }
            if (options.Format != "W" && RelationshipGuidId != null)
            {
                writer.WritePropertyName("relationshipGuidId"u8);
                writer.WriteStringValue(RelationshipGuidId);
            }
            if (options.Format != "W" && TenantId.HasValue)
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RelationshipLinkResourceFormatData IJsonModel<RelationshipLinkResourceFormatData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipLinkResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RelationshipLinkResourceFormatData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRelationshipLinkResourceFormatData(document.RootElement, options);
        }

        internal static RelationshipLinkResourceFormatData DeserializeRelationshipLinkResourceFormatData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IDictionary<string, string> displayName = default;
            IDictionary<string, string> description = default;
            string interactionType = default;
            string linkName = default;
            IList<RelationshipLinkFieldMapping> mappings = default;
            IList<ParticipantProfilePropertyReference> profilePropertyReferences = default;
            ProvisioningState? provisioningState = default;
            IList<ParticipantProfilePropertyReference> relatedProfilePropertyReferences = default;
            string relationshipName = default;
            string relationshipGuidId = default;
            Guid? tenantId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            displayName = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            description = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("interactionType"u8))
                        {
                            interactionType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("linkName"u8))
                        {
                            linkName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("mappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RelationshipLinkFieldMapping> array = new List<RelationshipLinkFieldMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RelationshipLinkFieldMapping.DeserializeRelationshipLinkFieldMapping(item, options));
                            }
                            mappings = array;
                            continue;
                        }
                        if (property0.NameEquals("profilePropertyReferences"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ParticipantProfilePropertyReference> array = new List<ParticipantProfilePropertyReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ParticipantProfilePropertyReference.DeserializeParticipantProfilePropertyReference(item, options));
                            }
                            profilePropertyReferences = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("relatedProfilePropertyReferences"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ParticipantProfilePropertyReference> array = new List<ParticipantProfilePropertyReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ParticipantProfilePropertyReference.DeserializeParticipantProfilePropertyReference(item, options));
                            }
                            relatedProfilePropertyReferences = array;
                            continue;
                        }
                        if (property0.NameEquals("relationshipName"u8))
                        {
                            relationshipName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("relationshipGuidId"u8))
                        {
                            relationshipGuidId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RelationshipLinkResourceFormatData(
                id,
                name,
                type,
                systemData,
                displayName ?? new ChangeTrackingDictionary<string, string>(),
                description ?? new ChangeTrackingDictionary<string, string>(),
                interactionType,
                linkName,
                mappings ?? new ChangeTrackingList<RelationshipLinkFieldMapping>(),
                profilePropertyReferences ?? new ChangeTrackingList<ParticipantProfilePropertyReference>(),
                provisioningState,
                relatedProfilePropertyReferences ?? new ChangeTrackingList<ParticipantProfilePropertyReference>(),
                relationshipName,
                relationshipGuidId,
                tenantId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RelationshipLinkResourceFormatData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipLinkResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RelationshipLinkResourceFormatData)} does not support '{options.Format}' format.");
            }
        }

        RelationshipLinkResourceFormatData IPersistableModel<RelationshipLinkResourceFormatData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelationshipLinkResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRelationshipLinkResourceFormatData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RelationshipLinkResourceFormatData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RelationshipLinkResourceFormatData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
