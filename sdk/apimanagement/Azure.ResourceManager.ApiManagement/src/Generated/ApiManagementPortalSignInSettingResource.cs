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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing an ApiManagementPortalSignInSetting along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="ApiManagementPortalSignInSettingResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetApiManagementPortalSignInSettingResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiManagementServiceResource"/> using the GetApiManagementPortalSignInSetting method.
    /// </summary>
    public partial class ApiManagementPortalSignInSettingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApiManagementPortalSignInSettingResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signin";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _apiManagementPortalSignInSettingSignInSettingsClientDiagnostics;
        private readonly SignInSettingsRestOperations _apiManagementPortalSignInSettingSignInSettingsRestClient;
        private readonly ApiManagementPortalSignInSettingData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/portalsettings";

        /// <summary> Initializes a new instance of the <see cref="ApiManagementPortalSignInSettingResource"/> class for mocking. </summary>
        protected ApiManagementPortalSignInSettingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementPortalSignInSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ApiManagementPortalSignInSettingResource(ArmClient client, ApiManagementPortalSignInSettingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementPortalSignInSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApiManagementPortalSignInSettingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementPortalSignInSettingSignInSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string apiManagementPortalSignInSettingSignInSettingsApiVersion);
            _apiManagementPortalSignInSettingSignInSettingsRestClient = new SignInSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementPortalSignInSettingSignInSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ApiManagementPortalSignInSettingData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get Sign In Settings for the Portal
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signin</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignInSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPortalSignInSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementPortalSignInSettingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementPortalSignInSettingSignInSettingsClientDiagnostics.CreateScope("ApiManagementPortalSignInSettingResource.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementPortalSignInSettingSignInSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementPortalSignInSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Sign In Settings for the Portal
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signin</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignInSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPortalSignInSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementPortalSignInSettingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementPortalSignInSettingSignInSettingsClientDiagnostics.CreateScope("ApiManagementPortalSignInSettingResource.Get");
            scope.Start();
            try
            {
                var response = _apiManagementPortalSignInSettingSignInSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementPortalSignInSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update Sign-In settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signin</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignInSettings_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPortalSignInSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="data"> Update Sign-In settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response> UpdateAsync(ETag ifMatch, ApiManagementPortalSignInSettingData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _apiManagementPortalSignInSettingSignInSettingsClientDiagnostics.CreateScope("ApiManagementPortalSignInSettingResource.Update");
            scope.Start();
            try
            {
                var response = await _apiManagementPortalSignInSettingSignInSettingsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, ifMatch, data, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update Sign-In settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signin</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignInSettings_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPortalSignInSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="data"> Update Sign-In settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response Update(ETag ifMatch, ApiManagementPortalSignInSettingData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _apiManagementPortalSignInSettingSignInSettingsClientDiagnostics.CreateScope("ApiManagementPortalSignInSettingResource.Update");
            scope.Start();
            try
            {
                var response = _apiManagementPortalSignInSettingSignInSettingsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, ifMatch, data, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or Update Sign-In settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signin</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignInSettings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPortalSignInSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementPortalSignInSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, ApiManagementPortalSignInSettingData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _apiManagementPortalSignInSettingSignInSettingsClientDiagnostics.CreateScope("ApiManagementPortalSignInSettingResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementPortalSignInSettingSignInSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var uri = _apiManagementPortalSignInSettingSignInSettingsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ApiManagementPortalSignInSettingResource>(Response.FromValue(new ApiManagementPortalSignInSettingResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create or Update Sign-In settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signin</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignInSettings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPortalSignInSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementPortalSignInSettingResource> CreateOrUpdate(WaitUntil waitUntil, ApiManagementPortalSignInSettingData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _apiManagementPortalSignInSettingSignInSettingsClientDiagnostics.CreateScope("ApiManagementPortalSignInSettingResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementPortalSignInSettingSignInSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, ifMatch, cancellationToken);
                var uri = _apiManagementPortalSignInSettingSignInSettingsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ApiManagementPortalSignInSettingResource>(Response.FromValue(new ApiManagementPortalSignInSettingResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets the entity state (Etag) version of the SignInSettings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signin</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignInSettings_GetEntityTag</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPortalSignInSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetEntityTagAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementPortalSignInSettingSignInSettingsClientDiagnostics.CreateScope("ApiManagementPortalSignInSettingResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = await _apiManagementPortalSignInSettingSignInSettingsRestClient.GetEntityTagAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the SignInSettings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalsettings/signin</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignInSettings_GetEntityTag</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementPortalSignInSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetEntityTag(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementPortalSignInSettingSignInSettingsClientDiagnostics.CreateScope("ApiManagementPortalSignInSettingResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = _apiManagementPortalSignInSettingSignInSettingsRestClient.GetEntityTag(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
