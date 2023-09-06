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
    public partial class ServerEndpointCloudTieringStatus : IUtf8JsonSerializable, IModelJsonSerializable<ServerEndpointCloudTieringStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServerEndpointCloudTieringStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServerEndpointCloudTieringStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServerEndpointCloudTieringStatus>(this, options.Format);

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

        internal static ServerEndpointCloudTieringStatus DeserializeServerEndpointCloudTieringStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> lastUpdatedTimestamp = default;
            Optional<ServerEndpointHealthState> health = default;
            Optional<DateTimeOffset> healthLastUpdatedTimestamp = default;
            Optional<int> lastCloudTieringResult = default;
            Optional<DateTimeOffset> lastSuccessTimestamp = default;
            Optional<CloudTieringSpaceSavings> spaceSavings = default;
            Optional<CloudTieringCachePerformance> cachePerformance = default;
            Optional<CloudTieringFilesNotTiering> filesNotTiering = default;
            Optional<CloudTieringVolumeFreeSpacePolicyStatus> volumeFreeSpacePolicyStatus = default;
            Optional<CloudTieringDatePolicyStatus> datePolicyStatus = default;
            Optional<CloudTieringLowDiskMode> lowDiskMode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    health = new ServerEndpointHealthState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthLastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthLastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastCloudTieringResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastCloudTieringResult = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastSuccessTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSuccessTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("spaceSavings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spaceSavings = CloudTieringSpaceSavings.DeserializeCloudTieringSpaceSavings(property.Value);
                    continue;
                }
                if (property.NameEquals("cachePerformance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cachePerformance = CloudTieringCachePerformance.DeserializeCloudTieringCachePerformance(property.Value);
                    continue;
                }
                if (property.NameEquals("filesNotTiering"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filesNotTiering = CloudTieringFilesNotTiering.DeserializeCloudTieringFilesNotTiering(property.Value);
                    continue;
                }
                if (property.NameEquals("volumeFreeSpacePolicyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    volumeFreeSpacePolicyStatus = CloudTieringVolumeFreeSpacePolicyStatus.DeserializeCloudTieringVolumeFreeSpacePolicyStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("datePolicyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    datePolicyStatus = CloudTieringDatePolicyStatus.DeserializeCloudTieringDatePolicyStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("lowDiskMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lowDiskMode = CloudTieringLowDiskMode.DeserializeCloudTieringLowDiskMode(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServerEndpointCloudTieringStatus(Optional.ToNullable(lastUpdatedTimestamp), Optional.ToNullable(health), Optional.ToNullable(healthLastUpdatedTimestamp), Optional.ToNullable(lastCloudTieringResult), Optional.ToNullable(lastSuccessTimestamp), spaceSavings.Value, cachePerformance.Value, filesNotTiering.Value, volumeFreeSpacePolicyStatus.Value, datePolicyStatus.Value, lowDiskMode.Value, rawData);
        }

        ServerEndpointCloudTieringStatus IModelJsonSerializable<ServerEndpointCloudTieringStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServerEndpointCloudTieringStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServerEndpointCloudTieringStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServerEndpointCloudTieringStatus>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServerEndpointCloudTieringStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServerEndpointCloudTieringStatus IModelSerializable<ServerEndpointCloudTieringStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServerEndpointCloudTieringStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServerEndpointCloudTieringStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServerEndpointCloudTieringStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServerEndpointCloudTieringStatus"/> to convert. </param>
        public static implicit operator RequestContent(ServerEndpointCloudTieringStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServerEndpointCloudTieringStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServerEndpointCloudTieringStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServerEndpointCloudTieringStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
