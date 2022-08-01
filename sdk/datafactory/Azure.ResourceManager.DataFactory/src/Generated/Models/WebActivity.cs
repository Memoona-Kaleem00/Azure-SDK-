// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// Web activity.
    /// Serialized Name: WebActivity
    /// </summary>
    public partial class WebActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of WebActivity. </summary>
        /// <param name="name">
        /// Activity name.
        /// Serialized Name: Activity.name
        /// </param>
        /// <param name="method">
        /// Rest API method for target endpoint.
        /// Serialized Name: WebActivity.typeProperties.method
        /// </param>
        /// <param name="uri">
        /// Web activity target endpoint and path. Type: string (or Expression with resultType string).
        /// Serialized Name: WebActivity.typeProperties.url
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="uri"/> is null. </exception>
        public WebActivity(string name, WebActivityMethod method, BinaryData uri) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            Method = method;
            Uri = uri;
            Datasets = new ChangeTrackingList<DatasetReference>();
            LinkedServices = new ChangeTrackingList<FactoryLinkedServiceReference>();
            ActivityType = "WebActivity";
        }

        /// <summary> Initializes a new instance of WebActivity. </summary>
        /// <param name="name">
        /// Activity name.
        /// Serialized Name: Activity.name
        /// </param>
        /// <param name="activityType">
        /// Type of activity.
        /// Serialized Name: Activity.type
        /// </param>
        /// <param name="description">
        /// Activity description.
        /// Serialized Name: Activity.description
        /// </param>
        /// <param name="dependsOn">
        /// Activity depends on condition.
        /// Serialized Name: Activity.dependsOn
        /// </param>
        /// <param name="userProperties">
        /// Activity user properties.
        /// Serialized Name: Activity.userProperties
        /// </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName">
        /// Linked service reference.
        /// Serialized Name: ExecutionActivity.linkedServiceName
        /// </param>
        /// <param name="policy">
        /// Activity policy.
        /// Serialized Name: ExecutionActivity.policy
        /// </param>
        /// <param name="method">
        /// Rest API method for target endpoint.
        /// Serialized Name: WebActivity.typeProperties.method
        /// </param>
        /// <param name="uri">
        /// Web activity target endpoint and path. Type: string (or Expression with resultType string).
        /// Serialized Name: WebActivity.typeProperties.url
        /// </param>
        /// <param name="headers">
        /// Represents the headers that will be sent to the request. For example, to set the language and type on a request: &quot;headers&quot; : { &quot;Accept-Language&quot;: &quot;en-us&quot;, &quot;Content-Type&quot;: &quot;application/json&quot; }. Type: string (or Expression with resultType string).
        /// Serialized Name: WebActivity.typeProperties.headers
        /// </param>
        /// <param name="body">
        /// Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string).
        /// Serialized Name: WebActivity.typeProperties.body
        /// </param>
        /// <param name="authentication">
        /// Authentication method used for calling the endpoint.
        /// Serialized Name: WebActivity.typeProperties.authentication
        /// </param>
        /// <param name="disableCertValidation">
        /// When set to true, Certificate validation will be disabled.
        /// Serialized Name: WebActivity.typeProperties.disableCertValidation
        /// </param>
        /// <param name="datasets">
        /// List of datasets passed to web endpoint.
        /// Serialized Name: WebActivity.typeProperties.datasets
        /// </param>
        /// <param name="linkedServices">
        /// List of linked services passed to web endpoint.
        /// Serialized Name: WebActivity.typeProperties.linkedServices
        /// </param>
        /// <param name="connectVia">
        /// The integration runtime reference.
        /// Serialized Name: WebActivity.typeProperties.connectVia
        /// </param>
        internal WebActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, FactoryLinkedServiceReference linkedServiceName, ActivityPolicy policy, WebActivityMethod method, BinaryData uri, BinaryData headers, BinaryData body, WebActivityAuthentication authentication, bool? disableCertValidation, IList<DatasetReference> datasets, IList<FactoryLinkedServiceReference> linkedServices, IntegrationRuntimeReference connectVia) : base(name, activityType, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Method = method;
            Uri = uri;
            Headers = headers;
            Body = body;
            Authentication = authentication;
            DisableCertValidation = disableCertValidation;
            Datasets = datasets;
            LinkedServices = linkedServices;
            ConnectVia = connectVia;
            ActivityType = activityType ?? "WebActivity";
        }

        /// <summary>
        /// Rest API method for target endpoint.
        /// Serialized Name: WebActivity.typeProperties.method
        /// </summary>
        public WebActivityMethod Method { get; set; }
        /// <summary>
        /// Web activity target endpoint and path. Type: string (or Expression with resultType string).
        /// Serialized Name: WebActivity.typeProperties.url
        /// </summary>
        public BinaryData Uri { get; set; }
        /// <summary>
        /// Represents the headers that will be sent to the request. For example, to set the language and type on a request: &quot;headers&quot; : { &quot;Accept-Language&quot;: &quot;en-us&quot;, &quot;Content-Type&quot;: &quot;application/json&quot; }. Type: string (or Expression with resultType string).
        /// Serialized Name: WebActivity.typeProperties.headers
        /// </summary>
        public BinaryData Headers { get; set; }
        /// <summary>
        /// Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string).
        /// Serialized Name: WebActivity.typeProperties.body
        /// </summary>
        public BinaryData Body { get; set; }
        /// <summary>
        /// Authentication method used for calling the endpoint.
        /// Serialized Name: WebActivity.typeProperties.authentication
        /// </summary>
        public WebActivityAuthentication Authentication { get; set; }
        /// <summary>
        /// When set to true, Certificate validation will be disabled.
        /// Serialized Name: WebActivity.typeProperties.disableCertValidation
        /// </summary>
        public bool? DisableCertValidation { get; set; }
        /// <summary>
        /// List of datasets passed to web endpoint.
        /// Serialized Name: WebActivity.typeProperties.datasets
        /// </summary>
        public IList<DatasetReference> Datasets { get; }
        /// <summary>
        /// List of linked services passed to web endpoint.
        /// Serialized Name: WebActivity.typeProperties.linkedServices
        /// </summary>
        public IList<FactoryLinkedServiceReference> LinkedServices { get; }
        /// <summary>
        /// The integration runtime reference.
        /// Serialized Name: WebActivity.typeProperties.connectVia
        /// </summary>
        public IntegrationRuntimeReference ConnectVia { get; set; }
    }
}
