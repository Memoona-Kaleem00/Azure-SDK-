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

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A Class representing a DataBoxEdgeUser along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DataBoxEdgeUserResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDataBoxEdgeUserResource method.
    /// Otherwise you can get one from its parent resource <see cref="DataBoxEdgeDeviceResource"/> using the GetDataBoxEdgeUser method.
    /// </summary>
    public partial class DataBoxEdgeUserResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataBoxEdgeUserResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="deviceName"> The deviceName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string deviceName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/users/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataBoxEdgeUserUsersClientDiagnostics;
        private readonly UsersRestOperations _dataBoxEdgeUserUsersRestClient;
        private readonly DataBoxEdgeUserData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataBoxEdge/dataBoxEdgeDevices/users";

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeUserResource"/> class for mocking. </summary>
        protected DataBoxEdgeUserResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeUserResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataBoxEdgeUserResource(ArmClient client, DataBoxEdgeUserData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeUserResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataBoxEdgeUserResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataBoxEdgeUserUsersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataBoxEdgeUserUsersApiVersion);
            _dataBoxEdgeUserUsersRestClient = new UsersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataBoxEdgeUserUsersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataBoxEdgeUserData Data
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
        /// Gets the properties of the specified user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataBoxEdgeUserResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataBoxEdgeUserUsersClientDiagnostics.CreateScope("DataBoxEdgeUserResource.Get");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeUserUsersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeUserResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataBoxEdgeUserResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataBoxEdgeUserUsersClientDiagnostics.CreateScope("DataBoxEdgeUserResource.Get");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeUserUsersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeUserResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the user on a databox edge/gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataBoxEdgeUserUsersClientDiagnostics.CreateScope("DataBoxEdgeUserResource.Delete");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeUserUsersRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DataBoxEdgeArmOperation(_dataBoxEdgeUserUsersClientDiagnostics, Pipeline, _dataBoxEdgeUserUsersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes the user on a databox edge/gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataBoxEdgeUserUsersClientDiagnostics.CreateScope("DataBoxEdgeUserResource.Delete");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeUserUsersRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DataBoxEdgeArmOperation(_dataBoxEdgeUserUsersClientDiagnostics, Pipeline, _dataBoxEdgeUserUsersRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new user or updates an existing user's information on a Data Box Edge/Data Box Gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The user details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataBoxEdgeUserResource>> UpdateAsync(WaitUntil waitUntil, DataBoxEdgeUserData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeUserUsersClientDiagnostics.CreateScope("DataBoxEdgeUserResource.Update");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeUserUsersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeUserResource>(new DataBoxEdgeUserOperationSource(Client), _dataBoxEdgeUserUsersClientDiagnostics, Pipeline, _dataBoxEdgeUserUsersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new user or updates an existing user's information on a Data Box Edge/Data Box Gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The user details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataBoxEdgeUserResource> Update(WaitUntil waitUntil, DataBoxEdgeUserData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeUserUsersClientDiagnostics.CreateScope("DataBoxEdgeUserResource.Update");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeUserUsersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeUserResource>(new DataBoxEdgeUserOperationSource(Client), _dataBoxEdgeUserUsersClientDiagnostics, Pipeline, _dataBoxEdgeUserUsersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
