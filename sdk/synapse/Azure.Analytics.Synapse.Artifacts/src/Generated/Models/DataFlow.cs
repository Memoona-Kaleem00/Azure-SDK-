// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary>
    /// Azure Synapse nested object which contains a flow with data movements and transformations.
    /// Please note <see cref="DataFlow"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="Flowlet"/> and <see cref="MappingDataFlow"/>.
    /// </summary>
    public partial class DataFlow
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataFlow"/>. </summary>
        public DataFlow()
        {
            Annotations = new ChangeTrackingList<object>();
        }

        /// <summary> Initializes a new instance of <see cref="DataFlow"/>. </summary>
        /// <param name="type"> Type of data flow. </param>
        /// <param name="description"> The description of the data flow. </param>
        /// <param name="annotations"> List of tags that can be used for describing the data flow. </param>
        /// <param name="folder"> The folder that this data flow is in. If not specified, Data flow will appear at the root level. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFlow(string type, string description, IList<object> annotations, DataFlowFolder folder, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            Description = description;
            Annotations = annotations;
            Folder = folder;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of data flow. </summary>
        internal string Type { get; set; }
        /// <summary> The description of the data flow. </summary>
        public string Description { get; set; }
        /// <summary> List of tags that can be used for describing the data flow. </summary>
        public IList<object> Annotations { get; }
        /// <summary> The folder that this data flow is in. If not specified, Data flow will appear at the root level. </summary>
        public DataFlowFolder Folder { get; set; }
    }
}
