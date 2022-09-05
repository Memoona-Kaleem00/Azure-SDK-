// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> The parameters used when calling trigger change detection action on cloud endpoint. </summary>
    public partial class TriggerChangeDetectionContent
    {
        /// <summary> Initializes a new instance of TriggerChangeDetectionContent. </summary>
        public TriggerChangeDetectionContent()
        {
            Paths = new ChangeTrackingList<string>();
        }

        /// <summary> Relative path to a directory Azure File share for which change detection is to be performed. </summary>
        public string DirectoryPath { get; set; }
        /// <summary> Change Detection Mode. Applies to a directory specified in directoryPath parameter. </summary>
        public ChangeDetectionMode? ChangeDetectionMode { get; set; }
        /// <summary> Array of relative paths on the Azure File share to be included in the change detection. Can be files and directories. </summary>
        public IList<string> Paths { get; }
    }
}
