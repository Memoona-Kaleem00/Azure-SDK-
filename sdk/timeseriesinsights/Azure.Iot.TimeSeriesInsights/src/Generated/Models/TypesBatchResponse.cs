// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights
{
    /// <summary> Response of a single operation on a batch of time series types. Exactly one of &quot;get&quot;, &quot;put&quot; or &quot;delete&quot; will be set. </summary>
    public partial class TypesBatchResponse
    {
        /// <summary> Initializes a new instance of TypesBatchResponse. </summary>
        internal TypesBatchResponse()
        {
            Get = new ChangeTrackingList<TimeSeriesTypeOrError>();
            Put = new ChangeTrackingList<TimeSeriesTypeOrError>();
            Delete = new ChangeTrackingList<InstancesOperationError>();
        }

        /// <summary> Initializes a new instance of TypesBatchResponse. </summary>
        /// <param name="get"> List of types or error objects corresponding by position to the &quot;get&quot; array in the request. Type object is set when operation is successful and error object is set when operation is unsuccessful. </param>
        /// <param name="put"> List of types or error objects corresponding by position to the &quot;put&quot; array in the request. Type object is set when operation is successful and error object is set when operation is unsuccessful. </param>
        /// <param name="delete"> List of error objects corresponding by position to the &quot;delete&quot; array in the request - null when the operation is successful. </param>
        internal TypesBatchResponse(IReadOnlyList<TimeSeriesTypeOrError> @get, IReadOnlyList<TimeSeriesTypeOrError> put, IReadOnlyList<InstancesOperationError> delete)
        {
            Get = @get;
            Put = put;
            Delete = delete;
        }

        /// <summary> List of types or error objects corresponding by position to the &quot;get&quot; array in the request. Type object is set when operation is successful and error object is set when operation is unsuccessful. </summary>
        public IReadOnlyList<TimeSeriesTypeOrError> Get { get; }
        /// <summary> List of types or error objects corresponding by position to the &quot;put&quot; array in the request. Type object is set when operation is successful and error object is set when operation is unsuccessful. </summary>
        public IReadOnlyList<TimeSeriesTypeOrError> Put { get; }
        /// <summary> List of error objects corresponding by position to the &quot;delete&quot; array in the request - null when the operation is successful. </summary>
        public IReadOnlyList<InstancesOperationError> Delete { get; }
    }
}
