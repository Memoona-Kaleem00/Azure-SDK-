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
    [JsonConverter(typeof(CustomActivityReferenceObjectConverter))]
    public partial class CustomActivityReferenceObject : IUtf8JsonSerializable, IModelJsonSerializable<CustomActivityReferenceObject>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CustomActivityReferenceObject>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CustomActivityReferenceObject>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomActivityReferenceObject>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(LinkedServices))
            {
                writer.WritePropertyName("linkedServices"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedServices)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<LinkedServiceReference>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Datasets))
            {
                writer.WritePropertyName("datasets"u8);
                writer.WriteStartArray();
                foreach (var item in Datasets)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DatasetReference>)item).Serialize(writer, options);
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

        internal static CustomActivityReferenceObject DeserializeCustomActivityReferenceObject(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<LinkedServiceReference>> linkedServices = default;
            Optional<IList<DatasetReference>> datasets = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkedServiceReference> array = new List<LinkedServiceReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedServiceReference.DeserializeLinkedServiceReference(item));
                    }
                    linkedServices = array;
                    continue;
                }
                if (property.NameEquals("datasets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatasetReference> array = new List<DatasetReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetReference.DeserializeDatasetReference(item));
                    }
                    datasets = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CustomActivityReferenceObject(Optional.ToList(linkedServices), Optional.ToList(datasets), rawData);
        }

        CustomActivityReferenceObject IModelJsonSerializable<CustomActivityReferenceObject>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomActivityReferenceObject>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomActivityReferenceObject(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CustomActivityReferenceObject>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomActivityReferenceObject>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CustomActivityReferenceObject IModelSerializable<CustomActivityReferenceObject>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomActivityReferenceObject>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCustomActivityReferenceObject(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CustomActivityReferenceObject"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CustomActivityReferenceObject"/> to convert. </param>
        public static implicit operator RequestContent(CustomActivityReferenceObject model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CustomActivityReferenceObject"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CustomActivityReferenceObject(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCustomActivityReferenceObject(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class CustomActivityReferenceObjectConverter : JsonConverter<CustomActivityReferenceObject>
        {
            public override void Write(Utf8JsonWriter writer, CustomActivityReferenceObject model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override CustomActivityReferenceObject Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCustomActivityReferenceObject(document.RootElement);
            }
        }
    }
}
