// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A Class representing a ContainerAppJobExecution along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ContainerAppJobExecutionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetContainerAppJobExecutionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerAppJobResource"/> using the GetContainerAppJobExecution method.
    /// </summary>
    public partial class ContainerAppJobExecutionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ContainerAppJobExecutionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="jobName"> The jobName. </param>
        /// <param name="jobExecutionName"> The jobExecutionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string jobName, string jobExecutionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/executions/{jobExecutionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _containerAppJobExecutionClientDiagnostics;
        private readonly ContainerAppsAPIRestOperations _containerAppJobExecutionRestClient;
        private readonly ClientDiagnostics _jobsClientDiagnostics;
        private readonly JobsRestOperations _jobsRestClient;
        private readonly ContainerAppJobExecutionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.App/jobs/executions";

        /// <summary> Initializes a new instance of the <see cref="ContainerAppJobExecutionResource"/> class for mocking. </summary>
        protected ContainerAppJobExecutionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppJobExecutionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ContainerAppJobExecutionResource(ArmClient client, ContainerAppJobExecutionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppJobExecutionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContainerAppJobExecutionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppJobExecutionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string containerAppJobExecutionApiVersion);
            _containerAppJobExecutionRestClient = new ContainerAppsAPIRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppJobExecutionApiVersion);
            _jobsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _jobsRestClient = new JobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContainerAppJobExecutionData Data
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

        /// <summary>
        /// Get details of a single job execution
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/executions/{jobExecutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecution</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppJobExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContainerAppJobExecutionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppJobExecutionClientDiagnostics.CreateScope("ContainerAppJobExecutionResource.Get");
            scope.Start();
            try
            {
                var response = await _containerAppJobExecutionRestClient.JobExecutionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppJobExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get details of a single job execution
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/executions/{jobExecutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecution</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppJobExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContainerAppJobExecutionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppJobExecutionClientDiagnostics.CreateScope("ContainerAppJobExecutionResource.Get");
            scope.Start();
            try
            {
                var response = _containerAppJobExecutionRestClient.JobExecution(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppJobExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Terminates execution of a running container apps job
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/executions/{jobExecutionName}/stop</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_StopExecution</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> StopExecutionJobAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _jobsClientDiagnostics.CreateScope("ContainerAppJobExecutionResource.StopExecutionJob");
            scope.Start();
            try
            {
                var response = await _jobsRestClient.StopExecutionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation(_jobsClientDiagnostics, Pipeline, _jobsRestClient.CreateStopExecutionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Terminates execution of a running container apps job
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/executions/{jobExecutionName}/stop</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_StopExecution</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation StopExecutionJob(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _jobsClientDiagnostics.CreateScope("ContainerAppJobExecutionResource.StopExecutionJob");
            scope.Start();
            try
            {
                var response = _jobsRestClient.StopExecution(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppContainersArmOperation(_jobsClientDiagnostics, Pipeline, _jobsRestClient.CreateStopExecutionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
    }
}
