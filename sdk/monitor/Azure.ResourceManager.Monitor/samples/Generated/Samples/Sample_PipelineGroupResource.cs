// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Monitor.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Monitor.Samples
{
    public partial class Sample_PipelineGroupResource
    {
        // List Pipeline groups by subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPipelineGroups_ListPipelineGroupsBySubscription()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Monitor/preview/2023-10-01-preview/examples/PipelineGroupListBySubscription.json
            // this example is just showing the usage of "PipelineGroups_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (PipelineGroupResource item in subscriptionResource.GetPipelineGroupsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PipelineGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Retrieves a PipelineGroup instance by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RetrievesAPipelineGroupInstanceByName()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Monitor/preview/2023-10-01-preview/examples/PipelineGroupGet.json
            // this example is just showing the usage of "PipelineGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PipelineGroupResource created on azure
            // for more information of creating PipelineGroupResource, please refer to the document of PipelineGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string pipelineGroupName = "plGroup1";
            ResourceIdentifier pipelineGroupResourceId = PipelineGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, pipelineGroupName);
            PipelineGroupResource pipelineGroup = client.GetPipelineGroupResource(pipelineGroupResourceId);

            // invoke the operation
            PipelineGroupResource result = await pipelineGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PipelineGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Updates a PipelineGroup instance
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdatesAPipelineGroupInstance()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Monitor/preview/2023-10-01-preview/examples/PipelineGroupUpdate.json
            // this example is just showing the usage of "PipelineGroups_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PipelineGroupResource created on azure
            // for more information of creating PipelineGroupResource, please refer to the document of PipelineGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string pipelineGroupName = "plGroup1";
            ResourceIdentifier pipelineGroupResourceId = PipelineGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, pipelineGroupName);
            PipelineGroupResource pipelineGroup = client.GetPipelineGroupResource(pipelineGroupResourceId);

            // invoke the operation
            PipelineGroupPatch patch = new PipelineGroupPatch()
            {
                Tags =
{
["tag1"] = "A",
["tag2"] = "B",
},
                Replicas = 3,
                Receivers =
{
new PipelineGroupReceiver(PipelineGroupReceiverType.Syslog,"syslog-receiver1")
{
Syslog = new SyslogReceiver("0.0.0.0:514"),
}
},
                Processors =
{
},
                Exporters =
{
new PipelineGroupExporter(PipelineGroupExporterType.AzureMonitorWorkspaceLogs,"my-workspace-logs-exporter1")
{
AzureMonitorWorkspaceLogs = new AzureMonitorWorkspaceLogsExporter(new AzureMonitorWorkspaceLogsApiConfig(new Uri("https://logs-myingestion-eb0s.eastus-1.ingest.monitor.azure.com"),"Custom-MyTableRawData_CL","dcr-00000000000000000000000000000000",new MonitorWorkspaceLogsSchemaMap(new MonitorWorkspaceLogsRecordMap[]
{
new MonitorWorkspaceLogsRecordMap("body","Body"),new MonitorWorkspaceLogsRecordMap("severity_text","SeverityText"),new MonitorWorkspaceLogsRecordMap("time_unix_nano","TimeGenerated")
})))
{
Concurrency = new MonitorWorkspaceLogsExporterConcurrencyConfiguration()
{
WorkerCount = 4,
BatchQueueSize = 100,
},
},
}
},
                Service = new PipelineGroupService(new PipelineGroupServicePipeline[]
            {
new PipelineGroupServicePipeline("MyPipelineForLogs1",PipelineGroupServicePipelineType.Logs,new string[]
{
"syslog-receiver1"
},new string[]
{
"my-workspace-logs-exporter1"
})
{
Processors =
{
},
}
            }),
            };
            ArmOperation<PipelineGroupResource> lro = await pipelineGroup.UpdateAsync(WaitUntil.Completed, patch);
            PipelineGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PipelineGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deletes a PipelineGroup instance
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletesAPipelineGroupInstance()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Monitor/preview/2023-10-01-preview/examples/PipelineGroupDelete.json
            // this example is just showing the usage of "PipelineGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PipelineGroupResource created on azure
            // for more information of creating PipelineGroupResource, please refer to the document of PipelineGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string pipelineGroupName = "plGroup1";
            ResourceIdentifier pipelineGroupResourceId = PipelineGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, pipelineGroupName);
            PipelineGroupResource pipelineGroup = client.GetPipelineGroupResource(pipelineGroupResourceId);

            // invoke the operation
            await pipelineGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
