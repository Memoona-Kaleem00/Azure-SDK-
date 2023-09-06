// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> An object that wraps the blob inventory rule. Each rule is uniquely defined by name. </summary>
    public partial class BlobInventoryPolicyRule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BlobInventoryPolicyRule"/>. </summary>
        /// <param name="isEnabled"> Rule is enabled when set to true. </param>
        /// <param name="name"> A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy. </param>
        /// <param name="destination"> Container name where blob inventory files are stored. Must be pre-created. </param>
        /// <param name="definition"> An object that defines the blob inventory policy rule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="destination"/> or <paramref name="definition"/> is null. </exception>
        public BlobInventoryPolicyRule(bool isEnabled, string name, string destination, BlobInventoryPolicyDefinition definition)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(destination, nameof(destination));
            Argument.AssertNotNull(definition, nameof(definition));

            IsEnabled = isEnabled;
            Name = name;
            Destination = destination;
            Definition = definition;
        }

        /// <summary> Initializes a new instance of <see cref="BlobInventoryPolicyRule"/>. </summary>
        /// <param name="isEnabled"> Rule is enabled when set to true. </param>
        /// <param name="name"> A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy. </param>
        /// <param name="destination"> Container name where blob inventory files are stored. Must be pre-created. </param>
        /// <param name="definition"> An object that defines the blob inventory policy rule. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobInventoryPolicyRule(bool isEnabled, string name, string destination, BlobInventoryPolicyDefinition definition, Dictionary<string, BinaryData> rawData)
        {
            IsEnabled = isEnabled;
            Name = name;
            Destination = destination;
            Definition = definition;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="BlobInventoryPolicyRule"/> for deserialization. </summary>
        internal BlobInventoryPolicyRule()
        {
        }

        /// <summary> Rule is enabled when set to true. </summary>
        public bool IsEnabled { get; set; }
        /// <summary> A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy. </summary>
        public string Name { get; set; }
        /// <summary> Container name where blob inventory files are stored. Must be pre-created. </summary>
        public string Destination { get; set; }
        /// <summary> An object that defines the blob inventory policy rule. </summary>
        public BlobInventoryPolicyDefinition Definition { get; set; }
    }
}
