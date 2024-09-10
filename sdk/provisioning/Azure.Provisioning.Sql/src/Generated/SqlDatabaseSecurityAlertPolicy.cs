// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlDatabaseSecurityAlertPolicy.
/// </summary>
public partial class SqlDatabaseSecurityAlertPolicy : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Specifies an array of alerts that are disabled. Allowed values are:
    /// Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly,
    /// Data_Exfiltration, Unsafe_Action, Brute_Force.
    /// </summary>
    public BicepList<string> DisabledAlerts { get => _disabledAlerts; set => _disabledAlerts.Assign(value); }
    private readonly BicepList<string> _disabledAlerts;

    /// <summary>
    /// Specifies an array of e-mail addresses to which the alert is sent.
    /// </summary>
    public BicepList<string> EmailAddresses { get => _emailAddresses; set => _emailAddresses.Assign(value); }
    private readonly BicepList<string> _emailAddresses;

    /// <summary>
    /// Specifies the number of days to keep in the Threat Detection audit logs.
    /// </summary>
    public BicepValue<int> RetentionDays { get => _retentionDays; set => _retentionDays.Assign(value); }
    private readonly BicepValue<int> _retentionDays;

    /// <summary>
    /// Specifies that the alert is sent to the account administrators.
    /// </summary>
    public BicepValue<bool> SendToEmailAccountAdmins { get => _sendToEmailAccountAdmins; set => _sendToEmailAccountAdmins.Assign(value); }
    private readonly BicepValue<bool> _sendToEmailAccountAdmins;

    /// <summary>
    /// Specifies the state of the policy, whether it is enabled or disabled or
    /// a policy has not been applied yet on the specific database.
    /// </summary>
    public BicepValue<SecurityAlertsPolicyState> State { get => _state; set => _state.Assign(value); }
    private readonly BicepValue<SecurityAlertsPolicyState> _state;

    /// <summary>
    /// Specifies the identifier key of the Threat Detection audit storage
    /// account.
    /// </summary>
    public BicepValue<string> StorageAccountAccessKey { get => _storageAccountAccessKey; set => _storageAccountAccessKey.Assign(value); }
    private readonly BicepValue<string> _storageAccountAccessKey;

    /// <summary>
    /// Specifies the blob storage endpoint (e.g.
    /// https://MyAccount.blob.core.windows.net). This blob storage will hold
    /// all Threat Detection audit logs.
    /// </summary>
    public BicepValue<string> StorageEndpoint { get => _storageEndpoint; set => _storageEndpoint.Assign(value); }
    private readonly BicepValue<string> _storageEndpoint;

    /// <summary>
    /// Specifies the UTC creation time of the policy.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

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
    /// Gets or sets a reference to the parent SqlDatabase.
    /// </summary>
    public SqlDatabase? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SqlDatabase> _parent;

    /// <summary>
    /// Creates a new SqlDatabaseSecurityAlertPolicy.
    /// </summary>
    /// <param name="resourceName">Name of the SqlDatabaseSecurityAlertPolicy.</param>
    /// <param name="resourceVersion">Version of the SqlDatabaseSecurityAlertPolicy.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public SqlDatabaseSecurityAlertPolicy(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Sql/servers/databases/securityAlertPolicies", resourceVersion ?? "2021-11-01", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _disabledAlerts = BicepList<string>.DefineProperty(this, "DisabledAlerts", ["properties", "disabledAlerts"]);
        _emailAddresses = BicepList<string>.DefineProperty(this, "EmailAddresses", ["properties", "emailAddresses"]);
        _retentionDays = BicepValue<int>.DefineProperty(this, "RetentionDays", ["properties", "retentionDays"]);
        _sendToEmailAccountAdmins = BicepValue<bool>.DefineProperty(this, "SendToEmailAccountAdmins", ["properties", "emailAccountAdmins"]);
        _state = BicepValue<SecurityAlertsPolicyState>.DefineProperty(this, "State", ["properties", "state"]);
        _storageAccountAccessKey = BicepValue<string>.DefineProperty(this, "StorageAccountAccessKey", ["properties", "storageAccountAccessKey"]);
        _storageEndpoint = BicepValue<string>.DefineProperty(this, "StorageEndpoint", ["properties", "storageEndpoint"]);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "creationTime"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SqlDatabase>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SqlDatabaseSecurityAlertPolicy resource versions.
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
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";

        /// <summary>
        /// 2014-01-01.
        /// </summary>
        public static readonly string V2014_01_01 = "2014-01-01";
    }

    /// <summary>
    /// Creates a reference to an existing SqlDatabaseSecurityAlertPolicy.
    /// </summary>
    /// <param name="resourceName">Name of the SqlDatabaseSecurityAlertPolicy.</param>
    /// <param name="resourceVersion">Version of the SqlDatabaseSecurityAlertPolicy.</param>
    /// <returns>The existing SqlDatabaseSecurityAlertPolicy resource.</returns>
    public static SqlDatabaseSecurityAlertPolicy FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
