// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(AzureDatabricksDeltaLakeImportCommandConverter))]
    public partial class AzureDatabricksDeltaLakeImportCommand : IUtf8JsonSerializable, IModelJsonSerializable<AzureDatabricksDeltaLakeImportCommand>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AzureDatabricksDeltaLakeImportCommand>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AzureDatabricksDeltaLakeImportCommand>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDatabricksDeltaLakeImportCommand>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DateFormat))
            {
                writer.WritePropertyName("dateFormat"u8);
                writer.WriteObjectValue(DateFormat);
            }
            if (Optional.IsDefined(TimestampFormat))
            {
                writer.WritePropertyName("timestampFormat"u8);
                writer.WriteObjectValue(TimestampFormat);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzureDatabricksDeltaLakeImportCommand DeserializeAzureDatabricksDeltaLakeImportCommand(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> dateFormat = default;
            Optional<object> timestampFormat = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateFormat = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("timestampFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestampFormat = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureDatabricksDeltaLakeImportCommand(type, additionalProperties, dateFormat.Value, timestampFormat.Value);
        }

        AzureDatabricksDeltaLakeImportCommand IModelJsonSerializable<AzureDatabricksDeltaLakeImportCommand>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDatabricksDeltaLakeImportCommand>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDatabricksDeltaLakeImportCommand(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureDatabricksDeltaLakeImportCommand>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDatabricksDeltaLakeImportCommand>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureDatabricksDeltaLakeImportCommand IModelSerializable<AzureDatabricksDeltaLakeImportCommand>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureDatabricksDeltaLakeImportCommand>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureDatabricksDeltaLakeImportCommand(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AzureDatabricksDeltaLakeImportCommand"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AzureDatabricksDeltaLakeImportCommand"/> to convert. </param>
        public static implicit operator RequestContent(AzureDatabricksDeltaLakeImportCommand model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AzureDatabricksDeltaLakeImportCommand"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AzureDatabricksDeltaLakeImportCommand(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureDatabricksDeltaLakeImportCommand(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class AzureDatabricksDeltaLakeImportCommandConverter : JsonConverter<AzureDatabricksDeltaLakeImportCommand>
        {
            public override void Write(Utf8JsonWriter writer, AzureDatabricksDeltaLakeImportCommand model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AzureDatabricksDeltaLakeImportCommand Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureDatabricksDeltaLakeImportCommand(document.RootElement);
            }
        }
    }
}
