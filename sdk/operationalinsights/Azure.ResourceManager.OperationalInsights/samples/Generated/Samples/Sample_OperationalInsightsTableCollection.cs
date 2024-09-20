// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights.Samples
{
    public partial class Sample_OperationalInsightsTableCollection
    {
        // TablesListByWorkspace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_TablesListByWorkspace()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2022-10-01/examples/TablesList.json
            // this example is just showing the usage of "Tables_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "oiautorest6685";
            string workspaceName = "oiautorest6685";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsTableResource
            OperationalInsightsTableCollection collection = operationalInsightsWorkspace.GetOperationalInsightsTables();

            // invoke the operation and iterate over the result
            await foreach (OperationalInsightsTableResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OperationalInsightsTableData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // TablesUpsert
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_TablesUpsert()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2022-10-01/examples/TablesUpsert.json
            // this example is just showing the usage of "Tables_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "oiautorest6685";
            string workspaceName = "oiautorest6685";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsTableResource
            OperationalInsightsTableCollection collection = operationalInsightsWorkspace.GetOperationalInsightsTables();

            // invoke the operation
            string tableName = "AzureNetworkFlow";
            OperationalInsightsTableData data = new OperationalInsightsTableData()
            {
                RetentionInDays = 45,
                TotalRetentionInDays = 70,
                Schema = new OperationalInsightsSchema()
                {
                    Name = "AzureNetworkFlow",
                    Columns =
{
new OperationalInsightsColumn()
{
Name = "MyNewColumn",
ColumnType = OperationalInsightsColumnType.Guid,
}
},
                },
            };
            ArmOperation<OperationalInsightsTableResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, tableName, data);
            OperationalInsightsTableResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsTableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // TablesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_TablesGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2022-10-01/examples/TablesGet.json
            // this example is just showing the usage of "Tables_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "oiautorest6685";
            string workspaceName = "oiautorest6685";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsTableResource
            OperationalInsightsTableCollection collection = operationalInsightsWorkspace.GetOperationalInsightsTables();

            // invoke the operation
            string tableName = "table1_SRCH";
            OperationalInsightsTableResource result = await collection.GetAsync(tableName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsTableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // TablesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_TablesGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2022-10-01/examples/TablesGet.json
            // this example is just showing the usage of "Tables_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "oiautorest6685";
            string workspaceName = "oiautorest6685";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsTableResource
            OperationalInsightsTableCollection collection = operationalInsightsWorkspace.GetOperationalInsightsTables();

            // invoke the operation
            string tableName = "table1_SRCH";
            bool result = await collection.ExistsAsync(tableName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // TablesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_TablesGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2022-10-01/examples/TablesGet.json
            // this example is just showing the usage of "Tables_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "oiautorest6685";
            string workspaceName = "oiautorest6685";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsTableResource
            OperationalInsightsTableCollection collection = operationalInsightsWorkspace.GetOperationalInsightsTables();

            // invoke the operation
            string tableName = "table1_SRCH";
            NullableResponse<OperationalInsightsTableResource> response = await collection.GetIfExistsAsync(tableName);
            OperationalInsightsTableResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OperationalInsightsTableData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
