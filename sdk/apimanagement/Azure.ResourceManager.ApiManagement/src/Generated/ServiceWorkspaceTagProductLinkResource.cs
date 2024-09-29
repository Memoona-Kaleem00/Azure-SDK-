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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing a ServiceWorkspaceTagProductLink along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ServiceWorkspaceTagProductLinkResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetServiceWorkspaceTagProductLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServiceWorkspaceTagResource"/> using the GetServiceWorkspaceTagProductLink method.
    /// </summary>
    public partial class ServiceWorkspaceTagProductLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServiceWorkspaceTagProductLinkResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        /// <param name="workspaceId"> The workspaceId. </param>
        /// <param name="tagId"> The tagId. </param>
        /// <param name="productLinkId"> The productLinkId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string workspaceId, string tagId, string productLinkId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/productLinks/{productLinkId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkClientDiagnostics;
        private readonly WorkspaceTagProductLinkRestOperations _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkRestClient;
        private readonly TagProductLinkContractData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/workspaces/tags/productLinks";

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceTagProductLinkResource"/> class for mocking. </summary>
        protected ServiceWorkspaceTagProductLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceTagProductLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServiceWorkspaceTagProductLinkResource(ArmClient client, TagProductLinkContractData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceTagProductLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceWorkspaceTagProductLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serviceWorkspaceTagProductLinkWorkspaceTagProductLinkApiVersion);
            _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkRestClient = new WorkspaceTagProductLinkRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceWorkspaceTagProductLinkWorkspaceTagProductLinkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TagProductLinkContractData Data
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
        /// Gets the product link for the tag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/productLinks/{productLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagProductLink_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagProductLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceWorkspaceTagProductLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkClientDiagnostics.CreateScope("ServiceWorkspaceTagProductLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceTagProductLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the product link for the tag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/productLinks/{productLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagProductLink_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagProductLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceWorkspaceTagProductLinkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkClientDiagnostics.CreateScope("ServiceWorkspaceTagProductLinkResource.Get");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceTagProductLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified product from the specified tag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/productLinks/{productLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagProductLink_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagProductLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkClientDiagnostics.CreateScope("ServiceWorkspaceTagProductLinkResource.Delete");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation(response, rehydrationToken);
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
        /// Deletes the specified product from the specified tag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/productLinks/{productLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagProductLink_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagProductLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkClientDiagnostics.CreateScope("ServiceWorkspaceTagProductLinkResource.Delete");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var uri = _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation(response, rehydrationToken);
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
        /// Adds a product to the specified tag via link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/productLinks/{productLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagProductLink_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagProductLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceWorkspaceTagProductLinkResource>> UpdateAsync(WaitUntil waitUntil, TagProductLinkContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkClientDiagnostics.CreateScope("ServiceWorkspaceTagProductLinkResource.Update");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ServiceWorkspaceTagProductLinkResource>(Response.FromValue(new ServiceWorkspaceTagProductLinkResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Adds a product to the specified tag via link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/productLinks/{productLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagProductLink_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagProductLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceWorkspaceTagProductLinkResource> Update(WaitUntil waitUntil, TagProductLinkContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkClientDiagnostics.CreateScope("ServiceWorkspaceTagProductLinkResource.Update");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var uri = _serviceWorkspaceTagProductLinkWorkspaceTagProductLinkRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ServiceWorkspaceTagProductLinkResource>(Response.FromValue(new ServiceWorkspaceTagProductLinkResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
    }
}
