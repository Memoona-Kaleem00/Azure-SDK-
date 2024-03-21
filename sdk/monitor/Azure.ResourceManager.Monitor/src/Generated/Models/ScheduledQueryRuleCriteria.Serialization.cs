// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class ScheduledQueryRuleCriteria : IUtf8JsonSerializable, IJsonModel<ScheduledQueryRuleCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScheduledQueryRuleCriteria>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScheduledQueryRuleCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRuleCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduledQueryRuleCriteria)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllOf))
            {
                writer.WritePropertyName("allOf"u8);
                writer.WriteStartArray();
                foreach (var item in AllOf)
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

        ScheduledQueryRuleCriteria IJsonModel<ScheduledQueryRuleCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRuleCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduledQueryRuleCriteria)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduledQueryRuleCriteria(document.RootElement, options);
        }

        internal static ScheduledQueryRuleCriteria DeserializeScheduledQueryRuleCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ScheduledQueryRuleCondition> allOf = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allOf"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScheduledQueryRuleCondition> array = new List<ScheduledQueryRuleCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScheduledQueryRuleCondition.DeserializeScheduledQueryRuleCondition(item, options));
                    }
                    allOf = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScheduledQueryRuleCriteria(allOf ?? new ChangeTrackingList<ScheduledQueryRuleCondition>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScheduledQueryRuleCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRuleCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScheduledQueryRuleCriteria)} does not support '{options.Format}' format.");
            }
        }

        ScheduledQueryRuleCriteria IPersistableModel<ScheduledQueryRuleCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRuleCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScheduledQueryRuleCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScheduledQueryRuleCriteria)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScheduledQueryRuleCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
