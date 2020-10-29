// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Library/package information of a Big Data pool powered by Apache Spark. </summary>
    public partial class LibraryInfo
    {
        /// <summary> Initializes a new instance of LibraryInfo. </summary>
        public LibraryInfo()
        {
        }

        /// <summary> Initializes a new instance of LibraryInfo. </summary>
        /// <param name="name"> Name of the library. </param>
        /// <param name="path"> Storage blob path of library. </param>
        /// <param name="containerName"> Storage blob container name. </param>
        /// <param name="uploadedTimestamp"> The last update time of the library. </param>
        /// <param name="type"> Type of the library. </param>
        internal LibraryInfo(string name, string path, string containerName, DateTimeOffset? uploadedTimestamp, string type)
        {
            Name = name;
            Path = path;
            ContainerName = containerName;
            UploadedTimestamp = uploadedTimestamp;
            Type = type;
        }

        /// <summary> Name of the library. </summary>
        public string Name { get; set; }
        /// <summary> Storage blob path of library. </summary>
        public string Path { get; set; }
        /// <summary> Storage blob container name. </summary>
        public string ContainerName { get; set; }
        /// <summary> The last update time of the library. </summary>
        public DateTimeOffset? UploadedTimestamp { get; set; }
        /// <summary> Type of the library. </summary>
        public string Type { get; set; }
    }
}
