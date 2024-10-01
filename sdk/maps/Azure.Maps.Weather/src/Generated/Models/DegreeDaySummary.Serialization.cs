// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Maps.Weather.Models
{
    public partial class DegreeDaySummary
    {
        internal static DegreeDaySummary DeserializeDegreeDaySummary(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WeatherValue heating = default;
            WeatherValue cooling = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("heating"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    heating = WeatherValue.DeserializeWeatherValue(property.Value);
                    continue;
                }
                if (property.NameEquals("cooling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cooling = WeatherValue.DeserializeWeatherValue(property.Value);
                    continue;
                }
            }
            return new DegreeDaySummary(heating, cooling);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DegreeDaySummary FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDegreeDaySummary(document.RootElement);
        }
    }
}
