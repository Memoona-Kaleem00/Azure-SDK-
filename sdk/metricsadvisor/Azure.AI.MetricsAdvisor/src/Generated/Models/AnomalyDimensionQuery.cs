// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.MetricsAdvisor;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AnomalyDimensionQuery. </summary>
    internal partial class AnomalyDimensionQuery
    {
        /// <summary> Initializes a new instance of <see cref="AnomalyDimensionQuery"/>. </summary>
        /// <param name="startTime"> start time. </param>
        /// <param name="endTime"> end time. </param>
        /// <param name="dimensionName"> dimension to query. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dimensionName"/> is null. </exception>
        public AnomalyDimensionQuery(DateTimeOffset startTime, DateTimeOffset endTime, string dimensionName)
        {
            Argument.AssertNotNull(dimensionName, nameof(dimensionName));

            StartTime = startTime;
            EndTime = endTime;
            DimensionName = dimensionName;
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDimensionQuery"/>. </summary>
        /// <param name="startTime"> start time. </param>
        /// <param name="endTime"> end time. </param>
        /// <param name="dimensionName"> dimension to query. </param>
        /// <param name="dimensionFilter"></param>
        internal AnomalyDimensionQuery(DateTimeOffset startTime, DateTimeOffset endTime, string dimensionName, DimensionKey dimensionFilter)
        {
            StartTime = startTime;
            EndTime = endTime;
            DimensionName = dimensionName;
            DimensionFilter = dimensionFilter;
        }

        /// <summary> start time. </summary>
        public DateTimeOffset StartTime { get; }
        /// <summary> end time. </summary>
        public DateTimeOffset EndTime { get; }
        /// <summary> dimension to query. </summary>
        public string DimensionName { get; }
        /// <summary> Gets or sets the dimension filter. </summary>
        public DimensionKey DimensionFilter { get; set; }
    }
}
