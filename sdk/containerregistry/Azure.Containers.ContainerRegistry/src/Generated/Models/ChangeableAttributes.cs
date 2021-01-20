// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Containers.ContainerRegistry.Models
{
    /// <summary> The ChangeableAttributes. </summary>
    public partial class ChangeableAttributes
    {
        /// <summary> Initializes a new instance of ChangeableAttributes. </summary>
        public ChangeableAttributes()
        {
        }

        /// <summary> Initializes a new instance of ChangeableAttributes. </summary>
        /// <param name="deleteEnabled"> Delete enabled. </param>
        /// <param name="writeEnabled"> Write enabled. </param>
        /// <param name="listEnabled"> List enabled. </param>
        /// <param name="readEnabled"> Read enabled. </param>
        internal ChangeableAttributes(bool? deleteEnabled, bool? writeEnabled, bool? listEnabled, bool? readEnabled)
        {
            DeleteEnabled = deleteEnabled;
            WriteEnabled = writeEnabled;
            ListEnabled = listEnabled;
            ReadEnabled = readEnabled;
        }

        /// <summary> Delete enabled. </summary>
        public bool? DeleteEnabled { get; set; }
        /// <summary> Write enabled. </summary>
        public bool? WriteEnabled { get; set; }
        /// <summary> List enabled. </summary>
        public bool? ListEnabled { get; set; }
        /// <summary> Read enabled. </summary>
        public bool? ReadEnabled { get; set; }
    }
}
