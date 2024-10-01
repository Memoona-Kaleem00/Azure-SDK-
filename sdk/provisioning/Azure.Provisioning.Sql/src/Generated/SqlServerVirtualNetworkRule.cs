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
/// SqlServerVirtualNetworkRule.
/// </summary>
public partial class SqlServerVirtualNetworkRule : Resource
{
    /// <summary>
    /// The name of the virtual network rule.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Create firewall rule before the virtual network has vnet service
    /// endpoint enabled.
    /// </summary>
    public BicepValue<bool> IgnoreMissingVnetServiceEndpoint { get => _ignoreMissingVnetServiceEndpoint; set => _ignoreMissingVnetServiceEndpoint.Assign(value); }
    private readonly BicepValue<bool> _ignoreMissingVnetServiceEndpoint;

    /// <summary>
    /// The ARM resource id of the virtual network subnet.
    /// </summary>
    public BicepValue<ResourceIdentifier> VirtualNetworkSubnetId { get => _virtualNetworkSubnetId; set => _virtualNetworkSubnetId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _virtualNetworkSubnetId;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Virtual Network Rule State.
    /// </summary>
    public BicepValue<SqlServerVirtualNetworkRuleState> State { get => _state; }
    private readonly BicepValue<SqlServerVirtualNetworkRuleState> _state;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SqlServer.
    /// </summary>
    public SqlServer? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SqlServer> _parent;

    /// <summary>
    /// Creates a new SqlServerVirtualNetworkRule.
    /// </summary>
    /// <param name="resourceName">Name of the SqlServerVirtualNetworkRule.</param>
    /// <param name="resourceVersion">Version of the SqlServerVirtualNetworkRule.</param>
    public SqlServerVirtualNetworkRule(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.Sql/servers/virtualNetworkRules", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _ignoreMissingVnetServiceEndpoint = BicepValue<bool>.DefineProperty(this, "IgnoreMissingVnetServiceEndpoint", ["properties", "ignoreMissingVnetServiceEndpoint"]);
        _virtualNetworkSubnetId = BicepValue<ResourceIdentifier>.DefineProperty(this, "VirtualNetworkSubnetId", ["properties", "virtualNetworkSubnetId"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _state = BicepValue<SqlServerVirtualNetworkRuleState>.DefineProperty(this, "State", ["properties", "state"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SqlServer>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SqlServerVirtualNetworkRule resource versions.
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
    /// Creates a reference to an existing SqlServerVirtualNetworkRule.
    /// </summary>
    /// <param name="resourceName">Name of the SqlServerVirtualNetworkRule.</param>
    /// <param name="resourceVersion">Version of the SqlServerVirtualNetworkRule.</param>
    /// <returns>The existing SqlServerVirtualNetworkRule resource.</returns>
    public static SqlServerVirtualNetworkRule FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
