// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The parameters to list SAS credentials of a storage account. </summary>
    public partial class AccountSasContent
    {
        /// <summary> Initializes a new instance of <see cref="AccountSasContent"/>. </summary>
        /// <param name="services"> The signed services accessible with the account SAS. Possible values include: Blob (b), Queue (q), Table (t), File (f). </param>
        /// <param name="resourceTypes"> The signed resource types that are accessible with the account SAS. Service (s): Access to service-level APIs; Container (c): Access to container-level APIs; Object (o): Access to object-level APIs for blobs, queue messages, table entities, and files. </param>
        /// <param name="permissions"> The signed permissions for the account SAS. Possible values include: Read (r), Write (w), Delete (d), List (l), Add (a), Create (c), Update (u) and Process (p). </param>
        /// <param name="sharedAccessExpireOn"> The time at which the shared access signature becomes invalid. </param>
        public AccountSasContent(StorageAccountSasSignedService services, StorageAccountSasSignedResourceType resourceTypes, StorageAccountSasPermission permissions, DateTimeOffset sharedAccessExpireOn)
        {
            Services = services;
            ResourceTypes = resourceTypes;
            Permissions = permissions;
            SharedAccessExpireOn = sharedAccessExpireOn;
        }

        /// <summary> Initializes a new instance of <see cref="AccountSasContent"/>. </summary>
        /// <param name="services"> The signed services accessible with the account SAS. Possible values include: Blob (b), Queue (q), Table (t), File (f). </param>
        /// <param name="resourceTypes"> The signed resource types that are accessible with the account SAS. Service (s): Access to service-level APIs; Container (c): Access to container-level APIs; Object (o): Access to object-level APIs for blobs, queue messages, table entities, and files. </param>
        /// <param name="permissions"> The signed permissions for the account SAS. Possible values include: Read (r), Write (w), Delete (d), List (l), Add (a), Create (c), Update (u) and Process (p). </param>
        /// <param name="ipAddressOrRange"> An IP address or a range of IP addresses from which to accept requests. </param>
        /// <param name="protocols"> The protocol permitted for a request made with the account SAS. </param>
        /// <param name="sharedAccessStartOn"> The time at which the SAS becomes valid. </param>
        /// <param name="sharedAccessExpireOn"> The time at which the shared access signature becomes invalid. </param>
        /// <param name="keyToSign"> The key to sign the account SAS token with. </param>
        internal AccountSasContent(StorageAccountSasSignedService services, StorageAccountSasSignedResourceType resourceTypes, StorageAccountSasPermission permissions, string ipAddressOrRange, StorageAccountHttpProtocol? protocols, DateTimeOffset? sharedAccessStartOn, DateTimeOffset sharedAccessExpireOn, string keyToSign)
        {
            Services = services;
            ResourceTypes = resourceTypes;
            Permissions = permissions;
            IPAddressOrRange = ipAddressOrRange;
            Protocols = protocols;
            SharedAccessStartOn = sharedAccessStartOn;
            SharedAccessExpireOn = sharedAccessExpireOn;
            KeyToSign = keyToSign;
        }

        /// <summary> The signed services accessible with the account SAS. Possible values include: Blob (b), Queue (q), Table (t), File (f). </summary>
        public StorageAccountSasSignedService Services { get; }
        /// <summary> The signed resource types that are accessible with the account SAS. Service (s): Access to service-level APIs; Container (c): Access to container-level APIs; Object (o): Access to object-level APIs for blobs, queue messages, table entities, and files. </summary>
        public StorageAccountSasSignedResourceType ResourceTypes { get; }
        /// <summary> The signed permissions for the account SAS. Possible values include: Read (r), Write (w), Delete (d), List (l), Add (a), Create (c), Update (u) and Process (p). </summary>
        public StorageAccountSasPermission Permissions { get; }
        /// <summary> An IP address or a range of IP addresses from which to accept requests. </summary>
        public string IPAddressOrRange { get; set; }
        /// <summary> The protocol permitted for a request made with the account SAS. </summary>
        public StorageAccountHttpProtocol? Protocols { get; set; }
        /// <summary> The time at which the SAS becomes valid. </summary>
        public DateTimeOffset? SharedAccessStartOn { get; set; }
        /// <summary> The time at which the shared access signature becomes invalid. </summary>
        public DateTimeOffset SharedAccessExpireOn { get; }
        /// <summary> The key to sign the account SAS token with. </summary>
        public string KeyToSign { get; set; }
    }
}
