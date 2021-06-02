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

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of ManagementLockObject and their operations over a ResourceGroup. </summary>
    public partial class ManagementLockObjectResourceGroupsContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, ManagementLockObject, ManagementLockObjectData>
    {
        /// <summary> Initializes a new instance of the <see cref="ManagementLockObjectResourceGroupsContainer"/> class for mocking. </summary>
        protected ManagementLockObjectResourceGroupsContainer()
        {
        }

        /// <summary> Initializes a new instance of ManagementLockObjectResourceGroupsContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagementLockObjectResourceGroupsContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private ManagementLocksRestOperations _restClient => new ManagementLocksRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a ManagementLockObject. Please note some properties can be set only during creation. </summary>
        /// <param name="lockName"> The lock name. The lock name can be a maximum of 260 characters. It cannot contain &lt;, &gt; %, &amp;, :, \, ?, /, or any control characters. </param>
        /// <param name="parameters"> The management lock parameters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<ManagementLockObject> CreateOrUpdate(string lockName, ManagementLockObjectData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectResourceGroupsContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (lockName == null)
                {
                    throw new ArgumentNullException(nameof(lockName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(lockName, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a ManagementLockObject. Please note some properties can be set only during creation. </summary>
        /// <param name="lockName"> The lock name. The lock name can be a maximum of 260 characters. It cannot contain &lt;, &gt; %, &amp;, :, \, ?, /, or any control characters. </param>
        /// <param name="parameters"> The management lock parameters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<ManagementLockObject>> CreateOrUpdateAsync(string lockName, ManagementLockObjectData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectResourceGroupsContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (lockName == null)
                {
                    throw new ArgumentNullException(nameof(lockName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(lockName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a ManagementLockObject. Please note some properties can be set only during creation. </summary>
        /// <param name="lockName"> The lock name. The lock name can be a maximum of 260 characters. It cannot contain &lt;, &gt; %, &amp;, :, \, ?, /, or any control characters. </param>
        /// <param name="parameters"> The management lock parameters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public ManagementLocksCreateOrUpdateAtResourceGroupLevelOperation StartCreateOrUpdate(string lockName, ManagementLockObjectData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectResourceGroupsContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (lockName == null)
                {
                    throw new ArgumentNullException(nameof(lockName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.CreateOrUpdateAtResourceGroupLevel(Id.ResourceGroupName, lockName, parameters, cancellationToken: cancellationToken);
                return new ManagementLocksCreateOrUpdateAtResourceGroupLevelOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a ManagementLockObject. Please note some properties can be set only during creation. </summary>
        /// <param name="lockName"> The lock name. The lock name can be a maximum of 260 characters. It cannot contain &lt;, &gt; %, &amp;, :, \, ?, /, or any control characters. </param>
        /// <param name="parameters"> The management lock parameters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<ManagementLocksCreateOrUpdateAtResourceGroupLevelOperation> StartCreateOrUpdateAsync(string lockName, ManagementLockObjectData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectResourceGroupsContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (lockName == null)
                {
                    throw new ArgumentNullException(nameof(lockName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.CreateOrUpdateAtResourceGroupLevelAsync(Id.ResourceGroupName, lockName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new ManagementLocksCreateOrUpdateAtResourceGroupLevelOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="lockName"> The name of the lock to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public override Response<ManagementLockObject> Get(string lockName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectResourceGroupsContainer.Get");
            scope.Start();
            try
            {
                if (lockName == null)
                {
                    throw new ArgumentNullException(nameof(lockName));
                }

                var response = _restClient.GetAtResourceGroupLevel(Id.ResourceGroupName, lockName, cancellationToken: cancellationToken);
                return Response.FromValue(new ManagementLockObject(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="lockName"> The name of the lock to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async override Task<Response<ManagementLockObject>> GetAsync(string lockName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectResourceGroupsContainer.Get");
            scope.Start();
            try
            {
                if (lockName == null)
                {
                    throw new ArgumentNullException(nameof(lockName));
                }

                var response = await _restClient.GetAtResourceGroupLevelAsync(Id.ResourceGroupName, lockName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ManagementLockObject(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the management locks for a resource group. </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagementLockObject" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<ManagementLockObject> List(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ManagementLockObject> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectResourceGroupsContainer.ListAtResourceGroupLevel");
                scope.Start();
                try
                {
                    var response = _restClient.ListAtResourceGroupLevel(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementLockObject(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagementLockObject> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectResourceGroupsContainer.ListAtResourceGroupLevel");
                scope.Start();
                try
                {
                    var response = _restClient.ListAtResourceGroupLevelNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementLockObject(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the management locks for a resource group. </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagementLockObject" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<ManagementLockObject> ListAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagementLockObject>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectResourceGroupsContainer.ListAtResourceGroupLevel");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAtResourceGroupLevelAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementLockObject(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagementLockObject>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectResourceGroupsContainer.ListAtResourceGroupLevel");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAtResourceGroupLevelNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementLockObject(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of ManagementLockObject for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<Core.GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectResourceGroupsContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ManagementLockObject.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of ManagementLockObject for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<Core.GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectResourceGroupsContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ManagementLockObject.ResourceType);
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
        // public ArmBuilder<ResourceGroupResourceIdentifier, ManagementLockObject, ManagementLockObjectData> Construct() { }
    }
}
