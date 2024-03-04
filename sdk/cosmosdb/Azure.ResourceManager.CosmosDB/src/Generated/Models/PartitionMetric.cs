// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The metric values for a single partition. </summary>
    public partial class PartitionMetric : CosmosDBBaseMetric
    {
        /// <summary> Initializes a new instance of <see cref="PartitionMetric"/>. </summary>
        internal PartitionMetric()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PartitionMetric"/>. </summary>
        /// <param name="startOn"> The start time for the metric (ISO-8601 format). </param>
        /// <param name="endOn"> The end time for the metric (ISO-8601 format). </param>
        /// <param name="timeGrain"> The time grain to be used to summarize the metric values. </param>
        /// <param name="unit"> The unit of the metric. </param>
        /// <param name="name"> The name information for the metric. </param>
        /// <param name="metricValues"> The metric values for the specified time window and timestep. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="partitionId"> The partition id (GUID identifier) of the metric values. </param>
        /// <param name="partitionKeyRangeId"> The partition key range id (integer identifier) of the metric values. </param>
        internal PartitionMetric(DateTimeOffset? startOn, DateTimeOffset? endOn, string timeGrain, CosmosDBMetricUnitType? unit, CosmosDBMetricName name, IReadOnlyList<CosmosDBMetricValue> metricValues, IDictionary<string, BinaryData> serializedAdditionalRawData, Guid? partitionId, string partitionKeyRangeId) : base(startOn, endOn, timeGrain, unit, name, metricValues, serializedAdditionalRawData)
        {
            PartitionId = partitionId;
            PartitionKeyRangeId = partitionKeyRangeId;
        }

        /// <summary> The partition id (GUID identifier) of the metric values. </summary>
        [WirePath("partitionId")]
        public Guid? PartitionId { get; }
        /// <summary> The partition key range id (integer identifier) of the metric values. </summary>
        [WirePath("partitionKeyRangeId")]
        public string PartitionKeyRangeId { get; }
    }
}
