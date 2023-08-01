// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Storagetasks.Models
{
    /// <summary> Represents storage task preview action condition. </summary>
    public partial class StorageTaskPreviewActionIfCondition
    {
        /// <summary> Initializes a new instance of StorageTaskPreviewActionIfCondition. </summary>
        public StorageTaskPreviewActionIfCondition()
        {
        }

        /// <summary> Initializes a new instance of StorageTaskPreviewActionIfCondition. </summary>
        /// <param name="condition"> Storage task condition to bes tested for a match. </param>
        internal StorageTaskPreviewActionIfCondition(string condition)
        {
            Condition = condition;
        }

        /// <summary> Storage task condition to bes tested for a match. </summary>
        public string Condition { get; set; }
    }
}
