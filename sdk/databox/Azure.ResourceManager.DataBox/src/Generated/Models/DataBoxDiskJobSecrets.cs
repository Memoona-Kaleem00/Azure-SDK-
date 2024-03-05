// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.ResourceManager.DataBox;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The secrets related to disk job. </summary>
    public partial class DataBoxDiskJobSecrets : JobSecrets
    {
        /// <summary> Initializes a new instance of <see cref="DataBoxDiskJobSecrets"/>. </summary>
        internal DataBoxDiskJobSecrets()
        {
            DiskSecrets = new ChangeTrackingList<DataBoxDiskSecret>();
            JobSecretsType = DataBoxOrderType.DataBoxDisk;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxDiskJobSecrets"/>. </summary>
        /// <param name="jobSecretsType"> Used to indicate what type of job secrets object. </param>
        /// <param name="dataCenterAccessSecurityCode"> Dc Access Security Code for Customer Managed Shipping. </param>
        /// <param name="error"> Error while fetching the secrets. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="diskSecrets"> Contains the list of secrets object for that device. </param>
        /// <param name="passkey"> PassKey for the disk Job. </param>
        /// <param name="isPasskeyUserDefined"> Whether passkey was provided by user. </param>
        internal DataBoxDiskJobSecrets(DataBoxOrderType jobSecretsType, DataCenterAccessSecurityCode dataCenterAccessSecurityCode, ResponseError error, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<DataBoxDiskSecret> diskSecrets, string passkey, bool? isPasskeyUserDefined) : base(jobSecretsType, dataCenterAccessSecurityCode, error, serializedAdditionalRawData)
        {
            DiskSecrets = diskSecrets;
            Passkey = passkey;
            IsPasskeyUserDefined = isPasskeyUserDefined;
            JobSecretsType = jobSecretsType;
        }

        /// <summary> Contains the list of secrets object for that device. </summary>
        public IReadOnlyList<DataBoxDiskSecret> DiskSecrets { get; }
        /// <summary> PassKey for the disk Job. </summary>
        public string Passkey { get; }
        /// <summary> Whether passkey was provided by user. </summary>
        public bool? IsPasskeyUserDefined { get; }
    }
}
