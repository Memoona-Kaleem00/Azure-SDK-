// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Currency field value. </summary>
    public partial class CurrencyValue
    {
        /// <summary> Initializes a new instance of CurrencyValue. </summary>
        /// <param name="amount"> Currency amount. </param>
        internal CurrencyValue(double amount)
        {
            Amount = amount;
        }

        /// <summary> Initializes a new instance of CurrencyValue. </summary>
        /// <param name="amount"> Currency amount. </param>
        /// <param name="currencySymbol"> Currency symbol label, if any. </param>
        /// <param name="currencyCode"> Resolved currency code (ISO 4217), if any. </param>
        internal CurrencyValue(double amount, string currencySymbol, string currencyCode)
        {
            Amount = amount;
            CurrencySymbol = currencySymbol;
            CurrencyCode = currencyCode;
        }

        /// <summary> Currency amount. </summary>
        public double Amount { get; }
        /// <summary> Currency symbol label, if any. </summary>
        public string CurrencySymbol { get; }
        /// <summary> Resolved currency code (ISO 4217), if any. </summary>
        public string CurrencyCode { get; }
    }
}
