// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> Settings for SMB protocol. </summary>
    public partial class ShareSmbSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ShareSmbSettings"/>. </summary>
        /// <param name="multichannel"> Settings for SMB Multichannel. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ShareSmbSettings(SmbMultichannel multichannel, Dictionary<string, BinaryData> rawData)
        {
            Multichannel = multichannel;
            _rawData = rawData;
        }

        /// <summary> Settings for SMB Multichannel. </summary>
        public SmbMultichannel Multichannel { get; set; }
    }
}
