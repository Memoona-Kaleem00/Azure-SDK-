// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response of the CheckNameAvailability operation.
    /// </summary>
    public partial class ApiManagementServiceNameAvailabilityResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApiManagementServiceNameAvailabilityResult class.
        /// </summary>
        public ApiManagementServiceNameAvailabilityResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApiManagementServiceNameAvailabilityResult class.
        /// </summary>
        /// <param name="nameAvailable">True if the name is available and can
        /// be used to create a new API Management service; otherwise
        /// false.</param>
        /// <param name="message">If reason == invalid, provide the user with
        /// the reason why the given name is invalid, and provide the resource
        /// naming requirements so that the user can select a valid name. If
        /// reason == AlreadyExists, explain that &lt;resourceName&gt; is
        /// already in use, and direct them to select a different name.</param>
        /// <param name="reason">Invalid indicates the name provided does not
        /// match the resource provider’s naming requirements (incorrect
        /// length, unsupported characters, etc.)  AlreadyExists indicates that
        /// the name is already in use and is therefore unavailable. Possible
        /// values include: 'Valid', 'Invalid', 'AlreadyExists'</param>
        public ApiManagementServiceNameAvailabilityResult(bool? nameAvailable = default(bool?), string message = default(string), NameAvailabilityReason? reason = default(NameAvailabilityReason?))
        {
            NameAvailable = nameAvailable;
            Message = message;
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets true if the name is available and can be used to create a new
        /// API Management service; otherwise false.
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public bool? NameAvailable { get; private set; }

        /// <summary>
        /// Gets if reason == invalid, provide the user with the reason why the
        /// given name is invalid, and provide the resource naming requirements
        /// so that the user can select a valid name. If reason ==
        /// AlreadyExists, explain that &amp;lt;resourceName&amp;gt; is already
        /// in use, and direct them to select a different name.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets or sets invalid indicates the name provided does not match the
        /// resource provider’s naming requirements (incorrect length,
        /// unsupported characters, etc.)  AlreadyExists indicates that the
        /// name is already in use and is therefore unavailable. Possible
        /// values include: 'Valid', 'Invalid', 'AlreadyExists'
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public NameAvailabilityReason? Reason { get; set; }

    }
}
