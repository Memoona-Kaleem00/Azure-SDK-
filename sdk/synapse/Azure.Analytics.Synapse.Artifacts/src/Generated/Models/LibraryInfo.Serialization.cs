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
    [JsonConverter(typeof(LibraryInfoConverter))]
    public partial class LibraryInfo : IUtf8JsonSerializable, IModelJsonSerializable<LibraryInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LibraryInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LibraryInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LibraryInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(ContainerName))
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (Optional.IsDefined(UploadedTimestamp))
            {
                writer.WritePropertyName("uploadedTimestamp"u8);
                writer.WriteStringValue(UploadedTimestamp.Value, "O");
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type);
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

        internal static LibraryInfo DeserializeLibraryInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> path = default;
            Optional<string> containerName = default;
            Optional<DateTimeOffset> uploadedTimestamp = default;
            Optional<string> type = default;
            Optional<string> provisioningStatus = default;
            Optional<string> creatorId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uploadedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uploadedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatus"u8))
                {
                    provisioningStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creatorId"u8))
                {
                    creatorId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LibraryInfo(name.Value, path.Value, containerName.Value, Optional.ToNullable(uploadedTimestamp), type.Value, provisioningStatus.Value, creatorId.Value, rawData);
        }

        LibraryInfo IModelJsonSerializable<LibraryInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LibraryInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLibraryInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LibraryInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LibraryInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LibraryInfo IModelSerializable<LibraryInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LibraryInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLibraryInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LibraryInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LibraryInfo"/> to convert. </param>
        public static implicit operator RequestContent(LibraryInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LibraryInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LibraryInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLibraryInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class LibraryInfoConverter : JsonConverter<LibraryInfo>
        {
            public override void Write(Utf8JsonWriter writer, LibraryInfo model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LibraryInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLibraryInfo(document.RootElement);
            }
        }
    }
}
