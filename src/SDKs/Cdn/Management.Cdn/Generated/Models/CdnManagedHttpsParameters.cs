// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the certificate source parameters using CDN managed certificate
    /// for enabling SSL.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Cdn")]
    public partial class CdnManagedHttpsParameters : CustomDomainHttpsParameters
    {
        /// <summary>
        /// Initializes a new instance of the CdnManagedHttpsParameters class.
        /// </summary>
        public CdnManagedHttpsParameters()
        {
            CertificateSourceParameters = new CdnCertificateSourceParameters();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CdnManagedHttpsParameters class.
        /// </summary>
        /// <param name="protocolType">Defines the TLS extension protocol that
        /// is used for secure delivery. Possible values include:
        /// 'ServerNameIndication', 'IPBased'</param>
        /// <param name="certificateSourceParameters">Defines the certificate
        /// source parameters using CDN managed certificate for enabling
        /// SSL.</param>
        public CdnManagedHttpsParameters(string protocolType, CdnCertificateSourceParameters certificateSourceParameters)
            : base(protocolType)
        {
            CertificateSourceParameters = certificateSourceParameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets defines the certificate source parameters using CDN
        /// managed certificate for enabling SSL.
        /// </summary>
        [JsonProperty(PropertyName = "certificateSourceParameters")]
        public CdnCertificateSourceParameters CertificateSourceParameters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (CertificateSourceParameters == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CertificateSourceParameters");
            }
            if (CertificateSourceParameters != null)
            {
                CertificateSourceParameters.Validate();
            }
        }
    }
}
