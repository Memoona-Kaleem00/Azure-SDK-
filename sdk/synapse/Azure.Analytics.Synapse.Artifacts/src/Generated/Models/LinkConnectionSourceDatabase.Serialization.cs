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
    [JsonConverter(typeof(LinkConnectionSourceDatabaseConverter))]
    public partial class LinkConnectionSourceDatabase : IUtf8JsonSerializable, IModelJsonSerializable<LinkConnectionSourceDatabase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LinkConnectionSourceDatabase>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LinkConnectionSourceDatabase>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkConnectionSourceDatabase>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedService))
            {
                writer.WritePropertyName("linkedService"u8);
                if (LinkedService is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LinkedServiceReference>)LinkedService).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(TypeProperties))
            {
                writer.WritePropertyName("typeProperties"u8);
                if (TypeProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LinkConnectionSourceDatabaseTypeProperties>)TypeProperties).Serialize(writer, options);
                }
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static LinkConnectionSourceDatabase DeserializeLinkConnectionSourceDatabase(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LinkedServiceReference> linkedService = default;
            Optional<LinkConnectionSourceDatabaseTypeProperties> typeProperties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    typeProperties = LinkConnectionSourceDatabaseTypeProperties.DeserializeLinkConnectionSourceDatabaseTypeProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LinkConnectionSourceDatabase(linkedService.Value, typeProperties.Value, rawData);
        }

        LinkConnectionSourceDatabase IModelJsonSerializable<LinkConnectionSourceDatabase>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkConnectionSourceDatabase>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkConnectionSourceDatabase(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LinkConnectionSourceDatabase>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkConnectionSourceDatabase>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LinkConnectionSourceDatabase IModelSerializable<LinkConnectionSourceDatabase>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkConnectionSourceDatabase>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLinkConnectionSourceDatabase(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LinkConnectionSourceDatabase"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LinkConnectionSourceDatabase"/> to convert. </param>
        public static implicit operator RequestContent(LinkConnectionSourceDatabase model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LinkConnectionSourceDatabase"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LinkConnectionSourceDatabase(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLinkConnectionSourceDatabase(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class LinkConnectionSourceDatabaseConverter : JsonConverter<LinkConnectionSourceDatabase>
        {
            public override void Write(Utf8JsonWriter writer, LinkConnectionSourceDatabase model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LinkConnectionSourceDatabase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkConnectionSourceDatabase(document.RootElement);
            }
        }
    }
}
