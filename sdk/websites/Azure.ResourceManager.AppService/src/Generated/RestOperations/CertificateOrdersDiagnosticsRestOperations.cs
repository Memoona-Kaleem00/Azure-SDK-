// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    internal partial class CertificateOrdersDiagnosticsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of CertificateOrdersDiagnosticsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public CertificateOrdersDiagnosticsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-02-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListAppServiceCertificateOrderDetectorResponseRequestUri(string subscriptionId, string resourceGroupName, string certificateOrderName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.CertificateRegistration/certificateOrders/", false);
            uri.AppendPath(certificateOrderName, true);
            uri.AppendPath("/detectors", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListAppServiceCertificateOrderDetectorResponseRequest(string subscriptionId, string resourceGroupName, string certificateOrderName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.CertificateRegistration/certificateOrders/", false);
            uri.AppendPath(certificateOrderName, true);
            uri.AppendPath("/detectors", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Description for Microsoft.CertificateRegistration to get the list of detectors for this RP. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="certificateOrderName"> The certificate order name for which the response is needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="certificateOrderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AppServiceDetectorListResult>> ListAppServiceCertificateOrderDetectorResponseAsync(string subscriptionId, string resourceGroupName, string certificateOrderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));

            using var message = CreateListAppServiceCertificateOrderDetectorResponseRequest(subscriptionId, resourceGroupName, certificateOrderName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppServiceDetectorListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AppServiceDetectorListResult.DeserializeAppServiceDetectorListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Description for Microsoft.CertificateRegistration to get the list of detectors for this RP. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="certificateOrderName"> The certificate order name for which the response is needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="certificateOrderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AppServiceDetectorListResult> ListAppServiceCertificateOrderDetectorResponse(string subscriptionId, string resourceGroupName, string certificateOrderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));

            using var message = CreateListAppServiceCertificateOrderDetectorResponseRequest(subscriptionId, resourceGroupName, certificateOrderName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppServiceDetectorListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AppServiceDetectorListResult.DeserializeAppServiceDetectorListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetAppServiceCertificateOrderDetectorResponseRequestUri(string subscriptionId, string resourceGroupName, string certificateOrderName, string detectorName, DateTimeOffset? startTime, DateTimeOffset? endTime, string timeGrain)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.CertificateRegistration/certificateOrders/", false);
            uri.AppendPath(certificateOrderName, true);
            uri.AppendPath("/detectors/", false);
            uri.AppendPath(detectorName, true);
            if (startTime != null)
            {
                uri.AppendQuery("startTime", startTime.Value, "O", true);
            }
            if (endTime != null)
            {
                uri.AppendQuery("endTime", endTime.Value, "O", true);
            }
            if (timeGrain != null)
            {
                uri.AppendQuery("timeGrain", timeGrain, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetAppServiceCertificateOrderDetectorResponseRequest(string subscriptionId, string resourceGroupName, string certificateOrderName, string detectorName, DateTimeOffset? startTime, DateTimeOffset? endTime, string timeGrain)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.CertificateRegistration/certificateOrders/", false);
            uri.AppendPath(certificateOrderName, true);
            uri.AppendPath("/detectors/", false);
            uri.AppendPath(detectorName, true);
            if (startTime != null)
            {
                uri.AppendQuery("startTime", startTime.Value, "O", true);
            }
            if (endTime != null)
            {
                uri.AppendQuery("endTime", endTime.Value, "O", true);
            }
            if (timeGrain != null)
            {
                uri.AppendQuery("timeGrain", timeGrain, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Description for Microsoft.CertificateRegistration call to get a detector response from App Lens. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="certificateOrderName"> The certificate order name for which the response is needed. </param>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="certificateOrderName"/> or <paramref name="detectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="certificateOrderName"/> or <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AppServiceDetectorData>> GetAppServiceCertificateOrderDetectorResponseAsync(string subscriptionId, string resourceGroupName, string certificateOrderName, string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var message = CreateGetAppServiceCertificateOrderDetectorResponseRequest(subscriptionId, resourceGroupName, certificateOrderName, detectorName, startTime, endTime, timeGrain);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppServiceDetectorData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AppServiceDetectorData.DeserializeAppServiceDetectorData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AppServiceDetectorData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Description for Microsoft.CertificateRegistration call to get a detector response from App Lens. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="certificateOrderName"> The certificate order name for which the response is needed. </param>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="certificateOrderName"/> or <paramref name="detectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="certificateOrderName"/> or <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AppServiceDetectorData> GetAppServiceCertificateOrderDetectorResponse(string subscriptionId, string resourceGroupName, string certificateOrderName, string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var message = CreateGetAppServiceCertificateOrderDetectorResponseRequest(subscriptionId, resourceGroupName, certificateOrderName, detectorName, startTime, endTime, timeGrain);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppServiceDetectorData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AppServiceDetectorData.DeserializeAppServiceDetectorData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AppServiceDetectorData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListAppServiceCertificateOrderDetectorResponseNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string certificateOrderName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListAppServiceCertificateOrderDetectorResponseNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string certificateOrderName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Description for Microsoft.CertificateRegistration to get the list of detectors for this RP. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="certificateOrderName"> The certificate order name for which the response is needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="certificateOrderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AppServiceDetectorListResult>> ListAppServiceCertificateOrderDetectorResponseNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string certificateOrderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));

            using var message = CreateListAppServiceCertificateOrderDetectorResponseNextPageRequest(nextLink, subscriptionId, resourceGroupName, certificateOrderName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppServiceDetectorListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AppServiceDetectorListResult.DeserializeAppServiceDetectorListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Description for Microsoft.CertificateRegistration to get the list of detectors for this RP. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="certificateOrderName"> The certificate order name for which the response is needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="certificateOrderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="certificateOrderName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AppServiceDetectorListResult> ListAppServiceCertificateOrderDetectorResponseNextPage(string nextLink, string subscriptionId, string resourceGroupName, string certificateOrderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(certificateOrderName, nameof(certificateOrderName));

            using var message = CreateListAppServiceCertificateOrderDetectorResponseNextPageRequest(nextLink, subscriptionId, resourceGroupName, certificateOrderName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppServiceDetectorListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AppServiceDetectorListResult.DeserializeAppServiceDetectorListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
