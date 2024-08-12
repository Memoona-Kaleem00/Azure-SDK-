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

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciNetworkProfile : IUtf8JsonSerializable, IJsonModel<HciNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HciNetworkProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HciNetworkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciNetworkProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(NicDetails))
            {
                writer.WritePropertyName("nicDetails"u8);
                writer.WriteStartArray();
                foreach (var item in NicDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SwitchDetails))
            {
                writer.WritePropertyName("switchDetails"u8);
                writer.WriteStartArray();
                foreach (var item in SwitchDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(HostNetwork))
            {
                writer.WritePropertyName("hostNetwork"u8);
                writer.WriteObjectValue(HostNetwork, options);
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

        HciNetworkProfile IJsonModel<HciNetworkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciNetworkProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHciNetworkProfile(document.RootElement, options);
        }

        internal static HciNetworkProfile DeserializeHciNetworkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<HciNicDetail> nicDetails = default;
            IReadOnlyList<HciEdgeDeviceSwitchDetail> switchDetails = default;
            HciClusterHostNetwork hostNetwork = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nicDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HciNicDetail> array = new List<HciNicDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HciNicDetail.DeserializeHciNicDetail(item, options));
                    }
                    nicDetails = array;
                    continue;
                }
                if (property.NameEquals("switchDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HciEdgeDeviceSwitchDetail> array = new List<HciEdgeDeviceSwitchDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HciEdgeDeviceSwitchDetail.DeserializeHciEdgeDeviceSwitchDetail(item, options));
                    }
                    switchDetails = array;
                    continue;
                }
                if (property.NameEquals("hostNetwork"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostNetwork = HciClusterHostNetwork.DeserializeHciClusterHostNetwork(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HciNetworkProfile(nicDetails ?? new ChangeTrackingList<HciNicDetail>(), switchDetails ?? new ChangeTrackingList<HciEdgeDeviceSwitchDetail>(), hostNetwork, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NicDetails), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  nicDetails: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(NicDetails))
                {
                    if (NicDetails.Any())
                    {
                        builder.Append("  nicDetails: ");
                        builder.AppendLine("[");
                        foreach (var item in NicDetails)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  nicDetails: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SwitchDetails), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  switchDetails: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SwitchDetails))
                {
                    if (SwitchDetails.Any())
                    {
                        builder.Append("  switchDetails: ");
                        builder.AppendLine("[");
                        foreach (var item in SwitchDetails)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  switchDetails: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HostNetwork), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  hostNetwork: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HostNetwork))
                {
                    builder.Append("  hostNetwork: ");
                    BicepSerializationHelpers.AppendChildObject(builder, HostNetwork, options, 2, false, "  hostNetwork: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<HciNetworkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(HciNetworkProfile)} does not support writing '{options.Format}' format.");
            }
        }

        HciNetworkProfile IPersistableModel<HciNetworkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHciNetworkProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HciNetworkProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HciNetworkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
