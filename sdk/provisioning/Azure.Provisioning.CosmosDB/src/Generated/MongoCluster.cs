// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// MongoCluster.
/// </summary>
public partial class MongoCluster : Resource
{
    /// <summary>
    /// The name of the mongo cluster.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The administrator&apos;s login for the mongo cluster.
    /// </summary>
    public BicepValue<string> AdministratorLogin { get => _administratorLogin; set => _administratorLogin.Assign(value); }
    private readonly BicepValue<string> _administratorLogin;

    /// <summary>
    /// The password of the administrator login.
    /// </summary>
    public BicepValue<string> AdministratorLoginPassword { get => _administratorLoginPassword; set => _administratorLoginPassword.Assign(value); }
    private readonly BicepValue<string> _administratorLoginPassword;

    /// <summary>
    /// The mode to create a mongo cluster.
    /// </summary>
    public BicepValue<CosmosDBAccountCreateMode> CreateMode { get => _createMode; set => _createMode.Assign(value); }
    private readonly BicepValue<CosmosDBAccountCreateMode> _createMode;

    /// <summary>
    /// The list of node group specs in the cluster.
    /// </summary>
    public BicepList<NodeGroupSpec> NodeGroupSpecs { get => _nodeGroupSpecs; set => _nodeGroupSpecs.Assign(value); }
    private readonly BicepList<NodeGroupSpec> _nodeGroupSpecs;

    /// <summary>
    /// Parameters used for restore operations.
    /// </summary>
    public BicepValue<MongoClusterRestoreParameters> RestoreParameters { get => _restoreParameters; set => _restoreParameters.Assign(value); }
    private readonly BicepValue<MongoClusterRestoreParameters> _restoreParameters;

    /// <summary>
    /// The Mongo DB server version. Defaults to the latest available version
    /// if not specified.
    /// </summary>
    public BicepValue<string> ServerVersion { get => _serverVersion; set => _serverVersion.Assign(value); }
    private readonly BicepValue<string> _serverVersion;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// A status of the mongo cluster.
    /// </summary>
    public BicepValue<MongoClusterStatus> ClusterStatus { get => _clusterStatus; }
    private readonly BicepValue<MongoClusterStatus> _clusterStatus;

    /// <summary>
    /// The default mongo connection string for the cluster.
    /// </summary>
    public BicepValue<string> ConnectionString { get => _connectionString; }
    private readonly BicepValue<string> _connectionString;

    /// <summary>
    /// Earliest restore timestamp in UTC ISO8601 format.
    /// </summary>
    public BicepValue<string> EarliestRestoreTime { get => _earliestRestoreTime; }
    private readonly BicepValue<string> _earliestRestoreTime;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// A provisioning state of the mongo cluster.
    /// </summary>
    public BicepValue<CosmosDBProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<CosmosDBProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new MongoCluster.
    /// </summary>
    /// <param name="resourceName">Name of the MongoCluster.</param>
    /// <param name="resourceVersion">Version of the MongoCluster.</param>
    public MongoCluster(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.DocumentDB/mongoClusters", resourceVersion ?? "2024-07-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _administratorLogin = BicepValue<string>.DefineProperty(this, "AdministratorLogin", ["properties", "administratorLogin"]);
        _administratorLoginPassword = BicepValue<string>.DefineProperty(this, "AdministratorLoginPassword", ["properties", "administratorLoginPassword"]);
        _createMode = BicepValue<CosmosDBAccountCreateMode>.DefineProperty(this, "CreateMode", ["properties", "createMode"]);
        _nodeGroupSpecs = BicepList<NodeGroupSpec>.DefineProperty(this, "NodeGroupSpecs", ["properties", "nodeGroupSpecs"]);
        _restoreParameters = BicepValue<MongoClusterRestoreParameters>.DefineProperty(this, "RestoreParameters", ["properties", "restoreParameters"]);
        _serverVersion = BicepValue<string>.DefineProperty(this, "ServerVersion", ["properties", "serverVersion"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _clusterStatus = BicepValue<MongoClusterStatus>.DefineProperty(this, "ClusterStatus", ["properties", "clusterStatus"], isOutput: true);
        _connectionString = BicepValue<string>.DefineProperty(this, "ConnectionString", ["properties", "connectionString"], isOutput: true);
        _earliestRestoreTime = BicepValue<string>.DefineProperty(this, "EarliestRestoreTime", ["properties", "earliestRestoreTime"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<CosmosDBProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported MongoCluster resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-07-01.
        /// </summary>
        public static readonly string V2024_07_01 = "2024-07-01";
    }

    /// <summary>
    /// Creates a reference to an existing MongoCluster.
    /// </summary>
    /// <param name="resourceName">Name of the MongoCluster.</param>
    /// <param name="resourceVersion">Version of the MongoCluster.</param>
    /// <returns>The existing MongoCluster resource.</returns>
    public static MongoCluster FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
