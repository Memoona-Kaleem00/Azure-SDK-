// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Collection of sites
    /// </summary>
    public partial class SiteCollection
    {
        /// <summary>
        /// Initializes a new instance of the SiteCollection class.
        /// </summary>
        public SiteCollection() { }

        /// <summary>
        /// Initializes a new instance of the SiteCollection class.
        /// </summary>
        public SiteCollection(IList<Site> value = default(IList<Site>), string nextLink = default(string), string id = default(string))
        {
            Value = value;
            NextLink = nextLink;
            Id = id;
        }

        /// <summary>
        /// Collection of resources
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Site> Value { get; set; }

        /// <summary>
        /// Link to next page of resources
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// Id of parent resource
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
