// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Reference objects for custom activity. </summary>
    public partial class CustomActivityReferenceObject
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CustomActivityReferenceObject"/>. </summary>
        public CustomActivityReferenceObject()
        {
            LinkedServices = new ChangeTrackingList<LinkedServiceReference>();
            Datasets = new ChangeTrackingList<DatasetReference>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomActivityReferenceObject"/>. </summary>
        /// <param name="linkedServices"> Linked service references. </param>
        /// <param name="datasets"> Dataset references. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomActivityReferenceObject(IList<LinkedServiceReference> linkedServices, IList<DatasetReference> datasets, Dictionary<string, BinaryData> rawData)
        {
            LinkedServices = linkedServices;
            Datasets = datasets;
            _rawData = rawData;
        }

        /// <summary> Linked service references. </summary>
        public IList<LinkedServiceReference> LinkedServices { get; }
        /// <summary> Dataset references. </summary>
        public IList<DatasetReference> Datasets { get; }
    }
}
