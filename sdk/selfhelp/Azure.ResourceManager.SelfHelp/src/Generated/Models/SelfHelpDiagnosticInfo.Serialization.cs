// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class SelfHelpDiagnosticInfo : IUtf8JsonSerializable, IJsonModel<SelfHelpDiagnosticInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SelfHelpDiagnosticInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SelfHelpDiagnosticInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHelpDiagnosticInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SolutionId))
            {
                writer.WritePropertyName("solutionId"u8);
                writer.WriteStringValue(SolutionId);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Insights))
            {
                writer.WritePropertyName("insights"u8);
                writer.WriteStartArray();
                foreach (var item in Insights)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
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

        SelfHelpDiagnosticInfo IJsonModel<SelfHelpDiagnosticInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHelpDiagnosticInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSelfHelpDiagnosticInfo(document.RootElement, options);
        }

        internal static SelfHelpDiagnosticInfo DeserializeSelfHelpDiagnosticInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string solutionId = default;
            SelfHelpDiagnosticStatus? status = default;
            IReadOnlyList<SelfHelpDiagnosticInsight> insights = default;
            SelfHelpError error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("solutionId"u8))
                {
                    solutionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new SelfHelpDiagnosticStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("insights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SelfHelpDiagnosticInsight> array = new List<SelfHelpDiagnosticInsight>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SelfHelpDiagnosticInsight.DeserializeSelfHelpDiagnosticInsight(item, options));
                    }
                    insights = array;
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = SelfHelpError.DeserializeSelfHelpError(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SelfHelpDiagnosticInfo(solutionId, status, insights ?? new ChangeTrackingList<SelfHelpDiagnosticInsight>(), error, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SelfHelpDiagnosticInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SelfHelpDiagnosticInfo)} does not support '{options.Format}' format.");
            }
        }

        SelfHelpDiagnosticInfo IPersistableModel<SelfHelpDiagnosticInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSelfHelpDiagnosticInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SelfHelpDiagnosticInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SelfHelpDiagnosticInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
