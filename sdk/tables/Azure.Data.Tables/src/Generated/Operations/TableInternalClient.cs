// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Data.Tables.Models;

namespace Azure.Data.Tables
{
    /// <summary> The TableInternal service client. </summary>
    internal partial class TableInternalClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal TableInternalRestClient RestClient { get; }
        /// <summary> Initializes a new instance of TableInternalClient for mocking. </summary>
        protected TableInternalClient()
        {
        }

        /// <summary> Queries tables under the given account. </summary>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TableQueryResponse>> QueryAsync(string requestId = null, QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.QueryAsync(requestId, queryOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Queries tables under the given account. </summary>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TableQueryResponse> Query(string requestId = null, QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            return RestClient.Query(requestId, queryOptions, cancellationToken);
        }

        /// <summary> Creates a new table under the given account. </summary>
        /// <param name="tableProperties"> The Table properties. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TableResponse>> CreateAsync(TableProperties tableProperties, string requestId = null, QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateAsync(tableProperties, requestId, queryOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new table under the given account. </summary>
        /// <param name="tableProperties"> The Table properties. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TableResponse> Create(TableProperties tableProperties, string requestId = null, QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            return RestClient.Create(tableProperties, requestId, queryOptions, cancellationToken);
        }

        /// <summary> Operation permanently deletes the specified table. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string table, string requestId = null, CancellationToken cancellationToken = default)
        {
            return (await RestClient.DeleteAsync(table, requestId, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Operation permanently deletes the specified table. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string table, string requestId = null, CancellationToken cancellationToken = default)
        {
            return RestClient.Delete(table, requestId, cancellationToken).GetRawResponse();
        }

        /// <summary> Queries entities in a table. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TableEntityQueryResponse>> QueryEntitiesAsync(string table, int? timeout = null, string requestId = null, QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.QueryEntitiesAsync(table, timeout, requestId, queryOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Queries entities in a table. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TableEntityQueryResponse> QueryEntities(string table, int? timeout = null, string requestId = null, QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            return RestClient.QueryEntities(table, timeout, requestId, queryOptions, cancellationToken);
        }

        /// <summary> Queries entities in a table. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="partitionKey"> The partition key of the entity. </param>
        /// <param name="rowKey"> The row key of the entity. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TableEntityQueryResponse>> QueryEntitiesWithPartitionAndRowKeyAsync(string table, string partitionKey, string rowKey, int? timeout = null, string requestId = null, QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.QueryEntitiesWithPartitionAndRowKeyAsync(table, partitionKey, rowKey, timeout, requestId, queryOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Queries entities in a table. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="partitionKey"> The partition key of the entity. </param>
        /// <param name="rowKey"> The row key of the entity. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TableEntityQueryResponse> QueryEntitiesWithPartitionAndRowKey(string table, string partitionKey, string rowKey, int? timeout = null, string requestId = null, QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            return RestClient.QueryEntitiesWithPartitionAndRowKey(table, partitionKey, rowKey, timeout, requestId, queryOptions, cancellationToken);
        }

        /// <summary> Update entity in a table. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="partitionKey"> The partition key of the entity. </param>
        /// <param name="rowKey"> The row key of the entity. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="tableEntityProperties"> The properties for the table entity. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdateEntityAsync(string table, string partitionKey, string rowKey, int? timeout = null, string requestId = null, IDictionary<string, object> tableEntityProperties = null, QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            return (await RestClient.UpdateEntityAsync(table, partitionKey, rowKey, timeout, requestId, tableEntityProperties, queryOptions, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Update entity in a table. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="partitionKey"> The partition key of the entity. </param>
        /// <param name="rowKey"> The row key of the entity. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="tableEntityProperties"> The properties for the table entity. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UpdateEntity(string table, string partitionKey, string rowKey, int? timeout = null, string requestId = null, IDictionary<string, object> tableEntityProperties = null, QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            return RestClient.UpdateEntity(table, partitionKey, rowKey, timeout, requestId, tableEntityProperties, queryOptions, cancellationToken).GetRawResponse();
        }

        /// <summary> Deletes the specified entity in a table. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="partitionKey"> The partition key of the entity. </param>
        /// <param name="rowKey"> The row key of the entity. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteEntityAsync(string table, string partitionKey, string rowKey, int? timeout = null, string requestId = null, QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            return (await RestClient.DeleteEntityAsync(table, partitionKey, rowKey, timeout, requestId, queryOptions, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Deletes the specified entity in a table. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="partitionKey"> The partition key of the entity. </param>
        /// <param name="rowKey"> The row key of the entity. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteEntity(string table, string partitionKey, string rowKey, int? timeout = null, string requestId = null, QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            return RestClient.DeleteEntity(table, partitionKey, rowKey, timeout, requestId, queryOptions, cancellationToken).GetRawResponse();
        }

        /// <summary> Insert entity in a table. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="tableEntityProperties"> The properties for the table entity. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyDictionary<string, object>>> InsertEntityAsync(string table, int? timeout = null, string requestId = null, IDictionary<string, object> tableEntityProperties = null, QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.InsertEntityAsync(table, timeout, requestId, tableEntityProperties, queryOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Insert entity in a table. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="tableEntityProperties"> The properties for the table entity. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyDictionary<string, object>> InsertEntity(string table, int? timeout = null, string requestId = null, IDictionary<string, object> tableEntityProperties = null, QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            return RestClient.InsertEntity(table, timeout, requestId, tableEntityProperties, queryOptions, cancellationToken);
        }

        /// <summary> Retrieves details about any stored access policies specified on the table that may be used wit Shared Access Signatures. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<SignedIdentifier>>> GetAccessPolicyAsync(string table, int? timeout = null, string requestId = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAccessPolicyAsync(table, timeout, requestId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves details about any stored access policies specified on the table that may be used wit Shared Access Signatures. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<SignedIdentifier>> GetAccessPolicy(string table, int? timeout = null, string requestId = null, CancellationToken cancellationToken = default)
        {
            return RestClient.GetAccessPolicy(table, timeout, requestId, cancellationToken);
        }

        /// <summary> sets stored access policies for the table that may be used with Shared Access Signatures. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="tableAcl"> the acls for the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> SetAccessPolicyAsync(string table, int? timeout = null, string requestId = null, IEnumerable<SignedIdentifier> tableAcl = null, CancellationToken cancellationToken = default)
        {
            return (await RestClient.SetAccessPolicyAsync(table, timeout, requestId, tableAcl, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> sets stored access policies for the table that may be used with Shared Access Signatures. </summary>
        /// <param name="table"> The name of the table. </param>
        /// <param name="timeout"> The The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/setting-timeouts-for-queue-service-operations&gt;Setting Timeouts for Queue Service Operations.&lt;/a&gt;. </param>
        /// <param name="requestId"> Provides a client-generated, opaque value with a 1 KB character limit that is recorded in the analytics logs when storage analytics logging is enabled. </param>
        /// <param name="tableAcl"> the acls for the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response SetAccessPolicy(string table, int? timeout = null, string requestId = null, IEnumerable<SignedIdentifier> tableAcl = null, CancellationToken cancellationToken = default)
        {
            return RestClient.SetAccessPolicy(table, timeout, requestId, tableAcl, cancellationToken).GetRawResponse();
        }
    }
}
