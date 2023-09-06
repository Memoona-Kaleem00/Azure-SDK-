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
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SynapseIPFirewallRuleInfoListResult : IUtf8JsonSerializable, IModelJsonSerializable<SynapseIPFirewallRuleInfoListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseIPFirewallRuleInfoListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseIPFirewallRuleInfoListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseIPFirewallRuleInfoListResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SynapseIPFirewallRuleInfoData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static SynapseIPFirewallRuleInfoListResult DeserializeSynapseIPFirewallRuleInfoListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<SynapseIPFirewallRuleInfoData>> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseIPFirewallRuleInfoData> array = new List<SynapseIPFirewallRuleInfoData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseIPFirewallRuleInfoData.DeserializeSynapseIPFirewallRuleInfoData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseIPFirewallRuleInfoListResult(nextLink.Value, Optional.ToList(value), rawData);
        }

        SynapseIPFirewallRuleInfoListResult IModelJsonSerializable<SynapseIPFirewallRuleInfoListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseIPFirewallRuleInfoListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIPFirewallRuleInfoListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseIPFirewallRuleInfoListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseIPFirewallRuleInfoListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseIPFirewallRuleInfoListResult IModelSerializable<SynapseIPFirewallRuleInfoListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseIPFirewallRuleInfoListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseIPFirewallRuleInfoListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseIPFirewallRuleInfoListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseIPFirewallRuleInfoListResult"/> to convert. </param>
        public static implicit operator RequestContent(SynapseIPFirewallRuleInfoListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseIPFirewallRuleInfoListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseIPFirewallRuleInfoListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseIPFirewallRuleInfoListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
