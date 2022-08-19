// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Marketplace. </summary>
    public static partial class MarketplaceExtensions
    {
        private static TenantResourceExtensionClient GetExtensionClient(TenantResource tenantResource)
        {
            return tenantResource.GetCachedClient((client) =>
            {
                return new TenantResourceExtensionClient(client, tenantResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of PrivateStoreResources in the TenantResource. </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PrivateStoreResources and their operations over a PrivateStoreResource. </returns>
        public static PrivateStoreCollection GetPrivateStores(this TenantResource tenantResource)
        {
            return GetExtensionClient(tenantResource).GetPrivateStores();
        }

        /// <summary>
        /// Get information about the private store
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}
        /// Operation Id: PrivateStore_Get
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateStoreId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateStoreId"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PrivateStoreResource>> GetPrivateStoreAsync(this TenantResource tenantResource, string privateStoreId, CancellationToken cancellationToken = default)
        {
            return await tenantResource.GetPrivateStores().GetAsync(privateStoreId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get information about the private store
        /// Request Path: /providers/Microsoft.Marketplace/privateStores/{privateStoreId}
        /// Operation Id: PrivateStore_Get
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateStoreId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateStoreId"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<PrivateStoreResource> GetPrivateStore(this TenantResource tenantResource, string privateStoreId, CancellationToken cancellationToken = default)
        {
            return tenantResource.GetPrivateStores().Get(privateStoreId, cancellationToken);
        }

        #region PrivateStoreResource
        /// <summary>
        /// Gets an object representing a <see cref="PrivateStoreResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateStoreResource.CreateResourceIdentifier" /> to create a <see cref="PrivateStoreResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateStoreResource" /> object. </returns>
        public static PrivateStoreResource GetPrivateStoreResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PrivateStoreResource.ValidateResourceId(id);
                return new PrivateStoreResource(client, id);
            }
            );
        }
        #endregion

        #region RequestApprovalResource
        /// <summary>
        /// Gets an object representing a <see cref="RequestApprovalResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RequestApprovalResource.CreateResourceIdentifier" /> to create a <see cref="RequestApprovalResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RequestApprovalResource" /> object. </returns>
        public static RequestApprovalResource GetRequestApprovalResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RequestApprovalResource.ValidateResourceId(id);
                return new RequestApprovalResource(client, id);
            }
            );
        }
        #endregion

        #region AdminRequestApprovalsResource
        /// <summary>
        /// Gets an object representing an <see cref="AdminRequestApprovalsResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AdminRequestApprovalsResource.CreateResourceIdentifier" /> to create an <see cref="AdminRequestApprovalsResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AdminRequestApprovalsResource" /> object. </returns>
        public static AdminRequestApprovalsResource GetAdminRequestApprovalsResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AdminRequestApprovalsResource.ValidateResourceId(id);
                return new AdminRequestApprovalsResource(client, id);
            }
            );
        }
        #endregion

        #region CollectionResource
        /// <summary>
        /// Gets an object representing a <see cref="CollectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CollectionResource.CreateResourceIdentifier" /> to create a <see cref="CollectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CollectionResource" /> object. </returns>
        public static CollectionResource GetCollectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                CollectionResource.ValidateResourceId(id);
                return new CollectionResource(client, id);
            }
            );
        }
        #endregion

        #region OfferResource
        /// <summary>
        /// Gets an object representing an <see cref="OfferResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OfferResource.CreateResourceIdentifier" /> to create an <see cref="OfferResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OfferResource" /> object. </returns>
        public static OfferResource GetOfferResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                OfferResource.ValidateResourceId(id);
                return new OfferResource(client, id);
            }
            );
        }
        #endregion
    }
}
