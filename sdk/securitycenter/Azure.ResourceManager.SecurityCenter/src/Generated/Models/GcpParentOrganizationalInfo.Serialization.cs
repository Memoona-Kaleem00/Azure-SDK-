// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GcpParentOrganizationalInfo : IUtf8JsonSerializable, IJsonModel<GcpParentOrganizationalInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GcpParentOrganizationalInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GcpParentOrganizationalInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpParentOrganizationalInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GcpParentOrganizationalInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ExcludedProjectNumbers))
            {
                writer.WritePropertyName("excludedProjectNumbers"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedProjectNumbers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ServiceAccountEmailAddress))
            {
                writer.WritePropertyName("serviceAccountEmailAddress"u8);
                writer.WriteStringValue(ServiceAccountEmailAddress);
            }
            if (Optional.IsDefined(WorkloadIdentityProviderId))
            {
                writer.WritePropertyName("workloadIdentityProviderId"u8);
                writer.WriteStringValue(WorkloadIdentityProviderId);
            }
            if (options.Format != "W" && Optional.IsDefined(OrganizationName))
            {
                writer.WritePropertyName("organizationName"u8);
                writer.WriteStringValue(OrganizationName);
            }
            writer.WritePropertyName("organizationMembershipType"u8);
            writer.WriteStringValue(OrganizationMembershipType.ToString());
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

        GcpParentOrganizationalInfo IJsonModel<GcpParentOrganizationalInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpParentOrganizationalInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GcpParentOrganizationalInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGcpParentOrganizationalInfo(document.RootElement, options);
        }

        internal static GcpParentOrganizationalInfo DeserializeGcpParentOrganizationalInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> excludedProjectNumbers = default;
            string serviceAccountEmailAddress = default;
            string workloadIdentityProviderId = default;
            string organizationName = default;
            OrganizationMembershipType organizationMembershipType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("excludedProjectNumbers"u8))
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
                    excludedProjectNumbers = array;
                    continue;
                }
                if (property.NameEquals("serviceAccountEmailAddress"u8))
                {
                    serviceAccountEmailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadIdentityProviderId"u8))
                {
                    workloadIdentityProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organizationName"u8))
                {
                    organizationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organizationMembershipType"u8))
                {
                    organizationMembershipType = new OrganizationMembershipType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GcpParentOrganizationalInfo(
                organizationMembershipType,
                serializedAdditionalRawData,
                excludedProjectNumbers ?? new ChangeTrackingList<string>(),
                serviceAccountEmailAddress,
                workloadIdentityProviderId,
                organizationName);
        }

        BinaryData IPersistableModel<GcpParentOrganizationalInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpParentOrganizationalInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GcpParentOrganizationalInfo)} does not support '{options.Format}' format.");
            }
        }

        GcpParentOrganizationalInfo IPersistableModel<GcpParentOrganizationalInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpParentOrganizationalInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGcpParentOrganizationalInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GcpParentOrganizationalInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GcpParentOrganizationalInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
