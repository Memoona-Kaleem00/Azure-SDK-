// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.PolicyInsights.Models;

namespace Azure.ResourceManager.PolicyInsights
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _policyTrackedResourcesClientDiagnostics;
        private PolicyTrackedResourcesRestOperations _policyTrackedResourcesRestClient;
        private ClientDiagnostics _policyEventsClientDiagnostics;
        private PolicyEventsRestOperations _policyEventsRestClient;
        private ClientDiagnostics _policyStatesClientDiagnostics;
        private PolicyStatesRestOperations _policyStatesRestClient;
        private ClientDiagnostics _policyRestrictionsClientDiagnostics;
        private PolicyRestrictionsRestOperations _policyRestrictionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics PolicyTrackedResourcesClientDiagnostics => _policyTrackedResourcesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PolicyTrackedResourcesRestOperations PolicyTrackedResourcesRestClient => _policyTrackedResourcesRestClient ??= new PolicyTrackedResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics PolicyEventsClientDiagnostics => _policyEventsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PolicyEventsRestOperations PolicyEventsRestClient => _policyEventsRestClient ??= new PolicyEventsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics PolicyStatesClientDiagnostics => _policyStatesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PolicyStatesRestOperations PolicyStatesRestClient => _policyStatesRestClient ??= new PolicyStatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics PolicyRestrictionsClientDiagnostics => _policyRestrictionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PolicyRestrictionsRestOperations PolicyRestrictionsRestClient => _policyRestrictionsRestClient ??= new PolicyRestrictionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Queries policy tracked resources under the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyTrackedResources/{policyTrackedResourcesResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyTrackedResources_ListQueryResultsForResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyTrackedResourceType"> The name of the virtual resource under PolicyTrackedResources resource type; only "default" is allowed. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyTrackedResourceRecord" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyTrackedResourceRecord> GetPolicyTrackedResourceQueryResultsAsync(PolicyTrackedResourceType policyTrackedResourceType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyTrackedResourcesRestClient.CreateListQueryResultsForResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, policyTrackedResourceType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyTrackedResourcesRestClient.CreateListQueryResultsForResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, policyTrackedResourceType, policyQuerySettings);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, PolicyTrackedResourceRecord.DeserializePolicyTrackedResourceRecord, PolicyTrackedResourcesClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetPolicyTrackedResourceQueryResults", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Queries policy tracked resources under the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyTrackedResources/{policyTrackedResourcesResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyTrackedResources_ListQueryResultsForResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyTrackedResourceType"> The name of the virtual resource under PolicyTrackedResources resource type; only "default" is allowed. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyTrackedResourceRecord" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyTrackedResourceRecord> GetPolicyTrackedResourceQueryResults(PolicyTrackedResourceType policyTrackedResourceType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyTrackedResourcesRestClient.CreateListQueryResultsForResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, policyTrackedResourceType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyTrackedResourcesRestClient.CreateListQueryResultsForResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, policyTrackedResourceType, policyQuerySettings);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, PolicyTrackedResourceRecord.DeserializePolicyTrackedResourceRecord, PolicyTrackedResourcesClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetPolicyTrackedResourceQueryResults", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Queries policy events for the resources under the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyEvents/{policyEventsResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyEvents_ListQueryResultsForResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyEventType"> The name of the virtual resource under PolicyEvents resource type; only "default" is allowed. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyEvent" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyEvent> GetPolicyEventQueryResultsAsync(PolicyEventType policyEventType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyEventsRestClient.CreateListQueryResultsForResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, policyEventType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyEventsRestClient.CreateListQueryResultsForResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, policyEventType, policyQuerySettings);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, PolicyEvent.DeserializePolicyEvent, PolicyEventsClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetPolicyEventQueryResults", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Queries policy events for the resources under the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyEvents/{policyEventsResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyEvents_ListQueryResultsForResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyEventType"> The name of the virtual resource under PolicyEvents resource type; only "default" is allowed. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyEvent" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyEvent> GetPolicyEventQueryResults(PolicyEventType policyEventType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyEventsRestClient.CreateListQueryResultsForResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, policyEventType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyEventsRestClient.CreateListQueryResultsForResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, policyEventType, policyQuerySettings);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, PolicyEvent.DeserializePolicyEvent, PolicyEventsClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetPolicyEventQueryResults", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Queries policy states for the resources under the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyStates_ListQueryResultsForResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyStateType"> The virtual resource under PolicyStates resource type. In a given time range, 'latest' represents the latest policy state(s), whereas 'default' represents all policy state(s). </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyState" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyState> GetPolicyStateQueryResultsAsync(PolicyStateType policyStateType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyStatesRestClient.CreateListQueryResultsForResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, policyStateType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyStatesRestClient.CreateListQueryResultsForResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, policyStateType, policyQuerySettings);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, PolicyState.DeserializePolicyState, PolicyStatesClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetPolicyStateQueryResults", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Queries policy states for the resources under the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesResource}/queryResults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyStates_ListQueryResultsForResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyStateType"> The virtual resource under PolicyStates resource type. In a given time range, 'latest' represents the latest policy state(s), whereas 'default' represents all policy state(s). </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyState" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyState> GetPolicyStateQueryResults(PolicyStateType policyStateType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyStatesRestClient.CreateListQueryResultsForResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, policyStateType, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PolicyStatesRestClient.CreateListQueryResultsForResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, policyStateType, policyQuerySettings);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, PolicyState.DeserializePolicyState, PolicyStatesClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetPolicyStateQueryResults", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Summarizes policy states for the resources under the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesSummaryResource}/summarize</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyStates_SummarizeForResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyStateSummaryType"> The virtual resource under PolicyStates resource type for summarize action. In a given time range, 'latest' represents the latest policy state(s) and is the only allowed value. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicySummary" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicySummary> SummarizePolicyStatesAsync(PolicyStateSummaryType policyStateSummaryType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyStatesRestClient.CreateSummarizeForResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, policyStateSummaryType, policyQuerySettings);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, PolicySummary.DeserializePolicySummary, PolicyStatesClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.SummarizePolicyStates", "value", null, cancellationToken);
        }

        /// <summary>
        /// Summarizes policy states for the resources under the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesSummaryResource}/summarize</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyStates_SummarizeForResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyStateSummaryType"> The virtual resource under PolicyStates resource type for summarize action. In a given time range, 'latest' represents the latest policy state(s) and is the only allowed value. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicySummary" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicySummary> SummarizePolicyStates(PolicyStateSummaryType policyStateSummaryType, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PolicyStatesRestClient.CreateSummarizeForResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, policyStateSummaryType, policyQuerySettings);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, null, PolicySummary.DeserializePolicySummary, PolicyStatesClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.SummarizePolicyStates", "value", null, cancellationToken);
        }

        /// <summary>
        /// Triggers a policy evaluation scan for all the resources under the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyStates/latest/triggerEvaluation</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyStates_TriggerResourceGroupEvaluation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> TriggerPolicyStateEvaluationAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = PolicyStatesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.TriggerPolicyStateEvaluation");
            scope.Start();
            try
            {
                var response = await PolicyStatesRestClient.TriggerResourceGroupEvaluationAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                var operation = new PolicyInsightsArmOperation(PolicyStatesClientDiagnostics, Pipeline, PolicyStatesRestClient.CreateTriggerResourceGroupEvaluationRequest(Id.SubscriptionId, Id.ResourceGroupName).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Triggers a policy evaluation scan for all the resources under the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyStates/latest/triggerEvaluation</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyStates_TriggerResourceGroupEvaluation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation TriggerPolicyStateEvaluation(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = PolicyStatesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.TriggerPolicyStateEvaluation");
            scope.Start();
            try
            {
                var response = PolicyStatesRestClient.TriggerResourceGroupEvaluation(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                var operation = new PolicyInsightsArmOperation(PolicyStatesClientDiagnostics, Pipeline, PolicyStatesRestClient.CreateTriggerResourceGroupEvaluationRequest(Id.SubscriptionId, Id.ResourceGroupName).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks what restrictions Azure Policy will place on a resource within a resource group. Use this when the resource group the resource will be created in is already known.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/checkPolicyRestrictions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyRestrictions_CheckAtResourceGroupScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The check policy restrictions parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckPolicyRestrictionsResult>> CheckPolicyRestrictionsAsync(CheckPolicyRestrictionsContent content, CancellationToken cancellationToken = default)
        {
            using var scope = PolicyRestrictionsClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.CheckPolicyRestrictions");
            scope.Start();
            try
            {
                var response = await PolicyRestrictionsRestClient.CheckAtResourceGroupScopeAsync(Id.SubscriptionId, Id.ResourceGroupName, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks what restrictions Azure Policy will place on a resource within a resource group. Use this when the resource group the resource will be created in is already known.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/checkPolicyRestrictions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyRestrictions_CheckAtResourceGroupScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The check policy restrictions parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckPolicyRestrictionsResult> CheckPolicyRestrictions(CheckPolicyRestrictionsContent content, CancellationToken cancellationToken = default)
        {
            using var scope = PolicyRestrictionsClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.CheckPolicyRestrictions");
            scope.Start();
            try
            {
                var response = PolicyRestrictionsRestClient.CheckAtResourceGroupScope(Id.SubscriptionId, Id.ResourceGroupName, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
