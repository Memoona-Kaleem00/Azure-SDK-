// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Container App container scaling rule.
/// </summary>
public partial class ContainerAppScaleRule : ProvisioningConstruct
{
    /// <summary>
    /// Scale Rule Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Azure Queue based scaling.
    /// </summary>
    public BicepValue<ContainerAppQueueScaleRule> AzureQueue { get => _azureQueue; set => _azureQueue.Assign(value); }
    private readonly BicepValue<ContainerAppQueueScaleRule> _azureQueue;

    /// <summary>
    /// Custom scale rule.
    /// </summary>
    public BicepValue<ContainerAppCustomScaleRule> Custom { get => _custom; set => _custom.Assign(value); }
    private readonly BicepValue<ContainerAppCustomScaleRule> _custom;

    /// <summary>
    /// HTTP requests based scaling.
    /// </summary>
    public BicepValue<ContainerAppHttpScaleRule> Http { get => _http; set => _http.Assign(value); }
    private readonly BicepValue<ContainerAppHttpScaleRule> _http;

    /// <summary>
    /// Tcp requests based scaling.
    /// </summary>
    public BicepValue<ContainerAppTcpScaleRule> Tcp { get => _tcp; set => _tcp.Assign(value); }
    private readonly BicepValue<ContainerAppTcpScaleRule> _tcp;

    /// <summary>
    /// Creates a new ContainerAppScaleRule.
    /// </summary>
    public ContainerAppScaleRule()
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"]);
        _azureQueue = BicepValue<ContainerAppQueueScaleRule>.DefineProperty(this, "AzureQueue", ["azureQueue"]);
        _custom = BicepValue<ContainerAppCustomScaleRule>.DefineProperty(this, "Custom", ["custom"]);
        _http = BicepValue<ContainerAppHttpScaleRule>.DefineProperty(this, "Http", ["http"]);
        _tcp = BicepValue<ContainerAppTcpScaleRule>.DefineProperty(this, "Tcp", ["tcp"]);
    }
}
