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
/// ContainerAppManagedEnvironmentStorage.
/// </summary>
public partial class ContainerAppManagedEnvironmentStorage : Resource
{
    /// <summary>
    /// Name of the storage.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Azure file properties.
    /// </summary>
    public BicepValue<ContainerAppAzureFileProperties> ManagedEnvironmentStorageAzureFile { get => _managedEnvironmentStorageAzureFile; set => _managedEnvironmentStorageAzureFile.Assign(value); }
    private readonly BicepValue<ContainerAppAzureFileProperties> _managedEnvironmentStorageAzureFile;

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
    /// Creates a new ContainerAppManagedEnvironmentStorage.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerAppManagedEnvironmentStorage.</param>
    /// <param name="resourceVersion">Version of the ContainerAppManagedEnvironmentStorage.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public ContainerAppManagedEnvironmentStorage(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.App/managedEnvironments/storages", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _managedEnvironmentStorageAzureFile = BicepValue<ContainerAppAzureFileProperties>.DefineProperty(this, "ManagedEnvironmentStorageAzureFile", ["properties", "azureFile"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ContainerAppManagedEnvironment>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing
    /// ContainerAppManagedEnvironmentStorage.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerAppManagedEnvironmentStorage.</param>
    /// <param name="resourceVersion">Version of the ContainerAppManagedEnvironmentStorage.</param>
    /// <returns>The existing ContainerAppManagedEnvironmentStorage resource.</returns>
    public static ContainerAppManagedEnvironmentStorage FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
