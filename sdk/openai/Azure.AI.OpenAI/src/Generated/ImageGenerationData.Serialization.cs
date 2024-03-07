// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.OpenAI
{
    public partial class ImageGenerationData : IUtf8JsonWriteable, IJsonModel<ImageGenerationData>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageGenerationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImageGenerationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageGenerationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageGenerationData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Url.AbsoluteUri);
            }
            if (Optional.IsDefined(Base64Data))
            {
                writer.WritePropertyName("b64_json"u8);
                writer.WriteStringValue(Base64Data);
            }
            if (Optional.IsDefined(ContentFilterResults))
            {
                writer.WritePropertyName("content_filter_results"u8);
                writer.WriteObjectValue(ContentFilterResults);
            }
            if (Optional.IsDefined(RevisedPrompt))
            {
                writer.WritePropertyName("revised_prompt"u8);
                writer.WriteStringValue(RevisedPrompt);
            }
            if (Optional.IsDefined(PromptFilterResults))
            {
                writer.WritePropertyName("prompt_filter_results"u8);
                writer.WriteObjectValue(PromptFilterResults);
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

        ImageGenerationData IJsonModel<ImageGenerationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageGenerationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageGenerationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageGenerationData(document.RootElement, options);
        }

        internal static ImageGenerationData DeserializeImageGenerationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri url = default;
            string b64Json = default;
            ImageGenerationContentFilterResults contentFilterResults = default;
            string revisedPrompt = default;
            ImageGenerationPromptFilterResults promptFilterResults = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("b64_json"u8))
                {
                    b64Json = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("content_filter_results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentFilterResults = ImageGenerationContentFilterResults.DeserializeImageGenerationContentFilterResults(property.Value, options);
                    continue;
                }
                if (property.NameEquals("revised_prompt"u8))
                {
                    revisedPrompt = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("prompt_filter_results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    promptFilterResults = ImageGenerationPromptFilterResults.DeserializeImageGenerationPromptFilterResults(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageGenerationData(
                url,
                b64Json,
                contentFilterResults,
                revisedPrompt,
                promptFilterResults,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImageGenerationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageGenerationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImageGenerationData)} does not support '{options.Format}' format.");
            }
        }

        ImageGenerationData IPersistableModel<ImageGenerationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageGenerationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageGenerationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageGenerationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageGenerationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ImageGenerationData FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeImageGenerationData(document.RootElement);
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
