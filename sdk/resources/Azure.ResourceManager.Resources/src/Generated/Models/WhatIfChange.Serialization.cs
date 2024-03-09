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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class WhatIfChange : IUtf8JsonSerializable, IJsonModel<WhatIfChange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WhatIfChange>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WhatIfChange>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatIfChange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WhatIfChange)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("resourceId"u8);
            writer.WriteStringValue(ResourceId);
            writer.WritePropertyName("changeType"u8);
            writer.WriteStringValue(ChangeType.ToSerialString());
            if (Optional.IsDefined(UnsupportedReason))
            {
                writer.WritePropertyName("unsupportedReason"u8);
                writer.WriteStringValue(UnsupportedReason);
            }
            if (Optional.IsDefined(Before))
            {
                writer.WritePropertyName("before"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Before);
#else
                using (JsonDocument document = JsonDocument.Parse(Before))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(After))
            {
                writer.WritePropertyName("after"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(After);
#else
                using (JsonDocument document = JsonDocument.Parse(After))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(Delta))
            {
                writer.WritePropertyName("delta"u8);
                writer.WriteStartArray();
                foreach (var item in Delta)
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

        WhatIfChange IJsonModel<WhatIfChange>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatIfChange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WhatIfChange)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWhatIfChange(document.RootElement, options);
        }

        internal static WhatIfChange DeserializeWhatIfChange(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceId = default;
            WhatIfChangeType changeType = default;
            string unsupportedReason = default;
            BinaryData before = default;
            BinaryData after = default;
            IReadOnlyList<WhatIfPropertyChange> delta = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("changeType"u8))
                {
                    changeType = property.Value.GetString().ToWhatIfChangeType();
                    continue;
                }
                if (property.NameEquals("unsupportedReason"u8))
                {
                    unsupportedReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("before"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    before = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("after"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    after = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("delta"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WhatIfPropertyChange> array = new List<WhatIfPropertyChange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WhatIfPropertyChange.DeserializeWhatIfPropertyChange(item, options));
                    }
                    delta = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WhatIfChange(
                resourceId,
                changeType,
                unsupportedReason,
                before,
                after,
                delta ?? new ChangeTrackingList<WhatIfPropertyChange>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceId), out propertyOverride);
            if (Optional.IsDefined(ResourceId) || hasPropertyOverride)
            {
                builder.Append("  resourceId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (ResourceId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ResourceId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ResourceId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ChangeType), out propertyOverride);
            builder.Append("  changeType: ");
            if (hasPropertyOverride)
            {
                builder.AppendLine($"{propertyOverride}");
            }
            else
            {
                builder.AppendLine($"'{ChangeType.ToSerialString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UnsupportedReason), out propertyOverride);
            if (Optional.IsDefined(UnsupportedReason) || hasPropertyOverride)
            {
                builder.Append("  unsupportedReason: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (UnsupportedReason.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UnsupportedReason}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UnsupportedReason}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Before), out propertyOverride);
            if (Optional.IsDefined(Before) || hasPropertyOverride)
            {
                builder.Append("  before: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{Before.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(After), out propertyOverride);
            if (Optional.IsDefined(After) || hasPropertyOverride)
            {
                builder.Append("  after: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{After.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Delta), out propertyOverride);
            if (Optional.IsCollectionDefined(Delta) || hasPropertyOverride)
            {
                if (Delta.Any() || hasPropertyOverride)
                {
                    builder.Append("  delta: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in Delta)
                        {
                            AppendChildObject(builder, item, options, 4, true, "  delta: ");
                        }
                        builder.AppendLine("  ]");
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

        BinaryData IPersistableModel<WhatIfChange>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatIfChange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WhatIfChange)} does not support '{options.Format}' format.");
            }
        }

        WhatIfChange IPersistableModel<WhatIfChange>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatIfChange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWhatIfChange(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(WhatIfChange)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WhatIfChange>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
