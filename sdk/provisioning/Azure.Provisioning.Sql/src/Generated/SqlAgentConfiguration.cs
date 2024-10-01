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
/// SqlAgentConfiguration.
/// </summary>
public partial class SqlAgentConfiguration : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The state of Sql Agent.
    /// </summary>
    public BicepValue<SqlAgentConfigurationPropertiesState> State { get => _state; set => _state.Assign(value); }
    private readonly BicepValue<SqlAgentConfigurationPropertiesState> _state;

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
    /// Gets or sets a reference to the parent ManagedInstance.
    /// </summary>
    public ManagedInstance? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ManagedInstance> _parent;

    /// <summary>
    /// Creates a new SqlAgentConfiguration.
    /// </summary>
    /// <param name="resourceName">Name of the SqlAgentConfiguration.</param>
    /// <param name="resourceVersion">Version of the SqlAgentConfiguration.</param>
    public SqlAgentConfiguration(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.Sql/managedInstances/sqlAgent", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _state = BicepValue<SqlAgentConfigurationPropertiesState>.DefineProperty(this, "State", ["properties", "state"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ManagedInstance>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SqlAgentConfiguration resource versions.
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

        /// <summary>
        /// 2018-06-01.
        /// </summary>
        public static readonly string V2018_06_01 = "2018-06-01";
    }

    /// <summary>
    /// Creates a reference to an existing SqlAgentConfiguration.
    /// </summary>
    /// <param name="resourceName">Name of the SqlAgentConfiguration.</param>
    /// <param name="resourceVersion">Version of the SqlAgentConfiguration.</param>
    /// <returns>The existing SqlAgentConfiguration resource.</returns>
    public static SqlAgentConfiguration FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
