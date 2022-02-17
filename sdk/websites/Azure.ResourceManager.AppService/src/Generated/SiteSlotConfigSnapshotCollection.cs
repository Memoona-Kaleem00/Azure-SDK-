// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of SiteSlotConfigSnapshot and their operations over its parent. </summary>
    public partial class SiteSlotConfigSnapshotCollection : ArmCollection
    {
        private readonly ClientDiagnostics _siteSlotConfigSnapshotWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotConfigSnapshotWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotConfigSnapshotCollection"/> class for mocking. </summary>
        protected SiteSlotConfigSnapshotCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotConfigSnapshotCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotConfigSnapshotCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotConfigSnapshotWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotConfigSnapshot.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SiteSlotConfigSnapshot.ResourceType, out string siteSlotConfigSnapshotWebAppsApiVersion);
            _siteSlotConfigSnapshotWebAppsRestClient = new WebAppsRestOperations(_siteSlotConfigSnapshotWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSlotConfigSnapshotWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != "Microsoft.Web/sites/slots/config")
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, "Microsoft.Web/sites/slots/config"), nameof(id));
        }

        /// <summary>
        /// Description for Gets a snapshot of the configuration of an app at a previous point in time.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web/snapshots/{snapshotId}
        /// Operation Id: WebApps_GetConfigurationSnapshotSlot
        /// </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        public async virtual Task<Response<SiteSlotConfigSnapshot>> GetAsync(string snapshotId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotId, nameof(snapshotId));

            using var scope = _siteSlotConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteSlotConfigSnapshotCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotConfigSnapshotWebAppsRestClient.GetConfigurationSnapshotSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, snapshotId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteSlotConfigSnapshotWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotConfigSnapshot(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a snapshot of the configuration of an app at a previous point in time.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web/snapshots/{snapshotId}
        /// Operation Id: WebApps_GetConfigurationSnapshotSlot
        /// </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        public virtual Response<SiteSlotConfigSnapshot> Get(string snapshotId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotId, nameof(snapshotId));

            using var scope = _siteSlotConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteSlotConfigSnapshotCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotConfigSnapshotWebAppsRestClient.GetConfigurationSnapshotSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, snapshotId, cancellationToken);
                if (response.Value == null)
                    throw _siteSlotConfigSnapshotWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotConfigSnapshot(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web/snapshots/{snapshotId}
        /// Operation Id: WebApps_GetConfigurationSnapshotSlot
        /// </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string snapshotId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotId, nameof(snapshotId));

            using var scope = _siteSlotConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteSlotConfigSnapshotCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(snapshotId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web/snapshots/{snapshotId}
        /// Operation Id: WebApps_GetConfigurationSnapshotSlot
        /// </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        public virtual Response<bool> Exists(string snapshotId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotId, nameof(snapshotId));

            using var scope = _siteSlotConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteSlotConfigSnapshotCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(snapshotId, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web/snapshots/{snapshotId}
        /// Operation Id: WebApps_GetConfigurationSnapshotSlot
        /// </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        public async virtual Task<Response<SiteSlotConfigSnapshot>> GetIfExistsAsync(string snapshotId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotId, nameof(snapshotId));

            using var scope = _siteSlotConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteSlotConfigSnapshotCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotConfigSnapshotWebAppsRestClient.GetConfigurationSnapshotSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, snapshotId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotConfigSnapshot>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotConfigSnapshot(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/web/snapshots/{snapshotId}
        /// Operation Id: WebApps_GetConfigurationSnapshotSlot
        /// </summary>
        /// <param name="snapshotId"> The ID of the snapshot to read. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotId"/> is null. </exception>
        public virtual Response<SiteSlotConfigSnapshot> GetIfExists(string snapshotId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotId, nameof(snapshotId));

            using var scope = _siteSlotConfigSnapshotWebAppsClientDiagnostics.CreateScope("SiteSlotConfigSnapshotCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotConfigSnapshotWebAppsRestClient.GetConfigurationSnapshotSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, snapshotId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotConfigSnapshot>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotConfigSnapshot(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
