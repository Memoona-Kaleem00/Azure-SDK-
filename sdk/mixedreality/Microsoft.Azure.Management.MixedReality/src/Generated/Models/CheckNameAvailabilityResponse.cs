// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MixedReality.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Check Name Availability Response
    /// </summary>
    public partial class CheckNameAvailabilityResponse
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResponse
        /// class.
        /// </summary>
        public CheckNameAvailabilityResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResponse
        /// class.
        /// </summary>
        /// <param name="nameAvailable">if name Available</param>
        /// <param name="reason">Resource Name To Verify. Possible values
        /// include: 'Invalid', 'AlreadyExists'</param>
        /// <param name="message">detail message</param>
        public CheckNameAvailabilityResponse(bool nameAvailable, string reason = default(string), string message = default(string))
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if name Available
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public bool NameAvailable { get; set; }

        /// <summary>
        /// Gets or sets resource Name To Verify. Possible values include:
        /// 'Invalid', 'AlreadyExists'
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets detail message
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
