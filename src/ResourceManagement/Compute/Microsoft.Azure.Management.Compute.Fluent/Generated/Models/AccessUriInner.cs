// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Azure;
    using Management;
    using Compute;
    using Fluent;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A disk access SAS uri.
    /// </summary>
    [JsonTransformation]
    public partial class AccessUriInner
    {
        /// <summary>
        /// Initializes a new instance of the AccessUriInner class.
        /// </summary>
        public AccessUriInner() { }

        /// <summary>
        /// Initializes a new instance of the AccessUriInner class.
        /// </summary>
        /// <param name="accessSAS">A SAS uri for accessing a disk.</param>
        public AccessUriInner(string accessSAS = default(string))
        {
            AccessSAS = accessSAS;
        }

        /// <summary>
        /// Gets a SAS uri for accessing a disk.
        /// </summary>
        [JsonProperty(PropertyName = "properties.output.accessSAS")]
        public string AccessSAS { get; protected set; }

    }
}

