// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Json-serialized array of User subscription quota response
    /// </summary>
    public partial class UserSubscriptionQuotaListResult
    {
        /// <summary>
        /// Initializes a new instance of the UserSubscriptionQuotaListResult
        /// class.
        /// </summary>
        public UserSubscriptionQuotaListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserSubscriptionQuotaListResult
        /// class.
        /// </summary>
        public UserSubscriptionQuotaListResult(IList<UserSubscriptionQuota> value = default(IList<UserSubscriptionQuota>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<UserSubscriptionQuota> Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
