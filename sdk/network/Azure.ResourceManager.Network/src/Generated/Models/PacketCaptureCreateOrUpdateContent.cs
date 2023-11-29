// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define the create packet capture operation. </summary>
    public partial class PacketCaptureCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="PacketCaptureCreateOrUpdateContent"/>. </summary>
        /// <param name="target"> The ID of the targeted resource, only AzureVM and AzureVMSS as target type are currently supported. </param>
        /// <param name="storageLocation"> The storage location for a packet capture session. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="target"/> or <paramref name="storageLocation"/> is null. </exception>
        public PacketCaptureCreateOrUpdateContent(string target, PacketCaptureStorageLocation storageLocation)
        {
            Argument.AssertNotNull(target, nameof(target));
            Argument.AssertNotNull(storageLocation, nameof(storageLocation));

            Target = target;
            StorageLocation = storageLocation;
            Filters = new ChangeTrackingList<PacketCaptureFilter>();
        }

        /// <summary> Initializes a new instance of <see cref="PacketCaptureCreateOrUpdateContent"/>. </summary>
        /// <param name="target"> The ID of the targeted resource, only AzureVM and AzureVMSS as target type are currently supported. </param>
        /// <param name="scope"> A list of AzureVMSS instances which can be included or excluded to run packet capture. If both included and excluded are empty, then the packet capture will run on all instances of AzureVMSS. </param>
        /// <param name="targetType"> Target type of the resource provided. </param>
        /// <param name="bytesToCapturePerPacket"> Number of bytes captured per packet, the remaining bytes are truncated. </param>
        /// <param name="totalBytesPerSession"> Maximum size of the capture output. </param>
        /// <param name="timeLimitInSeconds"> Maximum duration of the capture session in seconds. </param>
        /// <param name="storageLocation"> The storage location for a packet capture session. </param>
        /// <param name="filters"> A list of packet capture filters. </param>
        internal PacketCaptureCreateOrUpdateContent(string target, PacketCaptureMachineScope scope, PacketCaptureTargetType? targetType, long? bytesToCapturePerPacket, long? totalBytesPerSession, int? timeLimitInSeconds, PacketCaptureStorageLocation storageLocation, IList<PacketCaptureFilter> filters)
        {
            Target = target;
            Scope = scope;
            TargetType = targetType;
            BytesToCapturePerPacket = bytesToCapturePerPacket;
            TotalBytesPerSession = totalBytesPerSession;
            TimeLimitInSeconds = timeLimitInSeconds;
            StorageLocation = storageLocation;
            Filters = filters;
        }

        /// <summary> The ID of the targeted resource, only AzureVM and AzureVMSS as target type are currently supported. </summary>
        public string Target { get; }
        /// <summary> A list of AzureVMSS instances which can be included or excluded to run packet capture. If both included and excluded are empty, then the packet capture will run on all instances of AzureVMSS. </summary>
        public PacketCaptureMachineScope Scope { get; set; }
        /// <summary> Target type of the resource provided. </summary>
        public PacketCaptureTargetType? TargetType { get; set; }
        /// <summary> Number of bytes captured per packet, the remaining bytes are truncated. </summary>
        public long? BytesToCapturePerPacket { get; set; }
        /// <summary> Maximum size of the capture output. </summary>
        public long? TotalBytesPerSession { get; set; }
        /// <summary> Maximum duration of the capture session in seconds. </summary>
        public int? TimeLimitInSeconds { get; set; }
        /// <summary> The storage location for a packet capture session. </summary>
        public PacketCaptureStorageLocation StorageLocation { get; }
        /// <summary> A list of packet capture filters. </summary>
        public IList<PacketCaptureFilter> Filters { get; }
    }
}
