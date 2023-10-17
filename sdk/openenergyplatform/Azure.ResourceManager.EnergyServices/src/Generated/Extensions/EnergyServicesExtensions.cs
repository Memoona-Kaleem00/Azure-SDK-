// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.EnergyServices.Mocking;
using Azure.ResourceManager.EnergyServices.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EnergyServices
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.EnergyServices. </summary>
    public static partial class EnergyServicesExtensions
    {
        private static EnergyServicesArmClientMockingExtension GetEnergyServicesArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client0 => new EnergyServicesArmClientMockingExtension(client0));
        }

        private static EnergyServicesResourceGroupMockingExtension GetEnergyServicesResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client => new EnergyServicesResourceGroupMockingExtension(client, resource.Id));
        }

        private static EnergyServicesSubscriptionMockingExtension GetEnergyServicesSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client => new EnergyServicesSubscriptionMockingExtension(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="EnergyServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EnergyServiceResource.CreateResourceIdentifier" /> to create an <see cref="EnergyServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="EnergyServicesArmClientMockingExtension.GetEnergyServiceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EnergyServiceResource" /> object. </returns>
        public static EnergyServiceResource GetEnergyServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetEnergyServicesArmClientMockingExtension(client).GetEnergyServiceResource(id);
        }

        /// <summary>
        /// Gets a collection of EnergyServiceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="EnergyServicesResourceGroupMockingExtension.GetEnergyServices()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of EnergyServiceResources and their operations over a EnergyServiceResource. </returns>
        public static EnergyServiceCollection GetEnergyServices(this ResourceGroupResource resourceGroupResource)
        {
            return GetEnergyServicesResourceGroupMockingExtension(resourceGroupResource).GetEnergyServices();
        }

        /// <summary>
        /// Returns oep resource for a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OpenEnergyPlatform/energyServices/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnergyServices_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="EnergyServicesResourceGroupMockingExtension.GetEnergyServiceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<EnergyServiceResource>> GetEnergyServiceAsync(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetEnergyServicesResourceGroupMockingExtension(resourceGroupResource).GetEnergyServiceAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns oep resource for a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OpenEnergyPlatform/energyServices/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnergyServices_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="EnergyServicesResourceGroupMockingExtension.GetEnergyService(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<EnergyServiceResource> GetEnergyService(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return GetEnergyServicesResourceGroupMockingExtension(resourceGroupResource).GetEnergyService(resourceName, cancellationToken);
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
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="EnergyServicesSubscriptionMockingExtension.CheckNameAvailabilityLocation(EnergyServiceNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> NameAvailabilityRequest object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<EnergyServiceNameAvailabilityResult>> CheckNameAvailabilityLocationAsync(this SubscriptionResource subscriptionResource, EnergyServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetEnergyServicesSubscriptionMockingExtension(subscriptionResource).CheckNameAvailabilityLocationAsync(content, cancellationToken).ConfigureAwait(false);
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
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="EnergyServicesSubscriptionMockingExtension.CheckNameAvailabilityLocation(EnergyServiceNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> NameAvailabilityRequest object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<EnergyServiceNameAvailabilityResult> CheckNameAvailabilityLocation(this SubscriptionResource subscriptionResource, EnergyServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetEnergyServicesSubscriptionMockingExtension(subscriptionResource).CheckNameAvailabilityLocation(content, cancellationToken);
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
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="EnergyServicesSubscriptionMockingExtension.GetEnergyServices(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EnergyServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<EnergyServiceResource> GetEnergyServicesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetEnergyServicesSubscriptionMockingExtension(subscriptionResource).GetEnergyServicesAsync(cancellationToken);
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
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="EnergyServicesSubscriptionMockingExtension.GetEnergyServices(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EnergyServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<EnergyServiceResource> GetEnergyServices(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetEnergyServicesSubscriptionMockingExtension(subscriptionResource).GetEnergyServices(cancellationToken);
        }
    }
}
