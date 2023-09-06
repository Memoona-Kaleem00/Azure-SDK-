// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The supported disk size details for a disk type. </summary>
    public partial class SupportedConfigurationsDiskDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SupportedConfigurationsDiskDetails"/>. </summary>
        internal SupportedConfigurationsDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SupportedConfigurationsDiskDetails"/>. </summary>
        /// <param name="sku"> The type of disk sku. For example, Standard_LRS, Standard_ZRS, Premium_LRS, Premium_ZRS. </param>
        /// <param name="sizeInGB"> The disk size in GB. </param>
        /// <param name="minimumSupportedDiskCount"> The minimum supported disk count. </param>
        /// <param name="maximumSupportedDiskCount"> The maximum supported disk count. </param>
        /// <param name="iopsReadWrite"> The disk Iops. </param>
        /// <param name="mbpsReadWrite"> The disk provisioned throughput in MBps. </param>
        /// <param name="diskTier"> The disk tier, e.g. P10, E10. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SupportedConfigurationsDiskDetails(SapDiskSku sku, long? sizeInGB, long? minimumSupportedDiskCount, long? maximumSupportedDiskCount, long? iopsReadWrite, long? mbpsReadWrite, string diskTier, Dictionary<string, BinaryData> rawData)
        {
            Sku = sku;
            SizeInGB = sizeInGB;
            MinimumSupportedDiskCount = minimumSupportedDiskCount;
            MaximumSupportedDiskCount = maximumSupportedDiskCount;
            IopsReadWrite = iopsReadWrite;
            MbpsReadWrite = mbpsReadWrite;
            DiskTier = diskTier;
            _rawData = rawData;
        }

        /// <summary> The type of disk sku. For example, Standard_LRS, Standard_ZRS, Premium_LRS, Premium_ZRS. </summary>
        internal SapDiskSku Sku { get; }
        /// <summary> Defines the disk sku name. </summary>
        public DiskDetailsDiskSkuName? SkuName
        {
            get => Sku?.Name;
        }

        /// <summary> The disk size in GB. </summary>
        public long? SizeInGB { get; }
        /// <summary> The minimum supported disk count. </summary>
        public long? MinimumSupportedDiskCount { get; }
        /// <summary> The maximum supported disk count. </summary>
        public long? MaximumSupportedDiskCount { get; }
        /// <summary> The disk Iops. </summary>
        public long? IopsReadWrite { get; }
        /// <summary> The disk provisioned throughput in MBps. </summary>
        public long? MbpsReadWrite { get; }
        /// <summary> The disk tier, e.g. P10, E10. </summary>
        public string DiskTier { get; }
    }
}
