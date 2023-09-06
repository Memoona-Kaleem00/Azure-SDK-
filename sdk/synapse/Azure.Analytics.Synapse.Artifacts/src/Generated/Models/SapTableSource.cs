// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity source for SAP Table source. </summary>
    public partial class SapTableSource : TabularSource
    {
        /// <summary> Initializes a new instance of <see cref="SapTableSource"/>. </summary>
        public SapTableSource()
        {
            Type = "SapTableSource";
        }

        /// <summary> Initializes a new instance of <see cref="SapTableSource"/>. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        /// <param name="rowCount"> The number of rows to be retrieved. Type: integer(or Expression with resultType integer). </param>
        /// <param name="rowSkips"> The number of rows that will be skipped. Type: integer (or Expression with resultType integer). </param>
        /// <param name="rfcTableFields"> The fields of the SAP table that will be retrieved. For example, column0, column1. Type: string (or Expression with resultType string). </param>
        /// <param name="rfcTableOptions"> The options for the filtering of the SAP Table. For example, COLUMN0 EQ SOME VALUE. Type: string (or Expression with resultType string). </param>
        /// <param name="batchSize"> Specifies the maximum number of rows that will be retrieved at a time when retrieving data from SAP Table. Type: integer (or Expression with resultType integer). </param>
        /// <param name="customRfcReadTableFunctionModule"> Specifies the custom RFC function module that will be used to read data from SAP Table. Type: string (or Expression with resultType string). </param>
        /// <param name="sapDataColumnDelimiter"> The single character that will be used as delimiter passed to SAP RFC as well as splitting the output data retrieved. Type: string (or Expression with resultType string). </param>
        /// <param name="partitionOption"> The partition mechanism that will be used for SAP table read in parallel. </param>
        /// <param name="partitionSettings"> The settings that will be leveraged for SAP table source partitioning. </param>
        internal SapTableSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object queryTimeout, object additionalColumns, object rowCount, object rowSkips, object rfcTableFields, object rfcTableOptions, object batchSize, object customRfcReadTableFunctionModule, object sapDataColumnDelimiter, SapTablePartitionOption? partitionOption, SapTablePartitionSettings partitionSettings) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties, queryTimeout, additionalColumns)
        {
            RowCount = rowCount;
            RowSkips = rowSkips;
            RfcTableFields = rfcTableFields;
            RfcTableOptions = rfcTableOptions;
            BatchSize = batchSize;
            CustomRfcReadTableFunctionModule = customRfcReadTableFunctionModule;
            SapDataColumnDelimiter = sapDataColumnDelimiter;
            PartitionOption = partitionOption;
            PartitionSettings = partitionSettings;
            Type = type ?? "SapTableSource";
        }

        /// <summary> The number of rows to be retrieved. Type: integer(or Expression with resultType integer). </summary>
        public object RowCount { get; set; }
        /// <summary> The number of rows that will be skipped. Type: integer (or Expression with resultType integer). </summary>
        public object RowSkips { get; set; }
        /// <summary> The fields of the SAP table that will be retrieved. For example, column0, column1. Type: string (or Expression with resultType string). </summary>
        public object RfcTableFields { get; set; }
        /// <summary> The options for the filtering of the SAP Table. For example, COLUMN0 EQ SOME VALUE. Type: string (or Expression with resultType string). </summary>
        public object RfcTableOptions { get; set; }
        /// <summary> Specifies the maximum number of rows that will be retrieved at a time when retrieving data from SAP Table. Type: integer (or Expression with resultType integer). </summary>
        public object BatchSize { get; set; }
        /// <summary> Specifies the custom RFC function module that will be used to read data from SAP Table. Type: string (or Expression with resultType string). </summary>
        public object CustomRfcReadTableFunctionModule { get; set; }
        /// <summary> The single character that will be used as delimiter passed to SAP RFC as well as splitting the output data retrieved. Type: string (or Expression with resultType string). </summary>
        public object SapDataColumnDelimiter { get; set; }
        /// <summary> The partition mechanism that will be used for SAP table read in parallel. </summary>
        public SapTablePartitionOption? PartitionOption { get; set; }
        /// <summary> The settings that will be leveraged for SAP table source partitioning. </summary>
        public SapTablePartitionSettings PartitionSettings { get; set; }
    }
}
