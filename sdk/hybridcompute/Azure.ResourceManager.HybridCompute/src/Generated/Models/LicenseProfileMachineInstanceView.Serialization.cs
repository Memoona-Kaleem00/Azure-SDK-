// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class LicenseProfileMachineInstanceView : IUtf8JsonSerializable, IJsonModel<LicenseProfileMachineInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LicenseProfileMachineInstanceView>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LicenseProfileMachineInstanceView>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LicenseProfileMachineInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LicenseProfileMachineInstanceView)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && LicenseStatus.HasValue)
            {
                writer.WritePropertyName("licenseStatus"u8);
                writer.WriteStringValue(LicenseStatus.Value.ToString());
            }
            if (options.Format != "W" && LicenseChannel != null)
            {
                writer.WritePropertyName("licenseChannel"u8);
                writer.WriteStringValue(LicenseChannel);
            }
            if (EsuProfile != null)
            {
                writer.WritePropertyName("esuProfile"u8);
                writer.WriteObjectValue(EsuProfile);
            }
            writer.WritePropertyName("productProfile"u8);
            writer.WriteStartObject();
            if (SubscriptionStatus.HasValue)
            {
                writer.WritePropertyName("subscriptionStatus"u8);
                writer.WriteStringValue(SubscriptionStatus.Value.ToString());
            }
            if (ProductType.HasValue)
            {
                writer.WritePropertyName("productType"u8);
                writer.WriteStringValue(ProductType.Value.ToString());
            }
            if (options.Format != "W" && BillingStartOn.HasValue)
            {
                writer.WritePropertyName("billingStartDate"u8);
                writer.WriteStringValue(BillingStartOn.Value, "O");
            }
            if (options.Format != "W" && EnrollmentOn.HasValue)
            {
                writer.WritePropertyName("enrollmentDate"u8);
                writer.WriteStringValue(EnrollmentOn.Value, "O");
            }
            if (options.Format != "W" && DisenrollmentOn.HasValue)
            {
                writer.WritePropertyName("disenrollmentDate"u8);
                writer.WriteStringValue(DisenrollmentOn.Value, "O");
            }
            if (!(ProductFeatures is ChangeTrackingList<HybridComputeProductFeature> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("productFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in ProductFeatures)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WritePropertyName("softwareAssurance"u8);
            writer.WriteStartObject();
            if (IsSoftwareAssuranceCustomer.HasValue)
            {
                writer.WritePropertyName("softwareAssuranceCustomer"u8);
                writer.WriteBooleanValue(IsSoftwareAssuranceCustomer.Value);
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

        LicenseProfileMachineInstanceView IJsonModel<LicenseProfileMachineInstanceView>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LicenseProfileMachineInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LicenseProfileMachineInstanceView)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLicenseProfileMachineInstanceView(document.RootElement, options);
        }

        internal static LicenseProfileMachineInstanceView DeserializeLicenseProfileMachineInstanceView(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HybridComputeLicenseStatus> licenseStatus = default;
            Optional<string> licenseChannel = default;
            Optional<LicenseProfileMachineInstanceViewEsuProperties> esuProfile = default;
            Optional<LicenseProfileSubscriptionStatus> subscriptionStatus = default;
            Optional<LicenseProfileProductType> productType = default;
            Optional<DateTimeOffset> billingStartDate = default;
            Optional<DateTimeOffset> enrollmentDate = default;
            Optional<DateTimeOffset> disenrollmentDate = default;
            Optional<IList<HybridComputeProductFeature>> productFeatures = default;
            Optional<bool> softwareAssuranceCustomer = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("licenseStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseStatus = new HybridComputeLicenseStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("licenseChannel"u8))
                {
                    licenseChannel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("esuProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    esuProfile = LicenseProfileMachineInstanceViewEsuProperties.DeserializeLicenseProfileMachineInstanceViewEsuProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("productProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("subscriptionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subscriptionStatus = new LicenseProfileSubscriptionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("productType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            productType = new LicenseProfileProductType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingStartDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingStartDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("enrollmentDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enrollmentDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("disenrollmentDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disenrollmentDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("productFeatures"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<HybridComputeProductFeature> array = new List<HybridComputeProductFeature>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HybridComputeProductFeature.DeserializeHybridComputeProductFeature(item, options));
                            }
                            productFeatures = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("softwareAssurance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("softwareAssuranceCustomer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            softwareAssuranceCustomer = property0.Value.GetBoolean();
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
            return new LicenseProfileMachineInstanceView(Optional.ToNullable(licenseStatus), licenseChannel.Value, esuProfile.Value, Optional.ToNullable(subscriptionStatus), Optional.ToNullable(productType), Optional.ToNullable(billingStartDate), Optional.ToNullable(enrollmentDate), Optional.ToNullable(disenrollmentDate), Optional.ToList(productFeatures), Optional.ToNullable(softwareAssuranceCustomer), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LicenseProfileMachineInstanceView>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LicenseProfileMachineInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LicenseProfileMachineInstanceView)} does not support '{options.Format}' format.");
            }
        }

        LicenseProfileMachineInstanceView IPersistableModel<LicenseProfileMachineInstanceView>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LicenseProfileMachineInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLicenseProfileMachineInstanceView(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LicenseProfileMachineInstanceView)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LicenseProfileMachineInstanceView>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
