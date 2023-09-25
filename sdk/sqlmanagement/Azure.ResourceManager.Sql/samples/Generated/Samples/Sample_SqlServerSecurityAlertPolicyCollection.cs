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
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SqlServerSecurityAlertPolicyCollection
    {
        // Get a server's threat detection policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAServerSThreatDetectionPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ServerSecurityAlertsGet.json
            // this example is just showing the usage of "ServerSecurityAlertPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string serverName = "securityalert-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this SqlServerSecurityAlertPolicyResource
            SqlServerSecurityAlertPolicyCollection collection = sqlServer.GetSqlServerSecurityAlertPolicies();

            // invoke the operation
            SqlSecurityAlertPolicyName securityAlertPolicyName = SqlSecurityAlertPolicyName.Default;
            SqlServerSecurityAlertPolicyResource result = await collection.GetAsync(securityAlertPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerSecurityAlertPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a server's threat detection policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAServerSThreatDetectionPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ServerSecurityAlertsGet.json
            // this example is just showing the usage of "ServerSecurityAlertPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string serverName = "securityalert-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this SqlServerSecurityAlertPolicyResource
            SqlServerSecurityAlertPolicyCollection collection = sqlServer.GetSqlServerSecurityAlertPolicies();

            // invoke the operation
            SqlSecurityAlertPolicyName securityAlertPolicyName = SqlSecurityAlertPolicyName.Default;
            bool result = await collection.ExistsAsync(securityAlertPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a server's threat detection policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAServerSThreatDetectionPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ServerSecurityAlertsGet.json
            // this example is just showing the usage of "ServerSecurityAlertPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string serverName = "securityalert-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this SqlServerSecurityAlertPolicyResource
            SqlServerSecurityAlertPolicyCollection collection = sqlServer.GetSqlServerSecurityAlertPolicies();

            // invoke the operation
            SqlSecurityAlertPolicyName securityAlertPolicyName = SqlSecurityAlertPolicyName.Default;
            NullableResponse<SqlServerSecurityAlertPolicyResource> response = await collection.GetIfExistsAsync(securityAlertPolicyName);
            SqlServerSecurityAlertPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlServerSecurityAlertPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Update a server's threat detection policy with all parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateAServerSThreatDetectionPolicyWithAllParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ServerSecurityAlertsCreateMax.json
            // this example is just showing the usage of "ServerSecurityAlertPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string serverName = "securityalert-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this SqlServerSecurityAlertPolicyResource
            SqlServerSecurityAlertPolicyCollection collection = sqlServer.GetSqlServerSecurityAlertPolicies();

            // invoke the operation
            SqlSecurityAlertPolicyName securityAlertPolicyName = SqlSecurityAlertPolicyName.Default;
            SqlServerSecurityAlertPolicyData data = new SqlServerSecurityAlertPolicyData()
            {
                State = SecurityAlertsPolicyState.Enabled,
                DisabledAlerts =
{
"Access_Anomaly","Usage_Anomaly"
},
                EmailAddresses =
{
"testSecurityAlert@microsoft.com"
},
                SendToEmailAccountAdmins = true,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
                RetentionDays = 5,
            };
            ArmOperation<SqlServerSecurityAlertPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, securityAlertPolicyName, data);
            SqlServerSecurityAlertPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerSecurityAlertPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a server's threat detection policy with minimal parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateAServerSThreatDetectionPolicyWithMinimalParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ServerSecurityAlertsCreateMin.json
            // this example is just showing the usage of "ServerSecurityAlertPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string serverName = "securityalert-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this SqlServerSecurityAlertPolicyResource
            SqlServerSecurityAlertPolicyCollection collection = sqlServer.GetSqlServerSecurityAlertPolicies();

            // invoke the operation
            SqlSecurityAlertPolicyName securityAlertPolicyName = SqlSecurityAlertPolicyName.Default;
            SqlServerSecurityAlertPolicyData data = new SqlServerSecurityAlertPolicyData()
            {
                State = SecurityAlertsPolicyState.Enabled,
            };
            ArmOperation<SqlServerSecurityAlertPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, securityAlertPolicyName, data);
            SqlServerSecurityAlertPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerSecurityAlertPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List the server's threat detection policies
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListTheServerSThreatDetectionPolicies()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ServerSecurityAlertsListByServer.json
            // this example is just showing the usage of "ServerSecurityAlertPolicies_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string serverName = "securityalert-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this SqlServerSecurityAlertPolicyResource
            SqlServerSecurityAlertPolicyCollection collection = sqlServer.GetSqlServerSecurityAlertPolicies();

            // invoke the operation and iterate over the result
            await foreach (SqlServerSecurityAlertPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlServerSecurityAlertPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
