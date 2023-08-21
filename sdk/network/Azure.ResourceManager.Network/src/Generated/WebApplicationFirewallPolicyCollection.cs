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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="WebApplicationFirewallPolicyResource" /> and their operations.
    /// Each <see cref="WebApplicationFirewallPolicyResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="WebApplicationFirewallPolicyCollection" /> instance call the GetWebApplicationFirewallPolicies method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class WebApplicationFirewallPolicyCollection : ArmCollection, IEnumerable<WebApplicationFirewallPolicyResource>, IAsyncEnumerable<WebApplicationFirewallPolicyResource>
    {
        private readonly ClientDiagnostics _webApplicationFirewallPolicyClientDiagnostics;
        private readonly WebApplicationFirewallPoliciesRestOperations _webApplicationFirewallPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebApplicationFirewallPolicyCollection"/> class for mocking. </summary>
        protected WebApplicationFirewallPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebApplicationFirewallPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebApplicationFirewallPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webApplicationFirewallPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", WebApplicationFirewallPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebApplicationFirewallPolicyResource.ResourceType, out string webApplicationFirewallPolicyApiVersion);
            _webApplicationFirewallPolicyRestClient = new WebApplicationFirewallPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webApplicationFirewallPolicyApiVersion);
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
        /// Creates or update policy with specified rule set name within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApplicationFirewallPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="data"> Policy to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WebApplicationFirewallPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string policyName, WebApplicationFirewallPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webApplicationFirewallPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, policyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<WebApplicationFirewallPolicyResource>(Response.FromValue(new WebApplicationFirewallPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Creates or update policy with specified rule set name within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApplicationFirewallPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="data"> Policy to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WebApplicationFirewallPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string policyName, WebApplicationFirewallPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webApplicationFirewallPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, policyName, data, cancellationToken);
                var operation = new NetworkArmOperation<WebApplicationFirewallPolicyResource>(Response.FromValue(new WebApplicationFirewallPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve protection policy with specified name within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApplicationFirewallPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<Response<WebApplicationFirewallPolicyResource>> GetAsync(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _webApplicationFirewallPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebApplicationFirewallPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve protection policy with specified name within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApplicationFirewallPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<WebApplicationFirewallPolicyResource> Get(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _webApplicationFirewallPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebApplicationFirewallPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the protection policies within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApplicationFirewallPolicies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebApplicationFirewallPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebApplicationFirewallPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webApplicationFirewallPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webApplicationFirewallPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WebApplicationFirewallPolicyResource(Client, WebApplicationFirewallPolicyData.DeserializeWebApplicationFirewallPolicyData(e)), _webApplicationFirewallPolicyClientDiagnostics, Pipeline, "WebApplicationFirewallPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the protection policies within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApplicationFirewallPolicies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebApplicationFirewallPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebApplicationFirewallPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webApplicationFirewallPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webApplicationFirewallPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WebApplicationFirewallPolicyResource(Client, WebApplicationFirewallPolicyData.DeserializeWebApplicationFirewallPolicyData(e)), _webApplicationFirewallPolicyClientDiagnostics, Pipeline, "WebApplicationFirewallPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApplicationFirewallPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webApplicationFirewallPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApplicationFirewallPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public virtual Response<bool> Exists(string policyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyName, nameof(policyName));

            using var scope = _webApplicationFirewallPolicyClientDiagnostics.CreateScope("WebApplicationFirewallPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _webApplicationFirewallPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, policyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebApplicationFirewallPolicyResource> IEnumerable<WebApplicationFirewallPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebApplicationFirewallPolicyResource> IAsyncEnumerable<WebApplicationFirewallPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
