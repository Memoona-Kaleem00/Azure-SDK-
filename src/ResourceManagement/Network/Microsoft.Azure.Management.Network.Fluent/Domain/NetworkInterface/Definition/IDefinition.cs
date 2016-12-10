// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition
{
    using Microsoft.Azure.Management.Network.Fluent;
    using Microsoft.Azure.Management.Resource.Fluent.Core.ResourceActions;
    using Microsoft.Azure.Management.Network.Fluent.NicIpConfiguration.Definition;
    using Microsoft.Azure.Management.Resource.Fluent.Core.GroupableResource.Definition;
    using Microsoft.Azure.Management.Resource.Fluent.Core.Resource.Definition;

    /// <summary>
    /// The stage of the network interface definition allowing to specify subnet.
    /// </summary>
    public interface IWithPrimaryNetworkSubnet 
    {
        /// <summary>
        /// Associate a subnet with the network interface's primary IP configuration.
        /// </summary>
        /// <param name="name">The subnet name.</param>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithPrimaryPrivateIp WithSubnet(string name);
    }

    /// <summary>
    /// The stage of the network interface definition allowing to specify private IP address within
    /// a virtual network subnet.
    /// </summary>
    public interface IWithPrimaryPrivateIp 
    {
        /// <summary>
        /// Enables dynamic private IP address allocation within the specified existing virtual network
        /// subnet for the network interface's primary IP configuration.
        /// </summary>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithCreate WithPrimaryPrivateIpAddressDynamic();

        /// <summary>
        /// Assigns the specified static private IP address within the specified existing virtual network
        /// subnet to the network interface's primary IP configuration.
        /// </summary>
        /// <param name="staticPrivateIpAddress">
        /// The static IP address within the specified subnet to assign to
        /// the network interface.
        /// </param>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithCreate WithPrimaryPrivateIpAddressStatic(string staticPrivateIpAddress);
    }

    /// <summary>
    /// The stage of the network interface definition allowing to associate a network security group.
    /// </summary>
    public interface IWithNetworkSecurityGroup 
    {
        /// <summary>
        /// Create a new network security group to associate with network interface, based on the provided definition.
        /// </summary>
        /// <param name="creatable">A creatable definition for a new network security group.</param>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithCreate WithNewNetworkSecurityGroup(ICreatable<Microsoft.Azure.Management.Network.Fluent.INetworkSecurityGroup> creatable);

        /// <summary>
        /// Associates an existing network security group with the network interface.
        /// </summary>
        /// <param name="networkSecurityGroup">An existing network security group.</param>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithCreate WithExistingNetworkSecurityGroup(INetworkSecurityGroup networkSecurityGroup);
    }

    /// <summary>
    /// The stage of the network interface definition allowing to associate a secondary IP configurations.
    /// </summary>
    public interface IWithSecondaryIpConfiguration 
    {
        /// <summary>
        /// Starts definition of a secondary IP configuration.
        /// </summary>
        /// <param name="name">Name for the IP configuration.</param>
        Microsoft.Azure.Management.Network.Fluent.NicIpConfiguration.Definition.IBlank<Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithCreate> DefineSecondaryIpConfiguration(string name);
    }

    /// <summary>
    /// The stage of the network interface definition allowing to specify the virtual network for
    /// primary IP configuration.
    /// </summary>
    public interface IWithPrimaryNetwork 
    {
        /// <summary>
        /// Associate an existing virtual network with the network interface's primary IP configuration.
        /// </summary>
        /// <param name="network">An existing virtual network.</param>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithPrimaryNetworkSubnet WithExistingPrimaryNetwork(INetwork network);

        /// <summary>
        /// Create a new virtual network to associate with the network interface's primary IP configuration,
        /// based on the provided definition.
        /// </summary>
        /// <param name="creatable">A creatable definition for a new virtual network.</param>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithPrimaryPrivateIp WithNewPrimaryNetwork(ICreatable<Microsoft.Azure.Management.Network.Fluent.INetwork> creatable);

        /// <summary>
        /// Creates a new virtual network to associate with the network interface's primary IP configuration.
        /// <p>
        /// The virtual network will be created in the same resource group and region as of network interface,
        /// it will be created with the specified address space and a default subnet covering the entirety of
        /// the network IP address space.
        /// </summary>
        /// <param name="name">The name of the new virtual network.</param>
        /// <param name="addressSpace">The address space for rhe virtual network.</param>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithPrimaryPrivateIp WithNewPrimaryNetwork(string name, string addressSpace);

        /// <summary>
        /// Creates a new virtual network to associate with the network interface's primary IP configuration.
        /// <p>
        /// The virtual network will be created in the same resource group and region as of network interface,
        /// it will be created with the specified address space and a default subnet covering the entirety of
        /// the network IP address space.
        /// </summary>
        /// <param name="addressSpace">The address space for the virtual network.</param>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithPrimaryPrivateIp WithNewPrimaryNetwork(string addressSpace);
    }

    /// <summary>
    /// The stage of the network interface definition allowing to associate public IP address with it's primary
    /// IP configuration.
    /// </summary>
    public interface IWithPrimaryPublicIpAddress 
    {
        /// <summary>
        /// Create a new public IP address to associate with network interface's primary IP configuration, based on
        /// the provided definition.
        /// </summary>
        /// <param name="creatable">A creatable definition for a new public IP.</param>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithCreate WithNewPrimaryPublicIpAddress(ICreatable<Microsoft.Azure.Management.Network.Fluent.IPublicIpAddress> creatable);

        /// <summary>
        /// Creates a new public IP address in the same region and group as the resource and associate it
        /// with the network interface's primary IP configuration.
        /// <p>
        /// the internal name and DNS label for the public IP address will be derived from the network interface name.
        /// </summary>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithCreate WithNewPrimaryPublicIpAddress();

        /// <summary>
        /// Creates a new public IP address in the same region and group as the resource, with the specified DNS label
        /// and associate it with the network interface's primary IP configuration.
        /// <p>
        /// the internal name for the public IP address will be derived from the DNS label.
        /// </summary>
        /// <param name="leafDnsLabel">The leaf domain label.</param>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithCreate WithNewPrimaryPublicIpAddress(string leafDnsLabel);

        /// <summary>
        /// Associates an existing public IP address with the network interface's primary IP configuration.
        /// </summary>
        /// <param name="publicIpAddress">An existing public IP address.</param>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithCreate WithExistingPrimaryPublicIpAddress(IPublicIpAddress publicIpAddress);
    }

    /// <summary>
    /// The entirety of the network interface definition.
    /// </summary>
    public interface IDefinition  :
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IBlank,
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithGroup,
        IWithPrimaryNetwork,
        IWithPrimaryNetworkSubnet,
        IWithPrimaryPrivateIp,
        IWithCreate
    {
    }

    /// <summary>
    /// The stage of the network interface definition allowing to specify the resource group.
    /// </summary>
    public interface IWithGroup  :
        Microsoft.Azure.Management.Resource.Fluent.Core.GroupableResource.Definition.IWithGroup<Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithPrimaryNetwork>
    {
    }

    /// <summary>
    /// The stage of the network interface definition which contains all the minimum required inputs for
    /// the resource to be created (via WithCreate.create()), but also allows
    /// for any other optional settings to be specified.
    /// </summary>
    public interface IWithCreate  :
        ICreatable<Microsoft.Azure.Management.Network.Fluent.INetworkInterface>,
        IDefinitionWithTags<Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithCreate>,
        IWithPrimaryPublicIpAddress,
        IWithNetworkSecurityGroup,
        IWithSecondaryIpConfiguration,
        IWithLoadBalancer
    {
        /// <summary>
        /// Specifies the internal DNS name label for the network interface.
        /// </summary>
        /// <param name="dnsNameLabel">The internal DNS name label.</param>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithCreate WithInternalDnsNameLabel(string dnsNameLabel);

        /// <summary>
        /// Specifies the IP address of the custom DNS server to associate with the network interface.
        /// <p>
        /// Note this method's effect is additive, i.e. each time it is used, the new dns server is
        /// added to the network interface.
        /// </summary>
        /// <param name="ipAddress">The IP address of the DNS server.</param>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithCreate WithDnsServer(string ipAddress);

        /// <summary>
        /// Enable IP forwarding in the network interface.
        /// </summary>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithCreate WithIpForwarding();
    }

    /// <summary>
    /// The first stage of the network interface.
    /// </summary>
    public interface IBlank  :
        IDefinitionWithRegion<Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithGroup>
    {
    }

    /// <summary>
    /// The stage of the network interface definition allowing to associate it with a load balancer.
    /// </summary>
    public interface IWithLoadBalancer 
    {
        /// <summary>
        /// Associates the network interface's primary IP configuration with a backend of an existing load balancer.
        /// </summary>
        /// <param name="loadBalancer">An existing load balancer.</param>
        /// <param name="backendName">The name of an existing backend on that load balancer.</param>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithCreate WithExistingLoadBalancerBackend(ILoadBalancer loadBalancer, string backendName);

        /// <summary>
        /// Associates the network interface's primary IP configuration with an inbound NAT rule of an existing load balancer.
        /// </summary>
        /// <param name="loadBalancer">An existing load balancer.</param>
        /// <param name="inboundNatRuleName">The name of an existing inbound NAT rule on the selected load balancer.</param>
        Microsoft.Azure.Management.Network.Fluent.NetworkInterface.Definition.IWithCreate WithExistingLoadBalancerInboundNatRule(ILoadBalancer loadBalancer, string inboundNatRuleName);
    }
}