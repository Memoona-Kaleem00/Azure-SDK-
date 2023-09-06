// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Describes how media is transferred to the extension plugin. </summary>
    public partial class GrpcExtensionDataTransfer
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GrpcExtensionDataTransfer"/>. </summary>
        /// <param name="mode"> Data transfer mode: embedded or sharedMemory. </param>
        public GrpcExtensionDataTransfer(GrpcExtensionDataTransferMode mode)
        {
            Mode = mode;
        }

        /// <summary> Initializes a new instance of <see cref="GrpcExtensionDataTransfer"/>. </summary>
        /// <param name="sharedMemorySizeMiB"> The share memory buffer for sample transfers, in mebibytes. It can only be used with the 'SharedMemory' transfer mode. </param>
        /// <param name="mode"> Data transfer mode: embedded or sharedMemory. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GrpcExtensionDataTransfer(string sharedMemorySizeMiB, GrpcExtensionDataTransferMode mode, Dictionary<string, BinaryData> rawData)
        {
            SharedMemorySizeMiB = sharedMemorySizeMiB;
            Mode = mode;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="GrpcExtensionDataTransfer"/> for deserialization. </summary>
        internal GrpcExtensionDataTransfer()
        {
        }

        /// <summary> The share memory buffer for sample transfers, in mebibytes. It can only be used with the 'SharedMemory' transfer mode. </summary>
        public string SharedMemorySizeMiB { get; set; }
        /// <summary> Data transfer mode: embedded or sharedMemory. </summary>
        public GrpcExtensionDataTransferMode Mode { get; set; }
    }
}
