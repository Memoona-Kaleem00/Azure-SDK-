// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningDatastoreCollectionGetAllOptions. </summary>
    public partial class MachineLearningDatastoreCollectionGetAllOptions
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningDatastoreCollectionGetAllOptions"/>. </summary>
        public MachineLearningDatastoreCollectionGetAllOptions()
        {
            Names = new ChangeTrackingList<string>();
        }

        /// <summary> Continuation token for pagination. </summary>
        [WirePath("skip")]
        public string Skip { get; set; }
        /// <summary> Maximum number of results to return. </summary>
        [WirePath("count")]
        public int? Count { get; set; }
        /// <summary> Filter down to the workspace default datastore. </summary>
        [WirePath("isDefault")]
        public bool? IsDefault { get; set; }
        /// <summary> Names of datastores to return. </summary>
        [WirePath("names")]
        public IList<string> Names { get; }
        /// <summary> Text to search for in the datastore names. </summary>
        [WirePath("searchText")]
        public string SearchText { get; set; }
        /// <summary> Order by property (createdtime | modifiedtime | name). </summary>
        [WirePath("orderBy")]
        public string OrderBy { get; set; }
        /// <summary> Order by property in ascending order. </summary>
        [WirePath("orderByAsc")]
        public bool? OrderByAsc { get; set; }
    }
}
