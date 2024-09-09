// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// The resource model definition representing SKU.
/// </summary>
public partial class CognitiveServicesSku : ProvisioningConstruct
{
    /// <summary>
    /// The name of the SKU. Ex - P3. It is typically a letter+number code.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// This field is required to be implemented by the Resource Provider if
    /// the service has more than one tier, but is not required on a PUT.
    /// </summary>
    public BicepValue<CognitiveServicesSkuTier> Tier { get => _tier; set => _tier.Assign(value); }
    private readonly BicepValue<CognitiveServicesSkuTier> _tier;

    /// <summary>
    /// The SKU size. When the name field is the combination of tier and some
    /// other value, this would be the standalone code.
    /// </summary>
    public BicepValue<string> Size { get => _size; set => _size.Assign(value); }
    private readonly BicepValue<string> _size;

    /// <summary>
    /// If the service has different generations of hardware, for the same SKU,
    /// then that can be captured here.
    /// </summary>
    public BicepValue<string> Family { get => _family; set => _family.Assign(value); }
    private readonly BicepValue<string> _family;

    /// <summary>
    /// If the SKU supports scale out/in then the capacity integer should be
    /// included. If scale out/in is not possible for the resource this may be
    /// omitted.
    /// </summary>
    public BicepValue<int> Capacity { get => _capacity; set => _capacity.Assign(value); }
    private readonly BicepValue<int> _capacity;

    /// <summary>
    /// Creates a new CognitiveServicesSku.
    /// </summary>
    public CognitiveServicesSku()
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"]);
        _tier = BicepValue<CognitiveServicesSkuTier>.DefineProperty(this, "Tier", ["tier"]);
        _size = BicepValue<string>.DefineProperty(this, "Size", ["size"]);
        _family = BicepValue<string>.DefineProperty(this, "Family", ["family"]);
        _capacity = BicepValue<int>.DefineProperty(this, "Capacity", ["capacity"]);
    }
}
