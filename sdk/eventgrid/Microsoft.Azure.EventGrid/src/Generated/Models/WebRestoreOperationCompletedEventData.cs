// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Schema of the Data property of an EventGridEvent for an
    /// Microsoft.Web.RestoreOperationCompleted event.
    /// </summary>
    public partial class WebRestoreOperationCompletedEventData
    {
        /// <summary>
        /// Initializes a new instance of the
        /// WebRestoreOperationCompletedEventData class.
        /// </summary>
        public WebRestoreOperationCompletedEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// WebRestoreOperationCompletedEventData class.
        /// </summary>
        /// <param name="name">name of the web site that had this
        /// event.</param>
        /// <param name="clientRequestId">The client request id generated by
        /// the app service for the site API operation that triggered this
        /// event.</param>
        /// <param name="correlationRequestId">The correlation request id
        /// generated by the app service for the site API operation that
        /// triggered this event.</param>
        /// <param name="requestId">The request id generated by the app service
        /// for the site API operation that triggered this event.</param>
        /// <param name="address">HTTP request URL of this operation.</param>
        /// <param name="verb">HTTP verb of this operation.</param>
        public WebRestoreOperationCompletedEventData(AppEventTypeDetail appEventTypeDetail = default(AppEventTypeDetail), string name = default(string), string clientRequestId = default(string), string correlationRequestId = default(string), string requestId = default(string), string address = default(string), string verb = default(string))
        {
            AppEventTypeDetail = appEventTypeDetail;
            Name = name;
            ClientRequestId = clientRequestId;
            CorrelationRequestId = correlationRequestId;
            RequestId = requestId;
            Address = address;
            Verb = verb;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appEventTypeDetail")]
        public AppEventTypeDetail AppEventTypeDetail { get; set; }

        /// <summary>
        /// Gets or sets name of the web site that had this event.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the client request id generated by the app service for
        /// the site API operation that triggered this event.
        /// </summary>
        [JsonProperty(PropertyName = "clientRequestId")]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets the correlation request id generated by the app
        /// service for the site API operation that triggered this event.
        /// </summary>
        [JsonProperty(PropertyName = "correlationRequestId")]
        public string CorrelationRequestId { get; set; }

        /// <summary>
        /// Gets or sets the request id generated by the app service for the
        /// site API operation that triggered this event.
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or sets HTTP request URL of this operation.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets HTTP verb of this operation.
        /// </summary>
        [JsonProperty(PropertyName = "verb")]
        public string Verb { get; set; }

    }
}
