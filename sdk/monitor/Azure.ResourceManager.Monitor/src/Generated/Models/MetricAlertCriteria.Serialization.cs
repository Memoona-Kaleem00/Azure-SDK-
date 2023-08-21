// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MetricAlertCriteria : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("odata.type"u8);
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

        internal static MetricAlertCriteria DeserializeMetricAlertCriteria(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.Azure.Monitor.MultipleResourceMultipleMetricCriteria": return MetricAlertMultipleResourceMultipleMetricCriteria.DeserializeMetricAlertMultipleResourceMultipleMetricCriteria(element);
                    case "Microsoft.Azure.Monitor.SingleResourceMultipleMetricCriteria": return MetricAlertSingleResourceMultipleMetricCriteria.DeserializeMetricAlertSingleResourceMultipleMetricCriteria(element);
                    case "Microsoft.Azure.Monitor.WebtestLocationAvailabilityCriteria": return WebtestLocationAvailabilityCriteria.DeserializeWebtestLocationAvailabilityCriteria(element);
                }
            }
            return UnknownMetricAlertCriteria.DeserializeUnknownMetricAlertCriteria(element);
        }
    }
}
