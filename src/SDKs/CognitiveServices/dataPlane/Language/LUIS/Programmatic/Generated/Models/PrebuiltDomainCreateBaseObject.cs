// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A model object containing the name of the custom prebuilt entity and
    /// the name of the domain to which this model belongs.
    /// </summary>
    public partial class PrebuiltDomainCreateBaseObject
    {
        /// <summary>
        /// Initializes a new instance of the PrebuiltDomainCreateBaseObject
        /// class.
        /// </summary>
        public PrebuiltDomainCreateBaseObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrebuiltDomainCreateBaseObject
        /// class.
        /// </summary>
        /// <param name="domainName">The domain name.</param>
        public PrebuiltDomainCreateBaseObject(string domainName = default(string))
        {
            DomainName = domainName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the domain name.
        /// </summary>
        [JsonProperty(PropertyName = "domainName")]
        public string DomainName { get; set; }

    }
}
