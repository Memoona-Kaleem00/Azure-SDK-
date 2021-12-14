// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The ScanAuthorizationType. </summary>
    public readonly partial struct ScanAuthorizationType : IEquatable<ScanAuthorizationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScanAuthorizationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScanAuthorizationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureSubscriptionCredentialValue = "AzureSubscriptionCredential";
        private const string AzureSubscriptionMsiValue = "AzureSubscriptionMsi";
        private const string AzureResourceGroupCredentialValue = "AzureResourceGroupCredential";
        private const string AzureResourceGroupMsiValue = "AzureResourceGroupMsi";
        private const string AzureSynapseWorkspaceCredentialValue = "AzureSynapseWorkspaceCredential";
        private const string AzureSynapseWorkspaceMsiValue = "AzureSynapseWorkspaceMsi";
        private const string AzureSynapseCredentialValue = "AzureSynapseCredential";
        private const string AzureSynapseMsiValue = "AzureSynapseMsi";
        private const string AdlsGen1CredentialValue = "AdlsGen1Credential";
        private const string AdlsGen1MsiValue = "AdlsGen1Msi";
        private const string AdlsGen2CredentialValue = "AdlsGen2Credential";
        private const string AdlsGen2MsiValue = "AdlsGen2Msi";
        private const string AmazonAccountCredentialValue = "AmazonAccountCredential";
        private const string AmazonS3CredentialValue = "AmazonS3Credential";
        private const string AmazonS3RoleARNValue = "AmazonS3RoleARN";
        private const string AmazonSqlCredentialValue = "AmazonSqlCredential";
        private const string AzureCosmosDbCredentialValue = "AzureCosmosDbCredential";
        private const string AzureDataExplorerCredentialValue = "AzureDataExplorerCredential";
        private const string AzureDataExplorerMsiValue = "AzureDataExplorerMsi";
        private const string AzureFileServiceCredentialValue = "AzureFileServiceCredential";
        private const string AzureSqlDatabaseCredentialValue = "AzureSqlDatabaseCredential";
        private const string AzureSqlDatabaseMsiValue = "AzureSqlDatabaseMsi";
        private const string AmazonPostgreSqlCredentialValue = "AmazonPostgreSqlCredential";
        private const string AzurePostgreSqlCredentialValue = "AzurePostgreSqlCredential";
        private const string SqlServerDatabaseCredentialValue = "SqlServerDatabaseCredential";
        private const string AzureSqlDatabaseManagedInstanceCredentialValue = "AzureSqlDatabaseManagedInstanceCredential";
        private const string AzureSqlDatabaseManagedInstanceMsiValue = "AzureSqlDatabaseManagedInstanceMsi";
        private const string AzureSqlDataWarehouseCredentialValue = "AzureSqlDataWarehouseCredential";
        private const string AzureSqlDataWarehouseMsiValue = "AzureSqlDataWarehouseMsi";
        private const string AzureMySqlCredentialValue = "AzureMySqlCredential";
        private const string AzureStorageCredentialValue = "AzureStorageCredential";
        private const string AzureStorageMsiValue = "AzureStorageMsi";
        private const string TeradataTeradataCredentialValue = "TeradataTeradataCredential";
        private const string TeradataTeradataUserPassValue = "TeradataTeradataUserPass";
        private const string TeradataUserPassValue = "TeradataUserPass";
        private const string OracleOracleCredentialValue = "OracleOracleCredential";
        private const string OracleOracleUserPassValue = "OracleOracleUserPass";
        private const string SapS4HanaSapS4HanaCredentialValue = "SapS4HanaSapS4HanaCredential";
        private const string SapS4HanaSapS4HanaUserPassValue = "SapS4HanaSapS4HanaUserPass";
        private const string SapEccSapEccCredentialValue = "SapEccSapEccCredential";
        private const string SapEccSapEccUserPassValue = "SapEccSapEccUserPass";
        private const string PowerBIDelegatedValue = "PowerBIDelegated";
        private const string PowerBIMsiValue = "PowerBIMsi";

        /// <summary> AzureSubscriptionCredential. </summary>
        public static ScanAuthorizationType AzureSubscriptionCredential { get; } = new ScanAuthorizationType(AzureSubscriptionCredentialValue);
        /// <summary> AzureSubscriptionMsi. </summary>
        public static ScanAuthorizationType AzureSubscriptionMsi { get; } = new ScanAuthorizationType(AzureSubscriptionMsiValue);
        /// <summary> AzureResourceGroupCredential. </summary>
        public static ScanAuthorizationType AzureResourceGroupCredential { get; } = new ScanAuthorizationType(AzureResourceGroupCredentialValue);
        /// <summary> AzureResourceGroupMsi. </summary>
        public static ScanAuthorizationType AzureResourceGroupMsi { get; } = new ScanAuthorizationType(AzureResourceGroupMsiValue);
        /// <summary> AzureSynapseWorkspaceCredential. </summary>
        public static ScanAuthorizationType AzureSynapseWorkspaceCredential { get; } = new ScanAuthorizationType(AzureSynapseWorkspaceCredentialValue);
        /// <summary> AzureSynapseWorkspaceMsi. </summary>
        public static ScanAuthorizationType AzureSynapseWorkspaceMsi { get; } = new ScanAuthorizationType(AzureSynapseWorkspaceMsiValue);
        /// <summary> AzureSynapseCredential. </summary>
        public static ScanAuthorizationType AzureSynapseCredential { get; } = new ScanAuthorizationType(AzureSynapseCredentialValue);
        /// <summary> AzureSynapseMsi. </summary>
        public static ScanAuthorizationType AzureSynapseMsi { get; } = new ScanAuthorizationType(AzureSynapseMsiValue);
        /// <summary> AdlsGen1Credential. </summary>
        public static ScanAuthorizationType AdlsGen1Credential { get; } = new ScanAuthorizationType(AdlsGen1CredentialValue);
        /// <summary> AdlsGen1Msi. </summary>
        public static ScanAuthorizationType AdlsGen1Msi { get; } = new ScanAuthorizationType(AdlsGen1MsiValue);
        /// <summary> AdlsGen2Credential. </summary>
        public static ScanAuthorizationType AdlsGen2Credential { get; } = new ScanAuthorizationType(AdlsGen2CredentialValue);
        /// <summary> AdlsGen2Msi. </summary>
        public static ScanAuthorizationType AdlsGen2Msi { get; } = new ScanAuthorizationType(AdlsGen2MsiValue);
        /// <summary> AmazonAccountCredential. </summary>
        public static ScanAuthorizationType AmazonAccountCredential { get; } = new ScanAuthorizationType(AmazonAccountCredentialValue);
        /// <summary> AmazonS3Credential. </summary>
        public static ScanAuthorizationType AmazonS3Credential { get; } = new ScanAuthorizationType(AmazonS3CredentialValue);
        /// <summary> AmazonS3RoleARN. </summary>
        public static ScanAuthorizationType AmazonS3RoleARN { get; } = new ScanAuthorizationType(AmazonS3RoleARNValue);
        /// <summary> AmazonSqlCredential. </summary>
        public static ScanAuthorizationType AmazonSqlCredential { get; } = new ScanAuthorizationType(AmazonSqlCredentialValue);
        /// <summary> AzureCosmosDbCredential. </summary>
        public static ScanAuthorizationType AzureCosmosDbCredential { get; } = new ScanAuthorizationType(AzureCosmosDbCredentialValue);
        /// <summary> AzureDataExplorerCredential. </summary>
        public static ScanAuthorizationType AzureDataExplorerCredential { get; } = new ScanAuthorizationType(AzureDataExplorerCredentialValue);
        /// <summary> AzureDataExplorerMsi. </summary>
        public static ScanAuthorizationType AzureDataExplorerMsi { get; } = new ScanAuthorizationType(AzureDataExplorerMsiValue);
        /// <summary> AzureFileServiceCredential. </summary>
        public static ScanAuthorizationType AzureFileServiceCredential { get; } = new ScanAuthorizationType(AzureFileServiceCredentialValue);
        /// <summary> AzureSqlDatabaseCredential. </summary>
        public static ScanAuthorizationType AzureSqlDatabaseCredential { get; } = new ScanAuthorizationType(AzureSqlDatabaseCredentialValue);
        /// <summary> AzureSqlDatabaseMsi. </summary>
        public static ScanAuthorizationType AzureSqlDatabaseMsi { get; } = new ScanAuthorizationType(AzureSqlDatabaseMsiValue);
        /// <summary> AmazonPostgreSqlCredential. </summary>
        public static ScanAuthorizationType AmazonPostgreSqlCredential { get; } = new ScanAuthorizationType(AmazonPostgreSqlCredentialValue);
        /// <summary> AzurePostgreSqlCredential. </summary>
        public static ScanAuthorizationType AzurePostgreSqlCredential { get; } = new ScanAuthorizationType(AzurePostgreSqlCredentialValue);
        /// <summary> SqlServerDatabaseCredential. </summary>
        public static ScanAuthorizationType SqlServerDatabaseCredential { get; } = new ScanAuthorizationType(SqlServerDatabaseCredentialValue);
        /// <summary> AzureSqlDatabaseManagedInstanceCredential. </summary>
        public static ScanAuthorizationType AzureSqlDatabaseManagedInstanceCredential { get; } = new ScanAuthorizationType(AzureSqlDatabaseManagedInstanceCredentialValue);
        /// <summary> AzureSqlDatabaseManagedInstanceMsi. </summary>
        public static ScanAuthorizationType AzureSqlDatabaseManagedInstanceMsi { get; } = new ScanAuthorizationType(AzureSqlDatabaseManagedInstanceMsiValue);
        /// <summary> AzureSqlDataWarehouseCredential. </summary>
        public static ScanAuthorizationType AzureSqlDataWarehouseCredential { get; } = new ScanAuthorizationType(AzureSqlDataWarehouseCredentialValue);
        /// <summary> AzureSqlDataWarehouseMsi. </summary>
        public static ScanAuthorizationType AzureSqlDataWarehouseMsi { get; } = new ScanAuthorizationType(AzureSqlDataWarehouseMsiValue);
        /// <summary> AzureMySqlCredential. </summary>
        public static ScanAuthorizationType AzureMySqlCredential { get; } = new ScanAuthorizationType(AzureMySqlCredentialValue);
        /// <summary> AzureStorageCredential. </summary>
        public static ScanAuthorizationType AzureStorageCredential { get; } = new ScanAuthorizationType(AzureStorageCredentialValue);
        /// <summary> AzureStorageMsi. </summary>
        public static ScanAuthorizationType AzureStorageMsi { get; } = new ScanAuthorizationType(AzureStorageMsiValue);
        /// <summary> TeradataTeradataCredential. </summary>
        public static ScanAuthorizationType TeradataTeradataCredential { get; } = new ScanAuthorizationType(TeradataTeradataCredentialValue);
        /// <summary> TeradataTeradataUserPass. </summary>
        public static ScanAuthorizationType TeradataTeradataUserPass { get; } = new ScanAuthorizationType(TeradataTeradataUserPassValue);
        /// <summary> TeradataUserPass. </summary>
        public static ScanAuthorizationType TeradataUserPass { get; } = new ScanAuthorizationType(TeradataUserPassValue);
        /// <summary> OracleOracleCredential. </summary>
        public static ScanAuthorizationType OracleOracleCredential { get; } = new ScanAuthorizationType(OracleOracleCredentialValue);
        /// <summary> OracleOracleUserPass. </summary>
        public static ScanAuthorizationType OracleOracleUserPass { get; } = new ScanAuthorizationType(OracleOracleUserPassValue);
        /// <summary> SapS4HanaSapS4HanaCredential. </summary>
        public static ScanAuthorizationType SapS4HanaSapS4HanaCredential { get; } = new ScanAuthorizationType(SapS4HanaSapS4HanaCredentialValue);
        /// <summary> SapS4HanaSapS4HanaUserPass. </summary>
        public static ScanAuthorizationType SapS4HanaSapS4HanaUserPass { get; } = new ScanAuthorizationType(SapS4HanaSapS4HanaUserPassValue);
        /// <summary> SapEccSapEccCredential. </summary>
        public static ScanAuthorizationType SapEccSapEccCredential { get; } = new ScanAuthorizationType(SapEccSapEccCredentialValue);
        /// <summary> SapEccSapEccUserPass. </summary>
        public static ScanAuthorizationType SapEccSapEccUserPass { get; } = new ScanAuthorizationType(SapEccSapEccUserPassValue);
        /// <summary> PowerBIDelegated. </summary>
        public static ScanAuthorizationType PowerBIDelegated { get; } = new ScanAuthorizationType(PowerBIDelegatedValue);
        /// <summary> PowerBIMsi. </summary>
        public static ScanAuthorizationType PowerBIMsi { get; } = new ScanAuthorizationType(PowerBIMsiValue);
        /// <summary> Determines if two <see cref="ScanAuthorizationType"/> values are the same. </summary>
        public static bool operator ==(ScanAuthorizationType left, ScanAuthorizationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScanAuthorizationType"/> values are not the same. </summary>
        public static bool operator !=(ScanAuthorizationType left, ScanAuthorizationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScanAuthorizationType"/>. </summary>
        public static implicit operator ScanAuthorizationType(string value) => new ScanAuthorizationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScanAuthorizationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScanAuthorizationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
