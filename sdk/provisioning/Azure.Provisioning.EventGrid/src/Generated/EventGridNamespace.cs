// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// EventGridNamespace.
/// </summary>
public partial class EventGridNamespace : Resource
{
    /// <summary>
    /// Name of the namespace.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Identity information for the Namespace resource.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// This can be used to restrict traffic from specific IPs instead of all
    /// IPs. Note: These are considered only if PublicNetworkAccess is enabled.
    /// </summary>
    public BicepList<EventGridInboundIPRule> InboundIPRules { get => _inboundIPRules; set => _inboundIPRules.Assign(value); }
    private readonly BicepList<EventGridInboundIPRule> _inboundIPRules;

    /// <summary>
    /// This is an optional property and it allows the user to specify if the
    /// namespace resource supports zone-redundancy capability or not. If this
    /// property is not specified explicitly by the user, its
    /// default value depends on the following conditions:                 a.
    /// For Availability Zones enabled regions - The default property value
    /// would be true.                 b. For non-Availability Zones enabled
    /// regions - The default property value would be false.             Once
    /// specified, this property cannot be updated.
    /// </summary>
    public BicepValue<bool> IsZoneRedundant { get => _isZoneRedundant; set => _isZoneRedundant.Assign(value); }
    private readonly BicepValue<bool> _isZoneRedundant;

    /// <summary>
    /// Minimum TLS version of the publisher allowed to publish to this
    /// namespace. Only TLS version 1.2 is supported.
    /// </summary>
    public BicepValue<TlsVersion> MinimumTlsVersionAllowed { get => _minimumTlsVersionAllowed; set => _minimumTlsVersionAllowed.Assign(value); }
    private readonly BicepValue<TlsVersion> _minimumTlsVersionAllowed;

    /// <summary>
    /// List of private endpoint connections.
    /// </summary>
    public BicepList<EventGridPrivateEndpointConnectionData> PrivateEndpointConnections { get => _privateEndpointConnections; set => _privateEndpointConnections.Assign(value); }
    private readonly BicepList<EventGridPrivateEndpointConnectionData> _privateEndpointConnections;

    /// <summary>
    /// This determines if traffic is allowed over public network. By default
    /// it is enabled.             You can further restrict to specific IPs by
    /// configuring &lt;seealso
    /// cref=&quot;P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.PubSub.NamespaceProperties.InboundIpRules&quot;
    /// /&gt;
    /// </summary>
    public BicepValue<EventGridPublicNetworkAccess> PublicNetworkAccess { get => _publicNetworkAccess; set => _publicNetworkAccess.Assign(value); }
    private readonly BicepValue<EventGridPublicNetworkAccess> _publicNetworkAccess;

    /// <summary>
    /// Represents available Sku pricing tiers.
    /// </summary>
    public BicepValue<NamespaceSku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<NamespaceSku> _sku;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Topics configuration information for the namespace resource.
    /// </summary>
    public BicepValue<TopicsConfiguration> TopicsConfiguration { get => _topicsConfiguration; set => _topicsConfiguration.Assign(value); }
    private readonly BicepValue<TopicsConfiguration> _topicsConfiguration;

    /// <summary>
    /// Topic spaces configuration information for the namespace resource.
    /// </summary>
    public BicepValue<TopicSpacesConfiguration> TopicSpacesConfiguration { get => _topicSpacesConfiguration; set => _topicSpacesConfiguration.Assign(value); }
    private readonly BicepValue<TopicSpacesConfiguration> _topicSpacesConfiguration;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Provisioning state of the namespace resource.
    /// </summary>
    public BicepValue<NamespaceProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<NamespaceProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new EventGridNamespace.
    /// </summary>
    /// <param name="resourceName">Name of the EventGridNamespace.</param>
    /// <param name="resourceVersion">Version of the EventGridNamespace.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public EventGridNamespace(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.EventGrid/namespaces", resourceVersion ?? "2024-06-01-preview", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _inboundIPRules = BicepList<EventGridInboundIPRule>.DefineProperty(this, "InboundIPRules", ["properties", "inboundIpRules"]);
        _isZoneRedundant = BicepValue<bool>.DefineProperty(this, "IsZoneRedundant", ["properties", "isZoneRedundant"]);
        _minimumTlsVersionAllowed = BicepValue<TlsVersion>.DefineProperty(this, "MinimumTlsVersionAllowed", ["properties", "minimumTlsVersionAllowed"]);
        _privateEndpointConnections = BicepList<EventGridPrivateEndpointConnectionData>.DefineProperty(this, "PrivateEndpointConnections", ["properties", "privateEndpointConnections"]);
        _publicNetworkAccess = BicepValue<EventGridPublicNetworkAccess>.DefineProperty(this, "PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _sku = BicepValue<NamespaceSku>.DefineProperty(this, "Sku", ["sku"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _topicsConfiguration = BicepValue<TopicsConfiguration>.DefineProperty(this, "TopicsConfiguration", ["properties", "topicsConfiguration"]);
        _topicSpacesConfiguration = BicepValue<TopicSpacesConfiguration>.DefineProperty(this, "TopicSpacesConfiguration", ["properties", "topicSpacesConfiguration"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<NamespaceProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported EventGridNamespace resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-06-01-preview.
        /// </summary>
        public static readonly string V2024_06_01_preview = "2024-06-01-preview";
    }

    /// <summary>
    /// Creates a reference to an existing EventGridNamespace.
    /// </summary>
    /// <param name="resourceName">Name of the EventGridNamespace.</param>
    /// <param name="resourceVersion">Version of the EventGridNamespace.</param>
    /// <returns>The existing EventGridNamespace resource.</returns>
    public static EventGridNamespace FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
