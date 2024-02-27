// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class IntegrationRuntimeSsisProperties : IUtf8JsonSerializable, IJsonModel<IntegrationRuntimeSsisProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationRuntimeSsisProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IntegrationRuntimeSsisProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeSsisProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeSsisProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (CatalogInfo != null)
            {
                writer.WritePropertyName("catalogInfo"u8);
                writer.WriteObjectValue(CatalogInfo);
            }
            if (LicenseType.HasValue)
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (CustomSetupScriptProperties != null)
            {
                writer.WritePropertyName("customSetupScriptProperties"u8);
                writer.WriteObjectValue(CustomSetupScriptProperties);
            }
            if (DataProxyProperties != null)
            {
                writer.WritePropertyName("dataProxyProperties"u8);
                writer.WriteObjectValue(DataProxyProperties);
            }
            if (Edition.HasValue)
            {
                writer.WritePropertyName("edition"u8);
                writer.WriteStringValue(Edition.Value.ToString());
            }
            if (!(ExpressCustomSetupProperties is ChangeTrackingList<CustomSetupBase> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("expressCustomSetupProperties"u8);
                writer.WriteStartArray();
                foreach (var item in ExpressCustomSetupProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(PackageStores is ChangeTrackingList<DataFactoryPackageStore> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("packageStores"u8);
                writer.WriteStartArray();
                foreach (var item in PackageStores)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Credential != null)
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        IntegrationRuntimeSsisProperties IJsonModel<IntegrationRuntimeSsisProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeSsisProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeSsisProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationRuntimeSsisProperties(document.RootElement, options);
        }

        internal static IntegrationRuntimeSsisProperties DeserializeIntegrationRuntimeSsisProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IntegrationRuntimeSsisCatalogInfo> catalogInfo = default;
            Optional<IntegrationRuntimeLicenseType> licenseType = default;
            Optional<IntegrationRuntimeCustomSetupScriptProperties> customSetupScriptProperties = default;
            Optional<IntegrationRuntimeDataProxyProperties> dataProxyProperties = default;
            Optional<IntegrationRuntimeEdition> edition = default;
            IList<CustomSetupBase> expressCustomSetupProperties = default;
            IList<DataFactoryPackageStore> packageStores = default;
            Optional<DataFactoryCredentialReference> credential = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalogInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catalogInfo = IntegrationRuntimeSsisCatalogInfo.DeserializeIntegrationRuntimeSsisCatalogInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseType = new IntegrationRuntimeLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customSetupScriptProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customSetupScriptProperties = IntegrationRuntimeCustomSetupScriptProperties.DeserializeIntegrationRuntimeCustomSetupScriptProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataProxyProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataProxyProperties = IntegrationRuntimeDataProxyProperties.DeserializeIntegrationRuntimeDataProxyProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("edition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    edition = new IntegrationRuntimeEdition(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expressCustomSetupProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomSetupBase> array = new List<CustomSetupBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomSetupBase.DeserializeCustomSetupBase(item, options));
                    }
                    expressCustomSetupProperties = array;
                    continue;
                }
                if (property.NameEquals("packageStores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFactoryPackageStore> array = new List<DataFactoryPackageStore>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFactoryPackageStore.DeserializeDataFactoryPackageStore(item, options));
                    }
                    packageStores = array;
                    continue;
                }
                if (property.NameEquals("credential"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credential = DataFactoryCredentialReference.DeserializeDataFactoryCredentialReference(property.Value, options);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeSsisProperties(
                catalogInfo.Value,
                Optional.ToNullable(licenseType),
                customSetupScriptProperties.Value,
                dataProxyProperties.Value,
                Optional.ToNullable(edition),
                expressCustomSetupProperties ?? new ChangeTrackingList<CustomSetupBase>(),
                packageStores ?? new ChangeTrackingList<DataFactoryPackageStore>(),
                credential.Value,
                additionalProperties);
        }

        BinaryData IPersistableModel<IntegrationRuntimeSsisProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeSsisProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeSsisProperties)} does not support '{options.Format}' format.");
            }
        }

        IntegrationRuntimeSsisProperties IPersistableModel<IntegrationRuntimeSsisProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeSsisProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationRuntimeSsisProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeSsisProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationRuntimeSsisProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
