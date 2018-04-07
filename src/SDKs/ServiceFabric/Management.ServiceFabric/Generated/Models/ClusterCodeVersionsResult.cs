// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The result of the ServiceFabric runtime versions
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ClusterCodeVersionsResult
    {
        /// <summary>
        /// Initializes a new instance of the ClusterCodeVersionsResult class.
        /// </summary>
        public ClusterCodeVersionsResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterCodeVersionsResult class.
        /// </summary>
        /// <param name="id">The identification of the result</param>
        /// <param name="name">The name of the result</param>
        /// <param name="type">The result resource type</param>
        /// <param name="codeVersion">The Service Fabric runtime version of the
        /// cluster.</param>
        /// <param name="supportExpiryUtc">The date of expiry of support of the
        /// version.</param>
        /// <param name="environment">Indicates if this version is for Windows
        /// or Linux operating system. Possible values include: 'Windows',
        /// 'Linux'</param>
        public ClusterCodeVersionsResult(string id = default(string), string name = default(string), string type = default(string), string codeVersion = default(string), string supportExpiryUtc = default(string), string environment = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            CodeVersion = codeVersion;
            SupportExpiryUtc = supportExpiryUtc;
            Environment = environment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the identification of the result
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the result
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the result resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the Service Fabric runtime version of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.codeVersion")]
        public string CodeVersion { get; set; }

        /// <summary>
        /// Gets or sets the date of expiry of support of the version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportExpiryUtc")]
        public string SupportExpiryUtc { get; set; }

        /// <summary>
        /// Gets or sets indicates if this version is for Windows or Linux
        /// operating system. Possible values include: 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "properties.environment")]
        public string Environment { get; set; }

    }
}
