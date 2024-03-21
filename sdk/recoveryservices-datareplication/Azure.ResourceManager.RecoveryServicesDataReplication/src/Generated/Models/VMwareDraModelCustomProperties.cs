// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> VMware DRA model custom properties. </summary>
    public partial class VMwareDraModelCustomProperties : DraModelCustomProperties
    {
        /// <summary> Initializes a new instance of <see cref="VMwareDraModelCustomProperties"/>. </summary>
        /// <param name="biosId"> Gets or sets the BIOS Id of the DRA machine. </param>
        /// <param name="marsAuthenticationIdentity"> Identity model. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="biosId"/> or <paramref name="marsAuthenticationIdentity"/> is null. </exception>
        public VMwareDraModelCustomProperties(string biosId, DataReplicationIdentity marsAuthenticationIdentity)
        {
            Argument.AssertNotNull(biosId, nameof(biosId));
            Argument.AssertNotNull(marsAuthenticationIdentity, nameof(marsAuthenticationIdentity));

            BiosId = biosId;
            MarsAuthenticationIdentity = marsAuthenticationIdentity;
            InstanceType = "VMware";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareDraModelCustomProperties"/>. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="biosId"> Gets or sets the BIOS Id of the DRA machine. </param>
        /// <param name="marsAuthenticationIdentity"> Identity model. </param>
        internal VMwareDraModelCustomProperties(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string biosId, DataReplicationIdentity marsAuthenticationIdentity) : base(instanceType, serializedAdditionalRawData)
        {
            BiosId = biosId;
            MarsAuthenticationIdentity = marsAuthenticationIdentity;
            InstanceType = instanceType ?? "VMware";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareDraModelCustomProperties"/> for deserialization. </summary>
        internal VMwareDraModelCustomProperties()
        {
        }

        /// <summary> Gets or sets the BIOS Id of the DRA machine. </summary>
        public string BiosId { get; set; }
        /// <summary> Identity model. </summary>
        public DataReplicationIdentity MarsAuthenticationIdentity { get; set; }
    }
}
