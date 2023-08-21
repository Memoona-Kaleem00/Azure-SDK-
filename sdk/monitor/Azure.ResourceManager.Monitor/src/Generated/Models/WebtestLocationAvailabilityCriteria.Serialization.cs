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
    public partial class WebtestLocationAvailabilityCriteria : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("webTestId"u8);
            writer.WriteStringValue(WebTestId);
            writer.WritePropertyName("componentId"u8);
            writer.WriteStringValue(ComponentId);
            writer.WritePropertyName("failedLocationCount"u8);
            writer.WriteNumberValue(FailedLocationCount);
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

        internal static WebtestLocationAvailabilityCriteria DeserializeWebtestLocationAvailabilityCriteria(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier webTestId = default;
            ResourceIdentifier componentId = default;
            float failedLocationCount = default;
            MonitorOdataType odataType = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("webTestId"u8))
                {
                    webTestId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("componentId"u8))
                {
                    componentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failedLocationCount"u8))
                {
                    failedLocationCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("odata.type"u8))
                {
                    odataType = new MonitorOdataType(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new WebtestLocationAvailabilityCriteria(odataType, additionalProperties, webTestId, componentId, failedLocationCount);
        }
    }
}
