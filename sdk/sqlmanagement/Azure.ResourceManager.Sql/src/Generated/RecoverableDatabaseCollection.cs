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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="RecoverableDatabaseResource"/> and their operations.
    /// Each <see cref="RecoverableDatabaseResource"/> in the collection will belong to the same instance of <see cref="SqlServerResource"/>.
    /// To get a <see cref="RecoverableDatabaseCollection"/> instance call the GetRecoverableDatabases method from an instance of <see cref="SqlServerResource"/>.
    /// </summary>
    public partial class RecoverableDatabaseCollection : ArmCollection, IEnumerable<RecoverableDatabaseResource>, IAsyncEnumerable<RecoverableDatabaseResource>
    {
        private readonly ClientDiagnostics _recoverableDatabaseClientDiagnostics;
        private readonly RecoverableDatabasesRestOperations _recoverableDatabaseRestClient;

        /// <summary> Initializes a new instance of the <see cref="RecoverableDatabaseCollection"/> class for mocking. </summary>
        protected RecoverableDatabaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RecoverableDatabaseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RecoverableDatabaseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _recoverableDatabaseClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", RecoverableDatabaseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RecoverableDatabaseResource.ResourceType, out string recoverableDatabaseApiVersion);
            _recoverableDatabaseRestClient = new RecoverableDatabasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, recoverableDatabaseApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a recoverable database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/recoverableDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableDatabases_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RecoverableDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<Response<RecoverableDatabaseResource>> GetAsync(string databaseName, string expand = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _recoverableDatabaseClientDiagnostics.CreateScope("RecoverableDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _recoverableDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, expand, filter, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecoverableDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a recoverable database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/recoverableDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableDatabases_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RecoverableDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<RecoverableDatabaseResource> Get(string databaseName, string expand = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _recoverableDatabaseClientDiagnostics.CreateScope("RecoverableDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = _recoverableDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, expand, filter, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecoverableDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of recoverable databases.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/recoverableDatabases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableDatabases_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RecoverableDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RecoverableDatabaseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RecoverableDatabaseResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _recoverableDatabaseRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _recoverableDatabaseRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RecoverableDatabaseResource(Client, RecoverableDatabaseData.DeserializeRecoverableDatabaseData(e)), _recoverableDatabaseClientDiagnostics, Pipeline, "RecoverableDatabaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of recoverable databases.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/recoverableDatabases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableDatabases_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RecoverableDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RecoverableDatabaseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RecoverableDatabaseResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _recoverableDatabaseRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _recoverableDatabaseRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RecoverableDatabaseResource(Client, RecoverableDatabaseData.DeserializeRecoverableDatabaseData(e)), _recoverableDatabaseClientDiagnostics, Pipeline, "RecoverableDatabaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/recoverableDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableDatabases_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RecoverableDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string databaseName, string expand = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _recoverableDatabaseClientDiagnostics.CreateScope("RecoverableDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = await _recoverableDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, expand, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/recoverableDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableDatabases_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RecoverableDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<bool> Exists(string databaseName, string expand = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _recoverableDatabaseClientDiagnostics.CreateScope("RecoverableDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = _recoverableDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, expand, filter, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/recoverableDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableDatabases_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RecoverableDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<NullableResponse<RecoverableDatabaseResource>> GetIfExistsAsync(string databaseName, string expand = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _recoverableDatabaseClientDiagnostics.CreateScope("RecoverableDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _recoverableDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, expand, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RecoverableDatabaseResource>(response.GetRawResponse());
                return Response.FromValue(new RecoverableDatabaseResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/recoverableDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoverableDatabases_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RecoverableDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual NullableResponse<RecoverableDatabaseResource> GetIfExists(string databaseName, string expand = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _recoverableDatabaseClientDiagnostics.CreateScope("RecoverableDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _recoverableDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, expand, filter, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RecoverableDatabaseResource>(response.GetRawResponse());
                return Response.FromValue(new RecoverableDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RecoverableDatabaseResource> IEnumerable<RecoverableDatabaseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RecoverableDatabaseResource> IAsyncEnumerable<RecoverableDatabaseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
