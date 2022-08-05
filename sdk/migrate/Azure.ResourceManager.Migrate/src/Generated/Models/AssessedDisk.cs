// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> A disk assessed for an assessment. </summary>
    public partial class AssessedDisk
    {
        /// <summary> Initializes a new instance of AssessedDisk. </summary>
        internal AssessedDisk()
        {
        }

        /// <summary> Initializes a new instance of AssessedDisk. </summary>
        /// <param name="name"> Name of the assessed disk. </param>
        /// <param name="displayName"> User friendly name of the assessed disk. </param>
        /// <param name="gigabytesProvisioned"> Gigabytes of storage provisioned for this disk. </param>
        /// <param name="megabytesPerSecondOfRead"> Disk throughput in MegaBytes per second. </param>
        /// <param name="megabytesPerSecondOfWrite"> Disk throughput in MegaBytes per second. </param>
        /// <param name="numberOfReadOperationsPerSecond"> Number of read operations per second for the disk. </param>
        /// <param name="numberOfWriteOperationsPerSecond"> Number of read and write operations per second for the disk. </param>
        /// <param name="monthlyStorageCost"> Estimated aggregate storage cost for a 31-day month for this disk. </param>
        /// <param name="recommendedDiskType"> Storage type selected for this disk. </param>
        /// <param name="recommendedDiskSize"> Recommended Azure size for the disk, given utilization data and preferences set on Assessment. </param>
        /// <param name="gigabytesForRecommendedDiskSize"> Gigabytes of storage provided by the recommended Azure disk size. </param>
        /// <param name="suitability"> Whether this disk is suitable for Azure. </param>
        /// <param name="suitabilityExplanation"> If disk is not suitable to be migrated, this explains the reasons and mitigation steps. </param>
        /// <param name="suitabilityDetail"> If disk is suitable to be migrate but some conditions/checks were not considered while calculating suitability, this explains the details. </param>
        internal AssessedDisk(string name, string displayName, double? gigabytesProvisioned, double? megabytesPerSecondOfRead, double? megabytesPerSecondOfWrite, double? numberOfReadOperationsPerSecond, double? numberOfWriteOperationsPerSecond, double? monthlyStorageCost, AzureDiskType? recommendedDiskType, AzureDiskSize? recommendedDiskSize, int? gigabytesForRecommendedDiskSize, CloudSuitability? suitability, AzureDiskSuitabilityExplanation? suitabilityExplanation, AzureDiskSuitabilityDetail? suitabilityDetail)
        {
            Name = name;
            DisplayName = displayName;
            GigabytesProvisioned = gigabytesProvisioned;
            MegabytesPerSecondOfRead = megabytesPerSecondOfRead;
            MegabytesPerSecondOfWrite = megabytesPerSecondOfWrite;
            NumberOfReadOperationsPerSecond = numberOfReadOperationsPerSecond;
            NumberOfWriteOperationsPerSecond = numberOfWriteOperationsPerSecond;
            MonthlyStorageCost = monthlyStorageCost;
            RecommendedDiskType = recommendedDiskType;
            RecommendedDiskSize = recommendedDiskSize;
            GigabytesForRecommendedDiskSize = gigabytesForRecommendedDiskSize;
            Suitability = suitability;
            SuitabilityExplanation = suitabilityExplanation;
            SuitabilityDetail = suitabilityDetail;
        }

        /// <summary> Name of the assessed disk. </summary>
        public string Name { get; }
        /// <summary> User friendly name of the assessed disk. </summary>
        public string DisplayName { get; }
        /// <summary> Gigabytes of storage provisioned for this disk. </summary>
        public double? GigabytesProvisioned { get; }
        /// <summary> Disk throughput in MegaBytes per second. </summary>
        public double? MegabytesPerSecondOfRead { get; }
        /// <summary> Disk throughput in MegaBytes per second. </summary>
        public double? MegabytesPerSecondOfWrite { get; }
        /// <summary> Number of read operations per second for the disk. </summary>
        public double? NumberOfReadOperationsPerSecond { get; }
        /// <summary> Number of read and write operations per second for the disk. </summary>
        public double? NumberOfWriteOperationsPerSecond { get; }
        /// <summary> Estimated aggregate storage cost for a 31-day month for this disk. </summary>
        public double? MonthlyStorageCost { get; }
        /// <summary> Storage type selected for this disk. </summary>
        public AzureDiskType? RecommendedDiskType { get; }
        /// <summary> Recommended Azure size for the disk, given utilization data and preferences set on Assessment. </summary>
        public AzureDiskSize? RecommendedDiskSize { get; }
        /// <summary> Gigabytes of storage provided by the recommended Azure disk size. </summary>
        public int? GigabytesForRecommendedDiskSize { get; }
        /// <summary> Whether this disk is suitable for Azure. </summary>
        public CloudSuitability? Suitability { get; }
        /// <summary> If disk is not suitable to be migrated, this explains the reasons and mitigation steps. </summary>
        public AzureDiskSuitabilityExplanation? SuitabilityExplanation { get; }
        /// <summary> If disk is suitable to be migrate but some conditions/checks were not considered while calculating suitability, this explains the details. </summary>
        public AzureDiskSuitabilityDetail? SuitabilityDetail { get; }
    }
}
