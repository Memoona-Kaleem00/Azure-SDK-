// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ApplicationInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The code and message for an error.
    /// </summary>
    public partial class ErrorInfo
    {
        /// <summary>
        /// Initializes a new instance of the ErrorInfo class.
        /// </summary>
        public ErrorInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorInfo class.
        /// </summary>
        /// <param name="code">A machine readable error code.</param>
        /// <param name="message">A human readable error message.</param>
        /// <param name="details">error details.</param>
        /// <param name="innererror">Inner error details if they exist.</param>
        public ErrorInfo(string code, string message, IList<ErrorDetail> details = default(IList<ErrorDetail>), ErrorInfo innererror = default(ErrorInfo), object additionalProperties = default(object))
        {
            Code = code;
            Message = message;
            Details = details;
            Innererror = innererror;
            AdditionalProperties = additionalProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a machine readable error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a human readable error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets error details.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ErrorDetail> Details { get; set; }

        /// <summary>
        /// Gets or sets inner error details if they exist.
        /// </summary>
        [JsonProperty(PropertyName = "innererror")]
        public ErrorInfo Innererror { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additionalProperties")]
        public object AdditionalProperties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
            if (Details != null)
            {
                foreach (var element in Details)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Innererror != null)
            {
                Innererror.Validate();
            }
        }
    }
}
