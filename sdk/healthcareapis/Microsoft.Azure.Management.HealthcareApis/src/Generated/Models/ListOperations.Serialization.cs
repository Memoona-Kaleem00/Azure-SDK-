// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    public partial class ListOperations
    {
        internal static ListOperations DeserializeListOperations(JsonElement element)
        {
            Optional<IReadOnlyList<OperationDetail>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<OperationDetail> array = new List<OperationDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationDetail.DeserializeOperationDetail(item));
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
            return new ListOperations(Optional.ToList(value), nextLink.Value);
        }
    }
}
