// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class DscNodeReport : IUtf8JsonSerializable, IJsonModel<DscNodeReport>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DscNodeReport>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DscNodeReport>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeReport>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscNodeReport)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (EndOn.HasValue)
            {
                if (EndOn != null)
                {
                    writer.WritePropertyName("endTime"u8);
                    writer.WriteStringValue(EndOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("endTime");
                }
            }
            if (LastModifiedOn.HasValue)
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (StartOn.HasValue)
            {
                if (StartOn != null)
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("startTime");
                }
            }
            if (DscNodeReportType != null)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(DscNodeReportType);
            }
            if (ReportId != null)
            {
                writer.WritePropertyName("reportId"u8);
                writer.WriteStringValue(ReportId);
            }
            if (Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (RefreshMode != null)
            {
                writer.WritePropertyName("refreshMode"u8);
                writer.WriteStringValue(RefreshMode);
            }
            if (RebootRequested != null)
            {
                writer.WritePropertyName("rebootRequested"u8);
                writer.WriteStringValue(RebootRequested);
            }
            if (ReportFormatVersion != null)
            {
                writer.WritePropertyName("reportFormatVersion"u8);
                writer.WriteStringValue(ReportFormatVersion);
            }
            if (ConfigurationVersion != null)
            {
                writer.WritePropertyName("configurationVersion"u8);
                writer.WriteStringValue(ConfigurationVersion);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (!(Errors is ChangeTrackingList<DscReportError> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Resources is ChangeTrackingList<DscReportResource> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteStartArray();
                foreach (var item in Resources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (MetaConfiguration != null)
            {
                writer.WritePropertyName("metaConfiguration"u8);
                writer.WriteObjectValue(MetaConfiguration);
            }
            if (HostName != null)
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (!(IPV4Addresses is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("iPV4Addresses"u8);
                writer.WriteStartArray();
                foreach (var item in IPV4Addresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(IPV6Addresses is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("iPV6Addresses"u8);
                writer.WriteStartArray();
                foreach (var item in IPV6Addresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (NumberOfResources.HasValue)
            {
                writer.WritePropertyName("numberOfResources"u8);
                writer.WriteNumberValue(NumberOfResources.Value);
            }
            if (RawErrors != null)
            {
                writer.WritePropertyName("rawErrors"u8);
                writer.WriteStringValue(RawErrors);
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

        DscNodeReport IJsonModel<DscNodeReport>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeReport>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscNodeReport)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDscNodeReport(document.RootElement, options);
        }

        internal static DscNodeReport DeserializeDscNodeReport(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset?> endTime = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<DateTimeOffset?> startTime = default;
            Optional<string> type = default;
            Optional<string> reportId = default;
            Optional<string> status = default;
            Optional<string> refreshMode = default;
            Optional<string> rebootRequested = default;
            Optional<string> reportFormatVersion = default;
            Optional<string> configurationVersion = default;
            Optional<string> id = default;
            IReadOnlyList<DscReportError> errors = default;
            IReadOnlyList<DscReportResource> resources = default;
            Optional<DscMetaConfiguration> metaConfiguration = default;
            Optional<string> hostName = default;
            IReadOnlyList<string> ipV4Addresses = default;
            IReadOnlyList<string> ipV6Addresses = default;
            Optional<int> numberOfResources = default;
            Optional<string> rawErrors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startTime = null;
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reportId"u8))
                {
                    reportId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshMode"u8))
                {
                    refreshMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rebootRequested"u8))
                {
                    rebootRequested = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reportFormatVersion"u8))
                {
                    reportFormatVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationVersion"u8))
                {
                    configurationVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DscReportError> array = new List<DscReportError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DscReportError.DeserializeDscReportError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DscReportResource> array = new List<DscReportResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DscReportResource.DeserializeDscReportResource(item, options));
                    }
                    resources = array;
                    continue;
                }
                if (property.NameEquals("metaConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metaConfiguration = DscMetaConfiguration.DeserializeDscMetaConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iPV4Addresses"u8))
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
                    ipV4Addresses = array;
                    continue;
                }
                if (property.NameEquals("iPV6Addresses"u8))
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
                    ipV6Addresses = array;
                    continue;
                }
                if (property.NameEquals("numberOfResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfResources = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rawErrors"u8))
                {
                    rawErrors = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DscNodeReport(
                Optional.ToNullable(endTime),
                Optional.ToNullable(lastModifiedTime),
                Optional.ToNullable(startTime),
                type.Value,
                reportId.Value,
                status.Value,
                refreshMode.Value,
                rebootRequested.Value,
                reportFormatVersion.Value,
                configurationVersion.Value,
                id.Value,
                errors ?? new ChangeTrackingList<DscReportError>(),
                resources ?? new ChangeTrackingList<DscReportResource>(),
                metaConfiguration.Value,
                hostName.Value,
                ipV4Addresses ?? new ChangeTrackingList<string>(),
                ipV6Addresses ?? new ChangeTrackingList<string>(),
                Optional.ToNullable(numberOfResources),
                rawErrors.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DscNodeReport>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeReport>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DscNodeReport)} does not support '{options.Format}' format.");
            }
        }

        DscNodeReport IPersistableModel<DscNodeReport>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeReport>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDscNodeReport(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DscNodeReport)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DscNodeReport>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
