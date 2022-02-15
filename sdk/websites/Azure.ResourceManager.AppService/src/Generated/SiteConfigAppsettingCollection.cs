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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of SiteConfigAppsetting and their operations over its parent. </summary>
    public partial class SiteConfigAppsettingCollection : ArmCollection, IEnumerable<SiteConfigAppsetting>, IAsyncEnumerable<SiteConfigAppsetting>
    {
        private readonly ClientDiagnostics _siteConfigAppsettingWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteConfigAppsettingWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteConfigAppsettingCollection"/> class for mocking. </summary>
        protected SiteConfigAppsettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteConfigAppsettingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteConfigAppsettingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteConfigAppsettingWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteConfigAppsetting.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SiteConfigAppsetting.ResourceType, out string siteConfigAppsettingWebAppsApiVersion);
            _siteConfigAppsettingWebAppsRestClient = new WebAppsRestOperations(_siteConfigAppsettingWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteConfigAppsettingWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets the config reference and status of an app
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}
        /// Operation Id: WebApps_GetAppSettingKeyVaultReference
        /// </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettingKey"/> is null. </exception>
        public async virtual Task<Response<SiteConfigAppsetting>> GetAsync(string appSettingKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appSettingKey, nameof(appSettingKey));

            using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteConfigAppsettingWebAppsRestClient.GetAppSettingKeyVaultReferenceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appSettingKey, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteConfigAppsettingWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteConfigAppsetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the config reference and status of an app
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}
        /// Operation Id: WebApps_GetAppSettingKeyVaultReference
        /// </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettingKey"/> is null. </exception>
        public virtual Response<SiteConfigAppsetting> Get(string appSettingKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appSettingKey, nameof(appSettingKey));

            using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.Get");
            scope.Start();
            try
            {
                var response = _siteConfigAppsettingWebAppsRestClient.GetAppSettingKeyVaultReference(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appSettingKey, cancellationToken);
                if (response.Value == null)
                    throw _siteConfigAppsettingWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteConfigAppsetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the config reference app settings and status of an app
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings
        /// Operation Id: WebApps_GetAppSettingsKeyVaultReferences
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteConfigAppsetting" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteConfigAppsetting> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteConfigAppsetting>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteConfigAppsettingWebAppsRestClient.GetAppSettingsKeyVaultReferencesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteConfigAppsetting(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteConfigAppsetting>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteConfigAppsettingWebAppsRestClient.GetAppSettingsKeyVaultReferencesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteConfigAppsetting(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Gets the config reference app settings and status of an app
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings
        /// Operation Id: WebApps_GetAppSettingsKeyVaultReferences
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteConfigAppsetting" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteConfigAppsetting> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteConfigAppsetting> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteConfigAppsettingWebAppsRestClient.GetAppSettingsKeyVaultReferences(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteConfigAppsetting(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteConfigAppsetting> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteConfigAppsettingWebAppsRestClient.GetAppSettingsKeyVaultReferencesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteConfigAppsetting(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}
        /// Operation Id: WebApps_GetAppSettingKeyVaultReference
        /// </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettingKey"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string appSettingKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appSettingKey, nameof(appSettingKey));

            using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(appSettingKey, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}
        /// Operation Id: WebApps_GetAppSettingKeyVaultReference
        /// </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettingKey"/> is null. </exception>
        public virtual Response<bool> Exists(string appSettingKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appSettingKey, nameof(appSettingKey));

            using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(appSettingKey, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}
        /// Operation Id: WebApps_GetAppSettingKeyVaultReference
        /// </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettingKey"/> is null. </exception>
        public async virtual Task<Response<SiteConfigAppsetting>> GetIfExistsAsync(string appSettingKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appSettingKey, nameof(appSettingKey));

            using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteConfigAppsettingWebAppsRestClient.GetAppSettingKeyVaultReferenceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appSettingKey, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteConfigAppsetting>(null, response.GetRawResponse());
                return Response.FromValue(new SiteConfigAppsetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}
        /// Operation Id: WebApps_GetAppSettingKeyVaultReference
        /// </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appSettingKey"/> is null. </exception>
        public virtual Response<SiteConfigAppsetting> GetIfExists(string appSettingKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appSettingKey, nameof(appSettingKey));

            using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteConfigAppsettingWebAppsRestClient.GetAppSettingKeyVaultReference(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, appSettingKey, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteConfigAppsetting>(null, response.GetRawResponse());
                return Response.FromValue(new SiteConfigAppsetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteConfigAppsetting> IEnumerable<SiteConfigAppsetting>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteConfigAppsetting> IAsyncEnumerable<SiteConfigAppsetting>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
