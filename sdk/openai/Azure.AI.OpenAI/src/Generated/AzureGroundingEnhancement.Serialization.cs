// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.OpenAI
{
    public partial class AzureGroundingEnhancement : IUtf8JsonWriteable, IJsonModel<AzureGroundingEnhancement>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureGroundingEnhancement>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureGroundingEnhancement>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureGroundingEnhancement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureGroundingEnhancement)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("lines"u8);
            writer.WriteStartArray();
            foreach (var item in Lines)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        AzureGroundingEnhancement IJsonModel<AzureGroundingEnhancement>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureGroundingEnhancement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureGroundingEnhancement)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureGroundingEnhancement(document.RootElement, options);
        }

        internal static AzureGroundingEnhancement DeserializeAzureGroundingEnhancement(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AzureGroundingEnhancementLine> lines = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lines"u8))
                {
                    List<AzureGroundingEnhancementLine> array = new List<AzureGroundingEnhancementLine>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureGroundingEnhancementLine.DeserializeAzureGroundingEnhancementLine(item, options));
                    }
                    lines = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureGroundingEnhancement(lines, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureGroundingEnhancement>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureGroundingEnhancement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureGroundingEnhancement)} does not support '{options.Format}' format.");
            }
        }

        AzureGroundingEnhancement IPersistableModel<AzureGroundingEnhancement>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureGroundingEnhancement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureGroundingEnhancement(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureGroundingEnhancement)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureGroundingEnhancement>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static AzureGroundingEnhancement FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureGroundingEnhancement(document.RootElement);
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
