// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeBackupBackupRestoreFilesContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("fileList"u8);
            writer.WriteStartArray();
            foreach (var item in FileList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Core.Optional.IsDefined(RestoreFilePath))
            {
                writer.WritePropertyName("restoreFilePath"u8);
                writer.WriteStringValue(RestoreFilePath);
            }
            writer.WritePropertyName("destinationVolumeId"u8);
            writer.WriteStringValue(DestinationVolumeId);
            writer.WriteEndObject();
        }
    }
}
