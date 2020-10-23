// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Chat
{
    internal partial class MultiStatusResponse
    {
        internal static MultiStatusResponse DeserializeMultiStatusResponse(JsonElement element)
        {
            Optional<IReadOnlyList<IndividualStatusResponse>> multipleStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("multipleStatus"))
                {
                    List<IndividualStatusResponse> array = new List<IndividualStatusResponse>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IndividualStatusResponse.DeserializeIndividualStatusResponse(item));
                    }
                    multipleStatus = array;
                    continue;
                }
            }
            return new MultiStatusResponse(Optional.ToList(multipleStatus));
        }
    }
}
