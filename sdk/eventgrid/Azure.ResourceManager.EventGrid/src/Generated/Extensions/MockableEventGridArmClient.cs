// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableEventGridArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableEventGridArmClient"/> class for mocking. </summary>
        protected MockableEventGridArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableEventGridArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableEventGridArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableEventGridArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of EventSubscriptionResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of EventSubscriptionResources and their operations over a EventSubscriptionResource. </returns>
        public virtual EventSubscriptionCollection GetEventSubscriptions(ResourceIdentifier scope)
        {
            return new EventSubscriptionCollection(Client, scope);
        }

        /// <summary>
        /// Get properties of an event subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.EventGrid/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="eventSubscriptionName"> Name of the event subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<EventSubscriptionResource>> GetEventSubscriptionAsync(ResourceIdentifier scope, string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            return await GetEventSubscriptions(scope).GetAsync(eventSubscriptionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get properties of an event subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.EventGrid/eventSubscriptions/{eventSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="eventSubscriptionName"> Name of the event subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventSubscriptionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="eventSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<EventSubscriptionResource> GetEventSubscription(ResourceIdentifier scope, string eventSubscriptionName, CancellationToken cancellationToken = default)
        {
            return GetEventSubscriptions(scope).Get(eventSubscriptionName, cancellationToken);
        }

        /// <summary> Gets an object representing a ExtensionTopicResource along with the instance operations that can be performed on it in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> Returns a <see cref="ExtensionTopicResource"/> object. </returns>
        public virtual ExtensionTopicResource GetExtensionTopic(ResourceIdentifier scope)
        {
            return new ExtensionTopicResource(Client, scope.AppendProviderResource("Microsoft.EventGrid", "extensionTopics", "default"));
        }

        /// <summary>
        /// Gets an object representing a <see cref="CaCertificateResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CaCertificateResource.CreateResourceIdentifier" /> to create a <see cref="CaCertificateResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CaCertificateResource"/> object. </returns>
        public virtual CaCertificateResource GetCaCertificateResource(ResourceIdentifier id)
        {
            CaCertificateResource.ValidateResourceId(id);
            return new CaCertificateResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PartnerNamespaceChannelResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PartnerNamespaceChannelResource.CreateResourceIdentifier" /> to create a <see cref="PartnerNamespaceChannelResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PartnerNamespaceChannelResource"/> object. </returns>
        public virtual PartnerNamespaceChannelResource GetPartnerNamespaceChannelResource(ResourceIdentifier id)
        {
            PartnerNamespaceChannelResource.ValidateResourceId(id);
            return new PartnerNamespaceChannelResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventGridNamespaceClientGroupResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventGridNamespaceClientGroupResource.CreateResourceIdentifier" /> to create an <see cref="EventGridNamespaceClientGroupResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventGridNamespaceClientGroupResource"/> object. </returns>
        public virtual EventGridNamespaceClientGroupResource GetEventGridNamespaceClientGroupResource(ResourceIdentifier id)
        {
            EventGridNamespaceClientGroupResource.ValidateResourceId(id);
            return new EventGridNamespaceClientGroupResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventGridNamespaceClientResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventGridNamespaceClientResource.CreateResourceIdentifier" /> to create an <see cref="EventGridNamespaceClientResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventGridNamespaceClientResource"/> object. </returns>
        public virtual EventGridNamespaceClientResource GetEventGridNamespaceClientResource(ResourceIdentifier id)
        {
            EventGridNamespaceClientResource.ValidateResourceId(id);
            return new EventGridNamespaceClientResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventGridDomainResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventGridDomainResource.CreateResourceIdentifier" /> to create an <see cref="EventGridDomainResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventGridDomainResource"/> object. </returns>
        public virtual EventGridDomainResource GetEventGridDomainResource(ResourceIdentifier id)
        {
            EventGridDomainResource.ValidateResourceId(id);
            return new EventGridDomainResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DomainTopicResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DomainTopicResource.CreateResourceIdentifier" /> to create a <see cref="DomainTopicResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DomainTopicResource"/> object. </returns>
        public virtual DomainTopicResource GetDomainTopicResource(ResourceIdentifier id)
        {
            DomainTopicResource.ValidateResourceId(id);
            return new DomainTopicResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DomainTopicEventSubscriptionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DomainTopicEventSubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="DomainTopicEventSubscriptionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DomainTopicEventSubscriptionResource"/> object. </returns>
        public virtual DomainTopicEventSubscriptionResource GetDomainTopicEventSubscriptionResource(ResourceIdentifier id)
        {
            DomainTopicEventSubscriptionResource.ValidateResourceId(id);
            return new DomainTopicEventSubscriptionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TopicEventSubscriptionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TopicEventSubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="TopicEventSubscriptionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TopicEventSubscriptionResource"/> object. </returns>
        public virtual TopicEventSubscriptionResource GetTopicEventSubscriptionResource(ResourceIdentifier id)
        {
            TopicEventSubscriptionResource.ValidateResourceId(id);
            return new TopicEventSubscriptionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DomainEventSubscriptionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DomainEventSubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="DomainEventSubscriptionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DomainEventSubscriptionResource"/> object. </returns>
        public virtual DomainEventSubscriptionResource GetDomainEventSubscriptionResource(ResourceIdentifier id)
        {
            DomainEventSubscriptionResource.ValidateResourceId(id);
            return new DomainEventSubscriptionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventSubscriptionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventSubscriptionResource.CreateResourceIdentifier" /> to create an <see cref="EventSubscriptionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventSubscriptionResource"/> object. </returns>
        public virtual EventSubscriptionResource GetEventSubscriptionResource(ResourceIdentifier id)
        {
            EventSubscriptionResource.ValidateResourceId(id);
            return new EventSubscriptionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SystemTopicEventSubscriptionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SystemTopicEventSubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="SystemTopicEventSubscriptionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SystemTopicEventSubscriptionResource"/> object. </returns>
        public virtual SystemTopicEventSubscriptionResource GetSystemTopicEventSubscriptionResource(ResourceIdentifier id)
        {
            SystemTopicEventSubscriptionResource.ValidateResourceId(id);
            return new SystemTopicEventSubscriptionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PartnerTopicEventSubscriptionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PartnerTopicEventSubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="PartnerTopicEventSubscriptionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PartnerTopicEventSubscriptionResource"/> object. </returns>
        public virtual PartnerTopicEventSubscriptionResource GetPartnerTopicEventSubscriptionResource(ResourceIdentifier id)
        {
            PartnerTopicEventSubscriptionResource.ValidateResourceId(id);
            return new PartnerTopicEventSubscriptionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NamespaceTopicEventSubscriptionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NamespaceTopicEventSubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="NamespaceTopicEventSubscriptionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NamespaceTopicEventSubscriptionResource"/> object. </returns>
        public virtual NamespaceTopicEventSubscriptionResource GetNamespaceTopicEventSubscriptionResource(ResourceIdentifier id)
        {
            NamespaceTopicEventSubscriptionResource.ValidateResourceId(id);
            return new NamespaceTopicEventSubscriptionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventGridNamespaceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventGridNamespaceResource.CreateResourceIdentifier" /> to create an <see cref="EventGridNamespaceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventGridNamespaceResource"/> object. </returns>
        public virtual EventGridNamespaceResource GetEventGridNamespaceResource(ResourceIdentifier id)
        {
            EventGridNamespaceResource.ValidateResourceId(id);
            return new EventGridNamespaceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NamespaceTopicResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NamespaceTopicResource.CreateResourceIdentifier" /> to create a <see cref="NamespaceTopicResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NamespaceTopicResource"/> object. </returns>
        public virtual NamespaceTopicResource GetNamespaceTopicResource(ResourceIdentifier id)
        {
            NamespaceTopicResource.ValidateResourceId(id);
            return new NamespaceTopicResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PartnerConfigurationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PartnerConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="PartnerConfigurationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PartnerConfigurationResource"/> object. </returns>
        public virtual PartnerConfigurationResource GetPartnerConfigurationResource(ResourceIdentifier id)
        {
            PartnerConfigurationResource.ValidateResourceId(id);
            return new PartnerConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PartnerDestinationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PartnerDestinationResource.CreateResourceIdentifier" /> to create a <see cref="PartnerDestinationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PartnerDestinationResource"/> object. </returns>
        public virtual PartnerDestinationResource GetPartnerDestinationResource(ResourceIdentifier id)
        {
            PartnerDestinationResource.ValidateResourceId(id);
            return new PartnerDestinationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PartnerNamespaceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PartnerNamespaceResource.CreateResourceIdentifier" /> to create a <see cref="PartnerNamespaceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PartnerNamespaceResource"/> object. </returns>
        public virtual PartnerNamespaceResource GetPartnerNamespaceResource(ResourceIdentifier id)
        {
            PartnerNamespaceResource.ValidateResourceId(id);
            return new PartnerNamespaceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PartnerRegistrationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PartnerRegistrationResource.CreateResourceIdentifier" /> to create a <see cref="PartnerRegistrationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PartnerRegistrationResource"/> object. </returns>
        public virtual PartnerRegistrationResource GetPartnerRegistrationResource(ResourceIdentifier id)
        {
            PartnerRegistrationResource.ValidateResourceId(id);
            return new PartnerRegistrationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PartnerTopicResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PartnerTopicResource.CreateResourceIdentifier" /> to create a <see cref="PartnerTopicResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PartnerTopicResource"/> object. </returns>
        public virtual PartnerTopicResource GetPartnerTopicResource(ResourceIdentifier id)
        {
            PartnerTopicResource.ValidateResourceId(id);
            return new PartnerTopicResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TopicNetworkSecurityPerimeterConfigurationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TopicNetworkSecurityPerimeterConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="TopicNetworkSecurityPerimeterConfigurationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TopicNetworkSecurityPerimeterConfigurationResource"/> object. </returns>
        public virtual TopicNetworkSecurityPerimeterConfigurationResource GetTopicNetworkSecurityPerimeterConfigurationResource(ResourceIdentifier id)
        {
            TopicNetworkSecurityPerimeterConfigurationResource.ValidateResourceId(id);
            return new TopicNetworkSecurityPerimeterConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DomainNetworkSecurityPerimeterConfigurationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DomainNetworkSecurityPerimeterConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="DomainNetworkSecurityPerimeterConfigurationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DomainNetworkSecurityPerimeterConfigurationResource"/> object. </returns>
        public virtual DomainNetworkSecurityPerimeterConfigurationResource GetDomainNetworkSecurityPerimeterConfigurationResource(ResourceIdentifier id)
        {
            DomainNetworkSecurityPerimeterConfigurationResource.ValidateResourceId(id);
            return new DomainNetworkSecurityPerimeterConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventGridNamespacePermissionBindingResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventGridNamespacePermissionBindingResource.CreateResourceIdentifier" /> to create an <see cref="EventGridNamespacePermissionBindingResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventGridNamespacePermissionBindingResource"/> object. </returns>
        public virtual EventGridNamespacePermissionBindingResource GetEventGridNamespacePermissionBindingResource(ResourceIdentifier id)
        {
            EventGridNamespacePermissionBindingResource.ValidateResourceId(id);
            return new EventGridNamespacePermissionBindingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventGridTopicPrivateEndpointConnectionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventGridTopicPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="EventGridTopicPrivateEndpointConnectionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventGridTopicPrivateEndpointConnectionResource"/> object. </returns>
        public virtual EventGridTopicPrivateEndpointConnectionResource GetEventGridTopicPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            EventGridTopicPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new EventGridTopicPrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventGridDomainPrivateEndpointConnectionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventGridDomainPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="EventGridDomainPrivateEndpointConnectionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventGridDomainPrivateEndpointConnectionResource"/> object. </returns>
        public virtual EventGridDomainPrivateEndpointConnectionResource GetEventGridDomainPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            EventGridDomainPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new EventGridDomainPrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventGridPartnerNamespacePrivateEndpointConnectionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventGridPartnerNamespacePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="EventGridPartnerNamespacePrivateEndpointConnectionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventGridPartnerNamespacePrivateEndpointConnectionResource"/> object. </returns>
        public virtual EventGridPartnerNamespacePrivateEndpointConnectionResource GetEventGridPartnerNamespacePrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            EventGridPartnerNamespacePrivateEndpointConnectionResource.ValidateResourceId(id);
            return new EventGridPartnerNamespacePrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventGridTopicPrivateLinkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventGridTopicPrivateLinkResource.CreateResourceIdentifier" /> to create an <see cref="EventGridTopicPrivateLinkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventGridTopicPrivateLinkResource"/> object. </returns>
        public virtual EventGridTopicPrivateLinkResource GetEventGridTopicPrivateLinkResource(ResourceIdentifier id)
        {
            EventGridTopicPrivateLinkResource.ValidateResourceId(id);
            return new EventGridTopicPrivateLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventGridDomainPrivateLinkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventGridDomainPrivateLinkResource.CreateResourceIdentifier" /> to create an <see cref="EventGridDomainPrivateLinkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventGridDomainPrivateLinkResource"/> object. </returns>
        public virtual EventGridDomainPrivateLinkResource GetEventGridDomainPrivateLinkResource(ResourceIdentifier id)
        {
            EventGridDomainPrivateLinkResource.ValidateResourceId(id);
            return new EventGridDomainPrivateLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PartnerNamespacePrivateLinkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PartnerNamespacePrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="PartnerNamespacePrivateLinkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PartnerNamespacePrivateLinkResource"/> object. </returns>
        public virtual PartnerNamespacePrivateLinkResource GetPartnerNamespacePrivateLinkResource(ResourceIdentifier id)
        {
            PartnerNamespacePrivateLinkResource.ValidateResourceId(id);
            return new PartnerNamespacePrivateLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SystemTopicResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SystemTopicResource.CreateResourceIdentifier" /> to create a <see cref="SystemTopicResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SystemTopicResource"/> object. </returns>
        public virtual SystemTopicResource GetSystemTopicResource(ResourceIdentifier id)
        {
            SystemTopicResource.ValidateResourceId(id);
            return new SystemTopicResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventGridTopicResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventGridTopicResource.CreateResourceIdentifier" /> to create an <see cref="EventGridTopicResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EventGridTopicResource"/> object. </returns>
        public virtual EventGridTopicResource GetEventGridTopicResource(ResourceIdentifier id)
        {
            EventGridTopicResource.ValidateResourceId(id);
            return new EventGridTopicResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ExtensionTopicResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ExtensionTopicResource.CreateResourceIdentifier" /> to create an <see cref="ExtensionTopicResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ExtensionTopicResource"/> object. </returns>
        public virtual ExtensionTopicResource GetExtensionTopicResource(ResourceIdentifier id)
        {
            ExtensionTopicResource.ValidateResourceId(id);
            return new ExtensionTopicResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TopicSpaceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TopicSpaceResource.CreateResourceIdentifier" /> to create a <see cref="TopicSpaceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TopicSpaceResource"/> object. </returns>
        public virtual TopicSpaceResource GetTopicSpaceResource(ResourceIdentifier id)
        {
            TopicSpaceResource.ValidateResourceId(id);
            return new TopicSpaceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TopicTypeResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TopicTypeResource.CreateResourceIdentifier" /> to create a <see cref="TopicTypeResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TopicTypeResource"/> object. </returns>
        public virtual TopicTypeResource GetTopicTypeResource(ResourceIdentifier id)
        {
            TopicTypeResource.ValidateResourceId(id);
            return new TopicTypeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VerifiedPartnerResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VerifiedPartnerResource.CreateResourceIdentifier" /> to create a <see cref="VerifiedPartnerResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VerifiedPartnerResource"/> object. </returns>
        public virtual VerifiedPartnerResource GetVerifiedPartnerResource(ResourceIdentifier id)
        {
            VerifiedPartnerResource.ValidateResourceId(id);
            return new VerifiedPartnerResource(Client, id);
        }
    }
}
