﻿using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.Core.Tests
{
    public class GenericResourceContainerTests : ResourceManagerTestBase
    {
        public GenericResourceContainerTests(bool isAsync)
         : base(isAsync)//, RecordedTestMode.Record)
        {
        }

        [TestCase]
        [RecordedTest]
        public async Task Get()
        {
            ResourceGroup rg = await Client.DefaultSubscription.GetResourceGroups().Construct(LocationData.WestUS2).CreateOrUpdateAsync(Recording.GenerateAssetName("testrg"));
            var aset = await CreateGenericAvailabilitySetAsync(rg.Id);

            var genericResources = Client.DefaultSubscription.GetGenericResources();
            GenericResource aset2 = await genericResources.GetAsync(aset.Data.Id);

            AssertAreEqual(aset, aset2);
        }

        [TestCase]
        [RecordedTest]
        public async Task List()
        {
            ResourceGroup rg1 = await Client.DefaultSubscription.GetResourceGroups().Construct(LocationData.WestUS2).CreateOrUpdateAsync(Recording.GenerateAssetName("testrg"));
            _ = await CreateGenericAvailabilitySetAsync(rg1.Id);
            ResourceGroup rg2 = await Client.DefaultSubscription.GetResourceGroups().Construct(LocationData.WestUS2).CreateOrUpdateAsync(Recording.GenerateAssetName("testrg"));
            _ = await CreateGenericAvailabilitySetAsync(rg2.Id);

            var count = await GetResourceCountAsync(Client.DefaultSubscription.GetGenericResources());
            Assert.GreaterOrEqual(count, 2);
        }

        [TestCase]
        [RecordedTest]
        public async Task ListByResourceGroup()
        {
            ResourceGroup rg1 = await Client.DefaultSubscription.GetResourceGroups().Construct(LocationData.WestUS2).CreateOrUpdateAsync(Recording.GenerateAssetName("testrg"));
            _ = await CreateGenericAvailabilitySetAsync(rg1.Id);
            _ = await CreateGenericAvailabilitySetAsync(rg1.Id);
            ResourceGroup rg2 = await Client.DefaultSubscription.GetResourceGroups().Construct(LocationData.WestUS2).CreateOrUpdateAsync(Recording.GenerateAssetName("testrg"));
            _ = await CreateGenericAvailabilitySetAsync(rg2.Id);

            var count = await GetResourceCountAsync(Client.DefaultSubscription.GetGenericResources(), rg1);
            Assert.AreEqual(2, count);

            count = await GetResourceCountAsync (Client.DefaultSubscription.GetGenericResources(), rg2);
            Assert.AreEqual(1, count);
        }

        [TestCase]
        [RecordedTest]
        public async Task DoesExist()
        {
            ResourceGroup rg = await Client.DefaultSubscription.GetResourceGroups().Construct(LocationData.WestUS2).CreateOrUpdateAsync(Recording.GenerateAssetName("testrg"));
            var aset = await CreateGenericAvailabilitySetAsync(rg.Id);

            Assert.IsTrue(await Client.DefaultSubscription.GetGenericResources().DoesExistAsync(aset.Data.Id));
            Assert.IsFalse(await Client.DefaultSubscription.GetGenericResources().DoesExistAsync(aset.Data.Id + "1"));
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            ResourceGroup rg = await Client.DefaultSubscription.GetResourceGroups().Construct(LocationData.WestUS2).CreateOrUpdateAsync(Recording.GenerateAssetName("testrg"));
            Assert.DoesNotThrowAsync(async () => _ = await CreateGenericAvailabilitySetAsync(rg.Id));
        }

        [TestCase]
        [RecordedTest]
        public async Task StartCreateOrUpdate()
        {
            var rgOp = await Client.DefaultSubscription.GetResourceGroups().Construct(LocationData.WestUS2).StartCreateOrUpdateAsync(Recording.GenerateAssetName("testrg"));
            ResourceGroup rg = await rgOp.WaitForCompletionAsync();
            Assert.DoesNotThrowAsync(async () => {
                var createOp = await StartCreateGenericAvailabilitySetAsync(rg.Id);
                _ = await createOp.WaitForCompletionAsync();
            });
        }
    }
}
