// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.2.22.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Redirect incompatible row settings
    /// </summary>
    public partial class RedirectIncompatibleRowSettings
    {
        /// <summary>
        /// Initializes a new instance of the RedirectIncompatibleRowSettings
        /// class.
        /// </summary>
        public RedirectIncompatibleRowSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RedirectIncompatibleRowSettings
        /// class.
        /// </summary>
        /// <param name="linkedServiceName">Name of the Azure Storage or
        /// Storage SAS linked service used for redirecting incompatible row.
        /// Must be specified if redirectIncompatibleRowSettings is specified.
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="path">The path to storage for storing the redirect
        /// incompatible row data Type: string (or Expression with resultType
        /// string).</param>
        public RedirectIncompatibleRowSettings(object linkedServiceName, object path = default(object))
        {
            LinkedServiceName = linkedServiceName;
            Path = path;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Azure Storage or Storage SAS linked
        /// service used for redirecting incompatible row. Must be specified if
        /// redirectIncompatibleRowSettings is specified. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "linkedServiceName")]
        public object LinkedServiceName { get; set; }

        /// <summary>
        /// Gets or sets the path to storage for storing the redirect
        /// incompatible row data Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public object Path { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LinkedServiceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LinkedServiceName");
            }
        }
    }
}
