// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// StaticSiteBuildDatabaseConnection.
/// </summary>
public partial class StaticSiteBuildDatabaseConnection : Resource
{
    /// <summary>
    /// Name of the database connection.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// If present, the identity is used in conjunction with connection string
    /// to connect to the database. Use of the system-assigned managed
    /// identity is indicated with the string &apos;SystemAssigned&apos;,
    /// while use of a user-assigned managed identity is indicated with the
    /// resource id of the managed identity resource.
    /// </summary>
    public BicepValue<string> ConnectionIdentity { get => _connectionIdentity; set => _connectionIdentity.Assign(value); }
    private readonly BicepValue<string> _connectionIdentity;

    /// <summary>
    /// The connection string to use to connect to the database.
    /// </summary>
    public BicepValue<string> ConnectionString { get => _connectionString; set => _connectionString.Assign(value); }
    private readonly BicepValue<string> _connectionString;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// The region of the database resource.
    /// </summary>
    public BicepValue<string> Region { get => _region; set => _region.Assign(value); }
    private readonly BicepValue<string> _region;

    /// <summary>
    /// The resource id of the database.
    /// </summary>
    public BicepValue<ResourceIdentifier> ResourceId { get => _resourceId; set => _resourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _resourceId;

    /// <summary>
    /// A list of configuration files associated with this database connection.
    /// </summary>
    public BicepList<StaticSiteDatabaseConnectionConfigurationFileOverview> ConfigurationFiles { get => _configurationFiles; }
    private readonly BicepList<StaticSiteDatabaseConnectionConfigurationFileOverview> _configurationFiles;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new StaticSiteBuildDatabaseConnection.
    /// </summary>
    /// <param name="resourceName">Name of the StaticSiteBuildDatabaseConnection.</param>
    /// <param name="resourceVersion">Version of the StaticSiteBuildDatabaseConnection.</param>
    public StaticSiteBuildDatabaseConnection(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.Web/staticSites/builds/databaseConnections", resourceVersion ?? "2024-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _connectionIdentity = BicepValue<string>.DefineProperty(this, "ConnectionIdentity", ["properties", "connectionIdentity"]);
        _connectionString = BicepValue<string>.DefineProperty(this, "ConnectionString", ["properties", "connectionString"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _region = BicepValue<string>.DefineProperty(this, "Region", ["properties", "region"]);
        _resourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "ResourceId", ["properties", "resourceId"]);
        _configurationFiles = BicepList<StaticSiteDatabaseConnectionConfigurationFileOverview>.DefineProperty(this, "ConfigurationFiles", ["properties", "configurationFiles"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported StaticSiteBuildDatabaseConnection resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01.
        /// </summary>
        public static readonly string V2024_04_01 = "2024-04-01";

        /// <summary>
        /// 2023-12-01.
        /// </summary>
        public static readonly string V2023_12_01 = "2023-12-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";
    }

    /// <summary>
    /// Creates a reference to an existing StaticSiteBuildDatabaseConnection.
    /// </summary>
    /// <param name="resourceName">Name of the StaticSiteBuildDatabaseConnection.</param>
    /// <param name="resourceVersion">Version of the StaticSiteBuildDatabaseConnection.</param>
    /// <returns>The existing StaticSiteBuildDatabaseConnection resource.</returns>
    public static StaticSiteBuildDatabaseConnection FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
