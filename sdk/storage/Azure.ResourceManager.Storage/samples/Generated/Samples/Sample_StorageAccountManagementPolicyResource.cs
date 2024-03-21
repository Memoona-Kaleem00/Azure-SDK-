// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage.Samples
{
    public partial class Sample_StorageAccountManagementPolicyResource
    {
        // StorageAccountGetManagementPolicies
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_StorageAccountGetManagementPolicies()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/StorageAccountGetManagementPolicy.json
            // this example is just showing the usage of "ManagementPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountManagementPolicyResource created on azure
            // for more information of creating StorageAccountManagementPolicyResource, please refer to the document of StorageAccountManagementPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            ManagementPolicyName managementPolicyName = ManagementPolicyName.Default;
            ResourceIdentifier storageAccountManagementPolicyResourceId = StorageAccountManagementPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, managementPolicyName);
            StorageAccountManagementPolicyResource storageAccountManagementPolicy = client.GetStorageAccountManagementPolicyResource(storageAccountManagementPolicyResourceId);

            // invoke the operation
            StorageAccountManagementPolicyResource result = await storageAccountManagementPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageAccountManagementPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StorageAccountSetManagementPolicies
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StorageAccountSetManagementPolicies()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/StorageAccountSetManagementPolicy.json
            // this example is just showing the usage of "ManagementPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountManagementPolicyResource created on azure
            // for more information of creating StorageAccountManagementPolicyResource, please refer to the document of StorageAccountManagementPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string accountName = "sto9699";
            ManagementPolicyName managementPolicyName = ManagementPolicyName.Default;
            ResourceIdentifier storageAccountManagementPolicyResourceId = StorageAccountManagementPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, managementPolicyName);
            StorageAccountManagementPolicyResource storageAccountManagementPolicy = client.GetStorageAccountManagementPolicyResource(storageAccountManagementPolicyResourceId);

            // invoke the operation
            StorageAccountManagementPolicyData data = new StorageAccountManagementPolicyData()
            {
                Rules =
{
new ManagementPolicyRule("olcmtest1",ManagementPolicyRuleType.Lifecycle,new ManagementPolicyDefinition(new ManagementPolicyAction()
{
BaseBlob = new ManagementPolicyBaseBlob()
{
TierToCool = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 30,
},
TierToArchive = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 90,
},
Delete = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 1000,
},
},
Snapshot = new ManagementPolicySnapShot()
{
Delete = new DateAfterCreation(30),
},
})
{
Filters = new ManagementPolicyFilter(new string[]
{
"blockBlob"
})
{
PrefixMatch =
{
"olcmtestcontainer1"
},
},
})
{
IsEnabled = true,
},new ManagementPolicyRule("olcmtest2",ManagementPolicyRuleType.Lifecycle,new ManagementPolicyDefinition(new ManagementPolicyAction()
{
BaseBlob = new ManagementPolicyBaseBlob()
{
TierToCool = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 30,
},
TierToArchive = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 90,
},
Delete = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 1000,
},
},
})
{
Filters = new ManagementPolicyFilter(new string[]
{
"blockBlob"
})
{
PrefixMatch =
{
"olcmtestcontainer2"
},
BlobIndexMatch =
{
new ManagementPolicyTagFilter("tag1","==","val1"),new ManagementPolicyTagFilter("tag2","==","val2")
},
},
})
{
IsEnabled = true,
}
},
            };
            ArmOperation<StorageAccountManagementPolicyResource> lro = await storageAccountManagementPolicy.CreateOrUpdateAsync(WaitUntil.Completed, data);
            StorageAccountManagementPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageAccountManagementPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StorageAccountSetManagementPolicyColdTierActions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StorageAccountSetManagementPolicyColdTierActions()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/StorageAccountSetManagementPolicyColdTierActions.json
            // this example is just showing the usage of "ManagementPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountManagementPolicyResource created on azure
            // for more information of creating StorageAccountManagementPolicyResource, please refer to the document of StorageAccountManagementPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string accountName = "sto9699";
            ManagementPolicyName managementPolicyName = ManagementPolicyName.Default;
            ResourceIdentifier storageAccountManagementPolicyResourceId = StorageAccountManagementPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, managementPolicyName);
            StorageAccountManagementPolicyResource storageAccountManagementPolicy = client.GetStorageAccountManagementPolicyResource(storageAccountManagementPolicyResourceId);

            // invoke the operation
            StorageAccountManagementPolicyData data = new StorageAccountManagementPolicyData()
            {
                Rules =
{
new ManagementPolicyRule("olcmtest1",ManagementPolicyRuleType.Lifecycle,new ManagementPolicyDefinition(new ManagementPolicyAction()
{
BaseBlob = new ManagementPolicyBaseBlob()
{
TierToCool = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 30,
},
TierToArchive = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 90,
},
TierToCold = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 30,
},
Delete = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 1000,
},
},
Snapshot = new ManagementPolicySnapShot()
{
TierToCold = new DateAfterCreation(30),
Delete = new DateAfterCreation(30),
},
Version = new ManagementPolicyVersion()
{
TierToCold = new DateAfterCreation(30),
Delete = new DateAfterCreation(30),
},
})
{
Filters = new ManagementPolicyFilter(new string[]
{
"blockBlob"
})
{
PrefixMatch =
{
"olcmtestcontainer1"
},
},
})
{
IsEnabled = true,
}
},
            };
            ArmOperation<StorageAccountManagementPolicyResource> lro = await storageAccountManagementPolicy.CreateOrUpdateAsync(WaitUntil.Completed, data);
            StorageAccountManagementPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageAccountManagementPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StorageAccountSetManagementPolicyForBlockAndAppendBlobs
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StorageAccountSetManagementPolicyForBlockAndAppendBlobs()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/StorageAccountSetManagementPolicyForBlockAndAppendBlobs.json
            // this example is just showing the usage of "ManagementPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountManagementPolicyResource created on azure
            // for more information of creating StorageAccountManagementPolicyResource, please refer to the document of StorageAccountManagementPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string accountName = "sto9699";
            ManagementPolicyName managementPolicyName = ManagementPolicyName.Default;
            ResourceIdentifier storageAccountManagementPolicyResourceId = StorageAccountManagementPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, managementPolicyName);
            StorageAccountManagementPolicyResource storageAccountManagementPolicy = client.GetStorageAccountManagementPolicyResource(storageAccountManagementPolicyResourceId);

            // invoke the operation
            StorageAccountManagementPolicyData data = new StorageAccountManagementPolicyData()
            {
                Rules =
{
new ManagementPolicyRule("olcmtest1",ManagementPolicyRuleType.Lifecycle,new ManagementPolicyDefinition(new ManagementPolicyAction()
{
BaseBlob = new ManagementPolicyBaseBlob()
{
Delete = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 90,
},
},
Snapshot = new ManagementPolicySnapShot()
{
Delete = new DateAfterCreation(90),
},
Version = new ManagementPolicyVersion()
{
Delete = new DateAfterCreation(90),
},
})
{
Filters = new ManagementPolicyFilter(new string[]
{
"blockBlob","appendBlob"
})
{
PrefixMatch =
{
"olcmtestcontainer1"
},
},
})
{
IsEnabled = true,
}
},
            };
            ArmOperation<StorageAccountManagementPolicyResource> lro = await storageAccountManagementPolicy.CreateOrUpdateAsync(WaitUntil.Completed, data);
            StorageAccountManagementPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageAccountManagementPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StorageAccountSetManagementPolicyHotTierActions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StorageAccountSetManagementPolicyHotTierActions()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/StorageAccountSetManagementPolicyHotTierActions.json
            // this example is just showing the usage of "ManagementPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountManagementPolicyResource created on azure
            // for more information of creating StorageAccountManagementPolicyResource, please refer to the document of StorageAccountManagementPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string accountName = "sto9699";
            ManagementPolicyName managementPolicyName = ManagementPolicyName.Default;
            ResourceIdentifier storageAccountManagementPolicyResourceId = StorageAccountManagementPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, managementPolicyName);
            StorageAccountManagementPolicyResource storageAccountManagementPolicy = client.GetStorageAccountManagementPolicyResource(storageAccountManagementPolicyResourceId);

            // invoke the operation
            StorageAccountManagementPolicyData data = new StorageAccountManagementPolicyData()
            {
                Rules =
{
new ManagementPolicyRule("olcmtest1",ManagementPolicyRuleType.Lifecycle,new ManagementPolicyDefinition(new ManagementPolicyAction()
{
BaseBlob = new ManagementPolicyBaseBlob()
{
TierToHot = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 30,
},
},
Snapshot = new ManagementPolicySnapShot()
{
TierToHot = new DateAfterCreation(30),
},
Version = new ManagementPolicyVersion()
{
TierToHot = new DateAfterCreation(30),
},
})
{
Filters = new ManagementPolicyFilter(new string[]
{
"blockBlob"
})
{
PrefixMatch =
{
"olcmtestcontainer1"
},
},
})
{
IsEnabled = true,
}
},
            };
            ArmOperation<StorageAccountManagementPolicyResource> lro = await storageAccountManagementPolicy.CreateOrUpdateAsync(WaitUntil.Completed, data);
            StorageAccountManagementPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageAccountManagementPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StorageAccountSetManagementPolicyWithSnapshotAndVersion
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StorageAccountSetManagementPolicyWithSnapshotAndVersion()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/StorageAccountSetManagementPolicyWithSnapshotAndVersion.json
            // this example is just showing the usage of "ManagementPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountManagementPolicyResource created on azure
            // for more information of creating StorageAccountManagementPolicyResource, please refer to the document of StorageAccountManagementPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string accountName = "sto9699";
            ManagementPolicyName managementPolicyName = ManagementPolicyName.Default;
            ResourceIdentifier storageAccountManagementPolicyResourceId = StorageAccountManagementPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, managementPolicyName);
            StorageAccountManagementPolicyResource storageAccountManagementPolicy = client.GetStorageAccountManagementPolicyResource(storageAccountManagementPolicyResourceId);

            // invoke the operation
            StorageAccountManagementPolicyData data = new StorageAccountManagementPolicyData()
            {
                Rules =
{
new ManagementPolicyRule("olcmtest1",ManagementPolicyRuleType.Lifecycle,new ManagementPolicyDefinition(new ManagementPolicyAction()
{
BaseBlob = new ManagementPolicyBaseBlob()
{
TierToCool = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 30,
},
TierToArchive = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 90,
},
Delete = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 1000,
},
},
Snapshot = new ManagementPolicySnapShot()
{
TierToCool = new DateAfterCreation(30),
TierToArchive = new DateAfterCreation(90),
Delete = new DateAfterCreation(1000),
},
Version = new ManagementPolicyVersion()
{
TierToCool = new DateAfterCreation(30),
TierToArchive = new DateAfterCreation(90),
Delete = new DateAfterCreation(1000),
},
})
{
Filters = new ManagementPolicyFilter(new string[]
{
"blockBlob"
})
{
PrefixMatch =
{
"olcmtestcontainer1"
},
},
})
{
IsEnabled = true,
}
},
            };
            ArmOperation<StorageAccountManagementPolicyResource> lro = await storageAccountManagementPolicy.CreateOrUpdateAsync(WaitUntil.Completed, data);
            StorageAccountManagementPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageAccountManagementPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StorageAccountSetManagementPolicy_BaseBlobDaysAfterCreationActions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StorageAccountSetManagementPolicyBaseBlobDaysAfterCreationActions()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/StorageAccountSetManagementPolicy_BaseBlobDaysAfterCreationActions.json
            // this example is just showing the usage of "ManagementPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountManagementPolicyResource created on azure
            // for more information of creating StorageAccountManagementPolicyResource, please refer to the document of StorageAccountManagementPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string accountName = "sto9699";
            ManagementPolicyName managementPolicyName = ManagementPolicyName.Default;
            ResourceIdentifier storageAccountManagementPolicyResourceId = StorageAccountManagementPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, managementPolicyName);
            StorageAccountManagementPolicyResource storageAccountManagementPolicy = client.GetStorageAccountManagementPolicyResource(storageAccountManagementPolicyResourceId);

            // invoke the operation
            StorageAccountManagementPolicyData data = new StorageAccountManagementPolicyData()
            {
                Rules =
{
new ManagementPolicyRule("olcmtest1",ManagementPolicyRuleType.Lifecycle,new ManagementPolicyDefinition(new ManagementPolicyAction()
{
BaseBlob = new ManagementPolicyBaseBlob()
{
TierToCool = new DateAfterModification()
{
DaysAfterCreationGreaterThan = 30,
},
TierToArchive = new DateAfterModification()
{
DaysAfterCreationGreaterThan = 90,
},
Delete = new DateAfterModification()
{
DaysAfterCreationGreaterThan = 1000,
},
},
})
{
Filters = new ManagementPolicyFilter(new string[]
{
"blockBlob"
})
{
PrefixMatch =
{
"olcmtestcontainer1"
},
},
})
{
IsEnabled = true,
}
},
            };
            ArmOperation<StorageAccountManagementPolicyResource> lro = await storageAccountManagementPolicy.CreateOrUpdateAsync(WaitUntil.Completed, data);
            StorageAccountManagementPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageAccountManagementPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StorageAccountSetManagementPolicy_LastAccessTimeBasedBlobActions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StorageAccountSetManagementPolicyLastAccessTimeBasedBlobActions()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/StorageAccountSetManagementPolicy_LastAccessTimeBasedBlobActions.json
            // this example is just showing the usage of "ManagementPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountManagementPolicyResource created on azure
            // for more information of creating StorageAccountManagementPolicyResource, please refer to the document of StorageAccountManagementPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string accountName = "sto9699";
            ManagementPolicyName managementPolicyName = ManagementPolicyName.Default;
            ResourceIdentifier storageAccountManagementPolicyResourceId = StorageAccountManagementPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, managementPolicyName);
            StorageAccountManagementPolicyResource storageAccountManagementPolicy = client.GetStorageAccountManagementPolicyResource(storageAccountManagementPolicyResourceId);

            // invoke the operation
            StorageAccountManagementPolicyData data = new StorageAccountManagementPolicyData()
            {
                Rules =
{
new ManagementPolicyRule("olcmtest",ManagementPolicyRuleType.Lifecycle,new ManagementPolicyDefinition(new ManagementPolicyAction()
{
BaseBlob = new ManagementPolicyBaseBlob()
{
TierToCool = new DateAfterModification()
{
DaysAfterLastAccessTimeGreaterThan = 30,
},
TierToArchive = new DateAfterModification()
{
DaysAfterLastAccessTimeGreaterThan = 90,
},
Delete = new DateAfterModification()
{
DaysAfterLastAccessTimeGreaterThan = 1000,
},
EnableAutoTierToHotFromCool = true,
},
Snapshot = new ManagementPolicySnapShot()
{
Delete = new DateAfterCreation(30),
},
})
{
Filters = new ManagementPolicyFilter(new string[]
{
"blockBlob"
})
{
PrefixMatch =
{
"olcmtestcontainer"
},
},
})
{
IsEnabled = true,
}
},
            };
            ArmOperation<StorageAccountManagementPolicyResource> lro = await storageAccountManagementPolicy.CreateOrUpdateAsync(WaitUntil.Completed, data);
            StorageAccountManagementPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageAccountManagementPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StorageAccountSetManagementPolicy_LastTierChangeTimeActions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StorageAccountSetManagementPolicyLastTierChangeTimeActions()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/StorageAccountSetManagementPolicy_LastTierChangeTimeActions.json
            // this example is just showing the usage of "ManagementPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountManagementPolicyResource created on azure
            // for more information of creating StorageAccountManagementPolicyResource, please refer to the document of StorageAccountManagementPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string accountName = "sto9699";
            ManagementPolicyName managementPolicyName = ManagementPolicyName.Default;
            ResourceIdentifier storageAccountManagementPolicyResourceId = StorageAccountManagementPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, managementPolicyName);
            StorageAccountManagementPolicyResource storageAccountManagementPolicy = client.GetStorageAccountManagementPolicyResource(storageAccountManagementPolicyResourceId);

            // invoke the operation
            StorageAccountManagementPolicyData data = new StorageAccountManagementPolicyData()
            {
                Rules =
{
new ManagementPolicyRule("olcmtest",ManagementPolicyRuleType.Lifecycle,new ManagementPolicyDefinition(new ManagementPolicyAction()
{
BaseBlob = new ManagementPolicyBaseBlob()
{
TierToCool = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 30,
},
TierToArchive = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 90,
DaysAfterLastTierChangeGreaterThan = 120,
},
Delete = new DateAfterModification()
{
DaysAfterModificationGreaterThan = 1000,
},
},
Snapshot = new ManagementPolicySnapShot()
{
TierToArchive = new DateAfterCreation(30)
{
DaysAfterLastTierChangeGreaterThan = 90,
},
},
Version = new ManagementPolicyVersion()
{
TierToArchive = new DateAfterCreation(30)
{
DaysAfterLastTierChangeGreaterThan = 90,
},
},
})
{
Filters = new ManagementPolicyFilter(new string[]
{
"blockBlob"
})
{
PrefixMatch =
{
"olcmtestcontainer"
},
},
})
{
IsEnabled = true,
}
},
            };
            ArmOperation<StorageAccountManagementPolicyResource> lro = await storageAccountManagementPolicy.CreateOrUpdateAsync(WaitUntil.Completed, data);
            StorageAccountManagementPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageAccountManagementPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StorageAccountDeleteManagementPolicies
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_StorageAccountDeleteManagementPolicies()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/StorageAccountDeleteManagementPolicy.json
            // this example is just showing the usage of "ManagementPolicies_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageAccountManagementPolicyResource created on azure
            // for more information of creating StorageAccountManagementPolicyResource, please refer to the document of StorageAccountManagementPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            ManagementPolicyName managementPolicyName = ManagementPolicyName.Default;
            ResourceIdentifier storageAccountManagementPolicyResourceId = StorageAccountManagementPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, managementPolicyName);
            StorageAccountManagementPolicyResource storageAccountManagementPolicy = client.GetStorageAccountManagementPolicyResource(storageAccountManagementPolicyResourceId);

            // invoke the operation
            await storageAccountManagementPolicy.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
