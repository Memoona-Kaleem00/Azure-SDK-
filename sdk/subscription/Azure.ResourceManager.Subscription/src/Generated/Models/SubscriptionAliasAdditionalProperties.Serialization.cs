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

namespace Azure.ResourceManager.Subscription.Models
{
    public partial class SubscriptionAliasAdditionalProperties : IUtf8JsonSerializable, IModelJsonSerializable<SubscriptionAliasAdditionalProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SubscriptionAliasAdditionalProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SubscriptionAliasAdditionalProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubscriptionAliasAdditionalProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ManagementGroupId))
            {
                writer.WritePropertyName("managementGroupId"u8);
                writer.WriteStringValue(ManagementGroupId);
            }
            if (Optional.IsDefined(SubscriptionTenantId))
            {
                writer.WritePropertyName("subscriptionTenantId"u8);
                writer.WriteStringValue(SubscriptionTenantId.Value);
            }
            if (Optional.IsDefined(SubscriptionOwnerId))
            {
                writer.WritePropertyName("subscriptionOwnerId"u8);
                writer.WriteStringValue(SubscriptionOwnerId);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static SubscriptionAliasAdditionalProperties DeserializeSubscriptionAliasAdditionalProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> managementGroupId = default;
            Optional<Guid> subscriptionTenantId = default;
            Optional<string> subscriptionOwnerId = default;
            Optional<IDictionary<string, string>> tags = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managementGroupId"u8))
                {
                    managementGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionTenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("subscriptionOwnerId"u8))
                {
                    subscriptionOwnerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SubscriptionAliasAdditionalProperties(managementGroupId.Value, Optional.ToNullable(subscriptionTenantId), subscriptionOwnerId.Value, Optional.ToDictionary(tags), rawData);
        }

        SubscriptionAliasAdditionalProperties IModelJsonSerializable<SubscriptionAliasAdditionalProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubscriptionAliasAdditionalProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSubscriptionAliasAdditionalProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SubscriptionAliasAdditionalProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubscriptionAliasAdditionalProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SubscriptionAliasAdditionalProperties IModelSerializable<SubscriptionAliasAdditionalProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubscriptionAliasAdditionalProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSubscriptionAliasAdditionalProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SubscriptionAliasAdditionalProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SubscriptionAliasAdditionalProperties"/> to convert. </param>
        public static implicit operator RequestContent(SubscriptionAliasAdditionalProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SubscriptionAliasAdditionalProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SubscriptionAliasAdditionalProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSubscriptionAliasAdditionalProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
