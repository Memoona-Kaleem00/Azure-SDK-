// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Storagetasks.Models
{
    /// <summary> Storage task preview object key value pair properties. </summary>
    public partial class StorageTaskPreviewKeyValueProperties
    {
        /// <summary> Initializes a new instance of StorageTaskPreviewKeyValueProperties. </summary>
        public StorageTaskPreviewKeyValueProperties()
        {
        }

        /// <summary> Initializes a new instance of StorageTaskPreviewKeyValueProperties. </summary>
        /// <param name="key"> Represents the key property of the pair. </param>
        /// <param name="value"> Represents the value property of the pair. </param>
        internal StorageTaskPreviewKeyValueProperties(string key, string value)
        {
            Key = key;
            Value = value;
        }

        /// <summary> Represents the key property of the pair. </summary>
        public string Key { get; set; }
        /// <summary> Represents the value property of the pair. </summary>
        public string Value { get; set; }
    }
}
