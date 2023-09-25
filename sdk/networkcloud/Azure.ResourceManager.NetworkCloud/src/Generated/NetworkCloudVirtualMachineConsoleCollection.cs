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

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkCloudVirtualMachineConsoleResource" /> and their operations.
    /// Each <see cref="NetworkCloudVirtualMachineConsoleResource" /> in the collection will belong to the same instance of <see cref="NetworkCloudVirtualMachineResource" />.
    /// To get a <see cref="NetworkCloudVirtualMachineConsoleCollection" /> instance call the GetNetworkCloudVirtualMachineConsoles method from an instance of <see cref="NetworkCloudVirtualMachineResource" />.
    /// </summary>
    public partial class NetworkCloudVirtualMachineConsoleCollection : ArmCollection, IEnumerable<NetworkCloudVirtualMachineConsoleResource>, IAsyncEnumerable<NetworkCloudVirtualMachineConsoleResource>
    {
        private readonly ClientDiagnostics _networkCloudVirtualMachineConsoleConsolesClientDiagnostics;
        private readonly ConsolesRestOperations _networkCloudVirtualMachineConsoleConsolesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudVirtualMachineConsoleCollection"/> class for mocking. </summary>
        protected NetworkCloudVirtualMachineConsoleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudVirtualMachineConsoleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkCloudVirtualMachineConsoleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkCloudVirtualMachineConsoleConsolesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", NetworkCloudVirtualMachineConsoleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkCloudVirtualMachineConsoleResource.ResourceType, out string networkCloudVirtualMachineConsoleConsolesApiVersion);
            _networkCloudVirtualMachineConsoleConsolesRestClient = new ConsolesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkCloudVirtualMachineConsoleConsolesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkCloudVirtualMachineResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkCloudVirtualMachineResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new virtual machine console or update the properties of the existing virtual machine console.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/virtualMachines/{virtualMachineName}/consoles/{consoleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Consoles_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="consoleName"> The name of the virtual machine console. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consoleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consoleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkCloudVirtualMachineConsoleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string consoleName, NetworkCloudVirtualMachineConsoleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consoleName, nameof(consoleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudVirtualMachineConsoleConsolesClientDiagnostics.CreateScope("NetworkCloudVirtualMachineConsoleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkCloudVirtualMachineConsoleConsolesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, consoleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkCloudArmOperation<NetworkCloudVirtualMachineConsoleResource>(new NetworkCloudVirtualMachineConsoleOperationSource(Client), _networkCloudVirtualMachineConsoleConsolesClientDiagnostics, Pipeline, _networkCloudVirtualMachineConsoleConsolesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, consoleName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a new virtual machine console or update the properties of the existing virtual machine console.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/virtualMachines/{virtualMachineName}/consoles/{consoleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Consoles_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="consoleName"> The name of the virtual machine console. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consoleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consoleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkCloudVirtualMachineConsoleResource> CreateOrUpdate(WaitUntil waitUntil, string consoleName, NetworkCloudVirtualMachineConsoleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consoleName, nameof(consoleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudVirtualMachineConsoleConsolesClientDiagnostics.CreateScope("NetworkCloudVirtualMachineConsoleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkCloudVirtualMachineConsoleConsolesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, consoleName, data, cancellationToken);
                var operation = new NetworkCloudArmOperation<NetworkCloudVirtualMachineConsoleResource>(new NetworkCloudVirtualMachineConsoleOperationSource(Client), _networkCloudVirtualMachineConsoleConsolesClientDiagnostics, Pipeline, _networkCloudVirtualMachineConsoleConsolesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, consoleName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get properties of the provided virtual machine console.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/virtualMachines/{virtualMachineName}/consoles/{consoleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Consoles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="consoleName"> The name of the virtual machine console. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consoleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consoleName"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudVirtualMachineConsoleResource>> GetAsync(string consoleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consoleName, nameof(consoleName));

            using var scope = _networkCloudVirtualMachineConsoleConsolesClientDiagnostics.CreateScope("NetworkCloudVirtualMachineConsoleCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkCloudVirtualMachineConsoleConsolesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, consoleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudVirtualMachineConsoleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of the provided virtual machine console.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/virtualMachines/{virtualMachineName}/consoles/{consoleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Consoles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="consoleName"> The name of the virtual machine console. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consoleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consoleName"/> is null. </exception>
        public virtual Response<NetworkCloudVirtualMachineConsoleResource> Get(string consoleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consoleName, nameof(consoleName));

            using var scope = _networkCloudVirtualMachineConsoleConsolesClientDiagnostics.CreateScope("NetworkCloudVirtualMachineConsoleCollection.Get");
            scope.Start();
            try
            {
                var response = _networkCloudVirtualMachineConsoleConsolesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, consoleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudVirtualMachineConsoleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of consoles for the provided virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/virtualMachines/{virtualMachineName}/consoles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Consoles_ListByVirtualMachine</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkCloudVirtualMachineConsoleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkCloudVirtualMachineConsoleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudVirtualMachineConsoleConsolesRestClient.CreateListByVirtualMachineRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudVirtualMachineConsoleConsolesRestClient.CreateListByVirtualMachineNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudVirtualMachineConsoleResource(Client, NetworkCloudVirtualMachineConsoleData.DeserializeNetworkCloudVirtualMachineConsoleData(e)), _networkCloudVirtualMachineConsoleConsolesClientDiagnostics, Pipeline, "NetworkCloudVirtualMachineConsoleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of consoles for the provided virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/virtualMachines/{virtualMachineName}/consoles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Consoles_ListByVirtualMachine</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkCloudVirtualMachineConsoleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkCloudVirtualMachineConsoleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudVirtualMachineConsoleConsolesRestClient.CreateListByVirtualMachineRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudVirtualMachineConsoleConsolesRestClient.CreateListByVirtualMachineNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkCloudVirtualMachineConsoleResource(Client, NetworkCloudVirtualMachineConsoleData.DeserializeNetworkCloudVirtualMachineConsoleData(e)), _networkCloudVirtualMachineConsoleConsolesClientDiagnostics, Pipeline, "NetworkCloudVirtualMachineConsoleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/virtualMachines/{virtualMachineName}/consoles/{consoleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Consoles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="consoleName"> The name of the virtual machine console. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consoleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consoleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string consoleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consoleName, nameof(consoleName));

            using var scope = _networkCloudVirtualMachineConsoleConsolesClientDiagnostics.CreateScope("NetworkCloudVirtualMachineConsoleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkCloudVirtualMachineConsoleConsolesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, consoleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/virtualMachines/{virtualMachineName}/consoles/{consoleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Consoles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="consoleName"> The name of the virtual machine console. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consoleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consoleName"/> is null. </exception>
        public virtual Response<bool> Exists(string consoleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consoleName, nameof(consoleName));

            using var scope = _networkCloudVirtualMachineConsoleConsolesClientDiagnostics.CreateScope("NetworkCloudVirtualMachineConsoleCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkCloudVirtualMachineConsoleConsolesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, consoleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/virtualMachines/{virtualMachineName}/consoles/{consoleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Consoles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="consoleName"> The name of the virtual machine console. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consoleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consoleName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkCloudVirtualMachineConsoleResource>> GetIfExistsAsync(string consoleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consoleName, nameof(consoleName));

            using var scope = _networkCloudVirtualMachineConsoleConsolesClientDiagnostics.CreateScope("NetworkCloudVirtualMachineConsoleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkCloudVirtualMachineConsoleConsolesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, consoleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudVirtualMachineConsoleResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudVirtualMachineConsoleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/virtualMachines/{virtualMachineName}/consoles/{consoleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Consoles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="consoleName"> The name of the virtual machine console. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consoleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consoleName"/> is null. </exception>
        public virtual NullableResponse<NetworkCloudVirtualMachineConsoleResource> GetIfExists(string consoleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consoleName, nameof(consoleName));

            using var scope = _networkCloudVirtualMachineConsoleConsolesClientDiagnostics.CreateScope("NetworkCloudVirtualMachineConsoleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkCloudVirtualMachineConsoleConsolesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, consoleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudVirtualMachineConsoleResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudVirtualMachineConsoleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkCloudVirtualMachineConsoleResource> IEnumerable<NetworkCloudVirtualMachineConsoleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkCloudVirtualMachineConsoleResource> IAsyncEnumerable<NetworkCloudVirtualMachineConsoleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
