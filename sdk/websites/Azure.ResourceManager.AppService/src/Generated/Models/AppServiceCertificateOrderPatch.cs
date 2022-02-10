// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> ARM resource for a certificate order that is purchased through Azure. </summary>
    public partial class AppServiceCertificateOrderPatch : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of AppServiceCertificateOrderPatch. </summary>
        public AppServiceCertificateOrderPatch()
        {
            Certificates = new ChangeTrackingDictionary<string, AppServiceCertificate>();
            AppServiceCertificateNotRenewableReasons = new ChangeTrackingList<AppServiceCertificateNotRenewableReason>();
        }

        /// <summary> Initializes a new instance of AppServiceCertificateOrderPatch. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="certificates"> State of the Key Vault secret. </param>
        /// <param name="distinguishedName"> Certificate distinguished name. </param>
        /// <param name="domainVerificationToken"> Domain verification token. </param>
        /// <param name="validityInYears"> Duration in years (must be 1). </param>
        /// <param name="keySize"> Certificate key size. </param>
        /// <param name="productType"> Certificate product type. </param>
        /// <param name="autoRenew"> &lt;code&gt;true&lt;/code&gt; if the certificate should be automatically renewed when it expires; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="provisioningState"> Status of certificate order. </param>
        /// <param name="status"> Current order status. </param>
        /// <param name="signedCertificate"> Signed certificate. </param>
        /// <param name="csr"> Last CSR that was created for this order. </param>
        /// <param name="intermediate"> Intermediate certificate. </param>
        /// <param name="root"> Root certificate. </param>
        /// <param name="serialNumber"> Current serial number of the certificate. </param>
        /// <param name="lastCertificateIssuanceTime"> Certificate last issuance time. </param>
        /// <param name="expirationTime"> Certificate expiration time. </param>
        /// <param name="isPrivateKeyExternal"> &lt;code&gt;true&lt;/code&gt; if private key is external; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="appServiceCertificateNotRenewableReasons"> Reasons why App Service Certificate is not renewable at the current moment. </param>
        /// <param name="nextAutoRenewalTimeStamp"> Time stamp when the certificate would be auto renewed next. </param>
        /// <param name="contact"> Contact info. </param>
        internal AppServiceCertificateOrderPatch(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string kind, IDictionary<string, AppServiceCertificate> certificates, string distinguishedName, string domainVerificationToken, int? validityInYears, int? keySize, CertificateProductType? productType, bool? autoRenew, ProvisioningState? provisioningState, CertificateOrderStatus? status, CertificateDetails signedCertificate, string csr, CertificateDetails intermediate, CertificateDetails root, string serialNumber, DateTimeOffset? lastCertificateIssuanceTime, DateTimeOffset? expirationTime, bool? isPrivateKeyExternal, IReadOnlyList<AppServiceCertificateNotRenewableReason> appServiceCertificateNotRenewableReasons, DateTimeOffset? nextAutoRenewalTimeStamp, CertificateOrderContact contact) : base(id, name, type, systemData, kind)
        {
            Certificates = certificates;
            DistinguishedName = distinguishedName;
            DomainVerificationToken = domainVerificationToken;
            ValidityInYears = validityInYears;
            KeySize = keySize;
            ProductType = productType;
            AutoRenew = autoRenew;
            ProvisioningState = provisioningState;
            Status = status;
            SignedCertificate = signedCertificate;
            Csr = csr;
            Intermediate = intermediate;
            Root = root;
            SerialNumber = serialNumber;
            LastCertificateIssuanceTime = lastCertificateIssuanceTime;
            ExpirationTime = expirationTime;
            IsPrivateKeyExternal = isPrivateKeyExternal;
            AppServiceCertificateNotRenewableReasons = appServiceCertificateNotRenewableReasons;
            NextAutoRenewalTimeStamp = nextAutoRenewalTimeStamp;
            Contact = contact;
        }

        /// <summary> State of the Key Vault secret. </summary>
        public IDictionary<string, AppServiceCertificate> Certificates { get; }
        /// <summary> Certificate distinguished name. </summary>
        public string DistinguishedName { get; set; }
        /// <summary> Domain verification token. </summary>
        public string DomainVerificationToken { get; }
        /// <summary> Duration in years (must be 1). </summary>
        public int? ValidityInYears { get; set; }
        /// <summary> Certificate key size. </summary>
        public int? KeySize { get; set; }
        /// <summary> Certificate product type. </summary>
        public CertificateProductType? ProductType { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the certificate should be automatically renewed when it expires; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? AutoRenew { get; set; }
        /// <summary> Status of certificate order. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Current order status. </summary>
        public CertificateOrderStatus? Status { get; }
        /// <summary> Signed certificate. </summary>
        public CertificateDetails SignedCertificate { get; }
        /// <summary> Last CSR that was created for this order. </summary>
        public string Csr { get; set; }
        /// <summary> Intermediate certificate. </summary>
        public CertificateDetails Intermediate { get; }
        /// <summary> Root certificate. </summary>
        public CertificateDetails Root { get; }
        /// <summary> Current serial number of the certificate. </summary>
        public string SerialNumber { get; }
        /// <summary> Certificate last issuance time. </summary>
        public DateTimeOffset? LastCertificateIssuanceTime { get; }
        /// <summary> Certificate expiration time. </summary>
        public DateTimeOffset? ExpirationTime { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if private key is external; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsPrivateKeyExternal { get; }
        /// <summary> Reasons why App Service Certificate is not renewable at the current moment. </summary>
        public IReadOnlyList<AppServiceCertificateNotRenewableReason> AppServiceCertificateNotRenewableReasons { get; }
        /// <summary> Time stamp when the certificate would be auto renewed next. </summary>
        public DateTimeOffset? NextAutoRenewalTimeStamp { get; }
        /// <summary> Contact info. </summary>
        public CertificateOrderContact Contact { get; }
    }
}
