// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Properties for DataTransferServiceResource. </summary>
    public partial class DataTransferServiceProperties : CosmosDBServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="DataTransferServiceProperties"/>. </summary>
        public DataTransferServiceProperties()
        {
            Locations = new ChangeTrackingList<DataTransferRegionalService>();
            ServiceType = CosmosDBServiceType.DataTransfer;
        }

        /// <summary> Initializes a new instance of <see cref="DataTransferServiceProperties"/>. </summary>
        /// <param name="createdOn"> Time of the last state change (ISO-8601 format). </param>
        /// <param name="instanceSize"> Instance type for the service. </param>
        /// <param name="instanceCount"> Instance count for the service. </param>
        /// <param name="serviceType"> ServiceType for the service. </param>
        /// <param name="status"> Describes the status of a service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="locations"> An array that contains all of the locations for the service. </param>
        internal DataTransferServiceProperties(DateTimeOffset? createdOn, CosmosDBServiceSize? instanceSize, int? instanceCount, CosmosDBServiceType serviceType, CosmosDBServiceStatus? status, IDictionary<string, BinaryData> additionalProperties, IReadOnlyList<DataTransferRegionalService> locations) : base(createdOn, instanceSize, instanceCount, serviceType, status, additionalProperties)
        {
            Locations = locations;
            ServiceType = serviceType;
        }

        /// <summary> An array that contains all of the locations for the service. </summary>
        [WirePath("locations")]
        public IReadOnlyList<DataTransferRegionalService> Locations { get; }
    }
}
