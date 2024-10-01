// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// ContainerAppSourceControl.
/// </summary>
public partial class ContainerAppSourceControl : Resource
{
    /// <summary>
    /// Name of the Container App SourceControl.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The branch which will trigger the auto deployment.
    /// </summary>
    public BicepValue<string> Branch { get => _branch; set => _branch.Assign(value); }
    private readonly BicepValue<string> _branch;

    /// <summary>
    /// Container App Revision Template with all possible settings and the
    /// defaults if user did not provide them. The defaults are
    /// populated             as they were at the creation time
    /// </summary>
    public BicepValue<ContainerAppGitHubActionConfiguration> GitHubActionConfiguration { get => _gitHubActionConfiguration; set => _gitHubActionConfiguration.Assign(value); }
    private readonly BicepValue<ContainerAppGitHubActionConfiguration> _gitHubActionConfiguration;

    /// <summary>
    /// The repo url which will be integrated to ContainerApp.
    /// </summary>
    public BicepValue<Uri> RepoUri { get => _repoUri; set => _repoUri.Assign(value); }
    private readonly BicepValue<Uri> _repoUri;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Current provisioning State of the operation.
    /// </summary>
    public BicepValue<ContainerAppSourceControlOperationState> OperationState { get => _operationState; }
    private readonly BicepValue<ContainerAppSourceControlOperationState> _operationState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ContainerApp.
    /// </summary>
    public ContainerApp? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ContainerApp> _parent;

    /// <summary>
    /// Creates a new ContainerAppSourceControl.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerAppSourceControl.</param>
    /// <param name="resourceVersion">Version of the ContainerAppSourceControl.</param>
    public ContainerAppSourceControl(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.App/containerApps/sourcecontrols", resourceVersion ?? "2024-03-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _branch = BicepValue<string>.DefineProperty(this, "Branch", ["properties", "branch"]);
        _gitHubActionConfiguration = BicepValue<ContainerAppGitHubActionConfiguration>.DefineProperty(this, "GitHubActionConfiguration", ["properties", "githubActionConfiguration"]);
        _repoUri = BicepValue<Uri>.DefineProperty(this, "RepoUri", ["properties", "repoUrl"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _operationState = BicepValue<ContainerAppSourceControlOperationState>.DefineProperty(this, "OperationState", ["properties", "operationState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ContainerApp>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ContainerAppSourceControl resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-08-02-preview.
        /// </summary>
        public static readonly string V2024_08_02_preview = "2024-08-02-preview";

        /// <summary>
        /// 2024-03-01.
        /// </summary>
        public static readonly string V2024_03_01 = "2024-03-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2022-10-01.
        /// </summary>
        public static readonly string V2022_10_01 = "2022-10-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";
    }

    /// <summary>
    /// Creates a reference to an existing ContainerAppSourceControl.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerAppSourceControl.</param>
    /// <param name="resourceVersion">Version of the ContainerAppSourceControl.</param>
    /// <returns>The existing ContainerAppSourceControl resource.</returns>
    public static ContainerAppSourceControl FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
