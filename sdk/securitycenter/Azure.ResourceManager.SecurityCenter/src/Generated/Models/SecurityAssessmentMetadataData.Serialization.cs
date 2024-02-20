// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecurityAssessmentMetadataData : IUtf8JsonSerializable, IJsonModel<SecurityAssessmentMetadataData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityAssessmentMetadataData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityAssessmentMetadataData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAssessmentMetadataData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(PolicyDefinitionId))
            {
                writer.WritePropertyName("policyDefinitionId"u8);
                writer.WriteStringValue(PolicyDefinitionId);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(RemediationDescription))
            {
                writer.WritePropertyName("remediationDescription"u8);
                writer.WriteStringValue(RemediationDescription);
            }
            if (Optional.IsCollectionDefined(Categories))
            {
                writer.WritePropertyName("categories"u8);
                writer.WriteStartArray();
                foreach (var item in Categories)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Optional.IsDefined(UserImpact))
            {
                writer.WritePropertyName("userImpact"u8);
                writer.WriteStringValue(UserImpact.Value.ToString());
            }
            if (Optional.IsDefined(ImplementationEffort))
            {
                writer.WritePropertyName("implementationEffort"u8);
                writer.WriteStringValue(ImplementationEffort.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Threats))
            {
                writer.WritePropertyName("threats"u8);
                writer.WriteStartArray();
                foreach (var item in Threats)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsPreview))
            {
                writer.WritePropertyName("preview"u8);
                writer.WriteBooleanValue(IsPreview.Value);
            }
            if (Optional.IsDefined(AssessmentType))
            {
                writer.WritePropertyName("assessmentType"u8);
                writer.WriteStringValue(AssessmentType.Value.ToString());
            }
            if (Optional.IsDefined(PartnerData))
            {
                writer.WritePropertyName("partnerData"u8);
                writer.WriteObjectValue(PartnerData);
            }
            if (Optional.IsDefined(PublishDates))
            {
                writer.WritePropertyName("publishDates"u8);
                writer.WriteObjectValue(PublishDates);
            }
            if (Optional.IsDefined(PlannedDeprecationDate))
            {
                writer.WritePropertyName("plannedDeprecationDate"u8);
                writer.WriteStringValue(PlannedDeprecationDate);
            }
            if (Optional.IsCollectionDefined(Tactics))
            {
                writer.WritePropertyName("tactics"u8);
                writer.WriteStartArray();
                foreach (var item in Tactics)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Techniques))
            {
                writer.WritePropertyName("techniques"u8);
                writer.WriteStartArray();
                foreach (var item in Techniques)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
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

        SecurityAssessmentMetadataData IJsonModel<SecurityAssessmentMetadataData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAssessmentMetadataData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAssessmentMetadataData(document.RootElement, options);
        }

        internal static SecurityAssessmentMetadataData DeserializeSecurityAssessmentMetadataData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<ResourceIdentifier> policyDefinitionId = default;
            Optional<string> description = default;
            Optional<string> remediationDescription = default;
            Optional<IList<SecurityAssessmentResourceCategory>> categories = default;
            Optional<SecurityAssessmentSeverity> severity = default;
            Optional<SecurityAssessmentUserImpact> userImpact = default;
            Optional<ImplementationEffort> implementationEffort = default;
            Optional<IList<SecurityThreat>> threats = default;
            Optional<bool> preview = default;
            Optional<SecurityAssessmentType> assessmentType = default;
            Optional<SecurityAssessmentMetadataPartner> partnerData = default;
            Optional<SecurityAssessmentPublishDates> publishDates = default;
            Optional<string> plannedDeprecationDate = default;
            Optional<IList<SecurityAssessmentTactic>> tactics = default;
            Optional<IList<SecurityAssessmentTechnique>> techniques = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("policyDefinitionId"u8))
                        {
                            DeserializePolicyDefinitionId(property0, ref policyDefinitionId);
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("remediationDescription"u8))
                        {
                            remediationDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("categories"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityAssessmentResourceCategory> array = new List<SecurityAssessmentResourceCategory>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityAssessmentResourceCategory(item.GetString()));
                            }
                            categories = array;
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            severity = new SecurityAssessmentSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("userImpact"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            userImpact = new SecurityAssessmentUserImpact(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("implementationEffort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            implementationEffort = new ImplementationEffort(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("threats"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityThreat> array = new List<SecurityThreat>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityThreat(item.GetString()));
                            }
                            threats = array;
                            continue;
                        }
                        if (property0.NameEquals("preview"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            preview = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("assessmentType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            assessmentType = new SecurityAssessmentType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("partnerData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerData = SecurityAssessmentMetadataPartner.DeserializeSecurityAssessmentMetadataPartner(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("publishDates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publishDates = SecurityAssessmentPublishDates.DeserializeSecurityAssessmentPublishDates(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("plannedDeprecationDate"u8))
                        {
                            plannedDeprecationDate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tactics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityAssessmentTactic> array = new List<SecurityAssessmentTactic>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityAssessmentTactic(item.GetString()));
                            }
                            tactics = array;
                            continue;
                        }
                        if (property0.NameEquals("techniques"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityAssessmentTechnique> array = new List<SecurityAssessmentTechnique>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityAssessmentTechnique(item.GetString()));
                            }
                            techniques = array;
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
            return new SecurityAssessmentMetadataData(id, name, type, systemData.Value, displayName.Value, policyDefinitionId.Value, description.Value, remediationDescription.Value, Optional.ToList(categories), Optional.ToNullable(severity), Optional.ToNullable(userImpact), Optional.ToNullable(implementationEffort), Optional.ToList(threats), Optional.ToNullable(preview), Optional.ToNullable(assessmentType), partnerData.Value, publishDates.Value, plannedDeprecationDate.Value, Optional.ToList(tactics), Optional.ToList(techniques), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityAssessmentMetadataData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityAssessmentMetadataData)} does not support '{options.Format}' format.");
            }
        }

        SecurityAssessmentMetadataData IPersistableModel<SecurityAssessmentMetadataData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityAssessmentMetadataData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityAssessmentMetadataData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityAssessmentMetadataData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
