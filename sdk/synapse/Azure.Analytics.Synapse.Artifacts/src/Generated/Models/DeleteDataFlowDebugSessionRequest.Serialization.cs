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
    [JsonConverter(typeof(DeleteDataFlowDebugSessionRequestConverter))]
    public partial class DeleteDataFlowDebugSessionRequest : IUtf8JsonSerializable, IModelJsonSerializable<DeleteDataFlowDebugSessionRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DeleteDataFlowDebugSessionRequest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DeleteDataFlowDebugSessionRequest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeleteDataFlowDebugSessionRequest>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId);
            }
            if (Optional.IsDefined(DataFlowName))
            {
                writer.WritePropertyName("dataFlowName"u8);
                writer.WriteStringValue(DataFlowName);
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

        internal static DeleteDataFlowDebugSessionRequest DeserializeDeleteDataFlowDebugSessionRequest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sessionId = default;
            Optional<string> dataFlowName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFlowName"u8))
                {
                    dataFlowName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DeleteDataFlowDebugSessionRequest(sessionId.Value, dataFlowName.Value, rawData);
        }

        DeleteDataFlowDebugSessionRequest IModelJsonSerializable<DeleteDataFlowDebugSessionRequest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeleteDataFlowDebugSessionRequest>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDeleteDataFlowDebugSessionRequest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DeleteDataFlowDebugSessionRequest>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeleteDataFlowDebugSessionRequest>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DeleteDataFlowDebugSessionRequest IModelSerializable<DeleteDataFlowDebugSessionRequest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeleteDataFlowDebugSessionRequest>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDeleteDataFlowDebugSessionRequest(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DeleteDataFlowDebugSessionRequest"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DeleteDataFlowDebugSessionRequest"/> to convert. </param>
        public static implicit operator RequestContent(DeleteDataFlowDebugSessionRequest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DeleteDataFlowDebugSessionRequest"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DeleteDataFlowDebugSessionRequest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDeleteDataFlowDebugSessionRequest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class DeleteDataFlowDebugSessionRequestConverter : JsonConverter<DeleteDataFlowDebugSessionRequest>
        {
            public override void Write(Utf8JsonWriter writer, DeleteDataFlowDebugSessionRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DeleteDataFlowDebugSessionRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDeleteDataFlowDebugSessionRequest(document.RootElement);
            }
        }
    }
}
