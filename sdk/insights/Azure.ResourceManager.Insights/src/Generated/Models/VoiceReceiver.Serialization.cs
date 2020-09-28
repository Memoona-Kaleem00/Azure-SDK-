// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class VoiceReceiver : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("countryCode");
            writer.WriteStringValue(CountryCode);
            writer.WritePropertyName("phoneNumber");
            writer.WriteStringValue(PhoneNumber);
            writer.WriteEndObject();
        }

        internal static VoiceReceiver DeserializeVoiceReceiver(JsonElement element)
        {
            string name = default;
            string countryCode = default;
            string phoneNumber = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryCode"))
                {
                    countryCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneNumber"))
                {
                    phoneNumber = property.Value.GetString();
                    continue;
                }
            }
            return new VoiceReceiver(name, countryCode, phoneNumber);
        }
    }
}
