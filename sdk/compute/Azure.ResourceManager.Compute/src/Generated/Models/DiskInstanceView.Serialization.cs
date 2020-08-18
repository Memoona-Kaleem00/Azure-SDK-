// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class DiskInstanceView
    {
        internal static DiskInstanceView DeserializeDiskInstanceView(JsonElement element)
        {
            Optional<string> name = default;
            Optional<IReadOnlyList<DiskEncryptionSettings>> encryptionSettings = default;
            Optional<IReadOnlyList<InstanceViewStatus>> statuses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionSettings"))
                {
                    List<DiskEncryptionSettings> array = new List<DiskEncryptionSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiskEncryptionSettings.DeserializeDiskEncryptionSettings(item));
                    }
                    encryptionSettings = array;
                    continue;
                }
                if (property.NameEquals("statuses"))
                {
                    List<InstanceViewStatus> array = new List<InstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstanceViewStatus.DeserializeInstanceViewStatus(item));
                    }
                    statuses = array;
                    continue;
                }
            }
            return new DiskInstanceView(name.Value, Optional.ToList(encryptionSettings), Optional.ToList(statuses));
        }
    }
}
