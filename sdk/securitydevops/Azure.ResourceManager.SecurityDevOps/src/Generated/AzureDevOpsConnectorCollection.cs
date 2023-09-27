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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityDevOps
{
    /// <summary>
    /// A class representing a collection of <see cref="AzureDevOpsConnectorResource" /> and their operations.
    /// Each <see cref="AzureDevOpsConnectorResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="AzureDevOpsConnectorCollection" /> instance call the GetAzureDevOpsConnectors method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class AzureDevOpsConnectorCollection : ArmCollection, IEnumerable<AzureDevOpsConnectorResource>, IAsyncEnumerable<AzureDevOpsConnectorResource>
    {
        private readonly ClientDiagnostics _azureDevOpsConnectorClientDiagnostics;
        private readonly AzureDevOpsConnectorRestOperations _azureDevOpsConnectorRestClient;

        /// <summary> Initializes a new instance of the <see cref="AzureDevOpsConnectorCollection"/> class for mocking. </summary>
        protected AzureDevOpsConnectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AzureDevOpsConnectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AzureDevOpsConnectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _azureDevOpsConnectorClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityDevOps", AzureDevOpsConnectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AzureDevOpsConnectorResource.ResourceType, out string azureDevOpsConnectorApiVersion);
            _azureDevOpsConnectorRestClient = new AzureDevOpsConnectorRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, azureDevOpsConnectorApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an Azure DevOps Connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="data"> Connector resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsConnectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AzureDevOpsConnectorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string azureDevOpsConnectorName, AzureDevOpsConnectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _azureDevOpsConnectorClientDiagnostics.CreateScope("AzureDevOpsConnectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _azureDevOpsConnectorRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, azureDevOpsConnectorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityDevOpsArmOperation<AzureDevOpsConnectorResource>(new AzureDevOpsConnectorOperationSource(Client), _azureDevOpsConnectorClientDiagnostics, Pipeline, _azureDevOpsConnectorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, azureDevOpsConnectorName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an Azure DevOps Connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="data"> Connector resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsConnectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AzureDevOpsConnectorResource> CreateOrUpdate(WaitUntil waitUntil, string azureDevOpsConnectorName, AzureDevOpsConnectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _azureDevOpsConnectorClientDiagnostics.CreateScope("AzureDevOpsConnectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _azureDevOpsConnectorRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, azureDevOpsConnectorName, data, cancellationToken);
                var operation = new SecurityDevOpsArmOperation<AzureDevOpsConnectorResource>(new AzureDevOpsConnectorOperationSource(Client), _azureDevOpsConnectorClientDiagnostics, Pipeline, _azureDevOpsConnectorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, azureDevOpsConnectorName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Returns a monitored AzureDevOps Connector resource for a given ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsConnectorName"/> is null. </exception>
        public virtual async Task<Response<AzureDevOpsConnectorResource>> GetAsync(string azureDevOpsConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));

            using var scope = _azureDevOpsConnectorClientDiagnostics.CreateScope("AzureDevOpsConnectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _azureDevOpsConnectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, azureDevOpsConnectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureDevOpsConnectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored AzureDevOps Connector resource for a given ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsConnectorName"/> is null. </exception>
        public virtual Response<AzureDevOpsConnectorResource> Get(string azureDevOpsConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));

            using var scope = _azureDevOpsConnectorClientDiagnostics.CreateScope("AzureDevOpsConnectorCollection.Get");
            scope.Start();
            try
            {
                var response = _azureDevOpsConnectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, azureDevOpsConnectorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureDevOpsConnectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureDevOpsConnectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureDevOpsConnectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _azureDevOpsConnectorRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _azureDevOpsConnectorRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AzureDevOpsConnectorResource(Client, AzureDevOpsConnectorData.DeserializeAzureDevOpsConnectorData(e)), _azureDevOpsConnectorClientDiagnostics, Pipeline, "AzureDevOpsConnectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureDevOpsConnectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureDevOpsConnectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _azureDevOpsConnectorRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _azureDevOpsConnectorRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AzureDevOpsConnectorResource(Client, AzureDevOpsConnectorData.DeserializeAzureDevOpsConnectorData(e)), _azureDevOpsConnectorClientDiagnostics, Pipeline, "AzureDevOpsConnectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsConnectorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string azureDevOpsConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));

            using var scope = _azureDevOpsConnectorClientDiagnostics.CreateScope("AzureDevOpsConnectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _azureDevOpsConnectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, azureDevOpsConnectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsConnectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string azureDevOpsConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));

            using var scope = _azureDevOpsConnectorClientDiagnostics.CreateScope("AzureDevOpsConnectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _azureDevOpsConnectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, azureDevOpsConnectorName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsConnectorName"/> is null. </exception>
        public virtual async Task<NullableResponse<AzureDevOpsConnectorResource>> GetIfExistsAsync(string azureDevOpsConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));

            using var scope = _azureDevOpsConnectorClientDiagnostics.CreateScope("AzureDevOpsConnectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _azureDevOpsConnectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, azureDevOpsConnectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AzureDevOpsConnectorResource>(response.GetRawResponse());
                return Response.FromValue(new AzureDevOpsConnectorResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsConnectorName"/> is null. </exception>
        public virtual NullableResponse<AzureDevOpsConnectorResource> GetIfExists(string azureDevOpsConnectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsConnectorName, nameof(azureDevOpsConnectorName));

            using var scope = _azureDevOpsConnectorClientDiagnostics.CreateScope("AzureDevOpsConnectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _azureDevOpsConnectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, azureDevOpsConnectorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AzureDevOpsConnectorResource>(response.GetRawResponse());
                return Response.FromValue(new AzureDevOpsConnectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AzureDevOpsConnectorResource> IEnumerable<AzureDevOpsConnectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AzureDevOpsConnectorResource> IAsyncEnumerable<AzureDevOpsConnectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
