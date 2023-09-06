// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> Settings for SMB multichannel. </summary>
    public partial class SmbMultichannel
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SmbMultichannel"/>. </summary>
        public SmbMultichannel()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SmbMultichannel"/>. </summary>
        /// <param name="enabled"> If SMB multichannel is enabled. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SmbMultichannel(bool? enabled, Dictionary<string, BinaryData> rawData)
        {
            Enabled = enabled;
            _rawData = rawData;
        }

        /// <summary> If SMB multichannel is enabled. </summary>
        public bool? Enabled { get; set; }
    }
}
