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

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing a collection of <see cref="PlacementPolicyResource"/> and their operations.
    /// Each <see cref="PlacementPolicyResource"/> in the collection will belong to the same instance of <see cref="AvsPrivateCloudClusterResource"/>.
    /// To get a <see cref="PlacementPolicyCollection"/> instance call the GetPlacementPolicies method from an instance of <see cref="AvsPrivateCloudClusterResource"/>.
    /// </summary>
    public partial class PlacementPolicyCollection : ArmCollection, IEnumerable<PlacementPolicyResource>, IAsyncEnumerable<PlacementPolicyResource>
    {
        private readonly ClientDiagnostics _placementPolicyClientDiagnostics;
        private readonly PlacementPoliciesRestOperations _placementPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="PlacementPolicyCollection"/> class for mocking. </summary>
        protected PlacementPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PlacementPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PlacementPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _placementPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", PlacementPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PlacementPolicyResource.ResourceType, out string placementPolicyApiVersion);
            _placementPolicyRestClient = new PlacementPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, placementPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AvsPrivateCloudClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AvsPrivateCloudClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a placement policy in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/placementPolicies/{placementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlacementPolicies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AVS/privateClouds/clusters/placementPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="placementPolicyName"> Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement policy. </param>
        /// <param name="data"> A placement policy in the private cloud cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="placementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="placementPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PlacementPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string placementPolicyName, PlacementPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(placementPolicyName, nameof(placementPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _placementPolicyClientDiagnostics.CreateScope("PlacementPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _placementPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, placementPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<PlacementPolicyResource>(new PlacementPolicyOperationSource(Client), _placementPolicyClientDiagnostics, Pipeline, _placementPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, placementPolicyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a placement policy in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/placementPolicies/{placementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlacementPolicies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AVS/privateClouds/clusters/placementPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="placementPolicyName"> Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement policy. </param>
        /// <param name="data"> A placement policy in the private cloud cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="placementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="placementPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PlacementPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string placementPolicyName, PlacementPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(placementPolicyName, nameof(placementPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _placementPolicyClientDiagnostics.CreateScope("PlacementPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _placementPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, placementPolicyName, data, cancellationToken);
                var operation = new AvsArmOperation<PlacementPolicyResource>(new PlacementPolicyOperationSource(Client), _placementPolicyClientDiagnostics, Pipeline, _placementPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, placementPolicyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a placement policy by name in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/placementPolicies/{placementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlacementPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AVS/privateClouds/clusters/placementPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="placementPolicyName"> Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="placementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="placementPolicyName"/> is null. </exception>
        public virtual async Task<Response<PlacementPolicyResource>> GetAsync(string placementPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(placementPolicyName, nameof(placementPolicyName));

            using var scope = _placementPolicyClientDiagnostics.CreateScope("PlacementPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _placementPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, placementPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PlacementPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a placement policy by name in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/placementPolicies/{placementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlacementPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AVS/privateClouds/clusters/placementPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="placementPolicyName"> Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="placementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="placementPolicyName"/> is null. </exception>
        public virtual Response<PlacementPolicyResource> Get(string placementPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(placementPolicyName, nameof(placementPolicyName));

            using var scope = _placementPolicyClientDiagnostics.CreateScope("PlacementPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _placementPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, placementPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PlacementPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List placement policies in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/placementPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlacementPolicies_List</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AVS/privateClouds/clusters/placementPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PlacementPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PlacementPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _placementPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _placementPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PlacementPolicyResource(Client, PlacementPolicyData.DeserializePlacementPolicyData(e)), _placementPolicyClientDiagnostics, Pipeline, "PlacementPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List placement policies in a private cloud cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/placementPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlacementPolicies_List</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AVS/privateClouds/clusters/placementPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PlacementPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PlacementPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _placementPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _placementPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PlacementPolicyResource(Client, PlacementPolicyData.DeserializePlacementPolicyData(e)), _placementPolicyClientDiagnostics, Pipeline, "PlacementPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/placementPolicies/{placementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlacementPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AVS/privateClouds/clusters/placementPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="placementPolicyName"> Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="placementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="placementPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string placementPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(placementPolicyName, nameof(placementPolicyName));

            using var scope = _placementPolicyClientDiagnostics.CreateScope("PlacementPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _placementPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, placementPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/placementPolicies/{placementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlacementPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AVS/privateClouds/clusters/placementPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="placementPolicyName"> Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="placementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="placementPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string placementPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(placementPolicyName, nameof(placementPolicyName));

            using var scope = _placementPolicyClientDiagnostics.CreateScope("PlacementPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _placementPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, placementPolicyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/placementPolicies/{placementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlacementPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AVS/privateClouds/clusters/placementPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="placementPolicyName"> Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="placementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="placementPolicyName"/> is null. </exception>
        public virtual async Task<NullableResponse<PlacementPolicyResource>> GetIfExistsAsync(string placementPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(placementPolicyName, nameof(placementPolicyName));

            using var scope = _placementPolicyClientDiagnostics.CreateScope("PlacementPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _placementPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, placementPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PlacementPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new PlacementPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/placementPolicies/{placementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PlacementPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AVS/privateClouds/clusters/placementPolicies</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="placementPolicyName"> Name of the VMware vSphere Distributed Resource Scheduler (DRS) placement policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="placementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="placementPolicyName"/> is null. </exception>
        public virtual NullableResponse<PlacementPolicyResource> GetIfExists(string placementPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(placementPolicyName, nameof(placementPolicyName));

            using var scope = _placementPolicyClientDiagnostics.CreateScope("PlacementPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _placementPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, placementPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PlacementPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new PlacementPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PlacementPolicyResource> IEnumerable<PlacementPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PlacementPolicyResource> IAsyncEnumerable<PlacementPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
