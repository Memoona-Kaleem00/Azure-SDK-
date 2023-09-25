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

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceBusTopicAuthorizationRuleResource" /> and their operations.
    /// Each <see cref="ServiceBusTopicAuthorizationRuleResource" /> in the collection will belong to the same instance of <see cref="ServiceBusTopicResource" />.
    /// To get a <see cref="ServiceBusTopicAuthorizationRuleCollection" /> instance call the GetServiceBusTopicAuthorizationRules method from an instance of <see cref="ServiceBusTopicResource" />.
    /// </summary>
    public partial class ServiceBusTopicAuthorizationRuleCollection : ArmCollection, IEnumerable<ServiceBusTopicAuthorizationRuleResource>, IAsyncEnumerable<ServiceBusTopicAuthorizationRuleResource>
    {
        private readonly ClientDiagnostics _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics;
        private readonly TopicAuthorizationRulesRestOperations _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceBusTopicAuthorizationRuleCollection"/> class for mocking. </summary>
        protected ServiceBusTopicAuthorizationRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusTopicAuthorizationRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceBusTopicAuthorizationRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ServiceBusTopicAuthorizationRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceBusTopicAuthorizationRuleResource.ResourceType, out string serviceBusTopicAuthorizationRuleTopicAuthorizationRulesApiVersion);
            _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient = new TopicAuthorizationRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceBusTopicAuthorizationRuleTopicAuthorizationRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceBusTopicResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceBusTopicResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates an authorization rule for the specified topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="data"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceBusTopicAuthorizationRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string authorizationRuleName, ServiceBusAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<ServiceBusTopicAuthorizationRuleResource>(Response.FromValue(new ServiceBusTopicAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Creates an authorization rule for the specified topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="data"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceBusTopicAuthorizationRuleResource> CreateOrUpdate(WaitUntil waitUntil, string authorizationRuleName, ServiceBusAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, data, cancellationToken);
                var operation = new ServiceBusArmOperation<ServiceBusTopicAuthorizationRuleResource>(Response.FromValue(new ServiceBusTopicAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Returns the specified authorization rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<ServiceBusTopicAuthorizationRuleResource>> GetAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusTopicAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the specified authorization rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<ServiceBusTopicAuthorizationRuleResource> Get(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusTopicAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets authorization rules for a topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceBusTopicAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceBusTopicAuthorizationRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceBusTopicAuthorizationRuleResource(Client, ServiceBusAuthorizationRuleData.DeserializeServiceBusAuthorizationRuleData(e)), _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics, Pipeline, "ServiceBusTopicAuthorizationRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets authorization rules for a topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceBusTopicAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceBusTopicAuthorizationRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceBusTopicAuthorizationRuleResource(Client, ServiceBusAuthorizationRuleData.DeserializeServiceBusAuthorizationRuleData(e)), _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics, Pipeline, "ServiceBusTopicAuthorizationRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceBusTopicAuthorizationRuleResource>> GetIfExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceBusTopicAuthorizationRuleResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceBusTopicAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopicAuthorizationRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual NullableResponse<ServiceBusTopicAuthorizationRuleResource> GetIfExists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusTopicAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceBusTopicAuthorizationRuleTopicAuthorizationRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceBusTopicAuthorizationRuleResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceBusTopicAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceBusTopicAuthorizationRuleResource> IEnumerable<ServiceBusTopicAuthorizationRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceBusTopicAuthorizationRuleResource> IAsyncEnumerable<ServiceBusTopicAuthorizationRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
