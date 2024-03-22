// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverResourceProperties : IUtf8JsonSerializable, IJsonModel<MoverResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoverResourceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MoverResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverResourceProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WritePropertyName("sourceId"u8);
            writer.WriteStringValue(SourceId);
            if (options.Format != "W" && Optional.IsDefined(TargetId))
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
            if (Optional.IsDefined(ExistingTargetId))
            {
                if (ExistingTargetId != null)
                {
                    writer.WritePropertyName("existingTargetId"u8);
                    writer.WriteStringValue(ExistingTargetId);
                }
                else
                {
                    writer.WriteNull("existingTargetId");
                }
            }
            if (Optional.IsDefined(ResourceSettings))
            {
                if (ResourceSettings != null)
                {
                    writer.WritePropertyName("resourceSettings"u8);
                    writer.WriteObjectValue<MoverResourceSettings>(ResourceSettings, options);
                }
                else
                {
                    writer.WriteNull("resourceSettings");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(SourceResourceSettings))
            {
                if (SourceResourceSettings != null)
                {
                    writer.WritePropertyName("sourceResourceSettings"u8);
                    writer.WriteObjectValue<MoverResourceSettings>(SourceResourceSettings, options);
                }
                else
                {
                    writer.WriteNull("sourceResourceSettings");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(MoveStatus))
            {
                writer.WritePropertyName("moveStatus"u8);
                writer.WriteObjectValue<MoverResourcePropertiesMoveStatus>(MoveStatus, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue<MoverResourceDependency>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DependsOnOverrides))
            {
                writer.WritePropertyName("dependsOnOverrides"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOnOverrides)
                {
                    writer.WriteObjectValue<MoverResourceDependencyOverride>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(IsResolveRequired))
            {
                writer.WritePropertyName("isResolveRequired"u8);
                writer.WriteBooleanValue(IsResolveRequired.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Errors))
            {
                if (Errors != null)
                {
                    writer.WritePropertyName("errors"u8);
                    writer.WriteObjectValue<MoveResourcePropertiesErrors>(Errors, options);
                }
                else
                {
                    writer.WriteNull("errors");
                }
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

        MoverResourceProperties IJsonModel<MoverResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverResourceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverResourceProperties(document.RootElement, options);
        }

        internal static MoverResourceProperties DeserializeMoverResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MoverProvisioningState? provisioningState = default;
            ResourceIdentifier sourceId = default;
            ResourceIdentifier targetId = default;
            ResourceIdentifier existingTargetId = default;
            MoverResourceSettings resourceSettings = default;
            MoverResourceSettings sourceResourceSettings = default;
            MoverResourcePropertiesMoveStatus moveStatus = default;
            IReadOnlyList<MoverResourceDependency> dependsOn = default;
            IList<MoverResourceDependencyOverride> dependsOnOverrides = default;
            bool? isResolveRequired = default;
            MoveResourcePropertiesErrors errors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MoverProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceId"u8))
                {
                    sourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetId = null;
                        continue;
                    }
                    targetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("existingTargetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        existingTargetId = null;
                        continue;
                    }
                    existingTargetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceSettings = null;
                        continue;
                    }
                    resourceSettings = MoverResourceSettings.DeserializeMoverResourceSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sourceResourceSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sourceResourceSettings = null;
                        continue;
                    }
                    sourceResourceSettings = MoverResourceSettings.DeserializeMoverResourceSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("moveStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    moveStatus = MoverResourcePropertiesMoveStatus.DeserializeMoverResourcePropertiesMoveStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MoverResourceDependency> array = new List<MoverResourceDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MoverResourceDependency.DeserializeMoverResourceDependency(item, options));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("dependsOnOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MoverResourceDependencyOverride> array = new List<MoverResourceDependencyOverride>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MoverResourceDependencyOverride.DeserializeMoverResourceDependencyOverride(item, options));
                    }
                    dependsOnOverrides = array;
                    continue;
                }
                if (property.NameEquals("isResolveRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isResolveRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errors = null;
                        continue;
                    }
                    errors = MoveResourcePropertiesErrors.DeserializeMoveResourcePropertiesErrors(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MoverResourceProperties(
                provisioningState,
                sourceId,
                targetId,
                existingTargetId,
                resourceSettings,
                sourceResourceSettings,
                moveStatus,
                dependsOn ?? new ChangeTrackingList<MoverResourceDependency>(),
                dependsOnOverrides ?? new ChangeTrackingList<MoverResourceDependencyOverride>(),
                isResolveRequired,
                errors,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MoverResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MoverResourceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MoverResourceProperties IPersistableModel<MoverResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMoverResourceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MoverResourceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MoverResourceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
