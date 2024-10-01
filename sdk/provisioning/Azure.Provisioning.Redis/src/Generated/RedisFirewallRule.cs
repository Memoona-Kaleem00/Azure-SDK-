// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;
using System.Net;

namespace Azure.Provisioning.Redis;

/// <summary>
/// RedisFirewallRule.
/// </summary>
public partial class RedisFirewallRule : Resource
{
    /// <summary>
    /// The name of the firewall rule.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// highest IP address included in the range.
    /// </summary>
    public BicepValue<IPAddress> EndIP { get => _endIP; set => _endIP.Assign(value); }
    private readonly BicepValue<IPAddress> _endIP;

    /// <summary>
    /// lowest IP address included in the range.
    /// </summary>
    public BicepValue<IPAddress> StartIP { get => _startIP; set => _startIP.Assign(value); }
    private readonly BicepValue<IPAddress> _startIP;

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
    /// Gets or sets a reference to the parent RedisResource.
    /// </summary>
    public RedisResource? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<RedisResource> _parent;

    /// <summary>
    /// Creates a new RedisFirewallRule.
    /// </summary>
    /// <param name="resourceName">Name of the RedisFirewallRule.</param>
    /// <param name="resourceVersion">Version of the RedisFirewallRule.</param>
    public RedisFirewallRule(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.Cache/redis/firewallRules", resourceVersion ?? "2024-03-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _endIP = BicepValue<IPAddress>.DefineProperty(this, "EndIP", ["properties", "endIP"], isRequired: true);
        _startIP = BicepValue<IPAddress>.DefineProperty(this, "StartIP", ["properties", "startIP"], isRequired: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<RedisResource>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported RedisFirewallRule resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01-preview.
        /// </summary>
        public static readonly string V2024_04_01_preview = "2024-04-01-preview";

        /// <summary>
        /// 2024-03-01.
        /// </summary>
        public static readonly string V2024_03_01 = "2024-03-01";

        /// <summary>
        /// 2023-08-01.
        /// </summary>
        public static readonly string V2023_08_01 = "2023-08-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2022-06-01.
        /// </summary>
        public static readonly string V2022_06_01 = "2022-06-01";

        /// <summary>
        /// 2022-05-01.
        /// </summary>
        public static readonly string V2022_05_01 = "2022-05-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-07-01.
        /// </summary>
        public static readonly string V2019_07_01 = "2019-07-01";

        /// <summary>
        /// 2018-03-01.
        /// </summary>
        public static readonly string V2018_03_01 = "2018-03-01";

        /// <summary>
        /// 2017-10-01.
        /// </summary>
        public static readonly string V2017_10_01 = "2017-10-01";

        /// <summary>
        /// 2017-02-01.
        /// </summary>
        public static readonly string V2017_02_01 = "2017-02-01";

        /// <summary>
        /// 2016-04-01.
        /// </summary>
        public static readonly string V2016_04_01 = "2016-04-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";

        /// <summary>
        /// 2015-03-01.
        /// </summary>
        public static readonly string V2015_03_01 = "2015-03-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing RedisFirewallRule.
    /// </summary>
    /// <param name="resourceName">Name of the RedisFirewallRule.</param>
    /// <param name="resourceVersion">Version of the RedisFirewallRule.</param>
    /// <returns>The existing RedisFirewallRule resource.</returns>
    public static RedisFirewallRule FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this RedisFirewallRule resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 256, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers);
}
