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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedDatabaseSchemaResource"/> and their operations.
    /// Each <see cref="ManagedDatabaseSchemaResource"/> in the collection will belong to the same instance of <see cref="ManagedDatabaseResource"/>.
    /// To get a <see cref="ManagedDatabaseSchemaCollection"/> instance call the GetManagedDatabaseSchemas method from an instance of <see cref="ManagedDatabaseResource"/>.
    /// </summary>
    public partial class ManagedDatabaseSchemaCollection : ArmCollection, IEnumerable<ManagedDatabaseSchemaResource>, IAsyncEnumerable<ManagedDatabaseSchemaResource>
    {
        private readonly ClientDiagnostics _managedDatabaseSchemaClientDiagnostics;
        private readonly ManagedDatabaseSchemasRestOperations _managedDatabaseSchemaRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseSchemaCollection"/> class for mocking. </summary>
        protected ManagedDatabaseSchemaCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseSchemaCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedDatabaseSchemaCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedDatabaseSchemaClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedDatabaseSchemaResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedDatabaseSchemaResource.ResourceType, out string managedDatabaseSchemaApiVersion);
            _managedDatabaseSchemaRestClient = new ManagedDatabaseSchemasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedDatabaseSchemaApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get managed database schema
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseSchemas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual async Task<Response<ManagedDatabaseSchemaResource>> GetAsync(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _managedDatabaseSchemaClientDiagnostics.CreateScope("ManagedDatabaseSchemaCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSchemaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get managed database schema
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseSchemas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual Response<ManagedDatabaseSchemaResource> Get(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _managedDatabaseSchemaClientDiagnostics.CreateScope("ManagedDatabaseSchemaCollection.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseSchemaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List managed database schemas
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseSchemas_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedDatabaseSchemaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedDatabaseSchemaResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedDatabaseSchemaRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedDatabaseSchemaRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedDatabaseSchemaResource(Client, DatabaseSchemaData.DeserializeDatabaseSchemaData(e)), _managedDatabaseSchemaClientDiagnostics, Pipeline, "ManagedDatabaseSchemaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List managed database schemas
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseSchemas_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedDatabaseSchemaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedDatabaseSchemaResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedDatabaseSchemaRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedDatabaseSchemaRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedDatabaseSchemaResource(Client, DatabaseSchemaData.DeserializeDatabaseSchemaData(e)), _managedDatabaseSchemaClientDiagnostics, Pipeline, "ManagedDatabaseSchemaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseSchemas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseSchemaResource"/></description>
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

            using var scope = _managedDatabaseSchemaClientDiagnostics.CreateScope("ManagedDatabaseSchemaCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSchemaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseSchemas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseSchemaResource"/></description>
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

            using var scope = _managedDatabaseSchemaClientDiagnostics.CreateScope("ManagedDatabaseSchemaCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedDatabaseSchemaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseSchemas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual async Task<NullableResponse<ManagedDatabaseSchemaResource>> GetIfExistsAsync(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _managedDatabaseSchemaClientDiagnostics.CreateScope("ManagedDatabaseSchemaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSchemaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ManagedDatabaseSchemaResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseSchemaResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseSchemas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDatabaseSchemaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual NullableResponse<ManagedDatabaseSchemaResource> GetIfExists(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _managedDatabaseSchemaClientDiagnostics.CreateScope("ManagedDatabaseSchemaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedDatabaseSchemaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ManagedDatabaseSchemaResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedDatabaseSchemaResource> IEnumerable<ManagedDatabaseSchemaResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedDatabaseSchemaResource> IAsyncEnumerable<ManagedDatabaseSchemaResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
