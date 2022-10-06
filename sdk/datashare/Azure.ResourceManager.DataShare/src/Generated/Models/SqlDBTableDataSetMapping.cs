// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataShare;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> A SQL DB Table data set mapping. </summary>
    public partial class SqlDBTableDataSetMapping : ShareDataSetMappingData
    {
        /// <summary> Initializes a new instance of SqlDBTableDataSetMapping. </summary>
        /// <param name="databaseName"> DatabaseName name of the sink data set. </param>
        /// <param name="dataSetId"> The id of the source data set. </param>
        /// <param name="schemaName"> Schema of the table. Default value is dbo. </param>
        /// <param name="sqlServerResourceId"> Resource id of SQL server. </param>
        /// <param name="tableName"> SQL DB table name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/>, <paramref name="schemaName"/>, <paramref name="sqlServerResourceId"/> or <paramref name="tableName"/> is null. </exception>
        public SqlDBTableDataSetMapping(string databaseName, Guid dataSetId, string schemaName, ResourceIdentifier sqlServerResourceId, string tableName)
        {
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }
            if (sqlServerResourceId == null)
            {
                throw new ArgumentNullException(nameof(sqlServerResourceId));
            }
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            DatabaseName = databaseName;
            DataSetId = dataSetId;
            SchemaName = schemaName;
            SqlServerResourceId = sqlServerResourceId;
            TableName = tableName;
            Kind = DataSetMappingKind.SqlDBTable;
        }

        /// <summary> Initializes a new instance of SqlDBTableDataSetMapping. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set mapping. </param>
        /// <param name="databaseName"> DatabaseName name of the sink data set. </param>
        /// <param name="dataSetId"> The id of the source data set. </param>
        /// <param name="dataSetMappingStatus"> Gets the status of the data set mapping. </param>
        /// <param name="provisioningState"> Provisioning state of the data set mapping. </param>
        /// <param name="schemaName"> Schema of the table. Default value is dbo. </param>
        /// <param name="sqlServerResourceId"> Resource id of SQL server. </param>
        /// <param name="tableName"> SQL DB table name. </param>
        internal SqlDBTableDataSetMapping(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetMappingKind kind, string databaseName, Guid dataSetId, DataSetMappingStatus? dataSetMappingStatus, DataShareProvisioningState? provisioningState, string schemaName, ResourceIdentifier sqlServerResourceId, string tableName) : base(id, name, resourceType, systemData, kind)
        {
            DatabaseName = databaseName;
            DataSetId = dataSetId;
            DataSetMappingStatus = dataSetMappingStatus;
            ProvisioningState = provisioningState;
            SchemaName = schemaName;
            SqlServerResourceId = sqlServerResourceId;
            TableName = tableName;
            Kind = kind;
        }

        /// <summary> DatabaseName name of the sink data set. </summary>
        public string DatabaseName { get; set; }
        /// <summary> The id of the source data set. </summary>
        public Guid DataSetId { get; set; }
        /// <summary> Gets the status of the data set mapping. </summary>
        public DataSetMappingStatus? DataSetMappingStatus { get; }
        /// <summary> Provisioning state of the data set mapping. </summary>
        public DataShareProvisioningState? ProvisioningState { get; }
        /// <summary> Schema of the table. Default value is dbo. </summary>
        public string SchemaName { get; set; }
        /// <summary> Resource id of SQL server. </summary>
        public ResourceIdentifier SqlServerResourceId { get; set; }
        /// <summary> SQL DB table name. </summary>
        public string TableName { get; set; }
    }
}
