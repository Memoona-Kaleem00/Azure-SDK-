// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Input for command that completes online migration for an Azure SQL
    /// Database Managed Instance.
    /// </summary>
    public partial class MigrateMISyncCompleteCommandInput
    {
        /// <summary>
        /// Initializes a new instance of the MigrateMISyncCompleteCommandInput
        /// class.
        /// </summary>
        public MigrateMISyncCompleteCommandInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrateMISyncCompleteCommandInput
        /// class.
        /// </summary>
        /// <param name="sourceDatabaseName">Name of managed instance
        /// database</param>
        public MigrateMISyncCompleteCommandInput(string sourceDatabaseName)
        {
            SourceDatabaseName = sourceDatabaseName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of managed instance database
        /// </summary>
        [JsonProperty(PropertyName = "sourceDatabaseName")]
        public string SourceDatabaseName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SourceDatabaseName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceDatabaseName");
            }
        }
    }
}
