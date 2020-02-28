// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ExtendedLivyBatchRequest
    {
        /// <summary>
        /// Initializes a new instance of the ExtendedLivyBatchRequest class.
        /// </summary>
        public ExtendedLivyBatchRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedLivyBatchRequest class.
        /// </summary>
        public ExtendedLivyBatchRequest(IDictionary<string, string> tags = default(IDictionary<string, string>), string artifactId = default(string), string name = default(string), string file = default(string), string className = default(string), IList<string> args = default(IList<string>), IList<string> jars = default(IList<string>), IList<string> files = default(IList<string>), IList<string> archives = default(IList<string>), IDictionary<string, string> conf = default(IDictionary<string, string>), string driverMemory = default(string), int? driverCores = default(int?), string executorMemory = default(string), int? executorCores = default(int?), int? numExecutors = default(int?))
        {
            Tags = tags;
            ArtifactId = artifactId;
            Name = name;
            File = file;
            ClassName = className;
            Args = args;
            Jars = jars;
            Files = files;
            Archives = archives;
            Conf = conf;
            DriverMemory = driverMemory;
            DriverCores = driverCores;
            ExecutorMemory = executorMemory;
            ExecutorCores = executorCores;
            NumExecutors = numExecutors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "artifactId")]
        public string ArtifactId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "file")]
        public string File { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "className")]
        public string ClassName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "args")]
        public IList<string> Args { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jars")]
        public IList<string> Jars { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "files")]
        public IList<string> Files { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "archives")]
        public IList<string> Archives { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "conf")]
        public IDictionary<string, string> Conf { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "driverMemory")]
        public string DriverMemory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "driverCores")]
        public int? DriverCores { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "executorMemory")]
        public string ExecutorMemory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "executorCores")]
        public int? ExecutorCores { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "numExecutors")]
        public int? NumExecutors { get; set; }

    }
}
