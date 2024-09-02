// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> MLTable data definition. </summary>
    public partial class MachineLearningTable : MachineLearningDataVersionProperties
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningTable"/>. </summary>
        /// <param name="dataUri"> [Required] Uri of the data. Example: https://go.microsoft.com/fwlink/?linkid=2202330. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataUri"/> is null. </exception>
        public MachineLearningTable(Uri dataUri) : base(dataUri)
        {
            Argument.AssertNotNull(dataUri, nameof(dataUri));

            ReferencedUris = new ChangeTrackingList<Uri>();
            DataType = MachineLearningDataType.Mltable;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningTable"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). </param>
        /// <param name="dataType"> [Required] Specifies the type of data. </param>
        /// <param name="dataUri"> [Required] Uri of the data. Example: https://go.microsoft.com/fwlink/?linkid=2202330. </param>
        /// <param name="referencedUris"> Uris referenced in the MLTable definition (required for lineage). </param>
        internal MachineLearningTable(string description, IDictionary<string, string> tags, IDictionary<string, string> properties, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? isArchived, bool? isAnonymous, MachineLearningDataType dataType, Uri dataUri, IList<Uri> referencedUris) : base(description, tags, properties, serializedAdditionalRawData, isArchived, isAnonymous, dataType, dataUri)
        {
            ReferencedUris = referencedUris;
            DataType = dataType;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningTable"/> for deserialization. </summary>
        internal MachineLearningTable()
        {
        }

        /// <summary> Uris referenced in the MLTable definition (required for lineage). </summary>
        public IList<Uri> ReferencedUris { get; set; }
    }
}
