// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Authorization;

/// <summary>
/// RoleManagementPolicyAssignment.
/// </summary>
public partial class RoleManagementPolicyAssignment : Resource
{
    /// <summary>
    /// The name of format {guid_guid} the role management policy assignment to
    /// upsert.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The policy id role management policy assignment.
    /// </summary>
    public BicepValue<ResourceIdentifier> PolicyId { get => _policyId; set => _policyId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _policyId;

    /// <summary>
    /// The role definition of management policy assignment.
    /// </summary>
    public BicepValue<ResourceIdentifier> RoleDefinitionId { get => _roleDefinitionId; set => _roleDefinitionId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _roleDefinitionId;

    /// <summary>
    /// The role management policy scope.
    /// </summary>
    public BicepValue<string> Scope { get => _scope; set => _scope.Assign(value); }
    private readonly BicepValue<string> _scope;

    /// <summary>
    /// The readonly computed rule applied to the policy.             Please
    /// note
    /// Azure.ResourceManager.Authorization.Models.RoleManagementPolicyRule is
    /// the base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.Authorization.Models.RoleManagementPolicyApprovalRule,
    /// Azure.ResourceManager.Authorization.Models.RoleManagementPolicyAuthenticationContextRule,
    /// Azure.ResourceManager.Authorization.Models.RoleManagementPolicyEnablementRule,
    /// Azure.ResourceManager.Authorization.Models.RoleManagementPolicyExpirationRule
    /// and
    /// Azure.ResourceManager.Authorization.Models.RoleManagementPolicyNotificationRule.
    /// </summary>
    public BicepList<RoleManagementPolicyRule> EffectiveRules { get => _effectiveRules; }
    private readonly BicepList<RoleManagementPolicyRule> _effectiveRules;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Additional properties of scope, role definition and policy.
    /// </summary>
    public BicepValue<PolicyAssignmentProperties> PolicyAssignmentProperties { get => _policyAssignmentProperties; }
    private readonly BicepValue<PolicyAssignmentProperties> _policyAssignmentProperties;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new RoleManagementPolicyAssignment.
    /// </summary>
    /// <param name="resourceName">Name of the RoleManagementPolicyAssignment.</param>
    /// <param name="resourceVersion">Version of the RoleManagementPolicyAssignment.</param>
    public RoleManagementPolicyAssignment(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.Authorization/roleManagementPolicyAssignments", resourceVersion ?? "2020-10-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _policyId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PolicyId", ["properties", "policyId"]);
        _roleDefinitionId = BicepValue<ResourceIdentifier>.DefineProperty(this, "RoleDefinitionId", ["properties", "roleDefinitionId"]);
        _scope = BicepValue<string>.DefineProperty(this, "Scope", ["properties", "scope"]);
        _effectiveRules = BicepList<RoleManagementPolicyRule>.DefineProperty(this, "EffectiveRules", ["properties", "effectiveRules"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _policyAssignmentProperties = BicepValue<PolicyAssignmentProperties>.DefineProperty(this, "PolicyAssignmentProperties", ["properties", "policyAssignmentProperties"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported RoleManagementPolicyAssignment resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2020-10-01-preview.
        /// </summary>
        public static readonly string V2020_10_01_preview = "2020-10-01-preview";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";
    }

    /// <summary>
    /// Creates a reference to an existing RoleManagementPolicyAssignment.
    /// </summary>
    /// <param name="resourceName">Name of the RoleManagementPolicyAssignment.</param>
    /// <param name="resourceVersion">Version of the RoleManagementPolicyAssignment.</param>
    /// <returns>The existing RoleManagementPolicyAssignment resource.</returns>
    public static RoleManagementPolicyAssignment FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
