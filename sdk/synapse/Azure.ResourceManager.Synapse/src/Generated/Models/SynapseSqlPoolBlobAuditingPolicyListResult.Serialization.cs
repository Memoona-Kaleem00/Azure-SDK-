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
    internal partial class SynapseSqlPoolBlobAuditingPolicyListResult : IUtf8JsonSerializable, IModelJsonSerializable<SynapseSqlPoolBlobAuditingPolicyListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseSqlPoolBlobAuditingPolicyListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseSqlPoolBlobAuditingPolicyListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseSqlPoolBlobAuditingPolicyListResult>(this, options.Format);

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

        internal static SynapseSqlPoolBlobAuditingPolicyListResult DeserializeSynapseSqlPoolBlobAuditingPolicyListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SynapseSqlPoolBlobAuditingPolicyData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseSqlPoolBlobAuditingPolicyData> array = new List<SynapseSqlPoolBlobAuditingPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseSqlPoolBlobAuditingPolicyData.DeserializeSynapseSqlPoolBlobAuditingPolicyData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseSqlPoolBlobAuditingPolicyListResult(Optional.ToList(value), nextLink.Value, rawData);
        }

        SynapseSqlPoolBlobAuditingPolicyListResult IModelJsonSerializable<SynapseSqlPoolBlobAuditingPolicyListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseSqlPoolBlobAuditingPolicyListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSqlPoolBlobAuditingPolicyListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseSqlPoolBlobAuditingPolicyListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseSqlPoolBlobAuditingPolicyListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseSqlPoolBlobAuditingPolicyListResult IModelSerializable<SynapseSqlPoolBlobAuditingPolicyListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseSqlPoolBlobAuditingPolicyListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseSqlPoolBlobAuditingPolicyListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseSqlPoolBlobAuditingPolicyListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseSqlPoolBlobAuditingPolicyListResult"/> to convert. </param>
        public static implicit operator RequestContent(SynapseSqlPoolBlobAuditingPolicyListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseSqlPoolBlobAuditingPolicyListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseSqlPoolBlobAuditingPolicyListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseSqlPoolBlobAuditingPolicyListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
