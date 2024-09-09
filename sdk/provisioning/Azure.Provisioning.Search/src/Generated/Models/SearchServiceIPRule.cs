// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Search;

/// <summary>
/// The IP restriction rule of the Azure AI Search service.
/// </summary>
public partial class SearchServiceIPRule : ProvisioningConstruct
{
    /// <summary>
    /// Value corresponding to a single IPv4 address (eg., 123.1.2.3) or an IP
    /// range in CIDR format (eg., 123.1.2.3/24) to be allowed.
    /// </summary>
    public BicepValue<string> Value { get => _value; set => _value.Assign(value); }
    private readonly BicepValue<string> _value;

    /// <summary>
    /// Creates a new SearchServiceIPRule.
    /// </summary>
    public SearchServiceIPRule()
    {
        _value = BicepValue<string>.DefineProperty(this, "Value", ["value"]);
    }
}
