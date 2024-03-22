// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class SearchResultValue : IUtf8JsonSerializable, IJsonModel<SearchResultValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchResultValue>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SearchResultValue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchResultValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SearchResultValue)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SearchScore))
            {
                writer.WritePropertyName("@search.score"u8);
                writer.WriteNumberValue(SearchScore.Value);
            }
            if (Optional.IsDefined(SearchHighlights))
            {
                writer.WritePropertyName("@search.highlights"u8);
                writer.WriteObjectValue<SearchHighlights>(SearchHighlights, options);
            }
            if (Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("objectType"u8);
                writer.WriteStringValue(ObjectType);
            }
            if (Optional.IsDefined(CreateTime))
            {
                writer.WritePropertyName("createTime"u8);
                writer.WriteNumberValue(CreateTime.Value);
            }
            if (Optional.IsDefined(UpdateTime))
            {
                writer.WritePropertyName("updateTime"u8);
                writer.WriteNumberValue(UpdateTime.Value);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(QualifiedName))
            {
                writer.WritePropertyName("qualifiedName"u8);
                writer.WriteStringValue(QualifiedName);
            }
            if (Optional.IsDefined(EntityType))
            {
                writer.WritePropertyName("entityType"u8);
                writer.WriteStringValue(EntityType);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Endorsement))
            {
                writer.WritePropertyName("endorsement"u8);
                writer.WriteStringValue(Endorsement);
            }
            if (Optional.IsDefined(Owner))
            {
                writer.WritePropertyName("owner"u8);
                writer.WriteStringValue(Owner);
            }
            if (Optional.IsCollectionDefined(Classification))
            {
                writer.WritePropertyName("classification"u8);
                writer.WriteStartArray();
                foreach (var item in Classification)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStartArray();
                foreach (var item in Label)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Term))
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStartArray();
                foreach (var item in Term)
                {
                    writer.WriteObjectValue<TermSearchResultValue>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Contact))
            {
                writer.WritePropertyName("contact"u8);
                writer.WriteStartArray();
                foreach (var item in Contact)
                {
                    writer.WriteObjectValue<ContactSearchResultValue>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AssetType))
            {
                writer.WritePropertyName("assetType"u8);
                writer.WriteStartArray();
                foreach (var item in AssetType)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(GlossaryType))
            {
                writer.WritePropertyName("glossaryType"u8);
                writer.WriteStringValue(GlossaryType);
            }
            if (Optional.IsDefined(Glossary))
            {
                writer.WritePropertyName("glossary"u8);
                writer.WriteStringValue(Glossary);
            }
            if (Optional.IsDefined(TermStatus))
            {
                writer.WritePropertyName("termStatus"u8);
                writer.WriteStringValue(TermStatus);
            }
            if (Optional.IsCollectionDefined(TermTemplate))
            {
                writer.WritePropertyName("termTemplate"u8);
                writer.WriteStartArray();
                foreach (var item in TermTemplate)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LongDescription))
            {
                writer.WritePropertyName("longDescription"u8);
                writer.WriteStringValue(LongDescription);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SearchResultValue IJsonModel<SearchResultValue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchResultValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SearchResultValue)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchResultValue(document.RootElement, options);
        }

        internal static SearchResultValue DeserializeSearchResultValue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? searchScore = default;
            SearchHighlights searchHighlights = default;
            string objectType = default;
            long? createTime = default;
            long? updateTime = default;
            string id = default;
            string name = default;
            string qualifiedName = default;
            string entityType = default;
            string description = default;
            string endorsement = default;
            string owner = default;
            IReadOnlyList<string> classification = default;
            IReadOnlyList<string> label = default;
            IReadOnlyList<TermSearchResultValue> term = default;
            IReadOnlyList<ContactSearchResultValue> contact = default;
            IReadOnlyList<string> assetType = default;
            string glossaryType = default;
            string glossary = default;
            string termStatus = default;
            IReadOnlyList<string> termTemplate = default;
            string longDescription = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@search.score"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchScore = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("@search.highlights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchHighlights = SearchHighlights.DeserializeSearchHighlights(property.Value, options);
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("updateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qualifiedName"u8))
                {
                    qualifiedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entityType"u8))
                {
                    entityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endorsement"u8))
                {
                    endorsement = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("owner"u8))
                {
                    owner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("classification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    classification = array;
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    label = array;
                    continue;
                }
                if (property.NameEquals("term"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TermSearchResultValue> array = new List<TermSearchResultValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TermSearchResultValue.DeserializeTermSearchResultValue(item, options));
                    }
                    term = array;
                    continue;
                }
                if (property.NameEquals("contact"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContactSearchResultValue> array = new List<ContactSearchResultValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContactSearchResultValue.DeserializeContactSearchResultValue(item, options));
                    }
                    contact = array;
                    continue;
                }
                if (property.NameEquals("assetType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    assetType = array;
                    continue;
                }
                if (property.NameEquals("glossaryType"u8))
                {
                    glossaryType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("glossary"u8))
                {
                    glossary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("termStatus"u8))
                {
                    termStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("termTemplate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    termTemplate = array;
                    continue;
                }
                if (property.NameEquals("longDescription"u8))
                {
                    longDescription = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SearchResultValue(
                searchScore,
                searchHighlights,
                objectType,
                createTime,
                updateTime,
                id,
                name,
                qualifiedName,
                entityType,
                description,
                endorsement,
                owner,
                classification ?? new ChangeTrackingList<string>(),
                label ?? new ChangeTrackingList<string>(),
                term ?? new ChangeTrackingList<TermSearchResultValue>(),
                contact ?? new ChangeTrackingList<ContactSearchResultValue>(),
                assetType ?? new ChangeTrackingList<string>(),
                glossaryType,
                glossary,
                termStatus,
                termTemplate ?? new ChangeTrackingList<string>(),
                longDescription,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SearchResultValue>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchResultValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SearchResultValue)} does not support writing '{options.Format}' format.");
            }
        }

        SearchResultValue IPersistableModel<SearchResultValue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchResultValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSearchResultValue(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SearchResultValue)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SearchResultValue>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SearchResultValue FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSearchResultValue(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<SearchResultValue>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
