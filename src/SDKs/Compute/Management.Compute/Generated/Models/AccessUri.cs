// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A disk access SAS uri.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AccessUri
    {
        /// <summary>
        /// Initializes a new instance of the AccessUri class.
        /// </summary>
        public AccessUri()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccessUri class.
        /// </summary>
        /// <param name="accessSAS">A SAS uri for accessing a disk.</param>
        public AccessUri(string accessSAS = default(string))
        {
            AccessSAS = accessSAS;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a SAS uri for accessing a disk.
        /// </summary>
        [JsonProperty(PropertyName = "properties.output.accessSAS")]
        public string AccessSAS { get; private set; }

    }
}
