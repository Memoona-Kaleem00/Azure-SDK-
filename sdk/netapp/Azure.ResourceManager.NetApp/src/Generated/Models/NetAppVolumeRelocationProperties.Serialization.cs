// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeRelocationProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(IsRelocationRequested))
            {
                writer.WritePropertyName("relocationRequested"u8);
                writer.WriteBooleanValue(IsRelocationRequested.Value);
            }
            writer.WriteEndObject();
        }

        internal static NetAppVolumeRelocationProperties DeserializeNetAppVolumeRelocationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> relocationRequested = default;
            Core.Optional<bool> readyToBeFinalized = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relocationRequested"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    relocationRequested = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("readyToBeFinalized"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readyToBeFinalized = property.Value.GetBoolean();
                    continue;
                }
            }
            return new NetAppVolumeRelocationProperties(Core.Optional.ToNullable(relocationRequested), Core.Optional.ToNullable(readyToBeFinalized));
        }
    }
}
