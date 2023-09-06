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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.WorkloadMonitor
{
    /// <summary>
    /// A class representing a collection of <see cref="HealthMonitorStateChangeResource" /> and their operations.
    /// Each <see cref="HealthMonitorStateChangeResource" /> in the collection will belong to the same instance of <see cref="HealthMonitorResource" />.
    /// To get a <see cref="HealthMonitorStateChangeCollection" /> instance call the GetHealthMonitorStateChanges method from an instance of <see cref="HealthMonitorResource" />.
    /// </summary>
    public partial class HealthMonitorStateChangeCollection : ArmCollection, IEnumerable<HealthMonitorStateChangeResource>, IAsyncEnumerable<HealthMonitorStateChangeResource>
    {
        private readonly ClientDiagnostics _healthMonitorStateChangeHealthMonitorsClientDiagnostics;
        private readonly HealthMonitorsRestOperations _healthMonitorStateChangeHealthMonitorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HealthMonitorStateChangeCollection"/> class for mocking. </summary>
        protected HealthMonitorStateChangeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HealthMonitorStateChangeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HealthMonitorStateChangeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _healthMonitorStateChangeHealthMonitorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.WorkloadMonitor", HealthMonitorStateChangeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HealthMonitorStateChangeResource.ResourceType, out string healthMonitorStateChangeHealthMonitorsApiVersion);
            _healthMonitorStateChangeHealthMonitorsRestClient = new HealthMonitorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, healthMonitorStateChangeHealthMonitorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HealthMonitorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HealthMonitorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the health state change of a monitor of a virtual machine at the provided timestamp. Optional parameter: $expand (retrieve the monitor's evidence and configuration).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}/history/{timestampUnix}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_GetStateChange</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="timestampUnix"> The timestamp of the state change (unix format). </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timestampUnix"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timestampUnix"/> is null. </exception>
        public virtual async Task<Response<HealthMonitorStateChangeResource>> GetAsync(string timestampUnix, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timestampUnix, nameof(timestampUnix));

            using var scope = _healthMonitorStateChangeHealthMonitorsClientDiagnostics.CreateScope("HealthMonitorStateChangeCollection.Get");
            scope.Start();
            try
            {
                var response = await _healthMonitorStateChangeHealthMonitorsRestClient.GetStateChangeAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, timestampUnix, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HealthMonitorStateChangeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the health state change of a monitor of a virtual machine at the provided timestamp. Optional parameter: $expand (retrieve the monitor's evidence and configuration).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}/history/{timestampUnix}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_GetStateChange</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="timestampUnix"> The timestamp of the state change (unix format). </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timestampUnix"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timestampUnix"/> is null. </exception>
        public virtual Response<HealthMonitorStateChangeResource> Get(string timestampUnix, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timestampUnix, nameof(timestampUnix));

            using var scope = _healthMonitorStateChangeHealthMonitorsClientDiagnostics.CreateScope("HealthMonitorStateChangeCollection.Get");
            scope.Start();
            try
            {
                var response = _healthMonitorStateChangeHealthMonitorsRestClient.GetStateChange(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, timestampUnix, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HealthMonitorStateChangeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the health state changes of a monitor of a virtual machine within the provided time window (default is the last 24 hours). Optional parameters: $expand (retrieve the monitor's evidence and configuration) and $filter (filter by heartbeat condition).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}/history</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_ListStateChanges</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Optionally filter by heartbeat condition. Example: $filter=isHeartbeat eq false. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="startTimestampUtc"> The start of the time window. </param>
        /// <param name="endTimestampUtc"> The end of the time window. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HealthMonitorStateChangeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HealthMonitorStateChangeResource> GetAllAsync(string filter = null, string expand = null, DateTimeOffset? startTimestampUtc = null, DateTimeOffset? endTimestampUtc = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _healthMonitorStateChangeHealthMonitorsRestClient.CreateListStateChangesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, filter, expand, startTimestampUtc, endTimestampUtc);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _healthMonitorStateChangeHealthMonitorsRestClient.CreateListStateChangesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, filter, expand, startTimestampUtc, endTimestampUtc);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new HealthMonitorStateChangeResource(Client, HealthMonitorStateChangeData.DeserializeHealthMonitorStateChangeData(e)), _healthMonitorStateChangeHealthMonitorsClientDiagnostics, Pipeline, "HealthMonitorStateChangeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the health state changes of a monitor of a virtual machine within the provided time window (default is the last 24 hours). Optional parameters: $expand (retrieve the monitor's evidence and configuration) and $filter (filter by heartbeat condition).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}/history</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_ListStateChanges</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Optionally filter by heartbeat condition. Example: $filter=isHeartbeat eq false. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="startTimestampUtc"> The start of the time window. </param>
        /// <param name="endTimestampUtc"> The end of the time window. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HealthMonitorStateChangeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HealthMonitorStateChangeResource> GetAll(string filter = null, string expand = null, DateTimeOffset? startTimestampUtc = null, DateTimeOffset? endTimestampUtc = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _healthMonitorStateChangeHealthMonitorsRestClient.CreateListStateChangesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, filter, expand, startTimestampUtc, endTimestampUtc);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _healthMonitorStateChangeHealthMonitorsRestClient.CreateListStateChangesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, filter, expand, startTimestampUtc, endTimestampUtc);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new HealthMonitorStateChangeResource(Client, HealthMonitorStateChangeData.DeserializeHealthMonitorStateChangeData(e)), _healthMonitorStateChangeHealthMonitorsClientDiagnostics, Pipeline, "HealthMonitorStateChangeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}/history/{timestampUnix}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_GetStateChange</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="timestampUnix"> The timestamp of the state change (unix format). </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timestampUnix"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timestampUnix"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string timestampUnix, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timestampUnix, nameof(timestampUnix));

            using var scope = _healthMonitorStateChangeHealthMonitorsClientDiagnostics.CreateScope("HealthMonitorStateChangeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _healthMonitorStateChangeHealthMonitorsRestClient.GetStateChangeAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, timestampUnix, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}/history/{timestampUnix}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_GetStateChange</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="timestampUnix"> The timestamp of the state change (unix format). </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timestampUnix"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timestampUnix"/> is null. </exception>
        public virtual Response<bool> Exists(string timestampUnix, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timestampUnix, nameof(timestampUnix));

            using var scope = _healthMonitorStateChangeHealthMonitorsClientDiagnostics.CreateScope("HealthMonitorStateChangeCollection.Exists");
            scope.Start();
            try
            {
                var response = _healthMonitorStateChangeHealthMonitorsRestClient.GetStateChange(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, timestampUnix, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HealthMonitorStateChangeResource> IEnumerable<HealthMonitorStateChangeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HealthMonitorStateChangeResource> IAsyncEnumerable<HealthMonitorStateChangeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
