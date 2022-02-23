// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region DnsResolver
        /// <summary> Gets an object representing a DnsResolver along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DnsResolver" /> object. </returns>
        public static DnsResolver GetDnsResolver(this ArmClient armClient, ResourceIdentifier id)
        {
            DnsResolver.ValidateResourceId(id);
            return new DnsResolver(armClient, id);
        }
        #endregion

        #region InboundEndpoint
        /// <summary> Gets an object representing a InboundEndpoint along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="InboundEndpoint" /> object. </returns>
        public static InboundEndpoint GetInboundEndpoint(this ArmClient armClient, ResourceIdentifier id)
        {
            InboundEndpoint.ValidateResourceId(id);
            return new InboundEndpoint(armClient, id);
        }
        #endregion

        #region OutboundEndpoint
        /// <summary> Gets an object representing a OutboundEndpoint along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OutboundEndpoint" /> object. </returns>
        public static OutboundEndpoint GetOutboundEndpoint(this ArmClient armClient, ResourceIdentifier id)
        {
            OutboundEndpoint.ValidateResourceId(id);
            return new OutboundEndpoint(armClient, id);
        }
        #endregion

        #region DnsForwardingRuleset
        /// <summary> Gets an object representing a DnsForwardingRuleset along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DnsForwardingRuleset" /> object. </returns>
        public static DnsForwardingRuleset GetDnsForwardingRuleset(this ArmClient armClient, ResourceIdentifier id)
        {
            DnsForwardingRuleset.ValidateResourceId(id);
            return new DnsForwardingRuleset(armClient, id);
        }
        #endregion

        #region ForwardingRule
        /// <summary> Gets an object representing a ForwardingRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ForwardingRule" /> object. </returns>
        public static ForwardingRule GetForwardingRule(this ArmClient armClient, ResourceIdentifier id)
        {
            ForwardingRule.ValidateResourceId(id);
            return new ForwardingRule(armClient, id);
        }
        #endregion

        #region VirtualNetworkLink
        /// <summary> Gets an object representing a VirtualNetworkLink along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualNetworkLink" /> object. </returns>
        public static VirtualNetworkLink GetVirtualNetworkLink(this ArmClient armClient, ResourceIdentifier id)
        {
            VirtualNetworkLink.ValidateResourceId(id);
            return new VirtualNetworkLink(armClient, id);
        }
        #endregion
    }
}
