// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Migrate
{
    /// <summary>
    /// A class representing a collection of <see cref="VMwareCollectorResource" /> and their operations.
    /// Each <see cref="VMwareCollectorResource" /> in the collection will belong to the same instance of <see cref="ProjectResource" />.
    /// To get a <see cref="VMwareCollectorCollection" /> instance call the GetVMwareCollectors method from an instance of <see cref="ProjectResource" />.
    /// </summary>
    public partial class VMwareCollectorCollection : ArmCollection, IEnumerable<VMwareCollectorResource>, IAsyncEnumerable<VMwareCollectorResource>
    {
        private readonly ClientDiagnostics _vMwareCollectorClientDiagnostics;
        private readonly VMwareCollectorsRestOperations _vMwareCollectorRestClient;

        /// <summary> Initializes a new instance of the <see cref="VMwareCollectorCollection"/> class for mocking. </summary>
        protected VMwareCollectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VMwareCollectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VMwareCollectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vMwareCollectorClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Migrate", VMwareCollectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VMwareCollectorResource.ResourceType, out string vMwareCollectorApiVersion);
            _vMwareCollectorRestClient = new VMwareCollectorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vMwareCollectorApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ProjectResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ProjectResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update VMware collector
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors/{vmWareCollectorName}
        /// Operation Id: VMwareCollectors_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmWareCollectorName"> Unique name of a VMware collector within a project. </param>
        /// <param name="data"> New or Updated VMware collector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmWareCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmWareCollectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VMwareCollectorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vmWareCollectorName, VMwareCollectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmWareCollectorName, nameof(vmWareCollectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vMwareCollectorClientDiagnostics.CreateScope("VMwareCollectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vMwareCollectorRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MigrateArmOperation<VMwareCollectorResource>(Response.FromValue(new VMwareCollectorResource(Client, response), response.GetRawResponse()));
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
        /// Create or Update VMware collector
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors/{vmWareCollectorName}
        /// Operation Id: VMwareCollectors_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmWareCollectorName"> Unique name of a VMware collector within a project. </param>
        /// <param name="data"> New or Updated VMware collector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmWareCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmWareCollectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VMwareCollectorResource> CreateOrUpdate(WaitUntil waitUntil, string vmWareCollectorName, VMwareCollectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmWareCollectorName, nameof(vmWareCollectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vMwareCollectorClientDiagnostics.CreateScope("VMwareCollectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vMwareCollectorRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, data, cancellationToken);
                var operation = new MigrateArmOperation<VMwareCollectorResource>(Response.FromValue(new VMwareCollectorResource(Client, response), response.GetRawResponse()));
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
        /// Get a VMware collector.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors/{vmWareCollectorName}
        /// Operation Id: VMwareCollectors_Get
        /// </summary>
        /// <param name="vmWareCollectorName"> Unique name of a VMware collector within a project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmWareCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmWareCollectorName"/> is null. </exception>
        public virtual async Task<Response<VMwareCollectorResource>> GetAsync(string vmWareCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmWareCollectorName, nameof(vmWareCollectorName));

            using var scope = _vMwareCollectorClientDiagnostics.CreateScope("VMwareCollectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _vMwareCollectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareCollectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a VMware collector.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors/{vmWareCollectorName}
        /// Operation Id: VMwareCollectors_Get
        /// </summary>
        /// <param name="vmWareCollectorName"> Unique name of a VMware collector within a project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmWareCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmWareCollectorName"/> is null. </exception>
        public virtual Response<VMwareCollectorResource> Get(string vmWareCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmWareCollectorName, nameof(vmWareCollectorName));

            using var scope = _vMwareCollectorClientDiagnostics.CreateScope("VMwareCollectorCollection.Get");
            scope.Start();
            try
            {
                var response = _vMwareCollectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareCollectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of VMware collector.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors
        /// Operation Id: VMwareCollectors_ListByProject
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VMwareCollectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VMwareCollectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VMwareCollectorResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vMwareCollectorClientDiagnostics.CreateScope("VMwareCollectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vMwareCollectorRestClient.ListByProjectAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareCollectorResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get a list of VMware collector.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors
        /// Operation Id: VMwareCollectors_ListByProject
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VMwareCollectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VMwareCollectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VMwareCollectorResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vMwareCollectorClientDiagnostics.CreateScope("VMwareCollectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vMwareCollectorRestClient.ListByProject(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareCollectorResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors/{vmWareCollectorName}
        /// Operation Id: VMwareCollectors_Get
        /// </summary>
        /// <param name="vmWareCollectorName"> Unique name of a VMware collector within a project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmWareCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmWareCollectorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vmWareCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmWareCollectorName, nameof(vmWareCollectorName));

            using var scope = _vMwareCollectorClientDiagnostics.CreateScope("VMwareCollectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _vMwareCollectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors/{vmWareCollectorName}
        /// Operation Id: VMwareCollectors_Get
        /// </summary>
        /// <param name="vmWareCollectorName"> Unique name of a VMware collector within a project. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmWareCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmWareCollectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string vmWareCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmWareCollectorName, nameof(vmWareCollectorName));

            using var scope = _vMwareCollectorClientDiagnostics.CreateScope("VMwareCollectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _vMwareCollectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VMwareCollectorResource> IEnumerable<VMwareCollectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VMwareCollectorResource> IAsyncEnumerable<VMwareCollectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
