// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlPrivateEndpointConnection.
/// </summary>
public partial class SqlPrivateEndpointConnection : Resource
{
    /// <summary>
    /// The System.String to use.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Connection state of the private endpoint connection.
    /// </summary>
    public BicepValue<SqlPrivateLinkServiceConnectionStateProperty> ConnectionState { get => _connectionState; set => _connectionState.Assign(value); }
    private readonly BicepValue<SqlPrivateLinkServiceConnectionStateProperty> _connectionState;

    /// <summary>
    /// Gets or sets Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateEndpointId { get => _privateEndpointId; set => _privateEndpointId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _privateEndpointId;

    /// <summary>
    /// Group IDs.
    /// </summary>
    public BicepList<string> GroupIds { get => _groupIds; }
    private readonly BicepList<string> _groupIds;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// State of the private endpoint connection.
    /// </summary>
    public BicepValue<SqlPrivateEndpointProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<SqlPrivateEndpointProvisioningState> _provisioningState;

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
    /// Creates a new SqlPrivateEndpointConnection.
    /// </summary>
    /// <param name="resourceName">Name of the SqlPrivateEndpointConnection.</param>
    /// <param name="resourceVersion">Version of the SqlPrivateEndpointConnection.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public SqlPrivateEndpointConnection(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Sql/servers/privateEndpointConnections", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _connectionState = BicepValue<SqlPrivateLinkServiceConnectionStateProperty>.DefineProperty(this, "ConnectionState", ["properties", "privateLinkServiceConnectionState"]);
        _privateEndpointId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrivateEndpointId", ["properties", "privateEndpoint", "id"]);
        _groupIds = BicepList<string>.DefineProperty(this, "GroupIds", ["properties", "groupIds"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<SqlPrivateEndpointProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SqlServer>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing SqlPrivateEndpointConnection.
    /// </summary>
    /// <param name="resourceName">Name of the SqlPrivateEndpointConnection.</param>
    /// <param name="resourceVersion">Version of the SqlPrivateEndpointConnection.</param>
    /// <returns>The existing SqlPrivateEndpointConnection resource.</returns>
    public static SqlPrivateEndpointConnection FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
