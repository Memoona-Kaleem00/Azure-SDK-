// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Build result log resource properties payload. </summary>
    public partial class BuildResultLog
    {
        /// <summary> Initializes a new instance of BuildResultLog. </summary>
        internal BuildResultLog()
        {
        }

        /// <summary> Initializes a new instance of BuildResultLog. </summary>
        /// <param name="blobUri"> The public download URL of this build result log. </param>
        internal BuildResultLog(Uri blobUri)
        {
            BlobUri = blobUri;
        }

        /// <summary> The public download URL of this build result log. </summary>
        public Uri BlobUri { get; }
    }
}
