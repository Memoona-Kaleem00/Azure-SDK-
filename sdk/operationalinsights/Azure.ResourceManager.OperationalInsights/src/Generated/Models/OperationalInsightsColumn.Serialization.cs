// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsColumn : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Core.Optional.IsDefined(ColumnType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ColumnType.Value.ToString());
            }
            if (Core.Optional.IsDefined(DataTypeHint))
            {
                writer.WritePropertyName("dataTypeHint"u8);
                writer.WriteStringValue(DataTypeHint.Value.ToString());
            }
            if (Core.Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Core.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static OperationalInsightsColumn DeserializeOperationalInsightsColumn(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<OperationalInsightsColumnType> type = default;
            Core.Optional<OperationalInsightsColumnDataTypeHint> dataTypeHint = default;
            Core.Optional<string> displayName = default;
            Core.Optional<string> description = default;
            Core.Optional<bool> isDefaultDisplay = default;
            Core.Optional<bool> isHidden = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new OperationalInsightsColumnType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataTypeHint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataTypeHint = new OperationalInsightsColumnDataTypeHint(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDefaultDisplay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefaultDisplay = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isHidden"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHidden = property.Value.GetBoolean();
                    continue;
                }
            }
            return new OperationalInsightsColumn(name.Value, Core.Optional.ToNullable(type), Core.Optional.ToNullable(dataTypeHint), displayName.Value, description.Value, Core.Optional.ToNullable(isDefaultDisplay), Core.Optional.ToNullable(isHidden));
        }
    }
}
