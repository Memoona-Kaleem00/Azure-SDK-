// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Catalog.Models
{
    public partial class AtlasTermAssignmentHeader : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Confidence))
            {
                writer.WritePropertyName("confidence");
                writer.WriteNumberValue(Confidence.Value);
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy");
                writer.WriteStringValue(CreatedBy);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayText))
            {
                writer.WritePropertyName("displayText");
                writer.WriteStringValue(DisplayText);
            }
            if (Optional.IsDefined(Expression))
            {
                writer.WritePropertyName("expression");
                writer.WriteStringValue(Expression);
            }
            if (Optional.IsDefined(RelationGuid))
            {
                writer.WritePropertyName("relationGuid");
                writer.WriteStringValue(RelationGuid);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source");
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Steward))
            {
                writer.WritePropertyName("steward");
                writer.WriteStringValue(Steward);
            }
            if (Optional.IsDefined(TermGuid))
            {
                writer.WritePropertyName("termGuid");
                writer.WriteStringValue(TermGuid);
            }
            writer.WriteEndObject();
        }

        internal static AtlasTermAssignmentHeader DeserializeAtlasTermAssignmentHeader(JsonElement element)
        {
            Optional<int> confidence = default;
            Optional<string> createdBy = default;
            Optional<string> description = default;
            Optional<string> displayText = default;
            Optional<string> expression = default;
            Optional<string> relationGuid = default;
            Optional<string> source = default;
            Optional<AtlasTermAssignmentStatus> status = default;
            Optional<string> steward = default;
            Optional<string> termGuid = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("confidence"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    confidence = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("createdBy"))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayText"))
                {
                    displayText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expression"))
                {
                    expression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relationGuid"))
                {
                    relationGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new AtlasTermAssignmentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("steward"))
                {
                    steward = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("termGuid"))
                {
                    termGuid = property.Value.GetString();
                    continue;
                }
            }
            return new AtlasTermAssignmentHeader(Optional.ToNullable(confidence), createdBy.Value, description.Value, displayText.Value, expression.Value, relationGuid.Value, source.Value, Optional.ToNullable(status), steward.Value, termGuid.Value);
        }
    }
}
