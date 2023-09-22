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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ArcScVmm
{
    /// <summary>
    /// A class representing a collection of <see cref="ScVmmVirtualMachineTemplateResource" /> and their operations.
    /// Each <see cref="ScVmmVirtualMachineTemplateResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ScVmmVirtualMachineTemplateCollection" /> instance call the GetScVmmVirtualMachineTemplates method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ScVmmVirtualMachineTemplateCollection : ArmCollection, IEnumerable<ScVmmVirtualMachineTemplateResource>, IAsyncEnumerable<ScVmmVirtualMachineTemplateResource>
    {
        private readonly ClientDiagnostics _scVmmVirtualMachineTemplateVirtualMachineTemplatesClientDiagnostics;
        private readonly VirtualMachineTemplatesRestOperations _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScVmmVirtualMachineTemplateCollection"/> class for mocking. </summary>
        protected ScVmmVirtualMachineTemplateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScVmmVirtualMachineTemplateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScVmmVirtualMachineTemplateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scVmmVirtualMachineTemplateVirtualMachineTemplatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ArcScVmm", ScVmmVirtualMachineTemplateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScVmmVirtualMachineTemplateResource.ResourceType, out string scVmmVirtualMachineTemplateVirtualMachineTemplatesApiVersion);
            _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient = new VirtualMachineTemplatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scVmmVirtualMachineTemplateVirtualMachineTemplatesApiVersion);
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
        /// Onboards the ScVmm VM Template as an Azure VM Template resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualMachineTemplateName"> Name of the VirtualMachineTemplate. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScVmmVirtualMachineTemplateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualMachineTemplateName, ScVmmVirtualMachineTemplateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scVmmVirtualMachineTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("ScVmmVirtualMachineTemplateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ArcScVmmArmOperation<ScVmmVirtualMachineTemplateResource>(new ScVmmVirtualMachineTemplateOperationSource(Client), _scVmmVirtualMachineTemplateVirtualMachineTemplatesClientDiagnostics, Pipeline, _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Onboards the ScVmm VM Template as an Azure VM Template resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualMachineTemplateName"> Name of the VirtualMachineTemplate. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScVmmVirtualMachineTemplateResource> CreateOrUpdate(WaitUntil waitUntil, string virtualMachineTemplateName, ScVmmVirtualMachineTemplateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scVmmVirtualMachineTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("ScVmmVirtualMachineTemplateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, data, cancellationToken);
                var operation = new ArcScVmmArmOperation<ScVmmVirtualMachineTemplateResource>(new ScVmmVirtualMachineTemplateOperationSource(Client), _scVmmVirtualMachineTemplateVirtualMachineTemplatesClientDiagnostics, Pipeline, _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements VirtualMachineTemplate GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the VirtualMachineTemplate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual async Task<Response<ScVmmVirtualMachineTemplateResource>> GetAsync(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _scVmmVirtualMachineTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("ScVmmVirtualMachineTemplateCollection.Get");
            scope.Start();
            try
            {
                var response = await _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScVmmVirtualMachineTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements VirtualMachineTemplate GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the VirtualMachineTemplate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual Response<ScVmmVirtualMachineTemplateResource> Get(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _scVmmVirtualMachineTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("ScVmmVirtualMachineTemplateCollection.Get");
            scope.Start();
            try
            {
                var response = _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScVmmVirtualMachineTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of VirtualMachineTemplates in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachineTemplates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScVmmVirtualMachineTemplateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScVmmVirtualMachineTemplateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ScVmmVirtualMachineTemplateResource(Client, ScVmmVirtualMachineTemplateData.DeserializeScVmmVirtualMachineTemplateData(e)), _scVmmVirtualMachineTemplateVirtualMachineTemplatesClientDiagnostics, Pipeline, "ScVmmVirtualMachineTemplateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of VirtualMachineTemplates in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachineTemplates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScVmmVirtualMachineTemplateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScVmmVirtualMachineTemplateResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ScVmmVirtualMachineTemplateResource(Client, ScVmmVirtualMachineTemplateData.DeserializeScVmmVirtualMachineTemplateData(e)), _scVmmVirtualMachineTemplateVirtualMachineTemplatesClientDiagnostics, Pipeline, "ScVmmVirtualMachineTemplateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the VirtualMachineTemplate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _scVmmVirtualMachineTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("ScVmmVirtualMachineTemplateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the VirtualMachineTemplate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _scVmmVirtualMachineTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("ScVmmVirtualMachineTemplateCollection.Exists");
            scope.Start();
            try
            {
                var response = _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the VirtualMachineTemplate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual async Task<NullableResponse<ScVmmVirtualMachineTemplateResource>> GetIfExistsAsync(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _scVmmVirtualMachineTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("ScVmmVirtualMachineTemplateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ScVmmVirtualMachineTemplateResource>(response.GetRawResponse());
                return Response.FromValue(new ScVmmVirtualMachineTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the VirtualMachineTemplate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual NullableResponse<ScVmmVirtualMachineTemplateResource> GetIfExists(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _scVmmVirtualMachineTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("ScVmmVirtualMachineTemplateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _scVmmVirtualMachineTemplateVirtualMachineTemplatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ScVmmVirtualMachineTemplateResource>(response.GetRawResponse());
                return Response.FromValue(new ScVmmVirtualMachineTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScVmmVirtualMachineTemplateResource> IEnumerable<ScVmmVirtualMachineTemplateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScVmmVirtualMachineTemplateResource> IAsyncEnumerable<ScVmmVirtualMachineTemplateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
