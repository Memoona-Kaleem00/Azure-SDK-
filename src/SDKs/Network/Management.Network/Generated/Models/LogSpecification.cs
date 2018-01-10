// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Description of logging specification.
    /// </summary>
    public partial class LogSpecification
    {
        /// <summary>
        /// Initializes a new instance of the LogSpecification class.
        /// </summary>
        public LogSpecification()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogSpecification class.
        /// </summary>
        /// <param name="name">The name of the specification.</param>
        /// <param name="displayName">The display name of the
        /// specification.</param>
        /// <param name="blobDuration">Duration of the blob.</param>
        public LogSpecification(string name = default(string), string displayName = default(string), string blobDuration = default(string))
        {
            Name = name;
            DisplayName = displayName;
            BlobDuration = blobDuration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the specification.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name of the specification.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets duration of the blob.
        /// </summary>
        [JsonProperty(PropertyName = "blobDuration")]
        public string BlobDuration { get; set; }

    }
}
