// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Collection of Diagnostic Detectors
    /// Serialized Name: DiagnosticDetectorCollection
    /// </summary>
    internal partial class DiagnosticDetectorCollection
    {
        /// <summary> Initializes a new instance of DiagnosticDetectorCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: DiagnosticDetectorCollection.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DiagnosticDetectorCollection(IEnumerable<DetectorDefinitionAutoGeneratedData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DiagnosticDetectorCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: DiagnosticDetectorCollection.value
        /// </param>
        /// <param name="nextLink">
        /// Link to next page of resources.
        /// Serialized Name: DiagnosticDetectorCollection.nextLink
        /// </param>
        internal DiagnosticDetectorCollection(IReadOnlyList<DetectorDefinitionAutoGeneratedData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources.
        /// Serialized Name: DiagnosticDetectorCollection.value
        /// </summary>
        public IReadOnlyList<DetectorDefinitionAutoGeneratedData> Value { get; }
        /// <summary>
        /// Link to next page of resources.
        /// Serialized Name: DiagnosticDetectorCollection.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
