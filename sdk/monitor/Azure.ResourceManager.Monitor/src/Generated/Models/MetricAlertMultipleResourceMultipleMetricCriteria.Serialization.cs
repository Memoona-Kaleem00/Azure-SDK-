// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MetricAlertMultipleResourceMultipleMetricCriteria : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllOf))
            {
                writer.WritePropertyName("allOf");
                writer.WriteStartArray();
                foreach (var item in AllOf)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("odata.type");
            writer.WriteStringValue(OdataType.ToString());
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static MetricAlertMultipleResourceMultipleMetricCriteria DeserializeMetricAlertMultipleResourceMultipleMetricCriteria(JsonElement element)
        {
            Optional<IList<MultiMetricCriteria>> allOf = default;
            Odatatype odataType = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allOf"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MultiMetricCriteria> array = new List<MultiMetricCriteria>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MultiMetricCriteria.DeserializeMultiMetricCriteria(item));
                    }
                    allOf = array;
                    continue;
                }
                if (property.NameEquals("odata.type"))
                {
                    odataType = new Odatatype(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new MetricAlertMultipleResourceMultipleMetricCriteria(odataType, additionalProperties, Optional.ToList(allOf));
        }
    }
}
