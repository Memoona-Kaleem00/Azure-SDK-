// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary> The type used for update operations of the DeviceGroup. </summary>
    public partial class SphereDeviceGroupPatch
    {
        /// <summary> Initializes a new instance of <see cref="SphereDeviceGroupPatch"/>. </summary>
        public SphereDeviceGroupPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SphereDeviceGroupPatch"/>. </summary>
        /// <param name="description"> Description of the device group. </param>
        /// <param name="osFeedType"> Operating system feed type of the device group. </param>
        /// <param name="updatePolicy"> Update policy of the device group. </param>
        /// <param name="allowCrashDumpsCollection"> Flag to define if the user allows for crash dump collection. </param>
        /// <param name="regionalDataBoundary"> Regional data boundary for the device group. </param>
        internal SphereDeviceGroupPatch(string description, SphereOSFeedType? osFeedType, SphereUpdatePolicy? updatePolicy, SphereAllowCrashDumpCollectionStatus? allowCrashDumpsCollection, RegionalDataBoundary? regionalDataBoundary)
        {
            Description = description;
            OSFeedType = osFeedType;
            UpdatePolicy = updatePolicy;
            AllowCrashDumpsCollection = allowCrashDumpsCollection;
            RegionalDataBoundary = regionalDataBoundary;
        }

        /// <summary> Description of the device group. </summary>
        public string Description { get; set; }
        /// <summary> Operating system feed type of the device group. </summary>
        public SphereOSFeedType? OSFeedType { get; set; }
        /// <summary> Update policy of the device group. </summary>
        public SphereUpdatePolicy? UpdatePolicy { get; set; }
        /// <summary> Flag to define if the user allows for crash dump collection. </summary>
        public SphereAllowCrashDumpCollectionStatus? AllowCrashDumpsCollection { get; set; }
        /// <summary> Regional data boundary for the device group. </summary>
        public RegionalDataBoundary? RegionalDataBoundary { get; set; }
    }
}
