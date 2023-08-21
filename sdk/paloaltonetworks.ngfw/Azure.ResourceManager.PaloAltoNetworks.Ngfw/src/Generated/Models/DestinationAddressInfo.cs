// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> destination address. </summary>
    public partial class DestinationAddressInfo
    {
        /// <summary> Initializes a new instance of DestinationAddressInfo. </summary>
        public DestinationAddressInfo()
        {
            Cidrs = new Core.ChangeTrackingList<string>();
            Countries = new Core.ChangeTrackingList<string>();
            Feeds = new Core.ChangeTrackingList<string>();
            PrefixLists = new Core.ChangeTrackingList<string>();
            FqdnLists = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DestinationAddressInfo. </summary>
        /// <param name="cidrs"> special value 'any'. </param>
        /// <param name="countries"> list of countries. </param>
        /// <param name="feeds"> list of feeds. </param>
        /// <param name="prefixLists"> prefix list. </param>
        /// <param name="fqdnLists"> fqdn list. </param>
        internal DestinationAddressInfo(IList<string> cidrs, IList<string> countries, IList<string> feeds, IList<string> prefixLists, IList<string> fqdnLists)
        {
            Cidrs = cidrs;
            Countries = countries;
            Feeds = feeds;
            PrefixLists = prefixLists;
            FqdnLists = fqdnLists;
        }

        /// <summary> special value 'any'. </summary>
        public IList<string> Cidrs { get; }
        /// <summary> list of countries. </summary>
        public IList<string> Countries { get; }
        /// <summary> list of feeds. </summary>
        public IList<string> Feeds { get; }
        /// <summary> prefix list. </summary>
        public IList<string> PrefixLists { get; }
        /// <summary> fqdn list. </summary>
        public IList<string> FqdnLists { get; }
    }
}
