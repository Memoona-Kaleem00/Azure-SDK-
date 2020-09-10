// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.FlexibleServers.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A list of firewall rules.
    /// </summary>
    public partial class CustomerMaintenanceWindowListResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CustomerMaintenanceWindowListResult class.
        /// </summary>
        public CustomerMaintenanceWindowListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CustomerMaintenanceWindowListResult class.
        /// </summary>
        /// <param name="value">The list of CustomerMaintenanceWindows in a
        /// PostgreSQL server.</param>
        public CustomerMaintenanceWindowListResult(IList<CustomerMaintenanceWindow> value = default(IList<CustomerMaintenanceWindow>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of CustomerMaintenanceWindows in a PostgreSQL
        /// server.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<CustomerMaintenanceWindow> Value { get; set; }

    }
}
