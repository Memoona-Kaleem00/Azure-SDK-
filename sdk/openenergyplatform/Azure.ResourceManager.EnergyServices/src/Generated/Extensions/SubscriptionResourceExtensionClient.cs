// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.EnergyServices.Models;

namespace Azure.ResourceManager.EnergyServices
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _locationsClientDiagnostics;
        private LocationsRestOperations _locationsRestClient;
        private ClientDiagnostics _energyServiceClientDiagnostics;
        private EnergyServicesRestOperations _energyServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics LocationsClientDiagnostics => _locationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.EnergyServices", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationsRestOperations LocationsRestClient => _locationsRestClient ??= new LocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics EnergyServiceClientDiagnostics => _energyServiceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.EnergyServices", EnergyServiceResource.ResourceType.Namespace, Diagnostics);
        private EnergyServicesRestOperations EnergyServiceRestClient => _energyServiceRestClient ??= new EnergyServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(EnergyServiceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Checks the name availability of the resource with requested resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.OpenEnergyPlatform/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> NameAvailabilityRequest object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EnergyServiceNameAvailabilityResult>> CheckNameAvailabilityLocationAsync(EnergyServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityLocation");
            scope.Start();
            try
            {
                var response = await LocationsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks the name availability of the resource with requested resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.OpenEnergyPlatform/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> NameAvailabilityRequest object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EnergyServiceNameAvailabilityResult> CheckNameAvailabilityLocation(EnergyServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityLocation");
            scope.Start();
            try
            {
                var response = LocationsRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of oep resources under the given Azure Subscription ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.OpenEnergyPlatform/energyServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnergyServices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EnergyServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EnergyServiceResource> GetEnergyServicesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EnergyServiceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EnergyServiceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EnergyServiceResource(Client, EnergyServiceData.DeserializeEnergyServiceData(e)), EnergyServiceClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetEnergyServices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of oep resources under the given Azure Subscription ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.OpenEnergyPlatform/energyServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnergyServices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EnergyServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EnergyServiceResource> GetEnergyServices(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EnergyServiceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EnergyServiceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EnergyServiceResource(Client, EnergyServiceData.DeserializeEnergyServiceData(e)), EnergyServiceClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetEnergyServices", "value", "nextLink", cancellationToken);
        }
    }
}
