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

namespace Azure.ResourceManager.PrivateDns
{
    /// <summary>
    /// A class representing a collection of <see cref="PrivateDnsZoneResource"/> and their operations.
    /// Each <see cref="PrivateDnsZoneResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="PrivateDnsZoneCollection"/> instance call the GetPrivateDnsZones method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class PrivateDnsZoneCollection : ArmCollection, IEnumerable<PrivateDnsZoneResource>, IAsyncEnumerable<PrivateDnsZoneResource>
    {
        private readonly ClientDiagnostics _privateDnsZonePrivateZonesClientDiagnostics;
        private readonly PrivateZonesRestOperations _privateDnsZonePrivateZonesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateDnsZoneCollection"/> class for mocking. </summary>
        protected PrivateDnsZoneCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateDnsZoneCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PrivateDnsZoneCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateDnsZonePrivateZonesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PrivateDns", PrivateDnsZoneResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PrivateDnsZoneResource.ResourceType, out string privateDnsZonePrivateZonesApiVersion);
            _privateDnsZonePrivateZonesRestClient = new PrivateZonesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, privateDnsZonePrivateZonesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Private DNS zone. Does not modify Links to virtual networks or DNS records within the zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PrivateDnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateZoneName"> The name of the Private DNS zone (without a terminating dot). </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> The ETag of the Private DNS zone. Omit this value to always overwrite the current zone. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new Private DNS zone to be created, but to prevent updating an existing zone. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateZoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateZoneName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PrivateDnsZoneResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateZoneName, PrivateDnsZoneData data, ETag? ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateZoneName, nameof(privateZoneName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateDnsZonePrivateZonesClientDiagnostics.CreateScope("PrivateDnsZoneCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _privateDnsZonePrivateZonesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, privateZoneName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new PrivateDnsArmOperation<PrivateDnsZoneResource>(new PrivateDnsZoneOperationSource(Client), _privateDnsZonePrivateZonesClientDiagnostics, Pipeline, _privateDnsZonePrivateZonesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, privateZoneName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
        /// Creates or updates a Private DNS zone. Does not modify Links to virtual networks or DNS records within the zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PrivateDnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateZoneName"> The name of the Private DNS zone (without a terminating dot). </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> The ETag of the Private DNS zone. Omit this value to always overwrite the current zone. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to '*' to allow a new Private DNS zone to be created, but to prevent updating an existing zone. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateZoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateZoneName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PrivateDnsZoneResource> CreateOrUpdate(WaitUntil waitUntil, string privateZoneName, PrivateDnsZoneData data, ETag? ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateZoneName, nameof(privateZoneName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateDnsZonePrivateZonesClientDiagnostics.CreateScope("PrivateDnsZoneCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _privateDnsZonePrivateZonesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, privateZoneName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new PrivateDnsArmOperation<PrivateDnsZoneResource>(new PrivateDnsZoneOperationSource(Client), _privateDnsZonePrivateZonesClientDiagnostics, Pipeline, _privateDnsZonePrivateZonesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, privateZoneName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
        /// Gets a Private DNS zone. Retrieves the zone properties, but not the virtual networks links or the record sets within the zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PrivateDnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateZoneName"> The name of the Private DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateZoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateZoneName"/> is null. </exception>
        public virtual async Task<Response<PrivateDnsZoneResource>> GetAsync(string privateZoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateZoneName, nameof(privateZoneName));

            using var scope = _privateDnsZonePrivateZonesClientDiagnostics.CreateScope("PrivateDnsZoneCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateDnsZonePrivateZonesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, privateZoneName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateDnsZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Private DNS zone. Retrieves the zone properties, but not the virtual networks links or the record sets within the zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PrivateDnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateZoneName"> The name of the Private DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateZoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateZoneName"/> is null. </exception>
        public virtual Response<PrivateDnsZoneResource> Get(string privateZoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateZoneName, nameof(privateZoneName));

            using var scope = _privateDnsZonePrivateZonesClientDiagnostics.CreateScope("PrivateDnsZoneCollection.Get");
            scope.Start();
            try
            {
                var response = _privateDnsZonePrivateZonesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, privateZoneName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateDnsZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Private DNS zones within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PrivateDnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of record sets to return. If not specified, returns up to 100 record sets. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateDnsZoneResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateDnsZoneResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _privateDnsZonePrivateZonesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _privateDnsZonePrivateZonesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PrivateDnsZoneResource(Client, PrivateDnsZoneData.DeserializePrivateDnsZoneData(e)), _privateDnsZonePrivateZonesClientDiagnostics, Pipeline, "PrivateDnsZoneCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Private DNS zones within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PrivateDnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of record sets to return. If not specified, returns up to 100 record sets. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateDnsZoneResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateDnsZoneResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _privateDnsZonePrivateZonesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _privateDnsZonePrivateZonesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PrivateDnsZoneResource(Client, PrivateDnsZoneData.DeserializePrivateDnsZoneData(e)), _privateDnsZonePrivateZonesClientDiagnostics, Pipeline, "PrivateDnsZoneCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PrivateDnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateZoneName"> The name of the Private DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateZoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateZoneName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateZoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateZoneName, nameof(privateZoneName));

            using var scope = _privateDnsZonePrivateZonesClientDiagnostics.CreateScope("PrivateDnsZoneCollection.Exists");
            scope.Start();
            try
            {
                var response = await _privateDnsZonePrivateZonesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, privateZoneName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PrivateDnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateZoneName"> The name of the Private DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateZoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateZoneName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateZoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateZoneName, nameof(privateZoneName));

            using var scope = _privateDnsZonePrivateZonesClientDiagnostics.CreateScope("PrivateDnsZoneCollection.Exists");
            scope.Start();
            try
            {
                var response = _privateDnsZonePrivateZonesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, privateZoneName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PrivateDnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateZoneName"> The name of the Private DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateZoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateZoneName"/> is null. </exception>
        public virtual async Task<NullableResponse<PrivateDnsZoneResource>> GetIfExistsAsync(string privateZoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateZoneName, nameof(privateZoneName));

            using var scope = _privateDnsZonePrivateZonesClientDiagnostics.CreateScope("PrivateDnsZoneCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _privateDnsZonePrivateZonesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, privateZoneName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PrivateDnsZoneResource>(response.GetRawResponse());
                return Response.FromValue(new PrivateDnsZoneResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PrivateDnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateZoneName"> The name of the Private DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateZoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateZoneName"/> is null. </exception>
        public virtual NullableResponse<PrivateDnsZoneResource> GetIfExists(string privateZoneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateZoneName, nameof(privateZoneName));

            using var scope = _privateDnsZonePrivateZonesClientDiagnostics.CreateScope("PrivateDnsZoneCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _privateDnsZonePrivateZonesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, privateZoneName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PrivateDnsZoneResource>(response.GetRawResponse());
                return Response.FromValue(new PrivateDnsZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PrivateDnsZoneResource> IEnumerable<PrivateDnsZoneResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateDnsZoneResource> IAsyncEnumerable<PrivateDnsZoneResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
