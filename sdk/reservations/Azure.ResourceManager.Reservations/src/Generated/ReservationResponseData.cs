// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Reservations.Models;

namespace Azure.ResourceManager.Reservations
{
    /// <summary> A class representing the ReservationResponse data model. </summary>
    public partial class ReservationResponseData : ResourceData
    {
        /// <summary> Initializes a new instance of ReservationResponseData. </summary>
        internal ReservationResponseData()
        {
            Kind = "Microsoft.Compute";
        }

        /// <summary> Initializes a new instance of ReservationResponseData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The Azure Region where the reserved resource lives. </param>
        /// <param name="etag"></param>
        /// <param name="sku"> The sku information associated to this reservation. </param>
        /// <param name="properties"> The properties associated to this reservation. </param>
        /// <param name="kind"> Resource Provider type to be reserved. </param>
        internal ReservationResponseData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, ETag? etag, ReservationsSkuName sku, ReservationsProperties properties, string kind) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Etag = etag;
            Sku = sku;
            Properties = properties;
            Kind = kind;
        }

        /// <summary> The Azure Region where the reserved resource lives. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Gets the etag. </summary>
        public ETag? Etag { get; }
        /// <summary> The sku information associated to this reservation. </summary>
        internal ReservationsSkuName Sku { get; }
        /// <summary> Gets or sets the sku name. </summary>
        public string SkuName
        {
            get => Sku?.Name;
        }

        /// <summary> The properties associated to this reservation. </summary>
        public ReservationsProperties Properties { get; }
        /// <summary> Resource Provider type to be reserved. </summary>
        public string Kind { get; }
    }
}
