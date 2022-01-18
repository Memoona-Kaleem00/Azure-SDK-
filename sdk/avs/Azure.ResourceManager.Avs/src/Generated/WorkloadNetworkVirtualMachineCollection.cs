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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Avs
{
    /// <summary> A class representing collection of WorkloadNetworkVirtualMachine and their operations over its parent. </summary>
    public partial class WorkloadNetworkVirtualMachineCollection : ArmCollection, IEnumerable<WorkloadNetworkVirtualMachine>, IAsyncEnumerable<WorkloadNetworkVirtualMachine>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WorkloadNetworksRestOperations _workloadNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkVirtualMachineCollection"/> class for mocking. </summary>
        protected WorkloadNetworkVirtualMachineCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkVirtualMachineCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal WorkloadNetworkVirtualMachineCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _workloadNetworksRestClient = new WorkloadNetworksRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PrivateCloud.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PrivateCloud.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Get a virtual machine by id in a private cloud workload network. </summary>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineId"/> is null. </exception>
        public virtual Response<WorkloadNetworkVirtualMachine> Get(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            if (virtualMachineId == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineId));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.Get");
            scope.Start();
            try
            {
                var response = _workloadNetworksRestClient.GetVirtualMachine(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualMachineId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkVirtualMachine(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a virtual machine by id in a private cloud workload network. </summary>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineId"/> is null. </exception>
        public async virtual Task<Response<WorkloadNetworkVirtualMachine>> GetAsync(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            if (virtualMachineId == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineId));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.Get");
            scope.Start();
            try
            {
                var response = await _workloadNetworksRestClient.GetVirtualMachineAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualMachineId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new WorkloadNetworkVirtualMachine(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineId"/> is null. </exception>
        public virtual Response<WorkloadNetworkVirtualMachine> GetIfExists(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            if (virtualMachineId == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineId));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _workloadNetworksRestClient.GetVirtualMachine(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualMachineId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<WorkloadNetworkVirtualMachine>(null, response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkVirtualMachine(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineId"/> is null. </exception>
        public async virtual Task<Response<WorkloadNetworkVirtualMachine>> GetIfExistsAsync(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            if (virtualMachineId == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineId));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _workloadNetworksRestClient.GetVirtualMachineAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualMachineId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<WorkloadNetworkVirtualMachine>(null, response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkVirtualMachine(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineId"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            if (virtualMachineId == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineId));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualMachineId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualMachineId"> Virtual Machine identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string virtualMachineId, CancellationToken cancellationToken = default)
        {
            if (virtualMachineId == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineId));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualMachineId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List of virtual machines in a private cloud workload network. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkloadNetworkVirtualMachine" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkloadNetworkVirtualMachine> GetAll(CancellationToken cancellationToken = default)
        {
            Page<WorkloadNetworkVirtualMachine> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _workloadNetworksRestClient.ListVirtualMachines(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadNetworkVirtualMachine(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<WorkloadNetworkVirtualMachine> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _workloadNetworksRestClient.ListVirtualMachinesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadNetworkVirtualMachine(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List of virtual machines in a private cloud workload network. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkloadNetworkVirtualMachine" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkloadNetworkVirtualMachine> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<WorkloadNetworkVirtualMachine>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _workloadNetworksRestClient.ListVirtualMachinesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadNetworkVirtualMachine(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<WorkloadNetworkVirtualMachine>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WorkloadNetworkVirtualMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _workloadNetworksRestClient.ListVirtualMachinesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadNetworkVirtualMachine(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<WorkloadNetworkVirtualMachine> IEnumerable<WorkloadNetworkVirtualMachine>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkloadNetworkVirtualMachine> IAsyncEnumerable<WorkloadNetworkVirtualMachine>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, WorkloadNetworkVirtualMachine, WorkloadNetworkVirtualMachineData> Construct() { }
    }
}
