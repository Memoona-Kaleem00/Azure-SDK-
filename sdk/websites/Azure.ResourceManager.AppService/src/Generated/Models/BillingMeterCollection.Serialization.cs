// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class BillingMeterCollection
    {
        internal static BillingMeterCollection DeserializeBillingMeterCollection(JsonElement element)
        {
            IReadOnlyList<BillingMeter> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<BillingMeter> array = new List<BillingMeter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BillingMeter.DeserializeBillingMeter(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new BillingMeterCollection(value, nextLink.Value);
        }
    }
}
