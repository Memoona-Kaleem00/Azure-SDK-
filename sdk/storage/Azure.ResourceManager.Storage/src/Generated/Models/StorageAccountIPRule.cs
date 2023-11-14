// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> IP rule with specific IP or IP range in CIDR format. </summary>
    public partial class StorageAccountIPRule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageAccountIPRule"/>. </summary>
        /// <param name="ipAddressOrRange"> Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAddressOrRange"/> is null. </exception>
        public StorageAccountIPRule(string ipAddressOrRange)
        {
            Argument.AssertNotNull(ipAddressOrRange, nameof(ipAddressOrRange));

            IPAddressOrRange = ipAddressOrRange;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountIPRule"/>. </summary>
        /// <param name="ipAddressOrRange"> Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed. </param>
        /// <param name="action"> The action of IP ACL rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountIPRule(string ipAddressOrRange, StorageAccountNetworkRuleAction? action, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPAddressOrRange = ipAddressOrRange;
            Action = action;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountIPRule"/> for deserialization. </summary>
        internal StorageAccountIPRule()
        {
        }

        /// <summary> Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed. </summary>
        public string IPAddressOrRange { get; set; }
        /// <summary> The action of IP ACL rule. </summary>
        public StorageAccountNetworkRuleAction? Action { get; set; }
    }
}
