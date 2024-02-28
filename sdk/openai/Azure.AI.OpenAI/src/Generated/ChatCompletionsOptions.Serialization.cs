// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class ChatCompletionsOptions : IUtf8JsonSerializable, IJsonModel<ChatCompletionsOptions>
    {
        void IJsonModel<ChatCompletionsOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionsOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("messages"u8);
            writer.WriteStartArray();
            foreach (var item in Messages)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (!(Functions is ChangeTrackingList<FunctionDefinition> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("functions"u8);
                writer.WriteStartArray();
                foreach (var item in Functions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (FunctionCall != null)
            {
                writer.WritePropertyName("function_call"u8);
                writer.WriteObjectValue(FunctionCall);
            }
            if (MaxTokens.HasValue)
            {
                writer.WritePropertyName("max_tokens"u8);
                writer.WriteNumberValue(MaxTokens.Value);
            }
            if (Temperature.HasValue)
            {
                writer.WritePropertyName("temperature"u8);
                writer.WriteNumberValue(Temperature.Value);
            }
            if (NucleusSamplingFactor.HasValue)
            {
                writer.WritePropertyName("top_p"u8);
                writer.WriteNumberValue(NucleusSamplingFactor.Value);
            }
            if (!(TokenSelectionBiases is ChangeTrackingDictionary<int, int> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("logit_bias"u8);
                SerializeTokenSelectionBiases(writer);
            }
            if (User != null)
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(User);
            }
            if (ChoiceCount.HasValue)
            {
                writer.WritePropertyName("n"u8);
                writer.WriteNumberValue(ChoiceCount.Value);
            }
            if (!(StopSequences is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("stop"u8);
                writer.WriteStartArray();
                foreach (var item in StopSequences)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (PresencePenalty.HasValue)
            {
                writer.WritePropertyName("presence_penalty"u8);
                writer.WriteNumberValue(PresencePenalty.Value);
            }
            if (FrequencyPenalty.HasValue)
            {
                writer.WritePropertyName("frequency_penalty"u8);
                writer.WriteNumberValue(FrequencyPenalty.Value);
            }
            if (InternalShouldStreamResponse.HasValue)
            {
                writer.WritePropertyName("stream"u8);
                writer.WriteBooleanValue(InternalShouldStreamResponse.Value);
            }
            if (DeploymentName != null)
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(DeploymentName);
            }
            if (!(InternalAzureExtensionsDataSources is ChangeTrackingList<AzureChatExtensionConfiguration> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("dataSources"u8);
                writer.WriteStartArray();
                foreach (var item in InternalAzureExtensionsDataSources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Enhancements != null)
            {
                writer.WritePropertyName("enhancements"u8);
                writer.WriteObjectValue(Enhancements);
            }
            if (Seed.HasValue)
            {
                writer.WritePropertyName("seed"u8);
                writer.WriteNumberValue(Seed.Value);
            }
            if (ResponseFormat != null)
            {
                writer.WritePropertyName("response_format"u8);
                writer.WriteObjectValue(ResponseFormat);
            }
            if (!(Tools is ChangeTrackingList<ChatCompletionsToolDefinition> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("tools"u8);
                writer.WriteStartArray();
                foreach (var item in Tools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (InternalSuppressedToolChoice != null)
            {
                writer.WritePropertyName("tool_choice"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(InternalSuppressedToolChoice);
#else
                using (JsonDocument document = JsonDocument.Parse(InternalSuppressedToolChoice))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        ChatCompletionsOptions IJsonModel<ChatCompletionsOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionsOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatCompletionsOptions(document.RootElement, options);
        }

        internal static ChatCompletionsOptions DeserializeChatCompletionsOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ChatRequestMessage> messages = default;
            IList<FunctionDefinition> functions = default;
            FunctionDefinition functionCall = default;
            int? maxTokens = default;
            float? temperature = default;
            float? topP = default;
            IDictionary<int, int> logitBias = default;
            string user = default;
            int? n = default;
            IList<string> stop = default;
            float? presencePenalty = default;
            float? frequencyPenalty = default;
            bool? stream = default;
            string model = default;
            IList<AzureChatExtensionConfiguration> dataSources = default;
            AzureChatEnhancementConfiguration enhancements = default;
            long? seed = default;
            ChatCompletionsResponseFormat responseFormat = default;
            IList<ChatCompletionsToolDefinition> tools = default;
            BinaryData toolChoice = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messages"u8))
                {
                    List<ChatRequestMessage> array = new List<ChatRequestMessage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatRequestMessage.DeserializeChatRequestMessage(item, options));
                    }
                    messages = array;
                    continue;
                }
                if (property.NameEquals("functions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FunctionDefinition> array = new List<FunctionDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FunctionDefinition.DeserializeFunctionDefinition(item, options));
                    }
                    functions = array;
                    continue;
                }
                if (property.NameEquals("function_call"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    functionCall = FunctionDefinition.DeserializeFunctionDefinition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("max_tokens"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTokens = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("temperature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    temperature = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("top_p"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    topP = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("logit_bias"u8))
                {
                    DeserializeTokenSelectionBiases(property, ref logitBias);
                    continue;
                }
                if (property.NameEquals("user"u8))
                {
                    user = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("n"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    n = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("stop"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    stop = array;
                    continue;
                }
                if (property.NameEquals("presence_penalty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    presencePenalty = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("frequency_penalty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frequencyPenalty = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("stream"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stream = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureChatExtensionConfiguration> array = new List<AzureChatExtensionConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureChatExtensionConfiguration.DeserializeAzureChatExtensionConfiguration(item, options));
                    }
                    dataSources = array;
                    continue;
                }
                if (property.NameEquals("enhancements"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enhancements = AzureChatEnhancementConfiguration.DeserializeAzureChatEnhancementConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("seed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    seed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("response_format"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseFormat = ChatCompletionsResponseFormat.DeserializeChatCompletionsResponseFormat(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChatCompletionsToolDefinition> array = new List<ChatCompletionsToolDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatCompletionsToolDefinition.DeserializeChatCompletionsToolDefinition(item, options));
                    }
                    tools = array;
                    continue;
                }
                if (property.NameEquals("tool_choice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    toolChoice = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ChatCompletionsOptions(
                messages,
                functions ?? new ChangeTrackingList<FunctionDefinition>(),
                functionCall,
                maxTokens,
                temperature,
                topP,
                logitBias ?? new ChangeTrackingDictionary<int, int>(),
                user,
                n,
                stop ?? new ChangeTrackingList<string>(),
                presencePenalty,
                frequencyPenalty,
                stream,
                model,
                dataSources ?? new ChangeTrackingList<AzureChatExtensionConfiguration>(),
                enhancements,
                seed,
                responseFormat,
                tools ?? new ChangeTrackingList<ChatCompletionsToolDefinition>(),
                toolChoice,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChatCompletionsOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionsOptions)} does not support '{options.Format}' format.");
            }
        }

        ChatCompletionsOptions IPersistableModel<ChatCompletionsOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChatCompletionsOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionsOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatCompletionsOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ChatCompletionsOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChatCompletionsOptions(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
