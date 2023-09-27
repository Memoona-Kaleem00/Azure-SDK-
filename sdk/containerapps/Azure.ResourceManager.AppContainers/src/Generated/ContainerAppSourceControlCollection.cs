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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerAppSourceControlResource" /> and their operations.
    /// Each <see cref="ContainerAppSourceControlResource" /> in the collection will belong to the same instance of <see cref="ContainerAppResource" />.
    /// To get a <see cref="ContainerAppSourceControlCollection" /> instance call the GetContainerAppSourceControls method from an instance of <see cref="ContainerAppResource" />.
    /// </summary>
    public partial class ContainerAppSourceControlCollection : ArmCollection, IEnumerable<ContainerAppSourceControlResource>, IAsyncEnumerable<ContainerAppSourceControlResource>
    {
        private readonly ClientDiagnostics _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics;
        private readonly ContainerAppsSourceControlsRestOperations _containerAppSourceControlContainerAppsSourceControlsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppSourceControlCollection"/> class for mocking. </summary>
        protected ContainerAppSourceControlCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppSourceControlCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerAppSourceControlCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppSourceControlResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppSourceControlResource.ResourceType, out string containerAppSourceControlContainerAppsSourceControlsApiVersion);
            _containerAppSourceControlContainerAppsSourceControlsRestClient = new ContainerAppsSourceControlsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppSourceControlContainerAppsSourceControlsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerAppResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerAppResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update the SourceControl for a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sourceControlName"> Name of the Container App SourceControl. </param>
        /// <param name="data"> Properties used to create a Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerAppSourceControlResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sourceControlName, ContainerAppSourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("ContainerAppSourceControlCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerAppSourceControlContainerAppsSourceControlsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation<ContainerAppSourceControlResource>(new ContainerAppSourceControlOperationSource(Client), _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics, Pipeline, _containerAppSourceControlContainerAppsSourceControlsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update the SourceControl for a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sourceControlName"> Name of the Container App SourceControl. </param>
        /// <param name="data"> Properties used to create a Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerAppSourceControlResource> CreateOrUpdate(WaitUntil waitUntil, string sourceControlName, ContainerAppSourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("ContainerAppSourceControlCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerAppSourceControlContainerAppsSourceControlsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, data, cancellationToken);
                var operation = new AppContainersArmOperation<ContainerAppSourceControlResource>(new ContainerAppSourceControlOperationSource(Client), _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics, Pipeline, _containerAppSourceControlContainerAppsSourceControlsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a SourceControl of a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlName"> Name of the Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> is null. </exception>
        public virtual async Task<Response<ContainerAppSourceControlResource>> GetAsync(string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var scope = _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("ContainerAppSourceControlCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerAppSourceControlContainerAppsSourceControlsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a SourceControl of a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlName"> Name of the Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> is null. </exception>
        public virtual Response<ContainerAppSourceControlResource> Get(string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var scope = _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("ContainerAppSourceControlCollection.Get");
            scope.Start();
            try
            {
                var response = _containerAppSourceControlContainerAppsSourceControlsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Container App SourceControls in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_ListByContainerApp</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppSourceControlResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppSourceControlResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppSourceControlContainerAppsSourceControlsRestClient.CreateListByContainerAppRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppSourceControlContainerAppsSourceControlsRestClient.CreateListByContainerAppNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerAppSourceControlResource(Client, ContainerAppSourceControlData.DeserializeContainerAppSourceControlData(e)), _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics, Pipeline, "ContainerAppSourceControlCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the Container App SourceControls in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_ListByContainerApp</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppSourceControlResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppSourceControlResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppSourceControlContainerAppsSourceControlsRestClient.CreateListByContainerAppRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppSourceControlContainerAppsSourceControlsRestClient.CreateListByContainerAppNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerAppSourceControlResource(Client, ContainerAppSourceControlData.DeserializeContainerAppSourceControlData(e)), _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics, Pipeline, "ContainerAppSourceControlCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlName"> Name of the Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var scope = _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("ContainerAppSourceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerAppSourceControlContainerAppsSourceControlsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlName"> Name of the Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> is null. </exception>
        public virtual Response<bool> Exists(string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var scope = _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("ContainerAppSourceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerAppSourceControlContainerAppsSourceControlsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlName"> Name of the Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerAppSourceControlResource>> GetIfExistsAsync(string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var scope = _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("ContainerAppSourceControlCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerAppSourceControlContainerAppsSourceControlsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppSourceControlResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppSourceControlResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/sourcecontrols/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSourceControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlName"> Name of the Container App SourceControl. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> is null. </exception>
        public virtual NullableResponse<ContainerAppSourceControlResource> GetIfExists(string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var scope = _containerAppSourceControlContainerAppsSourceControlsClientDiagnostics.CreateScope("ContainerAppSourceControlCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerAppSourceControlContainerAppsSourceControlsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppSourceControlResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerAppSourceControlResource> IEnumerable<ContainerAppSourceControlResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerAppSourceControlResource> IAsyncEnumerable<ContainerAppSourceControlResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
