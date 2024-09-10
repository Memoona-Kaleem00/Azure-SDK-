// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Authorization;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Roles;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// CognitiveServicesAccount.
/// </summary>
public partial class CognitiveServicesAccount : Resource
{
    /// <summary>
    /// The name of Cognitive Services account.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Identity for the resource.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// The Kind of the resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// Properties of Cognitive Services account.
    /// </summary>
    public BicepValue<CognitiveServicesAccountProperties> Properties { get => _properties; set => _properties.Assign(value); }
    private readonly BicepValue<CognitiveServicesAccountProperties> _properties;

    /// <summary>
    /// The resource model definition representing SKU.
    /// </summary>
    public BicepValue<CognitiveServicesSku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<CognitiveServicesSku> _sku;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Resource Etag.
    /// </summary>
    public BicepValue<ETag> ETag { get => _eTag; }
    private readonly BicepValue<ETag> _eTag;

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
    /// Creates a new CognitiveServicesAccount.
    /// </summary>
    /// <param name="resourceName">Name of the CognitiveServicesAccount.</param>
    /// <param name="resourceVersion">Version of the CognitiveServicesAccount.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public CognitiveServicesAccount(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.CognitiveServices/accounts", resourceVersion ?? "2022-12-01", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _properties = BicepValue<CognitiveServicesAccountProperties>.DefineProperty(this, "Properties", ["properties"]);
        _sku = BicepValue<CognitiveServicesSku>.DefineProperty(this, "Sku", ["sku"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _eTag = BicepValue<ETag>.DefineProperty(this, "ETag", ["etag"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported CognitiveServicesAccount resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-06-01-preview.
        /// </summary>
        public static readonly string V2024_06_01_preview = "2024-06-01-preview";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2022-12-01.
        /// </summary>
        public static readonly string V2022_12_01 = "2022-12-01";

        /// <summary>
        /// 2022-10-01.
        /// </summary>
        public static readonly string V2022_10_01 = "2022-10-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2021-10-01.
        /// </summary>
        public static readonly string V2021_10_01 = "2021-10-01";

        /// <summary>
        /// 2021-04-30.
        /// </summary>
        public static readonly string V2021_04_30 = "2021-04-30";

        /// <summary>
        /// 2017-04-18.
        /// </summary>
        public static readonly string V2017_04_18 = "2017-04-18";
    }

    /// <summary>
    /// Creates a reference to an existing CognitiveServicesAccount.
    /// </summary>
    /// <param name="resourceName">Name of the CognitiveServicesAccount.</param>
    /// <param name="resourceVersion">Version of the CognitiveServicesAccount.</param>
    /// <returns>The existing CognitiveServicesAccount resource.</returns>
    public static CognitiveServicesAccount FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this CognitiveServicesAccount resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 2, maxLength: 64, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);

    /// <summary>
    /// Get access keys for this CognitiveServicesAccount resource.
    /// </summary>
    /// <returns>The keys for this CognitiveServicesAccount resource.</returns>
    public ServiceAccountApiKeys GetKeys() =>
        ServiceAccountApiKeys.FromExpression(
            new FunctionCallExpression(new MemberExpression(new IdentifierExpression(ResourceName), "listKeys")));

    /// <summary>
    /// Assign a role to a user-assigned identity that grants access to this
    /// CognitiveServicesAccount.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment AssignRole(CognitiveServicesBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{identity.ResourceName}_{CognitiveServicesBuiltInRole.GetBuiltInRoleName(role)}_{ResourceName}")
        {
            Scope = new IdentifierExpression(ResourceName),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };
}
