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
/// GremlinGraph.
/// </summary>
public partial class GremlinGraph : Resource
{
    /// <summary>
    /// Cosmos DB graph name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The standard JSON format of a Gremlin graph.
    /// </summary>
    public BicepValue<GremlinGraphResourceInfo> Resource { get => _resource; set => _resource.Assign(value); }
    private readonly BicepValue<GremlinGraphResourceInfo> _resource;

    /// <summary>
    /// Identity for the resource.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// A key-value pair of options to be applied for the request. This
    /// corresponds to the headers sent with the request.
    /// </summary>
    public BicepValue<CosmosDBCreateUpdateConfig> Options { get => _options; set => _options.Assign(value); }
    private readonly BicepValue<CosmosDBCreateUpdateConfig> _options;

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
    /// Gets or sets a reference to the parent GremlinDatabase.
    /// </summary>
    public GremlinDatabase? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<GremlinDatabase> _parent;

    /// <summary>
    /// Creates a new GremlinGraph.
    /// </summary>
    /// <param name="resourceName">Name of the GremlinGraph.</param>
    /// <param name="resourceVersion">Version of the GremlinGraph.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public GremlinGraph(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.DocumentDB/databaseAccounts/gremlinDatabases/graphs", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _resource = BicepValue<GremlinGraphResourceInfo>.DefineProperty(this, "Resource", ["properties", "resource"], isRequired: true);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _options = BicepValue<CosmosDBCreateUpdateConfig>.DefineProperty(this, "Options", ["properties", "options"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<GremlinDatabase>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing GremlinGraph.
    /// </summary>
    /// <param name="resourceName">Name of the GremlinGraph.</param>
    /// <param name="resourceVersion">Version of the GremlinGraph.</param>
    /// <returns>The existing GremlinGraph resource.</returns>
    public static GremlinGraph FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
