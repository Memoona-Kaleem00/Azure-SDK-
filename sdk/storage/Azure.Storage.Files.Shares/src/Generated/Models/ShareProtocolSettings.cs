// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> Protocol settings. </summary>
    public partial class ShareProtocolSettings
    {

        /// <summary> Initializes a new instance of ShareProtocolSettings. </summary>
        /// <param name="smb"> Settings for SMB protocol. </param>
        internal ShareProtocolSettings(ShareSmbSettings smb)
        {
            Smb = smb;
        }

        /// <summary> Settings for SMB protocol. </summary>
        public ShareSmbSettings Smb { get; set; }
    }
}
