// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class OwaspCrsExclusionEntry : IUtf8JsonSerializable, IJsonModel<OwaspCrsExclusionEntry>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OwaspCrsExclusionEntry>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OwaspCrsExclusionEntry>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OwaspCrsExclusionEntry>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OwaspCrsExclusionEntry)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("matchVariable"u8);
            writer.WriteStringValue(MatchVariable.ToString());
            writer.WritePropertyName("selectorMatchOperator"u8);
            writer.WriteStringValue(SelectorMatchOperator.ToString());
            writer.WritePropertyName("selector"u8);
            writer.WriteStringValue(Selector);
            if (Optional.IsCollectionDefined(ExclusionManagedRuleSets))
            {
                writer.WritePropertyName("exclusionManagedRuleSets"u8);
                writer.WriteStartArray();
                foreach (var item in ExclusionManagedRuleSets)
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

        OwaspCrsExclusionEntry IJsonModel<OwaspCrsExclusionEntry>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OwaspCrsExclusionEntry>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OwaspCrsExclusionEntry)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOwaspCrsExclusionEntry(document.RootElement, options);
        }

        internal static OwaspCrsExclusionEntry DeserializeOwaspCrsExclusionEntry(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OwaspCrsExclusionEntryMatchVariable matchVariable = default;
            OwaspCrsExclusionEntrySelectorMatchOperator selectorMatchOperator = default;
            string selector = default;
            Optional<IList<ExclusionManagedRuleSet>> exclusionManagedRuleSets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchVariable"u8))
                {
                    matchVariable = new OwaspCrsExclusionEntryMatchVariable(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selectorMatchOperator"u8))
                {
                    selectorMatchOperator = new OwaspCrsExclusionEntrySelectorMatchOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selector"u8))
                {
                    selector = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exclusionManagedRuleSets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExclusionManagedRuleSet> array = new List<ExclusionManagedRuleSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExclusionManagedRuleSet.DeserializeExclusionManagedRuleSet(item, options));
                    }
                    exclusionManagedRuleSets = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OwaspCrsExclusionEntry(matchVariable, selectorMatchOperator, selector, Optional.ToList(exclusionManagedRuleSets), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OwaspCrsExclusionEntry>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OwaspCrsExclusionEntry>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OwaspCrsExclusionEntry)} does not support '{options.Format}' format.");
            }
        }

        OwaspCrsExclusionEntry IPersistableModel<OwaspCrsExclusionEntry>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OwaspCrsExclusionEntry>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOwaspCrsExclusionEntry(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OwaspCrsExclusionEntry)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OwaspCrsExclusionEntry>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
