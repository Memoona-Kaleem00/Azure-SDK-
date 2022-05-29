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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteDetectorResource" /> and their operations.
    /// Each <see cref="SiteDetectorResource" /> in the collection will belong to the same instance of <see cref="WebSiteResource" />.
    /// To get a <see cref="SiteDetectorCollection" /> instance call the GetSiteDetectors method from an instance of <see cref="WebSiteResource" />.
    /// </summary>
    public partial class SiteDetectorCollection : ArmCollection, IEnumerable<SiteDetectorResource>, IAsyncEnumerable<SiteDetectorResource>
    {
        private readonly ClientDiagnostics _siteDetectorDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteDetectorDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteDetectorCollection"/> class for mocking. </summary>
        protected SiteDetectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteDetectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteDetectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteDetectorDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteDetectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteDetectorResource.ResourceType, out string siteDetectorDiagnosticsApiVersion);
            _siteDetectorDiagnosticsRestClient = new DiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteDetectorDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get site detector response
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetectorResponse
        /// </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="options"> A class representing the optional parameters in Get method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<Response<SiteDetectorResource>> GetAsync(string detectorName, SiteDetectorGetOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));
            options ??= new SiteDetectorGetOptions();

            using var scope = _siteDetectorDiagnosticsClientDiagnostics.CreateScope("SiteDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteDetectorDiagnosticsRestClient.GetSiteDetectorResponseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, options.StartTime, options.EndTime, options.TimeGrain, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get site detector response
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetectorResponse
        /// </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="options"> A class representing the optional parameters in Get method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<SiteDetectorResource> Get(string detectorName, SiteDetectorGetOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));
            options ??= new SiteDetectorGetOptions();

            using var scope = _siteDetectorDiagnosticsClientDiagnostics.CreateScope("SiteDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = _siteDetectorDiagnosticsRestClient.GetSiteDetectorResponse(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, options.StartTime, options.EndTime, options.TimeGrain, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List Site Detector Responses
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/detectors
        /// Operation Id: Diagnostics_ListSiteDetectorResponses
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteDetectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteDetectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteDetectorResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteDetectorDiagnosticsClientDiagnostics.CreateScope("SiteDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteDetectorDiagnosticsRestClient.ListSiteDetectorResponsesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDetectorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteDetectorResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteDetectorDiagnosticsClientDiagnostics.CreateScope("SiteDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteDetectorDiagnosticsRestClient.ListSiteDetectorResponsesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDetectorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Description for List Site Detector Responses
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/detectors
        /// Operation Id: Diagnostics_ListSiteDetectorResponses
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteDetectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteDetectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteDetectorResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteDetectorDiagnosticsClientDiagnostics.CreateScope("SiteDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteDetectorDiagnosticsRestClient.ListSiteDetectorResponses(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDetectorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteDetectorResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteDetectorDiagnosticsClientDiagnostics.CreateScope("SiteDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteDetectorDiagnosticsRestClient.ListSiteDetectorResponsesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDetectorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetectorResponse
        /// </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="options"> A class representing the optional parameters in Get method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string detectorName, SiteDetectorGetOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));
            options ??= new SiteDetectorGetOptions();

            using var scope = _siteDetectorDiagnosticsClientDiagnostics.CreateScope("SiteDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteDetectorDiagnosticsRestClient.GetSiteDetectorResponseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, options.StartTime, options.EndTime, options.TimeGrain, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetectorResponse
        /// </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="options"> A class representing the optional parameters in Get method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string detectorName, SiteDetectorGetOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));
            options ??= new SiteDetectorGetOptions();

            using var scope = _siteDetectorDiagnosticsClientDiagnostics.CreateScope("SiteDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteDetectorDiagnosticsRestClient.GetSiteDetectorResponse(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, options.StartTime, options.EndTime, options.TimeGrain, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteDetectorResource> IEnumerable<SiteDetectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteDetectorResource> IAsyncEnumerable<SiteDetectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
