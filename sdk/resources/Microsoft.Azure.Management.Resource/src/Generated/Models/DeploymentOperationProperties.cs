// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Deployment operation properties.
    /// </summary>
    public partial class DeploymentOperationProperties
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentOperationProperties
        /// class.
        /// </summary>
        public DeploymentOperationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentOperationProperties
        /// class.
        /// </summary>
        /// <param name="provisioningState">The state of the
        /// provisioning.</param>
        /// <param name="timestamp">The date and time of the operation.</param>
        /// <param name="duration">The duration of the operation.</param>
        /// <param name="serviceRequestId">Deployment operation service request
        /// id.</param>
        /// <param name="statusCode">Operation status code.</param>
        /// <param name="statusMessage">Operation status message.</param>
        /// <param name="targetResource">The target resource.</param>
        /// <param name="request">The HTTP request message.</param>
        /// <param name="response">The HTTP response message.</param>
        public DeploymentOperationProperties(string provisioningState = default(string), System.DateTime? timestamp = default(System.DateTime?), string duration = default(string), string serviceRequestId = default(string), string statusCode = default(string), object statusMessage = default(object), TargetResource targetResource = default(TargetResource), HttpMessage request = default(HttpMessage), HttpMessage response = default(HttpMessage))
        {
            ProvisioningState = provisioningState;
            Timestamp = timestamp;
            Duration = duration;
            ServiceRequestId = serviceRequestId;
            StatusCode = statusCode;
            StatusMessage = statusMessage;
            TargetResource = targetResource;
            Request = request;
            Response = response;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the state of the provisioning.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the date and time of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; private set; }

        /// <summary>
        /// Gets the duration of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; private set; }

        /// <summary>
        /// Gets deployment operation service request id.
        /// </summary>
        [JsonProperty(PropertyName = "serviceRequestId")]
        public string ServiceRequestId { get; private set; }

        /// <summary>
        /// Gets operation status code.
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public string StatusCode { get; private set; }

        /// <summary>
        /// Gets operation status message.
        /// </summary>
        [JsonProperty(PropertyName = "statusMessage")]
        public object StatusMessage { get; private set; }

        /// <summary>
        /// Gets the target resource.
        /// </summary>
        [JsonProperty(PropertyName = "targetResource")]
        public TargetResource TargetResource { get; private set; }

        /// <summary>
        /// Gets the HTTP request message.
        /// </summary>
        [JsonProperty(PropertyName = "request")]
        public HttpMessage Request { get; private set; }

        /// <summary>
        /// Gets the HTTP response message.
        /// </summary>
        [JsonProperty(PropertyName = "response")]
        public HttpMessage Response { get; private set; }

    }
}
