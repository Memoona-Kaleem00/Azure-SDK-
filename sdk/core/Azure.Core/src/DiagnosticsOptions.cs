﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Azure.Core
{
    /// <summary>
    ///
    /// </summary>
    public class DiagnosticsOptions
    {
        private const int MaxApplicationIdLength = 24;

        private string? _applicationId;

        internal DiagnosticsOptions()
        {
            IsTelemetryEnabled = !EnvironmentVariableToBool(Environment.GetEnvironmentVariable("AZURE_TELEMETRY_DISABLED")) ?? true;
            ApplicationId = DefaultApplicationId;
            LoggedHeaderNames = new List<string>()
            {
                "Date",
                "traceparent",
                "x-ms-client-request-id",
                "x-ms-request-id"
            };
            LoggedQueryParameters = new List<string>();
        }

        /// <summary>
        /// Get or sets value indicating whether HTTP pipeline logging is enabled.
        /// </summary>
        public bool IsLoggingEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets value indicating whether distributed tracing spans are going to be created for this clients methods calls and HTTP calls.
        /// </summary>
        public bool IsDistributedTracingEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets value indicating whether the "User-Agent" header containing <see cref="ApplicationId"/>, client library package name and version, <see cref="RuntimeInformation.FrameworkDescription"/>
        /// and <see cref="RuntimeInformation.OSDescription"/>.
        /// The default value can be controlled process wide by setting `AZURE_TELEMETRY_DISABLED` to true, false, 1 or 0.
        /// </summary>
        public bool IsTelemetryEnabled { get; set; }

        /// <summary>
        /// Gets or sets value indicating if request or response content should be logged.
        /// </summary>
        public bool IsLoggingContentEnabled { get; set; }

        /// <summary>
        /// Gets or sets value indicating maximum size of content to log in bytes. Defaults to 4096.
        /// </summary>
        public int LoggedContentSizeLimit { get; set; } = 4 * 1024;

        /// <summary>
        /// Gets a list of headers names that are not redacted during logging.
        /// </summary>
        public IList<string> LoggedHeaderNames { get; }

        /// <summary>
        /// Gets a list of query parameter names that are not redacted during logging.
        /// </summary>
        public IList<string> LoggedQueryParameters { get; }

        /// <summary>
        /// Gets or sets the value sent a the first part of "User-Agent" headers for all requests issues by this client. Defaults to <see cref="DefaultApplicationId"/>.
        /// </summary>
        public string? ApplicationId
        {
            get => _applicationId;
            set
            {
                if (value != null && value.Length > MaxApplicationIdLength)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(ApplicationId)} must be shorter than {MaxApplicationIdLength + 1} characters");
                }
                _applicationId = value;
            }
        }

        /// <summary>
        /// Gets or sets the default application id. Default application id would be set on all instaces
        /// </summary>
        public static string? DefaultApplicationId { get; set; }

        private static bool? EnvironmentVariableToBool(string value)
        {
            if (string.Equals("true", value, StringComparison.OrdinalIgnoreCase) ||
                string.Equals("1", value, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (string.Equals("false", value, StringComparison.OrdinalIgnoreCase) ||
                string.Equals("0", value, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            return null;
        }
    }
}
