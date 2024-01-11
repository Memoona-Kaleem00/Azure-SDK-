// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.TrafficManager
{
    /// <summary>
    /// A Class representing a TrafficManagerEndpoint along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="TrafficManagerEndpointResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetTrafficManagerEndpointResource method.
    /// Otherwise you can get one from its parent resource <see cref="TrafficManagerProfileResource"/> using the GetTrafficManagerEndpoint method.
    /// </summary>
    public partial class TrafficManagerEndpointResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TrafficManagerEndpointResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="profileName"> The profileName. </param>
        /// <param name="endpointType"> The endpointType. </param>
        /// <param name="endpointName"> The endpointName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string endpointType, string endpointName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/{endpointType}/{endpointName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _trafficManagerEndpointEndpointsClientDiagnostics;
        private readonly EndpointsRestOperations _trafficManagerEndpointEndpointsRestClient;
        private readonly TrafficManagerEndpointData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/trafficmanagerprofiles/{endpointType}";

        /// <summary> Initializes a new instance of the <see cref="TrafficManagerEndpointResource"/> class for mocking. </summary>
        protected TrafficManagerEndpointResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TrafficManagerEndpointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TrafficManagerEndpointResource(ArmClient client, TrafficManagerEndpointData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TrafficManagerEndpointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TrafficManagerEndpointResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _trafficManagerEndpointEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.TrafficManager", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string trafficManagerEndpointEndpointsApiVersion);
            _trafficManagerEndpointEndpointsRestClient = new EndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, trafficManagerEndpointEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TrafficManagerEndpointData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary>
        /// Gets a Traffic Manager endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/{endpointType}/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TrafficManagerEndpointResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _trafficManagerEndpointEndpointsClientDiagnostics.CreateScope("TrafficManagerEndpointResource.Get");
            scope.Start();
            try
            {
                var response = await _trafficManagerEndpointEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.ResourceType.GetLastType(), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TrafficManagerEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Traffic Manager endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/{endpointType}/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TrafficManagerEndpointResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _trafficManagerEndpointEndpointsClientDiagnostics.CreateScope("TrafficManagerEndpointResource.Get");
            scope.Start();
            try
            {
                var response = _trafficManagerEndpointEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.ResourceType.GetLastType(), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TrafficManagerEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a Traffic Manager endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/{endpointType}/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _trafficManagerEndpointEndpointsClientDiagnostics.CreateScope("TrafficManagerEndpointResource.Delete");
            scope.Start();
            try
            {
                var response = await _trafficManagerEndpointEndpointsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.ResourceType.GetLastType(), Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _trafficManagerEndpointEndpointsRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.ResourceType.GetLastType(), Id.Name);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new TrafficManagerArmOperation(response, operationId);
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
        /// Deletes a Traffic Manager endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/{endpointType}/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _trafficManagerEndpointEndpointsClientDiagnostics.CreateScope("TrafficManagerEndpointResource.Delete");
            scope.Start();
            try
            {
                var response = _trafficManagerEndpointEndpointsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.ResourceType.GetLastType(), Id.Name, cancellationToken);
                var uri = _trafficManagerEndpointEndpointsRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.ResourceType.GetLastType(), Id.Name);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new TrafficManagerArmOperation(response, operationId);
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
        /// Update a Traffic Manager endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/{endpointType}/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The Traffic Manager endpoint parameters supplied to the Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<TrafficManagerEndpointResource>> UpdateAsync(TrafficManagerEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _trafficManagerEndpointEndpointsClientDiagnostics.CreateScope("TrafficManagerEndpointResource.Update");
            scope.Start();
            try
            {
                var response = await _trafficManagerEndpointEndpointsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.ResourceType.GetLastType(), Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TrafficManagerEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a Traffic Manager endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/{endpointType}/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The Traffic Manager endpoint parameters supplied to the Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<TrafficManagerEndpointResource> Update(TrafficManagerEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _trafficManagerEndpointEndpointsClientDiagnostics.CreateScope("TrafficManagerEndpointResource.Update");
            scope.Start();
            try
            {
                var response = _trafficManagerEndpointEndpointsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.ResourceType.GetLastType(), Id.Name, data, cancellationToken);
                return Response.FromValue(new TrafficManagerEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
