// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing a collection of <see cref="DataBoxEdgeUserResource" /> and their operations.
    /// Each <see cref="DataBoxEdgeUserResource" /> in the collection will belong to the same instance of <see cref="DataBoxEdgeDeviceResource" />.
    /// To get a <see cref="DataBoxEdgeUserCollection" /> instance call the GetDataBoxEdgeUsers method from an instance of <see cref="DataBoxEdgeDeviceResource" />.
    /// </summary>
    public partial class DataBoxEdgeUserCollection : ArmCollection, IEnumerable<DataBoxEdgeUserResource>, IAsyncEnumerable<DataBoxEdgeUserResource>
    {
        private readonly ClientDiagnostics _dataBoxEdgeUserUsersClientDiagnostics;
        private readonly UsersRestOperations _dataBoxEdgeUserUsersRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeUserCollection"/> class for mocking. </summary>
        protected DataBoxEdgeUserCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxEdgeUserCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataBoxEdgeUserCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataBoxEdgeUserUsersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", DataBoxEdgeUserResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataBoxEdgeUserResource.ResourceType, out string dataBoxEdgeUserUsersApiVersion);
            _dataBoxEdgeUserUsersRestClient = new UsersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataBoxEdgeUserUsersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataBoxEdgeDeviceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataBoxEdgeDeviceResource.ResourceType), nameof(id));
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
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The user name. </param>
        /// <param name="data"> The user details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataBoxEdgeUserResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DataBoxEdgeUserData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeUserUsersClientDiagnostics.CreateScope("DataBoxEdgeUserCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeUserUsersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeUserResource>(new DataBoxEdgeUserOperationSource(Client), _dataBoxEdgeUserUsersClientDiagnostics, Pipeline, _dataBoxEdgeUserUsersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The user name. </param>
        /// <param name="data"> The user details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataBoxEdgeUserResource> CreateOrUpdate(WaitUntil waitUntil, string name, DataBoxEdgeUserData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataBoxEdgeUserUsersClientDiagnostics.CreateScope("DataBoxEdgeUserCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeUserUsersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new DataBoxEdgeArmOperation<DataBoxEdgeUserResource>(new DataBoxEdgeUserOperationSource(Client), _dataBoxEdgeUserUsersClientDiagnostics, Pipeline, _dataBoxEdgeUserUsersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// </list>
        /// </summary>
        /// <param name="name"> The user name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DataBoxEdgeUserResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeUserUsersClientDiagnostics.CreateScope("DataBoxEdgeUserCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeUserUsersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
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
        /// </list>
        /// </summary>
        /// <param name="name"> The user name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DataBoxEdgeUserResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeUserUsersClientDiagnostics.CreateScope("DataBoxEdgeUserCollection.Get");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeUserUsersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
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
        /// Gets all the users registered on a Data Box Edge/Data Box Gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/users</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_ListByDataBoxEdgeDevice</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Specify $filter='Type eq &lt;type&gt;' to filter on user type property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataBoxEdgeUserResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataBoxEdgeUserResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataBoxEdgeUserUsersRestClient.CreateListByDataBoxEdgeDeviceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataBoxEdgeUserUsersRestClient.CreateListByDataBoxEdgeDeviceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataBoxEdgeUserResource(Client, DataBoxEdgeUserData.DeserializeDataBoxEdgeUserData(e)), _dataBoxEdgeUserUsersClientDiagnostics, Pipeline, "DataBoxEdgeUserCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the users registered on a Data Box Edge/Data Box Gateway device.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/users</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_ListByDataBoxEdgeDevice</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Specify $filter='Type eq &lt;type&gt;' to filter on user type property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataBoxEdgeUserResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataBoxEdgeUserResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataBoxEdgeUserUsersRestClient.CreateListByDataBoxEdgeDeviceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataBoxEdgeUserUsersRestClient.CreateListByDataBoxEdgeDeviceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataBoxEdgeUserResource(Client, DataBoxEdgeUserData.DeserializeDataBoxEdgeUserData(e)), _dataBoxEdgeUserUsersClientDiagnostics, Pipeline, "DataBoxEdgeUserCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The user name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeUserUsersClientDiagnostics.CreateScope("DataBoxEdgeUserCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeUserUsersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The user name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeUserUsersClientDiagnostics.CreateScope("DataBoxEdgeUserCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeUserUsersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The user name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<DataBoxEdgeUserResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeUserUsersClientDiagnostics.CreateScope("DataBoxEdgeUserCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataBoxEdgeUserUsersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataBoxEdgeUserResource>(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeUserResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/{deviceName}/users/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Users_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The user name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<DataBoxEdgeUserResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _dataBoxEdgeUserUsersClientDiagnostics.CreateScope("DataBoxEdgeUserCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataBoxEdgeUserUsersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataBoxEdgeUserResource>(response.GetRawResponse());
                return Response.FromValue(new DataBoxEdgeUserResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataBoxEdgeUserResource> IEnumerable<DataBoxEdgeUserResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataBoxEdgeUserResource> IAsyncEnumerable<DataBoxEdgeUserResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
