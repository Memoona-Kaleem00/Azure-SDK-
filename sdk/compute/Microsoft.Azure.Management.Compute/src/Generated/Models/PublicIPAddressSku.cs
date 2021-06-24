// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the public IP Sku
    /// </summary>
    public partial class PublicIPAddressSku
    {
        /// <summary>
        /// Initializes a new instance of the PublicIPAddressSku class.
        /// </summary>
        public PublicIPAddressSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublicIPAddressSku class.
        /// </summary>
        /// <param name="publicIPAddressSkuName">Specify public IP sku name.
        /// Possible values include: 'Basic', 'Standard'</param>
        /// <param name="publicIPAddressSkuTier">Specify public IP sku tier.
        /// Possible values include: 'Regional', 'Global'</param>
        public PublicIPAddressSku(string publicIPAddressSkuName, string publicIPAddressSkuTier = default(string))
        {
            PublicIPAddressSkuName = publicIPAddressSkuName;
            PublicIPAddressSkuTier = publicIPAddressSkuTier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specify public IP sku name. Possible values include:
        /// 'Basic', 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "publicIPAddressSkuName")]
        public string PublicIPAddressSkuName { get; set; }

        /// <summary>
        /// Gets or sets specify public IP sku tier. Possible values include:
        /// 'Regional', 'Global'
        /// </summary>
        [JsonProperty(PropertyName = "publicIPAddressSkuTier")]
        public string PublicIPAddressSkuTier { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PublicIPAddressSkuName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PublicIPAddressSkuName");
            }
        }
    }
}
