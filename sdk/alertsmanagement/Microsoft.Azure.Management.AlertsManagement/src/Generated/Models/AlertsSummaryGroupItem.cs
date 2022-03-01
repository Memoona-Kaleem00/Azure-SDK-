// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Alerts summary group item
    /// </summary>
    public partial class AlertsSummaryGroupItem
    {
        /// <summary>
        /// Initializes a new instance of the AlertsSummaryGroupItem class.
        /// </summary>
        public AlertsSummaryGroupItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertsSummaryGroupItem class.
        /// </summary>
        /// <param name="name">Value of the aggregated field</param>
        /// <param name="count">Count of the aggregated field</param>
        /// <param name="groupedby">Name of the field aggregated</param>
        /// <param name="values">List of the items</param>
        public AlertsSummaryGroupItem(string name = default(string), long? count = default(long?), string groupedby = default(string), IList<AlertsSummaryGroupItem> values = default(IList<AlertsSummaryGroupItem>))
        {
            Name = name;
            Count = count;
            Groupedby = groupedby;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value of the aggregated field
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets count of the aggregated field
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }

        /// <summary>
        /// Gets or sets name of the field aggregated
        /// </summary>
        [JsonProperty(PropertyName = "groupedby")]
        public string Groupedby { get; set; }

        /// <summary>
        /// Gets or sets list of the items
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<AlertsSummaryGroupItem> Values { get; set; }

    }
}
