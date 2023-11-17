// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// A copy activity source.
    /// Please note <see cref="CopyActivitySource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AmazonMwsSource"/>, <see cref="AmazonRdsForOracleSource"/>, <see cref="AmazonRdsForSqlServerSource"/>, <see cref="AmazonRedshiftSource"/>, <see cref="AvroSource"/>, <see cref="AzureBlobFSSource"/>, <see cref="AzureDataExplorerSource"/>, <see cref="AzureDataLakeStoreSource"/>, <see cref="AzureDatabricksDeltaLakeSource"/>, <see cref="AzureMariaDBSource"/>, <see cref="AzureMySqlSource"/>, <see cref="AzurePostgreSqlSource"/>, <see cref="AzureSqlSource"/>, <see cref="AzureTableSource"/>, <see cref="BinarySource"/>, <see cref="DataFactoryBlobSource"/>, <see cref="CassandraSource"/>, <see cref="CommonDataServiceForAppsSource"/>, <see cref="ConcurSource"/>, <see cref="CosmosDBMongoDBApiSource"/>, <see cref="CosmosDBSqlApiSource"/>, <see cref="CouchbaseSource"/>, <see cref="Db2Source"/>, <see cref="DelimitedTextSource"/>, <see cref="DocumentDBCollectionSource"/>, <see cref="DrillSource"/>, <see cref="DynamicsAXSource"/>, <see cref="DynamicsCrmSource"/>, <see cref="DynamicsSource"/>, <see cref="EloquaSource"/>, <see cref="ExcelSource"/>, <see cref="FileSystemSource"/>, <see cref="GoogleAdWordsSource"/>, <see cref="GoogleBigQuerySource"/>, <see cref="GreenplumSource"/>, <see cref="HBaseSource"/>, <see cref="HdfsSource"/>, <see cref="HiveSource"/>, <see cref="DataFactoryHttpFileSource"/>, <see cref="HubspotSource"/>, <see cref="ImpalaSource"/>, <see cref="InformixSource"/>, <see cref="JiraSource"/>, <see cref="JsonSource"/>, <see cref="LakeHouseTableSource"/>, <see cref="MagentoSource"/>, <see cref="MariaDBSource"/>, <see cref="MarketoSource"/>, <see cref="MicrosoftAccessSource"/>, <see cref="MongoDBAtlasSource"/>, <see cref="MongoDBSource"/>, <see cref="MongoDBV2Source"/>, <see cref="MySqlSource"/>, <see cref="NetezzaSource"/>, <see cref="ODataSource"/>, <see cref="OdbcSource"/>, <see cref="Office365Source"/>, <see cref="OracleServiceCloudSource"/>, <see cref="OracleSource"/>, <see cref="OrcSource"/>, <see cref="ParquetSource"/>, <see cref="PaypalSource"/>, <see cref="PhoenixSource"/>, <see cref="PostgreSqlSource"/>, <see cref="PrestoSource"/>, <see cref="QuickBooksSource"/>, <see cref="RelationalSource"/>, <see cref="ResponsysSource"/>, <see cref="RestSource"/>, <see cref="SalesforceMarketingCloudSource"/>, <see cref="SalesforceServiceCloudSource"/>, <see cref="SalesforceSource"/>, <see cref="SapBWSource"/>, <see cref="SapCloudForCustomerSource"/>, <see cref="SapEccSource"/>, <see cref="SapHanaSource"/>, <see cref="SapOdpSource"/>, <see cref="SapOpenHubSource"/>, <see cref="SapTableSource"/>, <see cref="ServiceNowSource"/>, <see cref="SharePointOnlineListSource"/>, <see cref="ShopifySource"/>, <see cref="SnowflakeSource"/>, <see cref="SparkSource"/>, <see cref="SqlDWSource"/>, <see cref="SqlMISource"/>, <see cref="SqlServerSource"/>, <see cref="SqlSource"/>, <see cref="SquareSource"/>, <see cref="SybaseSource"/>, <see cref="TabularSource"/>, <see cref="TeradataSource"/>, <see cref="VerticaSource"/>, <see cref="WebSource"/>, <see cref="XeroSource"/>, <see cref="XmlSource"/> and <see cref="ZohoSource"/>.
    /// </summary>
    public partial class CopyActivitySource
    {
        /// <summary> Initializes a new instance of CopyActivitySource. </summary>
        public CopyActivitySource()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of CopyActivitySource. </summary>
        /// <param name="copySourceType"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal CopyActivitySource(string copySourceType, DataFactoryElement<int> sourceRetryCount, DataFactoryElement<string> sourceRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties)
        {
            CopySourceType = copySourceType;
            SourceRetryCount = sourceRetryCount;
            SourceRetryWait = sourceRetryWait;
            MaxConcurrentConnections = maxConcurrentConnections;
            DisableMetricsCollection = disableMetricsCollection;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Copy source type. </summary>
        internal string CopySourceType { get; set; }
        /// <summary> Source retry count. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> SourceRetryCount { get; set; }
        /// <summary> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public DataFactoryElement<string> SourceRetryWait { get; set; }
        /// <summary> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> MaxConcurrentConnections { get; set; }
        /// <summary> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> DisableMetricsCollection { get; set; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
