// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class SavingsPlanUtilizationAggregates : IUtf8JsonSerializable, IJsonModel<SavingsPlanUtilizationAggregates>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SavingsPlanUtilizationAggregates>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SavingsPlanUtilizationAggregates>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanUtilizationAggregates>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanUtilizationAggregates)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Grain))
            {
                writer.WritePropertyName("grain"u8);
                writer.WriteNumberValue(Grain.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(GrainUnit))
            {
                writer.WritePropertyName("grainUnit"u8);
                writer.WriteStringValue(GrainUnit);
            }
            if (options.Format != "W" && Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ValueUnit))
            {
                writer.WritePropertyName("valueUnit"u8);
                writer.WriteStringValue(ValueUnit);
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

        SavingsPlanUtilizationAggregates IJsonModel<SavingsPlanUtilizationAggregates>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanUtilizationAggregates>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanUtilizationAggregates)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSavingsPlanUtilizationAggregates(document.RootElement, options);
        }

        internal static SavingsPlanUtilizationAggregates DeserializeSavingsPlanUtilizationAggregates(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? grain = default;
            string grainUnit = default;
            float? value = default;
            string valueUnit = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("grain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    grain = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("grainUnit"u8))
                {
                    grainUnit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("valueUnit"u8))
                {
                    valueUnit = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SavingsPlanUtilizationAggregates(grain, grainUnit, value, valueUnit, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Grain), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  grain: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Grain))
                {
                    builder.Append("  grain: ");
                    builder.AppendLine($"'{Grain.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GrainUnit), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  grainUnit: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GrainUnit))
                {
                    builder.Append("  grainUnit: ");
                    if (GrainUnit.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{GrainUnit}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{GrainUnit}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Value), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  value: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Value))
                {
                    builder.Append("  value: ");
                    builder.AppendLine($"'{Value.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ValueUnit), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  valueUnit: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ValueUnit))
                {
                    builder.Append("  valueUnit: ");
                    if (ValueUnit.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ValueUnit}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ValueUnit}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SavingsPlanUtilizationAggregates>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanUtilizationAggregates>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanUtilizationAggregates)} does not support writing '{options.Format}' format.");
            }
        }

        SavingsPlanUtilizationAggregates IPersistableModel<SavingsPlanUtilizationAggregates>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanUtilizationAggregates>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSavingsPlanUtilizationAggregates(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanUtilizationAggregates)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SavingsPlanUtilizationAggregates>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
