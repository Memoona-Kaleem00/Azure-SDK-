// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// Copy activity.
    /// Serialized Name: CopyActivity
    /// </summary>
    public partial class CopyActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of CopyActivity. </summary>
        /// <param name="name">
        /// Activity name.
        /// Serialized Name: Activity.name
        /// </param>
        /// <param name="source">
        /// Copy activity source.
        /// Serialized Name: CopyActivity.typeProperties.source
        /// Please note <see cref="CopyActivitySource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsSource"/>, <see cref="AmazonRdsForOracleSource"/>, <see cref="AmazonRdsForSqlServerSource"/>, <see cref="AmazonRedshiftSource"/>, <see cref="AvroSource"/>, <see cref="AzureBlobFSSource"/>, <see cref="AzureDataExplorerSource"/>, <see cref="AzureDataLakeStoreSource"/>, <see cref="AzureDatabricksDeltaLakeSource"/>, <see cref="AzureMariaDBSource"/>, <see cref="AzureMySqlSource"/>, <see cref="AzurePostgreSqlSource"/>, <see cref="AzureSqlSource"/>, <see cref="AzureTableSource"/>, <see cref="BinarySource"/>, <see cref="BlobSource"/>, <see cref="CassandraSource"/>, <see cref="CommonDataServiceForAppsSource"/>, <see cref="ConcurSource"/>, <see cref="CosmosDBMongoDBApiSource"/>, <see cref="CosmosDBSqlApiSource"/>, <see cref="CouchbaseSource"/>, <see cref="Db2Source"/>, <see cref="DelimitedTextSource"/>, <see cref="DocumentDBCollectionSource"/>, <see cref="DrillSource"/>, <see cref="DynamicsAXSource"/>, <see cref="DynamicsCrmSource"/>, <see cref="DynamicsSource"/>, <see cref="EloquaSource"/>, <see cref="ExcelSource"/>, <see cref="FileSystemSource"/>, <see cref="GoogleAdWordsSource"/>, <see cref="GoogleBigQuerySource"/>, <see cref="GreenplumSource"/>, <see cref="HBaseSource"/>, <see cref="HdfsSource"/>, <see cref="HiveSource"/>, <see cref="HttpSource"/>, <see cref="HubspotSource"/>, <see cref="ImpalaSource"/>, <see cref="InformixSource"/>, <see cref="JiraSource"/>, <see cref="JsonSource"/>, <see cref="MagentoSource"/>, <see cref="MariaDBSource"/>, <see cref="MarketoSource"/>, <see cref="MicrosoftAccessSource"/>, <see cref="MongoDBAtlasSource"/>, <see cref="MongoDBSource"/>, <see cref="MongoDBV2Source"/>, <see cref="MySqlSource"/>, <see cref="NetezzaSource"/>, <see cref="ODataSource"/>, <see cref="OdbcSource"/>, <see cref="Office365Source"/>, <see cref="OracleServiceCloudSource"/>, <see cref="OracleSource"/>, <see cref="OrcSource"/>, <see cref="ParquetSource"/>, <see cref="PaypalSource"/>, <see cref="PhoenixSource"/>, <see cref="PostgreSqlSource"/>, <see cref="PrestoSource"/>, <see cref="QuickBooksSource"/>, <see cref="RelationalSource"/>, <see cref="ResponsysSource"/>, <see cref="RestSource"/>, <see cref="SalesforceMarketingCloudSource"/>, <see cref="SalesforceServiceCloudSource"/>, <see cref="SalesforceSource"/>, <see cref="SapBwSource"/>, <see cref="SapCloudForCustomerSource"/>, <see cref="SapEccSource"/>, <see cref="SapHanaSource"/>, <see cref="SapOdpSource"/>, <see cref="SapOpenHubSource"/>, <see cref="SapTableSource"/>, <see cref="ServiceNowSource"/>, <see cref="SharePointOnlineListSource"/>, <see cref="ShopifySource"/>, <see cref="SnowflakeSource"/>, <see cref="SparkSource"/>, <see cref="SqlDWSource"/>, <see cref="SqlMISource"/>, <see cref="SqlServerSource"/>, <see cref="SqlSource"/>, <see cref="SquareSource"/>, <see cref="SybaseSource"/>, <see cref="TabularSource"/>, <see cref="TeradataSource"/>, <see cref="VerticaSource"/>, <see cref="WebSource"/>, <see cref="XeroSource"/>, <see cref="XmlSource"/> and <see cref="ZohoSource"/>.
        /// </param>
        /// <param name="sink">
        /// Copy activity sink.
        /// Serialized Name: CopyActivity.typeProperties.sink
        /// Please note <see cref="CopySink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroSink"/>, <see cref="AzureBlobFSSink"/>, <see cref="AzureDataExplorerSink"/>, <see cref="AzureDataLakeStoreSink"/>, <see cref="AzureDatabricksDeltaLakeSink"/>, <see cref="AzureMySqlSink"/>, <see cref="AzurePostgreSqlSink"/>, <see cref="AzureQueueSink"/>, <see cref="AzureSearchIndexSink"/>, <see cref="AzureSqlSink"/>, <see cref="AzureTableSink"/>, <see cref="BinarySink"/>, <see cref="BlobSink"/>, <see cref="CommonDataServiceForAppsSink"/>, <see cref="CosmosDBMongoDBApiSink"/>, <see cref="CosmosDBSqlApiSink"/>, <see cref="DelimitedTextSink"/>, <see cref="DocumentDBCollectionSink"/>, <see cref="DynamicsCrmSink"/>, <see cref="DynamicsSink"/>, <see cref="FileSystemSink"/>, <see cref="InformixSink"/>, <see cref="JsonSink"/>, <see cref="MicrosoftAccessSink"/>, <see cref="MongoDBAtlasSink"/>, <see cref="MongoDBV2Sink"/>, <see cref="OdbcSink"/>, <see cref="OracleSink"/>, <see cref="OrcSink"/>, <see cref="ParquetSink"/>, <see cref="RestSink"/>, <see cref="SalesforceServiceCloudSink"/>, <see cref="SalesforceSink"/>, <see cref="SapCloudForCustomerSink"/>, <see cref="SnowflakeSink"/>, <see cref="SqlDWSink"/>, <see cref="SqlMISink"/>, <see cref="SqlServerSink"/> and <see cref="SqlSink"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="source"/> or <paramref name="sink"/> is null. </exception>
        public CopyActivity(string name, CopyActivitySource source, CopySink sink) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (sink == null)
            {
                throw new ArgumentNullException(nameof(sink));
            }

            Inputs = new ChangeTrackingList<DatasetReference>();
            Outputs = new ChangeTrackingList<DatasetReference>();
            Source = source;
            Sink = sink;
            PreserveRules = new ChangeTrackingList<BinaryData>();
            Preserve = new ChangeTrackingList<BinaryData>();
            ActivityType = "Copy";
        }

        /// <summary> Initializes a new instance of CopyActivity. </summary>
        /// <param name="name">
        /// Activity name.
        /// Serialized Name: Activity.name
        /// </param>
        /// <param name="activityType">
        /// Type of activity.
        /// Serialized Name: Activity.type
        /// </param>
        /// <param name="description">
        /// Activity description.
        /// Serialized Name: Activity.description
        /// </param>
        /// <param name="dependsOn">
        /// Activity depends on condition.
        /// Serialized Name: Activity.dependsOn
        /// </param>
        /// <param name="userProperties">
        /// Activity user properties.
        /// Serialized Name: Activity.userProperties
        /// </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName">
        /// Linked service reference.
        /// Serialized Name: ExecutionActivity.linkedServiceName
        /// </param>
        /// <param name="policy">
        /// Activity policy.
        /// Serialized Name: ExecutionActivity.policy
        /// </param>
        /// <param name="inputs">
        /// List of inputs for the activity.
        /// Serialized Name: CopyActivity.inputs
        /// </param>
        /// <param name="outputs">
        /// List of outputs for the activity.
        /// Serialized Name: CopyActivity.outputs
        /// </param>
        /// <param name="source">
        /// Copy activity source.
        /// Serialized Name: CopyActivity.typeProperties.source
        /// Please note <see cref="CopyActivitySource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsSource"/>, <see cref="AmazonRdsForOracleSource"/>, <see cref="AmazonRdsForSqlServerSource"/>, <see cref="AmazonRedshiftSource"/>, <see cref="AvroSource"/>, <see cref="AzureBlobFSSource"/>, <see cref="AzureDataExplorerSource"/>, <see cref="AzureDataLakeStoreSource"/>, <see cref="AzureDatabricksDeltaLakeSource"/>, <see cref="AzureMariaDBSource"/>, <see cref="AzureMySqlSource"/>, <see cref="AzurePostgreSqlSource"/>, <see cref="AzureSqlSource"/>, <see cref="AzureTableSource"/>, <see cref="BinarySource"/>, <see cref="BlobSource"/>, <see cref="CassandraSource"/>, <see cref="CommonDataServiceForAppsSource"/>, <see cref="ConcurSource"/>, <see cref="CosmosDBMongoDBApiSource"/>, <see cref="CosmosDBSqlApiSource"/>, <see cref="CouchbaseSource"/>, <see cref="Db2Source"/>, <see cref="DelimitedTextSource"/>, <see cref="DocumentDBCollectionSource"/>, <see cref="DrillSource"/>, <see cref="DynamicsAXSource"/>, <see cref="DynamicsCrmSource"/>, <see cref="DynamicsSource"/>, <see cref="EloquaSource"/>, <see cref="ExcelSource"/>, <see cref="FileSystemSource"/>, <see cref="GoogleAdWordsSource"/>, <see cref="GoogleBigQuerySource"/>, <see cref="GreenplumSource"/>, <see cref="HBaseSource"/>, <see cref="HdfsSource"/>, <see cref="HiveSource"/>, <see cref="HttpSource"/>, <see cref="HubspotSource"/>, <see cref="ImpalaSource"/>, <see cref="InformixSource"/>, <see cref="JiraSource"/>, <see cref="JsonSource"/>, <see cref="MagentoSource"/>, <see cref="MariaDBSource"/>, <see cref="MarketoSource"/>, <see cref="MicrosoftAccessSource"/>, <see cref="MongoDBAtlasSource"/>, <see cref="MongoDBSource"/>, <see cref="MongoDBV2Source"/>, <see cref="MySqlSource"/>, <see cref="NetezzaSource"/>, <see cref="ODataSource"/>, <see cref="OdbcSource"/>, <see cref="Office365Source"/>, <see cref="OracleServiceCloudSource"/>, <see cref="OracleSource"/>, <see cref="OrcSource"/>, <see cref="ParquetSource"/>, <see cref="PaypalSource"/>, <see cref="PhoenixSource"/>, <see cref="PostgreSqlSource"/>, <see cref="PrestoSource"/>, <see cref="QuickBooksSource"/>, <see cref="RelationalSource"/>, <see cref="ResponsysSource"/>, <see cref="RestSource"/>, <see cref="SalesforceMarketingCloudSource"/>, <see cref="SalesforceServiceCloudSource"/>, <see cref="SalesforceSource"/>, <see cref="SapBwSource"/>, <see cref="SapCloudForCustomerSource"/>, <see cref="SapEccSource"/>, <see cref="SapHanaSource"/>, <see cref="SapOdpSource"/>, <see cref="SapOpenHubSource"/>, <see cref="SapTableSource"/>, <see cref="ServiceNowSource"/>, <see cref="SharePointOnlineListSource"/>, <see cref="ShopifySource"/>, <see cref="SnowflakeSource"/>, <see cref="SparkSource"/>, <see cref="SqlDWSource"/>, <see cref="SqlMISource"/>, <see cref="SqlServerSource"/>, <see cref="SqlSource"/>, <see cref="SquareSource"/>, <see cref="SybaseSource"/>, <see cref="TabularSource"/>, <see cref="TeradataSource"/>, <see cref="VerticaSource"/>, <see cref="WebSource"/>, <see cref="XeroSource"/>, <see cref="XmlSource"/> and <see cref="ZohoSource"/>.
        /// </param>
        /// <param name="sink">
        /// Copy activity sink.
        /// Serialized Name: CopyActivity.typeProperties.sink
        /// Please note <see cref="CopySink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroSink"/>, <see cref="AzureBlobFSSink"/>, <see cref="AzureDataExplorerSink"/>, <see cref="AzureDataLakeStoreSink"/>, <see cref="AzureDatabricksDeltaLakeSink"/>, <see cref="AzureMySqlSink"/>, <see cref="AzurePostgreSqlSink"/>, <see cref="AzureQueueSink"/>, <see cref="AzureSearchIndexSink"/>, <see cref="AzureSqlSink"/>, <see cref="AzureTableSink"/>, <see cref="BinarySink"/>, <see cref="BlobSink"/>, <see cref="CommonDataServiceForAppsSink"/>, <see cref="CosmosDBMongoDBApiSink"/>, <see cref="CosmosDBSqlApiSink"/>, <see cref="DelimitedTextSink"/>, <see cref="DocumentDBCollectionSink"/>, <see cref="DynamicsCrmSink"/>, <see cref="DynamicsSink"/>, <see cref="FileSystemSink"/>, <see cref="InformixSink"/>, <see cref="JsonSink"/>, <see cref="MicrosoftAccessSink"/>, <see cref="MongoDBAtlasSink"/>, <see cref="MongoDBV2Sink"/>, <see cref="OdbcSink"/>, <see cref="OracleSink"/>, <see cref="OrcSink"/>, <see cref="ParquetSink"/>, <see cref="RestSink"/>, <see cref="SalesforceServiceCloudSink"/>, <see cref="SalesforceSink"/>, <see cref="SapCloudForCustomerSink"/>, <see cref="SnowflakeSink"/>, <see cref="SqlDWSink"/>, <see cref="SqlMISink"/>, <see cref="SqlServerSink"/> and <see cref="SqlSink"/>.
        /// </param>
        /// <param name="translator">
        /// Copy activity translator. If not specified, tabular translator is used.
        /// Serialized Name: CopyActivity.typeProperties.translator
        /// </param>
        /// <param name="enableStaging">
        /// Specifies whether to copy data via an interim staging. Default value is false. Type: boolean (or Expression with resultType boolean).
        /// Serialized Name: CopyActivity.typeProperties.enableStaging
        /// </param>
        /// <param name="stagingSettings">
        /// Specifies interim staging settings when EnableStaging is true.
        /// Serialized Name: CopyActivity.typeProperties.stagingSettings
        /// </param>
        /// <param name="parallelCopies">
        /// Maximum number of concurrent sessions opened on the source or sink to avoid overloading the data store. Type: integer (or Expression with resultType integer), minimum: 0.
        /// Serialized Name: CopyActivity.typeProperties.parallelCopies
        /// </param>
        /// <param name="dataIntegrationUnits">
        /// Maximum number of data integration units that can be used to perform this data movement. Type: integer (or Expression with resultType integer), minimum: 0.
        /// Serialized Name: CopyActivity.typeProperties.dataIntegrationUnits
        /// </param>
        /// <param name="enableSkipIncompatibleRow">
        /// Whether to skip incompatible row. Default value is false. Type: boolean (or Expression with resultType boolean).
        /// Serialized Name: CopyActivity.typeProperties.enableSkipIncompatibleRow
        /// </param>
        /// <param name="redirectIncompatibleRowSettings">
        /// Redirect incompatible row settings when EnableSkipIncompatibleRow is true.
        /// Serialized Name: CopyActivity.typeProperties.redirectIncompatibleRowSettings
        /// </param>
        /// <param name="logStorageSettings">
        /// (Deprecated. Please use LogSettings) Log storage settings customer need to provide when enabling session log.
        /// Serialized Name: CopyActivity.typeProperties.logStorageSettings
        /// </param>
        /// <param name="logSettings">
        /// Log settings customer needs provide when enabling log.
        /// Serialized Name: CopyActivity.typeProperties.logSettings
        /// </param>
        /// <param name="preserveRules">
        /// Preserve Rules.
        /// Serialized Name: CopyActivity.typeProperties.preserveRules
        /// </param>
        /// <param name="preserve">
        /// Preserve rules.
        /// Serialized Name: CopyActivity.typeProperties.preserve
        /// </param>
        /// <param name="validateDataConsistency">
        /// Whether to enable Data Consistency validation. Type: boolean (or Expression with resultType boolean).
        /// Serialized Name: CopyActivity.typeProperties.validateDataConsistency
        /// </param>
        /// <param name="skipErrorFile">
        /// Specify the fault tolerance for data consistency.
        /// Serialized Name: CopyActivity.typeProperties.skipErrorFile
        /// </param>
        internal CopyActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, FactoryLinkedServiceReference linkedServiceName, ActivityPolicy policy, IList<DatasetReference> inputs, IList<DatasetReference> outputs, CopyActivitySource source, CopySink sink, BinaryData translator, BinaryData enableStaging, StagingSettings stagingSettings, BinaryData parallelCopies, BinaryData dataIntegrationUnits, BinaryData enableSkipIncompatibleRow, RedirectIncompatibleRowSettings redirectIncompatibleRowSettings, LogStorageSettings logStorageSettings, LogSettings logSettings, IList<BinaryData> preserveRules, IList<BinaryData> preserve, BinaryData validateDataConsistency, SkipErrorFile skipErrorFile) : base(name, activityType, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Inputs = inputs;
            Outputs = outputs;
            Source = source;
            Sink = sink;
            Translator = translator;
            EnableStaging = enableStaging;
            StagingSettings = stagingSettings;
            ParallelCopies = parallelCopies;
            DataIntegrationUnits = dataIntegrationUnits;
            EnableSkipIncompatibleRow = enableSkipIncompatibleRow;
            RedirectIncompatibleRowSettings = redirectIncompatibleRowSettings;
            LogStorageSettings = logStorageSettings;
            LogSettings = logSettings;
            PreserveRules = preserveRules;
            Preserve = preserve;
            ValidateDataConsistency = validateDataConsistency;
            SkipErrorFile = skipErrorFile;
            ActivityType = activityType ?? "Copy";
        }

        /// <summary>
        /// List of inputs for the activity.
        /// Serialized Name: CopyActivity.inputs
        /// </summary>
        public IList<DatasetReference> Inputs { get; }
        /// <summary>
        /// List of outputs for the activity.
        /// Serialized Name: CopyActivity.outputs
        /// </summary>
        public IList<DatasetReference> Outputs { get; }
        /// <summary>
        /// Copy activity source.
        /// Serialized Name: CopyActivity.typeProperties.source
        /// Please note <see cref="CopyActivitySource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsSource"/>, <see cref="AmazonRdsForOracleSource"/>, <see cref="AmazonRdsForSqlServerSource"/>, <see cref="AmazonRedshiftSource"/>, <see cref="AvroSource"/>, <see cref="AzureBlobFSSource"/>, <see cref="AzureDataExplorerSource"/>, <see cref="AzureDataLakeStoreSource"/>, <see cref="AzureDatabricksDeltaLakeSource"/>, <see cref="AzureMariaDBSource"/>, <see cref="AzureMySqlSource"/>, <see cref="AzurePostgreSqlSource"/>, <see cref="AzureSqlSource"/>, <see cref="AzureTableSource"/>, <see cref="BinarySource"/>, <see cref="BlobSource"/>, <see cref="CassandraSource"/>, <see cref="CommonDataServiceForAppsSource"/>, <see cref="ConcurSource"/>, <see cref="CosmosDBMongoDBApiSource"/>, <see cref="CosmosDBSqlApiSource"/>, <see cref="CouchbaseSource"/>, <see cref="Db2Source"/>, <see cref="DelimitedTextSource"/>, <see cref="DocumentDBCollectionSource"/>, <see cref="DrillSource"/>, <see cref="DynamicsAXSource"/>, <see cref="DynamicsCrmSource"/>, <see cref="DynamicsSource"/>, <see cref="EloquaSource"/>, <see cref="ExcelSource"/>, <see cref="FileSystemSource"/>, <see cref="GoogleAdWordsSource"/>, <see cref="GoogleBigQuerySource"/>, <see cref="GreenplumSource"/>, <see cref="HBaseSource"/>, <see cref="HdfsSource"/>, <see cref="HiveSource"/>, <see cref="HttpSource"/>, <see cref="HubspotSource"/>, <see cref="ImpalaSource"/>, <see cref="InformixSource"/>, <see cref="JiraSource"/>, <see cref="JsonSource"/>, <see cref="MagentoSource"/>, <see cref="MariaDBSource"/>, <see cref="MarketoSource"/>, <see cref="MicrosoftAccessSource"/>, <see cref="MongoDBAtlasSource"/>, <see cref="MongoDBSource"/>, <see cref="MongoDBV2Source"/>, <see cref="MySqlSource"/>, <see cref="NetezzaSource"/>, <see cref="ODataSource"/>, <see cref="OdbcSource"/>, <see cref="Office365Source"/>, <see cref="OracleServiceCloudSource"/>, <see cref="OracleSource"/>, <see cref="OrcSource"/>, <see cref="ParquetSource"/>, <see cref="PaypalSource"/>, <see cref="PhoenixSource"/>, <see cref="PostgreSqlSource"/>, <see cref="PrestoSource"/>, <see cref="QuickBooksSource"/>, <see cref="RelationalSource"/>, <see cref="ResponsysSource"/>, <see cref="RestSource"/>, <see cref="SalesforceMarketingCloudSource"/>, <see cref="SalesforceServiceCloudSource"/>, <see cref="SalesforceSource"/>, <see cref="SapBwSource"/>, <see cref="SapCloudForCustomerSource"/>, <see cref="SapEccSource"/>, <see cref="SapHanaSource"/>, <see cref="SapOdpSource"/>, <see cref="SapOpenHubSource"/>, <see cref="SapTableSource"/>, <see cref="ServiceNowSource"/>, <see cref="SharePointOnlineListSource"/>, <see cref="ShopifySource"/>, <see cref="SnowflakeSource"/>, <see cref="SparkSource"/>, <see cref="SqlDWSource"/>, <see cref="SqlMISource"/>, <see cref="SqlServerSource"/>, <see cref="SqlSource"/>, <see cref="SquareSource"/>, <see cref="SybaseSource"/>, <see cref="TabularSource"/>, <see cref="TeradataSource"/>, <see cref="VerticaSource"/>, <see cref="WebSource"/>, <see cref="XeroSource"/>, <see cref="XmlSource"/> and <see cref="ZohoSource"/>.
        /// </summary>
        public CopyActivitySource Source { get; set; }
        /// <summary>
        /// Copy activity sink.
        /// Serialized Name: CopyActivity.typeProperties.sink
        /// Please note <see cref="CopySink"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroSink"/>, <see cref="AzureBlobFSSink"/>, <see cref="AzureDataExplorerSink"/>, <see cref="AzureDataLakeStoreSink"/>, <see cref="AzureDatabricksDeltaLakeSink"/>, <see cref="AzureMySqlSink"/>, <see cref="AzurePostgreSqlSink"/>, <see cref="AzureQueueSink"/>, <see cref="AzureSearchIndexSink"/>, <see cref="AzureSqlSink"/>, <see cref="AzureTableSink"/>, <see cref="BinarySink"/>, <see cref="BlobSink"/>, <see cref="CommonDataServiceForAppsSink"/>, <see cref="CosmosDBMongoDBApiSink"/>, <see cref="CosmosDBSqlApiSink"/>, <see cref="DelimitedTextSink"/>, <see cref="DocumentDBCollectionSink"/>, <see cref="DynamicsCrmSink"/>, <see cref="DynamicsSink"/>, <see cref="FileSystemSink"/>, <see cref="InformixSink"/>, <see cref="JsonSink"/>, <see cref="MicrosoftAccessSink"/>, <see cref="MongoDBAtlasSink"/>, <see cref="MongoDBV2Sink"/>, <see cref="OdbcSink"/>, <see cref="OracleSink"/>, <see cref="OrcSink"/>, <see cref="ParquetSink"/>, <see cref="RestSink"/>, <see cref="SalesforceServiceCloudSink"/>, <see cref="SalesforceSink"/>, <see cref="SapCloudForCustomerSink"/>, <see cref="SnowflakeSink"/>, <see cref="SqlDWSink"/>, <see cref="SqlMISink"/>, <see cref="SqlServerSink"/> and <see cref="SqlSink"/>.
        /// </summary>
        public CopySink Sink { get; set; }
        /// <summary>
        /// Copy activity translator. If not specified, tabular translator is used.
        /// Serialized Name: CopyActivity.typeProperties.translator
        /// </summary>
        public BinaryData Translator { get; set; }
        /// <summary>
        /// Specifies whether to copy data via an interim staging. Default value is false. Type: boolean (or Expression with resultType boolean).
        /// Serialized Name: CopyActivity.typeProperties.enableStaging
        /// </summary>
        public BinaryData EnableStaging { get; set; }
        /// <summary>
        /// Specifies interim staging settings when EnableStaging is true.
        /// Serialized Name: CopyActivity.typeProperties.stagingSettings
        /// </summary>
        public StagingSettings StagingSettings { get; set; }
        /// <summary>
        /// Maximum number of concurrent sessions opened on the source or sink to avoid overloading the data store. Type: integer (or Expression with resultType integer), minimum: 0.
        /// Serialized Name: CopyActivity.typeProperties.parallelCopies
        /// </summary>
        public BinaryData ParallelCopies { get; set; }
        /// <summary>
        /// Maximum number of data integration units that can be used to perform this data movement. Type: integer (or Expression with resultType integer), minimum: 0.
        /// Serialized Name: CopyActivity.typeProperties.dataIntegrationUnits
        /// </summary>
        public BinaryData DataIntegrationUnits { get; set; }
        /// <summary>
        /// Whether to skip incompatible row. Default value is false. Type: boolean (or Expression with resultType boolean).
        /// Serialized Name: CopyActivity.typeProperties.enableSkipIncompatibleRow
        /// </summary>
        public BinaryData EnableSkipIncompatibleRow { get; set; }
        /// <summary>
        /// Redirect incompatible row settings when EnableSkipIncompatibleRow is true.
        /// Serialized Name: CopyActivity.typeProperties.redirectIncompatibleRowSettings
        /// </summary>
        public RedirectIncompatibleRowSettings RedirectIncompatibleRowSettings { get; set; }
        /// <summary>
        /// (Deprecated. Please use LogSettings) Log storage settings customer need to provide when enabling session log.
        /// Serialized Name: CopyActivity.typeProperties.logStorageSettings
        /// </summary>
        public LogStorageSettings LogStorageSettings { get; set; }
        /// <summary>
        /// Log settings customer needs provide when enabling log.
        /// Serialized Name: CopyActivity.typeProperties.logSettings
        /// </summary>
        public LogSettings LogSettings { get; set; }
        /// <summary>
        /// Preserve Rules.
        /// Serialized Name: CopyActivity.typeProperties.preserveRules
        /// </summary>
        public IList<BinaryData> PreserveRules { get; }
        /// <summary>
        /// Preserve rules.
        /// Serialized Name: CopyActivity.typeProperties.preserve
        /// </summary>
        public IList<BinaryData> Preserve { get; }
        /// <summary>
        /// Whether to enable Data Consistency validation. Type: boolean (or Expression with resultType boolean).
        /// Serialized Name: CopyActivity.typeProperties.validateDataConsistency
        /// </summary>
        public BinaryData ValidateDataConsistency { get; set; }
        /// <summary>
        /// Specify the fault tolerance for data consistency.
        /// Serialized Name: CopyActivity.typeProperties.skipErrorFile
        /// </summary>
        public SkipErrorFile SkipErrorFile { get; set; }
    }
}
