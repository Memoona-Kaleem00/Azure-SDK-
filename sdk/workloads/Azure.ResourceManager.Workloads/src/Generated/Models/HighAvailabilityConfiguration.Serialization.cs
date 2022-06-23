// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    internal partial class HighAvailabilityConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("highAvailabilityType");
            writer.WriteStringValue(HighAvailabilityType.ToString());
            writer.WriteEndObject();
        }

        internal static HighAvailabilityConfiguration DeserializeHighAvailabilityConfiguration(JsonElement element)
        {
            SapHighAvailabilityType highAvailabilityType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("highAvailabilityType"))
                {
                    highAvailabilityType = new SapHighAvailabilityType(property.Value.GetString());
                    continue;
                }
            }
            return new HighAvailabilityConfiguration(highAvailabilityType);
        }
    }
}
