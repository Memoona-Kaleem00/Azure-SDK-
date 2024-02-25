// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class LinkerValidateOperationResult : IUtf8JsonSerializable, IJsonModel<LinkerValidateOperationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkerValidateOperationResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LinkerValidateOperationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkerValidateOperationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkerValidateOperationResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ResourceId != null)
            {
                if (ResourceId != null)
                {
                    writer.WritePropertyName("resourceId"u8);
                    writer.WriteStringValue(ResourceId);
                }
                else
                {
                    writer.WriteNull("resourceId");
                }
            }
            if (Status != null)
            {
                if (Status != null)
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status);
                }
                else
                {
                    writer.WriteNull("status");
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (LinkerName != null)
            {
                if (LinkerName != null)
                {
                    writer.WritePropertyName("linkerName"u8);
                    writer.WriteStringValue(LinkerName);
                }
                else
                {
                    writer.WriteNull("linkerName");
                }
            }
            if (IsConnectionAvailable.HasValue)
            {
                if (IsConnectionAvailable != null)
                {
                    writer.WritePropertyName("isConnectionAvailable"u8);
                    writer.WriteBooleanValue(IsConnectionAvailable.Value);
                }
                else
                {
                    writer.WriteNull("isConnectionAvailable");
                }
            }
            if (ReportStartOn.HasValue)
            {
                if (ReportStartOn != null)
                {
                    writer.WritePropertyName("reportStartTimeUtc"u8);
                    writer.WriteStringValue(ReportStartOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("reportStartTimeUtc");
                }
            }
            if (ReportEndOn.HasValue)
            {
                if (ReportEndOn != null)
                {
                    writer.WritePropertyName("reportEndTimeUtc"u8);
                    writer.WriteStringValue(ReportEndOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("reportEndTimeUtc");
                }
            }
            if (SourceId != null)
            {
                if (SourceId != null)
                {
                    writer.WritePropertyName("sourceId"u8);
                    writer.WriteStringValue(SourceId);
                }
                else
                {
                    writer.WriteNull("sourceId");
                }
            }
            if (TargetId != null)
            {
                if (TargetId != null)
                {
                    writer.WritePropertyName("targetId"u8);
                    writer.WriteStringValue(TargetId);
                }
                else
                {
                    writer.WriteNull("targetId");
                }
            }
            if (AuthType.HasValue)
            {
                if (AuthType != null)
                {
                    writer.WritePropertyName("authType"u8);
                    writer.WriteStringValue(AuthType.Value.ToString());
                }
                else
                {
                    writer.WriteNull("authType");
                }
            }
            if (!(ValidationDetail is ChangeTrackingList<LinkerValidationResultItemInfo> collection && collection.IsUndefined))
            {
                if (ValidationDetail != null)
                {
                    writer.WritePropertyName("validationDetail"u8);
                    writer.WriteStartArray();
                    foreach (var item in ValidationDetail)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("validationDetail");
                }
            }
            writer.WriteEndObject();
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

        LinkerValidateOperationResult IJsonModel<LinkerValidateOperationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkerValidateOperationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkerValidateOperationResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkerValidateOperationResult(document.RootElement, options);
        }

        internal static LinkerValidateOperationResult DeserializeLinkerValidateOperationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> resourceId = default;
            Optional<string> status = default;
            Optional<string> linkerName = default;
            Optional<bool?> isConnectionAvailable = default;
            Optional<DateTimeOffset?> reportStartTimeUtc = default;
            Optional<DateTimeOffset?> reportEndTimeUtc = default;
            Optional<ResourceIdentifier> sourceId = default;
            Optional<ResourceIdentifier> targetId = default;
            Optional<LinkerAuthType?> authType = default;
            IReadOnlyList<LinkerValidationResultItemInfo> validationDetail = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceId = null;
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        status = null;
                        continue;
                    }
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("linkerName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                linkerName = null;
                                continue;
                            }
                            linkerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isConnectionAvailable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                isConnectionAvailable = null;
                                continue;
                            }
                            isConnectionAvailable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("reportStartTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                reportStartTimeUtc = null;
                                continue;
                            }
                            reportStartTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("reportEndTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                reportEndTimeUtc = null;
                                continue;
                            }
                            reportEndTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                sourceId = null;
                                continue;
                            }
                            sourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                targetId = null;
                                continue;
                            }
                            targetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("authType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                authType = null;
                                continue;
                            }
                            authType = new LinkerAuthType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("validationDetail"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                validationDetail = null;
                                continue;
                            }
                            List<LinkerValidationResultItemInfo> array = new List<LinkerValidationResultItemInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LinkerValidationResultItemInfo.DeserializeLinkerValidationResultItemInfo(item, options));
                            }
                            validationDetail = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LinkerValidateOperationResult(resourceId.Value, status.Value, linkerName.Value, Optional.ToNullable(isConnectionAvailable), Optional.ToNullable(reportStartTimeUtc), Optional.ToNullable(reportEndTimeUtc), sourceId.Value, targetId.Value, Optional.ToNullable(authType), validationDetail ?? new ChangeTrackingList<LinkerValidationResultItemInfo>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LinkerValidateOperationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkerValidateOperationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LinkerValidateOperationResult)} does not support '{options.Format}' format.");
            }
        }

        LinkerValidateOperationResult IPersistableModel<LinkerValidateOperationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkerValidateOperationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLinkerValidateOperationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LinkerValidateOperationResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LinkerValidateOperationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
