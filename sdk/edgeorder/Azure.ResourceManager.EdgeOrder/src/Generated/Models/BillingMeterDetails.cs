// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Holds billing meter details for each type of billing. </summary>
    public partial class BillingMeterDetails
    {
        /// <summary> Initializes a new instance of BillingMeterDetails. </summary>
        internal BillingMeterDetails()
        {
        }

        /// <summary> Initializes a new instance of BillingMeterDetails. </summary>
        /// <param name="name"> Represents Billing type name. </param>
        /// <param name="meterDetails">
        /// Represents MeterDetails
        /// Please note <see cref="MeterDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Pav2MeterDetails"/> and <see cref="PurchaseMeterDetails"/>.
        /// </param>
        /// <param name="meteringType"> Represents Metering type (eg one-time or recurrent). </param>
        /// <param name="frequency"> Frequency of recurrence. </param>
        internal BillingMeterDetails(string name, MeterDetails meterDetails, MeteringType? meteringType, string frequency)
        {
            Name = name;
            MeterDetails = meterDetails;
            MeteringType = meteringType;
            Frequency = frequency;
        }

        /// <summary> Represents Billing type name. </summary>
        public string Name { get; }
        /// <summary>
        /// Represents MeterDetails
        /// Please note <see cref="MeterDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Pav2MeterDetails"/> and <see cref="PurchaseMeterDetails"/>.
        /// </summary>
        public MeterDetails MeterDetails { get; }
        /// <summary> Represents Metering type (eg one-time or recurrent). </summary>
        public MeteringType? MeteringType { get; }
        /// <summary> Frequency of recurrence. </summary>
        public string Frequency { get; }
    }
}
