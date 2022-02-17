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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of HubIPConfiguration and their operations over its parent. </summary>
    public partial class HubIPConfigurationCollection : ArmCollection, IEnumerable<HubIPConfiguration>, IAsyncEnumerable<HubIPConfiguration>
    {
        private readonly ClientDiagnostics _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics;
        private readonly VirtualHubIpConfigurationRestOperations _hubIPConfigurationVirtualHubIpConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="HubIPConfigurationCollection"/> class for mocking. </summary>
        protected HubIPConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HubIPConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HubIPConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", HubIPConfiguration.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(HubIPConfiguration.ResourceType, out string hubIPConfigurationVirtualHubIpConfigurationApiVersion);
            _hubIPConfigurationVirtualHubIpConfigurationRestClient = new VirtualHubIpConfigurationRestOperations(_hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, hubIPConfigurationVirtualHubIpConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualHub.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualHub.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a VirtualHubIpConfiguration resource if it doesn&apos;t exist else updates the existing VirtualHubIpConfiguration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}
        /// Operation Id: VirtualHubIpConfiguration_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="parameters"> Hub Ip Configuration parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<HubIPConfiguration>> CreateOrUpdateAsync(bool waitForCompletion, string ipConfigName, HubIPConfigurationData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigName, nameof(ipConfigName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hubIPConfigurationVirtualHubIpConfigurationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<HubIPConfiguration>(new HubIPConfigurationOperationSource(Client), _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics, Pipeline, _hubIPConfigurationVirtualHubIpConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a VirtualHubIpConfiguration resource if it doesn&apos;t exist else updates the existing VirtualHubIpConfiguration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}
        /// Operation Id: VirtualHubIpConfiguration_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="parameters"> Hub Ip Configuration parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<HubIPConfiguration> CreateOrUpdate(bool waitForCompletion, string ipConfigName, HubIPConfigurationData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigName, nameof(ipConfigName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hubIPConfigurationVirtualHubIpConfigurationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<HubIPConfiguration>(new HubIPConfigurationOperationSource(Client), _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics, Pipeline, _hubIPConfigurationVirtualHubIpConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Retrieves the details of a Virtual Hub Ip configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}
        /// Operation Id: VirtualHubIpConfiguration_Get
        /// </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> is null. </exception>
        public async virtual Task<Response<HubIPConfiguration>> GetAsync(string ipConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigName, nameof(ipConfigName));

            using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _hubIPConfigurationVirtualHubIpConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new HubIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a Virtual Hub Ip configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}
        /// Operation Id: VirtualHubIpConfiguration_Get
        /// </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> is null. </exception>
        public virtual Response<HubIPConfiguration> Get(string ipConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigName, nameof(ipConfigName));

            using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _hubIPConfigurationVirtualHubIpConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, cancellationToken);
                if (response.Value == null)
                    throw _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HubIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of all VirtualHubIpConfigurations.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations
        /// Operation Id: VirtualHubIpConfiguration_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HubIPConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HubIPConfiguration> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HubIPConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hubIPConfigurationVirtualHubIpConfigurationRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HubIPConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HubIPConfiguration>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hubIPConfigurationVirtualHubIpConfigurationRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HubIPConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Retrieves the details of all VirtualHubIpConfigurations.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations
        /// Operation Id: VirtualHubIpConfiguration_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HubIPConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HubIPConfiguration> GetAll(CancellationToken cancellationToken = default)
        {
            Page<HubIPConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hubIPConfigurationVirtualHubIpConfigurationRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HubIPConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HubIPConfiguration> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hubIPConfigurationVirtualHubIpConfigurationRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HubIPConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}
        /// Operation Id: VirtualHubIpConfiguration_Get
        /// </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string ipConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigName, nameof(ipConfigName));

            using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(ipConfigName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}
        /// Operation Id: VirtualHubIpConfiguration_Get
        /// </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> is null. </exception>
        public virtual Response<bool> Exists(string ipConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigName, nameof(ipConfigName));

            using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(ipConfigName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}
        /// Operation Id: VirtualHubIpConfiguration_Get
        /// </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> is null. </exception>
        public async virtual Task<Response<HubIPConfiguration>> GetIfExistsAsync(string ipConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigName, nameof(ipConfigName));

            using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hubIPConfigurationVirtualHubIpConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<HubIPConfiguration>(null, response.GetRawResponse());
                return Response.FromValue(new HubIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}
        /// Operation Id: VirtualHubIpConfiguration_Get
        /// </summary>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigName"/> is null. </exception>
        public virtual Response<HubIPConfiguration> GetIfExists(string ipConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipConfigName, nameof(ipConfigName));

            using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hubIPConfigurationVirtualHubIpConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ipConfigName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<HubIPConfiguration>(null, response.GetRawResponse());
                return Response.FromValue(new HubIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HubIPConfiguration> IEnumerable<HubIPConfiguration>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HubIPConfiguration> IAsyncEnumerable<HubIPConfiguration>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
