// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Datacenter address for given storage location.
    /// </summary>
    public partial class DatacenterAddressResponse
    {
        /// <summary>
        /// Initializes a new instance of the DatacenterAddressResponse class.
        /// </summary>
        public DatacenterAddressResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatacenterAddressResponse class.
        /// </summary>
        /// <param name="supportedCarriersForReturnShipment">List of supported
        /// carriers for return shipment.</param>
        /// <param name="dataCenterAzureLocation">Azure Location where the Data
        /// Center serves primarily.</param>
        public DatacenterAddressResponse(IList<string> supportedCarriersForReturnShipment = default(IList<string>), string dataCenterAzureLocation = default(string))
        {
            SupportedCarriersForReturnShipment = supportedCarriersForReturnShipment;
            DataCenterAzureLocation = dataCenterAzureLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of supported carriers for return shipment.
        /// </summary>
        [JsonProperty(PropertyName = "supportedCarriersForReturnShipment")]
        public IList<string> SupportedCarriersForReturnShipment { get; private set; }

        /// <summary>
        /// Gets azure Location where the Data Center serves primarily.
        /// </summary>
        [JsonProperty(PropertyName = "dataCenterAzureLocation")]
        public string DataCenterAzureLocation { get; private set; }

    }
}
