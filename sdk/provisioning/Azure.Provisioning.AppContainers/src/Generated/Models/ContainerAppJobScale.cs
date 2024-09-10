// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Scaling configurations for event driven jobs.
/// </summary>
public partial class ContainerAppJobScale : ProvisioningConstruct
{
    /// <summary>
    /// Interval to check each event source in seconds. Defaults to 30s.
    /// </summary>
    public BicepValue<int> PollingIntervalInSeconds { get => _pollingIntervalInSeconds; set => _pollingIntervalInSeconds.Assign(value); }
    private readonly BicepValue<int> _pollingIntervalInSeconds;

    /// <summary>
    /// Minimum number of job executions that are created for a trigger,
    /// default 0.
    /// </summary>
    public BicepValue<int> MinExecutions { get => _minExecutions; set => _minExecutions.Assign(value); }
    private readonly BicepValue<int> _minExecutions;

    /// <summary>
    /// Maximum number of job executions that are created for a trigger,
    /// default 100.
    /// </summary>
    public BicepValue<int> MaxExecutions { get => _maxExecutions; set => _maxExecutions.Assign(value); }
    private readonly BicepValue<int> _maxExecutions;

    /// <summary>
    /// Scaling rules.
    /// </summary>
    public BicepList<ContainerAppJobScaleRule> Rules { get => _rules; set => _rules.Assign(value); }
    private readonly BicepList<ContainerAppJobScaleRule> _rules;

    /// <summary>
    /// Creates a new ContainerAppJobScale.
    /// </summary>
    public ContainerAppJobScale()
    {
        _pollingIntervalInSeconds = BicepValue<int>.DefineProperty(this, "PollingIntervalInSeconds", ["pollingInterval"]);
        _minExecutions = BicepValue<int>.DefineProperty(this, "MinExecutions", ["minExecutions"]);
        _maxExecutions = BicepValue<int>.DefineProperty(this, "MaxExecutions", ["maxExecutions"]);
        _rules = BicepList<ContainerAppJobScaleRule>.DefineProperty(this, "Rules", ["rules"]);
    }
}
