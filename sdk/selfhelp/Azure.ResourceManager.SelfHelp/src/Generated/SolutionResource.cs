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
using Azure.ResourceManager.SelfHelp.Models;

namespace Azure.ResourceManager.SelfHelp
{
    /// <summary>
    /// A Class representing a SolutionResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SolutionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSolutionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetSolutionResource method.
    /// </summary>
    public partial class SolutionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SolutionResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="solutionResourceName"> The solutionResourceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string solutionResourceName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Help/solutions/{solutionResourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _solutionResourceSolutionClientDiagnostics;
        private readonly SolutionRestOperations _solutionResourceSolutionRestClient;
        private readonly SolutionResourceData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Help/solutions";

        /// <summary> Initializes a new instance of the <see cref="SolutionResource"/> class for mocking. </summary>
        protected SolutionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SolutionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SolutionResource(ArmClient client, SolutionResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SolutionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SolutionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _solutionResourceSolutionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SelfHelp", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string solutionResourceSolutionApiVersion);
            _solutionResourceSolutionRestClient = new SolutionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, solutionResourceSolutionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SolutionResourceData Data
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
        /// Get the solution using the applicable solutionResourceName while creating the solution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/solutions/{solutionResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Solution_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SolutionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _solutionResourceSolutionClientDiagnostics.CreateScope("SolutionResource.Get");
            scope.Start();
            try
            {
                var response = await _solutionResourceSolutionRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SolutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the solution using the applicable solutionResourceName while creating the solution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/solutions/{solutionResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Solution_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SolutionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _solutionResourceSolutionClientDiagnostics.CreateScope("SolutionResource.Get");
            scope.Start();
            try
            {
                var response = _solutionResourceSolutionRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SolutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the requiredInputs or additional information needed to execute the solution
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/solutions/{solutionResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Solution_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The required request body for updating a solution resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<SolutionResource>> UpdateAsync(WaitUntil waitUntil, SolutionResourcePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _solutionResourceSolutionClientDiagnostics.CreateScope("SolutionResource.Update");
            scope.Start();
            try
            {
                var response = await _solutionResourceSolutionRestClient.UpdateAsync(Id.Parent, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new SelfHelpArmOperation<SolutionResource>(new SolutionResourceOperationSource(Client), _solutionResourceSolutionClientDiagnostics, Pipeline, _solutionResourceSolutionRestClient.CreateUpdateRequest(Id.Parent, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Update the requiredInputs or additional information needed to execute the solution
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Help/solutions/{solutionResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Solution_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The required request body for updating a solution resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<SolutionResource> Update(WaitUntil waitUntil, SolutionResourcePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _solutionResourceSolutionClientDiagnostics.CreateScope("SolutionResource.Update");
            scope.Start();
            try
            {
                var response = _solutionResourceSolutionRestClient.Update(Id.Parent, Id.Name, patch, cancellationToken);
                var operation = new SelfHelpArmOperation<SolutionResource>(new SolutionResourceOperationSource(Client), _solutionResourceSolutionClientDiagnostics, Pipeline, _solutionResourceSolutionRestClient.CreateUpdateRequest(Id.Parent, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
