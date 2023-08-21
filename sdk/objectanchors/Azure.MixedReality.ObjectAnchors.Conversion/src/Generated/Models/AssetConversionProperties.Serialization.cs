// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.MixedReality.ObjectAnchors.Conversion.Models;

namespace Azure.MixedReality.ObjectAnchors.Conversion
{
    public partial class AssetConversionProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ConversionStatus))
            {
                writer.WritePropertyName("jobStatus"u8);
                writer.WriteStringValue(ConversionStatus.Value.ToSerialString());
            }
            if (Core.Optional.IsDefined(AssetFileTypeString))
            {
                writer.WritePropertyName("assetFileType"u8);
                writer.WriteStringValue(AssetFileTypeString);
            }
            if (Core.Optional.IsDefined(InputAssetUriString))
            {
                writer.WritePropertyName("inputAssetUri"u8);
                writer.WriteStringValue(InputAssetUriString);
            }
            if (Core.Optional.IsDefined(ConversionConfiguration))
            {
                writer.WritePropertyName("ingestionConfiguration"u8);
                writer.WriteObjectValue(ConversionConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static AssetConversionProperties DeserializeAssetConversionProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> clientErrorDetails = default;
            Core.Optional<string> serverErrorDetails = default;
            Core.Optional<ConversionErrorCode> errorCode = default;
            Core.Optional<Guid> jobId = default;
            Core.Optional<string> outputModelUri = default;
            Core.Optional<AssetConversionStatus> jobStatus = default;
            Core.Optional<string> assetFileType = default;
            Core.Optional<string> inputAssetUri = default;
            Core.Optional<Guid> accountId = default;
            Core.Optional<AssetConversionConfiguration> ingestionConfiguration = default;
            Core.Optional<Vector3> scaledAssetDimensions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientErrorDetails"u8))
                {
                    clientErrorDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverErrorDetails"u8))
                {
                    serverErrorDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorCode = new ConversionErrorCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("outputModelUri"u8))
                {
                    outputModelUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobStatus = property.Value.GetString().ToAssetConversionStatus();
                    continue;
                }
                if (property.NameEquals("assetFileType"u8))
                {
                    assetFileType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputAssetUri"u8))
                {
                    inputAssetUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("ingestionConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingestionConfiguration = AssetConversionConfiguration.DeserializeAssetConversionConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("scaledAssetDimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        scaledAssetDimensions = null;
                        continue;
                    }
                    scaledAssetDimensions = Vector3.DeserializeVector3(property.Value);
                    continue;
                }
            }
            return new AssetConversionProperties(clientErrorDetails.Value, serverErrorDetails.Value, errorCode, Core.Optional.ToNullable(jobId), outputModelUri.Value, Core.Optional.ToNullable(jobStatus), assetFileType.Value, inputAssetUri.Value, Core.Optional.ToNullable(accountId), ingestionConfiguration.Value, scaledAssetDimensions.Value);
        }
    }
}
