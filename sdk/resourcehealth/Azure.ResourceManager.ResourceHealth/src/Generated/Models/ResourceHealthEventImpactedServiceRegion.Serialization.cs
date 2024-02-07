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

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ResourceHealthEventImpactedServiceRegion : IUtf8JsonSerializable, IJsonModel<ResourceHealthEventImpactedServiceRegion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceHealthEventImpactedServiceRegion>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceHealthEventImpactedServiceRegion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventImpactedServiceRegion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthEventImpactedServiceRegion)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ImpactedRegion))
            {
                writer.WritePropertyName("impactedRegion"u8);
                writer.WriteStringValue(ImpactedRegion);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ImpactedSubscriptions))
            {
                writer.WritePropertyName("impactedSubscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in ImpactedSubscriptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ImpactedTenants))
            {
                writer.WritePropertyName("impactedTenants"u8);
                writer.WriteStartArray();
                foreach (var item in ImpactedTenants)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LastUpdateOn))
            {
                writer.WritePropertyName("lastUpdateTime"u8);
                writer.WriteStringValue(LastUpdateOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(Updates))
            {
                writer.WritePropertyName("updates"u8);
                writer.WriteStartArray();
                foreach (var item in Updates)
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

        ResourceHealthEventImpactedServiceRegion IJsonModel<ResourceHealthEventImpactedServiceRegion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventImpactedServiceRegion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthEventImpactedServiceRegion)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceHealthEventImpactedServiceRegion(document.RootElement, options);
        }

        internal static ResourceHealthEventImpactedServiceRegion DeserializeResourceHealthEventImpactedServiceRegion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> impactedRegion = default;
            Optional<ResourceHealthEventStatusValue> status = default;
            Optional<IReadOnlyList<string>> impactedSubscriptions = default;
            Optional<IReadOnlyList<string>> impactedTenants = default;
            Optional<DateTimeOffset> lastUpdateTime = default;
            Optional<IReadOnlyList<ResourceHealthEventUpdate>> updates = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("impactedRegion"u8))
                {
                    impactedRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ResourceHealthEventStatusValue(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("impactedSubscriptions"u8))
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
                    impactedSubscriptions = array;
                    continue;
                }
                if (property.NameEquals("impactedTenants"u8))
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
                    impactedTenants = array;
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceHealthEventUpdate> array = new List<ResourceHealthEventUpdate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceHealthEventUpdate.DeserializeResourceHealthEventUpdate(item));
                    }
                    updates = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceHealthEventImpactedServiceRegion(impactedRegion.Value, Optional.ToNullable(status), Optional.ToList(impactedSubscriptions), Optional.ToList(impactedTenants), Optional.ToNullable(lastUpdateTime), Optional.ToList(updates), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ImpactedRegion))
            {
                builder.Append("  impactedRegion:");
                if (ImpactedRegion.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ImpactedRegion}'''");
                }
                else
                {
                    builder.AppendLine($" '{ImpactedRegion}'");
                }
            }

            if (Optional.IsDefined(Status))
            {
                builder.Append("  status:");
                builder.AppendLine($" '{Status.Value.ToString()}'");
            }

            if (Optional.IsCollectionDefined(ImpactedSubscriptions))
            {
                if (ImpactedSubscriptions.Any())
                {
                    builder.Append("  impactedSubscriptions:");
                    builder.AppendLine(" [");
                    foreach (var item in ImpactedSubscriptions)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Contains(Environment.NewLine))
                        {
                            builder.AppendLine("    '''");
                            builder.AppendLine($"{item}'''");
                        }
                        else
                        {
                            builder.AppendLine($"    '{item}'");
                        }
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(ImpactedTenants))
            {
                if (ImpactedTenants.Any())
                {
                    builder.Append("  impactedTenants:");
                    builder.AppendLine(" [");
                    foreach (var item in ImpactedTenants)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Contains(Environment.NewLine))
                        {
                            builder.AppendLine("    '''");
                            builder.AppendLine($"{item}'''");
                        }
                        else
                        {
                            builder.AppendLine($"    '{item}'");
                        }
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(LastUpdateOn))
            {
                builder.Append("  lastUpdateTime:");
                var formattedDateTimeString = TypeFormatters.ToString(LastUpdateOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsCollectionDefined(Updates))
            {
                if (Updates.Any())
                {
                    builder.Append("  updates:");
                    builder.AppendLine(" [");
                    foreach (var item in Updates)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            bool inMultilineString = false;
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
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<ResourceHealthEventImpactedServiceRegion>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventImpactedServiceRegion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthEventImpactedServiceRegion)} does not support '{options.Format}' format.");
            }
        }

        ResourceHealthEventImpactedServiceRegion IPersistableModel<ResourceHealthEventImpactedServiceRegion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventImpactedServiceRegion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceHealthEventImpactedServiceRegion(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthEventImpactedServiceRegion)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceHealthEventImpactedServiceRegion>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
