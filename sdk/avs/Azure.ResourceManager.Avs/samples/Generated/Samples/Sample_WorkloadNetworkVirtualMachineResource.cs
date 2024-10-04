// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_WorkloadNetworkVirtualMachineResource
    {
        // WorkloadNetworks_GetVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkloadNetworksGetVirtualMachine()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_GetVirtualMachine.json
            // this example is just showing the usage of "WorkloadNetworks_GetVirtualMachine" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkVirtualMachineResource created on azure
            // for more information of creating WorkloadNetworkVirtualMachineResource, please refer to the document of WorkloadNetworkVirtualMachineResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string virtualMachineId = "vm1";
            ResourceIdentifier workloadNetworkVirtualMachineResourceId = WorkloadNetworkVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, virtualMachineId);
            WorkloadNetworkVirtualMachineResource workloadNetworkVirtualMachine = client.GetWorkloadNetworkVirtualMachineResource(workloadNetworkVirtualMachineResourceId);

            // invoke the operation
            WorkloadNetworkVirtualMachineResource result = await workloadNetworkVirtualMachine.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkVirtualMachineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
