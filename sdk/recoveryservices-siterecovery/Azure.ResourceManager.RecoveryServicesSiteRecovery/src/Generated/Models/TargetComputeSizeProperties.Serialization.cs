// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class TargetComputeSizeProperties : IUtf8JsonSerializable, IJsonModel<TargetComputeSizeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TargetComputeSizeProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TargetComputeSizeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetComputeSizeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TargetComputeSizeProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(CpuCoresCount))
            {
                writer.WritePropertyName("cpuCoresCount"u8);
                writer.WriteNumberValue(CpuCoresCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(VCpusAvailable))
            {
                writer.WritePropertyName("vCPUsAvailable"u8);
                writer.WriteNumberValue(VCpusAvailable.Value);
            }
            if (Optional.IsDefined(MemoryInGB))
            {
                writer.WritePropertyName("memoryInGB"u8);
                writer.WriteNumberValue(MemoryInGB.Value);
            }
            if (Optional.IsDefined(MaxDataDiskCount))
            {
                writer.WritePropertyName("maxDataDiskCount"u8);
                writer.WriteNumberValue(MaxDataDiskCount.Value);
            }
            if (Optional.IsDefined(MaxNicsCount))
            {
                writer.WritePropertyName("maxNicsCount"u8);
                writer.WriteNumberValue(MaxNicsCount.Value);
            }
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue<SiteRecoveryComputeSizeErrorDetails>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HighIopsSupported))
            {
                writer.WritePropertyName("highIopsSupported"u8);
                writer.WriteStringValue(HighIopsSupported);
            }
            if (Optional.IsCollectionDefined(HyperVGenerations))
            {
                writer.WritePropertyName("hyperVGenerations"u8);
                writer.WriteStartArray();
                foreach (var item in HyperVGenerations)
                {
                    writer.WriteStringValue(item);
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

        TargetComputeSizeProperties IJsonModel<TargetComputeSizeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetComputeSizeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TargetComputeSizeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTargetComputeSizeProperties(document.RootElement, options);
        }

        internal static TargetComputeSizeProperties DeserializeTargetComputeSizeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string friendlyName = default;
            int? cpuCoresCount = default;
            int? vCpusAvailable = default;
            double? memoryInGB = default;
            int? maxDataDiskCount = default;
            int? maxNicsCount = default;
            IReadOnlyList<SiteRecoveryComputeSizeErrorDetails> errors = default;
            string highIopsSupported = default;
            IReadOnlyList<string> hyperVGenerations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuCoresCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuCoresCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vCPUsAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vCpusAvailable = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("memoryInGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryInGB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maxDataDiskCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDataDiskCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxNicsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxNicsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryComputeSizeErrorDetails> array = new List<SiteRecoveryComputeSizeErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryComputeSizeErrorDetails.DeserializeSiteRecoveryComputeSizeErrorDetails(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("highIopsSupported"u8))
                {
                    highIopsSupported = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hyperVGenerations"u8))
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
                    hyperVGenerations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TargetComputeSizeProperties(
                name,
                friendlyName,
                cpuCoresCount,
                vCpusAvailable,
                memoryInGB,
                maxDataDiskCount,
                maxNicsCount,
                errors ?? new ChangeTrackingList<SiteRecoveryComputeSizeErrorDetails>(),
                highIopsSupported,
                hyperVGenerations ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TargetComputeSizeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetComputeSizeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TargetComputeSizeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        TargetComputeSizeProperties IPersistableModel<TargetComputeSizeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TargetComputeSizeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTargetComputeSizeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TargetComputeSizeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TargetComputeSizeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
