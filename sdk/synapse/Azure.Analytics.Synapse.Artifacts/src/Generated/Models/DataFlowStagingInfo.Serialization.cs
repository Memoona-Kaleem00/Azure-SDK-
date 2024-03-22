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
    [JsonConverter(typeof(DataFlowStagingInfoConverter))]
    public partial class DataFlowStagingInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedService))
            {
                writer.WritePropertyName("linkedService"u8);
                writer.WriteObjectValue<LinkedServiceReference>(LinkedService);
            }
            if (Optional.IsDefined(FolderPath))
            {
                writer.WritePropertyName("folderPath"u8);
                writer.WriteObjectValue<object>(FolderPath);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowStagingInfo DeserializeDataFlowStagingInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LinkedServiceReference linkedService = default;
            object folderPath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("folderPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folderPath = property.Value.GetObject();
                    continue;
                }
            }
            return new DataFlowStagingInfo(linkedService, folderPath);
        }

        internal partial class DataFlowStagingInfoConverter : JsonConverter<DataFlowStagingInfo>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowStagingInfo model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue<DataFlowStagingInfo>(model);
            }
            public override DataFlowStagingInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowStagingInfo(document.RootElement);
            }
        }
    }
}
