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

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class ServiceBusTopicOutputDataSource : IUtf8JsonSerializable, IModelJsonSerializable<ServiceBusTopicOutputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceBusTopicOutputDataSource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceBusTopicOutputDataSource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusTopicOutputDataSource>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(OutputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceBusNamespace))
            {
                writer.WritePropertyName("serviceBusNamespace"u8);
                writer.WriteStringValue(ServiceBusNamespace);
            }
            if (Optional.IsDefined(SharedAccessPolicyName))
            {
                writer.WritePropertyName("sharedAccessPolicyName"u8);
                writer.WriteStringValue(SharedAccessPolicyName);
            }
            if (Optional.IsDefined(SharedAccessPolicyKey))
            {
                writer.WritePropertyName("sharedAccessPolicyKey"u8);
                writer.WriteStringValue(SharedAccessPolicyKey);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode"u8);
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            if (Optional.IsDefined(TopicName))
            {
                writer.WritePropertyName("topicName"u8);
                writer.WriteStringValue(TopicName);
            }
            if (Optional.IsCollectionDefined(PropertyColumns))
            {
                writer.WritePropertyName("propertyColumns"u8);
                writer.WriteStartArray();
                foreach (var item in PropertyColumns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SystemPropertyColumns))
            {
                writer.WritePropertyName("systemPropertyColumns"u8);
                writer.WriteStartObject();
                foreach (var item in SystemPropertyColumns)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
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

        internal static ServiceBusTopicOutputDataSource DeserializeServiceBusTopicOutputDataSource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> serviceBusNamespace = default;
            Optional<string> sharedAccessPolicyName = default;
            Optional<string> sharedAccessPolicyKey = default;
            Optional<StreamAnalyticsAuthenticationMode> authenticationMode = default;
            Optional<string> topicName = default;
            Optional<IList<string>> propertyColumns = default;
            Optional<IDictionary<string, string>> systemPropertyColumns = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serviceBusNamespace"u8))
                        {
                            serviceBusNamespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyName"u8))
                        {
                            sharedAccessPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyKey"u8))
                        {
                            sharedAccessPolicyKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationMode = new StreamAnalyticsAuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("topicName"u8))
                        {
                            topicName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("propertyColumns"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            propertyColumns = array;
                            continue;
                        }
                        if (property0.NameEquals("systemPropertyColumns"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            systemPropertyColumns = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServiceBusTopicOutputDataSource(type, serviceBusNamespace.Value, sharedAccessPolicyName.Value, sharedAccessPolicyKey.Value, Optional.ToNullable(authenticationMode), topicName.Value, Optional.ToList(propertyColumns), Optional.ToDictionary(systemPropertyColumns), rawData);
        }

        ServiceBusTopicOutputDataSource IModelJsonSerializable<ServiceBusTopicOutputDataSource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusTopicOutputDataSource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusTopicOutputDataSource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceBusTopicOutputDataSource>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusTopicOutputDataSource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceBusTopicOutputDataSource IModelSerializable<ServiceBusTopicOutputDataSource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusTopicOutputDataSource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceBusTopicOutputDataSource(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServiceBusTopicOutputDataSource"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServiceBusTopicOutputDataSource"/> to convert. </param>
        public static implicit operator RequestContent(ServiceBusTopicOutputDataSource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServiceBusTopicOutputDataSource"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServiceBusTopicOutputDataSource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceBusTopicOutputDataSource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
