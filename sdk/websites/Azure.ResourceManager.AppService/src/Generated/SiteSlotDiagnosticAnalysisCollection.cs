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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteSlotDiagnosticAnalysisResource" /> and their operations.
    /// Each <see cref="SiteSlotDiagnosticAnalysisResource" /> in the collection will belong to the same instance of <see cref="SiteSlotDiagnosticResource" />.
    /// To get a <see cref="SiteSlotDiagnosticAnalysisCollection" /> instance call the GetSiteSlotDiagnosticAnalyses method from an instance of <see cref="SiteSlotDiagnosticResource" />.
    /// </summary>
    public partial class SiteSlotDiagnosticAnalysisCollection : ArmCollection, IEnumerable<SiteSlotDiagnosticAnalysisResource>, IAsyncEnumerable<SiteSlotDiagnosticAnalysisResource>
    {
        private readonly ClientDiagnostics _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteSlotDiagnosticAnalysisDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticAnalysisCollection"/> class for mocking. </summary>
        protected SiteSlotDiagnosticAnalysisCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticAnalysisCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotDiagnosticAnalysisCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotDiagnosticAnalysisResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotDiagnosticAnalysisResource.ResourceType, out string siteSlotDiagnosticAnalysisDiagnosticsApiVersion);
            _siteSlotDiagnosticAnalysisDiagnosticsRestClient = new DiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotDiagnosticAnalysisDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlotDiagnosticResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlotDiagnosticResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get Site Analysis
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteAnalysisSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotDiagnosticAnalysisResource>> GetAsync(string analysisName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(analysisName, nameof(analysisName));

            using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysisSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, analysisName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticAnalysisResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Site Analysis
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteAnalysisSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public virtual Response<SiteSlotDiagnosticAnalysisResource> Get(string analysisName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(analysisName, nameof(analysisName));

            using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysisSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, analysisName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticAnalysisResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Site Analyses
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_ListSiteAnalysesSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotDiagnosticAnalysisResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotDiagnosticAnalysisResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteSlotDiagnosticAnalysisDiagnosticsRestClient.CreateListSiteAnalysesSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteSlotDiagnosticAnalysisDiagnosticsRestClient.CreateListSiteAnalysesSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SiteSlotDiagnosticAnalysisResource(Client, WebSiteAnalysisDefinitionData.DeserializeWebSiteAnalysisDefinitionData(e)), _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics, Pipeline, "SiteSlotDiagnosticAnalysisCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get Site Analyses
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_ListSiteAnalysesSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotDiagnosticAnalysisResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotDiagnosticAnalysisResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteSlotDiagnosticAnalysisDiagnosticsRestClient.CreateListSiteAnalysesSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteSlotDiagnosticAnalysisDiagnosticsRestClient.CreateListSiteAnalysesSlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SiteSlotDiagnosticAnalysisResource(Client, WebSiteAnalysisDefinitionData.DeserializeWebSiteAnalysisDefinitionData(e)), _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics, Pipeline, "SiteSlotDiagnosticAnalysisCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteAnalysisSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string analysisName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(analysisName, nameof(analysisName));

            using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysisSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, analysisName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteAnalysisSlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public virtual Response<bool> Exists(string analysisName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(analysisName, nameof(analysisName));

            using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysisSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, analysisName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotDiagnosticAnalysisResource> IEnumerable<SiteSlotDiagnosticAnalysisResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotDiagnosticAnalysisResource> IAsyncEnumerable<SiteSlotDiagnosticAnalysisResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
