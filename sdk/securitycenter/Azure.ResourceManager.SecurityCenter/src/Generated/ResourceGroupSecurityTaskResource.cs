// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a ResourceGroupSecurityTask along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ResourceGroupSecurityTaskResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetResourceGroupSecurityTaskResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource"/> using the GetResourceGroupSecurityTask method.
    /// </summary>
    public partial class ResourceGroupSecurityTaskResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceGroupSecurityTaskResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="ascLocation"> The ascLocation. </param>
        /// <param name="taskName"> The taskName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, AzureLocation ascLocation, string taskName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceGroupSecurityTaskTasksClientDiagnostics;
        private readonly TasksRestOperations _resourceGroupSecurityTaskTasksRestClient;
        private readonly SecurityTaskData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/locations/tasks";

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupSecurityTaskResource"/> class for mocking. </summary>
        protected ResourceGroupSecurityTaskResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupSecurityTaskResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceGroupSecurityTaskResource(ArmClient client, SecurityTaskData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupSecurityTaskResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupSecurityTaskResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceGroupSecurityTaskTasksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceGroupSecurityTaskTasksApiVersion);
            _resourceGroupSecurityTaskTasksRestClient = new TasksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGroupSecurityTaskTasksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecurityTaskData Data
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
        /// Recommended tasks that will help improve the security of the subscription proactively
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_GetResourceGroupLevelTask</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2015-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupSecurityTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceGroupSecurityTaskResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupSecurityTaskTasksClientDiagnostics.CreateScope("ResourceGroupSecurityTaskResource.Get");
            scope.Start();
            try
            {
                var response = await _resourceGroupSecurityTaskTasksRestClient.GetResourceGroupLevelTaskAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupSecurityTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Recommended tasks that will help improve the security of the subscription proactively
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_GetResourceGroupLevelTask</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2015-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupSecurityTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceGroupSecurityTaskResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupSecurityTaskTasksClientDiagnostics.CreateScope("ResourceGroupSecurityTaskResource.Get");
            scope.Start();
            try
            {
                var response = _resourceGroupSecurityTaskTasksRestClient.GetResourceGroupLevelTask(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupSecurityTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
