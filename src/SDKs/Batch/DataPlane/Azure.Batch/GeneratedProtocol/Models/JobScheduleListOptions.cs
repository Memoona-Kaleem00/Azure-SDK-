// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional parameters for List operation.
    /// </summary>
    public partial class JobScheduleListOptions
    {
        /// <summary>
        /// Initializes a new instance of the JobScheduleListOptions class.
        /// </summary>
        public JobScheduleListOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobScheduleListOptions class.
        /// </summary>
        /// <param name="filter">An OData $filter clause. For more information
        /// on constructing this filter, see
        /// https://docs.microsoft.com/en-us/rest/api/batchservice/odata-filters-in-batch#list-job-schedules.</param>
        /// <param name="select">An OData $select clause.</param>
        /// <param name="expand">An OData $expand clause.</param>
        /// <param name="maxResults">The maximum number of items to return in
        /// the response. A maximum of 1000 job schedules can be
        /// returned.</param>
        /// <param name="timeout">The maximum time that the server can spend
        /// processing the request, in seconds. The default is 30
        /// seconds.</param>
        /// <param name="clientRequestId">The caller-generated request
        /// identity, in the form of a GUID with no decoration such as curly
        /// braces, e.g. 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0.</param>
        /// <param name="returnClientRequestId">Whether the server should
        /// return the client-request-id in the response.</param>
        /// <param name="ocpDate">The time the request was issued. Client
        /// libraries typically set this to the current system clock time; set
        /// it explicitly if you are calling the REST API directly.</param>
        public JobScheduleListOptions(string filter = default(string), string select = default(string), string expand = default(string), int? maxResults = default(int?), int? timeout = default(int?), System.Guid? clientRequestId = default(System.Guid?), bool? returnClientRequestId = default(bool?), System.DateTime? ocpDate = default(System.DateTime?))
        {
            Filter = filter;
            Select = select;
            Expand = expand;
            MaxResults = maxResults;
            Timeout = timeout;
            ClientRequestId = clientRequestId;
            ReturnClientRequestId = returnClientRequestId;
            OcpDate = ocpDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an OData $filter clause. For more information on
        /// constructing this filter, see
        /// https://docs.microsoft.com/en-us/rest/api/batchservice/odata-filters-in-batch#list-job-schedules.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets an OData $select clause.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public string Select { get; set; }

        /// <summary>
        /// Gets or sets an OData $expand clause.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public string Expand { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of items to return in the response.
        /// A maximum of 1000 job schedules can be returned.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Gets or sets the maximum time that the server can spend processing
        /// the request, in seconds. The default is 30 seconds.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public int? Timeout { get; set; }

        /// <summary>
        /// Gets or sets the caller-generated request identity, in the form of
        /// a GUID with no decoration such as curly braces, e.g.
        /// 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public System.Guid? ClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets whether the server should return the client-request-id
        /// in the response.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public bool? ReturnClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets the time the request was issued. Client libraries
        /// typically set this to the current system clock time; set it
        /// explicitly if you are calling the REST API directly.
        /// </summary>
        [JsonConverter(typeof(DateTimeRfc1123JsonConverter))]
        [Newtonsoft.Json.JsonIgnore]
        public System.DateTime? OcpDate { get; set; }

    }
}
