// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Body of the error response returned from the API.
    /// </summary>
    public partial class ErrorEntity
    {
        /// <summary>
        /// Initializes a new instance of the ErrorEntity class.
        /// </summary>
        public ErrorEntity() { }

        /// <summary>
        /// Initializes a new instance of the ErrorEntity class.
        /// </summary>
        /// <param name="code">Basic error code.</param>
        /// <param name="message">Any details of the error.</param>
        /// <param name="extendedCode">Type of error.</param>
        /// <param name="messageTemplate">Message template.</param>
        /// <param name="parameters">Parameters for the template.</param>
        /// <param name="innerErrors">Inner errors.</param>
        public ErrorEntity(string code = default(string), string message = default(string), string extendedCode = default(string), string messageTemplate = default(string), System.Collections.Generic.IList<string> parameters = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<ErrorEntity> innerErrors = default(System.Collections.Generic.IList<ErrorEntity>))
        {
            Code = code;
            Message = message;
            ExtendedCode = extendedCode;
            MessageTemplate = messageTemplate;
            Parameters = parameters;
            InnerErrors = innerErrors;
        }

        /// <summary>
        /// Gets or sets basic error code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets any details of the error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets type of error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "extendedCode")]
        public string ExtendedCode { get; set; }

        /// <summary>
        /// Gets or sets message template.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "messageTemplate")]
        public string MessageTemplate { get; set; }

        /// <summary>
        /// Gets or sets parameters for the template.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.IList<string> Parameters { get; set; }

        /// <summary>
        /// Gets or sets inner errors.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "innerErrors")]
        public System.Collections.Generic.IList<ErrorEntity> InnerErrors { get; set; }

    }
}
