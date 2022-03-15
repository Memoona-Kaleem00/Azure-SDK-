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

namespace Azure.ResourceManager.Hci
{
    /// <summary> A class representing collection of ArcExtension and their operations over its parent. </summary>
    public partial class ArcExtensionCollection : ArmCollection, IEnumerable<ArcExtension>, IAsyncEnumerable<ArcExtension>
    {
        private readonly ClientDiagnostics _arcExtensionExtensionsClientDiagnostics;
        private readonly ExtensionsRestOperations _arcExtensionExtensionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ArcExtensionCollection"/> class for mocking. </summary>
        protected ArcExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ArcExtensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ArcExtensionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _arcExtensionExtensionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", ArcExtension.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ArcExtension.ResourceType, out string arcExtensionExtensionsApiVersion);
            _arcExtensionExtensionsRestClient = new ExtensionsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, arcExtensionExtensionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ArcSetting.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ArcSetting.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create Extension for HCI cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}
        /// Operation Id: Extensions_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="extension"> Details of the Machine Extension to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="extension"/> is null. </exception>
        public virtual async Task<ArmOperation<ArcExtension>> CreateOrUpdateAsync(WaitUntil waitUntil, string extensionName, ArcExtensionData extension, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));
            Argument.AssertNotNull(extension, nameof(extension));

            using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _arcExtensionExtensionsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, extension, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation<ArcExtension>(new ArcExtensionOperationSource(Client), _arcExtensionExtensionsClientDiagnostics, Pipeline, _arcExtensionExtensionsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, extension).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create Extension for HCI cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}
        /// Operation Id: Extensions_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="extension"> Details of the Machine Extension to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="extension"/> is null. </exception>
        public virtual ArmOperation<ArcExtension> CreateOrUpdate(WaitUntil waitUntil, string extensionName, ArcExtensionData extension, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));
            Argument.AssertNotNull(extension, nameof(extension));

            using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _arcExtensionExtensionsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, extension, cancellationToken);
                var operation = new HciArmOperation<ArcExtension>(new ArcExtensionOperationSource(Client), _arcExtensionExtensionsClientDiagnostics, Pipeline, _arcExtensionExtensionsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, extension).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get particular Arc Extension of HCI Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}
        /// Operation Id: Extensions_Get
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual async Task<Response<ArcExtension>> GetAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _arcExtensionExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArcExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get particular Arc Extension of HCI Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}
        /// Operation Id: Extensions_Get
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<ArcExtension> Get(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _arcExtensionExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArcExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all Extensions under ArcSetting resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions
        /// Operation Id: Extensions_ListByArcSetting
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ArcExtension" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ArcExtension> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ArcExtension>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _arcExtensionExtensionsRestClient.ListByArcSettingAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ArcExtension(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ArcExtension>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _arcExtensionExtensionsRestClient.ListByArcSettingNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ArcExtension(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List all Extensions under ArcSetting resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions
        /// Operation Id: Extensions_ListByArcSetting
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ArcExtension" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ArcExtension> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ArcExtension> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _arcExtensionExtensionsRestClient.ListByArcSetting(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ArcExtension(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ArcExtension> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _arcExtensionExtensionsRestClient.ListByArcSettingNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ArcExtension(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}
        /// Operation Id: Extensions_Get
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(extensionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}
        /// Operation Id: Extensions_Get
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<bool> Exists(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(extensionName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}
        /// Operation Id: Extensions_Get
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual async Task<Response<ArcExtension>> GetIfExistsAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _arcExtensionExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ArcExtension>(null, response.GetRawResponse());
                return Response.FromValue(new ArcExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}/extensions/{extensionName}
        /// Operation Id: Extensions_Get
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<ArcExtension> GetIfExists(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _arcExtensionExtensionsClientDiagnostics.CreateScope("ArcExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _arcExtensionExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, extensionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ArcExtension>(null, response.GetRawResponse());
                return Response.FromValue(new ArcExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ArcExtension> IEnumerable<ArcExtension>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ArcExtension> IAsyncEnumerable<ArcExtension>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
