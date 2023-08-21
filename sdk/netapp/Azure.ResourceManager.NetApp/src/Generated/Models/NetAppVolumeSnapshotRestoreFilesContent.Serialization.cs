// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeSnapshotRestoreFilesContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("filePaths"u8);
            writer.WriteStartArray();
            foreach (var item in FilePaths)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Core.Optional.IsDefined(DestinationPath))
            {
                writer.WritePropertyName("destinationPath"u8);
                writer.WriteStringValue(DestinationPath);
            }
            writer.WriteEndObject();
        }
    }
}
