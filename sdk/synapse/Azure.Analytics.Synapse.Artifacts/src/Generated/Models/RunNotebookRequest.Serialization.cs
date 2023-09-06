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
    [JsonConverter(typeof(RunNotebookRequestConverter))]
    public partial class RunNotebookRequest : IUtf8JsonSerializable, IModelJsonSerializable<RunNotebookRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RunNotebookRequest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RunNotebookRequest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RunNotebookRequest>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Notebook))
            {
                writer.WritePropertyName("notebook"u8);
                writer.WriteStringValue(Notebook);
            }
            if (Optional.IsDefined(SparkPool))
            {
                writer.WritePropertyName("sparkPool"u8);
                writer.WriteStringValue(SparkPool);
            }
            if (Optional.IsDefined(SessionOptions))
            {
                writer.WritePropertyName("sessionOptions"u8);
                if (SessionOptions is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RunNotebookSparkSessionOptions>)SessionOptions).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(HonorSessionTimeToLive))
            {
                writer.WritePropertyName("honorSessionTimeToLive"u8);
                writer.WriteBooleanValue(HonorSessionTimeToLive.Value);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RunNotebookParameter>)item.Value).Serialize(writer, options);
                    }
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

        internal static RunNotebookRequest DeserializeRunNotebookRequest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> notebook = default;
            Optional<string> sparkPool = default;
            Optional<RunNotebookSparkSessionOptions> sessionOptions = default;
            Optional<bool> honorSessionTimeToLive = default;
            Optional<IDictionary<string, RunNotebookParameter>> parameters = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notebook"u8))
                {
                    notebook = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sparkPool"u8))
                {
                    sparkPool = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionOptions = RunNotebookSparkSessionOptions.DeserializeRunNotebookSparkSessionOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("honorSessionTimeToLive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    honorSessionTimeToLive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, RunNotebookParameter> dictionary = new Dictionary<string, RunNotebookParameter>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, RunNotebookParameter.DeserializeRunNotebookParameter(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RunNotebookRequest(notebook.Value, sparkPool.Value, sessionOptions.Value, Optional.ToNullable(honorSessionTimeToLive), Optional.ToDictionary(parameters), rawData);
        }

        RunNotebookRequest IModelJsonSerializable<RunNotebookRequest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RunNotebookRequest>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRunNotebookRequest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RunNotebookRequest>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RunNotebookRequest>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RunNotebookRequest IModelSerializable<RunNotebookRequest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RunNotebookRequest>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRunNotebookRequest(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RunNotebookRequest"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RunNotebookRequest"/> to convert. </param>
        public static implicit operator RequestContent(RunNotebookRequest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RunNotebookRequest"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RunNotebookRequest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRunNotebookRequest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class RunNotebookRequestConverter : JsonConverter<RunNotebookRequest>
        {
            public override void Write(Utf8JsonWriter writer, RunNotebookRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override RunNotebookRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRunNotebookRequest(document.RootElement);
            }
        }
    }
}
