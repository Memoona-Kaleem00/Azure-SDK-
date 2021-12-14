// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Scanning.Models
{
    public partial class AdlsGen1ScanRuleset : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteObjectValue(Properties);
            }
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(ScanRulesetType))
            {
                writer.WritePropertyName("scanRulesetType");
                writer.WriteStringValue(ScanRulesetType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AdlsGen1ScanRuleset DeserializeAdlsGen1ScanRuleset(JsonElement element)
        {
            Optional<AdlsGen1ScanRulesetPropertiesAutoGenerated> properties = default;
            DataSourceType kind = default;
            Optional<ScanRulesetType> scanRulesetType = default;
            Optional<ScanRulesetStatus> status = default;
            Optional<int> version = default;
            Optional<string> id = default;
            Optional<string> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = AdlsGen1ScanRulesetPropertiesAutoGenerated.DeserializeAdlsGen1ScanRulesetPropertiesAutoGenerated(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new DataSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scanRulesetType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scanRulesetType = new ScanRulesetType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new ScanRulesetStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    version = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new AdlsGen1ScanRuleset(id.Value, name.Value, Optional.ToNullable(scanRulesetType), Optional.ToNullable(status), Optional.ToNullable(version), kind, properties.Value);
        }
    }
}
