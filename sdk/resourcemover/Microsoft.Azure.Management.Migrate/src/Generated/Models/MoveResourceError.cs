// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Migrate.ResourceMover.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An error response from the azure resource mover service.
    /// </summary>
    public partial class MoveResourceError
    {
        /// <summary>
        /// Initializes a new instance of the MoveResourceError class.
        /// </summary>
        public MoveResourceError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MoveResourceError class.
        /// </summary>
        /// <param name="properties">The move resource error body.</param>
        public MoveResourceError(MoveResourceErrorBody properties = default(MoveResourceErrorBody))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the move resource error body.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public MoveResourceErrorBody Properties { get; set; }

    }
}
