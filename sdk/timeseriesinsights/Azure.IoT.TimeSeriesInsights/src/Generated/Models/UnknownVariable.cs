// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> The UnknownVariable. </summary>
    internal partial class UnknownVariable : TimeSeriesVariable
    {
        /// <summary> Initializes a new instance of <see cref="UnknownVariable"/>. </summary>
        /// <param name="kind"> Allowed "kind" values are - "numeric" or "aggregate". While "numeric" allows you to specify value of the reconstructed signal and the expression to aggregate them, the "aggregate" kind lets you directly aggregate on the event properties without specifying value. </param>
        /// <param name="filter"> Filter over the events that restricts the number of events being considered for computation. Example: "$event.Status.String='Good'". Optional. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownVariable(string kind, TimeSeriesExpression filter, Dictionary<string, BinaryData> rawData) : base(kind, filter, rawData)
        {
            Kind = kind ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownVariable"/> for deserialization. </summary>
        internal UnknownVariable()
        {
        }
    }
}
