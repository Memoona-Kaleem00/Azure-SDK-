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

namespace Azure.Data.Tables.Models
{
    internal partial class TableResponse : IUtf8JsonSerializable, IModelJsonSerializable<TableResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TableResponse>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TableResponse>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TableResponse>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(OdataMetadata))
            {
                writer.WritePropertyName("odata.metadata"u8);
                writer.WriteStringValue(OdataMetadata);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("TableName"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(OdataType))
            {
                writer.WritePropertyName("odata.type"u8);
                writer.WriteStringValue(OdataType);
            }
            if (Optional.IsDefined(OdataId))
            {
                writer.WritePropertyName("odata.id"u8);
                writer.WriteStringValue(OdataId);
            }
            if (Optional.IsDefined(OdataEditLink))
            {
                writer.WritePropertyName("odata.editLink"u8);
                writer.WriteStringValue(OdataEditLink);
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

        internal static TableResponse DeserializeTableResponse(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> odataMetadata = default;
            Optional<string> tableName = default;
            Optional<string> odataType = default;
            Optional<string> odataId = default;
            Optional<string> odataEditLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.metadata"u8))
                {
                    odataMetadata = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("TableName"u8))
                {
                    tableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("odata.id"u8))
                {
                    odataId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("odata.editLink"u8))
                {
                    odataEditLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TableResponse(tableName.Value, odataType.Value, odataId.Value, odataEditLink.Value, odataMetadata.Value, rawData);
        }

        TableResponse IModelJsonSerializable<TableResponse>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TableResponse>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTableResponse(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TableResponse>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TableResponse>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TableResponse IModelSerializable<TableResponse>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TableResponse>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTableResponse(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TableResponse"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TableResponse"/> to convert. </param>
        public static implicit operator RequestContent(TableResponse model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TableResponse"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TableResponse(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTableResponse(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
