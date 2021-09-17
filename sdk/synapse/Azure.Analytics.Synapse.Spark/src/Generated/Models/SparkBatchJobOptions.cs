// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkBatchJobOptions. </summary>
    public partial class SparkBatchJobOptions
    {
        /// <summary> Initializes a new instance of SparkBatchJobOptions. </summary>
        /// <param name="name"></param>
        /// <param name="file"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="file"/> is null. </exception>
        public SparkBatchJobOptions(string name, string file)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (file == null)
            {
                throw new ArgumentNullException(nameof(file));
            }

            Tags = new ChangeTrackingDictionary<string, string>();
            Name = name;
            File = file;
            Arguments = new ChangeTrackingList<string>();
            Jars = new ChangeTrackingList<string>();
            PythonFiles = new ChangeTrackingList<string>();
            Files = new ChangeTrackingList<string>();
            Archives = new ChangeTrackingList<string>();
            Configuration = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets the artifact id. </summary>
        public string ArtifactId { get; set; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the file. </summary>
        public string File { get; }
        /// <summary> Gets or sets the class name. </summary>
        public string ClassName { get; set; }
        /// <summary> Gets the arguments. </summary>
        public IList<string> Arguments { get; }
        /// <summary> Gets the jars. </summary>
        public IList<string> Jars { get; }
        /// <summary> Gets the python files. </summary>
        public IList<string> PythonFiles { get; }
        /// <summary> Gets the files. </summary>
        public IList<string> Files { get; }
        /// <summary> Gets the archives. </summary>
        public IList<string> Archives { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Configuration { get; }
        /// <summary> Gets or sets the driver memory. </summary>
        public string DriverMemory { get; set; }
        /// <summary> Gets or sets the driver cores. </summary>
        public int? DriverCores { get; set; }
        /// <summary> Gets or sets the executor memory. </summary>
        public string ExecutorMemory { get; set; }
        /// <summary> Gets or sets the executor cores. </summary>
        public int? ExecutorCores { get; set; }
        /// <summary> Gets or sets the executor count. </summary>
        public int? ExecutorCount { get; set; }
    }
}
