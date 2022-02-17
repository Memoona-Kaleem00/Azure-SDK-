﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Reflection;

namespace Azure.Core.Pipeline
{
    /// <summary>
    ///
    /// </summary>
    public static class HttpMessageEtensions
    {
        /// <summary>
        /// Sets the package name and version portion of the UserAgent telemetry value.
        /// Note: If <see cref="DiagnosticsOptions.IsTelemetryEnabled"/> is false, this value is never used.
        /// </summary>
        /// <param name="message">The message to set this info on.</param>
        /// <param name="packageInfo"> </param>
        public static void SetTelemetryPackageInfo(this HttpMessage message, TelemetryPackageInfo packageInfo)
        {
            message.SetInternalProperty(packageInfo);
        }
    }
}
