// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A Class representing a PolicyExemption along with the instance operations that can be performed on it. </summary>
    public partial class PolicyExemption : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PolicyExemption"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string policyExemptionName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _policyExemptionClientDiagnostics;
        private readonly PolicyExemptionsRestOperations _policyExemptionRestClient;
        private readonly PolicyExemptionData _data;

        /// <summary> Initializes a new instance of the <see cref="PolicyExemption"/> class for mocking. </summary>
        protected PolicyExemption()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PolicyExemption"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PolicyExemption(ArmClient client, PolicyExemptionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyExemption"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PolicyExemption(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _policyExemptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string policyExemptionApiVersion);
            _policyExemptionRestClient = new PolicyExemptionsRestOperations(_policyExemptionClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, policyExemptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policyExemptions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicyExemptionData Data
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

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// ContextualPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// OperationId: PolicyExemptions_Get
        /// <summary> This operation retrieves a single policy exemption, given its name and the scope it was created at. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<PolicyExemption>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemption.Get");
            scope.Start();
            try
            {
                var response = await _policyExemptionRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _policyExemptionClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PolicyExemption(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// ContextualPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// OperationId: PolicyExemptions_Get
        /// <summary> This operation retrieves a single policy exemption, given its name and the scope it was created at. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyExemption> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemption.Get");
            scope.Start();
            try
            {
                var response = _policyExemptionRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _policyExemptionClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyExemption(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// ContextualPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// OperationId: PolicyExemptions_Delete
        /// <summary> This operation deletes a policy exemption, given its name and the scope it was created in. The scope of a policy exemption is the part of its ID preceding &apos;/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}&apos;. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemption.Delete");
            scope.Start();
            try
            {
                var response = await _policyExemptionRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// ContextualPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// OperationId: PolicyExemptions_Delete
        /// <summary> This operation deletes a policy exemption, given its name and the scope it was created in. The scope of a policy exemption is the part of its ID preceding &apos;/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}&apos;. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemption.Delete");
            scope.Start();
            try
            {
                var response = _policyExemptionRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new ResourcesArmOperation(response);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemption.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemption.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
