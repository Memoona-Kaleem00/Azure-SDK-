// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.Azure.Management.HealthcareApis.Models;
using Page = Azure.Page<Microsoft.Azure.Management.HealthcareApis.Models.IotConnector>;

namespace Microsoft.Azure.Management.HealthcareApis
{
    /// <summary> The IotConnectors service client. </summary>
    public partial class IotConnectorsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal IotConnectorsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of IotConnectorsOperations for mocking. </summary>
        protected IotConnectorsOperations()
        {
        }
        /// <summary> Initializes a new instance of IotConnectorsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal IotConnectorsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-11-01")
        {
            RestClient = new IotConnectorsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the properties of the specified IoT Connector. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IotConnector>> GetAsync(string resourceGroupName, string workspaceName, string iotConnectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IotConnectorsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, workspaceName, iotConnectorName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the properties of the specified IoT Connector. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IotConnector> Get(string resourceGroupName, string workspaceName, string iotConnectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IotConnectorsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, workspaceName, iotConnectorName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all IoT Connectors for the given workspace. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is null. </exception>
        public virtual AsyncPageable<IotConnector> ListByWorkspaceAsync(string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            async Task<Page> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("IotConnectorsOperations.ListByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByWorkspaceAsync(resourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("IotConnectorsOperations.ListByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByWorkspaceNextPageAsync(nextLink, resourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all IoT Connectors for the given workspace. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is null. </exception>
        public virtual Pageable<IotConnector> ListByWorkspace(string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            Page FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("IotConnectorsOperations.ListByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.ListByWorkspace(resourceGroupName, workspaceName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("IotConnectorsOperations.ListByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.ListByWorkspaceNextPage(nextLink, resourceGroupName, workspaceName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Creates or updates an IoT Connector resource with the specified parameters. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="iotConnector"> The parameters for creating or updating an IoT Connectors resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="iotConnectorName"/>, or <paramref name="iotConnector"/> is null. </exception>
        public virtual async Task<IotConnectorsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string workspaceName, string iotConnectorName, IotConnector iotConnector, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (iotConnectorName == null)
            {
                throw new ArgumentNullException(nameof(iotConnectorName));
            }
            if (iotConnector == null)
            {
                throw new ArgumentNullException(nameof(iotConnector));
            }

            using var scope = _clientDiagnostics.CreateScope("IotConnectorsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, workspaceName, iotConnectorName, iotConnector, cancellationToken).ConfigureAwait(false);
                return new IotConnectorsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, workspaceName, iotConnectorName, iotConnector).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an IoT Connector resource with the specified parameters. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="iotConnector"> The parameters for creating or updating an IoT Connectors resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="iotConnectorName"/>, or <paramref name="iotConnector"/> is null. </exception>
        public virtual IotConnectorsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string workspaceName, string iotConnectorName, IotConnector iotConnector, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (iotConnectorName == null)
            {
                throw new ArgumentNullException(nameof(iotConnectorName));
            }
            if (iotConnector == null)
            {
                throw new ArgumentNullException(nameof(iotConnector));
            }

            using var scope = _clientDiagnostics.CreateScope("IotConnectorsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, workspaceName, iotConnectorName, iotConnector, cancellationToken);
                return new IotConnectorsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, workspaceName, iotConnectorName, iotConnector).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Patch an IoT Connector. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="iotConnectorPatchResource"> The parameters for updating an IoT Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="iotConnectorName"/>, <paramref name="workspaceName"/>, or <paramref name="iotConnectorPatchResource"/> is null. </exception>
        public virtual async Task<IotConnectorsUpdateOperation> StartUpdateAsync(string resourceGroupName, string iotConnectorName, string workspaceName, IotConnectorPatchResource iotConnectorPatchResource, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (iotConnectorName == null)
            {
                throw new ArgumentNullException(nameof(iotConnectorName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (iotConnectorPatchResource == null)
            {
                throw new ArgumentNullException(nameof(iotConnectorPatchResource));
            }

            using var scope = _clientDiagnostics.CreateScope("IotConnectorsOperations.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UpdateAsync(resourceGroupName, iotConnectorName, workspaceName, iotConnectorPatchResource, cancellationToken).ConfigureAwait(false);
                return new IotConnectorsUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, iotConnectorName, workspaceName, iotConnectorPatchResource).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Patch an IoT Connector. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="iotConnectorPatchResource"> The parameters for updating an IoT Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="iotConnectorName"/>, <paramref name="workspaceName"/>, or <paramref name="iotConnectorPatchResource"/> is null. </exception>
        public virtual IotConnectorsUpdateOperation StartUpdate(string resourceGroupName, string iotConnectorName, string workspaceName, IotConnectorPatchResource iotConnectorPatchResource, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (iotConnectorName == null)
            {
                throw new ArgumentNullException(nameof(iotConnectorName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (iotConnectorPatchResource == null)
            {
                throw new ArgumentNullException(nameof(iotConnectorPatchResource));
            }

            using var scope = _clientDiagnostics.CreateScope("IotConnectorsOperations.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Update(resourceGroupName, iotConnectorName, workspaceName, iotConnectorPatchResource, cancellationToken);
                return new IotConnectorsUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, iotConnectorName, workspaceName, iotConnectorPatchResource).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes an IoT Connector. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="iotConnectorName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<IotConnectorsDeleteOperation> StartDeleteAsync(string resourceGroupName, string iotConnectorName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (iotConnectorName == null)
            {
                throw new ArgumentNullException(nameof(iotConnectorName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("IotConnectorsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, iotConnectorName, workspaceName, cancellationToken).ConfigureAwait(false);
                return new IotConnectorsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, iotConnectorName, workspaceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes an IoT Connector. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="iotConnectorName"> The name of IoT Connector resource. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="iotConnectorName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public virtual IotConnectorsDeleteOperation StartDelete(string resourceGroupName, string iotConnectorName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (iotConnectorName == null)
            {
                throw new ArgumentNullException(nameof(iotConnectorName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("IotConnectorsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, iotConnectorName, workspaceName, cancellationToken);
                return new IotConnectorsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, iotConnectorName, workspaceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
