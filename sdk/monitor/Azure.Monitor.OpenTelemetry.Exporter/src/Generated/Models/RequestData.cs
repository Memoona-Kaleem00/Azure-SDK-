// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    /// <summary> An instance of Request represents completion of an external request to the application to do work and contains a summary of that request execution and the results. </summary>
    internal partial class RequestData : MonitorDomain
    {
        /// <summary> Initializes a new instance of <see cref="RequestData"/>. </summary>
        /// <param name="version"> Schema version. </param>
        /// <param name="id"> Identifier of a request call instance. Used for correlation between request and other telemetry items. </param>
        /// <param name="duration"> Request duration in format: DD.HH:MM:SS.MMMMMM. Must be less than 1000 days. </param>
        /// <param name="success"> Indication of successful or unsuccessful call. </param>
        /// <param name="responseCode"> Result of a request execution. HTTP status code for HTTP requests. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="duration"/> or <paramref name="responseCode"/> is null. </exception>
        public RequestData(int version, string id, string duration, bool success, string responseCode) : base(version)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(duration, nameof(duration));
            Argument.AssertNotNull(responseCode, nameof(responseCode));

            Id = id;
            Duration = duration;
            Success = success;
            ResponseCode = responseCode;
            Properties = new ChangeTrackingDictionary<string, string>();
            Measurements = new ChangeTrackingDictionary<string, double>();
        }

        /// <summary> Initializes a new instance of <see cref="RequestData"/>. </summary>
        /// <param name="version"> Schema version. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="id"> Identifier of a request call instance. Used for correlation between request and other telemetry items. </param>
        /// <param name="name"> Name of the request. Represents code path taken to process request. Low cardinality value to allow better grouping of requests. For HTTP requests it represents the HTTP method and URL path template like 'GET /values/{id}'. </param>
        /// <param name="duration"> Request duration in format: DD.HH:MM:SS.MMMMMM. Must be less than 1000 days. </param>
        /// <param name="success"> Indication of successful or unsuccessful call. </param>
        /// <param name="responseCode"> Result of a request execution. HTTP status code for HTTP requests. </param>
        /// <param name="source"> Source of the request. Examples are the instrumentation key of the caller or the ip address of the caller. </param>
        /// <param name="url"> Request URL with all query string parameters. </param>
        /// <param name="properties"> Collection of custom properties. </param>
        /// <param name="measurements"> Collection of custom measurements. </param>
        internal RequestData(int version, IDictionary<string, object> additionalProperties, string id, string name, string duration, bool success, string responseCode, string source, string url, IDictionary<string, string> properties, IDictionary<string, double> measurements) : base(version, additionalProperties)
        {
            Id = id;
            Name = name;
            Duration = duration;
            Success = success;
            ResponseCode = responseCode;
            Source = source;
            Url = url;
            Properties = properties;
            Measurements = measurements;
        }

        /// <summary> Identifier of a request call instance. Used for correlation between request and other telemetry items. </summary>
        public string Id { get; }
        /// <summary> Name of the request. Represents code path taken to process request. Low cardinality value to allow better grouping of requests. For HTTP requests it represents the HTTP method and URL path template like 'GET /values/{id}'. </summary>
        public string Name { get; set; }
        /// <summary> Request duration in format: DD.HH:MM:SS.MMMMMM. Must be less than 1000 days. </summary>
        public string Duration { get; }
        /// <summary> Indication of successful or unsuccessful call. </summary>
        public bool Success { get; }
        /// <summary> Result of a request execution. HTTP status code for HTTP requests. </summary>
        public string ResponseCode { get; }
        /// <summary> Source of the request. Examples are the instrumentation key of the caller or the ip address of the caller. </summary>
        public string Source { get; set; }
        /// <summary> Request URL with all query string parameters. </summary>
        public string Url { get; set; }
        /// <summary> Collection of custom properties. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Collection of custom measurements. </summary>
        public IDictionary<string, double> Measurements { get; }
    }
}
