// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ResourceSku : IUtf8JsonSerializable, IJsonModel<ResourceSku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceSku>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceSku>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceSku)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ResourceType != null)
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Tier != null)
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier);
            }
            if (options.Format != "W" && Size != null)
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size);
            }
            if (options.Format != "W" && Family != null)
            {
                writer.WritePropertyName("family"u8);
                writer.WriteStringValue(Family);
            }
            if (options.Format != "W" && Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W" && Capacity != null)
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteObjectValue(Capacity);
            }
            if (options.Format != "W" && !(Locations is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(ApiVersions is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("apiVersions"u8);
                writer.WriteStartArray();
                foreach (var item in ApiVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(Costs is ChangeTrackingList<ResourceSkuCosts> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("costs"u8);
                writer.WriteStartArray();
                foreach (var item in Costs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(Capabilities is ChangeTrackingList<ResourceSkuCapabilities> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(Restrictions is ChangeTrackingList<ResourceSkuRestrictions> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("restrictions"u8);
                writer.WriteStartArray();
                foreach (var item in Restrictions)
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

        ResourceSku IJsonModel<ResourceSku>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceSku)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceSku(document.RootElement, options);
        }

        internal static ResourceSku DeserializeResourceSku(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceType = default;
            Optional<string> name = default;
            Optional<string> tier = default;
            Optional<string> size = default;
            Optional<string> family = default;
            Optional<string> kind = default;
            Optional<ResourceSkuCapacity> capacity = default;
            IReadOnlyList<string> locations = default;
            IReadOnlyList<string> apiVersions = default;
            IReadOnlyList<ResourceSkuCosts> costs = default;
            IReadOnlyList<ResourceSkuCapabilities> capabilities = default;
            IReadOnlyList<ResourceSkuRestrictions> restrictions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("family"u8))
                {
                    family = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = ResourceSkuCapacity.DeserializeResourceSkuCapacity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("locations"u8))
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
                    locations = array;
                    continue;
                }
                if (property.NameEquals("apiVersions"u8))
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
                    apiVersions = array;
                    continue;
                }
                if (property.NameEquals("costs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceSkuCosts> array = new List<ResourceSkuCosts>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceSkuCosts.DeserializeResourceSkuCosts(item, options));
                    }
                    costs = array;
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceSkuCapabilities> array = new List<ResourceSkuCapabilities>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceSkuCapabilities.DeserializeResourceSkuCapabilities(item, options));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("restrictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceSkuRestrictions> array = new List<ResourceSkuRestrictions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceSkuRestrictions.DeserializeResourceSkuRestrictions(item, options));
                    }
                    restrictions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceSku(
                resourceType.Value,
                name.Value,
                tier.Value,
                size.Value,
                family.Value,
                kind.Value,
                capacity.Value,
                locations ?? new ChangeTrackingList<string>(),
                apiVersions ?? new ChangeTrackingList<string>(),
                costs ?? new ChangeTrackingList<ResourceSkuCosts>(),
                capabilities ?? new ChangeTrackingList<ResourceSkuCapabilities>(),
                restrictions ?? new ChangeTrackingList<ResourceSkuRestrictions>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceSku>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceSku)} does not support '{options.Format}' format.");
            }
        }

        ResourceSku IPersistableModel<ResourceSku>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceSku(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceSku)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceSku>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
