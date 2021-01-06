// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Monitoring.Models
{
    public partial class SqlQueryStringDataModel
    {
        internal static SqlQueryStringDataModel DeserializeSqlQueryStringDataModel(JsonElement element)
        {
            Optional<string> query = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"))
                {
                    query = property.Value.GetString();
                    continue;
                }
            }
            return new SqlQueryStringDataModel(query.Value);
        }
    }
}
