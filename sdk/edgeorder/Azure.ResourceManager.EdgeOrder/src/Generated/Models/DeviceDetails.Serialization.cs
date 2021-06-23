// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class DeviceDetails
    {
        internal static DeviceDetails DeserializeDeviceDetails(JsonElement element)
        {
            Optional<string> serialNumber = default;
            Optional<string> managementResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serialNumber"))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managementResourceId"))
                {
                    managementResourceId = property.Value.GetString();
                    continue;
                }
            }
            return new DeviceDetails(serialNumber.Value, managementResourceId.Value);
        }
    }
}
