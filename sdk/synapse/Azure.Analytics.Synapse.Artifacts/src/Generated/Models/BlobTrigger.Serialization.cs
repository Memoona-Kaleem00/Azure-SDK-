// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class BlobTrigger : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Pipelines))
            {
                writer.WritePropertyName("pipelines");
                writer.WriteStartArray();
                foreach (var item in Pipelines)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("folderPath");
            writer.WriteStringValue(FolderPath);
            writer.WritePropertyName("maxConcurrency");
            writer.WriteNumberValue(MaxConcurrency);
            writer.WritePropertyName("linkedService");
            writer.WriteObjectValue(LinkedService);
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static BlobTrigger DeserializeBlobTrigger(JsonElement element)
        {
            Optional<IList<TriggerPipelineReference>> pipelines = default;
            string type = default;
            Optional<string> description = default;
            Optional<TriggerRuntimeState> runtimeState = default;
            Optional<IList<object>> annotations = default;
            string folderPath = default;
            int maxConcurrency = default;
            LinkedServiceReference linkedService = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipelines"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TriggerPipelineReference> array = new List<TriggerPipelineReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TriggerPipelineReference.DeserializeTriggerPipelineReference(item));
                    }
                    pipelines = array;
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    runtimeState = new TriggerRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetObject());
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("folderPath"))
                        {
                            folderPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maxConcurrency"))
                        {
                            maxConcurrency = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("linkedService"))
                        {
                            linkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new BlobTrigger(type, description.Value, Optional.ToNullable(runtimeState), Optional.ToList(annotations), additionalProperties, Optional.ToList(pipelines), folderPath, maxConcurrency, linkedService);
        }
    }
}
