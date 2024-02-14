// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    public partial class DocumentPage : IUtf8JsonSerializable, IJsonModel<DocumentPage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentPage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DocumentPage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentPage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentPage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("pageNumber"u8);
            writer.WriteNumberValue(PageNumber);
            if (Optional.IsDefined(Angle))
            {
                writer.WritePropertyName("angle"u8);
                writer.WriteNumberValue(Angle.Value);
            }
            if (Optional.IsDefined(Width))
            {
                writer.WritePropertyName("width"u8);
                writer.WriteNumberValue(Width.Value);
            }
            if (Optional.IsDefined(Height))
            {
                writer.WritePropertyName("height"u8);
                writer.WriteNumberValue(Height.Value);
            }
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit.Value.ToString());
            }
            writer.WritePropertyName("spans"u8);
            writer.WriteStartArray();
            foreach (var item in Spans)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Words))
            {
                writer.WritePropertyName("words"u8);
                writer.WriteStartArray();
                foreach (var item in Words)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SelectionMarks))
            {
                writer.WritePropertyName("selectionMarks"u8);
                writer.WriteStartArray();
                foreach (var item in SelectionMarks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Lines))
            {
                writer.WritePropertyName("lines"u8);
                writer.WriteStartArray();
                foreach (var item in Lines)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Barcodes))
            {
                writer.WritePropertyName("barcodes"u8);
                writer.WriteStartArray();
                foreach (var item in Barcodes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Formulas))
            {
                writer.WritePropertyName("formulas"u8);
                writer.WriteStartArray();
                foreach (var item in Formulas)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        DocumentPage IJsonModel<DocumentPage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentPage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentPage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentPage(document.RootElement, options);
        }

        internal static DocumentPage DeserializeDocumentPage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int pageNumber = default;
            Optional<float> angle = default;
            Optional<float> width = default;
            Optional<float> height = default;
            Optional<LengthUnit> unit = default;
            IReadOnlyList<DocumentSpan> spans = default;
            Optional<IReadOnlyList<DocumentWord>> words = default;
            Optional<IReadOnlyList<DocumentSelectionMark>> selectionMarks = default;
            Optional<IReadOnlyList<DocumentLine>> lines = default;
            Optional<IReadOnlyList<DocumentBarcode>> barcodes = default;
            Optional<IReadOnlyList<DocumentFormula>> formulas = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pageNumber"u8))
                {
                    pageNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("angle"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    angle = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("width"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    width = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("height"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    height = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new LengthUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("spans"u8))
                {
                    List<DocumentSpan> array = new List<DocumentSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSpan.DeserializeDocumentSpan(item, options));
                    }
                    spans = array;
                    continue;
                }
                if (property.NameEquals("words"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentWord> array = new List<DocumentWord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentWord.DeserializeDocumentWord(item, options));
                    }
                    words = array;
                    continue;
                }
                if (property.NameEquals("selectionMarks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentSelectionMark> array = new List<DocumentSelectionMark>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSelectionMark.DeserializeDocumentSelectionMark(item, options));
                    }
                    selectionMarks = array;
                    continue;
                }
                if (property.NameEquals("lines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentLine> array = new List<DocumentLine>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentLine.DeserializeDocumentLine(item, options));
                    }
                    lines = array;
                    continue;
                }
                if (property.NameEquals("barcodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentBarcode> array = new List<DocumentBarcode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentBarcode.DeserializeDocumentBarcode(item, options));
                    }
                    barcodes = array;
                    continue;
                }
                if (property.NameEquals("formulas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentFormula> array = new List<DocumentFormula>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentFormula.DeserializeDocumentFormula(item, options));
                    }
                    formulas = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DocumentPage(pageNumber, Optional.ToNullable(angle), Optional.ToNullable(width), Optional.ToNullable(height), Optional.ToNullable(unit), spans, Optional.ToList(words), Optional.ToList(selectionMarks), Optional.ToList(lines), Optional.ToList(barcodes), Optional.ToList(formulas), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DocumentPage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentPage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DocumentPage)} does not support '{options.Format}' format.");
            }
        }

        DocumentPage IPersistableModel<DocumentPage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentPage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDocumentPage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentPage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentPage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentPage FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDocumentPage(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
