// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.GeoJson;

namespace Azure.Maps.Weather.Models
{
    /// <summary> Forecast window for the storm. </summary>
    public partial class WeatherWindow
    {
        /// <summary> Initializes a new instance of <see cref="WeatherWindow"/>. </summary>
        internal WeatherWindow()
        {
        }

        /// <summary> Location of the point on the left side of the window at the time of the timeframe. </summary>
        public LatLongPair TopLeft { get; }
        /// <summary> Location of the point on the right side of the window at the end of the timeframe. </summary>
        public LatLongPair BottomRight { get; }
        /// <summary> DateTime of the beginning of the window of movement, displayed in ISO8601 format. </summary>
        public DateTimeOffset? BeginTimestamp { get; }
        /// <summary> DateTime of the end of the window of movement, displayed in ISO8601 format. </summary>
        public DateTimeOffset? EndTimestamp { get; }
        /// <summary> Storm status at the beginning of the window. </summary>
        public string BeginStatus { get; }
        /// <summary> Storm status at the end of the window. </summary>
        public string EndStatus { get; }
    }
}
