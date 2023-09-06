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
    /// A class representing a collection of <see cref="SiteDiagnosticAnalysisResource" /> and their operations.
    /// Each <see cref="SiteDiagnosticAnalysisResource" /> in the collection will belong to the same instance of <see cref="SiteDiagnosticResource" />.
    /// To get a <see cref="SiteDiagnosticAnalysisCollection" /> instance call the GetSiteDiagnosticAnalyses method from an instance of <see cref="SiteDiagnosticResource" />.
    /// </summary>
    public partial class SiteDiagnosticAnalysisCollection : ArmCollection, IEnumerable<SiteDiagnosticAnalysisResource>, IAsyncEnumerable<SiteDiagnosticAnalysisResource>
    {
        private readonly ClientDiagnostics _siteDiagnosticAnalysisDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteDiagnosticAnalysisDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteDiagnosticAnalysisCollection"/> class for mocking. </summary>
        protected SiteDiagnosticAnalysisCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteDiagnosticAnalysisCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteDiagnosticAnalysisCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteDiagnosticAnalysisDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteDiagnosticAnalysisResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteDiagnosticAnalysisResource.ResourceType, out string siteDiagnosticAnalysisDiagnosticsApiVersion);
            _siteDiagnosticAnalysisDiagnosticsRestClient = new DiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteDiagnosticAnalysisDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteDiagnosticResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteDiagnosticResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get Site Analysis
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses/{analysisName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteAnalysis</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public virtual async Task<Response<SiteDiagnosticAnalysisResource>> GetAsync(string analysisName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(analysisName, nameof(analysisName));

            using var scope = _siteDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticAnalysisCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysisAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, analysisName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnosticAnalysisResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses/{analysisName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteAnalysis</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public virtual Response<SiteDiagnosticAnalysisResource> Get(string analysisName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(analysisName, nameof(analysisName));

            using var scope = _siteDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticAnalysisCollection.Get");
            scope.Start();
            try
            {
                var response = _siteDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysis(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, analysisName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnosticAnalysisResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_ListSiteAnalyses</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteDiagnosticAnalysisResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteDiagnosticAnalysisResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteDiagnosticAnalysisDiagnosticsRestClient.CreateListSiteAnalysesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteDiagnosticAnalysisDiagnosticsRestClient.CreateListSiteAnalysesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SiteDiagnosticAnalysisResource(Client, WebSiteAnalysisDefinitionData.DeserializeWebSiteAnalysisDefinitionData(e)), _siteDiagnosticAnalysisDiagnosticsClientDiagnostics, Pipeline, "SiteDiagnosticAnalysisCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get Site Analyses
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_ListSiteAnalyses</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteDiagnosticAnalysisResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteDiagnosticAnalysisResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteDiagnosticAnalysisDiagnosticsRestClient.CreateListSiteAnalysesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteDiagnosticAnalysisDiagnosticsRestClient.CreateListSiteAnalysesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SiteDiagnosticAnalysisResource(Client, WebSiteAnalysisDefinitionData.DeserializeWebSiteAnalysisDefinitionData(e)), _siteDiagnosticAnalysisDiagnosticsClientDiagnostics, Pipeline, "SiteDiagnosticAnalysisCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses/{analysisName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteAnalysis</description>
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

            using var scope = _siteDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticAnalysisCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysisAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, analysisName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses/{analysisName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Diagnostics_GetSiteAnalysis</description>
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

            using var scope = _siteDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticAnalysisCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysis(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, analysisName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteDiagnosticAnalysisResource> IEnumerable<SiteDiagnosticAnalysisResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteDiagnosticAnalysisResource> IAsyncEnumerable<SiteDiagnosticAnalysisResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
