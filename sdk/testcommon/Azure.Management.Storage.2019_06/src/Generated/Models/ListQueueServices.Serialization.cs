// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class ListQueueServices
    {
        internal static ListQueueServices DeserializeListQueueServices(JsonElement element)
        {
            Optional<IReadOnlyList<QueueServiceProperties>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<QueueServiceProperties> array = new List<QueueServiceProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueueServiceProperties.DeserializeQueueServiceProperties(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ListQueueServices(Optional.ToList(value));
        }
    }
}
