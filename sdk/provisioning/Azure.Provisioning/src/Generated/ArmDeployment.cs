// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.ResourceManager.Resources.Models;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Resources;

/// <summary>
/// ArmDeployment.
/// </summary>
public partial class ArmDeployment : Resource
{
    /// <summary>
    /// The name of the deployment.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// the location of the deployment.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Deployment properties.
    /// </summary>
    public BicepValue<ArmDeploymentPropertiesExtended> Properties { get => _properties; }
    private readonly BicepValue<ArmDeploymentPropertiesExtended> _properties;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Deployment tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Creates a new ArmDeployment.
    /// </summary>
    /// <param name="resourceName">Name of the ArmDeployment.</param>
    /// <param name="resourceVersion">Version of the ArmDeployment.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public ArmDeployment(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Resources/deployments", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isOutput: true);
        _properties = BicepValue<ArmDeploymentPropertiesExtended>.DefineProperty(this, "Properties", ["properties"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"], isOutput: true);
    }

    /// <summary>
    /// Creates a reference to an existing ArmDeployment.
    /// </summary>
    /// <param name="resourceName">Name of the ArmDeployment.</param>
    /// <param name="resourceVersion">Version of the ArmDeployment.</param>
    /// <returns>The existing ArmDeployment resource.</returns>
    public static ArmDeployment FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Creates a new ArmDeployment resource from a Bicep expression that
    /// evaluates to a ArmDeployment.
    /// </summary>
    /// <param name="expression">
    /// A Bicep expression that evaluates to a ArmDeployment resource.
    /// </param>
    /// <returns>A ArmDeployment resource.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static ArmDeployment FromExpression(Expression expression)
    {
        ArmDeployment resource = new(expression.ToString());
        resource.OverrideWithExpression(expression);
        return resource;
    }

    /// <summary>
    /// Get the requirements for naming this ArmDeployment resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 64, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period | ResourceNameCharacters.Parentheses);
}
