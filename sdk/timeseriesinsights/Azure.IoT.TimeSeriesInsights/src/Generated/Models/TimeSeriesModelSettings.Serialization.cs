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
    public partial class TimeSeriesModelSettings : IUtf8JsonSerializable, IModelJsonSerializable<TimeSeriesModelSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TimeSeriesModelSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TimeSeriesModelSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesModelSettings>(this, options.Format);

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

        internal static TimeSeriesModelSettings DeserializeTimeSeriesModelSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<TimeSeriesIdProperty>> timeSeriesIdProperties = default;
            Optional<string> defaultTypeId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeSeriesIdProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TimeSeriesIdProperty> array = new List<TimeSeriesIdProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesIdProperty.DeserializeTimeSeriesIdProperty(item));
                    }
                    timeSeriesIdProperties = array;
                    continue;
                }
                if (property.NameEquals("defaultTypeId"u8))
                {
                    defaultTypeId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TimeSeriesModelSettings(name.Value, Optional.ToList(timeSeriesIdProperties), defaultTypeId.Value, rawData);
        }

        TimeSeriesModelSettings IModelJsonSerializable<TimeSeriesModelSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesModelSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTimeSeriesModelSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TimeSeriesModelSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesModelSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TimeSeriesModelSettings IModelSerializable<TimeSeriesModelSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesModelSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTimeSeriesModelSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TimeSeriesModelSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TimeSeriesModelSettings"/> to convert. </param>
        public static implicit operator RequestContent(TimeSeriesModelSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TimeSeriesModelSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TimeSeriesModelSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTimeSeriesModelSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
