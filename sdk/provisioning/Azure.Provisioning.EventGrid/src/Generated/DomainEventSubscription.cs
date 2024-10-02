// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// DomainEventSubscription.
/// </summary>
public partial class DomainEventSubscription : Resource
{
    /// <summary>
    /// Name of the event subscription to be created. Event subscription names
    /// must be between 3 and 64 characters in length and use alphanumeric
    /// letters only.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The dead letter destination of the event subscription. Any event that
    /// cannot be delivered to its&apos; destination is sent to the dead
    /// letter destination.             Uses Azure Event Grid&apos;s identity
    /// to acquire the authentication tokens being used during delivery /
    /// dead-lettering.             Please note
    /// Azure.ResourceManager.EventGrid.Models.DeadLetterDestination is the
    /// base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.EventGrid.Models.StorageBlobDeadLetterDestination.
    /// </summary>
    public BicepValue<DeadLetterDestination> DeadLetterDestination { get => _deadLetterDestination; set => _deadLetterDestination.Assign(value); }
    private readonly BicepValue<DeadLetterDestination> _deadLetterDestination;

    /// <summary>
    /// The dead letter destination of the event subscription. Any event that
    /// cannot be delivered to its&apos; destination is sent to the dead
    /// letter destination.             Uses the managed identity setup on the
    /// parent resource (namely, topic or domain) to acquire the
    /// authentication tokens being used during delivery / dead-lettering.
    /// </summary>
    public BicepValue<DeadLetterWithResourceIdentity> DeadLetterWithResourceIdentity { get => _deadLetterWithResourceIdentity; set => _deadLetterWithResourceIdentity.Assign(value); }
    private readonly BicepValue<DeadLetterWithResourceIdentity> _deadLetterWithResourceIdentity;

    /// <summary>
    /// Information about the destination where events have to be delivered for
    /// the event subscription.             Uses the managed identity setup on
    /// the parent resource (namely, topic or domain) to acquire the
    /// authentication tokens being used during delivery / dead-lettering.
    /// </summary>
    public BicepValue<DeliveryWithResourceIdentity> DeliveryWithResourceIdentity { get => _deliveryWithResourceIdentity; set => _deliveryWithResourceIdentity.Assign(value); }
    private readonly BicepValue<DeliveryWithResourceIdentity> _deliveryWithResourceIdentity;

    /// <summary>
    /// Information about the destination where events have to be delivered for
    /// the event subscription.             Uses Azure Event Grid&apos;s
    /// identity to acquire the authentication tokens being used during
    /// delivery / dead-lettering.             Please note
    /// Azure.ResourceManager.EventGrid.Models.EventSubscriptionDestination is
    /// the base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.EventGrid.Models.AzureFunctionEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.EventHubEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.HybridConnectionEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.MonitorAlertEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.NamespaceTopicEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.PartnerEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.ServiceBusQueueEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.ServiceBusTopicEventSubscriptionDestination,
    /// Azure.ResourceManager.EventGrid.Models.StorageQueueEventSubscriptionDestination
    /// and
    /// Azure.ResourceManager.EventGrid.Models.WebHookEventSubscriptionDestination.
    /// </summary>
    public BicepValue<EventSubscriptionDestination> Destination { get => _destination; set => _destination.Assign(value); }
    private readonly BicepValue<EventSubscriptionDestination> _destination;

    /// <summary>
    /// The event delivery schema for the event subscription.
    /// </summary>
    public BicepValue<EventDeliverySchema> EventDeliverySchema { get => _eventDeliverySchema; set => _eventDeliverySchema.Assign(value); }
    private readonly BicepValue<EventDeliverySchema> _eventDeliverySchema;

    /// <summary>
    /// Expiration time of the event subscription.
    /// </summary>
    public BicepValue<DateTimeOffset> ExpireOn { get => _expireOn; set => _expireOn.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _expireOn;

    /// <summary>
    /// Information about the filter for the event subscription.
    /// </summary>
    public BicepValue<EventSubscriptionFilter> Filter { get => _filter; set => _filter.Assign(value); }
    private readonly BicepValue<EventSubscriptionFilter> _filter;

    /// <summary>
    /// List of user defined labels.
    /// </summary>
    public BicepList<string> Labels { get => _labels; set => _labels.Assign(value); }
    private readonly BicepList<string> _labels;

    /// <summary>
    /// The retry policy for events. This can be used to configure maximum
    /// number of delivery attempts and time to live for events.
    /// </summary>
    public BicepValue<EventSubscriptionRetryPolicy> RetryPolicy { get => _retryPolicy; set => _retryPolicy.Assign(value); }
    private readonly BicepValue<EventSubscriptionRetryPolicy> _retryPolicy;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Provisioning state of the event subscription.
    /// </summary>
    public BicepValue<EventSubscriptionProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<EventSubscriptionProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Name of the topic of the event subscription.
    /// </summary>
    public BicepValue<string> Topic { get => _topic; }
    private readonly BicepValue<string> _topic;

    /// <summary>
    /// Gets or sets a reference to the parent EventGridDomain.
    /// </summary>
    public EventGridDomain? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<EventGridDomain> _parent;

    /// <summary>
    /// Creates a new DomainEventSubscription.
    /// </summary>
    /// <param name="resourceName">Name of the DomainEventSubscription.</param>
    /// <param name="resourceVersion">Version of the DomainEventSubscription.</param>
    public DomainEventSubscription(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.EventGrid/domains/eventSubscriptions", resourceVersion ?? "2022-06-15")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _deadLetterDestination = BicepValue<DeadLetterDestination>.DefineProperty(this, "DeadLetterDestination", ["properties", "deadLetterDestination"]);
        _deadLetterWithResourceIdentity = BicepValue<DeadLetterWithResourceIdentity>.DefineProperty(this, "DeadLetterWithResourceIdentity", ["properties", "deadLetterWithResourceIdentity"]);
        _deliveryWithResourceIdentity = BicepValue<DeliveryWithResourceIdentity>.DefineProperty(this, "DeliveryWithResourceIdentity", ["properties", "deliveryWithResourceIdentity"]);
        _destination = BicepValue<EventSubscriptionDestination>.DefineProperty(this, "Destination", ["properties", "destination"]);
        _eventDeliverySchema = BicepValue<EventDeliverySchema>.DefineProperty(this, "EventDeliverySchema", ["properties", "eventDeliverySchema"]);
        _expireOn = BicepValue<DateTimeOffset>.DefineProperty(this, "ExpireOn", ["properties", "expirationTimeUtc"]);
        _filter = BicepValue<EventSubscriptionFilter>.DefineProperty(this, "Filter", ["properties", "filter"]);
        _labels = BicepList<string>.DefineProperty(this, "Labels", ["properties", "labels"]);
        _retryPolicy = BicepValue<EventSubscriptionRetryPolicy>.DefineProperty(this, "RetryPolicy", ["properties", "retryPolicy"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<EventSubscriptionProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _topic = BicepValue<string>.DefineProperty(this, "Topic", ["properties", "topic"], isOutput: true);
        _parent = ResourceReference<EventGridDomain>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported DomainEventSubscription resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-06-01-preview.
        /// </summary>
        public static readonly string V2024_06_01_preview = "2024-06-01-preview";

        /// <summary>
        /// 2022-06-15.
        /// </summary>
        public static readonly string V2022_06_15 = "2022-06-15";

        /// <summary>
        /// 2021-12-01.
        /// </summary>
        public static readonly string V2021_12_01 = "2021-12-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";
    }

    /// <summary>
    /// Creates a reference to an existing DomainEventSubscription.
    /// </summary>
    /// <param name="resourceName">Name of the DomainEventSubscription.</param>
    /// <param name="resourceVersion">Version of the DomainEventSubscription.</param>
    /// <returns>The existing DomainEventSubscription resource.</returns>
    public static DomainEventSubscription FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
