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

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class GetEvents : IUtf8JsonSerializable, IModelJsonSerializable<GetEvents>
    {
        void IModelJsonSerializable<GetEvents>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetEvents>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("timeSeriesId"u8);
            writer.WriteStartArray();
            foreach (var item in TimeSeriesIdInternal)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("searchSpan"u8);
            if (SearchSpan is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<DateTimeRange>)SearchSpan).Serialize(writer, options);
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                if (Filter is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<TimeSeriesExpression>)Filter).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(ProjectedProperties))
            {
                writer.WritePropertyName("projectedProperties"u8);
                writer.WriteStartArray();
                foreach (var item in ProjectedProperties)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<TimeSeriesInsightsEventProperty>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Take))
            {
                writer.WritePropertyName("take"u8);
                writer.WriteNumberValue(Take.Value);
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

        internal static GetEvents DeserializeGetEvents(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<object> timeSeriesId = default;
            DateTimeRange searchSpan = default;
            Optional<TimeSeriesExpression> filter = default;
            Optional<IList<TimeSeriesInsightsEventProperty>> projectedProperties = default;
            Optional<int> take = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeSeriesId"u8))
                {
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    timeSeriesId = array;
                    continue;
                }
                if (property.NameEquals("searchSpan"u8))
                {
                    searchSpan = DateTimeRange.DeserializeDateTimeRange(property.Value);
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = TimeSeriesExpression.DeserializeTimeSeriesExpression(property.Value);
                    continue;
                }
                if (property.NameEquals("projectedProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TimeSeriesInsightsEventProperty> array = new List<TimeSeriesInsightsEventProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesInsightsEventProperty.DeserializeTimeSeriesInsightsEventProperty(item));
                    }
                    projectedProperties = array;
                    continue;
                }
                if (property.NameEquals("take"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    take = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GetEvents(timeSeriesId, searchSpan, filter.Value, Optional.ToList(projectedProperties), Optional.ToNullable(take), rawData);
        }

        GetEvents IModelJsonSerializable<GetEvents>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetEvents>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGetEvents(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GetEvents>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetEvents>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GetEvents IModelSerializable<GetEvents>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetEvents>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGetEvents(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GetEvents"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GetEvents"/> to convert. </param>
        public static implicit operator RequestContent(GetEvents model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GetEvents"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GetEvents(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGetEvents(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
