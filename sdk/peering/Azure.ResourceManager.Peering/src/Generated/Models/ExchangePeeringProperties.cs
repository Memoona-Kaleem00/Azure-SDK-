// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The properties that define an exchange peering. </summary>
    public partial class ExchangePeeringProperties
    {
        /// <summary> Initializes a new instance of ExchangePeeringProperties. </summary>
        public ExchangePeeringProperties()
        {
            Connections = new Core.ChangeTrackingList<PeeringExchangeConnection>();
        }

        /// <summary> Initializes a new instance of ExchangePeeringProperties. </summary>
        /// <param name="connections"> The set of connections that constitute an exchange peering. </param>
        /// <param name="peerAsn"> The reference of the peer ASN. </param>
        internal ExchangePeeringProperties(IList<PeeringExchangeConnection> connections, WritableSubResource peerAsn)
        {
            Connections = connections;
            PeerAsn = peerAsn;
        }

        /// <summary> The set of connections that constitute an exchange peering. </summary>
        public IList<PeeringExchangeConnection> Connections { get; }
        /// <summary> The reference of the peer ASN. </summary>
        internal WritableSubResource PeerAsn { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PeerAsnId
        {
            get => PeerAsn is null ? default : PeerAsn.Id;
            set
            {
                if (PeerAsn is null)
                    PeerAsn = new WritableSubResource();
                PeerAsn.Id = value;
            }
        }
    }
}
