// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of JobAgent and their operations over its parent. </summary>
    public partial class JobAgentCollection : ArmCollection, IEnumerable<JobAgent>, IAsyncEnumerable<JobAgent>
    {
        private readonly ClientDiagnostics _jobAgentClientDiagnostics;
        private readonly JobAgentsRestOperations _jobAgentRestClient;

        /// <summary> Initializes a new instance of the <see cref="JobAgentCollection"/> class for mocking. </summary>
        protected JobAgentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="JobAgentCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal JobAgentCollection(ArmResource parent) : base(parent)
        {
            _jobAgentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", JobAgent.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(JobAgent.ResourceType, out string jobAgentApiVersion);
            _jobAgentRestClient = new JobAgentsRestOperations(_jobAgentClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, jobAgentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServer.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: JobAgents_CreateOrUpdate
        /// <summary> Creates or updates a job agent. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="jobAgentName"> The name of the job agent to be created or updated. </param>
        /// <param name="parameters"> The requested job agent resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual JobAgentCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string jobAgentName, JobAgentData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _jobAgentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, parameters, cancellationToken);
                var operation = new JobAgentCreateOrUpdateOperation(ArmClient, _jobAgentClientDiagnostics, Pipeline, _jobAgentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: JobAgents_CreateOrUpdate
        /// <summary> Creates or updates a job agent. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="jobAgentName"> The name of the job agent to be created or updated. </param>
        /// <param name="parameters"> The requested job agent resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<JobAgentCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string jobAgentName, JobAgentData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _jobAgentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new JobAgentCreateOrUpdateOperation(ArmClient, _jobAgentClientDiagnostics, Pipeline, _jobAgentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: JobAgents_Get
        /// <summary> Gets a job agent. </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public virtual Response<JobAgent> Get(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.Get");
            scope.Start();
            try
            {
                var response = _jobAgentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, cancellationToken);
                if (response.Value == null)
                    throw _jobAgentClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobAgent(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: JobAgents_Get
        /// <summary> Gets a job agent. </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public async virtual Task<Response<JobAgent>> GetAsync(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.Get");
            scope.Start();
            try
            {
                var response = await _jobAgentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _jobAgentClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new JobAgent(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public virtual Response<JobAgent> GetIfExists(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _jobAgentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<JobAgent>(null, response.GetRawResponse());
                return Response.FromValue(new JobAgent(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public async virtual Task<Response<JobAgent>> GetIfExistsAsync(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _jobAgentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobAgentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<JobAgent>(null, response.GetRawResponse());
                return Response.FromValue(new JobAgent(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public virtual Response<bool> Exists(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(jobAgentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobAgentName"> The name of the job agent to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobAgentName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobAgentName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string jobAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobAgentName, nameof(jobAgentName));

            using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(jobAgentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: JobAgents_ListByServer
        /// <summary> Gets a list of job agents in a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JobAgent" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JobAgent> GetAll(CancellationToken cancellationToken = default)
        {
            Page<JobAgent> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobAgentRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobAgent(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobAgent> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobAgentRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobAgent(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: JobAgents_ListByServer
        /// <summary> Gets a list of job agents in a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JobAgent" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JobAgent> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<JobAgent>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobAgentRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobAgent(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobAgent>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _jobAgentClientDiagnostics.CreateScope("JobAgentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobAgentRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobAgent(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<JobAgent> IEnumerable<JobAgent>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<JobAgent> IAsyncEnumerable<JobAgent>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
