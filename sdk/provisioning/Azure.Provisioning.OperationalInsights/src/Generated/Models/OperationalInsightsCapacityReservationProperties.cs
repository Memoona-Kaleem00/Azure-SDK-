// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// The Capacity Reservation properties.
/// </summary>
public partial class OperationalInsightsCapacityReservationProperties : ProvisioningConstruct
{
    /// <summary>
    /// The last time Sku was updated.
    /// </summary>
    public BicepValue<DateTimeOffset> LastSkuUpdatedOn { get => _lastSkuUpdatedOn; }
    private readonly BicepValue<DateTimeOffset> _lastSkuUpdatedOn;

    /// <summary>
    /// Minimum CapacityReservation value in GB.
    /// </summary>
    public BicepValue<long> MinCapacity { get => _minCapacity; }
    private readonly BicepValue<long> _minCapacity;

    /// <summary>
    /// Creates a new OperationalInsightsCapacityReservationProperties.
    /// </summary>
    public OperationalInsightsCapacityReservationProperties()
    {
        _lastSkuUpdatedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "LastSkuUpdatedOn", ["lastSkuUpdate"], isOutput: true);
        _minCapacity = BicepValue<long>.DefineProperty(this, "MinCapacity", ["minCapacity"], isOutput: true);
    }
}
