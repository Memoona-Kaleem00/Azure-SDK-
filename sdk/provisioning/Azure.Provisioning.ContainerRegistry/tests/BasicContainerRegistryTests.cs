// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Tests;
using NUnit.Framework;

namespace Azure.Provisioning.ContainerRegistry.Tests;

public class BasicContainerRegistryTests(bool async)
    : ProvisioningTestBase(async /*, skipTools: true, skipLiveCalls: true /**/)
{
    [Test]
    [Description("https://github.com/Azure/azure-quickstart-templates/blob/master/quickstarts/microsoft.containerregistry/container-registry/main.bicep")]
    public async Task CreateContainerRegistry()
    {
        await using Trycep test = CreateBicepTest();
        await test.Define(
            ctx =>
            {
                BicepParameter location =
                    new(nameof(location), typeof(string))
                    {
                        Value = BicepFunction.GetResourceGroup().Location,
                        Description = "Service location."
                    };

                ContainerRegistryService registry =
                    new(nameof(registry))
                    {
                        Location = location,
                        Sku = new ContainerRegistrySku { Name = ContainerRegistrySkuName.Standard },
                        IsAdminUserEnabled = false,
                        Tags = { { "displayName", "ContainerRegistry" } }
                    };
                registry.Tags.Add("container.registry", registry.Name);

                _ = new BicepOutput("registryLoginServer", typeof(string)) { Value = registry.LoginServer };
            })
        .Compare(
            """
            @description('Service location.')
            param location string = resourceGroup().location

            resource registry 'Microsoft.ContainerRegistry/registries@2023-07-01' = {
                name: take('registry${uniqueString(resourceGroup().id)}', 50)
                location: location
                sku: {
                    name: 'Standard'
                }
                properties: {
                    adminUserEnabled: false
                }
                tags: {
                    displayName: 'ContainerRegistry'
                    'container.registry': take('registry${uniqueString(resourceGroup().id)}', 50)
                }
            }

            output registryLoginServer string = registry.properties.loginServer
            """)
        .Lint()
        .ValidateAndDeployAsync();
    }
}
