// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A billing profile resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BillingProfile : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BillingProfile class.
        /// </summary>
        public BillingProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingProfile class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">The billing profile name.</param>
        /// <param name="poNumber">Purchase order number.</param>
        /// <param name="billingAddress">Billing address.</param>
        /// <param name="invoiceEmailOptIn">If the billing profile is opted in
        /// to recieve invoices via email.</param>
        /// <param name="isClassic">Is OMS bootstrapped billing
        /// profile.</param>
        /// <param name="invoiceDay">Invoice day.</param>
        /// <param name="currency">The currency associated with the billing
        /// profile.</param>
        /// <param name="enabledAzureSKUs">Information about the
        /// product.</param>
        /// <param name="invoiceSections">The invoice sections associated to
        /// the billing profile.</param>
        public BillingProfile(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), string poNumber = default(string), Address billingAddress = default(Address), bool? invoiceEmailOptIn = default(bool?), bool? isClassic = default(bool?), int? invoiceDay = default(int?), string currency = default(string), IList<EnabledAzureSKUs> enabledAzureSKUs = default(IList<EnabledAzureSKUs>), IList<InvoiceSection> invoiceSections = default(IList<InvoiceSection>))
            : base(id, name, type)
        {
            DisplayName = displayName;
            PoNumber = poNumber;
            BillingAddress = billingAddress;
            InvoiceEmailOptIn = invoiceEmailOptIn;
            IsClassic = isClassic;
            InvoiceDay = invoiceDay;
            Currency = currency;
            EnabledAzureSKUs = enabledAzureSKUs;
            InvoiceSections = invoiceSections;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the billing profile name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets purchase order number.
        /// </summary>
        [JsonProperty(PropertyName = "properties.poNumber")]
        public string PoNumber { get; set; }

        /// <summary>
        /// Gets or sets billing address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingAddress")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets if the billing profile is opted in to recieve invoices via
        /// email.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceEmailOptIn")]
        public bool? InvoiceEmailOptIn { get; private set; }

        /// <summary>
        /// Gets is OMS bootstrapped billing profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isClassic")]
        public bool? IsClassic { get; private set; }

        /// <summary>
        /// Gets invoice day.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceDay")]
        public int? InvoiceDay { get; private set; }

        /// <summary>
        /// Gets the currency associated with the billing profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// Gets or sets information about the product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabledAzureSKUs")]
        public IList<EnabledAzureSKUs> EnabledAzureSKUs { get; set; }

        /// <summary>
        /// Gets or sets the invoice sections associated to the billing
        /// profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSections")]
        public IList<InvoiceSection> InvoiceSections { get; set; }

    }
}
