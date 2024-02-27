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

namespace Azure.ResourceManager.MigrationDiscoverySap
{
    /// <summary>
    /// A class representing a collection of <see cref="ServerInstanceResource"/> and their operations.
    /// Each <see cref="ServerInstanceResource"/> in the collection will belong to the same instance of <see cref="SAPInstanceResource"/>.
    /// To get a <see cref="ServerInstanceCollection"/> instance call the GetServerInstances method from an instance of <see cref="SAPInstanceResource"/>.
    /// </summary>
    public partial class ServerInstanceCollection : ArmCollection, IEnumerable<ServerInstanceResource>, IAsyncEnumerable<ServerInstanceResource>
    {
        private readonly ClientDiagnostics _serverInstanceClientDiagnostics;
        private readonly ServerInstancesRestOperations _serverInstanceRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerInstanceCollection"/> class for mocking. </summary>
        protected ServerInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerInstanceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerInstanceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverInstanceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MigrationDiscoverySap", ServerInstanceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServerInstanceResource.ResourceType, out string serverInstanceApiVersion);
            _serverInstanceRestClient = new ServerInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverInstanceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SAPInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SAPInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates the Server Instance resource. &lt;br&gt;&lt;br&gt;;This will be used by service only. PUT operation on this resource by end user will return a Bad Request error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServerInstanceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serverInstanceName, ServerInstanceData data, CancellationToken cancellationToken = default)
        {
            if (serverInstanceName == null)
            {
                throw new ArgumentNullException(nameof(serverInstanceName));
            }
            if (serverInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverInstanceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _serverInstanceClientDiagnostics.CreateScope("ServerInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverInstanceRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MigrationDiscoverySapArmOperation<ServerInstanceResource>(new ServerInstanceOperationSource(Client), _serverInstanceClientDiagnostics, Pipeline, _serverInstanceRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates the Server Instance resource. &lt;br&gt;&lt;br&gt;;This will be used by service only. PUT operation on this resource by end user will return a Bad Request error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServerInstanceResource> CreateOrUpdate(WaitUntil waitUntil, string serverInstanceName, ServerInstanceData data, CancellationToken cancellationToken = default)
        {
            if (serverInstanceName == null)
            {
                throw new ArgumentNullException(nameof(serverInstanceName));
            }
            if (serverInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverInstanceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _serverInstanceClientDiagnostics.CreateScope("ServerInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverInstanceRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, data, cancellationToken);
                var operation = new MigrationDiscoverySapArmOperation<ServerInstanceResource>(new ServerInstanceOperationSource(Client), _serverInstanceClientDiagnostics, Pipeline, _serverInstanceRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the Server Instance resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> is null. </exception>
        public virtual async Task<Response<ServerInstanceResource>> GetAsync(string serverInstanceName, CancellationToken cancellationToken = default)
        {
            if (serverInstanceName == null)
            {
                throw new ArgumentNullException(nameof(serverInstanceName));
            }
            if (serverInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverInstanceName));
            }

            using var scope = _serverInstanceClientDiagnostics.CreateScope("ServerInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverInstanceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Server Instance resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> is null. </exception>
        public virtual Response<ServerInstanceResource> Get(string serverInstanceName, CancellationToken cancellationToken = default)
        {
            if (serverInstanceName == null)
            {
                throw new ArgumentNullException(nameof(serverInstanceName));
            }
            if (serverInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverInstanceName));
            }

            using var scope = _serverInstanceClientDiagnostics.CreateScope("ServerInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _serverInstanceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Server Instance resources for the given SAP Instance resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_ListBySapInstance</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerInstanceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serverInstanceRestClient.CreateListBySapInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serverInstanceRestClient.CreateListBySapInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServerInstanceResource(Client, ServerInstanceData.DeserializeServerInstanceData(e)), _serverInstanceClientDiagnostics, Pipeline, "ServerInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Server Instance resources for the given SAP Instance resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_ListBySapInstance</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerInstanceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serverInstanceRestClient.CreateListBySapInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serverInstanceRestClient.CreateListBySapInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServerInstanceResource(Client, ServerInstanceData.DeserializeServerInstanceData(e)), _serverInstanceClientDiagnostics, Pipeline, "ServerInstanceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serverInstanceName, CancellationToken cancellationToken = default)
        {
            if (serverInstanceName == null)
            {
                throw new ArgumentNullException(nameof(serverInstanceName));
            }
            if (serverInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverInstanceName));
            }

            using var scope = _serverInstanceClientDiagnostics.CreateScope("ServerInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serverInstanceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string serverInstanceName, CancellationToken cancellationToken = default)
        {
            if (serverInstanceName == null)
            {
                throw new ArgumentNullException(nameof(serverInstanceName));
            }
            if (serverInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverInstanceName));
            }

            using var scope = _serverInstanceClientDiagnostics.CreateScope("ServerInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = _serverInstanceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> is null. </exception>
        public virtual async Task<NullableResponse<ServerInstanceResource>> GetIfExistsAsync(string serverInstanceName, CancellationToken cancellationToken = default)
        {
            if (serverInstanceName == null)
            {
                throw new ArgumentNullException(nameof(serverInstanceName));
            }
            if (serverInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverInstanceName));
            }

            using var scope = _serverInstanceClientDiagnostics.CreateScope("ServerInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverInstanceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServerInstanceResource>(response.GetRawResponse());
                return Response.FromValue(new ServerInstanceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}/sapInstances/{sapInstanceName}/serverInstances/{serverInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerInstances_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverInstanceName"> The name of the Server instance resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverInstanceName"/> is null. </exception>
        public virtual NullableResponse<ServerInstanceResource> GetIfExists(string serverInstanceName, CancellationToken cancellationToken = default)
        {
            if (serverInstanceName == null)
            {
                throw new ArgumentNullException(nameof(serverInstanceName));
            }
            if (serverInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverInstanceName));
            }

            using var scope = _serverInstanceClientDiagnostics.CreateScope("ServerInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverInstanceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, serverInstanceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServerInstanceResource>(response.GetRawResponse());
                return Response.FromValue(new ServerInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerInstanceResource> IEnumerable<ServerInstanceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerInstanceResource> IAsyncEnumerable<ServerInstanceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
