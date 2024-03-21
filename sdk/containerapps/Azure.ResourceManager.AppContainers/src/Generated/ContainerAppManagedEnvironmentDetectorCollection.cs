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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerAppManagedEnvironmentDetectorResource"/> and their operations.
    /// Each <see cref="ContainerAppManagedEnvironmentDetectorResource"/> in the collection will belong to the same instance of <see cref="ContainerAppManagedEnvironmentResource"/>.
    /// To get a <see cref="ContainerAppManagedEnvironmentDetectorCollection"/> instance call the GetContainerAppManagedEnvironmentDetectors method from an instance of <see cref="ContainerAppManagedEnvironmentResource"/>.
    /// </summary>
    public partial class ContainerAppManagedEnvironmentDetectorCollection : ArmCollection, IEnumerable<ContainerAppManagedEnvironmentDetectorResource>, IAsyncEnumerable<ContainerAppManagedEnvironmentDetectorResource>
    {
        private readonly ClientDiagnostics _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsClientDiagnostics;
        private readonly ManagedEnvironmentDiagnosticsRestOperations _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedEnvironmentDetectorCollection"/> class for mocking. </summary>
        protected ContainerAppManagedEnvironmentDetectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedEnvironmentDetectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerAppManagedEnvironmentDetectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppManagedEnvironmentDetectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppManagedEnvironmentDetectorResource.ResourceType, out string containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsApiVersion);
            _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsRestClient = new ManagedEnvironmentDiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerAppManagedEnvironmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerAppManagedEnvironmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the diagnostics data for a Managed Environment used to host container apps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentDiagnostics_GetDetector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Name of the Managed Environment detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<Response<ContainerAppManagedEnvironmentDetectorResource>> GetAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsRestClient.GetDetectorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the diagnostics data for a Managed Environment used to host container apps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentDiagnostics_GetDetector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Name of the Managed Environment detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<ContainerAppManagedEnvironmentDetectorResource> Get(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsRestClient.GetDetector(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the list of diagnostics for a Managed Environment used to host container apps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/detectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentDiagnostics_ListDetectors</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppManagedEnvironmentDetectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppManagedEnvironmentDetectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsRestClient.CreateListDetectorsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ContainerAppManagedEnvironmentDetectorResource(Client, ContainerAppDiagnosticData.DeserializeContainerAppDiagnosticData(e)), _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsClientDiagnostics, Pipeline, "ContainerAppManagedEnvironmentDetectorCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the list of diagnostics for a Managed Environment used to host container apps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/detectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentDiagnostics_ListDetectors</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppManagedEnvironmentDetectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppManagedEnvironmentDetectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsRestClient.CreateListDetectorsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new ContainerAppManagedEnvironmentDetectorResource(Client, ContainerAppDiagnosticData.DeserializeContainerAppDiagnosticData(e)), _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsClientDiagnostics, Pipeline, "ContainerAppManagedEnvironmentDetectorCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentDiagnostics_GetDetector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Name of the Managed Environment detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsRestClient.GetDetectorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentDiagnostics_GetDetector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Name of the Managed Environment detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsRestClient.GetDetector(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentDiagnostics_GetDetector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Name of the Managed Environment detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerAppManagedEnvironmentDetectorResource>> GetIfExistsAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsRestClient.GetDetectorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppManagedEnvironmentDetectorResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentDetectorResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/detectors/{detectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentDiagnostics_GetDetector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="detectorName"> Name of the Managed Environment detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual NullableResponse<ContainerAppManagedEnvironmentDetectorResource> GetIfExists(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentDetectorManagedEnvironmentDiagnosticsRestClient.GetDetector(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppManagedEnvironmentDetectorResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerAppManagedEnvironmentDetectorResource> IEnumerable<ContainerAppManagedEnvironmentDetectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerAppManagedEnvironmentDetectorResource> IAsyncEnumerable<ContainerAppManagedEnvironmentDetectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
