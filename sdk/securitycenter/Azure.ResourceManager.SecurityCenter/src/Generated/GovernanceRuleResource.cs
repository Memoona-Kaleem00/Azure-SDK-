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
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a GovernanceRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="GovernanceRuleResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetGovernanceRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetGovernanceRule method.
    /// </summary>
    public partial class GovernanceRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GovernanceRuleResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="ruleId"> The ruleId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string ruleId)
        {
            var resourceId = $"{scope}/providers/Microsoft.Security/governanceRules/{ruleId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _governanceRuleClientDiagnostics;
        private readonly GovernanceRulesRestOperations _governanceRuleRestClient;
        private readonly GovernanceRuleData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/governanceRules";

        /// <summary> Initializes a new instance of the <see cref="GovernanceRuleResource"/> class for mocking. </summary>
        protected GovernanceRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GovernanceRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GovernanceRuleResource(ArmClient client, GovernanceRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GovernanceRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GovernanceRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _governanceRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string governanceRuleApiVersion);
            _governanceRuleRestClient = new GovernanceRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, governanceRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GovernanceRuleData Data
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
        /// Get a specific governance rule for the requested scope by ruleId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GovernanceRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _governanceRuleRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GovernanceRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a specific governance rule for the requested scope by ruleId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GovernanceRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleResource.Get");
            scope.Start();
            try
            {
                var response = _governanceRuleRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GovernanceRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a Governance rule over a given scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _governanceRuleRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation(_governanceRuleClientDiagnostics, Pipeline, _governanceRuleRestClient.CreateDeleteRequest(Id.Parent, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete a Governance rule over a given scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _governanceRuleRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new SecurityCenterArmOperation(_governanceRuleClientDiagnostics, Pipeline, _governanceRuleRestClient.CreateDeleteRequest(Id.Parent, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a governance rule over a given scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Governance rule over a given scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GovernanceRuleResource>> UpdateAsync(WaitUntil waitUntil, GovernanceRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _governanceRuleRestClient.CreateOrUpdateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<GovernanceRuleResource>(Response.FromValue(new GovernanceRuleResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a governance rule over a given scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Governance rule over a given scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GovernanceRuleResource> Update(WaitUntil waitUntil, GovernanceRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleResource.Update");
            scope.Start();
            try
            {
                var response = _governanceRuleRestClient.CreateOrUpdate(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<GovernanceRuleResource>(Response.FromValue(new GovernanceRuleResource(Client, response), response.GetRawResponse()));
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
        /// Execute a governance rule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}/execute</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="executeGovernanceRuleParams"> Execute governance rule over a given scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> ExecuteAsync(WaitUntil waitUntil, ExecuteGovernanceRuleParams executeGovernanceRuleParams = null, CancellationToken cancellationToken = default)
        {
            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleResource.Execute");
            scope.Start();
            try
            {
                var response = await _governanceRuleRestClient.ExecuteAsync(Id.Parent, Id.Name, executeGovernanceRuleParams, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation(_governanceRuleClientDiagnostics, Pipeline, _governanceRuleRestClient.CreateExecuteRequest(Id.Parent, Id.Name, executeGovernanceRuleParams).Request, response, OperationFinalStateVia.Location);
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
        /// Execute a governance rule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/governanceRules/{ruleId}/execute</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceRules_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="executeGovernanceRuleParams"> Execute governance rule over a given scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Execute(WaitUntil waitUntil, ExecuteGovernanceRuleParams executeGovernanceRuleParams = null, CancellationToken cancellationToken = default)
        {
            using var scope = _governanceRuleClientDiagnostics.CreateScope("GovernanceRuleResource.Execute");
            scope.Start();
            try
            {
                var response = _governanceRuleRestClient.Execute(Id.Parent, Id.Name, executeGovernanceRuleParams, cancellationToken);
                var operation = new SecurityCenterArmOperation(_governanceRuleClientDiagnostics, Pipeline, _governanceRuleRestClient.CreateExecuteRequest(Id.Parent, Id.Name, executeGovernanceRuleParams).Request, response, OperationFinalStateVia.Location);
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
