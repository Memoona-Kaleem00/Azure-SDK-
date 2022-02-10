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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A Class representing a DiskRestorePoint along with the instance operations that can be performed on it. </summary>
    public partial class DiskRestorePoint : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DiskRestorePoint"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string restorePointCollectionName, string vmRestorePointName, string diskRestorePointName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{vmRestorePointName}/diskRestorePoints/{diskRestorePointName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _diskRestorePointClientDiagnostics;
        private readonly DiskRestorePointRestOperations _diskRestorePointRestClient;
        private readonly DiskRestorePointData _data;

        /// <summary> Initializes a new instance of the <see cref="DiskRestorePoint"/> class for mocking. </summary>
        protected DiskRestorePoint()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DiskRestorePoint"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DiskRestorePoint(ArmClient client, DiskRestorePointData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DiskRestorePoint"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DiskRestorePoint(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diskRestorePointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string diskRestorePointApiVersion);
            _diskRestorePointRestClient = new DiskRestorePointRestOperations(_diskRestorePointClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, diskRestorePointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/restorePointCollections/restorePoints/diskRestorePoints";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DiskRestorePointData Data
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

        /// <summary> Get disk restorePoint resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DiskRestorePoint>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePoint.Get");
            scope.Start();
            try
            {
                var response = await _diskRestorePointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _diskRestorePointClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DiskRestorePoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get disk restorePoint resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DiskRestorePoint> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePoint.Get");
            scope.Start();
            try
            {
                var response = _diskRestorePointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _diskRestorePointClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskRestorePoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Grants access to a diskRestorePoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="grantAccessData"> Access data object supplied in the body of the get disk access operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="grantAccessData"/> is null. </exception>
        public async virtual Task<ArmOperation<AccessUri>> GrantAccessAsync(bool waitForCompletion, GrantAccessData grantAccessData, CancellationToken cancellationToken = default)
        {
            if (grantAccessData == null)
            {
                throw new ArgumentNullException(nameof(grantAccessData));
            }

            using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePoint.GrantAccess");
            scope.Start();
            try
            {
                var response = await _diskRestorePointRestClient.GrantAccessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, grantAccessData, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<AccessUri>(new AccessUriOperationSource(), _diskRestorePointClientDiagnostics, Pipeline, _diskRestorePointRestClient.CreateGrantAccessRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, grantAccessData).Request, response, OperationFinalStateVia.Location);
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

        /// <summary> Grants access to a diskRestorePoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="grantAccessData"> Access data object supplied in the body of the get disk access operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="grantAccessData"/> is null. </exception>
        public virtual ArmOperation<AccessUri> GrantAccess(bool waitForCompletion, GrantAccessData grantAccessData, CancellationToken cancellationToken = default)
        {
            if (grantAccessData == null)
            {
                throw new ArgumentNullException(nameof(grantAccessData));
            }

            using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePoint.GrantAccess");
            scope.Start();
            try
            {
                var response = _diskRestorePointRestClient.GrantAccess(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, grantAccessData, cancellationToken);
                var operation = new ComputeArmOperation<AccessUri>(new AccessUriOperationSource(), _diskRestorePointClientDiagnostics, Pipeline, _diskRestorePointRestClient.CreateGrantAccessRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, grantAccessData).Request, response, OperationFinalStateVia.Location);
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

        /// <summary> Revokes access to a diskRestorePoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> RevokeAccessAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePoint.RevokeAccess");
            scope.Start();
            try
            {
                var response = await _diskRestorePointRestClient.RevokeAccessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation(_diskRestorePointClientDiagnostics, Pipeline, _diskRestorePointRestClient.CreateRevokeAccessRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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

        /// <summary> Revokes access to a diskRestorePoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation RevokeAccess(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _diskRestorePointClientDiagnostics.CreateScope("DiskRestorePoint.RevokeAccess");
            scope.Start();
            try
            {
                var response = _diskRestorePointRestClient.RevokeAccess(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ComputeArmOperation(_diskRestorePointClientDiagnostics, Pipeline, _diskRestorePointRestClient.CreateRevokeAccessRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
