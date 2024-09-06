// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_SavingsPlanOrderModelCollection
    {
        // SavingsPlanOrderGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SavingsPlanOrderGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/savingsPlanOrderGetByBillingAccount.json
            // this example is just showing the usage of "SavingsPlanOrders_GetByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this SavingsPlanOrderModelResource
            SavingsPlanOrderModelCollection collection = billingAccount.GetSavingsPlanOrderModels();

            // invoke the operation
            string savingsPlanOrderId = "20000000-0000-0000-0000-000000000000";
            SavingsPlanOrderModelResource result = await collection.GetAsync(savingsPlanOrderId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SavingsPlanOrderModelData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SavingsPlanOrderGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SavingsPlanOrderGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/savingsPlanOrderGetByBillingAccount.json
            // this example is just showing the usage of "SavingsPlanOrders_GetByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this SavingsPlanOrderModelResource
            SavingsPlanOrderModelCollection collection = billingAccount.GetSavingsPlanOrderModels();

            // invoke the operation
            string savingsPlanOrderId = "20000000-0000-0000-0000-000000000000";
            bool result = await collection.ExistsAsync(savingsPlanOrderId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SavingsPlanOrderGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_SavingsPlanOrderGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/savingsPlanOrderGetByBillingAccount.json
            // this example is just showing the usage of "SavingsPlanOrders_GetByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this SavingsPlanOrderModelResource
            SavingsPlanOrderModelCollection collection = billingAccount.GetSavingsPlanOrderModels();

            // invoke the operation
            string savingsPlanOrderId = "20000000-0000-0000-0000-000000000000";
            NullableResponse<SavingsPlanOrderModelResource> response = await collection.GetIfExistsAsync(savingsPlanOrderId);
            SavingsPlanOrderModelResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SavingsPlanOrderModelData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // SavingsPlanOrderWithExpandedPaymentsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SavingsPlanOrderWithExpandedPaymentsGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/savingsPlanOrderExpandedScheduleGetByBillingAccount.json
            // this example is just showing the usage of "SavingsPlanOrders_GetByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this SavingsPlanOrderModelResource
            SavingsPlanOrderModelCollection collection = billingAccount.GetSavingsPlanOrderModels();

            // invoke the operation
            string savingsPlanOrderId = "20000000-0000-0000-0000-000000000000";
            SavingsPlanOrderModelResource result = await collection.GetAsync(savingsPlanOrderId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SavingsPlanOrderModelData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SavingsPlanOrderWithExpandedPaymentsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SavingsPlanOrderWithExpandedPaymentsGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/savingsPlanOrderExpandedScheduleGetByBillingAccount.json
            // this example is just showing the usage of "SavingsPlanOrders_GetByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this SavingsPlanOrderModelResource
            SavingsPlanOrderModelCollection collection = billingAccount.GetSavingsPlanOrderModels();

            // invoke the operation
            string savingsPlanOrderId = "20000000-0000-0000-0000-000000000000";
            bool result = await collection.ExistsAsync(savingsPlanOrderId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SavingsPlanOrderWithExpandedPaymentsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_SavingsPlanOrderWithExpandedPaymentsGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/savingsPlanOrderExpandedScheduleGetByBillingAccount.json
            // this example is just showing the usage of "SavingsPlanOrders_GetByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this SavingsPlanOrderModelResource
            SavingsPlanOrderModelCollection collection = billingAccount.GetSavingsPlanOrderModels();

            // invoke the operation
            string savingsPlanOrderId = "20000000-0000-0000-0000-000000000000";
            NullableResponse<SavingsPlanOrderModelResource> response = await collection.GetIfExistsAsync(savingsPlanOrderId);
            SavingsPlanOrderModelResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SavingsPlanOrderModelData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // SavingsPlanOrderList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SavingsPlanOrderList()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/savingsPlanOrderListByBillingAccount.json
            // this example is just showing the usage of "SavingsPlanOrders_ListByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this SavingsPlanOrderModelResource
            SavingsPlanOrderModelCollection collection = billingAccount.GetSavingsPlanOrderModels();

            // invoke the operation and iterate over the result
            await foreach (SavingsPlanOrderModelResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SavingsPlanOrderModelData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
