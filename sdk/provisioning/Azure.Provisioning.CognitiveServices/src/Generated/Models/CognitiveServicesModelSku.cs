// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// Describes an available Cognitive Services Model SKU.
/// </summary>
public partial class CognitiveServicesModelSku : ProvisioningConstruct
{
    /// <summary>
    /// The name of the model SKU.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The usage name of the model SKU.
    /// </summary>
    public BicepValue<string> UsageName { get => _usageName; set => _usageName.Assign(value); }
    private readonly BicepValue<string> _usageName;

    /// <summary>
    /// The datetime of deprecation of the model SKU.
    /// </summary>
    public BicepValue<DateTimeOffset> DeprecationOn { get => _deprecationOn; set => _deprecationOn.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _deprecationOn;

    /// <summary>
    /// The capacity configuration.
    /// </summary>
    public BicepValue<CognitiveServicesCapacityConfig> Capacity { get => _capacity; set => _capacity.Assign(value); }
    private readonly BicepValue<CognitiveServicesCapacityConfig> _capacity;

    /// <summary>
    /// The list of rateLimit.
    /// </summary>
    public BicepList<ServiceAccountCallRateLimit> RateLimits { get => _rateLimits; }
    private readonly BicepList<ServiceAccountCallRateLimit> _rateLimits;

    /// <summary>
    /// Creates a new CognitiveServicesModelSku.
    /// </summary>
    public CognitiveServicesModelSku()
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"]);
        _usageName = BicepValue<string>.DefineProperty(this, "UsageName", ["usageName"]);
        _deprecationOn = BicepValue<DateTimeOffset>.DefineProperty(this, "DeprecationOn", ["deprecationDate"]);
        _capacity = BicepValue<CognitiveServicesCapacityConfig>.DefineProperty(this, "Capacity", ["capacity"]);
        _rateLimits = BicepList<ServiceAccountCallRateLimit>.DefineProperty(this, "RateLimits", ["rateLimits"], isOutput: true);
    }
}
