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
    [JsonConverter(typeof(CreateDataFlowDebugSessionRequestConverter))]
    public partial class CreateDataFlowDebugSessionRequest : IUtf8JsonSerializable, IModelJsonSerializable<CreateDataFlowDebugSessionRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CreateDataFlowDebugSessionRequest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CreateDataFlowDebugSessionRequest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateDataFlowDebugSessionRequest>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ComputeType))
            {
                writer.WritePropertyName("computeType"u8);
                writer.WriteStringValue(ComputeType);
            }
            if (Optional.IsDefined(CoreCount))
            {
                writer.WritePropertyName("coreCount"u8);
                writer.WriteNumberValue(CoreCount.Value);
            }
            if (Optional.IsDefined(TimeToLive))
            {
                writer.WritePropertyName("timeToLive"u8);
                writer.WriteNumberValue(TimeToLive.Value);
            }
            if (Optional.IsDefined(IntegrationRuntime))
            {
                writer.WritePropertyName("integrationRuntime"u8);
                if (IntegrationRuntime is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<IntegrationRuntimeDebugResource>)IntegrationRuntime).Serialize(writer, options);
                }
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

        internal static CreateDataFlowDebugSessionRequest DeserializeCreateDataFlowDebugSessionRequest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> computeType = default;
            Optional<int> coreCount = default;
            Optional<int> timeToLive = default;
            Optional<IntegrationRuntimeDebugResource> integrationRuntime = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeType"u8))
                {
                    computeType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("coreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeToLive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeToLive = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("integrationRuntime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    integrationRuntime = IntegrationRuntimeDebugResource.DeserializeIntegrationRuntimeDebugResource(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CreateDataFlowDebugSessionRequest(computeType.Value, Optional.ToNullable(coreCount), Optional.ToNullable(timeToLive), integrationRuntime.Value, rawData);
        }

        CreateDataFlowDebugSessionRequest IModelJsonSerializable<CreateDataFlowDebugSessionRequest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateDataFlowDebugSessionRequest>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateDataFlowDebugSessionRequest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CreateDataFlowDebugSessionRequest>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateDataFlowDebugSessionRequest>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CreateDataFlowDebugSessionRequest IModelSerializable<CreateDataFlowDebugSessionRequest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateDataFlowDebugSessionRequest>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCreateDataFlowDebugSessionRequest(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CreateDataFlowDebugSessionRequest"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CreateDataFlowDebugSessionRequest"/> to convert. </param>
        public static implicit operator RequestContent(CreateDataFlowDebugSessionRequest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CreateDataFlowDebugSessionRequest"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CreateDataFlowDebugSessionRequest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCreateDataFlowDebugSessionRequest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class CreateDataFlowDebugSessionRequestConverter : JsonConverter<CreateDataFlowDebugSessionRequest>
        {
            public override void Write(Utf8JsonWriter writer, CreateDataFlowDebugSessionRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override CreateDataFlowDebugSessionRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCreateDataFlowDebugSessionRequest(document.RootElement);
            }
        }
    }
}
