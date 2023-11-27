// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Object containing updates for patch operations. </summary>
    public partial class VMwareResourcePatchContent
    {
        /// <summary> Initializes a new instance of <see cref="VMwareResourcePatchContent"/>. </summary>
        public VMwareResourcePatchContent()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
