// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class HealthcareEntityLink
    {
        internal static HealthcareEntityLink DeserializeHealthcareEntityLink(JsonElement element)
        {
            string dataSource = default;
            string id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSource"))
                {
                    dataSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new HealthcareEntityLink(dataSource, id);
        }
    }
}
