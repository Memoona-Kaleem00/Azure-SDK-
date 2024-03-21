// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define the create packet capture operation. </summary>
    public partial class PacketCaptureCreateOrUpdateContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

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
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PacketCaptureCreateOrUpdateContent(string target, PacketCaptureMachineScope scope, PacketCaptureTargetType? targetType, long? bytesToCapturePerPacket, long? totalBytesPerSession, int? timeLimitInSeconds, PacketCaptureStorageLocation storageLocation, IList<PacketCaptureFilter> filters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Target = target;
            Scope = scope;
            TargetType = targetType;
            BytesToCapturePerPacket = bytesToCapturePerPacket;
            TotalBytesPerSession = totalBytesPerSession;
            TimeLimitInSeconds = timeLimitInSeconds;
            StorageLocation = storageLocation;
            Filters = filters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PacketCaptureCreateOrUpdateContent"/> for deserialization. </summary>
        internal PacketCaptureCreateOrUpdateContent()
        {
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
