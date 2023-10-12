// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Workloads.SAPVirtualInstance.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Delete operation.
    /// </summary>
    public partial class SAPCentralInstancesDeleteHeaders
    {
        /// <summary>
        /// Initializes a new instance of the SAPCentralInstancesDeleteHeaders
        /// class.
        /// </summary>
        public SAPCentralInstancesDeleteHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SAPCentralInstancesDeleteHeaders
        /// class.
        /// </summary>
        /// <param name="location">The URI to fetch the updated SAP Central
        /// Services Instance resource.</param>
        public SAPCentralInstancesDeleteHeaders(string location = default(string))
        {
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URI to fetch the updated SAP Central Services
        /// Instance resource.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
