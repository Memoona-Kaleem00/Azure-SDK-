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

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing a collection of <see cref="SnapshotPolicyResource"/> and their operations.
    /// Each <see cref="SnapshotPolicyResource"/> in the collection will belong to the same instance of <see cref="NetAppAccountResource"/>.
    /// To get a <see cref="SnapshotPolicyCollection"/> instance call the GetSnapshotPolicies method from an instance of <see cref="NetAppAccountResource"/>.
    /// </summary>
    public partial class SnapshotPolicyCollection : ArmCollection, IEnumerable<SnapshotPolicyResource>, IAsyncEnumerable<SnapshotPolicyResource>
    {
        private readonly ClientDiagnostics _snapshotPolicyClientDiagnostics;
        private readonly SnapshotPoliciesRestOperations _snapshotPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="SnapshotPolicyCollection"/> class for mocking. </summary>
        protected SnapshotPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SnapshotPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SnapshotPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _snapshotPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", SnapshotPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SnapshotPolicyResource.ResourceType, out string snapshotPolicyApiVersion);
            _snapshotPolicyRestClient = new SnapshotPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, snapshotPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetAppAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetAppAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a snapshot policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SnapshotPolicies_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="snapshotPolicyName"> The name of the snapshot policy. </param>
        /// <param name="data"> Snapshot policy object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SnapshotPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string snapshotPolicyName, SnapshotPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotPolicyName, nameof(snapshotPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _snapshotPolicyRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, snapshotPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<SnapshotPolicyResource>(Response.FromValue(new SnapshotPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Create a snapshot policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SnapshotPolicies_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="snapshotPolicyName"> The name of the snapshot policy. </param>
        /// <param name="data"> Snapshot policy object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SnapshotPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string snapshotPolicyName, SnapshotPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotPolicyName, nameof(snapshotPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _snapshotPolicyRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, snapshotPolicyName, data, cancellationToken);
                var operation = new NetAppArmOperation<SnapshotPolicyResource>(Response.FromValue(new SnapshotPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Get a snapshot Policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SnapshotPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotPolicyName"> The name of the snapshot policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotPolicyName"/> is null. </exception>
        public virtual async Task<Response<SnapshotPolicyResource>> GetAsync(string snapshotPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotPolicyName, nameof(snapshotPolicyName));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _snapshotPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, snapshotPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SnapshotPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a snapshot Policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SnapshotPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotPolicyName"> The name of the snapshot policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotPolicyName"/> is null. </exception>
        public virtual Response<SnapshotPolicyResource> Get(string snapshotPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotPolicyName, nameof(snapshotPolicyName));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _snapshotPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, snapshotPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SnapshotPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List snapshot policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SnapshotPolicies_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SnapshotPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SnapshotPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _snapshotPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new SnapshotPolicyResource(Client, SnapshotPolicyData.DeserializeSnapshotPolicyData(e)), _snapshotPolicyClientDiagnostics, Pipeline, "SnapshotPolicyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List snapshot policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SnapshotPolicies_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SnapshotPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SnapshotPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _snapshotPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new SnapshotPolicyResource(Client, SnapshotPolicyData.DeserializeSnapshotPolicyData(e)), _snapshotPolicyClientDiagnostics, Pipeline, "SnapshotPolicyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SnapshotPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotPolicyName"> The name of the snapshot policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string snapshotPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotPolicyName, nameof(snapshotPolicyName));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _snapshotPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, snapshotPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SnapshotPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotPolicyName"> The name of the snapshot policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string snapshotPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotPolicyName, nameof(snapshotPolicyName));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _snapshotPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, snapshotPolicyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SnapshotPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotPolicyName"> The name of the snapshot policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotPolicyName"/> is null. </exception>
        public virtual async Task<NullableResponse<SnapshotPolicyResource>> GetIfExistsAsync(string snapshotPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotPolicyName, nameof(snapshotPolicyName));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _snapshotPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, snapshotPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SnapshotPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new SnapshotPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/snapshotPolicies/{snapshotPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SnapshotPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotPolicyName"> The name of the snapshot policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotPolicyName"/> is null. </exception>
        public virtual NullableResponse<SnapshotPolicyResource> GetIfExists(string snapshotPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotPolicyName, nameof(snapshotPolicyName));

            using var scope = _snapshotPolicyClientDiagnostics.CreateScope("SnapshotPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _snapshotPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, snapshotPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SnapshotPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new SnapshotPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SnapshotPolicyResource> IEnumerable<SnapshotPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SnapshotPolicyResource> IAsyncEnumerable<SnapshotPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
