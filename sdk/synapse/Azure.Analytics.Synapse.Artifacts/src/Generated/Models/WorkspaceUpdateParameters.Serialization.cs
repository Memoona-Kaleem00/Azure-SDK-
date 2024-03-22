// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(WorkspaceUpdateParametersConverter))]
    public partial class WorkspaceUpdateParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue<WorkspaceIdentity>(Identity);
            }
            writer.WriteEndObject();
        }

        internal static WorkspaceUpdateParameters DeserializeWorkspaceUpdateParameters(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            WorkspaceIdentity identity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = WorkspaceIdentity.DeserializeWorkspaceIdentity(property.Value);
                    continue;
                }
            }
            return new WorkspaceUpdateParameters(tags ?? new ChangeTrackingDictionary<string, string>(), identity);
        }

        internal partial class WorkspaceUpdateParametersConverter : JsonConverter<WorkspaceUpdateParameters>
        {
            public override void Write(Utf8JsonWriter writer, WorkspaceUpdateParameters model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue<WorkspaceUpdateParameters>(model);
            }
            public override WorkspaceUpdateParameters Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWorkspaceUpdateParameters(document.RootElement);
            }
        }
    }
}
