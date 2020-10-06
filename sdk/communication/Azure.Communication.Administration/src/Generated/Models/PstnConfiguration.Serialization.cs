// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    public partial class PstnConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("callbackUrl");
            writer.WriteStringValue(CallbackUrl);
            if (Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("applicationId");
                writer.WriteStringValue(ApplicationId);
            }
            writer.WriteEndObject();
        }

        internal static PstnConfiguration DeserializePstnConfiguration(JsonElement element)
        {
            string callbackUrl = default;
            Optional<string> applicationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("callbackUrl"))
                {
                    callbackUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationId"))
                {
                    applicationId = property.Value.GetString();
                    continue;
                }
            }
            return new PstnConfiguration(callbackUrl, applicationId.Value);
        }
    }
}
