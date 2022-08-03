// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// The properties that are associated with an Azure Storage account
    /// Serialized Name: StorageAccount
    /// </summary>
    public partial class StorageAccount
    {
        /// <summary> Initializes a new instance of StorageAccount. </summary>
        public StorageAccount()
        {
        }

        /// <summary> Initializes a new instance of StorageAccount. </summary>
        /// <param name="accountName">
        /// The name of the Azure Storage account. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: StorageAccount.accountName
        /// </param>
        /// <param name="accountKey">
        /// The account key for the Azure Storage account. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: StorageAccount.accountKey
        /// </param>
        /// <param name="authenticationMode">
        /// Authentication Mode.
        /// Serialized Name: StorageAccount.authenticationMode
        /// </param>
        internal StorageAccount(string accountName, string accountKey, AuthenticationMode? authenticationMode)
        {
            AccountName = accountName;
            AccountKey = accountKey;
            AuthenticationMode = authenticationMode;
        }

        /// <summary>
        /// The name of the Azure Storage account. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: StorageAccount.accountName
        /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// The account key for the Azure Storage account. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: StorageAccount.accountKey
        /// </summary>
        public string AccountKey { get; set; }
        /// <summary>
        /// Authentication Mode.
        /// Serialized Name: StorageAccount.authenticationMode
        /// </summary>
        public AuthenticationMode? AuthenticationMode { get; set; }
    }
}
