// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> WebHook activity. </summary>
    public partial class WebHookActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of <see cref="WebHookActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="method"> Rest API method for target endpoint. </param>
        /// <param name="url"> WebHook activity target endpoint and path. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="url"/> is null. </exception>
        public WebHookActivity(string name, WebHookActivityMethod method, object url) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(url, nameof(url));

            Method = method;
            Url = url;
            Type = "WebHook";
        }

        /// <summary> Initializes a new instance of <see cref="WebHookActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="method"> Rest API method for target endpoint. </param>
        /// <param name="url"> WebHook activity target endpoint and path. Type: string (or Expression with resultType string). </param>
        /// <param name="timeout"> The timeout within which the webhook should be called back. If there is no value specified, it defaults to 10 minutes. Type: string. Pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="headers"> Represents the headers that will be sent to the request. For example, to set the language and type on a request: "headers" : { "Accept-Language": "en-us", "Content-Type": "application/json" }. Type: string (or Expression with resultType string). </param>
        /// <param name="body"> Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string). </param>
        /// <param name="authentication"> Authentication method used for calling the endpoint. </param>
        /// <param name="reportStatusOnCallBack"> When set to true, statusCode, output and error in callback request body will be consumed by activity. The activity can be marked as failed by setting statusCode &gt;= 400 in callback request. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        internal WebHookActivity(string name, string type, string description, ActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, WebHookActivityMethod method, object url, string timeout, object headers, object body, WebActivityAuthentication authentication, object reportStatusOnCallBack) : base(name, type, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties)
        {
            Method = method;
            Url = url;
            Timeout = timeout;
            Headers = headers;
            Body = body;
            Authentication = authentication;
            ReportStatusOnCallBack = reportStatusOnCallBack;
            Type = type ?? "WebHook";
        }

        /// <summary> Initializes a new instance of <see cref="WebHookActivity"/> for deserialization. </summary>
        internal WebHookActivity()
        {
        }

        /// <summary> Rest API method for target endpoint. </summary>
        public WebHookActivityMethod Method { get; set; }
        /// <summary> WebHook activity target endpoint and path. Type: string (or Expression with resultType string). </summary>
        public object Url { get; set; }
        /// <summary> The timeout within which the webhook should be called back. If there is no value specified, it defaults to 10 minutes. Type: string. Pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public string Timeout { get; set; }
        /// <summary> Represents the headers that will be sent to the request. For example, to set the language and type on a request: "headers" : { "Accept-Language": "en-us", "Content-Type": "application/json" }. Type: string (or Expression with resultType string). </summary>
        public object Headers { get; set; }
        /// <summary> Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string). </summary>
        public object Body { get; set; }
        /// <summary> Authentication method used for calling the endpoint. </summary>
        public WebActivityAuthentication Authentication { get; set; }
        /// <summary> When set to true, statusCode, output and error in callback request body will be consumed by activity. The activity can be marked as failed by setting statusCode &gt;= 400 in callback request. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public object ReportStatusOnCallBack { get; set; }
    }
}
