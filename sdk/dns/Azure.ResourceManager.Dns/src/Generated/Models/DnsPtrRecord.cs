// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Dns.Models
{
    /// <summary> A PTR record. </summary>
    public partial class DnsPtrRecord
    {
        /// <summary> Initializes a new instance of DnsPtrRecord. </summary>
        public DnsPtrRecord()
        {
        }

        /// <summary> Initializes a new instance of DnsPtrRecord. </summary>
        /// <param name="dnsPtrDomainName"> The PTR target domain name for this PTR record. </param>
        internal DnsPtrRecord(string dnsPtrDomainName)
        {
            DnsPtrDomainName = dnsPtrDomainName;
        }

        /// <summary> The PTR target domain name for this PTR record. </summary>
        public string DnsPtrDomainName { get; set; }
    }
}
