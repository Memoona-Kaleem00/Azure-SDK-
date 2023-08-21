// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeBreakFileLocksContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ClientIP))
            {
                writer.WritePropertyName("clientIp"u8);
                writer.WriteStringValue(ClientIP.ToString());
            }
            if (Core.Optional.IsDefined(ConfirmRunningDisruptiveOperation))
            {
                writer.WritePropertyName("confirmRunningDisruptiveOperation"u8);
                writer.WriteBooleanValue(ConfirmRunningDisruptiveOperation.Value);
            }
            writer.WriteEndObject();
        }
    }
}
