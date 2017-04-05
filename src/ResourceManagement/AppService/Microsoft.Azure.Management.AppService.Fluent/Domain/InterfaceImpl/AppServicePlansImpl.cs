// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.AppService.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.AppService.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using System.Collections.Generic;

    internal partial class AppServicePlansImpl 
    {
        /// <summary>
        /// Begins a definition for a new resource.
        /// <p>
        /// This is the beginning of the builder pattern used to create top level resources
        /// in Azure. The final method completing the definition and starting the actual resource creation
        /// process in Azure is Creatable.create().
        /// <p>
        /// Note that the Creatable.create() method is
        /// only available at the stage of the resource definition that has the minimum set of input
        /// parameters specified. If you do not see Creatable.create() among the available methods, it
        /// means you have not yet specified all the required input settings. Input settings generally begin
        /// with the word "with", for example: <code>.withNewResourceGroup()</code> and return the next stage
        /// of the resource definition, as an interface in the "fluent interface" style.
        /// </summary>
        /// <param name="name">The name of the new resource.</param>
        AppServicePlan.Definition.IBlank Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsCreating<AppServicePlan.Definition.IBlank>.Define(string name)
        {
            return this.Define(name) as AppServicePlan.Definition.IBlank;
        }

        /// <summary>
        /// Lists resources of the specified type in the specified resource group.
        /// </summary>
        /// <param name="resourceGroupName">The name of the resource group to list the resources from.</param>
        IEnumerable<Microsoft.Azure.Management.AppService.Fluent.IAppServicePlan> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListingByGroup<Microsoft.Azure.Management.AppService.Fluent.IAppServicePlan>.ListByGroup(string resourceGroupName)
        {
            return this.ListByGroup(resourceGroupName);
        }


        /// <summary>
        /// Lists resources of the specified type in the subscription.
        /// </summary>
        IEnumerable<Microsoft.Azure.Management.AppService.Fluent.IAppServicePlan> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListing<Microsoft.Azure.Management.AppService.Fluent.IAppServicePlan>.List()
        {
            return this.List();
        }

        /// <summary>
        /// Gets the information about a resource from Azure based on the resource name and the name of its resource group.
        /// </summary>
        /// <param name="resourceGroupName">The name of the resource group the resource is in.</param>
        /// <param name="name">The name of the resource. (Note, this is not the ID).</param>
        async Task<IAppServicePlan> ISupportsGettingByGroup<IAppServicePlan>.GetByGroupAsync(string resourceGroupName, string name, CancellationToken cancellationToken)
        {
            return await this.GetByGroupAsync(resourceGroupName, name, cancellationToken) as Microsoft.Azure.Management.AppService.Fluent.IAppServicePlan;
        }

        /// <summary>
        /// Gets the information about a resource from Azure based on the resource name and the name of its resource group.
        /// </summary>
        /// <param name="id">The app service plan resource ID.</param>
        async Task<IAppServicePlan> ISupportsGettingById<IAppServicePlan>.GetByIdAsync(string id, CancellationToken cancellationToken)
        {
            return await this.GetByIdAsync(id, cancellationToken) as Microsoft.Azure.Management.AppService.Fluent.IAppServicePlan;
        }

        /// <summary>
        /// Asynchronously delete a resource from Azure, identifying it by its name and its resource group.
        /// </summary>
        /// <param name="groupName">The group the resource is part of.</param>
        /// <param name="name">The name of the resource.</param>
        async Task ISupportsDeletingByGroup.DeleteByGroupAsync(string groupName, string name, CancellationToken cancellationToken)
        {
 
            await this.DeleteByGroupAsync(groupName, name, cancellationToken);
        }
    }
}