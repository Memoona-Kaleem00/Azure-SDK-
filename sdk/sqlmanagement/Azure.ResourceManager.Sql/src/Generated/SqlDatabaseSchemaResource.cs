// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SqlDatabaseSchema along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SqlDatabaseSchemaResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSqlDatabaseSchemaResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlDatabaseResource"/> using the GetSqlDatabaseSchema method.
    /// </summary>
    public partial class SqlDatabaseSchemaResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlDatabaseSchemaResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        /// <param name="databaseName"> The databaseName. </param>
        /// <param name="schemaName"> The schemaName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlDatabaseSchemaDatabaseSchemasClientDiagnostics;
        private readonly DatabaseSchemasRestOperations _sqlDatabaseSchemaDatabaseSchemasRestClient;
        private readonly DatabaseSchemaData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/schemas";

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseSchemaResource"/> class for mocking. </summary>
        protected SqlDatabaseSchemaResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseSchemaResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlDatabaseSchemaResource(ArmClient client, DatabaseSchemaData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseSchemaResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlDatabaseSchemaResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlDatabaseSchemaDatabaseSchemasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlDatabaseSchemaDatabaseSchemasApiVersion);
            _sqlDatabaseSchemaDatabaseSchemasRestClient = new DatabaseSchemasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlDatabaseSchemaDatabaseSchemasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DatabaseSchemaData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SqlDatabaseTableResources in the SqlDatabaseSchema. </summary>
        /// <returns> An object representing collection of SqlDatabaseTableResources and their operations over a SqlDatabaseTableResource. </returns>
        public virtual SqlDatabaseTableCollection GetSqlDatabaseTables()
        {
            return GetCachedClient(client => new SqlDatabaseTableCollection(client, Id));
        }

        /// <summary>
        /// Get database table
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseTables_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseTableResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SqlDatabaseTableResource>> GetSqlDatabaseTableAsync(string tableName, CancellationToken cancellationToken = default)
        {
            return await GetSqlDatabaseTables().GetAsync(tableName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get database table
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseTables_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseTableResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SqlDatabaseTableResource> GetSqlDatabaseTable(string tableName, CancellationToken cancellationToken = default)
        {
            return GetSqlDatabaseTables().Get(tableName, cancellationToken);
        }

        /// <summary>
        /// Get database schema
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSchemas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlDatabaseSchemaResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateScope("SqlDatabaseSchemaResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlDatabaseSchemaDatabaseSchemasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlDatabaseSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get database schema
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseSchemas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlDatabaseSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlDatabaseSchemaResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateScope("SqlDatabaseSchemaResource.Get");
            scope.Start();
            try
            {
                var response = _sqlDatabaseSchemaDatabaseSchemasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlDatabaseSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
