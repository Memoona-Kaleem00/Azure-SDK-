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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountNetworkRuleSet : IUtf8JsonSerializable, IModelJsonSerializable<StorageAccountNetworkRuleSet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageAccountNetworkRuleSet>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageAccountNetworkRuleSet>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageAccountNetworkRuleSet>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Bypass))
            {
                writer.WritePropertyName("bypass"u8);
                writer.WriteStringValue(Bypass.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ResourceAccessRules))
            {
                writer.WritePropertyName("resourceAccessRules"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceAccessRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<StorageAccountResourceAccessRule>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<StorageAccountVirtualNetworkRule>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<StorageAccountIPRule>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("defaultAction"u8);
            writer.WriteStringValue(DefaultAction.ToSerialString());
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

        internal static StorageAccountNetworkRuleSet DeserializeStorageAccountNetworkRuleSet(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageNetworkBypass> bypass = default;
            Optional<IList<StorageAccountResourceAccessRule>> resourceAccessRules = default;
            Optional<IList<StorageAccountVirtualNetworkRule>> virtualNetworkRules = default;
            Optional<IList<StorageAccountIPRule>> ipRules = default;
            StorageNetworkDefaultAction defaultAction = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bypass"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bypass = new StorageNetworkBypass(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceAccessRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageAccountResourceAccessRule> array = new List<StorageAccountResourceAccessRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageAccountResourceAccessRule.DeserializeStorageAccountResourceAccessRule(item));
                    }
                    resourceAccessRules = array;
                    continue;
                }
                if (property.NameEquals("virtualNetworkRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageAccountVirtualNetworkRule> array = new List<StorageAccountVirtualNetworkRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageAccountVirtualNetworkRule.DeserializeStorageAccountVirtualNetworkRule(item));
                    }
                    virtualNetworkRules = array;
                    continue;
                }
                if (property.NameEquals("ipRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageAccountIPRule> array = new List<StorageAccountIPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageAccountIPRule.DeserializeStorageAccountIPRule(item));
                    }
                    ipRules = array;
                    continue;
                }
                if (property.NameEquals("defaultAction"u8))
                {
                    defaultAction = property.Value.GetString().ToStorageNetworkDefaultAction();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageAccountNetworkRuleSet(Optional.ToNullable(bypass), Optional.ToList(resourceAccessRules), Optional.ToList(virtualNetworkRules), Optional.ToList(ipRules), defaultAction, rawData);
        }

        StorageAccountNetworkRuleSet IModelJsonSerializable<StorageAccountNetworkRuleSet>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageAccountNetworkRuleSet>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountNetworkRuleSet(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageAccountNetworkRuleSet>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageAccountNetworkRuleSet>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageAccountNetworkRuleSet IModelSerializable<StorageAccountNetworkRuleSet>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageAccountNetworkRuleSet>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageAccountNetworkRuleSet(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageAccountNetworkRuleSet"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageAccountNetworkRuleSet"/> to convert. </param>
        public static implicit operator RequestContent(StorageAccountNetworkRuleSet model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageAccountNetworkRuleSet"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageAccountNetworkRuleSet(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageAccountNetworkRuleSet(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
