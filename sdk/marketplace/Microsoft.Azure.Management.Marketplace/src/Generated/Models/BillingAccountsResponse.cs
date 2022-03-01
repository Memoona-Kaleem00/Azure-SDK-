// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Marketplace.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Billing accounts response object
    /// </summary>
    public partial class BillingAccountsResponse
    {
        /// <summary>
        /// Initializes a new instance of the BillingAccountsResponse class.
        /// </summary>
        public BillingAccountsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingAccountsResponse class.
        /// </summary>
        /// <param name="billingAccounts">Billing accounts list</param>
        public BillingAccountsResponse(IList<string> billingAccounts = default(IList<string>))
        {
            BillingAccounts = billingAccounts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets billing accounts list
        /// </summary>
        [JsonProperty(PropertyName = "billingAccounts")]
        public IList<string> BillingAccounts { get; set; }

    }
}
