// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.AI.OpenAI
{
    [PersistableModelProxy(typeof(UnknownChatCompletionsNamedToolSelection))]
    internal partial class ChatCompletionsNamedToolSelection : IUtf8JsonWriteable, IJsonModel<ChatCompletionsNamedToolSelection>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChatCompletionsNamedToolSelection>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ChatCompletionsNamedToolSelection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsNamedToolSelection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionsNamedToolSelection)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
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

        ChatCompletionsNamedToolSelection IJsonModel<ChatCompletionsNamedToolSelection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsNamedToolSelection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionsNamedToolSelection)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatCompletionsNamedToolSelection(document.RootElement, options);
        }

        internal static ChatCompletionsNamedToolSelection DeserializeChatCompletionsNamedToolSelection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "function": return ChatCompletionsNamedFunctionToolSelection.DeserializeChatCompletionsNamedFunctionToolSelection(element, options);
                }
            }
            return UnknownChatCompletionsNamedToolSelection.DeserializeUnknownChatCompletionsNamedToolSelection(element, options);
        }

        BinaryData IPersistableModel<ChatCompletionsNamedToolSelection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsNamedToolSelection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionsNamedToolSelection)} does not support '{options.Format}' format.");
            }
        }

        ChatCompletionsNamedToolSelection IPersistableModel<ChatCompletionsNamedToolSelection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsNamedToolSelection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChatCompletionsNamedToolSelection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionsNamedToolSelection)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatCompletionsNamedToolSelection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ChatCompletionsNamedToolSelection FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChatCompletionsNamedToolSelection(document.RootElement);
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
