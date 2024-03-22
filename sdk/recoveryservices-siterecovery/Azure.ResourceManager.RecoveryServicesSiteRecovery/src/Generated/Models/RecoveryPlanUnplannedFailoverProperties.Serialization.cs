// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanUnplannedFailoverProperties : IUtf8JsonSerializable, IJsonModel<RecoveryPlanUnplannedFailoverProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPlanUnplannedFailoverProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryPlanUnplannedFailoverProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanUnplannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanUnplannedFailoverProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("failoverDirection"u8);
            writer.WriteStringValue(FailoverDirection.ToString());
            writer.WritePropertyName("sourceSiteOperations"u8);
            writer.WriteStringValue(SourceSiteOperation.ToString());
            if (Optional.IsCollectionDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ProviderSpecificDetails)
                {
                    writer.WriteObjectValue<RecoveryPlanProviderSpecificFailoverContent>(item, options);
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

        RecoveryPlanUnplannedFailoverProperties IJsonModel<RecoveryPlanUnplannedFailoverProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanUnplannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanUnplannedFailoverProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanUnplannedFailoverProperties(document.RootElement, options);
        }

        internal static RecoveryPlanUnplannedFailoverProperties DeserializeRecoveryPlanUnplannedFailoverProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PossibleOperationsDirection failoverDirection = default;
            SourceSiteOperation sourceSiteOperations = default;
            IList<RecoveryPlanProviderSpecificFailoverContent> providerSpecificDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failoverDirection"u8))
                {
                    failoverDirection = new PossibleOperationsDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceSiteOperations"u8))
                {
                    sourceSiteOperations = new SourceSiteOperation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPlanProviderSpecificFailoverContent> array = new List<RecoveryPlanProviderSpecificFailoverContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPlanProviderSpecificFailoverContent.DeserializeRecoveryPlanProviderSpecificFailoverContent(item, options));
                    }
                    providerSpecificDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecoveryPlanUnplannedFailoverProperties(failoverDirection, sourceSiteOperations, providerSpecificDetails ?? new ChangeTrackingList<RecoveryPlanProviderSpecificFailoverContent>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecoveryPlanUnplannedFailoverProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanUnplannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanUnplannedFailoverProperties)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryPlanUnplannedFailoverProperties IPersistableModel<RecoveryPlanUnplannedFailoverProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanUnplannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryPlanUnplannedFailoverProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanUnplannedFailoverProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPlanUnplannedFailoverProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
