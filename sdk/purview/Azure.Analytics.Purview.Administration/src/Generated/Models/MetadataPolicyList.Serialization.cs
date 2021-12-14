// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Administration.Models
{
    internal partial class MetadataPolicyList
    {
        internal static MetadataPolicyList DeserializeMetadataPolicyList(JsonElement element)
        {
            IReadOnlyList<MetadataPolicy> values = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("values"))
                {
                    List<MetadataPolicy> array = new List<MetadataPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetadataPolicy.DeserializeMetadataPolicy(item));
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new MetadataPolicyList(values, nextLink.Value);
        }
    }
}
