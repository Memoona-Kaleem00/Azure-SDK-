// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorSmsReceiver : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("countryCode"u8);
            writer.WriteStringValue(CountryCode);
            writer.WritePropertyName("phoneNumber"u8);
            writer.WriteStringValue(PhoneNumber);
            writer.WriteEndObject();
        }

        internal static MonitorSmsReceiver DeserializeMonitorSmsReceiver(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string countryCode = default;
            string phoneNumber = default;
            Core.Optional<MonitorReceiverStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryCode"u8))
                {
                    countryCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneNumber"u8))
                {
                    phoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToMonitorReceiverStatus();
                    continue;
                }
            }
            return new MonitorSmsReceiver(name, countryCode, phoneNumber, Core.Optional.ToNullable(status));
        }
    }
}
