// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class MatchCondition : IUtf8JsonSerializable, IJsonModel<MatchCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MatchCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MatchCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MatchCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MatchCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("matchVariables"u8);
            writer.WriteStartArray();
            foreach (var item in MatchVariables)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("operator"u8);
            writer.WriteStringValue(Operator.ToString());
            if (NegationConditon.HasValue)
            {
                writer.WritePropertyName("negationConditon"u8);
                writer.WriteBooleanValue(NegationConditon.Value);
            }
            writer.WritePropertyName("matchValues"u8);
            writer.WriteStartArray();
            foreach (var item in MatchValues)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (!(Transforms is ChangeTrackingList<WebApplicationFirewallTransform> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("transforms"u8);
                writer.WriteStartArray();
                foreach (var item in Transforms)
                {
                    writer.WriteStringValue(item.ToString());
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

        MatchCondition IJsonModel<MatchCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MatchCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MatchCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMatchCondition(document.RootElement, options);
        }

        internal static MatchCondition DeserializeMatchCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MatchVariable> matchVariables = default;
            WebApplicationFirewallOperator @operator = default;
            bool? negationConditon = default;
            IList<string> matchValues = default;
            IList<WebApplicationFirewallTransform> transforms = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchVariables"u8))
                {
                    List<MatchVariable> array = new List<MatchVariable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MatchVariable.DeserializeMatchVariable(item, options));
                    }
                    matchVariables = array;
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    @operator = new WebApplicationFirewallOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("negationConditon"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    negationConditon = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("matchValues"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    matchValues = array;
                    continue;
                }
                if (property.NameEquals("transforms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebApplicationFirewallTransform> array = new List<WebApplicationFirewallTransform>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new WebApplicationFirewallTransform(item.GetString()));
                    }
                    transforms = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MatchCondition(
                matchVariables,
                @operator,
                negationConditon,
                matchValues,
                transforms ?? new ChangeTrackingList<WebApplicationFirewallTransform>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MatchCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MatchCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MatchCondition)} does not support '{options.Format}' format.");
            }
        }

        MatchCondition IPersistableModel<MatchCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MatchCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMatchCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MatchCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MatchCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
