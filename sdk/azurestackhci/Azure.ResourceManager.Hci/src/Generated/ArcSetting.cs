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

namespace Azure.ResourceManager.Hci
{
    /// <summary> A Class representing a ArcSetting along with the instance operations that can be performed on it. </summary>
    public partial class ArcSetting : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ArcSetting"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterName, string arcSettingName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _arcSettingClientDiagnostics;
        private readonly ArcSettingsRestOperations _arcSettingRestClient;
        private readonly ArcSettingData _data;

        /// <summary> Initializes a new instance of the <see cref="ArcSetting"/> class for mocking. </summary>
        protected ArcSetting()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ArcSetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ArcSetting(ArmClient client, ArcSettingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ArcSetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ArcSetting(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _arcSettingClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string arcSettingApiVersion);
            _arcSettingRestClient = new ArcSettingsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, arcSettingApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AzureStackHCI/clusters/arcSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ArcSettingData Data
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

        /// <summary> Gets a collection of ArcExtensions in the ArcExtension. </summary>
        /// <returns> An object representing collection of ArcExtensions and their operations over a ArcExtension. </returns>
        public virtual ArcExtensionCollection GetArcExtensions()
        {
            return new ArcExtensionCollection(Client, Id);
        }

        /// <summary>
        /// Get particular Arc Extension of HCI Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}
        /// Operation Id: Extensions_Get
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual async Task<Response<ArcExtension>> GetArcExtensionAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            return await GetArcExtensions().GetAsync(extensionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get particular Arc Extension of HCI Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}
        /// Operation Id: Extensions_Get
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<ArcExtension> GetArcExtension(string extensionName, CancellationToken cancellationToken = default)
        {
            return GetArcExtensions().Get(extensionName, cancellationToken);
        }

        /// <summary>
        /// Get ArcSetting resource details of HCI Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}
        /// Operation Id: ArcSettings_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ArcSetting>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSetting.Get");
            scope.Start();
            try
            {
                var response = await _arcSettingRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArcSetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get ArcSetting resource details of HCI Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}
        /// Operation Id: ArcSettings_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ArcSetting> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSetting.Get");
            scope.Start();
            try
            {
                var response = _arcSettingRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArcSetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete ArcSetting resource details of HCI Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}
        /// Operation Id: ArcSettings_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSetting.Delete");
            scope.Start();
            try
            {
                var response = await _arcSettingRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation(_arcSettingClientDiagnostics, Pipeline, _arcSettingRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Delete ArcSetting resource details of HCI Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}
        /// Operation Id: ArcSettings_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSetting.Delete");
            scope.Start();
            try
            {
                var response = _arcSettingRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new HciArmOperation(_arcSettingClientDiagnostics, Pipeline, _arcSettingRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
