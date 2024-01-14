// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A Class representing an AutomationJob along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AutomationJobResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAutomationJobResource method.
    /// Otherwise you can get one from its parent resource <see cref="AutomationAccountResource"/> using the GetAutomationJob method.
    /// </summary>
    public partial class AutomationJobResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AutomationJobResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="automationAccountName"> The automationAccountName. </param>
        /// <param name="jobName"> The jobName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string automationAccountName, string jobName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _automationJobJobClientDiagnostics;
        private readonly JobRestOperations _automationJobJobRestClient;
        private readonly ClientDiagnostics _jobStreamClientDiagnostics;
        private readonly JobStreamRestOperations _jobStreamRestClient;
        private readonly AutomationJobData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Automation/automationAccounts/jobs";

        /// <summary> Initializes a new instance of the <see cref="AutomationJobResource"/> class for mocking. </summary>
        protected AutomationJobResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AutomationJobResource(ArmClient client, AutomationJobData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AutomationJobResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationJobJobClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string automationJobJobApiVersion);
            _automationJobJobRestClient = new JobRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationJobJobApiVersion);
            _jobStreamClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _jobStreamRestClient = new JobStreamRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AutomationJobData Data
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
        /// Retrieve the job identified by job name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutomationJobResource>> GetAsync(string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobResource.Get");
            scope.Start();
            try
            {
                var response = await _automationJobJobRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientRequestId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the job identified by job name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutomationJobResource> Get(string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobResource.Get");
            scope.Start();
            try
            {
                var response = _automationJobJobRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientRequestId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a job of the runbook.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The parameters supplied to the create job operation. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationJobResource>> UpdateAsync(WaitUntil waitUntil, AutomationJobCreateOrUpdateContent content, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobResource.Update");
            scope.Start();
            try
            {
                var response = await _automationJobJobRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, clientRequestId, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<AutomationJobResource>(Response.FromValue(new AutomationJobResource(Client, response), response.GetRawResponse()));
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
        /// Create a job of the runbook.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The parameters supplied to the create job operation. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AutomationJobResource> Update(WaitUntil waitUntil, AutomationJobCreateOrUpdateContent content, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobResource.Update");
            scope.Start();
            try
            {
                var response = _automationJobJobRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, clientRequestId, cancellationToken);
                var operation = new AutomationArmOperation<AutomationJobResource>(Response.FromValue(new AutomationJobResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve the job output identified by job name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}/output</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_GetOutput</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> GetOutputAsync(string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobResource.GetOutput");
            scope.Start();
            try
            {
                var response = await _automationJobJobRestClient.GetOutputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientRequestId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the job output identified by job name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}/output</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_GetOutput</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> GetOutput(string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobResource.GetOutput");
            scope.Start();
            try
            {
                var response = _automationJobJobRestClient.GetOutput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientRequestId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the runbook content of the job identified by job name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}/runbookContent</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_GetRunbookContent</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> GetRunbookContentAsync(string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobResource.GetRunbookContent");
            scope.Start();
            try
            {
                var response = await _automationJobJobRestClient.GetRunbookContentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientRequestId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the runbook content of the job identified by job name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}/runbookContent</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_GetRunbookContent</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> GetRunbookContent(string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobResource.GetRunbookContent");
            scope.Start();
            try
            {
                var response = _automationJobJobRestClient.GetRunbookContent(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientRequestId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Suspend the job identified by job name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}/suspend</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Suspend</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> SuspendAsync(string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobResource.Suspend");
            scope.Start();
            try
            {
                var response = await _automationJobJobRestClient.SuspendAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientRequestId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Suspend the job identified by job name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}/suspend</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Suspend</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Suspend(string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobResource.Suspend");
            scope.Start();
            try
            {
                var response = _automationJobJobRestClient.Suspend(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientRequestId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Stop the job identified by jobName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}/stop</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Stop</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StopAsync(string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobResource.Stop");
            scope.Start();
            try
            {
                var response = await _automationJobJobRestClient.StopAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientRequestId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Stop the job identified by jobName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}/stop</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Stop</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Stop(string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobResource.Stop");
            scope.Start();
            try
            {
                var response = _automationJobJobRestClient.Stop(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientRequestId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Resume the job identified by jobName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}/resume</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Resume</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ResumeAsync(string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobResource.Resume");
            scope.Start();
            try
            {
                var response = await _automationJobJobRestClient.ResumeAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientRequestId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Resume the job identified by jobName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}/resume</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Job_Resume</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Resume(string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobJobClientDiagnostics.CreateScope("AutomationJobResource.Resume");
            scope.Start();
            try
            {
                var response = _automationJobJobRestClient.Resume(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, clientRequestId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the job stream identified by job stream id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}/streams/{jobStreamId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobStream_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobStreamId"> The job stream id. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobStreamId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobStreamId"/> is null. </exception>
        public virtual async Task<Response<AutomationJobStream>> GetJobStreamAsync(string jobStreamId, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobStreamId, nameof(jobStreamId));

            using var scope = _jobStreamClientDiagnostics.CreateScope("AutomationJobResource.GetJobStream");
            scope.Start();
            try
            {
                var response = await _jobStreamRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, jobStreamId, clientRequestId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the job stream identified by job stream id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}/streams/{jobStreamId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobStream_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobStreamId"> The job stream id. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobStreamId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobStreamId"/> is null. </exception>
        public virtual Response<AutomationJobStream> GetJobStream(string jobStreamId, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobStreamId, nameof(jobStreamId));

            using var scope = _jobStreamClientDiagnostics.CreateScope("AutomationJobResource.GetJobStream");
            scope.Start();
            try
            {
                var response = _jobStreamRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, jobStreamId, clientRequestId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of jobs streams identified by job name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}/streams</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobStream_ListByJob</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationJobStream"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationJobStream> GetJobStreamsAsync(string filter = null, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _jobStreamRestClient.CreateListByJobRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, clientRequestId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _jobStreamRestClient.CreateListByJobNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, clientRequestId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, AutomationJobStream.DeserializeAutomationJobStream, _jobStreamClientDiagnostics, Pipeline, "AutomationJobResource.GetJobStreams", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of jobs streams identified by job name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobs/{jobName}/streams</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobStream_ListByJob</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationJobStream"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationJobStream> GetJobStreams(string filter = null, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _jobStreamRestClient.CreateListByJobRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, clientRequestId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _jobStreamRestClient.CreateListByJobNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, clientRequestId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, AutomationJobStream.DeserializeAutomationJobStream, _jobStreamClientDiagnostics, Pipeline, "AutomationJobResource.GetJobStreams", "value", "nextLink", cancellationToken);
        }
    }
}
