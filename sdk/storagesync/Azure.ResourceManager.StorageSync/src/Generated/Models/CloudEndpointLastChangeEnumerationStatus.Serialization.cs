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

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class CloudEndpointLastChangeEnumerationStatus : IUtf8JsonSerializable, IModelJsonSerializable<CloudEndpointLastChangeEnumerationStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CloudEndpointLastChangeEnumerationStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CloudEndpointLastChangeEnumerationStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudEndpointLastChangeEnumerationStatus>(this, options.Format);

            writer.WriteStartObject();
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

        internal static CloudEndpointLastChangeEnumerationStatus DeserializeCloudEndpointLastChangeEnumerationStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> startedTimestamp = default;
            Optional<DateTimeOffset> completedTimestamp = default;
            Optional<long> namespaceFilesCount = default;
            Optional<long> namespaceDirectoriesCount = default;
            Optional<long> namespaceSizeBytes = default;
            Optional<DateTimeOffset> nextRunTimestamp = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("completedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    completedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("namespaceFilesCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    namespaceFilesCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("namespaceDirectoriesCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    namespaceDirectoriesCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("namespaceSizeBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    namespaceSizeBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("nextRunTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextRunTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CloudEndpointLastChangeEnumerationStatus(Optional.ToNullable(startedTimestamp), Optional.ToNullable(completedTimestamp), Optional.ToNullable(namespaceFilesCount), Optional.ToNullable(namespaceDirectoriesCount), Optional.ToNullable(namespaceSizeBytes), Optional.ToNullable(nextRunTimestamp), rawData);
        }

        CloudEndpointLastChangeEnumerationStatus IModelJsonSerializable<CloudEndpointLastChangeEnumerationStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudEndpointLastChangeEnumerationStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudEndpointLastChangeEnumerationStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CloudEndpointLastChangeEnumerationStatus>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudEndpointLastChangeEnumerationStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CloudEndpointLastChangeEnumerationStatus IModelSerializable<CloudEndpointLastChangeEnumerationStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudEndpointLastChangeEnumerationStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCloudEndpointLastChangeEnumerationStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CloudEndpointLastChangeEnumerationStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CloudEndpointLastChangeEnumerationStatus"/> to convert. </param>
        public static implicit operator RequestContent(CloudEndpointLastChangeEnumerationStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CloudEndpointLastChangeEnumerationStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CloudEndpointLastChangeEnumerationStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCloudEndpointLastChangeEnumerationStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
