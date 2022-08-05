// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Properties of an assessed machine. </summary>
    public partial class AssessedMachineProperties
    {
        /// <summary> Initializes a new instance of AssessedMachineProperties. </summary>
        internal AssessedMachineProperties()
        {
            Disks = new ChangeTrackingDictionary<string, AssessedDisk>();
            NetworkAdapters = new ChangeTrackingDictionary<string, AssessedNetworkAdapter>();
        }

        /// <summary> Initializes a new instance of AssessedMachineProperties. </summary>
        /// <param name="bootType"> Boot type of the machine. </param>
        /// <param name="datacenterMachineArmId"> ARM ID of the discovered machine. </param>
        /// <param name="datacenterManagementServerArmId"> ARM ID of the discovered datacenter. </param>
        /// <param name="datacenterManagementServerName"> Name of the server hosting the datacenter management solution. </param>
        /// <param name="description"> Description of the machine. </param>
        /// <param name="displayName"> User readable name of the machine as defined by the user in their private datacenter. </param>
        /// <param name="megabytesOfMemory"> Memory in Megabytes. </param>
        /// <param name="numberOfCores"> Processor count. </param>
        /// <param name="operatingSystemType"> Operating System type of the machine. </param>
        /// <param name="operatingSystemName"> Operating System name of the machine. </param>
        /// <param name="operatingSystemVersion"> Operating System version of the machine. </param>
        /// <param name="monthlyBandwidthCost"> Monthly network cost estimate for the network adapters that are attached to this machine as a group, for a 31-day month. </param>
        /// <param name="monthlyStorageCost"> Monthly storage cost estimate for the disks that are attached to this machine as a group, for a 31-day month. </param>
        /// <param name="monthlyPremiumStorageCost"> Monthly premium storage cost estimate for the disks that are attached to this machine as a group, for a 31-day month. </param>
        /// <param name="monthlyStandardSSDStorageCost"> Monthly standard SSD storage cost estimate for the disks that are attached to this machine as a group, for a 31-day month. </param>
        /// <param name="confidenceRatingInPercentage"> Confidence rating of assessed machine. </param>
        /// <param name="disks"> Dictionary of disks attached to the machine. Key is ID of disk. Value is a disk object. </param>
        /// <param name="networkAdapters"> Dictionary of network adapters attached to the machine. Key is name of the adapter. Value is a network adapter object. </param>
        /// <param name="recommendedSize"> Recommended Azure size for this machine. </param>
        /// <param name="numberOfCoresForRecommendedSize"> Number of CPU cores in the Recommended Azure VM Size. </param>
        /// <param name="megabytesOfMemoryForRecommendedSize"> Megabytes of memory in the Recommended Azure VM Size. </param>
        /// <param name="monthlyComputeCostForRecommendedSize"> Compute Cost for a 31-day month, if the machine is migrated to Azure with the Recommended Size. </param>
        /// <param name="percentageCoresUtilization"> Utilization percentage of the processor core as observed in the private data center, in the Time Range selected on Assessment, reported as the Percentile value based on the percentile number selected in assessment. </param>
        /// <param name="percentageMemoryUtilization"> Utilization percentage of the memory as observed in the private data center, in the Time Range selected on Assessment, reported as the Percentile value based on the percentile number selected in assessment. </param>
        /// <param name="suitability"> Whether machine is suitable for migration to Azure. </param>
        /// <param name="suitabilityExplanation"> If machine is not ready to be migrated, this explains the reasons and mitigation steps. </param>
        /// <param name="suitabilityDetail"> If machine is not suitable for cloud, this explains the reasons. </param>
        /// <param name="createdTimestamp"> Time when this machine was created. Date-Time represented in ISO-8601 format. </param>
        /// <param name="updatedTimestamp"> Time when this machine was last updated. Date-Time represented in ISO-8601 format. </param>
        internal AssessedMachineProperties(MachineBootType? bootType, string datacenterMachineArmId, string datacenterManagementServerArmId, string datacenterManagementServerName, string description, string displayName, double? megabytesOfMemory, int? numberOfCores, string operatingSystemType, string operatingSystemName, string operatingSystemVersion, double? monthlyBandwidthCost, double? monthlyStorageCost, double? monthlyPremiumStorageCost, double? monthlyStandardSSDStorageCost, double? confidenceRatingInPercentage, IReadOnlyDictionary<string, AssessedDisk> disks, IReadOnlyDictionary<string, AssessedNetworkAdapter> networkAdapters, AzureVmSize? recommendedSize, int? numberOfCoresForRecommendedSize, double? megabytesOfMemoryForRecommendedSize, double? monthlyComputeCostForRecommendedSize, double? percentageCoresUtilization, double? percentageMemoryUtilization, CloudSuitability? suitability, AzureVmSuitabilityExplanation? suitabilityExplanation, AzureVmSuitabilityDetail? suitabilityDetail, DateTimeOffset? createdTimestamp, DateTimeOffset? updatedTimestamp)
        {
            BootType = bootType;
            DatacenterMachineArmId = datacenterMachineArmId;
            DatacenterManagementServerArmId = datacenterManagementServerArmId;
            DatacenterManagementServerName = datacenterManagementServerName;
            Description = description;
            DisplayName = displayName;
            MegabytesOfMemory = megabytesOfMemory;
            NumberOfCores = numberOfCores;
            OperatingSystemType = operatingSystemType;
            OperatingSystemName = operatingSystemName;
            OperatingSystemVersion = operatingSystemVersion;
            MonthlyBandwidthCost = monthlyBandwidthCost;
            MonthlyStorageCost = monthlyStorageCost;
            MonthlyPremiumStorageCost = monthlyPremiumStorageCost;
            MonthlyStandardSSDStorageCost = monthlyStandardSSDStorageCost;
            ConfidenceRatingInPercentage = confidenceRatingInPercentage;
            Disks = disks;
            NetworkAdapters = networkAdapters;
            RecommendedSize = recommendedSize;
            NumberOfCoresForRecommendedSize = numberOfCoresForRecommendedSize;
            MegabytesOfMemoryForRecommendedSize = megabytesOfMemoryForRecommendedSize;
            MonthlyComputeCostForRecommendedSize = monthlyComputeCostForRecommendedSize;
            PercentageCoresUtilization = percentageCoresUtilization;
            PercentageMemoryUtilization = percentageMemoryUtilization;
            Suitability = suitability;
            SuitabilityExplanation = suitabilityExplanation;
            SuitabilityDetail = suitabilityDetail;
            CreatedTimestamp = createdTimestamp;
            UpdatedTimestamp = updatedTimestamp;
        }

        /// <summary> Boot type of the machine. </summary>
        public MachineBootType? BootType { get; }
        /// <summary> ARM ID of the discovered machine. </summary>
        public string DatacenterMachineArmId { get; }
        /// <summary> ARM ID of the discovered datacenter. </summary>
        public string DatacenterManagementServerArmId { get; }
        /// <summary> Name of the server hosting the datacenter management solution. </summary>
        public string DatacenterManagementServerName { get; }
        /// <summary> Description of the machine. </summary>
        public string Description { get; }
        /// <summary> User readable name of the machine as defined by the user in their private datacenter. </summary>
        public string DisplayName { get; }
        /// <summary> Memory in Megabytes. </summary>
        public double? MegabytesOfMemory { get; }
        /// <summary> Processor count. </summary>
        public int? NumberOfCores { get; }
        /// <summary> Operating System type of the machine. </summary>
        public string OperatingSystemType { get; }
        /// <summary> Operating System name of the machine. </summary>
        public string OperatingSystemName { get; }
        /// <summary> Operating System version of the machine. </summary>
        public string OperatingSystemVersion { get; }
        /// <summary> Monthly network cost estimate for the network adapters that are attached to this machine as a group, for a 31-day month. </summary>
        public double? MonthlyBandwidthCost { get; }
        /// <summary> Monthly storage cost estimate for the disks that are attached to this machine as a group, for a 31-day month. </summary>
        public double? MonthlyStorageCost { get; }
        /// <summary> Monthly premium storage cost estimate for the disks that are attached to this machine as a group, for a 31-day month. </summary>
        public double? MonthlyPremiumStorageCost { get; }
        /// <summary> Monthly standard SSD storage cost estimate for the disks that are attached to this machine as a group, for a 31-day month. </summary>
        public double? MonthlyStandardSSDStorageCost { get; }
        /// <summary> Confidence rating of assessed machine. </summary>
        public double? ConfidenceRatingInPercentage { get; }
        /// <summary> Dictionary of disks attached to the machine. Key is ID of disk. Value is a disk object. </summary>
        public IReadOnlyDictionary<string, AssessedDisk> Disks { get; }
        /// <summary> Dictionary of network adapters attached to the machine. Key is name of the adapter. Value is a network adapter object. </summary>
        public IReadOnlyDictionary<string, AssessedNetworkAdapter> NetworkAdapters { get; }
        /// <summary> Recommended Azure size for this machine. </summary>
        public AzureVmSize? RecommendedSize { get; }
        /// <summary> Number of CPU cores in the Recommended Azure VM Size. </summary>
        public int? NumberOfCoresForRecommendedSize { get; }
        /// <summary> Megabytes of memory in the Recommended Azure VM Size. </summary>
        public double? MegabytesOfMemoryForRecommendedSize { get; }
        /// <summary> Compute Cost for a 31-day month, if the machine is migrated to Azure with the Recommended Size. </summary>
        public double? MonthlyComputeCostForRecommendedSize { get; }
        /// <summary> Utilization percentage of the processor core as observed in the private data center, in the Time Range selected on Assessment, reported as the Percentile value based on the percentile number selected in assessment. </summary>
        public double? PercentageCoresUtilization { get; }
        /// <summary> Utilization percentage of the memory as observed in the private data center, in the Time Range selected on Assessment, reported as the Percentile value based on the percentile number selected in assessment. </summary>
        public double? PercentageMemoryUtilization { get; }
        /// <summary> Whether machine is suitable for migration to Azure. </summary>
        public CloudSuitability? Suitability { get; }
        /// <summary> If machine is not ready to be migrated, this explains the reasons and mitigation steps. </summary>
        public AzureVmSuitabilityExplanation? SuitabilityExplanation { get; }
        /// <summary> If machine is not suitable for cloud, this explains the reasons. </summary>
        public AzureVmSuitabilityDetail? SuitabilityDetail { get; }
        /// <summary> Time when this machine was created. Date-Time represented in ISO-8601 format. </summary>
        public DateTimeOffset? CreatedTimestamp { get; }
        /// <summary> Time when this machine was last updated. Date-Time represented in ISO-8601 format. </summary>
        public DateTimeOffset? UpdatedTimestamp { get; }
    }
}
