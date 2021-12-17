// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The available data types for Amazon Web Services S3 data connector.
    /// </summary>
    public partial class AwsS3DataConnectorDataTypes
    {
        /// <summary>
        /// Initializes a new instance of the AwsS3DataConnectorDataTypes
        /// class.
        /// </summary>
        public AwsS3DataConnectorDataTypes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AwsS3DataConnectorDataTypes
        /// class.
        /// </summary>
        /// <param name="logs">Logs data type.</param>
        public AwsS3DataConnectorDataTypes(AwsS3DataConnectorDataTypesLogs logs)
        {
            Logs = logs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets logs data type.
        /// </summary>
        [JsonProperty(PropertyName = "logs")]
        public AwsS3DataConnectorDataTypesLogs Logs { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Logs == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Logs");
            }
            if (Logs != null)
            {
                Logs.Validate();
            }
        }
    }
}
