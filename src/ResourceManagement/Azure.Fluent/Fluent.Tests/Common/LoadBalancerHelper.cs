﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Fluent.Tests.Common;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.Azure.Management.Fluent.Compute;
using Microsoft.Azure.Management.Fluent.Network;
using Microsoft.Azure.Management.Fluent.Resource.Core;
using Microsoft.Azure.Management.Fluent.Resource.Core.ResourceActions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Tests.Common
{
    public static class LoadBalancerHelper
    {
        public static readonly long TEST_ID = DateTime.Now.Millisecond;
        public static readonly Region REGION = Region.US_WEST;
        public static readonly string GROUP_NAME = "rg" + TEST_ID;
        public static readonly string LB_NAME = "lb" + TEST_ID;
        public static readonly string[] PIP_NAMES = { "pipa" + TEST_ID, "pipb" + TEST_ID };
        public static readonly string[] VM_IDS =
            {
                "/subscriptions/9657ab5d-4a4a-4fd2-ae7a-4cd9fbd030ef/resourceGroups/marcinslbtest/providers/Microsoft.Compute/virtualMachines/marcinslbtest1",
                "/subscriptions/9657ab5d-4a4a-4fd2-ae7a-4cd9fbd030ef/resourceGroups/marcinslbtest/providers/Microsoft.Compute/virtualMachines/marcinslbtest3"
        };

        // Create VNet for the LB
        public static IEnumerable<IPublicIpAddress> EnsurePIPs(IPublicIpAddresses pips)
        {
            var creatablePips = new List<ICreatable<IPublicIpAddress>>();
            for (int i = 0; i<PIP_NAMES.Length; i++)
            {
                creatablePips.Add(pips.Define(PIP_NAMES[i])
                                  .WithRegion(REGION)
                                  .WithNewResourceGroup(GROUP_NAME)
                                  .WithLeafDomainLabel(PIP_NAMES[i]));
            }

            return pips.Create(creatablePips.ToArray());
        }

        // Ensure VMs for the LB
        public static IEnumerable<IVirtualMachine> EnsureVMs(
            INetworks networks, 
            IVirtualMachines vms, 
            params string[] vmIds)
        {
            var createdVMs = new List<IVirtualMachine>();
            INetwork network = null;
            Region region = Region.US_WEST;
            string userName = "testuser" + TEST_ID;
            string availabilitySetName = "as" + TEST_ID;

            foreach (var vmId in vmIds)
            {
                string groupName = ResourceUtils.GroupFromResourceId(vmId);
                string vmName = ResourceUtils.NameFromResourceId(vmId);
                IVirtualMachine vm = null;

                if (groupName == null)
                {
                    // Creating a new VM
                    vm = null;
                    groupName = "rg" + TEST_ID;
                    vmName = "vm" + TEST_ID;

                    if (network == null)
                    {
                        // Create a VNet for the VM
                        network = networks.Define("net" + TEST_ID)
                            .WithRegion(region)
                            .WithNewResourceGroup(groupName)
                            .WithAddressSpace("10.0.0.0/28")
                            .Create();
                    }

                    vm = vms.Define(vmName)
                            .WithRegion(Region.US_WEST)
                            .WithNewResourceGroup(groupName)
                            .WithExistingPrimaryNetwork(network)
                            .WithSubnet("subnet1")
                            .WithPrimaryPrivateIpAddressDynamic()
                            .WithoutPrimaryPublicIpAddress()
                            .WithPopularLinuxImage(KnownLinuxVirtualMachineImage.UBUNTU_SERVER_14_04_LTS)
                            .WithRootUserName(userName)
                            .WithPassword("Abcdef.123456")
                            .WithNewAvailabilitySet(availabilitySetName)
                            .WithSize(VirtualMachineSizeTypes.StandardA1)
                            .Create();
                }
                else
                {
                    // Getting an existing VM
                    try
                    {
                        vm = vms.GetById(vmId);
                    }
                    catch (Exception)
                    {
                        vm = null;
                    }
                }

                if (vm != null)
                {
                    createdVMs.Add(vm);
                }
            }

            return createdVMs;
        }

        // Print LB info
        public static void PrintLB(ILoadBalancer resource)
        {
            var info = new StringBuilder();
            info.Append("Load balancer: ").Append(resource.Id)
                    .Append("Name: ").Append(resource.Name)
                    .Append("\n\tResource group: ").Append(resource.ResourceGroupName)
                    .Append("\n\tRegion: ").Append(resource.Region)
                    .Append("\n\tTags: ").Append(resource.Tags)
                    .Append("\n\tBackends: ").Append(string.Join(", ", resource.Backends.Keys));

            // Show public IP addresses
            info.Append("\n\tPublic IP address IDs: ")
                .Append(resource.PublicIpAddressIds.Count);
            foreach (string pipId in resource.PublicIpAddressIds)
            {
                info.AppendLine("\n\t\tPIP id: ").Append(pipId);
            }

            // Show TCP probes
            info.Append("\n\tTCP probes: ")
                .Append(resource.TcpProbes.Count);
            foreach (var probe in resource.TcpProbes.Values)
            {
                info.Append("\n\t\tProbe name: ").Append(probe.Name)
                    .Append("\n\t\t\tPort: ").Append(probe.Port)
                    .Append("\n\t\t\tInterval in seconds: ").Append(probe.IntervalInSeconds)
                    .Append("\n\t\t\tRetries before unhealthy: ").Append(probe.NumberOfProbes);

                // Show associated load balancing rules
                info.Append("\n\t\t\tReferenced from load balancing rules: ")
                    .Append(probe.LoadBalancingRules.Count);
                foreach (var rule in probe.LoadBalancingRules.Values)
                {
                    info.Append("\n\t\t\t\tName: ").Append(rule.Name);
                }
            }

            // Show HTTP probes
            info.Append("\n\tHTTP probes: ")
                .Append(resource.HttpProbes.Count);
            foreach (var probe in resource.HttpProbes.Values)
            {
                info.Append("\n\t\tProbe name: ").Append(probe.Name)
                    .Append("\n\t\t\tPort: ").Append(probe.Port)
                    .Append("\n\t\t\tInterval in seconds: ").Append(probe.IntervalInSeconds)
                    .Append("\n\t\t\tRetries before unhealthy: ").Append(probe.NumberOfProbes)
                    .Append("\n\t\t\tHTTP request path: ").Append(probe.RequestPath);

                // Show associated load balancing rules
                info.Append("\n\t\t\tReferenced from load balancing rules: ")
                    .Append(probe.LoadBalancingRules.Count);
                foreach( var rule in probe.LoadBalancingRules.Values)
                {
                    info.Append("\n\t\t\t\tName: ").Append(rule.Name);
                }
            }

            // Show load balancing rules
            info.Append("\n\tLoad balancing rules: ")
                .Append(resource.LoadBalancingRules.Count);
            foreach( var rule in resource.LoadBalancingRules.Values)
            {
                info.Append("\n\t\tLB rule name: ").Append(rule.Name)
                    .Append("\n\t\t\tProtocol: ").Append(rule.Protocol)
                    .Append("\n\t\t\tFloating IP enabled? ").Append(rule.FloatingIpEnabled)
                    .Append("\n\t\t\tIdle timeout in minutes: ").Append(rule.IdleTimeoutInMinutes)
                    .Append("\n\t\t\tLoad distribution method: ").Append(rule.LoadDistribution);

                var frontend = rule.Frontend;
                info.Append("\n\t\t\tFrontend: ");
                if (frontend != null)
                {
                    info.Append(frontend.Name);
                }
                else
                {
                    info.Append("(None)");
                }

                info.Append("\n\t\t\tFrontend port: ").Append(rule.FrontendPort);

                var backend = rule.Backend;
                info.Append("\n\t\t\tBackend: ");
                if (backend != null)
                {
                    info.Append(backend.Name);
                }
                else
                {
                    info.Append("(None)");
                }

                info.Append("\n\t\t\tBackend port: ").Append(rule.BackendPort);

                var probe = rule.Probe;
                info.Append("\n\t\t\tProbe: ");
                if (probe == null)
                {
                    info.Append("(None)");
                }
                else
                {
                    info.Append(probe.Name).Append(" [").Append(probe.Protocol).Append("]");
                }
            }

            // Show frontends
            info.Append("\n\tFrontends: ")
                .Append(resource.Frontends.Count);
            foreach (var frontend in resource.Frontends.Values)
            {
                info.Append("\n\t\tFrontend name: ").Append(frontend.Name)
                    .Append("\n\t\t\tInternet facing: ").Append(frontend.IsPublic);
                if (frontend.IsPublic)
                {
                    info.Append("\n\t\t\tPublic IP Address ID: ").Append(((IPublicFrontend)frontend).PublicIpAddressId);
                }
                else
                {
                    info.Append("\n\t\t\tVirtual network ID: ").Append(((IPrivateFrontend)frontend).NetworkId)
                        .Append("\n\t\t\tSubnet name: ").Append(((IPrivateFrontend)frontend).SubnetName)
                        .Append("\n\t\t\tPrivate IP address: ").Append(((IPrivateFrontend)frontend).PrivateIpAddress)
                        .Append("\n\t\t\tPrivate IP allocation method: ").Append(((IPrivateFrontend)frontend).PrivateIpAllocationMethod);
                }

                // Inbound NAT pool references
                info.Append("\n\t\t\tReferenced inbound NAT pools: ")
                    .Append(frontend.InboundNatPools.Count);
                foreach ( var pool in frontend.InboundNatPools.Values)
                {
                    info.Append("\n\t\t\t\tName: ").Append(pool.Name);
                }

                // Inbound NAT rule references
                info.Append("\n\t\t\tReferenced inbound NAT rules: ")
                    .Append(frontend.InboundNatRules.Count);
                foreach ( var rule in frontend.InboundNatRules.Values)
                {
                    info.Append("\n\t\t\t\tName: ").Append(rule.Name);
                }

                // Load balancing rule references
                info.Append("\n\t\t\tReferenced load balancing rules: ")
                    .Append(frontend.LoadBalancingRules.Count);
                foreach (var rule in frontend.LoadBalancingRules.Values)
                {
                    info.Append("\n\t\t\t\tName: ").Append(rule.Name);
                }
            }

            // Show inbound NAT rules
            info.Append("\n\tInbound NAT rules: ")
                .Append(resource.InboundNatRules.Count);
            foreach (var natRule in resource.InboundNatRules.Values)
            {
                info.Append("\n\t\tInbound NAT rule name: ").Append(natRule.Name)
                    .Append("\n\t\t\tProtocol: ").Append(natRule.Protocol)
                    .Append("\n\t\t\tFrontend: ").Append(natRule.Frontend.Name)
                    .Append("\n\t\t\tFrontend port: ").Append(natRule.FrontendPort)
                    .Append("\n\t\t\tBackend port: ").Append(natRule.BackendPort)
                    .Append("\n\t\t\tBackend NIC ID: ").Append(natRule.BackendNetworkInterfaceId)
                    .Append("\n\t\t\tBackend NIC IP config name: ").Append(natRule.BackendNicIpConfigurationName)
                    .Append("\n\t\t\tFloating IP? ").Append(natRule.FloatingIpEnabled)
                    .Append("\n\t\t\tIdle timeout in minutes: ").Append(natRule.IdleTimeoutInMinutes);
            }

            // Show inbound NAT pools
            info.Append("\n\tInbound NAT pools: ")
                .Append(resource.InboundNatPools.Count);
            foreach (var natPool in resource.InboundNatPools.Values)
            {
                info.Append("\n\t\tInbound NAT pool name: ").Append(natPool.Name)
                    .Append("\n\t\t\tProtocol: ").Append(natPool.Protocol)
                    .Append("\n\t\t\tFrontend: ").Append(natPool.Frontend.Name)
                    .Append("\n\t\t\tFrontend port range: ")
                        .Append(natPool.FrontendPortRangeStart)
                        .Append("-")
                        .Append(natPool.FrontendPortRangeEnd)
                    .Append("\n\t\t\tBackend port: ").Append(natPool.BackendPort);
            }

            // Show backends
            info.Append("\n\tBackends: ")
                .Append(resource.Backends.Count);
            foreach ( var backend in resource.Backends.Values)
            {
                info.Append("\n\t\tBackend name: ").Append(backend.Name);

                // Show assigned backend NICs
                info.Append("\n\t\t\tReferenced NICs: ")
                    .Append(backend.BackendNicIpConfigurationNames.Count);
                foreach ( var entry in backend.BackendNicIpConfigurationNames)
                {
                    info.Append("\n\t\t\t\tNIC ID: ").Append(entry.Key)
                        .Append(" - IP Config: ").Append(entry.Value);
                }

                // Show assigned virtual machines
                var vmIds = backend.GetVirtualMachineIds();
                info.Append("\n\t\t\tReferenced virtual machine ids: ")
                    .Append(vmIds.Count);
                foreach ( var vmId in vmIds)
                {
                    info.Append("\n\t\t\t\tVM ID: ").Append(vmId);
                }

                // Show assigned load balancing rules
                info.Append("\n\t\t\tReferenced load balancing rules: ")
                    .Append( string.Join(", ", backend.LoadBalancingRules.Keys));
            }

            TestHelper.WriteLine(info.ToString());
        }
    }
}
