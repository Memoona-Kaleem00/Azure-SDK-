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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkVirtualApplianceSkuResource"/> and their operations.
    /// Each <see cref="NetworkVirtualApplianceSkuResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="NetworkVirtualApplianceSkuCollection"/> instance call the GetNetworkVirtualApplianceSkus method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class NetworkVirtualApplianceSkuCollection : ArmCollection, IEnumerable<NetworkVirtualApplianceSkuResource>, IAsyncEnumerable<NetworkVirtualApplianceSkuResource>
    {
        private readonly ClientDiagnostics _networkVirtualApplianceSkuVirtualApplianceSkusClientDiagnostics;
        private readonly VirtualApplianceSkusRestOperations _networkVirtualApplianceSkuVirtualApplianceSkusRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkVirtualApplianceSkuCollection"/> class for mocking. </summary>
        protected NetworkVirtualApplianceSkuCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkVirtualApplianceSkuCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkVirtualApplianceSkuCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkVirtualApplianceSkuVirtualApplianceSkusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkVirtualApplianceSkuResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkVirtualApplianceSkuResource.ResourceType, out string networkVirtualApplianceSkuVirtualApplianceSkusApiVersion);
            _networkVirtualApplianceSkuVirtualApplianceSkusRestClient = new VirtualApplianceSkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkVirtualApplianceSkuVirtualApplianceSkusApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieves a single available sku for network virtual appliance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkVirtualApplianceSkus/{skuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSkus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkVirtualApplianceSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skuName"> Name of the Sku. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="skuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="skuName"/> is null. </exception>
        public virtual async Task<Response<NetworkVirtualApplianceSkuResource>> GetAsync(string skuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(skuName, nameof(skuName));

            using var scope = _networkVirtualApplianceSkuVirtualApplianceSkusClientDiagnostics.CreateScope("NetworkVirtualApplianceSkuCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkVirtualApplianceSkuVirtualApplianceSkusRestClient.GetAsync(Id.SubscriptionId, skuName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkVirtualApplianceSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves a single available sku for network virtual appliance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkVirtualApplianceSkus/{skuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSkus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkVirtualApplianceSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skuName"> Name of the Sku. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="skuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="skuName"/> is null. </exception>
        public virtual Response<NetworkVirtualApplianceSkuResource> Get(string skuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(skuName, nameof(skuName));

            using var scope = _networkVirtualApplianceSkuVirtualApplianceSkusClientDiagnostics.CreateScope("NetworkVirtualApplianceSkuCollection.Get");
            scope.Start();
            try
            {
                var response = _networkVirtualApplianceSkuVirtualApplianceSkusRestClient.Get(Id.SubscriptionId, skuName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkVirtualApplianceSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all SKUs available for a virtual appliance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkVirtualApplianceSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSkus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkVirtualApplianceSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkVirtualApplianceSkuResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkVirtualApplianceSkuResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkVirtualApplianceSkuVirtualApplianceSkusRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkVirtualApplianceSkuVirtualApplianceSkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkVirtualApplianceSkuResource(Client, NetworkVirtualApplianceSkuData.DeserializeNetworkVirtualApplianceSkuData(e)), _networkVirtualApplianceSkuVirtualApplianceSkusClientDiagnostics, Pipeline, "NetworkVirtualApplianceSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all SKUs available for a virtual appliance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkVirtualApplianceSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSkus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkVirtualApplianceSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkVirtualApplianceSkuResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkVirtualApplianceSkuResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkVirtualApplianceSkuVirtualApplianceSkusRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkVirtualApplianceSkuVirtualApplianceSkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkVirtualApplianceSkuResource(Client, NetworkVirtualApplianceSkuData.DeserializeNetworkVirtualApplianceSkuData(e)), _networkVirtualApplianceSkuVirtualApplianceSkusClientDiagnostics, Pipeline, "NetworkVirtualApplianceSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkVirtualApplianceSkus/{skuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSkus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkVirtualApplianceSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skuName"> Name of the Sku. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="skuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="skuName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string skuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(skuName, nameof(skuName));

            using var scope = _networkVirtualApplianceSkuVirtualApplianceSkusClientDiagnostics.CreateScope("NetworkVirtualApplianceSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkVirtualApplianceSkuVirtualApplianceSkusRestClient.GetAsync(Id.SubscriptionId, skuName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkVirtualApplianceSkus/{skuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSkus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkVirtualApplianceSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skuName"> Name of the Sku. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="skuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="skuName"/> is null. </exception>
        public virtual Response<bool> Exists(string skuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(skuName, nameof(skuName));

            using var scope = _networkVirtualApplianceSkuVirtualApplianceSkusClientDiagnostics.CreateScope("NetworkVirtualApplianceSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkVirtualApplianceSkuVirtualApplianceSkusRestClient.Get(Id.SubscriptionId, skuName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkVirtualApplianceSkus/{skuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSkus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkVirtualApplianceSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skuName"> Name of the Sku. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="skuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="skuName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkVirtualApplianceSkuResource>> GetIfExistsAsync(string skuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(skuName, nameof(skuName));

            using var scope = _networkVirtualApplianceSkuVirtualApplianceSkusClientDiagnostics.CreateScope("NetworkVirtualApplianceSkuCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkVirtualApplianceSkuVirtualApplianceSkusRestClient.GetAsync(Id.SubscriptionId, skuName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkVirtualApplianceSkuResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkVirtualApplianceSkuResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkVirtualApplianceSkus/{skuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualApplianceSkus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkVirtualApplianceSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skuName"> Name of the Sku. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="skuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="skuName"/> is null. </exception>
        public virtual NullableResponse<NetworkVirtualApplianceSkuResource> GetIfExists(string skuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(skuName, nameof(skuName));

            using var scope = _networkVirtualApplianceSkuVirtualApplianceSkusClientDiagnostics.CreateScope("NetworkVirtualApplianceSkuCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkVirtualApplianceSkuVirtualApplianceSkusRestClient.Get(Id.SubscriptionId, skuName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkVirtualApplianceSkuResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkVirtualApplianceSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkVirtualApplianceSkuResource> IEnumerable<NetworkVirtualApplianceSkuResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkVirtualApplianceSkuResource> IAsyncEnumerable<NetworkVirtualApplianceSkuResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
