// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PolicyInsights;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    internal partial class CheckRestrictionsResultContentEvaluationResult : IUtf8JsonSerializable, IJsonModel<CheckRestrictionsResultContentEvaluationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CheckRestrictionsResultContentEvaluationResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CheckRestrictionsResultContentEvaluationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckRestrictionsResultContentEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckRestrictionsResultContentEvaluationResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(PolicyEvaluations is ChangeTrackingList<PolicyEvaluationResult> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("policyEvaluations"u8);
                writer.WriteStartArray();
                foreach (var item in PolicyEvaluations)
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

        CheckRestrictionsResultContentEvaluationResult IJsonModel<CheckRestrictionsResultContentEvaluationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckRestrictionsResultContentEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CheckRestrictionsResultContentEvaluationResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCheckRestrictionsResultContentEvaluationResult(document.RootElement, options);
        }

        internal static CheckRestrictionsResultContentEvaluationResult DeserializeCheckRestrictionsResultContentEvaluationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<PolicyEvaluationResult> policyEvaluations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyEvaluations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PolicyEvaluationResult> array = new List<PolicyEvaluationResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicyEvaluationResult.DeserializePolicyEvaluationResult(item, options));
                    }
                    policyEvaluations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CheckRestrictionsResultContentEvaluationResult(policyEvaluations ?? new ChangeTrackingList<PolicyEvaluationResult>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CheckRestrictionsResultContentEvaluationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckRestrictionsResultContentEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CheckRestrictionsResultContentEvaluationResult)} does not support '{options.Format}' format.");
            }
        }

        CheckRestrictionsResultContentEvaluationResult IPersistableModel<CheckRestrictionsResultContentEvaluationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CheckRestrictionsResultContentEvaluationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCheckRestrictionsResultContentEvaluationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CheckRestrictionsResultContentEvaluationResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CheckRestrictionsResultContentEvaluationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
