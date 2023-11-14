// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(TumblingWindowTriggerDependencyReferenceConverter))]
    public partial class TumblingWindowTriggerDependencyReference : IUtf8JsonSerializable, IJsonModel<TumblingWindowTriggerDependencyReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TumblingWindowTriggerDependencyReference>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<TumblingWindowTriggerDependencyReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<TumblingWindowTriggerDependencyReference>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<TumblingWindowTriggerDependencyReference>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Offset))
            {
                writer.WritePropertyName("offset"u8);
                writer.WriteStringValue(Offset);
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size);
            }
            writer.WritePropertyName("referenceTrigger"u8);
            writer.WriteObjectValue(ReferenceTrigger);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        TumblingWindowTriggerDependencyReference IJsonModel<TumblingWindowTriggerDependencyReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TumblingWindowTriggerDependencyReference)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTumblingWindowTriggerDependencyReference(document.RootElement, options);
        }

        internal static TumblingWindowTriggerDependencyReference DeserializeTumblingWindowTriggerDependencyReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> offset = default;
            Optional<string> size = default;
            TriggerReference referenceTrigger = default;
            string type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("referenceTrigger"u8))
                {
                    referenceTrigger = TriggerReference.DeserializeTriggerReference(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TumblingWindowTriggerDependencyReference(type, serializedAdditionalRawData, referenceTrigger, offset.Value, size.Value);
        }

        BinaryData IPersistableModel<TumblingWindowTriggerDependencyReference>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TumblingWindowTriggerDependencyReference)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        TumblingWindowTriggerDependencyReference IPersistableModel<TumblingWindowTriggerDependencyReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TumblingWindowTriggerDependencyReference)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeTumblingWindowTriggerDependencyReference(document.RootElement, options);
        }

        string IPersistableModel<TumblingWindowTriggerDependencyReference>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class TumblingWindowTriggerDependencyReferenceConverter : JsonConverter<TumblingWindowTriggerDependencyReference>
        {
            public override void Write(Utf8JsonWriter writer, TumblingWindowTriggerDependencyReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TumblingWindowTriggerDependencyReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTumblingWindowTriggerDependencyReference(document.RootElement);
            }
        }
    }
}
