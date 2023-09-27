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

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="AuthorizationPolicyResourceFormatResource" /> and their operations.
    /// Each <see cref="AuthorizationPolicyResourceFormatResource" /> in the collection will belong to the same instance of <see cref="HubResource" />.
    /// To get an <see cref="AuthorizationPolicyResourceFormatCollection" /> instance call the GetAuthorizationPolicyResourceFormats method from an instance of <see cref="HubResource" />.
    /// </summary>
    public partial class AuthorizationPolicyResourceFormatCollection : ArmCollection, IEnumerable<AuthorizationPolicyResourceFormatResource>, IAsyncEnumerable<AuthorizationPolicyResourceFormatResource>
    {
        private readonly ClientDiagnostics _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics;
        private readonly AuthorizationPoliciesRestOperations _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AuthorizationPolicyResourceFormatCollection"/> class for mocking. </summary>
        protected AuthorizationPolicyResourceFormatCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AuthorizationPolicyResourceFormatCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AuthorizationPolicyResourceFormatCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", AuthorizationPolicyResourceFormatResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AuthorizationPolicyResourceFormatResource.ResourceType, out string authorizationPolicyResourceFormatAuthorizationPoliciesApiVersion);
            _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient = new AuthorizationPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, authorizationPolicyResourceFormatAuthorizationPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates an authorization policy or updates an existing authorization policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationPolicyName"> The name of the policy. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate authorization policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AuthorizationPolicyResourceFormatResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string authorizationPolicyName, AuthorizationPolicyResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationPolicyName, nameof(authorizationPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation<AuthorizationPolicyResourceFormatResource>(Response.FromValue(new AuthorizationPolicyResourceFormatResource(Client, response), response.GetRawResponse()));
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
        /// Creates an authorization policy or updates an existing authorization policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationPolicyName"> The name of the policy. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate authorization policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AuthorizationPolicyResourceFormatResource> CreateOrUpdate(WaitUntil waitUntil, string authorizationPolicyName, AuthorizationPolicyResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationPolicyName, nameof(authorizationPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationPolicyName, data, cancellationToken);
                var operation = new CustomerInsightsArmOperation<AuthorizationPolicyResourceFormatResource>(Response.FromValue(new AuthorizationPolicyResourceFormatResource(Client, response), response.GetRawResponse()));
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
        /// Gets an authorization policy in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationPolicyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationPolicyName"/> is null. </exception>
        public virtual async Task<Response<AuthorizationPolicyResourceFormatResource>> GetAsync(string authorizationPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationPolicyName, nameof(authorizationPolicyName));

            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = await _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AuthorizationPolicyResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an authorization policy in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationPolicyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationPolicyName"/> is null. </exception>
        public virtual Response<AuthorizationPolicyResourceFormatResource> Get(string authorizationPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationPolicyName, nameof(authorizationPolicyName));

            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AuthorizationPolicyResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the authorization policies in a specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_ListByHub</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AuthorizationPolicyResourceFormatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AuthorizationPolicyResourceFormatResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.CreateListByHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.CreateListByHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AuthorizationPolicyResourceFormatResource(Client, AuthorizationPolicyResourceFormatData.DeserializeAuthorizationPolicyResourceFormatData(e)), _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics, Pipeline, "AuthorizationPolicyResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the authorization policies in a specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_ListByHub</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AuthorizationPolicyResourceFormatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AuthorizationPolicyResourceFormatResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.CreateListByHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.CreateListByHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AuthorizationPolicyResourceFormatResource(Client, AuthorizationPolicyResourceFormatData.DeserializeAuthorizationPolicyResourceFormatData(e)), _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics, Pipeline, "AuthorizationPolicyResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationPolicyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string authorizationPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationPolicyName, nameof(authorizationPolicyName));

            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = await _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationPolicyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationPolicyName, nameof(authorizationPolicyName));

            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationPolicyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationPolicyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationPolicyName"/> is null. </exception>
        public virtual async Task<NullableResponse<AuthorizationPolicyResourceFormatResource>> GetIfExistsAsync(string authorizationPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationPolicyName, nameof(authorizationPolicyName));

            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AuthorizationPolicyResourceFormatResource>(response.GetRawResponse());
                return Response.FromValue(new AuthorizationPolicyResourceFormatResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/authorizationPolicies/{authorizationPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationPolicyName"> The name of the policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationPolicyName"/> is null. </exception>
        public virtual NullableResponse<AuthorizationPolicyResourceFormatResource> GetIfExists(string authorizationPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationPolicyName, nameof(authorizationPolicyName));

            using var scope = _authorizationPolicyResourceFormatAuthorizationPoliciesClientDiagnostics.CreateScope("AuthorizationPolicyResourceFormatCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _authorizationPolicyResourceFormatAuthorizationPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AuthorizationPolicyResourceFormatResource>(response.GetRawResponse());
                return Response.FromValue(new AuthorizationPolicyResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AuthorizationPolicyResourceFormatResource> IEnumerable<AuthorizationPolicyResourceFormatResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AuthorizationPolicyResourceFormatResource> IAsyncEnumerable<AuthorizationPolicyResourceFormatResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
