// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Profile of the managed cluster load balancer.
/// </summary>
public partial class ManagedClusterLoadBalancerProfile : ProvisioningConstruct
{
    /// <summary>
    /// Desired managed outbound IPs for the cluster load balancer.
    /// </summary>
    public BicepValue<ManagedClusterLoadBalancerProfileManagedOutboundIPs> ManagedOutboundIPs { get => _managedOutboundIPs; set => _managedOutboundIPs.Assign(value); }
    private readonly BicepValue<ManagedClusterLoadBalancerProfileManagedOutboundIPs> _managedOutboundIPs;

    /// <summary>
    /// A list of public IP prefix resources.
    /// </summary>
    public BicepList<WritableSubResource> OutboundPublicIPPrefixes { get => _outboundPublicIPPrefixes; set => _outboundPublicIPPrefixes.Assign(value); }
    private readonly BicepList<WritableSubResource> _outboundPublicIPPrefixes;

    /// <summary>
    /// A list of public IP resources.
    /// </summary>
    public BicepList<WritableSubResource> OutboundPublicIPs { get => _outboundPublicIPs; set => _outboundPublicIPs.Assign(value); }
    private readonly BicepList<WritableSubResource> _outboundPublicIPs;

    /// <summary>
    /// The effective outbound IP resources of the cluster load balancer.
    /// </summary>
    public BicepList<WritableSubResource> EffectiveOutboundIPs { get => _effectiveOutboundIPs; set => _effectiveOutboundIPs.Assign(value); }
    private readonly BicepList<WritableSubResource> _effectiveOutboundIPs;

    /// <summary>
    /// The desired number of allocated SNAT ports per VM. Allowed values are
    /// in the range of 0 to 64000 (inclusive). The default value is 0 which
    /// results in Azure dynamically allocating ports.
    /// </summary>
    public BicepValue<int> AllocatedOutboundPorts { get => _allocatedOutboundPorts; set => _allocatedOutboundPorts.Assign(value); }
    private readonly BicepValue<int> _allocatedOutboundPorts;

    /// <summary>
    /// Desired outbound flow idle timeout in minutes. Allowed values are in
    /// the range of 4 to 120 (inclusive). The default value is 30 minutes.
    /// </summary>
    public BicepValue<int> IdleTimeoutInMinutes { get => _idleTimeoutInMinutes; set => _idleTimeoutInMinutes.Assign(value); }
    private readonly BicepValue<int> _idleTimeoutInMinutes;

    /// <summary>
    /// Enable multiple standard load balancers per AKS cluster or not.
    /// </summary>
    public BicepValue<bool> EnableMultipleStandardLoadBalancers { get => _enableMultipleStandardLoadBalancers; set => _enableMultipleStandardLoadBalancers.Assign(value); }
    private readonly BicepValue<bool> _enableMultipleStandardLoadBalancers;

    /// <summary>
    /// The type of the managed inbound Load Balancer BackendPool.
    /// </summary>
    public BicepValue<ManagedClusterLoadBalancerBackendPoolType> BackendPoolType { get => _backendPoolType; set => _backendPoolType.Assign(value); }
    private readonly BicepValue<ManagedClusterLoadBalancerBackendPoolType> _backendPoolType;

    /// <summary>
    /// Creates a new ManagedClusterLoadBalancerProfile.
    /// </summary>
    public ManagedClusterLoadBalancerProfile()
    {
        _managedOutboundIPs = BicepValue<ManagedClusterLoadBalancerProfileManagedOutboundIPs>.DefineProperty(this, "ManagedOutboundIPs", ["managedOutboundIPs"]);
        _outboundPublicIPPrefixes = BicepList<WritableSubResource>.DefineProperty(this, "OutboundPublicIPPrefixes", ["outboundIPPrefixes", "publicIPPrefixes"]);
        _outboundPublicIPs = BicepList<WritableSubResource>.DefineProperty(this, "OutboundPublicIPs", ["outboundIPs", "publicIPs"]);
        _effectiveOutboundIPs = BicepList<WritableSubResource>.DefineProperty(this, "EffectiveOutboundIPs", ["effectiveOutboundIPs"]);
        _allocatedOutboundPorts = BicepValue<int>.DefineProperty(this, "AllocatedOutboundPorts", ["allocatedOutboundPorts"]);
        _idleTimeoutInMinutes = BicepValue<int>.DefineProperty(this, "IdleTimeoutInMinutes", ["idleTimeoutInMinutes"]);
        _enableMultipleStandardLoadBalancers = BicepValue<bool>.DefineProperty(this, "EnableMultipleStandardLoadBalancers", ["enableMultipleStandardLoadBalancers"]);
        _backendPoolType = BicepValue<ManagedClusterLoadBalancerBackendPoolType>.DefineProperty(this, "BackendPoolType", ["backendPoolType"]);
    }
}
