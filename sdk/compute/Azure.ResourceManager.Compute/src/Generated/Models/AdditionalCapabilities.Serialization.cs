// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class AdditionalCapabilities : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UltraSsdEnabled))
            {
                writer.WritePropertyName("ultraSSDEnabled");
                writer.WriteBooleanValue(UltraSsdEnabled.Value);
            }
            if (Optional.IsDefined(HibernationEnabled))
            {
                writer.WritePropertyName("hibernationEnabled");
                writer.WriteBooleanValue(HibernationEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static AdditionalCapabilities DeserializeAdditionalCapabilities(JsonElement element)
        {
            Optional<bool> ultraSSDEnabled = default;
            Optional<bool> hibernationEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ultraSSDEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ultraSSDEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hibernationEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hibernationEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AdditionalCapabilities(Optional.ToNullable(ultraSSDEnabled), Optional.ToNullable(hibernationEnabled));
        }
    }
}
