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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A Class representing a ContainerAppManagedEnvironmentDetectorResourceProperty along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ContainerAppManagedEnvironmentDetectorResourcePropertyResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetContainerAppManagedEnvironmentDetectorResourcePropertyResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerAppManagedEnvironmentResource"/> using the GetContainerAppManagedEnvironmentDetectorResourceProperty method.
    /// </summary>
    public partial class ContainerAppManagedEnvironmentDetectorResourcePropertyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ContainerAppManagedEnvironmentDetectorResourcePropertyResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="environmentName"> The environmentName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string environmentName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/detectorProperties/rootApi";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _containerAppManagedEnvironmentDetectorResourcePropertyManagedEnvironmentsDiagnosticsClientDiagnostics;
        private readonly ManagedEnvironmentsDiagnosticsRestOperations _containerAppManagedEnvironmentDetectorResourcePropertyManagedEnvironmentsDiagnosticsRestClient;
        private readonly ContainerAppManagedEnvironmentData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.App/managedEnvironments/detectorProperties";

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedEnvironmentDetectorResourcePropertyResource"/> class for mocking. </summary>
        protected ContainerAppManagedEnvironmentDetectorResourcePropertyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedEnvironmentDetectorResourcePropertyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ContainerAppManagedEnvironmentDetectorResourcePropertyResource(ArmClient client, ContainerAppManagedEnvironmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppManagedEnvironmentDetectorResourcePropertyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContainerAppManagedEnvironmentDetectorResourcePropertyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppManagedEnvironmentDetectorResourcePropertyManagedEnvironmentsDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string containerAppManagedEnvironmentDetectorResourcePropertyManagedEnvironmentsDiagnosticsApiVersion);
            _containerAppManagedEnvironmentDetectorResourcePropertyManagedEnvironmentsDiagnosticsRestClient = new ManagedEnvironmentsDiagnosticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppManagedEnvironmentDetectorResourcePropertyManagedEnvironmentsDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContainerAppManagedEnvironmentData Data
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

        /// <summary>
        /// Get the properties of a Managed Environment used to host container apps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/detectorProperties/rootApi</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentsDiagnostics_GetRoot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContainerAppManagedEnvironmentDetectorResourcePropertyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppManagedEnvironmentDetectorResourcePropertyManagedEnvironmentsDiagnosticsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDetectorResourcePropertyResource.Get");
            scope.Start();
            try
            {
                var response = await _containerAppManagedEnvironmentDetectorResourcePropertyManagedEnvironmentsDiagnosticsRestClient.GetRootAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentDetectorResourcePropertyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of a Managed Environment used to host container apps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}/detectorProperties/rootApi</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironmentsDiagnostics_GetRoot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContainerAppManagedEnvironmentDetectorResourcePropertyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppManagedEnvironmentDetectorResourcePropertyManagedEnvironmentsDiagnosticsClientDiagnostics.CreateScope("ContainerAppManagedEnvironmentDetectorResourcePropertyResource.Get");
            scope.Start();
            try
            {
                var response = _containerAppManagedEnvironmentDetectorResourcePropertyManagedEnvironmentsDiagnosticsRestClient.GetRoot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppManagedEnvironmentDetectorResourcePropertyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
