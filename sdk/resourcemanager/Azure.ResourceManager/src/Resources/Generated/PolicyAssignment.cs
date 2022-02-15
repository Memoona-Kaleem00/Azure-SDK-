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
    /// <summary> A Class representing a PolicyAssignment along with the instance operations that can be performed on it. </summary>
    public partial class PolicyAssignment : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PolicyAssignment"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string policyAssignmentName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _policyAssignmentClientDiagnostics;
        private readonly PolicyAssignmentsRestOperations _policyAssignmentRestClient;
        private readonly PolicyAssignmentData _data;

        /// <summary> Initializes a new instance of the <see cref="PolicyAssignment"/> class for mocking. </summary>
        protected PolicyAssignment()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PolicyAssignment"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PolicyAssignment(ArmClient client, PolicyAssignmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyAssignment"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PolicyAssignment(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _policyAssignmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string policyAssignmentApiVersion);
            _policyAssignmentRestClient = new PolicyAssignmentsRestOperations(_policyAssignmentClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, policyAssignmentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policyAssignments";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicyAssignmentData Data
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
        /// This operation retrieves a single policy assignment, given its name and the scope it was created at.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}
        /// Operation Id: PolicyAssignments_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<PolicyAssignment>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _policyAssignmentClientDiagnostics.CreateScope("PolicyAssignment.Get");
            scope.Start();
            try
            {
                var response = await _policyAssignmentRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _policyAssignmentClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PolicyAssignment(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves a single policy assignment, given its name and the scope it was created at.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}
        /// Operation Id: PolicyAssignments_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyAssignment> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _policyAssignmentClientDiagnostics.CreateScope("PolicyAssignment.Get");
            scope.Start();
            try
            {
                var response = _policyAssignmentRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _policyAssignmentClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyAssignment(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation deletes a policy assignment, given its name and the scope it was created in. The scope of a policy assignment is the part of its ID preceding &apos;/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}&apos;.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}
        /// Operation Id: PolicyAssignments_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation<PolicyAssignment>> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _policyAssignmentClientDiagnostics.CreateScope("PolicyAssignment.Delete");
            scope.Start();
            try
            {
                var response = await _policyAssignmentRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<PolicyAssignment>(Response.FromValue(new PolicyAssignment(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
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
        /// This operation deletes a policy assignment, given its name and the scope it was created in. The scope of a policy assignment is the part of its ID preceding &apos;/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}&apos;.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}
        /// Operation Id: PolicyAssignments_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<PolicyAssignment> Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _policyAssignmentClientDiagnostics.CreateScope("PolicyAssignment.Delete");
            scope.Start();
            try
            {
                var response = _policyAssignmentRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new ResourcesArmOperation<PolicyAssignment>(Response.FromValue(new PolicyAssignment(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
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
