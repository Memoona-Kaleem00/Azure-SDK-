// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Object for patch operations.
    /// </summary>
    public partial class PatchObject
    {
        /// <summary>
        /// Initializes a new instance of the PatchObject class.
        /// </summary>
        public PatchObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatchObject class.
        /// </summary>
        /// <param name="tags">Resource tags.</param>
        public PatchObject(IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
