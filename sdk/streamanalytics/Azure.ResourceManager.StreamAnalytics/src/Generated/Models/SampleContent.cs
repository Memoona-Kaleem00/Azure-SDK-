// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// The stream analytics input to sample.
    /// Serialized Name: SampleInput
    /// </summary>
    public partial class SampleContent
    {
        /// <summary> Initializes a new instance of SampleContent. </summary>
        public SampleContent()
        {
        }

        /// <summary>
        /// The stream analytics input to sample.
        /// Serialized Name: SampleInput.input
        /// </summary>
        public StreamingJobInputData Input { get; set; }
        /// <summary>
        /// Defaults to the default ASA job compatibility level. Today it is 1.2
        /// Serialized Name: SampleInput.compatibilityLevel
        /// </summary>
        public string CompatibilityLevel { get; set; }
        /// <summary>
        /// The SAS URI of the storage blob for service to write the sampled events to. If this parameter is not provided, service will write events to he system account and share a temporary SAS URI to it.
        /// Serialized Name: SampleInput.eventsUri
        /// </summary>
        public Uri EventsUri { get; set; }
        /// <summary>
        /// Defaults to en-US.
        /// Serialized Name: SampleInput.dataLocale
        /// </summary>
        public string DataLocale { get; set; }
    }
}
