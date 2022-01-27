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
using Azure.ResourceManager.KeyVault.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A Class representing a ManagedHsm along with the instance operations that can be performed on it. </summary>
    public partial class ManagedHsm : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedHsm"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedHsmClientDiagnostics;
        private readonly ManagedHsmsRestOperations _managedHsmRestClient;
        private readonly ClientDiagnostics _mHSMPrivateLinkResourcesClientDiagnostics;
        private readonly MhsmPrivateLinkResourcesRestOperations _mHSMPrivateLinkResourcesRestClient;
        private readonly ManagedHsmData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedHsm"/> class for mocking. </summary>
        protected ManagedHsm()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedHsm"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedHsm(ArmClient armClient, ManagedHsmData data) : this(armClient, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedHsm"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedHsm(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
            _managedHsmClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.KeyVault", ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(ResourceType, out string managedHsmApiVersion);
            _managedHsmRestClient = new ManagedHsmsRestOperations(_managedHsmClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managedHsmApiVersion);
            _mHSMPrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.KeyVault", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
            _mHSMPrivateLinkResourcesRestClient = new MhsmPrivateLinkResourcesRestOperations(_mHSMPrivateLinkResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.KeyVault/managedHSMs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedHsmData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// OperationId: ManagedHsms_Get
        /// <summary> Gets the specified managed HSM Pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedHsm>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedHsmClientDiagnostics.CreateScope("ManagedHsm.Get");
            scope.Start();
            try
            {
                var response = await _managedHsmRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _managedHsmClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedHsm(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// OperationId: ManagedHsms_Get
        /// <summary> Gets the specified managed HSM Pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedHsm> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedHsmClientDiagnostics.CreateScope("ManagedHsm.Get");
            scope.Start();
            try
            {
                var response = _managedHsmRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _managedHsmClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedHsm(ArmClient, response.Value), response.GetRawResponse());
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
            using var scope = _managedHsmClientDiagnostics.CreateScope("ManagedHsm.GetAvailableLocations");
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
            using var scope = _managedHsmClientDiagnostics.CreateScope("ManagedHsm.GetAvailableLocations");
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// OperationId: ManagedHsms_Delete
        /// <summary> Deletes the specified managed HSM Pool. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ManagedHsmDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _managedHsmClientDiagnostics.CreateScope("ManagedHsm.Delete");
            scope.Start();
            try
            {
                var response = await _managedHsmRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedHsmDeleteOperation(_managedHsmClientDiagnostics, Pipeline, _managedHsmRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// OperationId: ManagedHsms_Delete
        /// <summary> Deletes the specified managed HSM Pool. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ManagedHsmDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _managedHsmClientDiagnostics.CreateScope("ManagedHsm.Delete");
            scope.Start();
            try
            {
                var response = _managedHsmRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new ManagedHsmDeleteOperation(_managedHsmClientDiagnostics, Pipeline, _managedHsmRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// OperationId: ManagedHsms_Update
        /// <summary> Update a managed HSM Pool in the specified subscription. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> Parameters to patch the managed HSM Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ManagedHsmUpdateOperation> UpdateAsync(bool waitForCompletion, ManagedHsmData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _managedHsmClientDiagnostics.CreateScope("ManagedHsm.Update");
            scope.Start();
            try
            {
                var response = await _managedHsmRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedHsmUpdateOperation(ArmClient, _managedHsmClientDiagnostics, Pipeline, _managedHsmRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// OperationId: ManagedHsms_Update
        /// <summary> Update a managed HSM Pool in the specified subscription. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> Parameters to patch the managed HSM Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ManagedHsmUpdateOperation Update(bool waitForCompletion, ManagedHsmData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _managedHsmClientDiagnostics.CreateScope("ManagedHsm.Update");
            scope.Start();
            try
            {
                var response = _managedHsmRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                var operation = new ManagedHsmUpdateOperation(ArmClient, _managedHsmClientDiagnostics, Pipeline, _managedHsmRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}/privateLinkResources
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// OperationId: MHSMPrivateLinkResources_ListByMhsmResource
        /// <summary> Gets the private link resources supported for the managed hsm pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MhsmPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MhsmPrivateLinkResource> GetMhsmPrivateLinkResourcesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MhsmPrivateLinkResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mHSMPrivateLinkResourcesClientDiagnostics.CreateScope("ManagedHsm.GetMhsmPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = await _mHSMPrivateLinkResourcesRestClient.ListByMhsmResourceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}/privateLinkResources
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/managedHSMs/{name}
        /// OperationId: MHSMPrivateLinkResources_ListByMhsmResource
        /// <summary> Gets the private link resources supported for the managed hsm pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MhsmPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MhsmPrivateLinkResource> GetMhsmPrivateLinkResources(CancellationToken cancellationToken = default)
        {
            Page<MhsmPrivateLinkResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mHSMPrivateLinkResourcesClientDiagnostics.CreateScope("ManagedHsm.GetMhsmPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = _mHSMPrivateLinkResourcesRestClient.ListByMhsmResource(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        #region MhsmPrivateEndpointConnection

        /// <summary> Gets a collection of MhsmPrivateEndpointConnections in the ManagedHsm. </summary>
        /// <returns> An object representing collection of MhsmPrivateEndpointConnections and their operations over a ManagedHsm. </returns>
        public virtual MhsmPrivateEndpointConnectionCollection GetMhsmPrivateEndpointConnections()
        {
            return new MhsmPrivateEndpointConnectionCollection(this);
        }
        #endregion
    }
}
