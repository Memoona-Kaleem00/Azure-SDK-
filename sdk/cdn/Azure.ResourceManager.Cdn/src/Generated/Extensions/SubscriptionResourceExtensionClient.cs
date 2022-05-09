// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Cdn.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _defaultClientDiagnostics;
        private CdnManagementRestOperations _defaultRestClient;
        private ClientDiagnostics _profileClientDiagnostics;
        private ProfilesRestOperations _profileRestClient;
        private ClientDiagnostics _resourceUsageClientDiagnostics;
        private ResourceUsageRestOperations _resourceUsageRestClient;
        private ClientDiagnostics _managedRuleSetsClientDiagnostics;
        private ManagedRuleSetsRestOperations _managedRuleSetsRestClient;

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

        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Cdn", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CdnManagementRestOperations DefaultRestClient => _defaultRestClient ??= new CdnManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ProfileClientDiagnostics => _profileClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Cdn", ProfileResource.ResourceType.Namespace, Diagnostics);
        private ProfilesRestOperations ProfileRestClient => _profileRestClient ??= new ProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ProfileResource.ResourceType));
        private ClientDiagnostics ResourceUsageClientDiagnostics => _resourceUsageClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Cdn", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ResourceUsageRestOperations ResourceUsageRestClient => _resourceUsageRestClient ??= new ResourceUsageRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ManagedRuleSetsClientDiagnostics => _managedRuleSetsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Cdn", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ManagedRuleSetsRestOperations ManagedRuleSetsRestClient => _managedRuleSetsRestClient ??= new ManagedRuleSetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Check the availability of a resource name. This is needed for resources where name is globally unique, such as a CDN endpoint.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cdn/checkNameAvailability
        /// Operation Id: CheckNameAvailabilityWithSubscription
        /// </summary>
        /// <param name="input"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckNameAvailabilityOutput>> CheckCdnNameAvailabilityWithSubscriptionAsync(CheckNameAvailabilityInput input, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckCdnNameAvailabilityWithSubscription");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.CheckNameAvailabilityWithSubscriptionAsync(Id.SubscriptionId, input, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of a resource name. This is needed for resources where name is globally unique, such as a CDN endpoint.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cdn/checkNameAvailability
        /// Operation Id: CheckNameAvailabilityWithSubscription
        /// </summary>
        /// <param name="input"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckNameAvailabilityOutput> CheckCdnNameAvailabilityWithSubscription(CheckNameAvailabilityInput input, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckCdnNameAvailabilityWithSubscription");
            scope.Start();
            try
            {
                var response = DefaultRestClient.CheckNameAvailabilityWithSubscription(Id.SubscriptionId, input, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if the probe path is a valid path and the file can be accessed. Probe path is the path to a file hosted on the origin server to help accelerate the delivery of dynamic content via the CDN endpoint. This path is relative to the origin path specified in the endpoint configuration.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cdn/validateProbe
        /// Operation Id: ValidateProbe
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ValidateProbeOutput>> ValidateProbeAsync(ValidateProbeContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.ValidateProbe");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.ValidateProbeAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if the probe path is a valid path and the file can be accessed. Probe path is the path to a file hosted on the origin server to help accelerate the delivery of dynamic content via the CDN endpoint. This path is relative to the origin path specified in the endpoint configuration.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cdn/validateProbe
        /// Operation Id: ValidateProbe
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ValidateProbeOutput> ValidateProbe(ValidateProbeContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.ValidateProbe");
            scope.Start();
            try
            {
                var response = DefaultRestClient.ValidateProbe(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the Azure Front Door Standard, Azure Front Door Premium, and CDN profiles within an Azure subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cdn/profiles
        /// Operation Id: Profiles_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProfileResource> GetProfilesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ProfileResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ProfileClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetProfiles");
                scope.Start();
                try
                {
                    var response = await ProfileRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ProfileResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ProfileResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ProfileClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetProfiles");
                scope.Start();
                try
                {
                    var response = await ProfileRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ProfileResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all of the Azure Front Door Standard, Azure Front Door Premium, and CDN profiles within an Azure subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cdn/profiles
        /// Operation Id: Profiles_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProfileResource> GetProfiles(CancellationToken cancellationToken = default)
        {
            Page<ProfileResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ProfileClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetProfiles");
                scope.Start();
                try
                {
                    var response = ProfileRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ProfileResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ProfileResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ProfileClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetProfiles");
                scope.Start();
                try
                {
                    var response = ProfileRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ProfileResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Check the quota and actual usage of the CDN profiles under the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cdn/checkResourceUsage
        /// Operation Id: ResourceUsage_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceUsage> GetResourceUsagesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceUsage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ResourceUsageClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetResourceUsages");
                scope.Start();
                try
                {
                    var response = await ResourceUsageRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceUsage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ResourceUsageClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetResourceUsages");
                scope.Start();
                try
                {
                    var response = await ResourceUsageRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Check the quota and actual usage of the CDN profiles under the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cdn/checkResourceUsage
        /// Operation Id: ResourceUsage_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceUsage> GetResourceUsages(CancellationToken cancellationToken = default)
        {
            Page<ResourceUsage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ResourceUsageClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetResourceUsages");
                scope.Start();
                try
                {
                    var response = ResourceUsageRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceUsage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ResourceUsageClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetResourceUsages");
                scope.Start();
                try
                {
                    var response = ResourceUsageRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all available managed rule sets.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cdn/cdnWebApplicationFirewallManagedRuleSets
        /// Operation Id: ManagedRuleSets_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedRuleSetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedRuleSetDefinition> GetManagedRuleSetsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedRuleSetDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedRuleSetsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedRuleSets");
                scope.Start();
                try
                {
                    var response = await ManagedRuleSetsRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedRuleSetDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedRuleSetsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedRuleSets");
                scope.Start();
                try
                {
                    var response = await ManagedRuleSetsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all available managed rule sets.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cdn/cdnWebApplicationFirewallManagedRuleSets
        /// Operation Id: ManagedRuleSets_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedRuleSetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedRuleSetDefinition> GetManagedRuleSets(CancellationToken cancellationToken = default)
        {
            Page<ManagedRuleSetDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ManagedRuleSetsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedRuleSets");
                scope.Start();
                try
                {
                    var response = ManagedRuleSetsRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedRuleSetDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ManagedRuleSetsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetManagedRuleSets");
                scope.Start();
                try
                {
                    var response = ManagedRuleSetsRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
