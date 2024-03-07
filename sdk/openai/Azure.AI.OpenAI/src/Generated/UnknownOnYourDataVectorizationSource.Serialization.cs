// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.OpenAI
{
    internal partial class UnknownOnYourDataVectorizationSource : IUtf8JsonWriteable, IJsonModel<OnYourDataVectorizationSource>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<OnYourDataVectorizationSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OnYourDataVectorizationSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataVectorizationSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OnYourDataVectorizationSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
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

        OnYourDataVectorizationSource IJsonModel<OnYourDataVectorizationSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataVectorizationSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OnYourDataVectorizationSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOnYourDataVectorizationSource(document.RootElement, options);
        }

        internal static UnknownOnYourDataVectorizationSource DeserializeUnknownOnYourDataVectorizationSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OnYourDataVectorizationSourceType type = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new OnYourDataVectorizationSourceType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownOnYourDataVectorizationSource(type, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OnYourDataVectorizationSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataVectorizationSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OnYourDataVectorizationSource)} does not support '{options.Format}' format.");
            }
        }

        OnYourDataVectorizationSource IPersistableModel<OnYourDataVectorizationSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataVectorizationSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOnYourDataVectorizationSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OnYourDataVectorizationSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OnYourDataVectorizationSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static new UnknownOnYourDataVectorizationSource FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnknownOnYourDataVectorizationSource(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual RequestBody ToRequestBody()
        {
            var content = new Utf8JsonRequestBody();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
