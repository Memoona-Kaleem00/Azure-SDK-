// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Logic
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _workflowClientDiagnostics;
        private WorkflowsRestOperations _workflowRestClient;
        private ClientDiagnostics _integrationAccountClientDiagnostics;
        private IntegrationAccountsRestOperations _integrationAccountRestClient;
        private ClientDiagnostics _integrationServiceEnvironmentClientDiagnostics;
        private IntegrationServiceEnvironmentsRestOperations _integrationServiceEnvironmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics WorkflowClientDiagnostics => _workflowClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Logic", WorkflowResource.ResourceType.Namespace, Diagnostics);
        private WorkflowsRestOperations WorkflowRestClient => _workflowRestClient ??= new WorkflowsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(WorkflowResource.ResourceType));
        private ClientDiagnostics IntegrationAccountClientDiagnostics => _integrationAccountClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Logic", IntegrationAccountResource.ResourceType.Namespace, Diagnostics);
        private IntegrationAccountsRestOperations IntegrationAccountRestClient => _integrationAccountRestClient ??= new IntegrationAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(IntegrationAccountResource.ResourceType));
        private ClientDiagnostics IntegrationServiceEnvironmentClientDiagnostics => _integrationServiceEnvironmentClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Logic", IntegrationServiceEnvironmentResource.ResourceType.Namespace, Diagnostics);
        private IntegrationServiceEnvironmentsRestOperations IntegrationServiceEnvironmentRestClient => _integrationServiceEnvironmentRestClient ??= new IntegrationServiceEnvironmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(IntegrationServiceEnvironmentResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets a list of workflows by subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Logic/workflows
        /// Operation Id: Workflows_ListBySubscription
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: State, Trigger, and ReferencedResourceId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkflowResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkflowResource> GetWorkflowsAsync(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<WorkflowResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = WorkflowClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetWorkflows");
                scope.Start();
                try
                {
                    var response = await WorkflowRestClient.ListBySubscriptionAsync(Id.SubscriptionId, top, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkflowResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<WorkflowResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = WorkflowClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetWorkflows");
                scope.Start();
                try
                {
                    var response = await WorkflowRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, top, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkflowResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of workflows by subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Logic/workflows
        /// Operation Id: Workflows_ListBySubscription
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: State, Trigger, and ReferencedResourceId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkflowResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkflowResource> GetWorkflows(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Page<WorkflowResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = WorkflowClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetWorkflows");
                scope.Start();
                try
                {
                    var response = WorkflowRestClient.ListBySubscription(Id.SubscriptionId, top, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkflowResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<WorkflowResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = WorkflowClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetWorkflows");
                scope.Start();
                try
                {
                    var response = WorkflowRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, top, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkflowResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of integration accounts by subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Logic/integrationAccounts
        /// Operation Id: IntegrationAccounts_ListBySubscription
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IntegrationAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IntegrationAccountResource> GetIntegrationAccountsAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<IntegrationAccountResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = IntegrationAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetIntegrationAccounts");
                scope.Start();
                try
                {
                    var response = await IntegrationAccountRestClient.ListBySubscriptionAsync(Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IntegrationAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<IntegrationAccountResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = IntegrationAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetIntegrationAccounts");
                scope.Start();
                try
                {
                    var response = await IntegrationAccountRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IntegrationAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of integration accounts by subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Logic/integrationAccounts
        /// Operation Id: IntegrationAccounts_ListBySubscription
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IntegrationAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IntegrationAccountResource> GetIntegrationAccounts(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<IntegrationAccountResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = IntegrationAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetIntegrationAccounts");
                scope.Start();
                try
                {
                    var response = IntegrationAccountRestClient.ListBySubscription(Id.SubscriptionId, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IntegrationAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<IntegrationAccountResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = IntegrationAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetIntegrationAccounts");
                scope.Start();
                try
                {
                    var response = IntegrationAccountRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IntegrationAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of integration service environments by subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Logic/integrationServiceEnvironments
        /// Operation Id: IntegrationServiceEnvironments_ListBySubscription
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IntegrationServiceEnvironmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IntegrationServiceEnvironmentResource> GetIntegrationServiceEnvironmentsAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<IntegrationServiceEnvironmentResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = IntegrationServiceEnvironmentClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetIntegrationServiceEnvironments");
                scope.Start();
                try
                {
                    var response = await IntegrationServiceEnvironmentRestClient.ListBySubscriptionAsync(Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IntegrationServiceEnvironmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<IntegrationServiceEnvironmentResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = IntegrationServiceEnvironmentClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetIntegrationServiceEnvironments");
                scope.Start();
                try
                {
                    var response = await IntegrationServiceEnvironmentRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IntegrationServiceEnvironmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of integration service environments by subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Logic/integrationServiceEnvironments
        /// Operation Id: IntegrationServiceEnvironments_ListBySubscription
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IntegrationServiceEnvironmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IntegrationServiceEnvironmentResource> GetIntegrationServiceEnvironments(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<IntegrationServiceEnvironmentResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = IntegrationServiceEnvironmentClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetIntegrationServiceEnvironments");
                scope.Start();
                try
                {
                    var response = IntegrationServiceEnvironmentRestClient.ListBySubscription(Id.SubscriptionId, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IntegrationServiceEnvironmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<IntegrationServiceEnvironmentResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = IntegrationServiceEnvironmentClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetIntegrationServiceEnvironments");
                scope.Start();
                try
                {
                    var response = IntegrationServiceEnvironmentRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IntegrationServiceEnvironmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
