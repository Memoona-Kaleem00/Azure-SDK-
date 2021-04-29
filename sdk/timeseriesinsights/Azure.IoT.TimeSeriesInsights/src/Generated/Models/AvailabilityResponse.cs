// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Response of Get Availability operation. When environment has no data, availability property is null. </summary>
    internal partial class AvailabilityResponse
    {
        /// <summary> Initializes a new instance of AvailabilityResponse. </summary>
        internal AvailabilityResponse()
        {
        }

        /// <summary> Initializes a new instance of AvailabilityResponse. </summary>
        /// <param name="availability"> Event availability information when environment contains events. When environment has no data yet, this property is null or not present. </param>
        internal AvailabilityResponse(Availability availability)
        {
            Availability = availability;
        }

        /// <summary> Event availability information when environment contains events. When environment has no data yet, this property is null or not present. </summary>
        public Availability Availability { get; }
    }
}
