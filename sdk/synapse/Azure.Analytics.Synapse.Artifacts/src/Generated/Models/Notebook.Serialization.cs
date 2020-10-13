// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class Notebook : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(BigDataPool))
            {
                writer.WritePropertyName("bigDataPool");
                writer.WriteObjectValue(BigDataPool);
            }
            if (Optional.IsDefined(SessionProperties))
            {
                writer.WritePropertyName("sessionProperties");
                writer.WriteObjectValue(SessionProperties);
            }
            writer.WritePropertyName("metadata");
            writer.WriteObjectValue(Metadata);
            writer.WritePropertyName("nbformat");
            writer.WriteNumberValue(Nbformat);
            writer.WritePropertyName("nbformat_minor");
            writer.WriteNumberValue(NbformatMinor);
            writer.WritePropertyName("cells");
            writer.WriteStartArray();
            foreach (var item in Cells)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static Notebook DeserializeNotebook(JsonElement element)
        {
            Optional<string> description = default;
            Optional<BigDataPoolReference> bigDataPool = default;
            Optional<NotebookSessionProperties> sessionProperties = default;
            NotebookMetadata metadata = default;
            int nbformat = default;
            int nbformatMinor = default;
            IList<NotebookCell> cells = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bigDataPool"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bigDataPool = BigDataPoolReference.DeserializeBigDataPoolReference(property.Value);
                    continue;
                }
                if (property.NameEquals("sessionProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sessionProperties = NotebookSessionProperties.DeserializeNotebookSessionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    metadata = NotebookMetadata.DeserializeNotebookMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("nbformat"))
                {
                    nbformat = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nbformat_minor"))
                {
                    nbformatMinor = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cells"))
                {
                    List<NotebookCell> array = new List<NotebookCell>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NotebookCell.DeserializeNotebookCell(item));
                    }
                    cells = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new Notebook(description.Value, bigDataPool.Value, sessionProperties.Value, metadata, nbformat, nbformatMinor, cells, additionalProperties);
        }
    }
}
