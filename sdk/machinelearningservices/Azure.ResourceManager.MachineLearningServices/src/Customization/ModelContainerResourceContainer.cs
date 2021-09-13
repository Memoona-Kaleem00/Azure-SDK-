// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing collection of ModelContainerResource and their operations over a Workspace. </summary>
    public partial class ModelContainerResourceContainer : ArmContainer
    {
        // Container level operations.

        /// <summary> Create or update container. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        public virtual Response<ModelContainerResource> CreateOrUpdate(string name, ModelContainer properties, CancellationToken cancellationToken = default)
        {
            return Get(name, cancellationToken);
        }

        /// <summary> Create or update container. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        public virtual Task<Response<ModelContainerResource>> CreateOrUpdateAsync(string name, ModelContainer properties, CancellationToken cancellationToken = default)
        {
            return GetAsync(name, cancellationToken);
        }

        /// <summary> Create or update container. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        internal virtual ModelContainerCreateOrUpdateOperation StartCreateOrUpdate(string name, ModelContainer properties, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Create or update container. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        internal virtual Task<ModelContainerCreateOrUpdateOperation> StartCreateOrUpdateAsync(string name, ModelContainer properties, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ModelContainerResource> Get(string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ModelContainerResourceContainer.Get");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }

                return Response.FromValue(GenerateResource(name), null);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Task<Response<ModelContainerResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ModelContainerResourceContainer.Get");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }

                return Task.FromResult(Response.FromValue(GenerateResource(name), null));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        internal virtual Response<ModelContainerResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        internal virtual Task<Response<ModelContainerResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        internal virtual Response<bool> CheckIfExists(string name, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        internal virtual Task<Response<bool>> CheckIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> List model containers. </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="count"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ModelContainerResource" /> that may take multiple service requests to iterate over. </returns>
        internal Pageable<ModelContainerResource> GetAll(string skip = null, int? count = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> List model containers. </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="count"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ModelContainerResource" /> that may take multiple service requests to iterate over. </returns>
        internal AsyncPageable<ModelContainerResource> GetAllAsync(string skip = null, int? count = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Filters the list of <see cref="ModelContainerResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        internal Pageable<GenericResource> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Filters the list of <see cref="ModelContainerResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        internal AsyncPageable<GenericResource> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        private ModelContainerResource GenerateResource(
            string name,
            ModelContainerResourceData resourceData = default)
        {
            resourceData ??= new ModelContainerResourceData(
                Parent.Id + $"/models/{name}",
                name,
                ModelContainerResourceOperations.ResourceType,
                new ModelContainer(string.Empty, new Dictionary<string, string>(), new Dictionary<string, string>()),
                null);

            return new ModelContainerResource(Parent, resourceData);
        }
    }
}
