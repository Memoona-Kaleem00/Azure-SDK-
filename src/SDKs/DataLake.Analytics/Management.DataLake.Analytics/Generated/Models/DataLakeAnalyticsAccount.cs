// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Data Lake Analytics account object, containing all information
    /// associated with the named Data Lake Analytics account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DataLakeAnalyticsAccount : Resource
    {
        /// <summary>
        /// Initializes a new instance of the DataLakeAnalyticsAccount class.
        /// </summary>
        public DataLakeAnalyticsAccount()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataLakeAnalyticsAccount class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="defaultDataLakeStoreAccount">the default data lake
        /// storage account associated with this Data Lake Analytics
        /// account.</param>
        /// <param name="dataLakeStoreAccounts">the list of Data Lake storage
        /// accounts associated with this account.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="provisioningState">the provisioning status of the Data
        /// Lake Analytics account. Possible values include: 'Failed',
        /// 'Creating', 'Running', 'Succeeded', 'Patching', 'Suspending',
        /// 'Resuming', 'Deleting', 'Deleted'</param>
        /// <param name="state">the state of the Data Lake Analytics account.
        /// Possible values include: 'Active', 'Suspended'</param>
        /// <param name="maxDegreeOfParallelism">the maximum supported degree
        /// of parallelism for this account.</param>
        /// <param name="queryStoreRetention">the number of days that job
        /// metadata is retained.</param>
        /// <param name="maxJobCount">the maximum supported jobs running under
        /// the account at the same time.</param>
        /// <param name="systemMaxDegreeOfParallelism">the system defined
        /// maximum supported degree of parallelism for this account, which
        /// restricts the maximum value of parallelism the user can set for the
        /// account..</param>
        /// <param name="systemMaxJobCount">the system defined maximum
        /// supported jobs running under the account at the same time, which
        /// restricts the maximum number of running jobs the user can set for
        /// the account.</param>
        /// <param name="storageAccounts">the list of Azure Blob storage
        /// accounts associated with this account.</param>
        /// <param name="creationTime">the account creation time.</param>
        /// <param name="lastModifiedTime">the account last modified
        /// time.</param>
        /// <param name="endpoint">the full CName endpoint for this
        /// account.</param>
        /// <param name="newTier">the commitment tier for the next month.
        /// Possible values include: 'Consumption', 'Commitment_100AUHours',
        /// 'Commitment_500AUHours', 'Commitment_1000AUHours',
        /// 'Commitment_5000AUHours', 'Commitment_10000AUHours',
        /// 'Commitment_50000AUHours', 'Commitment_100000AUHours',
        /// 'Commitment_500000AUHours'</param>
        /// <param name="currentTier">the commitment tier in use for the
        /// current month. Possible values include: 'Consumption',
        /// 'Commitment_100AUHours', 'Commitment_500AUHours',
        /// 'Commitment_1000AUHours', 'Commitment_5000AUHours',
        /// 'Commitment_10000AUHours', 'Commitment_50000AUHours',
        /// 'Commitment_100000AUHours', 'Commitment_500000AUHours'</param>
        /// <param name="firewallState">The current state of the IP address
        /// firewall for this Data Lake Analytics account. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="firewallAllowAzureIps">The current state of allowing
        /// or disallowing IPs originating within Azure through the firewall.
        /// If the firewall is disabled, this is not enforced. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="firewallRules">The list of firewall rules associated
        /// with this Data Lake Analytics account.</param>
        /// <param name="maxDegreeOfParallelismPerJob">the maximum supported
        /// degree of parallelism per job for this account.</param>
        /// <param name="minPriorityPerJob">the minimum supported priority per
        /// job for this account.</param>
        /// <param name="computePolicies">the list of compute policies to
        /// create in this account.</param>
        public DataLakeAnalyticsAccount(string location, string defaultDataLakeStoreAccount, IList<DataLakeStoreAccountInfo> dataLakeStoreAccounts, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), DataLakeAnalyticsAccountStatus? provisioningState = default(DataLakeAnalyticsAccountStatus?), DataLakeAnalyticsAccountState? state = default(DataLakeAnalyticsAccountState?), int? maxDegreeOfParallelism = default(int?), int? queryStoreRetention = default(int?), int? maxJobCount = default(int?), int? systemMaxDegreeOfParallelism = default(int?), int? systemMaxJobCount = default(int?), IList<StorageAccountInfo> storageAccounts = default(IList<StorageAccountInfo>), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), string endpoint = default(string), TierType? newTier = default(TierType?), TierType? currentTier = default(TierType?), FirewallState? firewallState = default(FirewallState?), FirewallAllowAzureIpsState? firewallAllowAzureIps = default(FirewallAllowAzureIpsState?), IList<FirewallRule> firewallRules = default(IList<FirewallRule>), int? maxDegreeOfParallelismPerJob = default(int?), int? minPriorityPerJob = default(int?), IList<ComputePolicyAccountCreateParameters> computePolicies = default(IList<ComputePolicyAccountCreateParameters>))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            State = state;
            DefaultDataLakeStoreAccount = defaultDataLakeStoreAccount;
            MaxDegreeOfParallelism = maxDegreeOfParallelism;
            QueryStoreRetention = queryStoreRetention;
            MaxJobCount = maxJobCount;
            SystemMaxDegreeOfParallelism = systemMaxDegreeOfParallelism;
            SystemMaxJobCount = systemMaxJobCount;
            DataLakeStoreAccounts = dataLakeStoreAccounts;
            StorageAccounts = storageAccounts;
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            Endpoint = endpoint;
            NewTier = newTier;
            CurrentTier = currentTier;
            FirewallState = firewallState;
            FirewallAllowAzureIps = firewallAllowAzureIps;
            FirewallRules = firewallRules;
            MaxDegreeOfParallelismPerJob = maxDegreeOfParallelismPerJob;
            MinPriorityPerJob = minPriorityPerJob;
            ComputePolicies = computePolicies;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning status of the Data Lake Analytics account.
        /// Possible values include: 'Failed', 'Creating', 'Running',
        /// 'Succeeded', 'Patching', 'Suspending', 'Resuming', 'Deleting',
        /// 'Deleted'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public DataLakeAnalyticsAccountStatus? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the state of the Data Lake Analytics account. Possible values
        /// include: 'Active', 'Suspended'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public DataLakeAnalyticsAccountState? State { get; private set; }

        /// <summary>
        /// Gets or sets the default data lake storage account associated with
        /// this Data Lake Analytics account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultDataLakeStoreAccount")]
        public string DefaultDataLakeStoreAccount { get; set; }

        /// <summary>
        /// Gets or sets the maximum supported degree of parallelism for this
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDegreeOfParallelism")]
        public int? MaxDegreeOfParallelism { get; set; }

        /// <summary>
        /// Gets or sets the number of days that job metadata is retained.
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryStoreRetention")]
        public int? QueryStoreRetention { get; set; }

        /// <summary>
        /// Gets or sets the maximum supported jobs running under the account
        /// at the same time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxJobCount")]
        public int? MaxJobCount { get; set; }

        /// <summary>
        /// Gets the system defined maximum supported degree of parallelism for
        /// this account, which restricts the maximum value of parallelism the
        /// user can set for the account..
        /// </summary>
        [JsonProperty(PropertyName = "properties.systemMaxDegreeOfParallelism")]
        public int? SystemMaxDegreeOfParallelism { get; private set; }

        /// <summary>
        /// Gets the system defined maximum supported jobs running under the
        /// account at the same time, which restricts the maximum number of
        /// running jobs the user can set for the account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.systemMaxJobCount")]
        public int? SystemMaxJobCount { get; private set; }

        /// <summary>
        /// Gets or sets the list of Data Lake storage accounts associated with
        /// this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataLakeStoreAccounts")]
        public IList<DataLakeStoreAccountInfo> DataLakeStoreAccounts { get; set; }

        /// <summary>
        /// Gets or sets the list of Azure Blob storage accounts associated
        /// with this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccounts")]
        public IList<StorageAccountInfo> StorageAccounts { get; set; }

        /// <summary>
        /// Gets the account creation time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the account last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets the full CName endpoint for this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoint")]
        public string Endpoint { get; private set; }

        /// <summary>
        /// Gets or sets the commitment tier for the next month. Possible
        /// values include: 'Consumption', 'Commitment_100AUHours',
        /// 'Commitment_500AUHours', 'Commitment_1000AUHours',
        /// 'Commitment_5000AUHours', 'Commitment_10000AUHours',
        /// 'Commitment_50000AUHours', 'Commitment_100000AUHours',
        /// 'Commitment_500000AUHours'
        /// </summary>
        [JsonProperty(PropertyName = "properties.newTier")]
        public TierType? NewTier { get; set; }

        /// <summary>
        /// Gets the commitment tier in use for the current month. Possible
        /// values include: 'Consumption', 'Commitment_100AUHours',
        /// 'Commitment_500AUHours', 'Commitment_1000AUHours',
        /// 'Commitment_5000AUHours', 'Commitment_10000AUHours',
        /// 'Commitment_50000AUHours', 'Commitment_100000AUHours',
        /// 'Commitment_500000AUHours'
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentTier")]
        public TierType? CurrentTier { get; private set; }

        /// <summary>
        /// Gets or sets the current state of the IP address firewall for this
        /// Data Lake Analytics account. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallState")]
        public FirewallState? FirewallState { get; set; }

        /// <summary>
        /// Gets or sets the current state of allowing or disallowing IPs
        /// originating within Azure through the firewall. If the firewall is
        /// disabled, this is not enforced. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallAllowAzureIps")]
        public FirewallAllowAzureIpsState? FirewallAllowAzureIps { get; set; }

        /// <summary>
        /// Gets or sets the list of firewall rules associated with this Data
        /// Lake Analytics account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallRules")]
        public IList<FirewallRule> FirewallRules { get; set; }

        /// <summary>
        /// Gets or sets the maximum supported degree of parallelism per job
        /// for this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDegreeOfParallelismPerJob")]
        public int? MaxDegreeOfParallelismPerJob { get; set; }

        /// <summary>
        /// Gets or sets the minimum supported priority per job for this
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minPriorityPerJob")]
        public int? MinPriorityPerJob { get; set; }

        /// <summary>
        /// Gets or sets the list of compute policies to create in this
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.computePolicies")]
        public IList<ComputePolicyAccountCreateParameters> ComputePolicies { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (DefaultDataLakeStoreAccount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DefaultDataLakeStoreAccount");
            }
            if (DataLakeStoreAccounts == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataLakeStoreAccounts");
            }
            if (MaxDegreeOfParallelism < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxDegreeOfParallelism", 1);
            }
            if (QueryStoreRetention > 180)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "QueryStoreRetention", 180);
            }
            if (QueryStoreRetention < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "QueryStoreRetention", 1);
            }
            if (MaxJobCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxJobCount", 1);
            }
            if (DataLakeStoreAccounts != null)
            {
                foreach (var element in DataLakeStoreAccounts)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (StorageAccounts != null)
            {
                foreach (var element1 in StorageAccounts)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (FirewallRules != null)
            {
                foreach (var element2 in FirewallRules)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (MaxDegreeOfParallelismPerJob < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxDegreeOfParallelismPerJob", 1);
            }
            if (MinPriorityPerJob < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MinPriorityPerJob", 1);
            }
            if (ComputePolicies != null)
            {
                foreach (var element3 in ComputePolicies)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
        }
    }
}
