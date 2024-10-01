// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Resources;

/// <summary>
/// PolicyAssignment.
/// </summary>
public partial class PolicyAssignment : Resource
{
    /// <summary>
    /// The name of the policy assignment.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// This message will be part of response in case of policy violation.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// The display name of the policy assignment.
    /// </summary>
    public BicepValue<string> DisplayName { get => _displayName; set => _displayName.Assign(value); }
    private readonly BicepValue<string> _displayName;

    /// <summary>
    /// The policy assignment enforcement mode. Possible values are Default and
    /// DoNotEnforce.
    /// </summary>
    public BicepValue<EnforcementMode> EnforcementMode { get => _enforcementMode; set => _enforcementMode.Assign(value); }
    private readonly BicepValue<EnforcementMode> _enforcementMode;

    /// <summary>
    /// The policy&apos;s excluded scopes.
    /// </summary>
    public BicepList<string> ExcludedScopes { get => _excludedScopes; set => _excludedScopes.Assign(value); }
    private readonly BicepList<string> _excludedScopes;

    /// <summary>
    /// The location of the policy assignment. Only required when utilizing
    /// managed identity.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The managed identity associated with the policy assignment. Current
    /// supported identity types: None, SystemAssigned, UserAssigned.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> ManagedIdentity { get => _managedIdentity; set => _managedIdentity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _managedIdentity;

    /// <summary>
    /// The policy assignment metadata. Metadata is an open ended object and is
    /// typically a collection of key value pairs.                          To
    /// assign an object to this property use
    /// System.BinaryData.FromObjectAsJson``1(``0,System.Text.Json.JsonSerializerOptions).
    /// To assign an already formatted json string to
    /// this property use System.BinaryData.FromString(System.String).
    /// Examples:
    /// BinaryData.FromObjectAsJson(&quot;foo&quot;)Creates a
    /// payload of
    /// &quot;foo&quot;.BinaryData.FromString(&quot;\&quot;foo\&quot;&quot;)Creates
    /// a payload of &quot;foo&quot;.BinaryData.FromObjectAsJson(new { key =
    /// &quot;value&quot; })Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.BinaryData.FromString(&quot;{\&quot;key\&quot;:
    /// \&quot;value\&quot;}&quot;)Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.
    /// </summary>
    public BicepValue<BinaryData> Metadata { get => _metadata; set => _metadata.Assign(value); }
    private readonly BicepValue<BinaryData> _metadata;

    /// <summary>
    /// The messages that describe why a resource is non-compliant with the
    /// policy.
    /// </summary>
    public BicepList<NonComplianceMessage> NonComplianceMessages { get => _nonComplianceMessages; set => _nonComplianceMessages.Assign(value); }
    private readonly BicepList<NonComplianceMessage> _nonComplianceMessages;

    /// <summary>
    /// The policy property value override.
    /// </summary>
    public BicepList<PolicyOverride> Overrides { get => _overrides; set => _overrides.Assign(value); }
    private readonly BicepList<PolicyOverride> _overrides;

    /// <summary>
    /// The parameter values for the assigned policy rule. The keys are the
    /// parameter names.
    /// </summary>
    public BicepDictionary<ArmPolicyParameterValue> Parameters { get => _parameters; set => _parameters.Assign(value); }
    private readonly BicepDictionary<ArmPolicyParameterValue> _parameters;

    /// <summary>
    /// The ID of the policy definition or policy set definition being assigned.
    /// </summary>
    public BicepValue<string> PolicyDefinitionId { get => _policyDefinitionId; set => _policyDefinitionId.Assign(value); }
    private readonly BicepValue<string> _policyDefinitionId;

    /// <summary>
    /// The resource selector list to filter policies by resource properties.
    /// </summary>
    public BicepList<ResourceSelector> ResourceSelectors { get => _resourceSelectors; set => _resourceSelectors.Assign(value); }
    private readonly BicepList<ResourceSelector> _resourceSelectors;

    /// <summary>
    /// Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The scope for the policy assignment.
    /// </summary>
    public BicepValue<string> Scope { get => _scope; }
    private readonly BicepValue<string> _scope;

    /// <summary>
    /// Azure Resource Manager metadata containing createdBy and modifiedBy
    /// information.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new PolicyAssignment.
    /// </summary>
    /// <param name="resourceName">Name of the PolicyAssignment.</param>
    /// <param name="resourceVersion">Version of the PolicyAssignment.</param>
    public PolicyAssignment(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.Authorization/policyAssignments", resourceVersion ?? "2024-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["properties", "description"]);
        _displayName = BicepValue<string>.DefineProperty(this, "DisplayName", ["properties", "displayName"]);
        _enforcementMode = BicepValue<EnforcementMode>.DefineProperty(this, "EnforcementMode", ["properties", "enforcementMode"]);
        _excludedScopes = BicepList<string>.DefineProperty(this, "ExcludedScopes", ["properties", "notScopes"]);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"]);
        _managedIdentity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "ManagedIdentity", ["identity"]);
        _metadata = BicepValue<BinaryData>.DefineProperty(this, "Metadata", ["properties", "metadata"]);
        _nonComplianceMessages = BicepList<NonComplianceMessage>.DefineProperty(this, "NonComplianceMessages", ["properties", "nonComplianceMessages"]);
        _overrides = BicepList<PolicyOverride>.DefineProperty(this, "Overrides", ["properties", "overrides"]);
        _parameters = BicepDictionary<ArmPolicyParameterValue>.DefineProperty(this, "Parameters", ["properties", "parameters"]);
        _policyDefinitionId = BicepValue<string>.DefineProperty(this, "PolicyDefinitionId", ["properties", "policyDefinitionId"]);
        _resourceSelectors = BicepList<ResourceSelector>.DefineProperty(this, "ResourceSelectors", ["properties", "resourceSelectors"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _scope = BicepValue<string>.DefineProperty(this, "Scope", ["properties", "scope"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported PolicyAssignment resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01.
        /// </summary>
        public static readonly string V2024_04_01 = "2024-04-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2022-06-01.
        /// </summary>
        public static readonly string V2022_06_01 = "2022-06-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-08-01.
        /// </summary>
        public static readonly string V2020_08_01 = "2020-08-01";

        /// <summary>
        /// 2020-03-01.
        /// </summary>
        public static readonly string V2020_03_01 = "2020-03-01";

        /// <summary>
        /// 2019-09-01.
        /// </summary>
        public static readonly string V2019_09_01 = "2019-09-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";

        /// <summary>
        /// 2019-01-01.
        /// </summary>
        public static readonly string V2019_01_01 = "2019-01-01";

        /// <summary>
        /// 2018-05-01.
        /// </summary>
        public static readonly string V2018_05_01 = "2018-05-01";

        /// <summary>
        /// 2018-03-01.
        /// </summary>
        public static readonly string V2018_03_01 = "2018-03-01";

        /// <summary>
        /// 2016-12-01.
        /// </summary>
        public static readonly string V2016_12_01 = "2016-12-01";

        /// <summary>
        /// 2016-04-01.
        /// </summary>
        public static readonly string V2016_04_01 = "2016-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing PolicyAssignment.
    /// </summary>
    /// <param name="resourceName">Name of the PolicyAssignment.</param>
    /// <param name="resourceVersion">Version of the PolicyAssignment.</param>
    /// <returns>The existing PolicyAssignment resource.</returns>
    public static PolicyAssignment FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this PolicyAssignment resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 128, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period | ResourceNameCharacters.Parentheses);
}
