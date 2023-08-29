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

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    /// <summary>
    /// A class representing a collection of <see cref="WorkflowModelResource" /> and their operations.
    /// Each <see cref="WorkflowModelResource" /> in the collection will belong to the same instance of <see cref="VaultModelResource" />.
    /// To get a <see cref="WorkflowModelCollection" /> instance call the GetWorkflowModels method from an instance of <see cref="VaultModelResource" />.
    /// </summary>
    public partial class WorkflowModelCollection : ArmCollection, IEnumerable<WorkflowModelResource>, IAsyncEnumerable<WorkflowModelResource>
    {
        private readonly ClientDiagnostics _workflowModelWorkflowClientDiagnostics;
        private readonly WorkflowRestOperations _workflowModelWorkflowRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkflowModelCollection"/> class for mocking. </summary>
        protected WorkflowModelCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkflowModelCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkflowModelCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workflowModelWorkflowClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesDataReplication", WorkflowModelResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkflowModelResource.ResourceType, out string workflowModelWorkflowApiVersion);
            _workflowModelWorkflowRestClient = new WorkflowRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workflowModelWorkflowApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VaultModelResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VaultModelResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the details of the job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflow_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The job (workflow) name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<WorkflowModelResource>> GetAsync(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _workflowModelWorkflowClientDiagnostics.CreateScope("WorkflowModelCollection.Get");
            scope.Start();
            try
            {
                var response = await _workflowModelWorkflowRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkflowModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflow_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The job (workflow) name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<WorkflowModelResource> Get(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _workflowModelWorkflowClientDiagnostics.CreateScope("WorkflowModelCollection.Get");
            scope.Start();
            try
            {
                var response = _workflowModelWorkflowRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkflowModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of jobs in the given vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/jobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflow_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter string. </param>
        /// <param name="continuationToken"> Continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkflowModelResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkflowModelResource> GetAllAsync(string filter = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workflowModelWorkflowRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workflowModelWorkflowRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, continuationToken);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WorkflowModelResource(Client, WorkflowModelData.DeserializeWorkflowModelData(e)), _workflowModelWorkflowClientDiagnostics, Pipeline, "WorkflowModelCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of jobs in the given vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/jobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflow_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter string. </param>
        /// <param name="continuationToken"> Continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkflowModelResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkflowModelResource> GetAll(string filter = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workflowModelWorkflowRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workflowModelWorkflowRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, continuationToken);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WorkflowModelResource(Client, WorkflowModelData.DeserializeWorkflowModelData(e)), _workflowModelWorkflowClientDiagnostics, Pipeline, "WorkflowModelCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflow_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The job (workflow) name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _workflowModelWorkflowClientDiagnostics.CreateScope("WorkflowModelCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workflowModelWorkflowRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflow_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> The job (workflow) name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        public virtual Response<bool> Exists(string jobName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var scope = _workflowModelWorkflowClientDiagnostics.CreateScope("WorkflowModelCollection.Exists");
            scope.Start();
            try
            {
                var response = _workflowModelWorkflowRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkflowModelResource> IEnumerable<WorkflowModelResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkflowModelResource> IAsyncEnumerable<WorkflowModelResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
