// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// ContainerAppManagedEnvironmentCertificate.
/// </summary>
public partial class ContainerAppManagedEnvironmentCertificate : Resource
{
    /// <summary>
    /// Name of the Certificate.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Certificate resource specific properties.
    /// </summary>
    public BicepValue<ContainerAppCertificateProperties> Properties { get => _properties; set => _properties.Assign(value); }
    private readonly BicepValue<ContainerAppCertificateProperties> _properties;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

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
    /// Gets or sets a reference to the parent ContainerAppManagedEnvironment.
    /// </summary>
    public ContainerAppManagedEnvironment? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ContainerAppManagedEnvironment> _parent;

    /// <summary>
    /// Creates a new ContainerAppManagedEnvironmentCertificate.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerAppManagedEnvironmentCertificate.</param>
    /// <param name="resourceVersion">Version of the ContainerAppManagedEnvironmentCertificate.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public ContainerAppManagedEnvironmentCertificate(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.App/managedEnvironments/certificates", resourceVersion ?? "2023-05-01", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _properties = BicepValue<ContainerAppCertificateProperties>.DefineProperty(this, "Properties", ["properties"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ContainerAppManagedEnvironment>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ContainerAppManagedEnvironmentCertificate resource versions.
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
    /// Creates a reference to an existing
    /// ContainerAppManagedEnvironmentCertificate.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerAppManagedEnvironmentCertificate.</param>
    /// <param name="resourceVersion">Version of the ContainerAppManagedEnvironmentCertificate.</param>
    /// <returns>The existing ContainerAppManagedEnvironmentCertificate resource.</returns>
    public static ContainerAppManagedEnvironmentCertificate FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
