// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Function key info.
    /// Serialized Name: KeyInfo
    /// </summary>
    public partial class KeyInfo
    {
        /// <summary> Initializes a new instance of KeyInfo. </summary>
        public KeyInfo()
        {
        }

        /// <summary> Initializes a new instance of KeyInfo. </summary>
        /// <param name="name">
        /// Key name
        /// Serialized Name: KeyInfo.name
        /// </param>
        /// <param name="value">
        /// Key value
        /// Serialized Name: KeyInfo.value
        /// </param>
        internal KeyInfo(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Key name
        /// Serialized Name: KeyInfo.name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Key value
        /// Serialized Name: KeyInfo.value
        /// </summary>
        public string Value { get; set; }
    }
}
