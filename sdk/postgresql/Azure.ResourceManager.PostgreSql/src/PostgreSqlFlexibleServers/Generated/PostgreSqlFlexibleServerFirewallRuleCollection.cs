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

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    /// <summary>
    /// A class representing a collection of <see cref="PostgreSqlFlexibleServerFirewallRuleResource" /> and their operations.
    /// Each <see cref="PostgreSqlFlexibleServerFirewallRuleResource" /> in the collection will belong to the same instance of <see cref="PostgreSqlFlexibleServerResource" />.
    /// To get a <see cref="PostgreSqlFlexibleServerFirewallRuleCollection" /> instance call the GetPostgreSqlFlexibleServerFirewallRules method from an instance of <see cref="PostgreSqlFlexibleServerResource" />.
    /// </summary>
    public partial class PostgreSqlFlexibleServerFirewallRuleCollection : ArmCollection, IEnumerable<PostgreSqlFlexibleServerFirewallRuleResource>, IAsyncEnumerable<PostgreSqlFlexibleServerFirewallRuleResource>
    {
        private readonly ClientDiagnostics _postgreSqlFlexibleServerFirewallRuleFirewallRulesClientDiagnostics;
        private readonly FirewallRulesRestOperations _postgreSqlFlexibleServerFirewallRuleFirewallRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlFlexibleServerFirewallRuleCollection"/> class for mocking. </summary>
        protected PostgreSqlFlexibleServerFirewallRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlFlexibleServerFirewallRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PostgreSqlFlexibleServerFirewallRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _postgreSqlFlexibleServerFirewallRuleFirewallRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql.FlexibleServers", PostgreSqlFlexibleServerFirewallRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PostgreSqlFlexibleServerFirewallRuleResource.ResourceType, out string postgreSqlFlexibleServerFirewallRuleFirewallRulesApiVersion);
            _postgreSqlFlexibleServerFirewallRuleFirewallRulesRestClient = new FirewallRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, postgreSqlFlexibleServerFirewallRuleFirewallRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PostgreSqlFlexibleServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PostgreSqlFlexibleServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new firewall rule or updates an existing firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firewallRuleName"> The name of the server firewall rule. </param>
        /// <param name="data"> The required parameters for creating or updating a firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PostgreSqlFlexibleServerFirewallRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string firewallRuleName, PostgreSqlFlexibleServerFirewallRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlFlexibleServerFirewallRuleFirewallRulesClientDiagnostics.CreateScope("PostgreSqlFlexibleServerFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerFirewallRuleFirewallRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new FlexibleServersArmOperation<PostgreSqlFlexibleServerFirewallRuleResource>(new PostgreSqlFlexibleServerFirewallRuleOperationSource(Client), _postgreSqlFlexibleServerFirewallRuleFirewallRulesClientDiagnostics, Pipeline, _postgreSqlFlexibleServerFirewallRuleFirewallRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a new firewall rule or updates an existing firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firewallRuleName"> The name of the server firewall rule. </param>
        /// <param name="data"> The required parameters for creating or updating a firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PostgreSqlFlexibleServerFirewallRuleResource> CreateOrUpdate(WaitUntil waitUntil, string firewallRuleName, PostgreSqlFlexibleServerFirewallRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlFlexibleServerFirewallRuleFirewallRulesClientDiagnostics.CreateScope("PostgreSqlFlexibleServerFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerFirewallRuleFirewallRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data, cancellationToken);
                var operation = new FlexibleServersArmOperation<PostgreSqlFlexibleServerFirewallRuleResource>(new PostgreSqlFlexibleServerFirewallRuleOperationSource(Client), _postgreSqlFlexibleServerFirewallRuleFirewallRulesClientDiagnostics, Pipeline, _postgreSqlFlexibleServerFirewallRuleFirewallRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// List all the firewall rules in a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the server firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual async Task<Response<PostgreSqlFlexibleServerFirewallRuleResource>> GetAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _postgreSqlFlexibleServerFirewallRuleFirewallRulesClientDiagnostics.CreateScope("PostgreSqlFlexibleServerFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerFirewallRuleFirewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFlexibleServerFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the firewall rules in a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the server firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual Response<PostgreSqlFlexibleServerFirewallRuleResource> Get(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _postgreSqlFlexibleServerFirewallRuleFirewallRulesClientDiagnostics.CreateScope("PostgreSqlFlexibleServerFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerFirewallRuleFirewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFlexibleServerFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the firewall rules in a given PostgreSQL server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/firewallRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlFlexibleServerFirewallRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlFlexibleServerFirewallRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlFlexibleServerFirewallRuleFirewallRulesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlFlexibleServerFirewallRuleFirewallRulesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlFlexibleServerFirewallRuleResource(Client, PostgreSqlFlexibleServerFirewallRuleData.DeserializePostgreSqlFlexibleServerFirewallRuleData(e)), _postgreSqlFlexibleServerFirewallRuleFirewallRulesClientDiagnostics, Pipeline, "PostgreSqlFlexibleServerFirewallRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the firewall rules in a given PostgreSQL server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/firewallRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlFlexibleServerFirewallRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlFlexibleServerFirewallRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlFlexibleServerFirewallRuleFirewallRulesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlFlexibleServerFirewallRuleFirewallRulesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlFlexibleServerFirewallRuleResource(Client, PostgreSqlFlexibleServerFirewallRuleData.DeserializePostgreSqlFlexibleServerFirewallRuleData(e)), _postgreSqlFlexibleServerFirewallRuleFirewallRulesClientDiagnostics, Pipeline, "PostgreSqlFlexibleServerFirewallRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the server firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _postgreSqlFlexibleServerFirewallRuleFirewallRulesClientDiagnostics.CreateScope("PostgreSqlFlexibleServerFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerFirewallRuleFirewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the server firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _postgreSqlFlexibleServerFirewallRuleFirewallRulesClientDiagnostics.CreateScope("PostgreSqlFlexibleServerFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerFirewallRuleFirewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PostgreSqlFlexibleServerFirewallRuleResource> IEnumerable<PostgreSqlFlexibleServerFirewallRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PostgreSqlFlexibleServerFirewallRuleResource> IAsyncEnumerable<PostgreSqlFlexibleServerFirewallRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
