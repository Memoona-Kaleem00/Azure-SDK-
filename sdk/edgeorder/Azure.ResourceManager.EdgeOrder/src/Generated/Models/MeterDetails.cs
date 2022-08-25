// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary>
    /// Holds details about billing type and its meter guids
    /// Please note <see cref="MeterDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="Pav2MeterDetails"/> and <see cref="PurchaseMeterDetails"/>.
    /// </summary>
    public abstract partial class MeterDetails
    {
        /// <summary> Initializes a new instance of MeterDetails. </summary>
        protected MeterDetails()
        {
        }

        /// <summary> Initializes a new instance of MeterDetails. </summary>
        /// <param name="billingType"> Represents billing type. </param>
        /// <param name="multiplier"> Billing unit applicable for Pav2 billing. </param>
        /// <param name="chargingType"> Charging type. </param>
        internal MeterDetails(BillingType billingType, double? multiplier, ChargingType? chargingType)
        {
            BillingType = billingType;
            Multiplier = multiplier;
            ChargingType = chargingType;
        }

        /// <summary> Represents billing type. </summary>
        internal BillingType BillingType { get; set; }
        /// <summary> Billing unit applicable for Pav2 billing. </summary>
        public double? Multiplier { get; }
        /// <summary> Charging type. </summary>
        public ChargingType? ChargingType { get; }
    }
}
