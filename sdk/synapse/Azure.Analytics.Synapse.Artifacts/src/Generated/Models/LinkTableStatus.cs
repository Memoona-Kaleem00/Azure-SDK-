// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkTableStatus. </summary>
    public partial class LinkTableStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LinkTableStatus"/>. </summary>
        internal LinkTableStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinkTableStatus"/>. </summary>
        /// <param name="id"> ID provided by the client. </param>
        /// <param name="status"> Link table status, please refer to this [articles](https://learn.microsoft.com/azure/synapse-analytics/synapse-link/sql-database-synapse-link#monitoring) for details. </param>
        /// <param name="errorMessage"> Link table error message. </param>
        /// <param name="startTime"> Link table start time. </param>
        /// <param name="stopTime"> Link table stop time. </param>
        /// <param name="linkTableId"> Link table ID. </param>
        /// <param name="errorCode"> Link table error code. </param>
        /// <param name="lastProcessedData"> Link table last processed data time. </param>
        /// <param name="lastTransactionCommitTime"> Link table last transaction commit time. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LinkTableStatus(string id, string status, string errorMessage, object startTime, object stopTime, string linkTableId, string errorCode, DateTimeOffset? lastProcessedData, DateTimeOffset? lastTransactionCommitTime, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Status = status;
            ErrorMessage = errorMessage;
            StartTime = startTime;
            StopTime = stopTime;
            LinkTableId = linkTableId;
            ErrorCode = errorCode;
            LastProcessedData = lastProcessedData;
            LastTransactionCommitTime = lastTransactionCommitTime;
            _rawData = rawData;
        }

        /// <summary> ID provided by the client. </summary>
        public string Id { get; }
        /// <summary> Link table status, please refer to this [articles](https://learn.microsoft.com/azure/synapse-analytics/synapse-link/sql-database-synapse-link#monitoring) for details. </summary>
        public string Status { get; }
        /// <summary> Link table error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> Link table start time. </summary>
        public object StartTime { get; }
        /// <summary> Link table stop time. </summary>
        public object StopTime { get; }
        /// <summary> Link table ID. </summary>
        public string LinkTableId { get; }
        /// <summary> Link table error code. </summary>
        public string ErrorCode { get; }
        /// <summary> Link table last processed data time. </summary>
        public DateTimeOffset? LastProcessedData { get; }
        /// <summary> Link table last transaction commit time. </summary>
        public DateTimeOffset? LastTransactionCommitTime { get; }
    }
}
