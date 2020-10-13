// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class PolybaseSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RejectType))
            {
                writer.WritePropertyName("rejectType");
                writer.WriteStringValue(RejectType.Value.ToString());
            }
            if (Optional.IsDefined(RejectValue))
            {
                writer.WritePropertyName("rejectValue");
                writer.WriteObjectValue(RejectValue);
            }
            if (Optional.IsDefined(RejectSampleValue))
            {
                writer.WritePropertyName("rejectSampleValue");
                writer.WriteObjectValue(RejectSampleValue);
            }
            if (Optional.IsDefined(UseTypeDefault))
            {
                writer.WritePropertyName("useTypeDefault");
                writer.WriteObjectValue(UseTypeDefault);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static PolybaseSettings DeserializePolybaseSettings(JsonElement element)
        {
            Optional<PolybaseSettingsRejectType> rejectType = default;
            Optional<object> rejectValue = default;
            Optional<object> rejectSampleValue = default;
            Optional<object> useTypeDefault = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rejectType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rejectType = new PolybaseSettingsRejectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rejectValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rejectValue = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("rejectSampleValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rejectSampleValue = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("useTypeDefault"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    useTypeDefault = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PolybaseSettings(Optional.ToNullable(rejectType), rejectValue.Value, rejectSampleValue.Value, useTypeDefault.Value, additionalProperties);
        }
    }
}
