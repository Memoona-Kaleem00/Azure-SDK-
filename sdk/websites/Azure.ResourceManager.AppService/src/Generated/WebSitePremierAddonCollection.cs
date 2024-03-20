// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="WebSitePremierAddonResource"/> and their operations.
    /// Each <see cref="WebSitePremierAddonResource"/> in the collection will belong to the same instance of <see cref="WebSiteResource"/>.
    /// To get a <see cref="WebSitePremierAddonCollection"/> instance call the GetWebSitePremierAddons method from an instance of <see cref="WebSiteResource"/>.
    /// </summary>
    public partial class WebSitePremierAddonCollection : ArmCollection
    {
        private readonly ClientDiagnostics _webSitePremierAddonWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSitePremierAddonWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSitePremierAddonCollection"/> class for mocking. </summary>
        protected WebSitePremierAddonCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSitePremierAddonCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebSitePremierAddonCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSitePremierAddonWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WebSitePremierAddonResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebSitePremierAddonResource.ResourceType, out string webSitePremierAddonWebAppsApiVersion);
            _webSitePremierAddonWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSitePremierAddonWebAppsApiVersion);
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
        /// Description for Updates a named add-on of an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/premieraddons/{premierAddOnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_AddPremierAddOn</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSitePremierAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="data"> A JSON representation of the edited premier add-on. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WebSitePremierAddonResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string premierAddOnName, PremierAddOnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSitePremierAddonWebAppsClientDiagnostics.CreateScope("WebSitePremierAddonCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webSitePremierAddonWebAppsRestClient.AddPremierAddOnAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, premierAddOnName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<WebSitePremierAddonResource>(Response.FromValue(new WebSitePremierAddonResource(Client, response), response.GetRawResponse()));
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
        /// Description for Updates a named add-on of an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/premieraddons/{premierAddOnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_AddPremierAddOn</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSitePremierAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="data"> A JSON representation of the edited premier add-on. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WebSitePremierAddonResource> CreateOrUpdate(WaitUntil waitUntil, string premierAddOnName, PremierAddOnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSitePremierAddonWebAppsClientDiagnostics.CreateScope("WebSitePremierAddonCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webSitePremierAddonWebAppsRestClient.AddPremierAddOn(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, premierAddOnName, data, cancellationToken);
                var operation = new AppServiceArmOperation<WebSitePremierAddonResource>(Response.FromValue(new WebSitePremierAddonResource(Client, response), response.GetRawResponse()));
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
        /// Description for Gets a named add-on of an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/premieraddons/{premierAddOnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetPremierAddOn</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSitePremierAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual async Task<Response<WebSitePremierAddonResource>> GetAsync(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _webSitePremierAddonWebAppsClientDiagnostics.CreateScope("WebSitePremierAddonCollection.Get");
            scope.Start();
            try
            {
                var response = await _webSitePremierAddonWebAppsRestClient.GetPremierAddOnAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, premierAddOnName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSitePremierAddonResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a named add-on of an app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/premieraddons/{premierAddOnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetPremierAddOn</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSitePremierAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual Response<WebSitePremierAddonResource> Get(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _webSitePremierAddonWebAppsClientDiagnostics.CreateScope("WebSitePremierAddonCollection.Get");
            scope.Start();
            try
            {
                var response = _webSitePremierAddonWebAppsRestClient.GetPremierAddOn(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, premierAddOnName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSitePremierAddonResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/premieraddons/{premierAddOnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetPremierAddOn</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSitePremierAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _webSitePremierAddonWebAppsClientDiagnostics.CreateScope("WebSitePremierAddonCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webSitePremierAddonWebAppsRestClient.GetPremierAddOnAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, premierAddOnName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/premieraddons/{premierAddOnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetPremierAddOn</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSitePremierAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual Response<bool> Exists(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _webSitePremierAddonWebAppsClientDiagnostics.CreateScope("WebSitePremierAddonCollection.Exists");
            scope.Start();
            try
            {
                var response = _webSitePremierAddonWebAppsRestClient.GetPremierAddOn(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, premierAddOnName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/premieraddons/{premierAddOnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetPremierAddOn</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSitePremierAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual async Task<NullableResponse<WebSitePremierAddonResource>> GetIfExistsAsync(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _webSitePremierAddonWebAppsClientDiagnostics.CreateScope("WebSitePremierAddonCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webSitePremierAddonWebAppsRestClient.GetPremierAddOnAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, premierAddOnName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WebSitePremierAddonResource>(response.GetRawResponse());
                return Response.FromValue(new WebSitePremierAddonResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/premieraddons/{premierAddOnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetPremierAddOn</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSitePremierAddonResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="premierAddOnName"> Add-on name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="premierAddOnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOnName"/> is null. </exception>
        public virtual NullableResponse<WebSitePremierAddonResource> GetIfExists(string premierAddOnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(premierAddOnName, nameof(premierAddOnName));

            using var scope = _webSitePremierAddonWebAppsClientDiagnostics.CreateScope("WebSitePremierAddonCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webSitePremierAddonWebAppsRestClient.GetPremierAddOn(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, premierAddOnName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WebSitePremierAddonResource>(response.GetRawResponse());
                return Response.FromValue(new WebSitePremierAddonResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
