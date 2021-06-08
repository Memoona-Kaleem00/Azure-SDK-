// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Core.Resources;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> A class representing collection of DeploymentExtended and their operations over a Tenant. </summary>
    public partial class DeploymentExtendedContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, DeploymentExtended, DeploymentExtendedData>
    {
        /// <summary> Initializes a new instance of the <see cref="DeploymentExtendedContainer"/> class for mocking. </summary>
        protected DeploymentExtendedContainer()
        {
        }

        /// <summary> Initializes a new instance of DeploymentExtendedContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DeploymentExtendedContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private DeploymentsRestOperations _restClient => new DeploymentsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.RootResourceIdentifier.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a DeploymentExtended. Please note some properties can be set only during creation. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="parameters"> Additional parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<DeploymentExtended> CreateOrUpdate(string deploymentName, Deployment parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(deploymentName, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a DeploymentExtended. Please note some properties can be set only during creation. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="parameters"> Additional parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<DeploymentExtended>> CreateOrUpdateAsync(string deploymentName, Deployment parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(deploymentName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a DeploymentExtended. Please note some properties can be set only during creation. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="parameters"> Additional parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public DeploymentsCreateOrUpdateAtScopeOperation StartCreateOrUpdate(string deploymentName, Deployment parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.CreateOrUpdateAtScope(Id.Name, deploymentName, parameters, cancellationToken: cancellationToken);
                return new DeploymentsCreateOrUpdateAtScopeOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateAtScopeRequest(Id.Name, deploymentName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a DeploymentExtended. Please note some properties can be set only during creation. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="parameters"> Additional parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<DeploymentsCreateOrUpdateAtScopeOperation> StartCreateOrUpdateAsync(string deploymentName, Deployment parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.CreateOrUpdateAtScopeAsync(Id.Name, deploymentName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new DeploymentsCreateOrUpdateAtScopeOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateAtScopeRequest(Id.Name, deploymentName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public override Response<DeploymentExtended> Get(string deploymentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.Get");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }

                var response = _restClient.GetAtScope(Id.Name, deploymentName, cancellationToken: cancellationToken);
                return Response.FromValue(new DeploymentExtended(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async override Task<Response<DeploymentExtended>> GetAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.Get");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }

                var response = await _restClient.GetAtScopeAsync(Id.Name, deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DeploymentExtended(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all the deployments for a resource group. </summary>
        /// <param name="filter"> The filter to apply on the operation. For example, you can use $filter=provisioningState eq &apos;{state}&apos;. </param>
        /// <param name="top"> The number of results to get. If null is passed, returns all deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeploymentExtended" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<DeploymentExtended> List(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<DeploymentExtended> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentExtended(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeploymentExtended> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentExtended(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get all the deployments for a resource group. </summary>
        /// <param name="filter"> The filter to apply on the operation. For example, you can use $filter=provisioningState eq &apos;{state}&apos;. </param>
        /// <param name="top"> The number of results to get. If null is passed, returns all deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeploymentExtended" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<DeploymentExtended> ListAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DeploymentExtended>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentExtended(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeploymentExtended>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentExtended(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of DeploymentExtended for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<Core.GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DeploymentExtendedOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of DeploymentExtended for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<Core.GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DeploymentExtendedOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, DeploymentExtended, DeploymentExtendedData> Construct() { }
    }
}
