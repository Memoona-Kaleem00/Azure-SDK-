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

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SpatialAnalysisPersonDistanceZoneEvents : IUtf8JsonSerializable, IModelJsonSerializable<SpatialAnalysisPersonDistanceZoneEvents>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SpatialAnalysisPersonDistanceZoneEvents>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SpatialAnalysisPersonDistanceZoneEvents>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SpatialAnalysisPersonDistanceZoneEvents>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("zone"u8);
            if (Zone is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<NamedPolygonBase>)Zone).Serialize(writer, options);
            }
            if (Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SpatialAnalysisPersonDistanceEvent>)item).Serialize(writer, options);
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

        internal static SpatialAnalysisPersonDistanceZoneEvents DeserializeSpatialAnalysisPersonDistanceZoneEvents(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NamedPolygonBase zone = default;
            Optional<IList<SpatialAnalysisPersonDistanceEvent>> events = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zone"u8))
                {
                    zone = NamedPolygonBase.DeserializeNamedPolygonBase(property.Value);
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SpatialAnalysisPersonDistanceEvent> array = new List<SpatialAnalysisPersonDistanceEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpatialAnalysisPersonDistanceEvent.DeserializeSpatialAnalysisPersonDistanceEvent(item));
                    }
                    events = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SpatialAnalysisPersonDistanceZoneEvents(zone, Optional.ToList(events), rawData);
        }

        SpatialAnalysisPersonDistanceZoneEvents IModelJsonSerializable<SpatialAnalysisPersonDistanceZoneEvents>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SpatialAnalysisPersonDistanceZoneEvents>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSpatialAnalysisPersonDistanceZoneEvents(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SpatialAnalysisPersonDistanceZoneEvents>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SpatialAnalysisPersonDistanceZoneEvents>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SpatialAnalysisPersonDistanceZoneEvents IModelSerializable<SpatialAnalysisPersonDistanceZoneEvents>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SpatialAnalysisPersonDistanceZoneEvents>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSpatialAnalysisPersonDistanceZoneEvents(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SpatialAnalysisPersonDistanceZoneEvents"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SpatialAnalysisPersonDistanceZoneEvents"/> to convert. </param>
        public static implicit operator RequestContent(SpatialAnalysisPersonDistanceZoneEvents model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SpatialAnalysisPersonDistanceZoneEvents"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SpatialAnalysisPersonDistanceZoneEvents(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSpatialAnalysisPersonDistanceZoneEvents(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
