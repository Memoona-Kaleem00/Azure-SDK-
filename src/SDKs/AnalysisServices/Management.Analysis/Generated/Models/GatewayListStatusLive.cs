// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Analysis.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Analysis;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Status of gateway is live
    /// </summary>
    public partial class GatewayListStatusLive
    {
        /// <summary>
        /// Initializes a new instance of the GatewayListStatusLive class.
        /// </summary>
        public GatewayListStatusLive()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayListStatusLive class.
        /// </summary>
        /// <param name="status">Live message of list gateway. Possible values
        /// include: 'Live'</param>
        public GatewayListStatusLive(Status? status = default(Status?))
        {
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets live message of list gateway. Possible values include:
        /// 'Live'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Status? Status { get; set; }

    }
}
