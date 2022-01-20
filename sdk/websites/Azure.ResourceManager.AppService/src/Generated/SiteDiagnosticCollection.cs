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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of DiagnosticCategory and their operations over its parent. </summary>
    public partial class SiteDiagnosticCollection : ArmCollection, IEnumerable<SiteDiagnostic>, IAsyncEnumerable<SiteDiagnostic>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DiagnosticsRestOperations _diagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteDiagnosticCollection"/> class for mocking. </summary>
        protected SiteDiagnosticCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteDiagnosticCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteDiagnosticCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SiteDiagnostic.ResourceType, out string apiVersion);
            _diagnosticsRestClient = new DiagnosticsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: Diagnostics_GetSiteDiagnosticCategory
        /// <summary> Description for Get Diagnostics Category. </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual Response<SiteDiagnostic> Get(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            if (diagnosticCategory == null)
            {
                throw new ArgumentNullException(nameof(diagnosticCategory));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = _diagnosticsRestClient.GetSiteDiagnosticCategory(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticCategory, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnostic(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: Diagnostics_GetSiteDiagnosticCategory
        /// <summary> Description for Get Diagnostics Category. </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public async virtual Task<Response<SiteDiagnostic>> GetAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            if (diagnosticCategory == null)
            {
                throw new ArgumentNullException(nameof(diagnosticCategory));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = await _diagnosticsRestClient.GetSiteDiagnosticCategoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticCategory, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteDiagnostic(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual Response<SiteDiagnostic> GetIfExists(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            if (diagnosticCategory == null)
            {
                throw new ArgumentNullException(nameof(diagnosticCategory));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diagnosticsRestClient.GetSiteDiagnosticCategory(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticCategory, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteDiagnostic>(null, response.GetRawResponse());
                return Response.FromValue(new SiteDiagnostic(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public async virtual Task<Response<SiteDiagnostic>> GetIfExistsAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            if (diagnosticCategory == null)
            {
                throw new ArgumentNullException(nameof(diagnosticCategory));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _diagnosticsRestClient.GetSiteDiagnosticCategoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, diagnosticCategory, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteDiagnostic>(null, response.GetRawResponse());
                return Response.FromValue(new SiteDiagnostic(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual Response<bool> Exists(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            if (diagnosticCategory == null)
            {
                throw new ArgumentNullException(nameof(diagnosticCategory));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(diagnosticCategory, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            if (diagnosticCategory == null)
            {
                throw new ArgumentNullException(nameof(diagnosticCategory));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(diagnosticCategory, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: Diagnostics_ListSiteDiagnosticCategories
        /// <summary> Description for Get Diagnostics Categories. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteDiagnostic" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteDiagnostic> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteDiagnostic> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diagnosticsRestClient.ListSiteDiagnosticCategories(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDiagnostic(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteDiagnostic> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diagnosticsRestClient.ListSiteDiagnosticCategoriesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDiagnostic(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: Diagnostics_ListSiteDiagnosticCategories
        /// <summary> Description for Get Diagnostics Categories. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteDiagnostic" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteDiagnostic> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteDiagnostic>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diagnosticsRestClient.ListSiteDiagnosticCategoriesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDiagnostic(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteDiagnostic>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diagnosticsRestClient.ListSiteDiagnosticCategoriesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDiagnostic(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteDiagnostic> IEnumerable<SiteDiagnostic>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteDiagnostic> IAsyncEnumerable<SiteDiagnostic>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteDiagnostic, DiagnosticCategoryData> Construct() { }
    }
}
