// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    internal partial class UnknownCopySink : IUtf8JsonSerializable, IModelJsonSerializable<CopySink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CopySink>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CopySink>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopySink>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(WriteBatchSize))
            {
                writer.WritePropertyName("writeBatchSize"u8);
                writer.WriteObjectValue(WriteBatchSize);
            }
            if (Optional.IsDefined(WriteBatchTimeout))
            {
                writer.WritePropertyName("writeBatchTimeout"u8);
                writer.WriteObjectValue(WriteBatchTimeout);
            }
            if (Optional.IsDefined(SinkRetryCount))
            {
                writer.WritePropertyName("sinkRetryCount"u8);
                writer.WriteObjectValue(SinkRetryCount);
            }
            if (Optional.IsDefined(SinkRetryWait))
            {
                writer.WritePropertyName("sinkRetryWait"u8);
                writer.WriteObjectValue(SinkRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static CopySink DeserializeUnknownCopySink(JsonElement element, ModelSerializerOptions options = default) => DeserializeCopySink(element, options);

        CopySink IModelJsonSerializable<CopySink>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopySink>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownCopySink(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CopySink>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopySink>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CopySink IModelSerializable<CopySink>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopySink>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCopySink(doc.RootElement, options);
        }
    }
}
