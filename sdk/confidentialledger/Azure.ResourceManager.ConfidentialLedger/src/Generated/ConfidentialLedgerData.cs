// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ConfidentialLedger.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ConfidentialLedger
{
    /// <summary>
    /// A class representing the ConfidentialLedger data model.
    /// Confidential Ledger. Contains the properties of Confidential Ledger Resource.
    /// </summary>
    public partial class ConfidentialLedgerData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ConfidentialLedgerData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ConfidentialLedgerData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConfidentialLedgerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Properties of Confidential Ledger Resource. </param>
        internal ConfidentialLedgerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ConfidentialLedgerProperties properties) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
        }

        /// <summary> Properties of Confidential Ledger Resource. </summary>
        public ConfidentialLedgerProperties Properties { get; set; }
    }
}
