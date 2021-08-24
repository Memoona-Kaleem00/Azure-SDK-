// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class representing collection of QueueService and their operations over a StorageAccount. </summary>
    public partial class QueueServiceContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly QueueServicesRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="QueueServiceContainer"/> class for mocking. </summary>
        protected QueueServiceContainer()
        {
        }

        /// <summary> Initializes a new instance of QueueServiceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal QueueServiceContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new QueueServicesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => StorageAccount.ResourceType;

        // Container level operations.

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="queueServiceName"> The name of the Queue Service within the specified storage account. Queue Service Name must be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<QueueService> Get(string queueServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueServiceContainer.Get");
            scope.Start();
            try
            {
                if (queueServiceName == null)
                {
                    throw new ArgumentNullException(nameof(queueServiceName));
                }

                var response = _restClient.GetServiceProperties(Id.ResourceGroupName, Id.Name, queueServiceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QueueService(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="queueServiceName"> The name of the Queue Service within the specified storage account. Queue Service Name must be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<QueueService>> GetAsync(string queueServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueServiceContainer.Get");
            scope.Start();
            try
            {
                if (queueServiceName == null)
                {
                    throw new ArgumentNullException(nameof(queueServiceName));
                }

                var response = await _restClient.GetServicePropertiesAsync(Id.ResourceGroupName, Id.Name, queueServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new QueueService(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="queueServiceName"> The name of the Queue Service within the specified storage account. Queue Service Name must be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<QueueService> GetIfExists(string queueServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueServiceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (queueServiceName == null)
                {
                    throw new ArgumentNullException(nameof(queueServiceName));
                }

                var response = _restClient.GetServiceProperties(Id.ResourceGroupName, Id.Name, queueServiceName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<QueueService>(null, response.GetRawResponse())
                    : Response.FromValue(new QueueService(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="queueServiceName"> The name of the Queue Service within the specified storage account. Queue Service Name must be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<QueueService>> GetIfExistsAsync(string queueServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueServiceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (queueServiceName == null)
                {
                    throw new ArgumentNullException(nameof(queueServiceName));
                }

                var response = await _restClient.GetServicePropertiesAsync(Id.ResourceGroupName, Id.Name, queueServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<QueueService>(null, response.GetRawResponse())
                    : Response.FromValue(new QueueService(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="queueServiceName"> The name of the Queue Service within the specified storage account. Queue Service Name must be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string queueServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueServiceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (queueServiceName == null)
                {
                    throw new ArgumentNullException(nameof(queueServiceName));
                }

                var response = GetIfExists(queueServiceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="queueServiceName"> The name of the Queue Service within the specified storage account. Queue Service Name must be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string queueServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueServiceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (queueServiceName == null)
                {
                    throw new ArgumentNullException(nameof(queueServiceName));
                }

                var response = await GetIfExistsAsync(queueServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all queue services for the storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<QueueService>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueServiceContainer.GetAll");
            scope.Start();
            try
            {
                var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(data => new QueueService(Parent, data)).ToArray() as IReadOnlyList<QueueService>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all queue services for the storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<QueueService>> GetAll(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueServiceContainer.GetAll");
            scope.Start();
            try
            {
                var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(response.Value.Value.Select(data => new QueueService(Parent, data)).ToArray() as IReadOnlyList<QueueService>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="QueueService" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueServiceContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(QueueService.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="QueueService" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("QueueServiceContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(QueueService.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, QueueService, QueueServiceData> Construct() { }
    }
}
