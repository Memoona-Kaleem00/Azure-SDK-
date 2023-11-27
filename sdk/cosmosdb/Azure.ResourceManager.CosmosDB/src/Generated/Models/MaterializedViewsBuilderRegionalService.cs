// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Resource for a regional service location. </summary>
    public partial class MaterializedViewsBuilderRegionalService : CosmosDBRegionalService
    {
        /// <summary> Initializes a new instance of <see cref="MaterializedViewsBuilderRegionalService"/>. </summary>
        internal MaterializedViewsBuilderRegionalService()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MaterializedViewsBuilderRegionalService"/>. </summary>
        /// <param name="name"> The regional service name. </param>
        /// <param name="location"> The location name. </param>
        /// <param name="status"> Describes the status of a service. </param>
        internal MaterializedViewsBuilderRegionalService(string name, AzureLocation? location, CosmosDBServiceStatus? status) : base(name, location, status)
        {
        }
    }
}
