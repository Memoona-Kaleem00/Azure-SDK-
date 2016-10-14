// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using System.Linq;

    /// <summary>
    /// Endpoint properties required for new endpoint creation.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class EndpointCreateParameters : Microsoft.Rest.Azure.IResource
    {
        /// <summary>
        /// Initializes a new instance of the EndpointCreateParameters class.
        /// </summary>
        public EndpointCreateParameters() { }

        /// <summary>
        /// Initializes a new instance of the EndpointCreateParameters class.
        /// </summary>
        /// <param name="location">Endpoint location</param>
        /// <param name="origins">The set of origins for the CDN endpoint.
        /// When multiple origins exist, the first origin will be used as
        /// primary and rest will be used as failover options.</param>
        /// <param name="tags">Endpoint tags</param>
        /// <param name="originHostHeader">The host header CDN provider will
        /// send along with content requests to origins. The default value is
        /// the host name of the origin.</param>
        /// <param name="originPath">The path used for origin requests.</param>
        /// <param name="contentTypesToCompress">List of content types on
        /// which compression will be applied. The value for the elements
        /// should be a valid MIME type.</param>
        /// <param name="isCompressionEnabled">Indicates whether content
        /// compression is enabled. Default value is false. If compression is
        /// enabled, the content transferred from the CDN endpoint to the end
        /// user will be compressed. The requested content must be larger
        /// than 1 byte and smaller than 1 MB.</param>
        /// <param name="isHttpAllowed">Indicates whether HTTP traffic is
        /// allowed on the endpoint. Default value is true. At least one
        /// protocol (HTTP or HTTPS) must be allowed.</param>
        /// <param name="isHttpsAllowed">Indicates whether https traffic is
        /// allowed on the endpoint. Default value is true. At least one
        /// protocol (HTTP or HTTPS) must be allowed.</param>
        /// <param name="queryStringCachingBehavior">Defines the query string
        /// caching behavior. Possible values include: 'IgnoreQueryString',
        /// 'BypassCaching', 'UseQueryString', 'NotSet'</param>
        /// <param name="geoFilters">The list of geo filters for the CDN
        /// endpoint.</param>
        public EndpointCreateParameters(string location, System.Collections.Generic.IList<DeepCreatedOrigin> origins, System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string originHostHeader = default(string), string originPath = default(string), System.Collections.Generic.IList<string> contentTypesToCompress = default(System.Collections.Generic.IList<string>), bool? isCompressionEnabled = default(bool?), bool? isHttpAllowed = default(bool?), bool? isHttpsAllowed = default(bool?), QueryStringCachingBehavior? queryStringCachingBehavior = default(QueryStringCachingBehavior?), System.Collections.Generic.IList<GeoFilter> geoFilters = default(System.Collections.Generic.IList<GeoFilter>))
        {
            Location = location;
            Tags = tags;
            OriginHostHeader = originHostHeader;
            OriginPath = originPath;
            ContentTypesToCompress = contentTypesToCompress;
            IsCompressionEnabled = isCompressionEnabled;
            IsHttpAllowed = isHttpAllowed;
            IsHttpsAllowed = isHttpsAllowed;
            QueryStringCachingBehavior = queryStringCachingBehavior;
            Origins = origins;
            GeoFilters = geoFilters;
        }

        /// <summary>
        /// Gets or sets endpoint location
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets endpoint tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the host header CDN provider will send along with
        /// content requests to origins. The default value is the host name
        /// of the origin.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.originHostHeader")]
        public string OriginHostHeader { get; set; }

        /// <summary>
        /// Gets or sets the path used for origin requests.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.originPath")]
        public string OriginPath { get; set; }

        /// <summary>
        /// Gets or sets list of content types on which compression will be
        /// applied. The value for the elements should be a valid MIME type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.contentTypesToCompress")]
        public System.Collections.Generic.IList<string> ContentTypesToCompress { get; set; }

        /// <summary>
        /// Gets or sets indicates whether content compression is enabled.
        /// Default value is false. If compression is enabled, the content
        /// transferred from the CDN endpoint to the end user will be
        /// compressed. The requested content must be larger than 1 byte and
        /// smaller than 1 MB.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isCompressionEnabled")]
        public bool? IsCompressionEnabled { get; set; }

        /// <summary>
        /// Gets or sets indicates whether HTTP traffic is allowed on the
        /// endpoint. Default value is true. At least one protocol (HTTP or
        /// HTTPS) must be allowed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isHttpAllowed")]
        public bool? IsHttpAllowed { get; set; }

        /// <summary>
        /// Gets or sets indicates whether https traffic is allowed on the
        /// endpoint. Default value is true. At least one protocol (HTTP or
        /// HTTPS) must be allowed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isHttpsAllowed")]
        public bool? IsHttpsAllowed { get; set; }

        /// <summary>
        /// Gets or sets defines the query string caching behavior. Possible
        /// values include: 'IgnoreQueryString', 'BypassCaching',
        /// 'UseQueryString', 'NotSet'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.queryStringCachingBehavior")]
        public QueryStringCachingBehavior? QueryStringCachingBehavior { get; set; }

        /// <summary>
        /// Gets or sets the set of origins for the CDN endpoint. When
        /// multiple origins exist, the first origin will be used as primary
        /// and rest will be used as failover options.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.origins")]
        public System.Collections.Generic.IList<DeepCreatedOrigin> Origins { get; set; }

        /// <summary>
        /// Gets or sets the list of geo filters for the CDN endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.geoFilters")]
        public System.Collections.Generic.IList<GeoFilter> GeoFilters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Location");
            }
            if (Origins == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Origins");
            }
            if (this.Origins != null)
            {
                foreach (var element in this.Origins)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.GeoFilters != null)
            {
                foreach (var element1 in this.GeoFilters)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
