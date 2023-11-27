// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the PolicySignaturesOverridesForIdps data model.
    /// Contains all specific policy signatures overrides for the IDPS
    /// </summary>
    public partial class PolicySignaturesOverridesForIdpsData
    {
        /// <summary> Initializes a new instance of <see cref="PolicySignaturesOverridesForIdpsData"/>. </summary>
        public PolicySignaturesOverridesForIdpsData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PolicySignaturesOverridesForIdpsData"/>. </summary>
        /// <param name="name"> Contains the name of the resource (default). </param>
        /// <param name="id"> Will contain the resource id of the signature override resource. </param>
        /// <param name="resourceType"> Will contain the type of the resource: Microsoft.Network/firewallPolicies/intrusionDetectionSignaturesOverrides. </param>
        /// <param name="properties"> Will contain the properties of the resource (the actual signature overrides). </param>
        internal PolicySignaturesOverridesForIdpsData(string name, ResourceIdentifier id, ResourceType? resourceType, PolicySignaturesOverridesForIdpsProperties properties)
        {
            Name = name;
            Id = id;
            ResourceType = resourceType;
            Properties = properties;
        }

        /// <summary> Contains the name of the resource (default). </summary>
        public string Name { get; set; }
        /// <summary> Will contain the resource id of the signature override resource. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> Will contain the type of the resource: Microsoft.Network/firewallPolicies/intrusionDetectionSignaturesOverrides. </summary>
        public ResourceType? ResourceType { get; set; }
        /// <summary> Will contain the properties of the resource (the actual signature overrides). </summary>
        internal PolicySignaturesOverridesForIdpsProperties Properties { get; set; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Signatures
        {
            get
            {
                if (Properties is null)
                    Properties = new PolicySignaturesOverridesForIdpsProperties();
                return Properties.Signatures;
            }
        }
    }
}
