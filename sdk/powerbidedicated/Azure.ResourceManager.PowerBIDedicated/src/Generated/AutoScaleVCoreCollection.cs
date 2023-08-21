// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PowerBIDedicated
{
    /// <summary>
    /// A class representing a collection of <see cref="AutoScaleVCoreResource" /> and their operations.
    /// Each <see cref="AutoScaleVCoreResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="AutoScaleVCoreCollection" /> instance call the GetAutoScaleVCores method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class AutoScaleVCoreCollection : ArmCollection, IEnumerable<AutoScaleVCoreResource>, IAsyncEnumerable<AutoScaleVCoreResource>
    {
        private readonly ClientDiagnostics _autoScaleVCoreClientDiagnostics;
        private readonly AutoScaleVCoresRestOperations _autoScaleVCoreRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutoScaleVCoreCollection"/> class for mocking. </summary>
        protected AutoScaleVCoreCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutoScaleVCoreCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutoScaleVCoreCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _autoScaleVCoreClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PowerBIDedicated", AutoScaleVCoreResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutoScaleVCoreResource.ResourceType, out string autoScaleVCoreApiVersion);
            _autoScaleVCoreRestClient = new AutoScaleVCoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, autoScaleVCoreApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Provisions the specified auto scale v-core based on the configuration specified in the request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/autoScaleVCores/{vcoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoScaleVCores_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="data"> Contains the information used to provision the auto scale v-core. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcoreName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AutoScaleVCoreResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vcoreName, AutoScaleVCoreData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcoreName, nameof(vcoreName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _autoScaleVCoreClientDiagnostics.CreateScope("AutoScaleVCoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _autoScaleVCoreRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, vcoreName, data, cancellationToken).ConfigureAwait(false);
                var operation = new PowerBIDedicatedArmOperation<AutoScaleVCoreResource>(Response.FromValue(new AutoScaleVCoreResource(Client, response), response.GetRawResponse()));
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
        /// Provisions the specified auto scale v-core based on the configuration specified in the request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/autoScaleVCores/{vcoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoScaleVCores_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="data"> Contains the information used to provision the auto scale v-core. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcoreName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AutoScaleVCoreResource> CreateOrUpdate(WaitUntil waitUntil, string vcoreName, AutoScaleVCoreData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcoreName, nameof(vcoreName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _autoScaleVCoreClientDiagnostics.CreateScope("AutoScaleVCoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _autoScaleVCoreRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, vcoreName, data, cancellationToken);
                var operation = new PowerBIDedicatedArmOperation<AutoScaleVCoreResource>(Response.FromValue(new AutoScaleVCoreResource(Client, response), response.GetRawResponse()));
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
        /// Gets details about the specified auto scale v-core.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/autoScaleVCores/{vcoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoScaleVCores_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcoreName"/> is null. </exception>
        public virtual async Task<Response<AutoScaleVCoreResource>> GetAsync(string vcoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcoreName, nameof(vcoreName));

            using var scope = _autoScaleVCoreClientDiagnostics.CreateScope("AutoScaleVCoreCollection.Get");
            scope.Start();
            try
            {
                var response = await _autoScaleVCoreRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vcoreName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutoScaleVCoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details about the specified auto scale v-core.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/autoScaleVCores/{vcoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoScaleVCores_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcoreName"/> is null. </exception>
        public virtual Response<AutoScaleVCoreResource> Get(string vcoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcoreName, nameof(vcoreName));

            using var scope = _autoScaleVCoreClientDiagnostics.CreateScope("AutoScaleVCoreCollection.Get");
            scope.Start();
            try
            {
                var response = _autoScaleVCoreRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vcoreName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutoScaleVCoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the auto scale v-cores for the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/autoScaleVCores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoScaleVCores_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutoScaleVCoreResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutoScaleVCoreResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _autoScaleVCoreRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AutoScaleVCoreResource(Client, AutoScaleVCoreData.DeserializeAutoScaleVCoreData(e)), _autoScaleVCoreClientDiagnostics, Pipeline, "AutoScaleVCoreCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all the auto scale v-cores for the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/autoScaleVCores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoScaleVCores_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutoScaleVCoreResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutoScaleVCoreResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _autoScaleVCoreRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, null, e => new AutoScaleVCoreResource(Client, AutoScaleVCoreData.DeserializeAutoScaleVCoreData(e)), _autoScaleVCoreClientDiagnostics, Pipeline, "AutoScaleVCoreCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/autoScaleVCores/{vcoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoScaleVCores_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcoreName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vcoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcoreName, nameof(vcoreName));

            using var scope = _autoScaleVCoreClientDiagnostics.CreateScope("AutoScaleVCoreCollection.Exists");
            scope.Start();
            try
            {
                var response = await _autoScaleVCoreRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vcoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/autoScaleVCores/{vcoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoScaleVCores_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vcoreName"> The name of the auto scale v-core. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcoreName"/> is null. </exception>
        public virtual Response<bool> Exists(string vcoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcoreName, nameof(vcoreName));

            using var scope = _autoScaleVCoreClientDiagnostics.CreateScope("AutoScaleVCoreCollection.Exists");
            scope.Start();
            try
            {
                var response = _autoScaleVCoreRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vcoreName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutoScaleVCoreResource> IEnumerable<AutoScaleVCoreResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutoScaleVCoreResource> IAsyncEnumerable<AutoScaleVCoreResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
