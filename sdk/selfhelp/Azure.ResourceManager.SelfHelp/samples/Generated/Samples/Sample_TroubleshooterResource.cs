// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.SelfHelp;
using Azure.ResourceManager.SelfHelp.Models;

namespace Azure.ResourceManager.SelfHelp.Samples
{
    public partial class Sample_TroubleshooterResource
    {
        // Troubleshooters_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_TroubleshootersCreate()
        {
            // Generated from example definition: specification/help/resource-manager/Microsoft.Help/preview/2023-09-01-preview/examples/Troubleshooter_Create.json
            // this example is just showing the usage of "Troubleshooters_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TroubleshooterResource created on azure
            // for more information of creating TroubleshooterResource, please refer to the document of TroubleshooterResource
            string scope = "subscriptions/mySubscription/resourcegroups/myresourceGroup/providers/Microsoft.KeyVault/vaults/test-keyvault-rp";
            string troubleshooterName = "abf168ed-1b54-454a-86f6-e4b62253d3b1";
            ResourceIdentifier troubleshooterResourceId = TroubleshooterResource.CreateResourceIdentifier(scope, troubleshooterName);
            TroubleshooterResource troubleshooterResource = client.GetTroubleshooterResource(troubleshooterResourceId);

            // invoke the operation
            TroubleshooterResourceData data = new TroubleshooterResourceData()
            {
                SolutionId = "SampleTroubleshooterSolutionId",
                Parameters =
{
["ResourceURI"] = "subscriptions/mySubscription/resourcegroups/myresourceGroup/providers/Microsoft.KeyVault/vaults/test-keyvault-rp",
},
            };
            ArmOperation<TroubleshooterResource> lro = await troubleshooterResource.UpdateAsync(WaitUntil.Completed, data);
            TroubleshooterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TroubleshooterResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Troubleshooters_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_TroubleshootersGet()
        {
            // Generated from example definition: specification/help/resource-manager/Microsoft.Help/preview/2023-09-01-preview/examples/Troubleshooter_Get.json
            // this example is just showing the usage of "Troubleshooters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TroubleshooterResource created on azure
            // for more information of creating TroubleshooterResource, please refer to the document of TroubleshooterResource
            string scope = "subscriptions/mySubscription/resourcegroups/myresourceGroup/providers/Microsoft.KeyVault/vaults/test-keyvault-rp";
            string troubleshooterName = "abf168ed-1b54-454a-86f6-e4b62253d3b1";
            ResourceIdentifier troubleshooterResourceId = TroubleshooterResource.CreateResourceIdentifier(scope, troubleshooterName);
            TroubleshooterResource troubleshooterResource = client.GetTroubleshooterResource(troubleshooterResourceId);

            // invoke the operation
            TroubleshooterResource result = await troubleshooterResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TroubleshooterResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Troubleshooter_Continue
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Continue_TroubleshooterContinue()
        {
            // Generated from example definition: specification/help/resource-manager/Microsoft.Help/preview/2023-09-01-preview/examples/Troubleshooter_Continue.json
            // this example is just showing the usage of "Troubleshooters_Continue" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TroubleshooterResource created on azure
            // for more information of creating TroubleshooterResource, please refer to the document of TroubleshooterResource
            string scope = "subscriptions/mySubscription/resourcegroups/myresourceGroup/providers/Microsoft.KeyVault/vaults/test-keyvault-rp";
            string troubleshooterName = "abf168ed-1b54-454a-86f6-e4b62253d3b1";
            ResourceIdentifier troubleshooterResourceId = TroubleshooterResource.CreateResourceIdentifier(scope, troubleshooterName);
            TroubleshooterResource troubleshooterResource = client.GetTroubleshooterResource(troubleshooterResourceId);

            // invoke the operation
            ContinueRequestBody continueRequestBody = new ContinueRequestBody()
            {
                StepId = "SampleStepId",
                Responses =
{
new TroubleshooterResult()
{
QuestionId = "SampleQuestionId",
QuestionType = new QuestionType("Text"),
Response = "Connection exception",
}
},
            };
            await troubleshooterResource.ContinueAsync(continueRequestBody: continueRequestBody);

            Console.WriteLine($"Succeeded");
        }

        // Troubleshooters_End
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task End_TroubleshootersEnd()
        {
            // Generated from example definition: specification/help/resource-manager/Microsoft.Help/preview/2023-09-01-preview/examples/Troubleshooter_End.json
            // this example is just showing the usage of "Troubleshooters_End" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TroubleshooterResource created on azure
            // for more information of creating TroubleshooterResource, please refer to the document of TroubleshooterResource
            string scope = "subscriptions/mySubscription/resourcegroups/myresourceGroup/providers/Microsoft.KeyVault/vaults/test-keyvault-rp";
            string troubleshooterName = "abf168ed-1b54-454a-86f6-e4b62253d3b1";
            ResourceIdentifier troubleshooterResourceId = TroubleshooterResource.CreateResourceIdentifier(scope, troubleshooterName);
            TroubleshooterResource troubleshooterResource = client.GetTroubleshooterResource(troubleshooterResourceId);

            // invoke the operation
            await troubleshooterResource.EndAsync();

            Console.WriteLine($"Succeeded");
        }

        // Troubleshooters_Restart
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Restart_TroubleshootersRestart()
        {
            // Generated from example definition: specification/help/resource-manager/Microsoft.Help/preview/2023-09-01-preview/examples/Troubleshooter_Restart.json
            // this example is just showing the usage of "Troubleshooters_Restart" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TroubleshooterResource created on azure
            // for more information of creating TroubleshooterResource, please refer to the document of TroubleshooterResource
            string scope = "subscriptions/mySubscription/resourcegroups/myresourceGroup/providers/Microsoft.KeyVault/vaults/test-keyvault-rp";
            string troubleshooterName = "abf168ed-1b54-454a-86f6-e4b62253d3b1";
            ResourceIdentifier troubleshooterResourceId = TroubleshooterResource.CreateResourceIdentifier(scope, troubleshooterName);
            TroubleshooterResource troubleshooterResource = client.GetTroubleshooterResource(troubleshooterResourceId);

            // invoke the operation
            RestartTroubleshooterResult result = await troubleshooterResource.RestartAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
