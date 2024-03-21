// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Samples
{
    public partial class Sample_ScalingPlanPooledScheduleResource
    {
        // ScalingPlanPooledSchedules_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ScalingPlanPooledSchedulesGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2023-09-05/examples/ScalingPlanPooledSchedule_Get.json
            // this example is just showing the usage of "ScalingPlanPooledSchedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScalingPlanPooledScheduleResource created on azure
            // for more information of creating ScalingPlanPooledScheduleResource, please refer to the document of ScalingPlanPooledScheduleResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string scalingPlanName = "scalingPlan1";
            string scalingPlanScheduleName = "scalingPlanScheduleWeekdays1";
            ResourceIdentifier scalingPlanPooledScheduleResourceId = ScalingPlanPooledScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, scalingPlanName, scalingPlanScheduleName);
            ScalingPlanPooledScheduleResource scalingPlanPooledSchedule = client.GetScalingPlanPooledScheduleResource(scalingPlanPooledScheduleResourceId);

            // invoke the operation
            ScalingPlanPooledScheduleResource result = await scalingPlanPooledSchedule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScalingPlanPooledScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ScalingPlanPooledSchedules_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ScalingPlanPooledSchedulesDelete()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2023-09-05/examples/ScalingPlanPooledSchedule_Delete.json
            // this example is just showing the usage of "ScalingPlanPooledSchedules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScalingPlanPooledScheduleResource created on azure
            // for more information of creating ScalingPlanPooledScheduleResource, please refer to the document of ScalingPlanPooledScheduleResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string scalingPlanName = "scalingPlan1";
            string scalingPlanScheduleName = "scalingPlanScheduleWeekdays1";
            ResourceIdentifier scalingPlanPooledScheduleResourceId = ScalingPlanPooledScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, scalingPlanName, scalingPlanScheduleName);
            ScalingPlanPooledScheduleResource scalingPlanPooledSchedule = client.GetScalingPlanPooledScheduleResource(scalingPlanPooledScheduleResourceId);

            // invoke the operation
            await scalingPlanPooledSchedule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ScalingPlanPooledSchedules_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ScalingPlanPooledSchedulesUpdate()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2023-09-05/examples/ScalingPlanPooledSchedule_Update.json
            // this example is just showing the usage of "ScalingPlanPooledSchedules_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScalingPlanPooledScheduleResource created on azure
            // for more information of creating ScalingPlanPooledScheduleResource, please refer to the document of ScalingPlanPooledScheduleResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string scalingPlanName = "scalingPlan1";
            string scalingPlanScheduleName = "scalingPlanScheduleWeekdays1";
            ResourceIdentifier scalingPlanPooledScheduleResourceId = ScalingPlanPooledScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, scalingPlanName, scalingPlanScheduleName);
            ScalingPlanPooledScheduleResource scalingPlanPooledSchedule = client.GetScalingPlanPooledScheduleResource(scalingPlanPooledScheduleResourceId);

            // invoke the operation
            ScalingPlanPooledSchedulePatch patch = new ScalingPlanPooledSchedulePatch()
            {
                DaysOfWeek =
{
DesktopVirtualizationDayOfWeek.Monday,DesktopVirtualizationDayOfWeek.Tuesday,DesktopVirtualizationDayOfWeek.Wednesday,DesktopVirtualizationDayOfWeek.Thursday,DesktopVirtualizationDayOfWeek.Friday
},
                RampUpLoadBalancingAlgorithm = SessionHostLoadBalancingAlgorithm.DepthFirst,
                RampUpCapacityThresholdPct = 80,
                PeakStartTime = new ScalingActionTime(8, 0),
                RampDownLoadBalancingAlgorithm = SessionHostLoadBalancingAlgorithm.DepthFirst,
                RampDownMinimumHostsPct = 20,
                RampDownWaitTimeMinutes = 30,
            };
            ScalingPlanPooledScheduleResource result = await scalingPlanPooledSchedule.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScalingPlanPooledScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
