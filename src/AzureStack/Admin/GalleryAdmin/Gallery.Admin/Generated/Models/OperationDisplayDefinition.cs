// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Gallery.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about the REST operation.
    /// </summary>
    public partial class OperationDisplayDefinition
    {
        /// <summary>
        /// Initializes a new instance of the OperationDisplayDefinition class.
        /// </summary>
        public OperationDisplayDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationDisplayDefinition class.
        /// </summary>
        /// <param name="description">Description of the REST
        /// operation.</param>
        /// <param name="operation">Type of REST operation.</param>
        /// <param name="provider">Provider of the REST operation.</param>
        /// <param name="resource">Resource returned by the REST
        /// operation.</param>
        public OperationDisplayDefinition(string description = default(string), string operation = default(string), string provider = default(string), string resource = default(string))
        {
            Description = description;
            Operation = operation;
            Provider = provider;
            Resource = resource;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets description of the REST operation.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets type of REST operation.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets provider of the REST operation.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets resource returned by the REST operation.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

    }
}
