// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecurityCenterApiCollectionData : IUtf8JsonSerializable, IJsonModel<SecurityCenterApiCollectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityCenterApiCollectionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityCenterApiCollectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterApiCollectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityCenterApiCollectionData)} does not support '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(DiscoveredVia))
            {
                writer.WritePropertyName("discoveredVia"u8);
                writer.WriteStringValue(DiscoveredVia);
            }
            if (options.Format != "W" && Optional.IsDefined(BaseUri))
            {
                writer.WritePropertyName("baseUrl"u8);
                writer.WriteStringValue(BaseUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfApiEndpoints))
            {
                writer.WritePropertyName("numberOfApiEndpoints"u8);
                writer.WriteNumberValue(NumberOfApiEndpoints.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfInactiveApiEndpoints))
            {
                writer.WritePropertyName("numberOfInactiveApiEndpoints"u8);
                writer.WriteNumberValue(NumberOfInactiveApiEndpoints.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfUnauthenticatedApiEndpoints))
            {
                writer.WritePropertyName("numberOfUnauthenticatedApiEndpoints"u8);
                writer.WriteNumberValue(NumberOfUnauthenticatedApiEndpoints.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfExternalApiEndpoints))
            {
                writer.WritePropertyName("numberOfExternalApiEndpoints"u8);
                writer.WriteNumberValue(NumberOfExternalApiEndpoints.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfApiEndpointsWithSensitiveDataExposed))
            {
                writer.WritePropertyName("numberOfApiEndpointsWithSensitiveDataExposed"u8);
                writer.WriteNumberValue(NumberOfApiEndpointsWithSensitiveDataExposed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SensitivityLabel))
            {
                writer.WritePropertyName("sensitivityLabel"u8);
                writer.WriteStringValue(SensitivityLabel);
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

        SecurityCenterApiCollectionData IJsonModel<SecurityCenterApiCollectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterApiCollectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityCenterApiCollectionData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityCenterApiCollectionData(document.RootElement, options);
        }

        internal static SecurityCenterApiCollectionData DeserializeSecurityCenterApiCollectionData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<SecurityFamilyProvisioningState> provisioningState = default;
            Optional<string> displayName = default;
            Optional<ResourceIdentifier> discoveredVia = default;
            Optional<Uri> baseUrl = default;
            Optional<long> numberOfApiEndpoints = default;
            Optional<long> numberOfInactiveApiEndpoints = default;
            Optional<long> numberOfUnauthenticatedApiEndpoints = default;
            Optional<long> numberOfExternalApiEndpoints = default;
            Optional<long> numberOfApiEndpointsWithSensitiveDataExposed = default;
            Optional<string> sensitivityLabel = default;
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new SecurityFamilyProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("discoveredVia"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            discoveredVia = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("baseUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            baseUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("numberOfApiEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfApiEndpoints = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfInactiveApiEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfInactiveApiEndpoints = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfUnauthenticatedApiEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfUnauthenticatedApiEndpoints = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfExternalApiEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfExternalApiEndpoints = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfApiEndpointsWithSensitiveDataExposed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfApiEndpointsWithSensitiveDataExposed = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("sensitivityLabel"u8))
                        {
                            sensitivityLabel = property0.Value.GetString();
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
            return new SecurityCenterApiCollectionData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), displayName.Value, discoveredVia.Value, baseUrl.Value, Optional.ToNullable(numberOfApiEndpoints), Optional.ToNullable(numberOfInactiveApiEndpoints), Optional.ToNullable(numberOfUnauthenticatedApiEndpoints), Optional.ToNullable(numberOfExternalApiEndpoints), Optional.ToNullable(numberOfApiEndpointsWithSensitiveDataExposed), sensitivityLabel.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                if (Name.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Name}'''");
                }
                else
                {
                    builder.AppendLine($" '{Name}'");
                }
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("    provisioningState:");
                builder.AppendLine($" '{ProvisioningState.Value.ToString()}'");
            }

            if (Optional.IsDefined(DisplayName))
            {
                builder.Append("    displayName:");
                if (DisplayName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{DisplayName}'''");
                }
                else
                {
                    builder.AppendLine($" '{DisplayName}'");
                }
            }

            if (Optional.IsDefined(DiscoveredVia))
            {
                builder.Append("    discoveredVia:");
                builder.AppendLine($" '{DiscoveredVia.ToString()}'");
            }

            if (Optional.IsDefined(BaseUri))
            {
                builder.Append("    baseUrl:");
                builder.AppendLine($" '{BaseUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(NumberOfApiEndpoints))
            {
                builder.Append("    numberOfApiEndpoints:");
                builder.AppendLine($" '{NumberOfApiEndpoints.Value.ToString()}'");
            }

            if (Optional.IsDefined(NumberOfInactiveApiEndpoints))
            {
                builder.Append("    numberOfInactiveApiEndpoints:");
                builder.AppendLine($" '{NumberOfInactiveApiEndpoints.Value.ToString()}'");
            }

            if (Optional.IsDefined(NumberOfUnauthenticatedApiEndpoints))
            {
                builder.Append("    numberOfUnauthenticatedApiEndpoints:");
                builder.AppendLine($" '{NumberOfUnauthenticatedApiEndpoints.Value.ToString()}'");
            }

            if (Optional.IsDefined(NumberOfExternalApiEndpoints))
            {
                builder.Append("    numberOfExternalApiEndpoints:");
                builder.AppendLine($" '{NumberOfExternalApiEndpoints.Value.ToString()}'");
            }

            if (Optional.IsDefined(NumberOfApiEndpointsWithSensitiveDataExposed))
            {
                builder.Append("    numberOfApiEndpointsWithSensitiveDataExposed:");
                builder.AppendLine($" '{NumberOfApiEndpointsWithSensitiveDataExposed.Value.ToString()}'");
            }

            if (Optional.IsDefined(SensitivityLabel))
            {
                builder.Append("    sensitivityLabel:");
                if (SensitivityLabel.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{SensitivityLabel}'''");
                }
                else
                {
                    builder.AppendLine($" '{SensitivityLabel}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            bool inMultilineString = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<SecurityCenterApiCollectionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterApiCollectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityCenterApiCollectionData)} does not support '{options.Format}' format.");
            }
        }

        SecurityCenterApiCollectionData IPersistableModel<SecurityCenterApiCollectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterApiCollectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityCenterApiCollectionData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SecurityCenterApiCollectionData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityCenterApiCollectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
