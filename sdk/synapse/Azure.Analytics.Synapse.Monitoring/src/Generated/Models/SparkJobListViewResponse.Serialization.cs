// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Monitoring.Models
{
    public partial class SparkJobListViewResponse
    {
        internal static SparkJobListViewResponse DeserializeSparkJobListViewResponse(JsonElement element)
        {
            Optional<int> nJobs = default;
            Optional<IReadOnlyList<SparkJob>> sparkJobs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nJobs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nJobs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sparkJobs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SparkJob> array = new List<SparkJob>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SparkJob.DeserializeSparkJob(item));
                    }
                    sparkJobs = array;
                    continue;
                }
            }
            return new SparkJobListViewResponse(Optional.ToNullable(nJobs), Optional.ToList(sparkJobs));
        }
    }
}
