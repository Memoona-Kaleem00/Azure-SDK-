// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Request containing information needed for calculating refund. </summary>
    public partial class ReservationCalculateRefundContent
    {
        /// <summary> Initializes a new instance of <see cref="ReservationCalculateRefundContent"/>. </summary>
        public ReservationCalculateRefundContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReservationCalculateRefundContent"/>. </summary>
        /// <param name="id"> Fully qualified identifier of the reservation order being returned. </param>
        /// <param name="properties"> Properties needed for calculate refund including the scope and the reservation to be returned. </param>
        internal ReservationCalculateRefundContent(string id, ReservationCalculateRefundRequestProperties properties)
        {
            Id = id;
            Properties = properties;
        }

        /// <summary> Fully qualified identifier of the reservation order being returned. </summary>
        public string Id { get; set; }
        /// <summary> Properties needed for calculate refund including the scope and the reservation to be returned. </summary>
        public ReservationCalculateRefundRequestProperties Properties { get; set; }
    }
}
