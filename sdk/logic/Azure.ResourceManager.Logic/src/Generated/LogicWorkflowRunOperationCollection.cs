// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing a collection of <see cref="LogicWorkflowRunOperationResource" /> and their operations.
    /// Each <see cref="LogicWorkflowRunOperationResource" /> in the collection will belong to the same instance of <see cref="LogicWorkflowRunResource" />.
    /// To get a <see cref="LogicWorkflowRunOperationCollection" /> instance call the GetLogicWorkflowRunOperations method from an instance of <see cref="LogicWorkflowRunResource" />.
    /// </summary>
    public partial class LogicWorkflowRunOperationCollection : ArmCollection
    {
        private readonly ClientDiagnostics _logicWorkflowRunOperationWorkflowRunOperationsClientDiagnostics;
        private readonly WorkflowRunRestOperations _logicWorkflowRunOperationWorkflowRunOperationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunOperationCollection"/> class for mocking. </summary>
        protected LogicWorkflowRunOperationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunOperationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LogicWorkflowRunOperationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicWorkflowRunOperationWorkflowRunOperationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", LogicWorkflowRunOperationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LogicWorkflowRunOperationResource.ResourceType, out string logicWorkflowRunOperationWorkflowRunOperationsApiVersion);
            _logicWorkflowRunOperationWorkflowRunOperationsRestClient = new WorkflowRunRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowRunOperationWorkflowRunOperationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LogicWorkflowRunResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LogicWorkflowRunResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets an operation for a run.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/operations/{operationId}
        /// Operation Id: WorkflowRunOperations_Get
        /// </summary>
        /// <param name="operationId"> The workflow operation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual async Task<Response<LogicWorkflowRunOperationResource>> GetAsync(string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = _logicWorkflowRunOperationWorkflowRunOperationsClientDiagnostics.CreateScope("LogicWorkflowRunOperationCollection.Get");
            scope.Start();
            try
            {
                var response = await _logicWorkflowRunOperationWorkflowRunOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an operation for a run.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/operations/{operationId}
        /// Operation Id: WorkflowRunOperations_Get
        /// </summary>
        /// <param name="operationId"> The workflow operation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual Response<LogicWorkflowRunOperationResource> Get(string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = _logicWorkflowRunOperationWorkflowRunOperationsClientDiagnostics.CreateScope("LogicWorkflowRunOperationCollection.Get");
            scope.Start();
            try
            {
                var response = _logicWorkflowRunOperationWorkflowRunOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowRunOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/operations/{operationId}
        /// Operation Id: WorkflowRunOperations_Get
        /// </summary>
        /// <param name="operationId"> The workflow operation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = _logicWorkflowRunOperationWorkflowRunOperationsClientDiagnostics.CreateScope("LogicWorkflowRunOperationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _logicWorkflowRunOperationWorkflowRunOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/operations/{operationId}
        /// Operation Id: WorkflowRunOperations_Get
        /// </summary>
        /// <param name="operationId"> The workflow operation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual Response<bool> Exists(string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = _logicWorkflowRunOperationWorkflowRunOperationsClientDiagnostics.CreateScope("LogicWorkflowRunOperationCollection.Exists");
            scope.Start();
            try
            {
                var response = _logicWorkflowRunOperationWorkflowRunOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, operationId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
