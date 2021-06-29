// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The TarGZip compression method used on a dataset. </summary>
    public partial class DatasetTarGZipCompression : DatasetCompression
    {
        /// <summary> Initializes a new instance of DatasetTarGZipCompression. </summary>
        public DatasetTarGZipCompression()
        {
            Type = "TarGZip";
        }

        /// <summary> Initializes a new instance of DatasetTarGZipCompression. </summary>
        /// <param name="type"> Type of dataset compression. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="level"> The TarGZip compression level. </param>
        internal DatasetTarGZipCompression(string type, IDictionary<string, object> additionalProperties, object level) : base(type, additionalProperties)
        {
            Level = level;
            Type = type ?? "TarGZip";
        }

        /// <summary> The TarGZip compression level. </summary>
        public object Level { get; set; }
    }
}
