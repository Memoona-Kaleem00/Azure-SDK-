// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// EventHubsDisasterRecovery.
/// </summary>
public partial class EventHubsDisasterRecovery : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Alternate name specified when alias and namespace names are same.
    /// </summary>
    public BicepValue<string> AlternateName { get => _alternateName; set => _alternateName.Assign(value); }
    private readonly BicepValue<string> _alternateName;

    /// <summary>
    /// ARM Id of the Primary/Secondary eventhub namespace name, which is part
    /// of GEO DR pairing.
    /// </summary>
    public BicepValue<string> PartnerNamespace { get => _partnerNamespace; set => _partnerNamespace.Assign(value); }
    private readonly BicepValue<string> _partnerNamespace;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The geo-location where the resource lives.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Number of entities pending to be replicated.
    /// </summary>
    public BicepValue<long> PendingReplicationOperationsCount { get => _pendingReplicationOperationsCount; }
    private readonly BicepValue<long> _pendingReplicationOperationsCount;

    /// <summary>
    /// Provisioning state of the Alias(Disaster Recovery configuration) -
    /// possible values &apos;Accepted&apos; or &apos;Succeeded&apos; or
    /// &apos;Failed&apos;.
    /// </summary>
    public BicepValue<EventHubsDisasterRecoveryProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<EventHubsDisasterRecoveryProvisioningState> _provisioningState;

    /// <summary>
    /// role of namespace in GEO DR - possible values &apos;Primary&apos; or
    /// &apos;PrimaryNotReplicating&apos; or &apos;Secondary&apos;.
    /// </summary>
    public BicepValue<EventHubsDisasterRecoveryRole> Role { get => _role; }
    private readonly BicepValue<EventHubsDisasterRecoveryRole> _role;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent EventHubsNamespace.
    /// </summary>
    public EventHubsNamespace? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<EventHubsNamespace> _parent;

    /// <summary>
    /// Creates a new EventHubsDisasterRecovery.
    /// </summary>
    /// <param name="resourceName">Name of the EventHubsDisasterRecovery.</param>
    /// <param name="resourceVersion">Version of the EventHubsDisasterRecovery.</param>
    public EventHubsDisasterRecovery(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.EventHub/namespaces/disasterRecoveryConfigs", resourceVersion ?? "2024-01-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _alternateName = BicepValue<string>.DefineProperty(this, "AlternateName", ["properties", "alternateName"]);
        _partnerNamespace = BicepValue<string>.DefineProperty(this, "PartnerNamespace", ["properties", "partnerNamespace"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isOutput: true);
        _pendingReplicationOperationsCount = BicepValue<long>.DefineProperty(this, "PendingReplicationOperationsCount", ["properties", "pendingReplicationOperationsCount"], isOutput: true);
        _provisioningState = BicepValue<EventHubsDisasterRecoveryProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _role = BicepValue<EventHubsDisasterRecoveryRole>.DefineProperty(this, "Role", ["properties", "role"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<EventHubsNamespace>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported EventHubsDisasterRecovery resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01-preview.
        /// </summary>
        public static readonly string V2024_05_01_preview = "2024-05-01-preview";

        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";

        /// <summary>
        /// 2017-04-01.
        /// </summary>
        public static readonly string V2017_04_01 = "2017-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing EventHubsDisasterRecovery.
    /// </summary>
    /// <param name="resourceName">Name of the EventHubsDisasterRecovery.</param>
    /// <param name="resourceVersion">Version of the EventHubsDisasterRecovery.</param>
    /// <returns>The existing EventHubsDisasterRecovery resource.</returns>
    public static EventHubsDisasterRecovery FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this EventHubsDisasterRecovery resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 6, maxLength: 50, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);
}
