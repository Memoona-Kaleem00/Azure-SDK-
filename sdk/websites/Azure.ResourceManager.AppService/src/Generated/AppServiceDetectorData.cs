// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the AppServiceDetector data model.
    /// Class representing Response from Detector
    /// </summary>
    public partial class AppServiceDetectorData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceDetectorData"/>. </summary>
        public AppServiceDetectorData()
        {
            Dataset = new ChangeTrackingList<DiagnosticDataset>();
            DataProvidersMetadata = new ChangeTrackingList<DataProviderMetadata>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceDetectorData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="metadata"> metadata for the detector. </param>
        /// <param name="dataset"> Data Set. </param>
        /// <param name="status"> Indicates status of the most severe insight. </param>
        /// <param name="dataProvidersMetadata"> Additional configuration for different data providers to be used by the UI. </param>
        /// <param name="suggestedUtterances"> Suggested utterances where the detector can be applicable. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceDetectorData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DetectorInfo metadata, IList<DiagnosticDataset> dataset, AppServiceStatusInfo status, IList<DataProviderMetadata> dataProvidersMetadata, QueryUtterancesResults suggestedUtterances, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Metadata = metadata;
            Dataset = dataset;
            Status = status;
            DataProvidersMetadata = dataProvidersMetadata;
            SuggestedUtterances = suggestedUtterances;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> metadata for the detector. </summary>
        public DetectorInfo Metadata { get; set; }
        /// <summary> Data Set. </summary>
        public IList<DiagnosticDataset> Dataset { get; }
        /// <summary> Indicates status of the most severe insight. </summary>
        public AppServiceStatusInfo Status { get; set; }
        /// <summary> Additional configuration for different data providers to be used by the UI. </summary>
        public IList<DataProviderMetadata> DataProvidersMetadata { get; }
        /// <summary> Suggested utterances where the detector can be applicable. </summary>
        public QueryUtterancesResults SuggestedUtterances { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
