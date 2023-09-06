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
    [JsonConverter(typeof(TriggerDependencyReferenceConverter))]
    public partial class TriggerDependencyReference : IUtf8JsonSerializable, IModelJsonSerializable<TriggerDependencyReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TriggerDependencyReference>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TriggerDependencyReference>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggerDependencyReference>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("referenceTrigger"u8);
            if (ReferenceTrigger is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<TriggerReference>)ReferenceTrigger).Serialize(writer, options);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
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

        internal static TriggerDependencyReference DeserializeTriggerDependencyReference(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "TumblingWindowTriggerDependencyReference": return TumblingWindowTriggerDependencyReference.DeserializeTumblingWindowTriggerDependencyReference(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            TriggerReference referenceTrigger = default;
            string type = "TriggerDependencyReference";
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("referenceTrigger"u8))
                {
                    referenceTrigger = TriggerReference.DeserializeTriggerReference(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TriggerDependencyReference(type, referenceTrigger, rawData);
        }

        TriggerDependencyReference IModelJsonSerializable<TriggerDependencyReference>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggerDependencyReference>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTriggerDependencyReference(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TriggerDependencyReference>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggerDependencyReference>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TriggerDependencyReference IModelSerializable<TriggerDependencyReference>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggerDependencyReference>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTriggerDependencyReference(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TriggerDependencyReference"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TriggerDependencyReference"/> to convert. </param>
        public static implicit operator RequestContent(TriggerDependencyReference model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TriggerDependencyReference"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TriggerDependencyReference(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTriggerDependencyReference(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class TriggerDependencyReferenceConverter : JsonConverter<TriggerDependencyReference>
        {
            public override void Write(Utf8JsonWriter writer, TriggerDependencyReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TriggerDependencyReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTriggerDependencyReference(document.RootElement);
            }
        }
    }
}
