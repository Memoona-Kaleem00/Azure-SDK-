// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple8000Series.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents the network settings of a device.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NetworkSettings : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the NetworkSettings class.
        /// </summary>
        public NetworkSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkSettings class.
        /// </summary>
        /// <param name="dnsSettings">The DNS (Domain Name System) settings of
        /// device.</param>
        /// <param name="networkAdapters">The network adapter list of
        /// device.</param>
        /// <param name="webproxySettings">The webproxy settings of
        /// device.</param>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The name of the object.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="kind">The Kind of the object. Currently only
        /// Series8000 is supported. Possible values include:
        /// 'Series8000'</param>
        public NetworkSettings(DNSSettings dnsSettings, NetworkAdapterList networkAdapters, WebproxySettings webproxySettings, string id = default(string), string name = default(string), string type = default(string), Kind? kind = default(Kind?))
            : base(id, name, type, kind)
        {
            DnsSettings = dnsSettings;
            NetworkAdapters = networkAdapters;
            WebproxySettings = webproxySettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the DNS (Domain Name System) settings of device.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsSettings")]
        public DNSSettings DnsSettings { get; set; }

        /// <summary>
        /// Gets or sets the network adapter list of device.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkAdapters")]
        public NetworkAdapterList NetworkAdapters { get; set; }

        /// <summary>
        /// Gets or sets the webproxy settings of device.
        /// </summary>
        [JsonProperty(PropertyName = "properties.webproxySettings")]
        public WebproxySettings WebproxySettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DnsSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DnsSettings");
            }
            if (NetworkAdapters == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NetworkAdapters");
            }
            if (WebproxySettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WebproxySettings");
            }
            if (NetworkAdapters != null)
            {
                NetworkAdapters.Validate();
            }
            if (WebproxySettings != null)
            {
                WebproxySettings.Validate();
            }
        }
    }
}
