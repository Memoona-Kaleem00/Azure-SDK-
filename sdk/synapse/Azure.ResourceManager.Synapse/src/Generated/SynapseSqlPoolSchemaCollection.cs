// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseSqlPoolSchemaResource" /> and their operations.
    /// Each <see cref="SynapseSqlPoolSchemaResource" /> in the collection will belong to the same instance of <see cref="SynapseSqlPoolResource" />.
    /// To get a <see cref="SynapseSqlPoolSchemaCollection" /> instance call the GetSynapseSqlPoolSchemas method from an instance of <see cref="SynapseSqlPoolResource" />.
    /// </summary>
    public partial class SynapseSqlPoolSchemaCollection : ArmCollection, IEnumerable<SynapseSqlPoolSchemaResource>, IAsyncEnumerable<SynapseSqlPoolSchemaResource>
    {
        private readonly ClientDiagnostics _synapseSqlPoolSchemaSqlPoolSchemasClientDiagnostics;
        private readonly SqlPoolSchemasRestOperations _synapseSqlPoolSchemaSqlPoolSchemasRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseSqlPoolSchemaCollection"/> class for mocking. </summary>
        protected SynapseSqlPoolSchemaCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseSqlPoolSchemaCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseSqlPoolSchemaCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseSqlPoolSchemaSqlPoolSchemasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseSqlPoolSchemaResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseSqlPoolSchemaResource.ResourceType, out string synapseSqlPoolSchemaSqlPoolSchemasApiVersion);
            _synapseSqlPoolSchemaSqlPoolSchemasRestClient = new SqlPoolSchemasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseSqlPoolSchemaSqlPoolSchemasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseSqlPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseSqlPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get Sql Pool schema
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSchemas_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual async Task<Response<SynapseSqlPoolSchemaResource>> GetAsync(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _synapseSqlPoolSchemaSqlPoolSchemasClientDiagnostics.CreateScope("SynapseSqlPoolSchemaCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolSchemaSqlPoolSchemasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Sql Pool schema
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSchemas_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual Response<SynapseSqlPoolSchemaResource> Get(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _synapseSqlPoolSchemaSqlPoolSchemasClientDiagnostics.CreateScope("SynapseSqlPoolSchemaCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolSchemaSqlPoolSchemasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets schemas of a given SQL pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSchemas_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseSqlPoolSchemaResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseSqlPoolSchemaResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseSqlPoolSchemaSqlPoolSchemasRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseSqlPoolSchemaSqlPoolSchemasRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SynapseSqlPoolSchemaResource(Client, SynapseSqlPoolSchemaData.DeserializeSynapseSqlPoolSchemaData(e)), _synapseSqlPoolSchemaSqlPoolSchemasClientDiagnostics, Pipeline, "SynapseSqlPoolSchemaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets schemas of a given SQL pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSchemas_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseSqlPoolSchemaResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseSqlPoolSchemaResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseSqlPoolSchemaSqlPoolSchemasRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseSqlPoolSchemaSqlPoolSchemasRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SynapseSqlPoolSchemaResource(Client, SynapseSqlPoolSchemaData.DeserializeSynapseSqlPoolSchemaData(e)), _synapseSqlPoolSchemaSqlPoolSchemasClientDiagnostics, Pipeline, "SynapseSqlPoolSchemaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSchemas_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _synapseSqlPoolSchemaSqlPoolSchemasClientDiagnostics.CreateScope("SynapseSqlPoolSchemaCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolSchemaSqlPoolSchemasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSchemas_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual Response<bool> Exists(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _synapseSqlPoolSchemaSqlPoolSchemasClientDiagnostics.CreateScope("SynapseSqlPoolSchemaCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolSchemaSqlPoolSchemasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSchemas_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual async Task<NullableResponse<SynapseSqlPoolSchemaResource>> GetIfExistsAsync(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _synapseSqlPoolSchemaSqlPoolSchemasClientDiagnostics.CreateScope("SynapseSqlPoolSchemaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolSchemaSqlPoolSchemasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SynapseSqlPoolSchemaResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSchemas_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual NullableResponse<SynapseSqlPoolSchemaResource> GetIfExists(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _synapseSqlPoolSchemaSqlPoolSchemasClientDiagnostics.CreateScope("SynapseSqlPoolSchemaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolSchemaSqlPoolSchemasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SynapseSqlPoolSchemaResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseSqlPoolSchemaResource> IEnumerable<SynapseSqlPoolSchemaResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseSqlPoolSchemaResource> IAsyncEnumerable<SynapseSqlPoolSchemaResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
