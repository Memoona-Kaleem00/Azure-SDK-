// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.AI.OpenAI
{
    [PersistableModelProxy(typeof(UnknownAzureChatExtensionConfiguration))]
    public partial class AzureChatExtensionConfiguration : IUtf8JsonWriteable, IJsonModel<AzureChatExtensionConfiguration>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureChatExtensionConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureChatExtensionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatExtensionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureChatExtensionConfiguration)} does not support '{format}' format.");
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

        AzureChatExtensionConfiguration IJsonModel<AzureChatExtensionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatExtensionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureChatExtensionConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureChatExtensionConfiguration(document.RootElement, options);
        }

        internal static AzureChatExtensionConfiguration DeserializeAzureChatExtensionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "azure_search": return AzureSearchChatExtensionConfiguration.DeserializeAzureSearchChatExtensionConfiguration(element, options);
                    case "azure_ml_index": return AzureMachineLearningIndexChatExtensionConfiguration.DeserializeAzureMachineLearningIndexChatExtensionConfiguration(element, options);
                    case "azure_cosmos_db": return AzureCosmosDBChatExtensionConfiguration.DeserializeAzureCosmosDBChatExtensionConfiguration(element, options);
                    case "elasticsearch": return ElasticsearchChatExtensionConfiguration.DeserializeElasticsearchChatExtensionConfiguration(element, options);
                    case "pinecone": return PineconeChatExtensionConfiguration.DeserializePineconeChatExtensionConfiguration(element, options);
                }
            }
            return UnknownAzureChatExtensionConfiguration.DeserializeUnknownAzureChatExtensionConfiguration(element, options);
        }

        BinaryData IPersistableModel<AzureChatExtensionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatExtensionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureChatExtensionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        AzureChatExtensionConfiguration IPersistableModel<AzureChatExtensionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatExtensionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureChatExtensionConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureChatExtensionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureChatExtensionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static AzureChatExtensionConfiguration FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureChatExtensionConfiguration(document.RootElement);
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
