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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A Class representing a ManagementGroupPolicyDefinition along with the instance operations that can be performed on it. </summary>
    public partial class ManagementGroupPolicyDefinition : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagementGroupPolicyDefinition"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string managementGroupId, string policyDefinitionName)
        {
            var resourceId = $"/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics;
        private readonly PolicyDefinitionsRestOperations _managementGroupPolicyDefinitionPolicyDefinitionsRestClient;
        private readonly PolicyDefinitionData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupPolicyDefinition"/> class for mocking. </summary>
        protected ManagementGroupPolicyDefinition()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagementGroupPolicyDefinition"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagementGroupPolicyDefinition(ArmClient client, PolicyDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupPolicyDefinition"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagementGroupPolicyDefinition(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string managementGroupPolicyDefinitionPolicyDefinitionsApiVersion);
            _managementGroupPolicyDefinitionPolicyDefinitionsRestClient = new PolicyDefinitionsRestOperations(_managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managementGroupPolicyDefinitionPolicyDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policyDefinitions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicyDefinitionData Data
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
        /// This operation retrieves the policy definition in the given management group with the given name.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_GetAtManagementGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagementGroupPolicyDefinition>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinition.Get");
            scope.Start();
            try
            {
                var response = await _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.GetAtManagementGroupAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagementGroupPolicyDefinition(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the policy definition in the given management group with the given name.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_GetAtManagementGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagementGroupPolicyDefinition> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinition.Get");
            scope.Start();
            try
            {
                var response = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.GetAtManagementGroup(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementGroupPolicyDefinition(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation deletes the policy definition in the given management group with the given name.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_DeleteAtManagementGroup
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinition.Delete");
            scope.Start();
            try
            {
                var response = await _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.DeleteAtManagementGroupAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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

        /// <summary>
        /// This operation deletes the policy definition in the given management group with the given name.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_DeleteAtManagementGroup
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupPolicyDefinitionPolicyDefinitionsClientDiagnostics.CreateScope("ManagementGroupPolicyDefinition.Delete");
            scope.Start();
            try
            {
                var response = _managementGroupPolicyDefinitionPolicyDefinitionsRestClient.DeleteAtManagementGroup(Id.Parent.Name, Id.Name, cancellationToken);
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
    }
}
