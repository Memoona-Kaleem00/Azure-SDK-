// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Instructions for rendering the data
    /// </summary>
    public partial class Rendering
    {
        /// <summary>
        /// Initializes a new instance of the Rendering class.
        /// </summary>
        public Rendering()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Rendering class.
        /// </summary>
        /// <param name="type">Rendering Type. Possible values include:
        /// 'NoGraph', 'Table', 'TimeSeries', 'TimeSeriesPerInstance'</param>
        /// <param name="title">Title of data</param>
        /// <param name="description">Description of the data that will help it
        /// be interpreted</param>
        public Rendering(RenderingType? type = default(RenderingType?), string title = default(string), string description = default(string))
        {
            Type = type;
            Title = title;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets rendering Type. Possible values include: 'NoGraph',
        /// 'Table', 'TimeSeries', 'TimeSeriesPerInstance'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public RenderingType? Type { get; set; }

        /// <summary>
        /// Gets or sets title of data
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets description of the data that will help it be
        /// interpreted
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
