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
    [JsonConverter(typeof(NotebookLanguageInfoConverter))]
    public partial class NotebookLanguageInfo : IUtf8JsonSerializable, IModelJsonSerializable<NotebookLanguageInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NotebookLanguageInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NotebookLanguageInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotebookLanguageInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(CodemirrorMode))
            {
                writer.WritePropertyName("codemirror_mode"u8);
                writer.WriteStringValue(CodemirrorMode);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static NotebookLanguageInfo DeserializeNotebookLanguageInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<string> codemirrorMode = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("codemirror_mode"u8))
                {
                    codemirrorMode = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new NotebookLanguageInfo(name, codemirrorMode.Value, additionalProperties);
        }

        NotebookLanguageInfo IModelJsonSerializable<NotebookLanguageInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotebookLanguageInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNotebookLanguageInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NotebookLanguageInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotebookLanguageInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NotebookLanguageInfo IModelSerializable<NotebookLanguageInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NotebookLanguageInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNotebookLanguageInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NotebookLanguageInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NotebookLanguageInfo"/> to convert. </param>
        public static implicit operator RequestContent(NotebookLanguageInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NotebookLanguageInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NotebookLanguageInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNotebookLanguageInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class NotebookLanguageInfoConverter : JsonConverter<NotebookLanguageInfo>
        {
            public override void Write(Utf8JsonWriter writer, NotebookLanguageInfo model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override NotebookLanguageInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeNotebookLanguageInfo(document.RootElement);
            }
        }
    }
}
