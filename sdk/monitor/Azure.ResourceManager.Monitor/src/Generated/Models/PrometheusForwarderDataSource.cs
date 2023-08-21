// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Definition of Prometheus metrics forwarding configuration. </summary>
    public partial class PrometheusForwarderDataSource
    {
        /// <summary> Initializes a new instance of PrometheusForwarderDataSource. </summary>
        public PrometheusForwarderDataSource()
        {
            Streams = new Core.ChangeTrackingList<DataCollectionRuleKnownPrometheusForwarderDataSourceStream>();
            LabelIncludeFilter = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of PrometheusForwarderDataSource. </summary>
        /// <param name="streams"> List of streams that this data source will be sent to. </param>
        /// <param name="labelIncludeFilter">
        /// The list of label inclusion filters in the form of label "name-value" pairs.
        /// Currently only one label is supported: 'microsoft_metrics_include_label'.
        /// Label values are matched case-insensitively.
        /// </param>
        /// <param name="name">
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </param>
        internal PrometheusForwarderDataSource(IList<DataCollectionRuleKnownPrometheusForwarderDataSourceStream> streams, IDictionary<string, string> labelIncludeFilter, string name)
        {
            Streams = streams;
            LabelIncludeFilter = labelIncludeFilter;
            Name = name;
        }

        /// <summary> List of streams that this data source will be sent to. </summary>
        public IList<DataCollectionRuleKnownPrometheusForwarderDataSourceStream> Streams { get; }
        /// <summary>
        /// The list of label inclusion filters in the form of label "name-value" pairs.
        /// Currently only one label is supported: 'microsoft_metrics_include_label'.
        /// Label values are matched case-insensitively.
        /// </summary>
        public IDictionary<string, string> LabelIncludeFilter { get; }
        /// <summary>
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}
