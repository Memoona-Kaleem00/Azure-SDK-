// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary>
    /// Datacenter address for given storage location.
    /// Please note <see cref="DatacenterAddressResponse"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DatacenterAddressInstructionResponse"/> and <see cref="DatacenterAddressLocationResponse"/>.
    /// </summary>
    public abstract partial class DatacenterAddressResponse
    {
        /// <summary> Initializes a new instance of DatacenterAddressResponse. </summary>
        protected DatacenterAddressResponse()
        {
            SupportedCarriersForReturnShipment = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DatacenterAddressResponse. </summary>
        /// <param name="datacenterAddressType"> Data center address type. </param>
        /// <param name="supportedCarriersForReturnShipment"> List of supported carriers for return shipment. </param>
        /// <param name="dataCenterAzureLocation"> Azure Location where the Data Center serves primarily. </param>
        internal DatacenterAddressResponse(DatacenterAddressType datacenterAddressType, IReadOnlyList<string> supportedCarriersForReturnShipment, string dataCenterAzureLocation)
        {
            DatacenterAddressType = datacenterAddressType;
            SupportedCarriersForReturnShipment = supportedCarriersForReturnShipment;
            DataCenterAzureLocation = dataCenterAzureLocation;
        }

        /// <summary> Data center address type. </summary>
        internal DatacenterAddressType DatacenterAddressType { get; set; }
        /// <summary> List of supported carriers for return shipment. </summary>
        public IReadOnlyList<string> SupportedCarriersForReturnShipment { get; }
        /// <summary> Azure Location where the Data Center serves primarily. </summary>
        public string DataCenterAzureLocation { get; }
    }
}
