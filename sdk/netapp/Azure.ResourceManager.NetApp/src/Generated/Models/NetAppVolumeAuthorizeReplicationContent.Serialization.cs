// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeAuthorizeReplicationContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(RemoteVolumeResourceId))
            {
                writer.WritePropertyName("remoteVolumeResourceId"u8);
                writer.WriteStringValue(RemoteVolumeResourceId);
            }
            writer.WriteEndObject();
        }
    }
}
