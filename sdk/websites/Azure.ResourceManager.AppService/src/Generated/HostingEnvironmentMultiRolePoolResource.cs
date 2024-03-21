// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a HostingEnvironmentMultiRolePool along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="HostingEnvironmentMultiRolePoolResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetHostingEnvironmentMultiRolePoolResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppServiceEnvironmentResource"/> using the GetHostingEnvironmentMultiRolePool method.
    /// </summary>
    public partial class HostingEnvironmentMultiRolePoolResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HostingEnvironmentMultiRolePoolResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics;
        private readonly AppServiceEnvironmentsRestOperations _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient;
        private readonly AppServiceWorkerPoolData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/hostingEnvironments/multiRolePools";

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentMultiRolePoolResource"/> class for mocking. </summary>
        protected HostingEnvironmentMultiRolePoolResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentMultiRolePoolResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HostingEnvironmentMultiRolePoolResource(ArmClient client, AppServiceWorkerPoolData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentMultiRolePoolResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HostingEnvironmentMultiRolePoolResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string hostingEnvironmentMultiRolePoolAppServiceEnvironmentsApiVersion);
            _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hostingEnvironmentMultiRolePoolAppServiceEnvironmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AppServiceWorkerPoolData Data
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
        /// Description for Get properties of a multi-role pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_GetMultiRolePool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentMultiRolePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HostingEnvironmentMultiRolePoolResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePoolResource.Get");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.GetMultiRolePoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentMultiRolePoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get properties of a multi-role pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_GetMultiRolePool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentMultiRolePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HostingEnvironmentMultiRolePoolResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePoolResource.Get");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.GetMultiRolePool(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentMultiRolePoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Create or update a multi-role pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_UpdateMultiRolePool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentMultiRolePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Properties of the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<HostingEnvironmentMultiRolePoolResource>> UpdateAsync(AppServiceWorkerPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePoolResource.Update");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.UpdateMultiRolePoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new HostingEnvironmentMultiRolePoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Create or update a multi-role pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_UpdateMultiRolePool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentMultiRolePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Properties of the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<HostingEnvironmentMultiRolePoolResource> Update(AppServiceWorkerPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePoolResource.Update");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.UpdateMultiRolePool(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                return Response.FromValue(new HostingEnvironmentMultiRolePoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Create or update a multi-role pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_CreateOrUpdateMultiRolePool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentMultiRolePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties of the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HostingEnvironmentMultiRolePoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, AppServiceWorkerPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePoolResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateOrUpdateMultiRolePoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<HostingEnvironmentMultiRolePoolResource>(new HostingEnvironmentMultiRolePoolOperationSource(Client), _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics, Pipeline, _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateCreateOrUpdateMultiRolePoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Create or update a multi-role pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_CreateOrUpdateMultiRolePool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentMultiRolePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties of the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HostingEnvironmentMultiRolePoolResource> CreateOrUpdate(WaitUntil waitUntil, AppServiceWorkerPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentMultiRolePoolResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateOrUpdateMultiRolePool(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var operation = new AppServiceArmOperation<HostingEnvironmentMultiRolePoolResource>(new HostingEnvironmentMultiRolePoolOperationSource(Client), _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics, Pipeline, _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateCreateOrUpdateMultiRolePoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get metric definitions for a specific instance of a multi-role pool of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/instances/{instance}/metricdefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListMultiRolePoolInstanceMetricDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instance"> Name of the instance in the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instance"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instance"/> is null. </exception>
        /// <returns> An async collection of <see cref="ResourceMetricDefinition"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceMetricDefinition> GetMultiRolePoolInstanceMetricDefinitionsAsync(string instance, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instance, nameof(instance));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRolePoolInstanceMetricDefinitionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, instance);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRolePoolInstanceMetricDefinitionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, instance);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ResourceMetricDefinition.DeserializeResourceMetricDefinition(e), _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentMultiRolePoolResource.GetMultiRolePoolInstanceMetricDefinitions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get metric definitions for a specific instance of a multi-role pool of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/instances/{instance}/metricdefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListMultiRolePoolInstanceMetricDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instance"> Name of the instance in the multi-role pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instance"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instance"/> is null. </exception>
        /// <returns> A collection of <see cref="ResourceMetricDefinition"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceMetricDefinition> GetMultiRolePoolInstanceMetricDefinitions(string instance, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instance, nameof(instance));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRolePoolInstanceMetricDefinitionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, instance);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRolePoolInstanceMetricDefinitionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, instance);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ResourceMetricDefinition.DeserializeResourceMetricDefinition(e), _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentMultiRolePoolResource.GetMultiRolePoolInstanceMetricDefinitions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get metric definitions for a multi-role pool of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/metricdefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListMultiRoleMetricDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentMultiRolePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceMetricDefinition"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceMetricDefinition> GetMultiRoleMetricDefinitionsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRoleMetricDefinitionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRoleMetricDefinitionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ResourceMetricDefinition.DeserializeResourceMetricDefinition(e), _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentMultiRolePoolResource.GetMultiRoleMetricDefinitions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get metric definitions for a multi-role pool of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/metricdefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListMultiRoleMetricDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentMultiRolePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceMetricDefinition"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceMetricDefinition> GetMultiRoleMetricDefinitions(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRoleMetricDefinitionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRoleMetricDefinitionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ResourceMetricDefinition.DeserializeResourceMetricDefinition(e), _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentMultiRolePoolResource.GetMultiRoleMetricDefinitions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get available SKUs for scaling a multi-role pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListMultiRolePoolSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentMultiRolePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServicePoolSkuInfo"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServicePoolSkuInfo> GetMultiRolePoolSkusAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRolePoolSkusRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRolePoolSkusNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => AppServicePoolSkuInfo.DeserializeAppServicePoolSkuInfo(e), _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentMultiRolePoolResource.GetMultiRolePoolSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get available SKUs for scaling a multi-role pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListMultiRolePoolSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentMultiRolePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServicePoolSkuInfo"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServicePoolSkuInfo> GetMultiRolePoolSkus(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRolePoolSkusRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRolePoolSkusNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => AppServicePoolSkuInfo.DeserializeAppServicePoolSkuInfo(e), _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentMultiRolePoolResource.GetMultiRolePoolSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get usage metrics for a multi-role pool of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListMultiRoleUsages</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentMultiRolePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServiceUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServiceUsage> GetMultiRoleUsagesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRoleUsagesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRoleUsagesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => AppServiceUsage.DeserializeAppServiceUsage(e), _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentMultiRolePoolResource.GetMultiRoleUsages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get usage metrics for a multi-role pool of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/multiRolePools/default/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListMultiRoleUsages</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostingEnvironmentMultiRolePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServiceUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServiceUsage> GetMultiRoleUsages(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRoleUsagesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsRestClient.CreateListMultiRoleUsagesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => AppServiceUsage.DeserializeAppServiceUsage(e), _hostingEnvironmentMultiRolePoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentMultiRolePoolResource.GetMultiRoleUsages", "value", "nextLink", cancellationToken);
        }
    }
}
