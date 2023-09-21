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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteRecoveryEventResource" /> and their operations.
    /// Each <see cref="SiteRecoveryEventResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="SiteRecoveryEventCollection" /> instance call the GetSiteRecoveryEvents method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class SiteRecoveryEventCollection : ArmCollection, IEnumerable<SiteRecoveryEventResource>, IAsyncEnumerable<SiteRecoveryEventResource>
    {
        private readonly ClientDiagnostics _siteRecoveryEventReplicationEventsClientDiagnostics;
        private readonly ReplicationEventsRestOperations _siteRecoveryEventReplicationEventsRestClient;
        private readonly string _resourceName;

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryEventCollection"/> class for mocking. </summary>
        protected SiteRecoveryEventCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryEventCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal SiteRecoveryEventCollection(ArmClient client, ResourceIdentifier id, string resourceName) : base(client, id)
        {
            _resourceName = resourceName;
            _siteRecoveryEventReplicationEventsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", SiteRecoveryEventResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteRecoveryEventResource.ResourceType, out string siteRecoveryEventReplicationEventsApiVersion);
            _siteRecoveryEventReplicationEventsRestClient = new ReplicationEventsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecoveryEventReplicationEventsApiVersion);
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
        /// The operation to get the details of an Azure Site recovery event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationEvents/{eventName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationEvents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventName"> The name of the Azure Site Recovery event. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventName"/> is null. </exception>
        public virtual async Task<Response<SiteRecoveryEventResource>> GetAsync(string eventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventName, nameof(eventName));

            using var scope = _siteRecoveryEventReplicationEventsClientDiagnostics.CreateScope("SiteRecoveryEventCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteRecoveryEventReplicationEventsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, eventName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the details of an Azure Site recovery event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationEvents/{eventName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationEvents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventName"> The name of the Azure Site Recovery event. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventName"/> is null. </exception>
        public virtual Response<SiteRecoveryEventResource> Get(string eventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventName, nameof(eventName));

            using var scope = _siteRecoveryEventReplicationEventsClientDiagnostics.CreateScope("SiteRecoveryEventCollection.Get");
            scope.Start();
            try
            {
                var response = _siteRecoveryEventReplicationEventsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, eventName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of Azure Site Recovery events for the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationEvents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationEvents_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteRecoveryEventResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteRecoveryEventResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryEventReplicationEventsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryEventReplicationEventsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryEventResource(Client, SiteRecoveryEventData.DeserializeSiteRecoveryEventData(e)), _siteRecoveryEventReplicationEventsClientDiagnostics, Pipeline, "SiteRecoveryEventCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of Azure Site Recovery events for the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationEvents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationEvents_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteRecoveryEventResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteRecoveryEventResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryEventReplicationEventsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryEventReplicationEventsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryEventResource(Client, SiteRecoveryEventData.DeserializeSiteRecoveryEventData(e)), _siteRecoveryEventReplicationEventsClientDiagnostics, Pipeline, "SiteRecoveryEventCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationEvents/{eventName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationEvents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventName"> The name of the Azure Site Recovery event. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string eventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventName, nameof(eventName));

            using var scope = _siteRecoveryEventReplicationEventsClientDiagnostics.CreateScope("SiteRecoveryEventCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryEventReplicationEventsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, eventName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationEvents/{eventName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationEvents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventName"> The name of the Azure Site Recovery event. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventName"/> is null. </exception>
        public virtual Response<bool> Exists(string eventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventName, nameof(eventName));

            using var scope = _siteRecoveryEventReplicationEventsClientDiagnostics.CreateScope("SiteRecoveryEventCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteRecoveryEventReplicationEventsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, eventName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationEvents/{eventName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationEvents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventName"> The name of the Azure Site Recovery event. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventName"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteRecoveryEventResource>> GetIfExistsAsync(string eventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventName, nameof(eventName));

            using var scope = _siteRecoveryEventReplicationEventsClientDiagnostics.CreateScope("SiteRecoveryEventCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryEventReplicationEventsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, eventName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryEventResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryEventResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationEvents/{eventName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationEvents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventName"> The name of the Azure Site Recovery event. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventName"/> is null. </exception>
        public virtual NullableResponse<SiteRecoveryEventResource> GetIfExists(string eventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventName, nameof(eventName));

            using var scope = _siteRecoveryEventReplicationEventsClientDiagnostics.CreateScope("SiteRecoveryEventCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteRecoveryEventReplicationEventsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, eventName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryEventResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteRecoveryEventResource> IEnumerable<SiteRecoveryEventResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteRecoveryEventResource> IAsyncEnumerable<SiteRecoveryEventResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
