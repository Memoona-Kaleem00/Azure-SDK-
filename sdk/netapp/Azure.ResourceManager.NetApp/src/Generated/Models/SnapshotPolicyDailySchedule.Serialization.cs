// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class SnapshotPolicyDailySchedule : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(SnapshotsToKeep))
            {
                writer.WritePropertyName("snapshotsToKeep"u8);
                writer.WriteNumberValue(SnapshotsToKeep.Value);
            }
            if (Core.Optional.IsDefined(Hour))
            {
                writer.WritePropertyName("hour"u8);
                writer.WriteNumberValue(Hour.Value);
            }
            if (Core.Optional.IsDefined(Minute))
            {
                writer.WritePropertyName("minute"u8);
                writer.WriteNumberValue(Minute.Value);
            }
            if (Core.Optional.IsDefined(UsedBytes))
            {
                writer.WritePropertyName("usedBytes"u8);
                writer.WriteNumberValue(UsedBytes.Value);
            }
            writer.WriteEndObject();
        }

        internal static SnapshotPolicyDailySchedule DeserializeSnapshotPolicyDailySchedule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<int> snapshotsToKeep = default;
            Core.Optional<int> hour = default;
            Core.Optional<int> minute = default;
            Core.Optional<long> usedBytes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("snapshotsToKeep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snapshotsToKeep = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hour"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hour = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minute = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("usedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usedBytes = property.Value.GetInt64();
                    continue;
                }
            }
            return new SnapshotPolicyDailySchedule(Core.Optional.ToNullable(snapshotsToKeep), Core.Optional.ToNullable(hour), Core.Optional.ToNullable(minute), Core.Optional.ToNullable(usedBytes));
        }
    }
}
