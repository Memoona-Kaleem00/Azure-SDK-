// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The ONVIF device DNS properties. </summary>
    public partial class OnvifDns
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OnvifDns"/>. </summary>
        public OnvifDns()
        {
            Ipv4Address = new ChangeTrackingList<string>();
            Ipv6Address = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="OnvifDns"/>. </summary>
        /// <param name="fromDhcp"> Result value showing if the ONVIF device is configured to use DHCP. </param>
        /// <param name="ipv4Address"> An array of IPv4 address for the discovered ONVIF device. </param>
        /// <param name="ipv6Address"> An array of IPv6 address for the discovered ONVIF device. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OnvifDns(bool? fromDhcp, IList<string> ipv4Address, IList<string> ipv6Address, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FromDhcp = fromDhcp;
            Ipv4Address = ipv4Address;
            Ipv6Address = ipv6Address;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Result value showing if the ONVIF device is configured to use DHCP. </summary>
        public bool? FromDhcp { get; set; }
        /// <summary> An array of IPv4 address for the discovered ONVIF device. </summary>
        public IList<string> Ipv4Address { get; }
        /// <summary> An array of IPv6 address for the discovered ONVIF device. </summary>
        public IList<string> Ipv6Address { get; }
    }
}
