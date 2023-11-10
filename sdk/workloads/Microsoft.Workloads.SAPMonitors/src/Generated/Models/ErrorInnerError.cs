// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Workloads.SAPMonitors.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Object containing more specific information than  the current object
    /// about the error.
    /// </summary>
    public partial class ErrorInnerError
    {
        /// <summary>
        /// Initializes a new instance of the ErrorInnerError class.
        /// </summary>
        public ErrorInnerError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorInnerError class.
        /// </summary>
        public ErrorInnerError(Error innerError = default(Error))
        {
            InnerError = innerError;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "innerError")]
        public Error InnerError { get; set; }

    }
}
