// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.ElasticSan.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ElasticSan
{
    /// <summary>
    /// A class representing the ElasticSanSnapshot data model.
    /// Response for Volume Snapshot request.
    /// </summary>
    public partial class ElasticSanSnapshotData : ResourceData
    {
        /// <summary> Initializes a new instance of ElasticSanSnapshotData. </summary>
        /// <param name="creationData"> Data used when creating a volume snapshot. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="creationData"/> is null. </exception>
        public ElasticSanSnapshotData(SnapshotCreationData creationData)
        {
            Argument.AssertNotNull(creationData, nameof(creationData));

            CreationData = creationData;
        }

        /// <summary> Initializes a new instance of ElasticSanSnapshotData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="creationData"> Data used when creating a volume snapshot. </param>
        /// <param name="provisioningState"> State of the operation on the resource. </param>
        /// <param name="sourceVolumeSizeGiB"> Size of Source Volume. </param>
        /// <param name="volumeName"> Source Volume Name of a snapshot. </param>
        internal ElasticSanSnapshotData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SnapshotCreationData creationData, ElasticSanProvisioningState? provisioningState, long? sourceVolumeSizeGiB, string volumeName) : base(id, name, resourceType, systemData)
        {
            CreationData = creationData;
            ProvisioningState = provisioningState;
            SourceVolumeSizeGiB = sourceVolumeSizeGiB;
            VolumeName = volumeName;
        }

        /// <summary> Data used when creating a volume snapshot. </summary>
        internal SnapshotCreationData CreationData { get; set; }
        /// <summary> Fully qualified resource ID of the volume. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/volumes/{volumeName}". </summary>
        public ResourceIdentifier CreationDataSourceId
        {
            get => CreationData is null ? default : CreationData.SourceId;
            set => CreationData = new SnapshotCreationData(value);
        }

        /// <summary> State of the operation on the resource. </summary>
        public ElasticSanProvisioningState? ProvisioningState { get; }
        /// <summary> Size of Source Volume. </summary>
        public long? SourceVolumeSizeGiB { get; }
        /// <summary> Source Volume Name of a snapshot. </summary>
        public string VolumeName { get; }
    }
}
