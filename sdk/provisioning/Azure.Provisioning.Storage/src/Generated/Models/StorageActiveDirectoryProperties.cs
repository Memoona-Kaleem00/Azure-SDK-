// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// Settings properties for Active Directory (AD).
/// </summary>
public partial class StorageActiveDirectoryProperties : ProvisioningConstruct
{
    /// <summary>
    /// Specifies the primary domain that the AD DNS server is authoritative
    /// for.
    /// </summary>
    public BicepValue<string> DomainName { get => _domainName; set => _domainName.Assign(value); }
    private readonly BicepValue<string> _domainName;

    /// <summary>
    /// Specifies the NetBIOS domain name.
    /// </summary>
    public BicepValue<string> NetBiosDomainName { get => _netBiosDomainName; set => _netBiosDomainName.Assign(value); }
    private readonly BicepValue<string> _netBiosDomainName;

    /// <summary>
    /// Specifies the Active Directory forest to get.
    /// </summary>
    public BicepValue<string> ForestName { get => _forestName; set => _forestName.Assign(value); }
    private readonly BicepValue<string> _forestName;

    /// <summary>
    /// Specifies the domain GUID.
    /// </summary>
    public BicepValue<Guid> DomainGuid { get => _domainGuid; set => _domainGuid.Assign(value); }
    private readonly BicepValue<Guid> _domainGuid;

    /// <summary>
    /// Specifies the security identifier (SID).
    /// </summary>
    public BicepValue<string> DomainSid { get => _domainSid; set => _domainSid.Assign(value); }
    private readonly BicepValue<string> _domainSid;

    /// <summary>
    /// Specifies the security identifier (SID) for Azure Storage.
    /// </summary>
    public BicepValue<string> AzureStorageSid { get => _azureStorageSid; set => _azureStorageSid.Assign(value); }
    private readonly BicepValue<string> _azureStorageSid;

    /// <summary>
    /// Specifies the Active Directory SAMAccountName for Azure Storage.
    /// </summary>
    public BicepValue<string> SamAccountName { get => _samAccountName; set => _samAccountName.Assign(value); }
    private readonly BicepValue<string> _samAccountName;

    /// <summary>
    /// Specifies the Active Directory account type for Azure Storage.
    /// </summary>
    public BicepValue<ActiveDirectoryAccountType> AccountType { get => _accountType; set => _accountType.Assign(value); }
    private readonly BicepValue<ActiveDirectoryAccountType> _accountType;

    /// <summary>
    /// Creates a new StorageActiveDirectoryProperties.
    /// </summary>
    public StorageActiveDirectoryProperties()
    {
        _domainName = BicepValue<string>.DefineProperty(this, "DomainName", ["domainName"]);
        _netBiosDomainName = BicepValue<string>.DefineProperty(this, "NetBiosDomainName", ["netBiosDomainName"]);
        _forestName = BicepValue<string>.DefineProperty(this, "ForestName", ["forestName"]);
        _domainGuid = BicepValue<Guid>.DefineProperty(this, "DomainGuid", ["domainGuid"]);
        _domainSid = BicepValue<string>.DefineProperty(this, "DomainSid", ["domainSid"]);
        _azureStorageSid = BicepValue<string>.DefineProperty(this, "AzureStorageSid", ["azureStorageSid"]);
        _samAccountName = BicepValue<string>.DefineProperty(this, "SamAccountName", ["samAccountName"]);
        _accountType = BicepValue<ActiveDirectoryAccountType>.DefineProperty(this, "AccountType", ["accountType"]);
    }
}
