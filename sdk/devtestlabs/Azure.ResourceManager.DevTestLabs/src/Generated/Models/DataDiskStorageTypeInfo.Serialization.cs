// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DataDiskStorageTypeInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Lun))
            {
                writer.WritePropertyName("lun");
                writer.WriteStringValue(Lun);
            }
            if (Optional.IsDefined(StorageType))
            {
                writer.WritePropertyName("storageType");
                writer.WriteStringValue(StorageType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static DataDiskStorageTypeInfo DeserializeDataDiskStorageTypeInfo(JsonElement element)
        {
            Optional<string> lun = default;
            Optional<StorageType> storageType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lun"))
                {
                    lun = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageType = new StorageType(property.Value.GetString());
                    continue;
                }
            }
            return new DataDiskStorageTypeInfo(lun.Value, Optional.ToNullable(storageType));
        }
    }
}
