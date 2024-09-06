// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ApplicationInsights;

/// <summary>
/// The collection of request properties.
/// </summary>
public partial class WebTestRequest : ProvisioningConstruct
{
    /// <summary>
    /// Url location to test.
    /// </summary>
    public BicepValue<Uri> RequestUri { get => _requestUri; set => _requestUri.Assign(value); }
    private readonly BicepValue<Uri> _requestUri;

    /// <summary>
    /// List of headers and their values to add to the WebTest call.
    /// </summary>
    public BicepList<WebTestRequestHeaderField> Headers { get => _headers; set => _headers.Assign(value); }
    private readonly BicepList<WebTestRequestHeaderField> _headers;

    /// <summary>
    /// Http verb to use for this web test.
    /// </summary>
    public BicepValue<string> HttpVerb { get => _httpVerb; set => _httpVerb.Assign(value); }
    private readonly BicepValue<string> _httpVerb;

    /// <summary>
    /// Base64 encoded string body to send with this web test.
    /// </summary>
    public BicepValue<string> RequestBody { get => _requestBody; set => _requestBody.Assign(value); }
    private readonly BicepValue<string> _requestBody;

    /// <summary>
    /// Parse Dependent request for this WebTest.
    /// </summary>
    public BicepValue<bool> ParseDependentRequests { get => _parseDependentRequests; set => _parseDependentRequests.Assign(value); }
    private readonly BicepValue<bool> _parseDependentRequests;

    /// <summary>
    /// Follow redirects for this web test.
    /// </summary>
    public BicepValue<bool> FollowRedirects { get => _followRedirects; set => _followRedirects.Assign(value); }
    private readonly BicepValue<bool> _followRedirects;

    /// <summary>
    /// Creates a new WebTestRequest.
    /// </summary>
    public WebTestRequest()
    {
        _requestUri = BicepValue<Uri>.DefineProperty(this, "RequestUri", ["RequestUrl"]);
        _headers = BicepList<WebTestRequestHeaderField>.DefineProperty(this, "Headers", ["Headers"]);
        _httpVerb = BicepValue<string>.DefineProperty(this, "HttpVerb", ["HttpVerb"]);
        _requestBody = BicepValue<string>.DefineProperty(this, "RequestBody", ["RequestBody"]);
        _parseDependentRequests = BicepValue<bool>.DefineProperty(this, "ParseDependentRequests", ["ParseDependentRequests"]);
        _followRedirects = BicepValue<bool>.DefineProperty(this, "FollowRedirects", ["FollowRedirects"]);
    }
}
