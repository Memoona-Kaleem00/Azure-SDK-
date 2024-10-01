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

namespace Azure.ResourceManager.Elastic
{
    /// <summary>
    /// A Class representing a MonitoredSubscriptionProperty along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MonitoredSubscriptionPropertyResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMonitoredSubscriptionPropertyResource method.
    /// Otherwise you can get one from its parent resource <see cref="ElasticMonitorResource"/> using the GetMonitoredSubscriptionProperty method.
    /// </summary>
    public partial class MonitoredSubscriptionPropertyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MonitoredSubscriptionPropertyResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="monitorName"> The monitorName. </param>
        /// <param name="configurationName"> The configurationName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string monitorName, string configurationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}/monitoredSubscriptions/{configurationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _monitoredSubscriptionPropertyMonitoredSubscriptionsClientDiagnostics;
        private readonly MonitoredSubscriptionsRestOperations _monitoredSubscriptionPropertyMonitoredSubscriptionsRestClient;
        private readonly MonitoredSubscriptionPropertyData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Elastic/monitors/monitoredSubscriptions";

        /// <summary> Initializes a new instance of the <see cref="MonitoredSubscriptionPropertyResource"/> class for mocking. </summary>
        protected MonitoredSubscriptionPropertyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MonitoredSubscriptionPropertyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MonitoredSubscriptionPropertyResource(ArmClient client, MonitoredSubscriptionPropertyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MonitoredSubscriptionPropertyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MonitoredSubscriptionPropertyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _monitoredSubscriptionPropertyMonitoredSubscriptionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Elastic", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string monitoredSubscriptionPropertyMonitoredSubscriptionsApiVersion);
            _monitoredSubscriptionPropertyMonitoredSubscriptionsRestClient = new MonitoredSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, monitoredSubscriptionPropertyMonitoredSubscriptionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MonitoredSubscriptionPropertyData Data
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
        /// List all the subscriptions currently being monitored by the Elastic monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}/monitoredSubscriptions/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MonitoredSubscriptionPropertyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MonitoredSubscriptionPropertyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _monitoredSubscriptionPropertyMonitoredSubscriptionsClientDiagnostics.CreateScope("MonitoredSubscriptionPropertyResource.Get");
            scope.Start();
            try
            {
                var response = await _monitoredSubscriptionPropertyMonitoredSubscriptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MonitoredSubscriptionPropertyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the subscriptions currently being monitored by the Elastic monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}/monitoredSubscriptions/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MonitoredSubscriptionPropertyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MonitoredSubscriptionPropertyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _monitoredSubscriptionPropertyMonitoredSubscriptionsClientDiagnostics.CreateScope("MonitoredSubscriptionPropertyResource.Get");
            scope.Start();
            try
            {
                var response = _monitoredSubscriptionPropertyMonitoredSubscriptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MonitoredSubscriptionPropertyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the subscriptions that are being monitored by the Elastic monitor resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}/monitoredSubscriptions/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MonitoredSubscriptionPropertyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _monitoredSubscriptionPropertyMonitoredSubscriptionsClientDiagnostics.CreateScope("MonitoredSubscriptionPropertyResource.Delete");
            scope.Start();
            try
            {
                var response = await _monitoredSubscriptionPropertyMonitoredSubscriptionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ElasticArmOperation(_monitoredSubscriptionPropertyMonitoredSubscriptionsClientDiagnostics, Pipeline, _monitoredSubscriptionPropertyMonitoredSubscriptionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Updates the subscriptions that are being monitored by the Elastic monitor resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}/monitoredSubscriptions/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MonitoredSubscriptionPropertyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _monitoredSubscriptionPropertyMonitoredSubscriptionsClientDiagnostics.CreateScope("MonitoredSubscriptionPropertyResource.Delete");
            scope.Start();
            try
            {
                var response = _monitoredSubscriptionPropertyMonitoredSubscriptionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ElasticArmOperation(_monitoredSubscriptionPropertyMonitoredSubscriptionsClientDiagnostics, Pipeline, _monitoredSubscriptionPropertyMonitoredSubscriptionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Updates the subscriptions that are being monitored by the Elastic monitor resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}/monitoredSubscriptions/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MonitoredSubscriptionPropertyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The <see cref="MonitoredSubscriptionPropertyData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MonitoredSubscriptionPropertyResource>> UpdateAsync(WaitUntil waitUntil, MonitoredSubscriptionPropertyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _monitoredSubscriptionPropertyMonitoredSubscriptionsClientDiagnostics.CreateScope("MonitoredSubscriptionPropertyResource.Update");
            scope.Start();
            try
            {
                var response = await _monitoredSubscriptionPropertyMonitoredSubscriptionsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ElasticArmOperation<MonitoredSubscriptionPropertyResource>(new MonitoredSubscriptionPropertyOperationSource(Client), _monitoredSubscriptionPropertyMonitoredSubscriptionsClientDiagnostics, Pipeline, _monitoredSubscriptionPropertyMonitoredSubscriptionsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Updates the subscriptions that are being monitored by the Elastic monitor resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Elastic/monitors/{monitorName}/monitoredSubscriptions/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MonitoredSubscriptions_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MonitoredSubscriptionPropertyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The <see cref="MonitoredSubscriptionPropertyData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MonitoredSubscriptionPropertyResource> Update(WaitUntil waitUntil, MonitoredSubscriptionPropertyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _monitoredSubscriptionPropertyMonitoredSubscriptionsClientDiagnostics.CreateScope("MonitoredSubscriptionPropertyResource.Update");
            scope.Start();
            try
            {
                var response = _monitoredSubscriptionPropertyMonitoredSubscriptionsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ElasticArmOperation<MonitoredSubscriptionPropertyResource>(new MonitoredSubscriptionPropertyOperationSource(Client), _monitoredSubscriptionPropertyMonitoredSubscriptionsClientDiagnostics, Pipeline, _monitoredSubscriptionPropertyMonitoredSubscriptionsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
