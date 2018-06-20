// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.AzureBridge.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Published activation resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ActivationResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ActivationResource class.
        /// </summary>
        public ActivationResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivationResource class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Location of the resource</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="displayName">Name displayed for the product.</param>
        /// <param name="azureRegistrationResourceIdentifier">Azure
        /// registration resource identifier.</param>
        /// <param name="provisioningState">Provisioning state of the resource.
        /// Possible values include: 'Stopped', 'Starting', 'Running',
        /// 'Stopping', 'Succeeded', 'Downloading'</param>
        /// <param name="expiration">The activation expiration.</param>
        /// <param name="marketplaceSyndicationEnabled">Value indicating
        /// whether the marketplace syndication feature is enabled.</param>
        /// <param name="usageReportingEnabled">Value indicating whether the
        /// usage reporting feature is enabled.</param>
        public ActivationResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string displayName = default(string), string azureRegistrationResourceIdentifier = default(string), string provisioningState = default(string), string expiration = default(string), bool? marketplaceSyndicationEnabled = default(bool?), bool? usageReportingEnabled = default(bool?))
            : base(id, name, type, location, tags)
        {
            DisplayName = displayName;
            AzureRegistrationResourceIdentifier = azureRegistrationResourceIdentifier;
            ProvisioningState = provisioningState;
            Expiration = expiration;
            MarketplaceSyndicationEnabled = marketplaceSyndicationEnabled;
            UsageReportingEnabled = usageReportingEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name displayed for the product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets azure registration resource identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureRegistrationResourceIdentifier")]
        public string AzureRegistrationResourceIdentifier { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the resource. Possible values
        /// include: 'Stopped', 'Starting', 'Running', 'Stopping', 'Succeeded',
        /// 'Downloading'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the activation expiration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expiration")]
        public string Expiration { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether the marketplace syndication
        /// feature is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.marketplaceSyndicationEnabled")]
        public bool? MarketplaceSyndicationEnabled { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether the usage reporting feature
        /// is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageReportingEnabled")]
        public bool? UsageReportingEnabled { get; set; }

    }
}
