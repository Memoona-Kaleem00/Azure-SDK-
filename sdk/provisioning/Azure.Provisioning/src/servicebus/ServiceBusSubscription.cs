// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.ResourceManager.ServiceBus;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.Provisioning.ServiceBus
{
    /// <summary>
    /// Represents a Service Bus subscription.
    /// </summary>
    public class ServiceBusSubscription : Resource<ServiceBusSubscriptionData>
    {
        private const string ResourceTypeName = "Microsoft.ServiceBus/namespaces/topics/subscriptions";
        private static readonly Func<string, ServiceBusSubscriptionData> Empty = (name) => ArmServiceBusModelFactory.ServiceBusSubscriptionData();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceBusSubscription"/>.
        /// </summary>
        /// <param name="scope">The scope.</param>
        /// <param name="requiresSession">Whether to use sessions.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="name">The name.</param>
        /// <param name="version">The version.</param>
        /// <param name="location">The location.</param>
        public ServiceBusSubscription(IConstruct scope, bool? requiresSession = default, ServiceBusTopic? parent = null, string name = "sbsubscription", string version = ServiceBusNamespace.DefaultVersion, AzureLocation? location = default)
            : this(scope, parent, name, version, false, (name) => ArmServiceBusModelFactory.ServiceBusSubscriptionData(
                name: name,
                requiresSession: requiresSession,
                resourceType: ResourceTypeName,
                location: location ?? Environment.GetEnvironmentVariable("AZURE_LOCATION") ?? AzureLocation.WestUS))
        {
        }

        private ServiceBusSubscription(IConstruct scope, ServiceBusTopic? parent = null, string name = "sbsubscription", string version = ServiceBusNamespace.DefaultVersion, bool isExisting = true, Func<string, ServiceBusSubscriptionData>? creator = null)
            : base(scope, parent, name, ResourceTypeName, version, creator ?? Empty, isExisting)
        {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ServiceBusSubscription"/> class referencing an existing instance.
        /// </summary>
        /// <param name="scope">The scope.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="parent">The resource group.</param>
        /// <returns>The KeyVault instance.</returns>
        public static ServiceBusSubscription FromExisting(IConstruct scope, string name, ServiceBusTopic parent)
            => new ServiceBusSubscription(scope, parent: parent, name: name, isExisting: true);

        /// <inheritdoc/>
        protected override Resource? FindParentInScope(IConstruct scope)
        {
            return scope.GetSingleResource<ServiceBusTopic>() ?? new ServiceBusTopic(scope);
        }
    }
}
