// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Elastic;

namespace Azure.ResourceManager.Elastic.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableElasticSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _elasticMonitorResourceMonitorsClientDiagnostics;
        private MonitorsRestOperations _elasticMonitorResourceMonitorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableElasticSubscriptionResource"/> class for mocking. </summary>
        protected MockableElasticSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableElasticSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableElasticSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ElasticMonitorResourceMonitorsClientDiagnostics => _elasticMonitorResourceMonitorsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Elastic", ElasticMonitorResource.ResourceType.Namespace, Diagnostics);
        private MonitorsRestOperations ElasticMonitorResourceMonitorsRestClient => _elasticMonitorResourceMonitorsRestClient ??= new MonitorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ElasticMonitorResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all monitors under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Elastic/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ElasticMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ElasticMonitorResource> GetElasticMonitorResourcesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ElasticMonitorResourceMonitorsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ElasticMonitorResourceMonitorsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ElasticMonitorResource(Client, ElasticMonitorResourceData.DeserializeElasticMonitorResourceData(e)), ElasticMonitorResourceMonitorsClientDiagnostics, Pipeline, "MockableElasticSubscriptionResource.GetElasticMonitorResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all monitors under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Elastic/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ElasticMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ElasticMonitorResource> GetElasticMonitorResources(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ElasticMonitorResourceMonitorsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ElasticMonitorResourceMonitorsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ElasticMonitorResource(Client, ElasticMonitorResourceData.DeserializeElasticMonitorResourceData(e)), ElasticMonitorResourceMonitorsClientDiagnostics, Pipeline, "MockableElasticSubscriptionResource.GetElasticMonitorResources", "value", "nextLink", cancellationToken);
        }
    }
}
