// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsIncidentEntitiesResult : IUtf8JsonSerializable, IJsonModel<SecurityInsightsIncidentEntitiesResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsIncidentEntitiesResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsIncidentEntitiesResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentEntitiesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIncidentEntitiesResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Entities))
            {
                writer.WritePropertyName("entities"u8);
                writer.WriteStartArray();
                foreach (var item in Entities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MetaData))
            {
                writer.WritePropertyName("metaData"u8);
                writer.WriteStartArray();
                foreach (var item in MetaData)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        SecurityInsightsIncidentEntitiesResult IJsonModel<SecurityInsightsIncidentEntitiesResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentEntitiesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIncidentEntitiesResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsIncidentEntitiesResult(document.RootElement, options);
        }

        internal static SecurityInsightsIncidentEntitiesResult DeserializeSecurityInsightsIncidentEntitiesResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SecurityInsightsEntity> entities = default;
            IReadOnlyList<SecurityInsightsIncidentEntitiesMetadata> metaData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityInsightsEntity> array = new List<SecurityInsightsEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityInsightsEntity.DeserializeSecurityInsightsEntity(item, options));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("metaData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityInsightsIncidentEntitiesMetadata> array = new List<SecurityInsightsIncidentEntitiesMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityInsightsIncidentEntitiesMetadata.DeserializeSecurityInsightsIncidentEntitiesMetadata(item, options));
                    }
                    metaData = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsIncidentEntitiesResult(entities ?? new ChangeTrackingList<SecurityInsightsEntity>(), metaData ?? new ChangeTrackingList<SecurityInsightsIncidentEntitiesMetadata>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityInsightsIncidentEntitiesResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentEntitiesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsIncidentEntitiesResult)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsIncidentEntitiesResult IPersistableModel<SecurityInsightsIncidentEntitiesResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentEntitiesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsIncidentEntitiesResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsIncidentEntitiesResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsIncidentEntitiesResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
