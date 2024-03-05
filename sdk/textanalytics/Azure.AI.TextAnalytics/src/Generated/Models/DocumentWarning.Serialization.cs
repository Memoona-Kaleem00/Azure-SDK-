// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class DocumentWarning : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("code"u8);
            writer.WriteStringValue(Code.ToSerialString());
            writer.WritePropertyName("message"u8);
            writer.WriteStringValue(Message);
            if (Optional.IsDefined(TargetRef))
            {
                writer.WritePropertyName("targetRef"u8);
                writer.WriteStringValue(TargetRef);
            }
            writer.WriteEndObject();
        }

        internal static DocumentWarning DeserializeDocumentWarning(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WarningCodeValue code = default;
            string message = default;
            string targetRef = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString().ToWarningCodeValue();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetRef"u8))
                {
                    targetRef = property.Value.GetString();
                    continue;
                }
            }
            return new DocumentWarning(code, message, targetRef);
        }
    }
}
