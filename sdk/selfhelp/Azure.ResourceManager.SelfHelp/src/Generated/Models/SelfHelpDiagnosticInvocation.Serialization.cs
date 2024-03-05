// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SelfHelp;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class SelfHelpDiagnosticInvocation : IUtf8JsonSerializable, IJsonModel<SelfHelpDiagnosticInvocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SelfHelpDiagnosticInvocation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SelfHelpDiagnosticInvocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticInvocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHelpDiagnosticInvocation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SolutionId))
            {
                writer.WritePropertyName("solutionId"u8);
                writer.WriteStringValue(SolutionId);
            }
            if (Optional.IsCollectionDefined(AdditionalParameters))
            {
                writer.WritePropertyName("additionalParameters"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        SelfHelpDiagnosticInvocation IJsonModel<SelfHelpDiagnosticInvocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticInvocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHelpDiagnosticInvocation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSelfHelpDiagnosticInvocation(document.RootElement, options);
        }

        internal static SelfHelpDiagnosticInvocation DeserializeSelfHelpDiagnosticInvocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string solutionId = default;
            IDictionary<string, string> additionalParameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("solutionId"u8))
                {
                    solutionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalParameters"u8))
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
                    additionalParameters = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SelfHelpDiagnosticInvocation(solutionId, additionalParameters ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SelfHelpDiagnosticInvocation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticInvocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SelfHelpDiagnosticInvocation)} does not support '{options.Format}' format.");
            }
        }

        SelfHelpDiagnosticInvocation IPersistableModel<SelfHelpDiagnosticInvocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpDiagnosticInvocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSelfHelpDiagnosticInvocation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SelfHelpDiagnosticInvocation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SelfHelpDiagnosticInvocation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
