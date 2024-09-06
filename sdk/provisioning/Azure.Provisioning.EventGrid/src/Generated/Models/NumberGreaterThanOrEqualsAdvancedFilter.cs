// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// NumberGreaterThanOrEquals Advanced Filter.
/// </summary>
public partial class NumberGreaterThanOrEqualsAdvancedFilter : AdvancedFilter
{
    /// <summary>
    /// The filter value.
    /// </summary>
    public BicepValue<double> Value { get => _value; set => _value.Assign(value); }
    private readonly BicepValue<double> _value;

    /// <summary>
    /// Creates a new NumberGreaterThanOrEqualsAdvancedFilter.
    /// </summary>
    public NumberGreaterThanOrEqualsAdvancedFilter() : base()
    {
        BicepValue<string>.DefineProperty(this, "operatorType", ["operatorType"], defaultValue: "NumberGreaterThanOrEquals");
        _value = BicepValue<double>.DefineProperty(this, "Value", ["value"]);
    }
}
