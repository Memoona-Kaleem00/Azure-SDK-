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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class PermissionsResourceProviderItem : IUtf8JsonSerializable, IJsonModel<PermissionsResourceProviderItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PermissionsResourceProviderItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PermissionsResourceProviderItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PermissionsResourceProviderItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PermissionsResourceProviderItem)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Provider))
            {
                writer.WritePropertyName("provider"u8);
                writer.WriteStringValue(Provider.Value.ToString());
            }
            if (Optional.IsDefined(PermissionsDisplayText))
            {
                writer.WritePropertyName("permissionsDisplayText"u8);
                writer.WriteStringValue(PermissionsDisplayText);
            }
            if (Optional.IsDefined(ProviderDisplayName))
            {
                writer.WritePropertyName("providerDisplayName"u8);
                writer.WriteStringValue(ProviderDisplayName);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope.Value.ToString());
            }
            if (Optional.IsDefined(RequiredPermissions))
            {
                writer.WritePropertyName("requiredPermissions"u8);
                writer.WriteObjectValue(RequiredPermissions, options);
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

        PermissionsResourceProviderItem IJsonModel<PermissionsResourceProviderItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PermissionsResourceProviderItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PermissionsResourceProviderItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePermissionsResourceProviderItem(document.RootElement, options);
        }

        internal static PermissionsResourceProviderItem DeserializePermissionsResourceProviderItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProviderName? provider = default;
            string permissionsDisplayText = default;
            string providerDisplayName = default;
            PermissionProviderScope? scope = default;
            RequiredPermissions requiredPermissions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provider"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provider = new ProviderName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("permissionsDisplayText"u8))
                {
                    permissionsDisplayText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerDisplayName"u8))
                {
                    providerDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scope = new PermissionProviderScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requiredPermissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requiredPermissions = RequiredPermissions.DeserializeRequiredPermissions(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PermissionsResourceProviderItem(
                provider,
                permissionsDisplayText,
                providerDisplayName,
                scope,
                requiredPermissions,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Provider), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  provider: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Provider))
                {
                    builder.Append("  provider: ");
                    builder.AppendLine($"'{Provider.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PermissionsDisplayText), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  permissionsDisplayText: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PermissionsDisplayText))
                {
                    builder.Append("  permissionsDisplayText: ");
                    if (PermissionsDisplayText.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PermissionsDisplayText}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PermissionsDisplayText}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProviderDisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  providerDisplayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProviderDisplayName))
                {
                    builder.Append("  providerDisplayName: ");
                    if (ProviderDisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ProviderDisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ProviderDisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Scope), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scope: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Scope))
                {
                    builder.Append("  scope: ");
                    builder.AppendLine($"'{Scope.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RequiredPermissions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  requiredPermissions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RequiredPermissions))
                {
                    builder.Append("  requiredPermissions: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RequiredPermissions, options, 2, false, "  requiredPermissions: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PermissionsResourceProviderItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PermissionsResourceProviderItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PermissionsResourceProviderItem)} does not support writing '{options.Format}' format.");
            }
        }

        PermissionsResourceProviderItem IPersistableModel<PermissionsResourceProviderItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PermissionsResourceProviderItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePermissionsResourceProviderItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PermissionsResourceProviderItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PermissionsResourceProviderItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
