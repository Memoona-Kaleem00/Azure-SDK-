// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServerAzureADAdministrator and their operations over its parent. </summary>
    public partial class ServerAzureADAdministratorCollection : ArmCollection, IEnumerable<ServerAzureADAdministrator>, IAsyncEnumerable<ServerAzureADAdministrator>
    {
        private readonly ClientDiagnostics _serverAzureADAdministratorClientDiagnostics;
        private readonly ServerAzureADAdministratorsRestOperations _serverAzureADAdministratorRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerAzureADAdministratorCollection"/> class for mocking. </summary>
        protected ServerAzureADAdministratorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerAzureADAdministratorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerAzureADAdministratorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverAzureADAdministratorClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerAzureADAdministrator.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ServerAzureADAdministrator.ResourceType, out string serverAzureADAdministratorApiVersion);
            _serverAzureADAdministratorRestClient = new ServerAzureADAdministratorsRestOperations(_serverAzureADAdministratorClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverAzureADAdministratorApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServer.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an existing Azure Active Directory administrator.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}
        /// Operation Id: ServerAzureADAdministrators_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="administratorName"> The name of server active directory administrator. </param>
        /// <param name="parameters"> The requested Azure Active Directory administrator Resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<ServerAzureADAdministrator>> CreateOrUpdateAsync(bool waitForCompletion, AdministratorName administratorName, ServerAzureADAdministratorData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _serverAzureADAdministratorClientDiagnostics.CreateScope("ServerAzureADAdministratorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverAzureADAdministratorRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ServerAzureADAdministrator>(new ServerAzureADAdministratorOperationSource(Client), _serverAzureADAdministratorClientDiagnostics, Pipeline, _serverAzureADAdministratorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an existing Azure Active Directory administrator.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}
        /// Operation Id: ServerAzureADAdministrators_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="administratorName"> The name of server active directory administrator. </param>
        /// <param name="parameters"> The requested Azure Active Directory administrator Resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ServerAzureADAdministrator> CreateOrUpdate(bool waitForCompletion, AdministratorName administratorName, ServerAzureADAdministratorData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _serverAzureADAdministratorClientDiagnostics.CreateScope("ServerAzureADAdministratorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverAzureADAdministratorRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, parameters, cancellationToken);
                var operation = new SqlArmOperation<ServerAzureADAdministrator>(new ServerAzureADAdministratorOperationSource(Client), _serverAzureADAdministratorClientDiagnostics, Pipeline, _serverAzureADAdministratorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Azure Active Directory administrator.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}
        /// Operation Id: ServerAzureADAdministrators_Get
        /// </summary>
        /// <param name="administratorName"> The name of server active directory administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServerAzureADAdministrator>> GetAsync(AdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAzureADAdministratorClientDiagnostics.CreateScope("ServerAzureADAdministratorCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverAzureADAdministratorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _serverAzureADAdministratorClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerAzureADAdministrator(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Azure Active Directory administrator.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}
        /// Operation Id: ServerAzureADAdministrators_Get
        /// </summary>
        /// <param name="administratorName"> The name of server active directory administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerAzureADAdministrator> Get(AdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAzureADAdministratorClientDiagnostics.CreateScope("ServerAzureADAdministratorCollection.Get");
            scope.Start();
            try
            {
                var response = _serverAzureADAdministratorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken);
                if (response.Value == null)
                    throw _serverAzureADAdministratorClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerAzureADAdministrator(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of Azure Active Directory administrators in a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators
        /// Operation Id: ServerAzureADAdministrators_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerAzureADAdministrator" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerAzureADAdministrator> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerAzureADAdministrator>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverAzureADAdministratorClientDiagnostics.CreateScope("ServerAzureADAdministratorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverAzureADAdministratorRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerAzureADAdministrator(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerAzureADAdministrator>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverAzureADAdministratorClientDiagnostics.CreateScope("ServerAzureADAdministratorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverAzureADAdministratorRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerAzureADAdministrator(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of Azure Active Directory administrators in a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators
        /// Operation Id: ServerAzureADAdministrators_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerAzureADAdministrator" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerAzureADAdministrator> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerAzureADAdministrator> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverAzureADAdministratorClientDiagnostics.CreateScope("ServerAzureADAdministratorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverAzureADAdministratorRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerAzureADAdministrator(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerAzureADAdministrator> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverAzureADAdministratorClientDiagnostics.CreateScope("ServerAzureADAdministratorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverAzureADAdministratorRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerAzureADAdministrator(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}
        /// Operation Id: ServerAzureADAdministrators_Get
        /// </summary>
        /// <param name="administratorName"> The name of server active directory administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> ExistsAsync(AdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAzureADAdministratorClientDiagnostics.CreateScope("ServerAzureADAdministratorCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(administratorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}
        /// Operation Id: ServerAzureADAdministrators_Get
        /// </summary>
        /// <param name="administratorName"> The name of server active directory administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(AdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAzureADAdministratorClientDiagnostics.CreateScope("ServerAzureADAdministratorCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(administratorName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}
        /// Operation Id: ServerAzureADAdministrators_Get
        /// </summary>
        /// <param name="administratorName"> The name of server active directory administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServerAzureADAdministrator>> GetIfExistsAsync(AdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAzureADAdministratorClientDiagnostics.CreateScope("ServerAzureADAdministratorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverAzureADAdministratorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerAzureADAdministrator>(null, response.GetRawResponse());
                return Response.FromValue(new ServerAzureADAdministrator(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/administrators/{administratorName}
        /// Operation Id: ServerAzureADAdministrators_Get
        /// </summary>
        /// <param name="administratorName"> The name of server active directory administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerAzureADAdministrator> GetIfExists(AdministratorName administratorName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAzureADAdministratorClientDiagnostics.CreateScope("ServerAzureADAdministratorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverAzureADAdministratorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, administratorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerAzureADAdministrator>(null, response.GetRawResponse());
                return Response.FromValue(new ServerAzureADAdministrator(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerAzureADAdministrator> IEnumerable<ServerAzureADAdministrator>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerAzureADAdministrator> IAsyncEnumerable<ServerAzureADAdministrator>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
