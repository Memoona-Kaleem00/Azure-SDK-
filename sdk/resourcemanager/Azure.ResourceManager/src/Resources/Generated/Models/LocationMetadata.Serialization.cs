// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class LocationMetadata : IUtf8JsonSerializable, IJsonModel<LocationMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LocationMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LocationMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocationMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LocationMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(RegionType))
            {
                writer.WritePropertyName("regionType"u8);
                writer.WriteStringValue(RegionType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(RegionCategory))
            {
                writer.WritePropertyName("regionCategory"u8);
                writer.WriteStringValue(RegionCategory.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Geography))
            {
                writer.WritePropertyName("geography"u8);
                writer.WriteStringValue(Geography);
            }
            if (options.Format != "W" && Optional.IsDefined(GeographyGroup))
            {
                writer.WritePropertyName("geographyGroup"u8);
                writer.WriteStringValue(GeographyGroup);
            }
            if (options.Format != "W" && Optional.IsDefined(Longitude))
            {
                writer.WritePropertyName("longitude"u8);
                WriteLongitude(writer);
            }
            if (options.Format != "W" && Optional.IsDefined(Latitude))
            {
                writer.WritePropertyName("latitude"u8);
                WriteLatitude(writer);
            }
            if (options.Format != "W" && Optional.IsDefined(PhysicalLocation))
            {
                writer.WritePropertyName("physicalLocation"u8);
                writer.WriteStringValue(PhysicalLocation);
            }
            if (Optional.IsCollectionDefined(PairedRegions))
            {
                writer.WritePropertyName("pairedRegion"u8);
                writer.WriteStartArray();
                foreach (var item in PairedRegions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(HomeLocation))
            {
                writer.WritePropertyName("homeLocation"u8);
                writer.WriteStringValue(HomeLocation);
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

        LocationMetadata IJsonModel<LocationMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocationMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LocationMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLocationMetadata(document.RootElement, options);
        }

        internal static LocationMetadata DeserializeLocationMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RegionType? regionType = default;
            RegionCategory? regionCategory = default;
            string geography = default;
            string geographyGroup = default;
            double? longitude = default;
            double? latitude = default;
            string physicalLocation = default;
            IReadOnlyList<PairedRegion> pairedRegion = default;
            string homeLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("regionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    regionType = new RegionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("regionCategory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    regionCategory = new RegionCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geography"u8))
                {
                    geography = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("geographyGroup"u8))
                {
                    geographyGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("longitude"u8))
                {
                    ReadLongitude(property, ref longitude);
                    continue;
                }
                if (property.NameEquals("latitude"u8))
                {
                    ReadLatitude(property, ref latitude);
                    continue;
                }
                if (property.NameEquals("physicalLocation"u8))
                {
                    physicalLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pairedRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PairedRegion> array = new List<PairedRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PairedRegion.DeserializePairedRegion(item, options));
                    }
                    pairedRegion = array;
                    continue;
                }
                if (property.NameEquals("homeLocation"u8))
                {
                    homeLocation = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LocationMetadata(
                regionType,
                regionCategory,
                geography,
                geographyGroup,
                longitude,
                latitude,
                physicalLocation,
                pairedRegion ?? new ChangeTrackingList<PairedRegion>(),
                homeLocation,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.ParameterOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RegionType), out propertyOverride);
            if (Optional.IsDefined(RegionType) || hasPropertyOverride)
            {
                builder.Append("  regionType: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{RegionType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RegionCategory), out propertyOverride);
            if (Optional.IsDefined(RegionCategory) || hasPropertyOverride)
            {
                builder.Append("  regionCategory: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{RegionCategory.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Geography), out propertyOverride);
            if (Optional.IsDefined(Geography) || hasPropertyOverride)
            {
                builder.Append("  geography: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Geography.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Geography}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Geography}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GeographyGroup), out propertyOverride);
            if (Optional.IsDefined(GeographyGroup) || hasPropertyOverride)
            {
                builder.Append("  geographyGroup: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (GeographyGroup.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{GeographyGroup}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{GeographyGroup}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Longitude), out propertyOverride);
            if (Optional.IsDefined(Longitude) || hasPropertyOverride)
            {
                builder.Append("  longitude: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{Longitude.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Latitude), out propertyOverride);
            if (Optional.IsDefined(Latitude) || hasPropertyOverride)
            {
                builder.Append("  latitude: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{Latitude.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PhysicalLocation), out propertyOverride);
            if (Optional.IsDefined(PhysicalLocation) || hasPropertyOverride)
            {
                builder.Append("  physicalLocation: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (PhysicalLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PhysicalLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PhysicalLocation}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PairedRegions), out propertyOverride);
            if (Optional.IsCollectionDefined(PairedRegions) || hasPropertyOverride)
            {
                if (PairedRegions.Any() || hasPropertyOverride)
                {
                    builder.Append("  pairedRegion: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in PairedRegions)
                        {
                            AppendChildObject(builder, item, options, 4, true, "  pairedRegion: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HomeLocation), out propertyOverride);
            if (Optional.IsDefined(HomeLocation) || hasPropertyOverride)
            {
                builder.Append("  homeLocation: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (HomeLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HomeLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HomeLocation}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine, string formattedPropertyName)
        {
            string indent = new string(' ', spaces);
            int emptyObjectLength = 2 + spaces + Environment.NewLine.Length + Environment.NewLine.Length;
            int length = stringBuilder.Length;
            bool inMultilineString = false;

            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($"{line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
            if (stringBuilder.Length == length + emptyObjectLength)
            {
                stringBuilder.Length = stringBuilder.Length - emptyObjectLength - formattedPropertyName.Length;
            }
        }

        BinaryData IPersistableModel<LocationMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocationMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(LocationMetadata)} does not support '{options.Format}' format.");
            }
        }

        LocationMetadata IPersistableModel<LocationMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocationMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLocationMetadata(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(LocationMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LocationMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
