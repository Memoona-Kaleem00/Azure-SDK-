// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </summary>
    public partial class DatasetFolder
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DatasetFolder"/>. </summary>
        public DatasetFolder()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatasetFolder"/>. </summary>
        /// <param name="name"> The name of the folder that this Dataset is in. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DatasetFolder(string name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> The name of the folder that this Dataset is in. </summary>
        public string Name { get; set; }
    }
}
