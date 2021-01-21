// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error response body contract.
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
        /// <param name="code">An identifier for the error. Codes are invariant
        /// and are intended to be consumed programmatically.</param>
        /// <param name="message">A message describing the error, intended to
        /// be suitable for display in a user interface.</param>
        public ErrorResponseBody(string code = default(string), string message = default(string))
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
        /// Gets or sets an identifier for the error. Codes are invariant and
        /// are intended to be consumed programmatically.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a message describing the error, intended to be
        /// suitable for display in a user interface.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
