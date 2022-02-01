// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Subscription.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error response indicates that the service is not able to process the
    /// incoming request. The reason is provided in the error message.
    /// </summary>
    public partial class ErrorResponseBody
    {
        /// <summary>
        /// Initializes a new instance of the ErrorResponseBody class.
        /// </summary>
        public ErrorResponseBody()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponseBody class.
        /// </summary>
        /// <param name="error">The details of the error.</param>
        /// <param name="code">Error code</param>
        /// <param name="message">Error message indicating why the operation
        /// failed.</param>
        public ErrorResponseBody(ErrorResponse error = default(ErrorResponse), string code = default(string), string message = default(string))
        {
            Error = error;
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the details of the error.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorResponse Error { get; set; }

        /// <summary>
        /// Gets or sets error code
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets error message indicating why the operation failed.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
