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
using Azure.ResourceManager.DeviceUpdate.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary>
    /// A Class representing a DeviceUpdatePrivateEndpointConnectionProxy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDeviceUpdatePrivateEndpointConnectionProxyResource method.
    /// Otherwise you can get one from its parent resource <see cref="DeviceUpdateAccountResource"/> using the GetDeviceUpdatePrivateEndpointConnectionProxy method.
    /// </summary>
    public partial class DeviceUpdatePrivateEndpointConnectionProxyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="privateEndpointConnectionProxyId"> The privateEndpointConnectionProxyId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics;
        private readonly PrivateEndpointConnectionProxiesRestOperations _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient;
        private readonly DeviceUpdatePrivateEndpointConnectionProxyData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DeviceUpdate/accounts/privateEndpointConnectionProxies";

        /// <summary> Initializes a new instance of the <see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/> class for mocking. </summary>
        protected DeviceUpdatePrivateEndpointConnectionProxyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DeviceUpdatePrivateEndpointConnectionProxyResource(ArmClient client, DeviceUpdatePrivateEndpointConnectionProxyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceUpdatePrivateEndpointConnectionProxyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeviceUpdatePrivateEndpointConnectionProxyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceUpdate", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesApiVersion);
            _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient = new PrivateEndpointConnectionProxiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DeviceUpdatePrivateEndpointConnectionProxyData Data
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
        /// (INTERNAL - DO NOT USE) Get the specified private endpoint connection proxy associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeviceUpdatePrivateEndpointConnectionProxyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyResource.Get");
            scope.Start();
            try
            {
                var response = await _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceUpdatePrivateEndpointConnectionProxyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Get the specified private endpoint connection proxy associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeviceUpdatePrivateEndpointConnectionProxyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyResource.Get");
            scope.Start();
            try
            {
                var response = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceUpdatePrivateEndpointConnectionProxyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Deletes the specified private endpoint connection proxy associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyResource.Delete");
            scope.Start();
            try
            {
                var response = await _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceUpdateArmOperation(_deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics, Pipeline, _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Deletes the specified private endpoint connection proxy associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyResource.Delete");
            scope.Start();
            try
            {
                var response = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DeviceUpdateArmOperation(_deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics, Pipeline, _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Creates or updates the specified private endpoint connection proxy resource associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DeviceUpdatePrivateEndpointConnectionProxyResource>> UpdateAsync(WaitUntil waitUntil, DeviceUpdatePrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyResource.Update");
            scope.Start();
            try
            {
                var response = await _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceUpdateArmOperation<DeviceUpdatePrivateEndpointConnectionProxyResource>(new DeviceUpdatePrivateEndpointConnectionProxyOperationSource(Client), _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics, Pipeline, _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// (INTERNAL - DO NOT USE) Creates or updates the specified private endpoint connection proxy resource associated with the device update account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DeviceUpdatePrivateEndpointConnectionProxyResource> Update(WaitUntil waitUntil, DeviceUpdatePrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyResource.Update");
            scope.Start();
            try
            {
                var response = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new DeviceUpdateArmOperation<DeviceUpdatePrivateEndpointConnectionProxyResource>(new DeviceUpdatePrivateEndpointConnectionProxyOperationSource(Client), _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics, Pipeline, _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// (INTERNAL - DO NOT USE) Validates a private endpoint connection proxy object.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Validate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response> ValidateAsync(DeviceUpdatePrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyResource.Validate");
            scope.Start();
            try
            {
                var response = await _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.ValidateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Validates a private endpoint connection proxy object.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_Validate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response Validate(DeviceUpdatePrivateEndpointConnectionProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyResource.Validate");
            scope.Start();
            try
            {
                var response = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.Validate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Updates a private endpoint inside the private endpoint connection proxy object.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}/updatePrivateEndpointProperties</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_UpdatePrivateEndpointProperties</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointUpdate"> The parameters for updating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointUpdate"/> is null. </exception>
        public virtual async Task<Response> UpdatePrivateEndpointPropertiesAsync(DeviceUpdatePrivateEndpointUpdate privateEndpointUpdate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(privateEndpointUpdate, nameof(privateEndpointUpdate));

            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyResource.UpdatePrivateEndpointProperties");
            scope.Start();
            try
            {
                var response = await _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.UpdatePrivateEndpointPropertiesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, privateEndpointUpdate, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Updates a private endpoint inside the private endpoint connection proxy object.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}/updatePrivateEndpointProperties</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnectionProxies_UpdatePrivateEndpointProperties</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointUpdate"> The parameters for updating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointUpdate"/> is null. </exception>
        public virtual Response UpdatePrivateEndpointProperties(DeviceUpdatePrivateEndpointUpdate privateEndpointUpdate, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(privateEndpointUpdate, nameof(privateEndpointUpdate));

            using var scope = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesClientDiagnostics.CreateScope("DeviceUpdatePrivateEndpointConnectionProxyResource.UpdatePrivateEndpointProperties");
            scope.Start();
            try
            {
                var response = _deviceUpdatePrivateEndpointConnectionProxyPrivateEndpointConnectionProxiesRestClient.UpdatePrivateEndpointProperties(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, privateEndpointUpdate, cancellationToken);
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
