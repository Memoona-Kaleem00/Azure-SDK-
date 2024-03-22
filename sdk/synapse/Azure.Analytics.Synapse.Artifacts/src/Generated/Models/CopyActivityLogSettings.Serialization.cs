// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(CopyActivityLogSettingsConverter))]
    public partial class CopyActivityLogSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LogLevel))
            {
                writer.WritePropertyName("logLevel"u8);
                writer.WriteObjectValue<object>(LogLevel);
            }
            if (Optional.IsDefined(EnableReliableLogging))
            {
                writer.WritePropertyName("enableReliableLogging"u8);
                writer.WriteObjectValue<object>(EnableReliableLogging);
            }
            writer.WriteEndObject();
        }

        internal static CopyActivityLogSettings DeserializeCopyActivityLogSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object logLevel = default;
            object enableReliableLogging = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logLevel = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("enableReliableLogging"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableReliableLogging = property.Value.GetObject();
                    continue;
                }
            }
            return new CopyActivityLogSettings(logLevel, enableReliableLogging);
        }

        internal partial class CopyActivityLogSettingsConverter : JsonConverter<CopyActivityLogSettings>
        {
            public override void Write(Utf8JsonWriter writer, CopyActivityLogSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue<CopyActivityLogSettings>(model);
            }
            public override CopyActivityLogSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCopyActivityLogSettings(document.RootElement);
            }
        }
    }
}
