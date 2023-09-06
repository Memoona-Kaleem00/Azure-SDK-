// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Netezza source. </summary>
    public partial class NetezzaSource : TabularSource
    {
        /// <summary> Initializes a new instance of <see cref="NetezzaSource"/>. </summary>
        public NetezzaSource()
        {
            Type = "NetezzaSource";
        }

        /// <summary> Initializes a new instance of <see cref="NetezzaSource"/>. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        /// <param name="query"> A query to retrieve data from source. Type: string (or Expression with resultType string). </param>
        /// <param name="partitionOption"> The partition mechanism that will be used for Netezza read in parallel. </param>
        /// <param name="partitionSettings"> The settings that will be leveraged for Netezza source partitioning. </param>
        internal NetezzaSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object queryTimeout, object additionalColumns, object query, NetezzaPartitionOption? partitionOption, NetezzaPartitionSettings partitionSettings) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties, queryTimeout, additionalColumns)
        {
            Query = query;
            PartitionOption = partitionOption;
            PartitionSettings = partitionSettings;
            Type = type ?? "NetezzaSource";
        }

        /// <summary> A query to retrieve data from source. Type: string (or Expression with resultType string). </summary>
        public object Query { get; set; }
        /// <summary> The partition mechanism that will be used for Netezza read in parallel. </summary>
        public NetezzaPartitionOption? PartitionOption { get; set; }
        /// <summary> The settings that will be leveraged for Netezza source partitioning. </summary>
        public NetezzaPartitionSettings PartitionSettings { get; set; }
    }
}
