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
    /// Collection of Diagnostic Analyses
    /// Serialized Name: DiagnosticAnalysisCollection
    /// </summary>
    internal partial class DiagnosticAnalysisCollection
    {
        /// <summary> Initializes a new instance of DiagnosticAnalysisCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: DiagnosticAnalysisCollection.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DiagnosticAnalysisCollection(IEnumerable<AnalysisDefinitionData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DiagnosticAnalysisCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: DiagnosticAnalysisCollection.value
        /// </param>
        /// <param name="nextLink">
        /// Link to next page of resources.
        /// Serialized Name: DiagnosticAnalysisCollection.nextLink
        /// </param>
        internal DiagnosticAnalysisCollection(IReadOnlyList<AnalysisDefinitionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources.
        /// Serialized Name: DiagnosticAnalysisCollection.value
        /// </summary>
        public IReadOnlyList<AnalysisDefinitionData> Value { get; }
        /// <summary>
        /// Link to next page of resources.
        /// Serialized Name: DiagnosticAnalysisCollection.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
