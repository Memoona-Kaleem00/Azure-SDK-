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
    [JsonConverter(typeof(DynamicExecutorAllocationConverter))]
    public partial class DynamicExecutorAllocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static DynamicExecutorAllocation DeserializeDynamicExecutorAllocation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DynamicExecutorAllocation(enabled);
        }

        internal partial class DynamicExecutorAllocationConverter : JsonConverter<DynamicExecutorAllocation>
        {
            public override void Write(Utf8JsonWriter writer, DynamicExecutorAllocation model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DynamicExecutorAllocation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDynamicExecutorAllocation(document.RootElement);
            }
        }
    }
}
