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

namespace Azure.ResourceManager.PolicyInsights
{
    /// <summary>
    /// A Class representing a PolicyAttestation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="PolicyAttestationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetPolicyAttestationResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetPolicyAttestation method.
    /// </summary>
    public partial class PolicyAttestationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PolicyAttestationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceId, string attestationName)
        {
            var resourceId0 = $"{resourceId}/providers/Microsoft.PolicyInsights/attestations/{attestationName}";
            return new ResourceIdentifier(resourceId0);
        }

        private readonly ClientDiagnostics _policyAttestationAttestationsClientDiagnostics;
        private readonly AttestationsRestOperations _policyAttestationAttestationsRestClient;
        private readonly PolicyAttestationData _data;

        /// <summary> Initializes a new instance of the <see cref="PolicyAttestationResource"/> class for mocking. </summary>
        protected PolicyAttestationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PolicyAttestationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PolicyAttestationResource(ArmClient client, PolicyAttestationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyAttestationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PolicyAttestationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _policyAttestationAttestationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string policyAttestationAttestationsApiVersion);
            _policyAttestationAttestationsRestClient = new AttestationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, policyAttestationAttestationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.PolicyInsights/attestations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicyAttestationData Data
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
        /// Gets an existing attestation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/attestations/{attestationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Attestations_GetAtResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicyAttestationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationResource.Get");
            scope.Start();
            try
            {
                var response = await _policyAttestationAttestationsRestClient.GetAtResourceAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyAttestationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing attestation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/attestations/{attestationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Attestations_GetAtResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyAttestationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationResource.Get");
            scope.Start();
            try
            {
                var response = _policyAttestationAttestationsRestClient.GetAtResource(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyAttestationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing attestation at individual resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/attestations/{attestationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Attestations_DeleteAtResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationResource.Delete");
            scope.Start();
            try
            {
                var response = await _policyAttestationAttestationsRestClient.DeleteAtResourceAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new PolicyInsightsArmOperation(response);
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
        /// Deletes an existing attestation at individual resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/attestations/{attestationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Attestations_DeleteAtResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationResource.Delete");
            scope.Start();
            try
            {
                var response = _policyAttestationAttestationsRestClient.DeleteAtResource(Id.Parent, Id.Name, cancellationToken);
                var operation = new PolicyInsightsArmOperation(response);
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
        /// Creates or updates an attestation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/attestations/{attestationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Attestations_CreateOrUpdateAtResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The attestation parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PolicyAttestationResource>> UpdateAsync(WaitUntil waitUntil, PolicyAttestationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationResource.Update");
            scope.Start();
            try
            {
                var response = await _policyAttestationAttestationsRestClient.CreateOrUpdateAtResourceAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new PolicyInsightsArmOperation<PolicyAttestationResource>(new PolicyAttestationOperationSource(Client), _policyAttestationAttestationsClientDiagnostics, Pipeline, _policyAttestationAttestationsRestClient.CreateCreateOrUpdateAtResourceRequest(Id.Parent, Id.Name, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Creates or updates an attestation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/attestations/{attestationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Attestations_CreateOrUpdateAtResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The attestation parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PolicyAttestationResource> Update(WaitUntil waitUntil, PolicyAttestationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policyAttestationAttestationsClientDiagnostics.CreateScope("PolicyAttestationResource.Update");
            scope.Start();
            try
            {
                var response = _policyAttestationAttestationsRestClient.CreateOrUpdateAtResource(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new PolicyInsightsArmOperation<PolicyAttestationResource>(new PolicyAttestationOperationSource(Client), _policyAttestationAttestationsClientDiagnostics, Pipeline, _policyAttestationAttestationsRestClient.CreateCreateOrUpdateAtResourceRequest(Id.Parent, Id.Name, data).Request, response, Core.OperationFinalStateVia.Location);
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
