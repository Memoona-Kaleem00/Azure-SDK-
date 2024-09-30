// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// DistributedAvailabilityGroup.
/// </summary>
public partial class DistributedAvailabilityGroup : Resource
{
    /// <summary>
    /// The distributed availability group name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The primary availability group name.
    /// </summary>
    public BicepValue<string> PrimaryAvailabilityGroupName { get => _primaryAvailabilityGroupName; set => _primaryAvailabilityGroupName.Assign(value); }
    private readonly BicepValue<string> _primaryAvailabilityGroupName;

    /// <summary>
    /// The replication mode of a distributed availability group. Parameter
    /// will be ignored during link creation.
    /// </summary>
    public BicepValue<DistributedAvailabilityGroupReplicationMode> ReplicationMode { get => _replicationMode; set => _replicationMode.Assign(value); }
    private readonly BicepValue<DistributedAvailabilityGroupReplicationMode> _replicationMode;

    /// <summary>
    /// The secondary availability group name.
    /// </summary>
    public BicepValue<string> SecondaryAvailabilityGroupName { get => _secondaryAvailabilityGroupName; set => _secondaryAvailabilityGroupName.Assign(value); }
    private readonly BicepValue<string> _secondaryAvailabilityGroupName;

    /// <summary>
    /// The source endpoint.
    /// </summary>
    public BicepValue<string> SourceEndpoint { get => _sourceEndpoint; set => _sourceEndpoint.Assign(value); }
    private readonly BicepValue<string> _sourceEndpoint;

    /// <summary>
    /// The name of the target database.
    /// </summary>
    public BicepValue<string> TargetDatabase { get => _targetDatabase; set => _targetDatabase.Assign(value); }
    private readonly BicepValue<string> _targetDatabase;

    /// <summary>
    /// The distributed availability group id.
    /// </summary>
    public BicepValue<Guid> DistributedAvailabilityGroupId { get => _distributedAvailabilityGroupId; }
    private readonly BicepValue<Guid> _distributedAvailabilityGroupId;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The last hardened lsn.
    /// </summary>
    public BicepValue<string> LastHardenedLsn { get => _lastHardenedLsn; }
    private readonly BicepValue<string> _lastHardenedLsn;

    /// <summary>
    /// The link state.
    /// </summary>
    public BicepValue<string> LinkState { get => _linkState; }
    private readonly BicepValue<string> _linkState;

    /// <summary>
    /// The source replica id.
    /// </summary>
    public BicepValue<Guid> SourceReplicaId { get => _sourceReplicaId; }
    private readonly BicepValue<Guid> _sourceReplicaId;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// The target replica id.
    /// </summary>
    public BicepValue<Guid> TargetReplicaId { get => _targetReplicaId; }
    private readonly BicepValue<Guid> _targetReplicaId;

    /// <summary>
    /// Gets or sets a reference to the parent ManagedInstance.
    /// </summary>
    public ManagedInstance? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ManagedInstance> _parent;

    /// <summary>
    /// Creates a new DistributedAvailabilityGroup.
    /// </summary>
    /// <param name="resourceName">Name of the DistributedAvailabilityGroup.</param>
    /// <param name="resourceVersion">Version of the DistributedAvailabilityGroup.</param>
    public DistributedAvailabilityGroup(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.Sql/managedInstances/distributedAvailabilityGroups", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _primaryAvailabilityGroupName = BicepValue<string>.DefineProperty(this, "PrimaryAvailabilityGroupName", ["properties", "primaryAvailabilityGroupName"]);
        _replicationMode = BicepValue<DistributedAvailabilityGroupReplicationMode>.DefineProperty(this, "ReplicationMode", ["properties", "replicationMode"]);
        _secondaryAvailabilityGroupName = BicepValue<string>.DefineProperty(this, "SecondaryAvailabilityGroupName", ["properties", "secondaryAvailabilityGroupName"]);
        _sourceEndpoint = BicepValue<string>.DefineProperty(this, "SourceEndpoint", ["properties", "sourceEndpoint"]);
        _targetDatabase = BicepValue<string>.DefineProperty(this, "TargetDatabase", ["properties", "targetDatabase"]);
        _distributedAvailabilityGroupId = BicepValue<Guid>.DefineProperty(this, "DistributedAvailabilityGroupId", ["properties", "distributedAvailabilityGroupId"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _lastHardenedLsn = BicepValue<string>.DefineProperty(this, "LastHardenedLsn", ["properties", "lastHardenedLsn"], isOutput: true);
        _linkState = BicepValue<string>.DefineProperty(this, "LinkState", ["properties", "linkState"], isOutput: true);
        _sourceReplicaId = BicepValue<Guid>.DefineProperty(this, "SourceReplicaId", ["properties", "sourceReplicaId"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _targetReplicaId = BicepValue<Guid>.DefineProperty(this, "TargetReplicaId", ["properties", "targetReplicaId"], isOutput: true);
        _parent = ResourceReference<ManagedInstance>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported DistributedAvailabilityGroup resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01-preview.
        /// </summary>
        public static readonly string V2024_05_01_preview = "2024-05-01-preview";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing DistributedAvailabilityGroup.
    /// </summary>
    /// <param name="resourceName">Name of the DistributedAvailabilityGroup.</param>
    /// <param name="resourceVersion">Version of the DistributedAvailabilityGroup.</param>
    /// <returns>The existing DistributedAvailabilityGroup resource.</returns>
    public static DistributedAvailabilityGroup FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
