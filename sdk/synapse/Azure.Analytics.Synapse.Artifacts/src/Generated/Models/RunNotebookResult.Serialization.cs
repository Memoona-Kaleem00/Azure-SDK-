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
    [JsonConverter(typeof(RunNotebookResultConverter))]
    public partial class RunNotebookResult : IUtf8JsonSerializable, IModelJsonSerializable<RunNotebookResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RunNotebookResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RunNotebookResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RunNotebookResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RunId))
            {
                writer.WritePropertyName("runId"u8);
                writer.WriteStringValue(RunId);
            }
            if (Optional.IsDefined(RunStatus))
            {
                writer.WritePropertyName("runStatus"u8);
                writer.WriteStringValue(RunStatus);
            }
            if (Optional.IsDefined(LastCheckedOn))
            {
                writer.WritePropertyName("lastCheckedOn"u8);
                writer.WriteStringValue(LastCheckedOn);
            }
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteNumberValue(SessionId.Value);
            }
            if (Optional.IsDefined(SparkPool))
            {
                writer.WritePropertyName("sparkPool"u8);
                writer.WriteStringValue(SparkPool);
            }
            if (Optional.IsDefined(SessionDetail))
            {
                writer.WritePropertyName("sessionDetail"u8);
                writer.WriteObjectValue(SessionDetail);
            }
            if (Optional.IsDefined(ExitValue))
            {
                writer.WritePropertyName("exitValue"u8);
                writer.WriteStringValue(ExitValue);
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                if (Error is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RunNotebookError>)Error).Serialize(writer, options);
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

        internal static RunNotebookResult DeserializeRunNotebookResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> runId = default;
            Optional<string> runStatus = default;
            Optional<string> lastCheckedOn = default;
            Optional<long> sessionId = default;
            Optional<string> sparkPool = default;
            Optional<object> sessionDetail = default;
            Optional<string> exitValue = default;
            Optional<RunNotebookError> error = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runId"u8))
                {
                    runId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runStatus"u8))
                {
                    runStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastCheckedOn"u8))
                {
                    lastCheckedOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("sparkPool"u8))
                {
                    sparkPool = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionDetail"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionDetail = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("exitValue"u8))
                {
                    exitValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = RunNotebookError.DeserializeRunNotebookError(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RunNotebookResult(runId.Value, runStatus.Value, lastCheckedOn.Value, Optional.ToNullable(sessionId), sparkPool.Value, sessionDetail.Value, exitValue.Value, error.Value, rawData);
        }

        RunNotebookResult IModelJsonSerializable<RunNotebookResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RunNotebookResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRunNotebookResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RunNotebookResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RunNotebookResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RunNotebookResult IModelSerializable<RunNotebookResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RunNotebookResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRunNotebookResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RunNotebookResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RunNotebookResult"/> to convert. </param>
        public static implicit operator RequestContent(RunNotebookResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RunNotebookResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RunNotebookResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRunNotebookResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class RunNotebookResultConverter : JsonConverter<RunNotebookResult>
        {
            public override void Write(Utf8JsonWriter writer, RunNotebookResult model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override RunNotebookResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRunNotebookResult(document.RootElement);
            }
        }
    }
}
