// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Time series model settings including model name, Time Series ID properties and default type ID. </summary>
    public partial class TimeSeriesModelSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TimeSeriesModelSettings"/>. </summary>
        internal TimeSeriesModelSettings()
        {
            TimeSeriesIdProperties = new ChangeTrackingList<TimeSeriesIdProperty>();
        }

        /// <summary> Initializes a new instance of <see cref="TimeSeriesModelSettings"/>. </summary>
        /// <param name="name"> Time series model display name which is shown in the UX. Examples: "Temperature Sensors", "MyDevices". </param>
        /// <param name="timeSeriesIdProperties"> Time series ID properties defined during environment creation. </param>
        /// <param name="defaultTypeId"> Default type ID of the model that new time series instances will automatically belong to. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TimeSeriesModelSettings(string name, IReadOnlyList<TimeSeriesIdProperty> timeSeriesIdProperties, string defaultTypeId, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            TimeSeriesIdProperties = timeSeriesIdProperties;
            DefaultTypeId = defaultTypeId;
            _rawData = rawData;
        }

        /// <summary> Time series model display name which is shown in the UX. Examples: "Temperature Sensors", "MyDevices". </summary>
        public string Name { get; }
        /// <summary> Time series ID properties defined during environment creation. </summary>
        public IReadOnlyList<TimeSeriesIdProperty> TimeSeriesIdProperties { get; }
        /// <summary> Default type ID of the model that new time series instances will automatically belong to. </summary>
        public string DefaultTypeId { get; }
    }
}
