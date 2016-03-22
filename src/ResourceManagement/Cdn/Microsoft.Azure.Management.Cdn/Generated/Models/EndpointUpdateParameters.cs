// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Endpoint properties required for new endpoint creation.
    /// </summary>
    public partial class EndpointUpdateParameters : IResource
    {
        /// <summary>
        /// Initializes a new instance of the EndpointUpdateParameters class.
        /// </summary>
        public EndpointUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the EndpointUpdateParameters class.
        /// </summary>
        public EndpointUpdateParameters(IDictionary<string, string> tags = default(IDictionary<string, string>), string originHostHeader = default(string), string originPath = default(string), IList<string> contentTypesToCompress = default(IList<string>), bool? isCompressionEnabled = default(bool?), bool? isHttpAllowed = default(bool?), bool? isHttpsAllowed = default(bool?), QueryStringCachingBehavior? queryStringCachingBehavior = default(QueryStringCachingBehavior?))
        {
            Tags = tags;
            OriginHostHeader = originHostHeader;
            OriginPath = originPath;
            ContentTypesToCompress = contentTypesToCompress;
            IsCompressionEnabled = isCompressionEnabled;
            IsHttpAllowed = isHttpAllowed;
            IsHttpsAllowed = isHttpsAllowed;
            QueryStringCachingBehavior = queryStringCachingBehavior;
        }

        /// <summary>
        /// Endpoint tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// The host header the CDN provider will send along with content
        /// requests to origins. The default value is the host name of the
        /// origin.
        /// </summary>
        [JsonProperty(PropertyName = "properties.originHostHeader")]
        public string OriginHostHeader { get; set; }

        /// <summary>
        /// The path used for origin requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.originPath")]
        public string OriginPath { get; set; }

        /// <summary>
        /// List of content types on which compression will be applied. The
        /// value for the elements should be a valid MIME type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentTypesToCompress")]
        public IList<string> ContentTypesToCompress { get; set; }

        /// <summary>
        /// Indicates whether content compression is enabled. Default value is
        /// false. If compression is enabled, the content transferred from
        /// the CDN endpoint to the end user will be compressed. The
        /// requested content must be larger than 1 byte and smaller than 1
        /// MB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isCompressionEnabled")]
        public bool? IsCompressionEnabled { get; set; }

        /// <summary>
        /// Indicates whether HTTP traffic is allowed on the endpoint. Default
        /// value is true. At least one protocol (HTTP or HTTPS) must be
        /// allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isHttpAllowed")]
        public bool? IsHttpAllowed { get; set; }

        /// <summary>
        /// Indicates whether HTTPS traffic is allowed on the endpoint.
        /// Default value is true. At least one protocol (HTTP or HTTPS) must
        /// be allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isHttpsAllowed")]
        public bool? IsHttpsAllowed { get; set; }

        /// <summary>
        /// Defines the query string caching behavior. Possible values for
        /// this property include: 'IgnoreQueryString', 'BypassCaching',
        /// 'UseQueryString', 'NotSet'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryStringCachingBehavior")]
        public QueryStringCachingBehavior? QueryStringCachingBehavior { get; set; }

    }
}
