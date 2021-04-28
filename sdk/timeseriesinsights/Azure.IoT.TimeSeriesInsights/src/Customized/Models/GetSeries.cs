// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary>
    /// Get Series query. Allows to retrieve time series of calculated variable values from events for a given Time Series ID and search span.
    /// </summary>
    [CodeGenModel("GetSeries")]
    [CodeGenSuppress("GetSeries", typeof(IEnumerable<object>), typeof(DateTimeRange))]
    internal partial class GetSeries
    {
        // Autorest does not support changing type for properties. In order to turn TimeSeriesId
        // from a list of objects to a strongly typed object, TimeSeriesId has been renamed to
        // TimeSeriesIdInternal and a new property, TimeSeriesId, has been created with the proper type.

        [CodeGenMember("TimeSeriesId")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "CodeQuality",
            "IDE0051:Remove unused private members",
            Justification = "Autorest does not support changing type for properties. In order to turn TimeSeriesId from" +
            "a list of objects to a strongly typed object, TimeSeriesId has been renamed to TimeSeriesIdInternal and a" +
            "new property, TimeSeriesId, has been created with the proper type.")]
        private IList<object> TimeSeriesIdInternal { get; }

        /// <summary>
        /// Time Series Id that uniquely identifies the instance. It matches Time Series Id properties in an environment.
        /// </summary>
        public TimeSeriesId TimeSeriesId { get; }

        /// <summary>
        /// Initializes a new instance of GetSeries.
        /// </summary>
        /// <param name="timeSeriesId">
        /// Time Series Id that uniquely identifies the instance. It matches Time Series Id properties in
        /// an environment. Immutable, never null.
        /// </param>
        /// <param name="searchSpan">
        /// The range of time on which the query is executed. Cannot be null.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="timeSeriesId"/> or <paramref name="searchSpan"/> is null.
        /// </exception>
        public GetSeries(TimeSeriesId timeSeriesId, DateTimeRange searchSpan)
        {
            TimeSeriesId = timeSeriesId ?? throw new ArgumentNullException(nameof(timeSeriesId));
            SearchSpan = searchSpan ?? throw new ArgumentNullException(nameof(searchSpan));
            ProjectedVariables = new ChangeTrackingList<string>();
            InlineVariables = new ChangeTrackingDictionary<string, TimeSeriesVariable>();
        }
    }
}
