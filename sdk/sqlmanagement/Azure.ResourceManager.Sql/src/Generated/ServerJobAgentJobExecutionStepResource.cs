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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ServerJobAgentJobExecutionStep along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ServerJobAgentJobExecutionStepResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetServerJobAgentJobExecutionStepResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServerJobAgentJobExecutionResource" /> using the GetServerJobAgentJobExecutionStep method.
    /// </summary>
    public partial class ServerJobAgentJobExecutionStepResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServerJobAgentJobExecutionStepResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, string stepName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serverJobAgentJobExecutionStepJobStepExecutionsClientDiagnostics;
        private readonly JobStepExecutionsRestOperations _serverJobAgentJobExecutionStepJobStepExecutionsRestClient;
        private readonly JobExecutionData _data;

        /// <summary> Initializes a new instance of the <see cref="ServerJobAgentJobExecutionStepResource"/> class for mocking. </summary>
        protected ServerJobAgentJobExecutionStepResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServerJobAgentJobExecutionStepResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServerJobAgentJobExecutionStepResource(ArmClient client, JobExecutionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServerJobAgentJobExecutionStepResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServerJobAgentJobExecutionStepResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverJobAgentJobExecutionStepJobStepExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serverJobAgentJobExecutionStepJobStepExecutionsApiVersion);
            _serverJobAgentJobExecutionStepJobStepExecutionsRestClient = new JobStepExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverJobAgentJobExecutionStepJobStepExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/jobAgents/jobs/executions/steps";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual JobExecutionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ServerJobAgentJobExecutionStepTargetResources in the ServerJobAgentJobExecutionStep. </summary>
        /// <returns> An object representing collection of ServerJobAgentJobExecutionStepTargetResources and their operations over a ServerJobAgentJobExecutionStepTargetResource. </returns>
        public virtual ServerJobAgentJobExecutionStepTargetCollection GetServerJobAgentJobExecutionStepTargets()
        {
            return GetCachedClient(Client => new ServerJobAgentJobExecutionStepTargetCollection(Client, Id));
        }

        /// <summary>
        /// Gets a target execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}
        /// Operation Id: JobTargetExecutions_Get
        /// </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ServerJobAgentJobExecutionStepTargetResource>> GetServerJobAgentJobExecutionStepTargetAsync(Guid targetId, CancellationToken cancellationToken = default)
        {
            return await GetServerJobAgentJobExecutionStepTargets().GetAsync(targetId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a target execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}/targets/{targetId}
        /// Operation Id: JobTargetExecutions_Get
        /// </summary>
        /// <param name="targetId"> The target id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ServerJobAgentJobExecutionStepTargetResource> GetServerJobAgentJobExecutionStepTarget(Guid targetId, CancellationToken cancellationToken = default)
        {
            return GetServerJobAgentJobExecutionStepTargets().Get(targetId, cancellationToken);
        }

        /// <summary>
        /// Gets a step execution of a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}
        /// Operation Id: JobStepExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerJobAgentJobExecutionStepResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionStepJobStepExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepResource.Get");
            scope.Start();
            try
            {
                var response = await _serverJobAgentJobExecutionStepJobStepExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerJobAgentJobExecutionStepResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a step execution of a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/steps/{stepName}
        /// Operation Id: JobStepExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerJobAgentJobExecutionStepResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionStepJobStepExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepResource.Get");
            scope.Start();
            try
            {
                var response = _serverJobAgentJobExecutionStepJobStepExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Guid.Parse(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerJobAgentJobExecutionStepResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
