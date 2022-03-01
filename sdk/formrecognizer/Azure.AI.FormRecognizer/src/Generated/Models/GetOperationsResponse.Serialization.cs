// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    internal partial class GetOperationsResponse
    {
        internal static GetOperationsResponse DeserializeGetOperationsResponse(JsonElement element)
        {
            IReadOnlyList<ModelOperationInfo> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ModelOperationInfo> array = new List<ModelOperationInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelOperationInfo.DeserializeModelOperationInfo(item));
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
            return new GetOperationsResponse(value, nextLink.Value);
        }
    }
}
