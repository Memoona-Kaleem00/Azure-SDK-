// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Graph;
    using Microsoft.Azure.Management.Graph.RBAC;
    using Microsoft.Azure.Management.Graph.RBAC.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Active Directory error information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GraphError
    {
        /// <summary>
        /// Initializes a new instance of the GraphError class.
        /// </summary>
        public GraphError()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GraphError class.
        /// </summary>
        /// <param name="code">Error code.</param>
        /// <param name="message">Error message value.</param>
        public GraphError(string code = default(string), string message = default(string))
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error code.
        /// </summary>
        [JsonProperty(PropertyName = "odata.error.code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets error message value.
        /// </summary>
        [JsonProperty(PropertyName = "odata.error.message.value")]
        public string Message { get; set; }

    }
}
