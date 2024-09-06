// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Authorization;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Roles;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.AppConfiguration;

/// <summary>
/// AppConfigurationStore.
/// </summary>
public partial class AppConfigurationStore : Resource
{
    /// <summary>
    /// The name of the configuration store.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Indicates whether the configuration store need to be recovered.
    /// </summary>
    public BicepValue<AppConfigurationCreateMode> CreateMode { get => _createMode; set => _createMode.Assign(value); }
    private readonly BicepValue<AppConfigurationCreateMode> _createMode;

    /// <summary>
    /// Disables all authentication methods other than AAD authentication.
    /// </summary>
    public BicepValue<bool> DisableLocalAuth { get => _disableLocalAuth; set => _disableLocalAuth.Assign(value); }
    private readonly BicepValue<bool> _disableLocalAuth;

    /// <summary>
    /// Property specifying whether protection against purge is enabled for
    /// this configuration store.
    /// </summary>
    public BicepValue<bool> EnablePurgeProtection { get => _enablePurgeProtection; set => _enablePurgeProtection.Assign(value); }
    private readonly BicepValue<bool> _enablePurgeProtection;

    /// <summary>
    /// Key vault properties.
    /// </summary>
    public BicepValue<AppConfigurationKeyVaultProperties> EncryptionKeyVaultProperties { get => _encryptionKeyVaultProperties; set => _encryptionKeyVaultProperties.Assign(value); }
    private readonly BicepValue<AppConfigurationKeyVaultProperties> _encryptionKeyVaultProperties;

    /// <summary>
    /// The managed identity information, if configured.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// Control permission for data plane traffic coming from public networks
    /// while private endpoint is enabled.
    /// </summary>
    public BicepValue<AppConfigurationPublicNetworkAccess> PublicNetworkAccess { get => _publicNetworkAccess; set => _publicNetworkAccess.Assign(value); }
    private readonly BicepValue<AppConfigurationPublicNetworkAccess> _publicNetworkAccess;

    /// <summary>
    /// The SKU name of the configuration store.
    /// </summary>
    public BicepValue<string> SkuName { get => _skuName; set => _skuName.Assign(value); }
    private readonly BicepValue<string> _skuName;

    /// <summary>
    /// The amount of time in days that the configuration store will be
    /// retained when it is soft deleted.
    /// </summary>
    public BicepValue<int> SoftDeleteRetentionInDays { get => _softDeleteRetentionInDays; set => _softDeleteRetentionInDays.Assign(value); }
    private readonly BicepValue<int> _softDeleteRetentionInDays;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// The creation date of configuration store.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// The DNS endpoint where the configuration store API will be available.
    /// </summary>
    public BicepValue<string> Endpoint { get => _endpoint; }
    private readonly BicepValue<string> _endpoint;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The list of private endpoint connections that are set up for this
    /// resource.
    /// </summary>
    public BicepList<AppConfigurationPrivateEndpointConnectionReference> PrivateEndpointConnections { get => _privateEndpointConnections; }
    private readonly BicepList<AppConfigurationPrivateEndpointConnectionReference> _privateEndpointConnections;

    /// <summary>
    /// The provisioning state of the configuration store.
    /// </summary>
    public BicepValue<AppConfigurationProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<AppConfigurationProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new AppConfigurationStore.
    /// </summary>
    /// <param name="resourceName">Name of the AppConfigurationStore.</param>
    /// <param name="resourceVersion">Version of the AppConfigurationStore.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public AppConfigurationStore(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.AppConfiguration/configurationStores", resourceVersion ?? "2019-10-01", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _createMode = BicepValue<AppConfigurationCreateMode>.DefineProperty(this, "CreateMode", ["properties", "createMode"]);
        _disableLocalAuth = BicepValue<bool>.DefineProperty(this, "DisableLocalAuth", ["properties", "disableLocalAuth"]);
        _enablePurgeProtection = BicepValue<bool>.DefineProperty(this, "EnablePurgeProtection", ["properties", "enablePurgeProtection"]);
        _encryptionKeyVaultProperties = BicepValue<AppConfigurationKeyVaultProperties>.DefineProperty(this, "EncryptionKeyVaultProperties", ["properties", "encryption", "keyVaultProperties"]);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _publicNetworkAccess = BicepValue<AppConfigurationPublicNetworkAccess>.DefineProperty(this, "PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _skuName = BicepValue<string>.DefineProperty(this, "SkuName", ["sku", "name"]);
        _softDeleteRetentionInDays = BicepValue<int>.DefineProperty(this, "SoftDeleteRetentionInDays", ["properties", "softDeleteRetentionInDays"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "creationDate"], isOutput: true);
        _endpoint = BicepValue<string>.DefineProperty(this, "Endpoint", ["properties", "endpoint"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _privateEndpointConnections = BicepList<AppConfigurationPrivateEndpointConnectionReference>.DefineProperty(this, "PrivateEndpointConnections", ["properties", "privateEndpointConnections"], isOutput: true);
        _provisioningState = BicepValue<AppConfigurationProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported AppConfigurationStore resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01.
        /// </summary>
        public static readonly string V2024_05_01 = "2024-05-01";

        /// <summary>
        /// 2023-03-01.
        /// </summary>
        public static readonly string V2023_03_01 = "2023-03-01";

        /// <summary>
        /// 2022-05-01.
        /// </summary>
        public static readonly string V2022_05_01 = "2022-05-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-10-01.
        /// </summary>
        public static readonly string V2019_10_01 = "2019-10-01";
    }

    /// <summary>
    /// Creates a reference to an existing AppConfigurationStore.
    /// </summary>
    /// <param name="resourceName">Name of the AppConfigurationStore.</param>
    /// <param name="resourceVersion">Version of the AppConfigurationStore.</param>
    /// <returns>The existing AppConfigurationStore resource.</returns>
    public static AppConfigurationStore FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this AppConfigurationStore resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 5, maxLength: 50, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);

    /// <summary>
    /// Get access keys for this AppConfigurationStore resource.
    /// </summary>
    /// <returns>The keys for this AppConfigurationStore resource.</returns>
    public BicepList<AppConfigurationStoreApiKey> GetKeys() =>
        BicepList<AppConfigurationStoreApiKey>.FromExpression(
            AppConfigurationStoreApiKey.FromExpression,
            new MemberExpression(new FunctionCallExpression(new MemberExpression(new IdentifierExpression(ResourceName), "listKeys")), "keys"));

    /// <summary>
    /// Assign a role to a user-assigned identity that grants access to this
    /// AppConfigurationStore.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment AssignRole(AppConfigurationBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{identity.ResourceName}_{AppConfigurationBuiltInRole.GetBuiltInRoleName(role)}_{ResourceName}")
        {
            Scope = new IdentifierExpression(ResourceName),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };
}
