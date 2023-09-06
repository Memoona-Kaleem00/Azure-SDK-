// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseManagedIntegrationRuntimeError : IUtf8JsonSerializable, IModelJsonSerializable<SynapseManagedIntegrationRuntimeError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseManagedIntegrationRuntimeError>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseManagedIntegrationRuntimeError>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseManagedIntegrationRuntimeError>(this, options.Format);

            writer.WriteStartObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static SynapseManagedIntegrationRuntimeError DeserializeSynapseManagedIntegrationRuntimeError(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> time = default;
            Optional<string> code = default;
            Optional<IReadOnlyList<string>> parameters = default;
            Optional<string> message = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("time"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    time = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
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
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseManagedIntegrationRuntimeError(Optional.ToNullable(time), code.Value, Optional.ToList(parameters), message.Value, additionalProperties);
        }

        SynapseManagedIntegrationRuntimeError IModelJsonSerializable<SynapseManagedIntegrationRuntimeError>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseManagedIntegrationRuntimeError>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseManagedIntegrationRuntimeError(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseManagedIntegrationRuntimeError>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseManagedIntegrationRuntimeError>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseManagedIntegrationRuntimeError IModelSerializable<SynapseManagedIntegrationRuntimeError>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseManagedIntegrationRuntimeError>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseManagedIntegrationRuntimeError(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseManagedIntegrationRuntimeError"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseManagedIntegrationRuntimeError"/> to convert. </param>
        public static implicit operator RequestContent(SynapseManagedIntegrationRuntimeError model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseManagedIntegrationRuntimeError"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseManagedIntegrationRuntimeError(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseManagedIntegrationRuntimeError(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
