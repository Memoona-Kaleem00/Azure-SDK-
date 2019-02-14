// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list Kusto data connection validation result.
    /// </summary>
    public partial class DataConnectionValidationListResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataConnectionValidationListResult class.
        /// </summary>
        public DataConnectionValidationListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DataConnectionValidationListResult class.
        /// </summary>
        /// <param name="value">The list of Kusto data connection validation
        /// errors.</param>
        public DataConnectionValidationListResult(IList<DataConnectionValidationResult> value = default(IList<DataConnectionValidationResult>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of Kusto data connection validation errors.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<DataConnectionValidationResult> Value { get; set; }

    }
}
