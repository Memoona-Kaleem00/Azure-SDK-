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
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A Class representing a PostRulestackRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="PostRulestackRuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetPostRulestackRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="GlobalRulestackResource" /> using the GetPostRulestackRule method.
    /// </summary>
    public partial class PostRulestackRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PostRulestackRuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string globalRulestackName, string priority)
        {
            var resourceId = $"/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/postRules/{priority}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _postRulestackRulePostRulesClientDiagnostics;
        private readonly PostRulesRestOperations _postRulestackRulePostRulesRestClient;
        private readonly PostRulestackRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="PostRulestackRuleResource"/> class for mocking. </summary>
        protected PostRulestackRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PostRulestackRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PostRulestackRuleResource(ArmClient client, PostRulestackRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PostRulestackRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PostRulestackRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _postRulestackRulePostRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string postRulestackRulePostRulesApiVersion);
            _postRulestackRulePostRulesRestClient = new PostRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, postRulestackRulePostRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "PaloAltoNetworks.Cloudngfw/globalRulestacks/postRules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PostRulestackRuleData Data
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
        /// Get a PostRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/postRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PostRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PostRulestackRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _postRulestackRulePostRulesClientDiagnostics.CreateScope("PostRulestackRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _postRulestackRulePostRulesRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostRulestackRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a PostRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/postRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PostRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PostRulestackRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _postRulestackRulePostRulesClientDiagnostics.CreateScope("PostRulestackRuleResource.Get");
            scope.Start();
            try
            {
                var response = _postRulestackRulePostRulesRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostRulestackRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a PostRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/postRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PostRules_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _postRulestackRulePostRulesClientDiagnostics.CreateScope("PostRulestackRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _postRulestackRulePostRulesRestClient.DeleteAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation(_postRulestackRulePostRulesClientDiagnostics, Pipeline, _postRulestackRulePostRulesRestClient.CreateDeleteRequest(Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Delete a PostRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/postRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PostRules_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _postRulestackRulePostRulesClientDiagnostics.CreateScope("PostRulestackRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _postRulestackRulePostRulesRestClient.Delete(Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NgfwArmOperation(_postRulestackRulePostRulesClientDiagnostics, Pipeline, _postRulestackRulePostRulesRestClient.CreateDeleteRequest(Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a PostRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/postRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PostRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PostRulestackRuleResource>> UpdateAsync(WaitUntil waitUntil, PostRulestackRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postRulestackRulePostRulesClientDiagnostics.CreateScope("PostRulestackRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _postRulestackRulePostRulesRestClient.CreateOrUpdateAsync(Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<PostRulestackRuleResource>(new PostRulestackRuleOperationSource(Client), _postRulestackRulePostRulesClientDiagnostics, Pipeline, _postRulestackRulePostRulesRestClient.CreateCreateOrUpdateRequest(Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a PostRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/postRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PostRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PostRulestackRuleResource> Update(WaitUntil waitUntil, PostRulestackRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postRulestackRulePostRulesClientDiagnostics.CreateScope("PostRulestackRuleResource.Update");
            scope.Start();
            try
            {
                var response = _postRulestackRulePostRulesRestClient.CreateOrUpdate(Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new NgfwArmOperation<PostRulestackRuleResource>(new PostRulestackRuleOperationSource(Client), _postRulestackRulePostRulesClientDiagnostics, Pipeline, _postRulestackRulePostRulesRestClient.CreateCreateOrUpdateRequest(Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/postRules/{priority}/getCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PostRules_getCounters</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FirewallRuleCounter>> GetCountersAsync(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _postRulestackRulePostRulesClientDiagnostics.CreateScope("PostRulestackRuleResource.GetCounters");
            scope.Start();
            try
            {
                var response = await _postRulestackRulePostRulesRestClient.GetCountersAsync(Id.Parent.Name, Id.Name, firewallName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/postRules/{priority}/getCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PostRules_getCounters</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FirewallRuleCounter> GetCounters(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _postRulestackRulePostRulesClientDiagnostics.CreateScope("PostRulestackRuleResource.GetCounters");
            scope.Start();
            try
            {
                var response = _postRulestackRulePostRulesRestClient.GetCounters(Id.Parent.Name, Id.Name, firewallName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Refresh counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/postRules/{priority}/refreshCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PostRules_refreshCounters</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RefreshCountersAsync(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _postRulestackRulePostRulesClientDiagnostics.CreateScope("PostRulestackRuleResource.RefreshCounters");
            scope.Start();
            try
            {
                var response = await _postRulestackRulePostRulesRestClient.RefreshCountersAsync(Id.Parent.Name, Id.Name, firewallName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Refresh counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/postRules/{priority}/refreshCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PostRules_refreshCounters</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RefreshCounters(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _postRulestackRulePostRulesClientDiagnostics.CreateScope("PostRulestackRuleResource.RefreshCounters");
            scope.Start();
            try
            {
                var response = _postRulestackRulePostRulesRestClient.RefreshCounters(Id.Parent.Name, Id.Name, firewallName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Reset counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/postRules/{priority}/resetCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PostRules_resetCounters</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FirewallRuleResetConter>> ResetCountersAsync(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _postRulestackRulePostRulesClientDiagnostics.CreateScope("PostRulestackRuleResource.ResetCounters");
            scope.Start();
            try
            {
                var response = await _postRulestackRulePostRulesRestClient.ResetCountersAsync(Id.Parent.Name, Id.Name, firewallName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Reset counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/postRules/{priority}/resetCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PostRules_resetCounters</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FirewallRuleResetConter> ResetCounters(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _postRulestackRulePostRulesClientDiagnostics.CreateScope("PostRulestackRuleResource.ResetCounters");
            scope.Start();
            try
            {
                var response = _postRulestackRulePostRulesRestClient.ResetCounters(Id.Parent.Name, Id.Name, firewallName, cancellationToken);
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
