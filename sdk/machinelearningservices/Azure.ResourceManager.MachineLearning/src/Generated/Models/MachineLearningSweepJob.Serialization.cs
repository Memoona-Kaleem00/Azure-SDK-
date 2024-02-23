// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningSweepJob : IUtf8JsonSerializable, IJsonModel<MachineLearningSweepJob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningSweepJob>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningSweepJob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSweepJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSweepJob)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (EarlyTermination != null)
            {
                if (EarlyTermination != null)
                {
                    writer.WritePropertyName("earlyTermination"u8);
                    writer.WriteObjectValue(EarlyTermination);
                }
                else
                {
                    writer.WriteNull("earlyTermination");
                }
            }
            if (!(Inputs is ChangeTrackingDictionary<string, MachineLearningJobInput> collection && collection.IsUndefined))
            {
                if (Inputs != null)
                {
                    writer.WritePropertyName("inputs"u8);
                    writer.WriteStartObject();
                    foreach (var item in Inputs)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("inputs");
                }
            }
            if (Limits != null)
            {
                writer.WritePropertyName("limits"u8);
                writer.WriteObjectValue(Limits);
            }
            writer.WritePropertyName("objective"u8);
            writer.WriteObjectValue(Objective);
            if (!(Outputs is ChangeTrackingDictionary<string, MachineLearningJobOutput> collection0 && collection0.IsUndefined))
            {
                if (Outputs != null)
                {
                    writer.WritePropertyName("outputs"u8);
                    writer.WriteStartObject();
                    foreach (var item in Outputs)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("outputs");
                }
            }
            if (QueueSettings != null)
            {
                if (QueueSettings != null)
                {
                    writer.WritePropertyName("queueSettings"u8);
                    writer.WriteObjectValue(QueueSettings);
                }
                else
                {
                    writer.WriteNull("queueSettings");
                }
            }
            writer.WritePropertyName("samplingAlgorithm"u8);
            writer.WriteObjectValue(SamplingAlgorithm);
            writer.WritePropertyName("searchSpace"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SearchSpace);
#else
            using (JsonDocument document = JsonDocument.Parse(SearchSpace))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            writer.WritePropertyName("trial"u8);
            writer.WriteObjectValue(Trial);
            if (ComponentId != null)
            {
                if (ComponentId != null)
                {
                    writer.WritePropertyName("componentId"u8);
                    writer.WriteStringValue(ComponentId);
                }
                else
                {
                    writer.WriteNull("componentId");
                }
            }
            if (ComputeId != null)
            {
                if (ComputeId != null)
                {
                    writer.WritePropertyName("computeId"u8);
                    writer.WriteStringValue(ComputeId);
                }
                else
                {
                    writer.WriteNull("computeId");
                }
            }
            if (DisplayName != null)
            {
                if (DisplayName != null)
                {
                    writer.WritePropertyName("displayName"u8);
                    writer.WriteStringValue(DisplayName);
                }
                else
                {
                    writer.WriteNull("displayName");
                }
            }
            if (ExperimentName != null)
            {
                writer.WritePropertyName("experimentName"u8);
                writer.WriteStringValue(ExperimentName);
            }
            if (Identity != null)
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
                }
            }
            if (IsArchived.HasValue)
            {
                writer.WritePropertyName("isArchived"u8);
                writer.WriteBooleanValue(IsArchived.Value);
            }
            writer.WritePropertyName("jobType"u8);
            writer.WriteStringValue(JobType.ToString());
            if (NotificationSetting != null)
            {
                if (NotificationSetting != null)
                {
                    writer.WritePropertyName("notificationSetting"u8);
                    writer.WriteObjectValue(NotificationSetting);
                }
                else
                {
                    writer.WriteNull("notificationSetting");
                }
            }
            if (!(SecretsConfiguration is ChangeTrackingDictionary<string, SecretConfiguration> collection1 && collection1.IsUndefined))
            {
                if (SecretsConfiguration != null)
                {
                    writer.WritePropertyName("secretsConfiguration"u8);
                    writer.WriteStartObject();
                    foreach (var item in SecretsConfiguration)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("secretsConfiguration");
                }
            }
            if (!(Services is ChangeTrackingDictionary<string, MachineLearningJobService> collection2 && collection2.IsUndefined))
            {
                if (Services != null)
                {
                    writer.WritePropertyName("services"u8);
                    writer.WriteStartObject();
                    foreach (var item in Services)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("services");
                }
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Description != null)
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (!(Properties is ChangeTrackingDictionary<string, string> collection3 && collection3.IsUndefined))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection4 && collection4.IsUndefined))
            {
                if (Tags != null)
                {
                    writer.WritePropertyName("tags"u8);
                    writer.WriteStartObject();
                    foreach (var item in Tags)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("tags");
                }
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MachineLearningSweepJob IJsonModel<MachineLearningSweepJob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSweepJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSweepJob)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningSweepJob(document.RootElement, options);
        }

        internal static MachineLearningSweepJob DeserializeMachineLearningSweepJob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningEarlyTerminationPolicy> earlyTermination = default;
            IDictionary<string, MachineLearningJobInput> inputs = default;
            Optional<MachineLearningSweepJobLimits> limits = default;
            MachineLearningObjective objective = default;
            IDictionary<string, MachineLearningJobOutput> outputs = default;
            Optional<JobQueueSettings> queueSettings = default;
            SamplingAlgorithm samplingAlgorithm = default;
            BinaryData searchSpace = default;
            MachineLearningTrialComponent trial = default;
            Optional<ResourceIdentifier> componentId = default;
            Optional<ResourceIdentifier> computeId = default;
            Optional<string> displayName = default;
            Optional<string> experimentName = default;
            Optional<MachineLearningIdentityConfiguration> identity = default;
            Optional<bool> isArchived = default;
            JobType jobType = default;
            Optional<NotificationSetting> notificationSetting = default;
            IDictionary<string, SecretConfiguration> secretsConfiguration = default;
            IDictionary<string, MachineLearningJobService> services = default;
            Optional<MachineLearningJobStatus> status = default;
            Optional<string> description = default;
            IDictionary<string, string> properties = default;
            IDictionary<string, string> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("earlyTermination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyTermination = null;
                        continue;
                    }
                    earlyTermination = MachineLearningEarlyTerminationPolicy.DeserializeMachineLearningEarlyTerminationPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        inputs = null;
                        continue;
                    }
                    Dictionary<string, MachineLearningJobInput> dictionary = new Dictionary<string, MachineLearningJobInput>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningJobInput.DeserializeMachineLearningJobInput(property0.Value, options));
                    }
                    inputs = dictionary;
                    continue;
                }
                if (property.NameEquals("limits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limits = MachineLearningSweepJobLimits.DeserializeMachineLearningSweepJobLimits(property.Value, options);
                    continue;
                }
                if (property.NameEquals("objective"u8))
                {
                    objective = MachineLearningObjective.DeserializeMachineLearningObjective(property.Value, options);
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        outputs = null;
                        continue;
                    }
                    Dictionary<string, MachineLearningJobOutput> dictionary = new Dictionary<string, MachineLearningJobOutput>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningJobOutput.DeserializeMachineLearningJobOutput(property0.Value, options));
                    }
                    outputs = dictionary;
                    continue;
                }
                if (property.NameEquals("queueSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        queueSettings = null;
                        continue;
                    }
                    queueSettings = JobQueueSettings.DeserializeJobQueueSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("samplingAlgorithm"u8))
                {
                    samplingAlgorithm = SamplingAlgorithm.DeserializeSamplingAlgorithm(property.Value, options);
                    continue;
                }
                if (property.NameEquals("searchSpace"u8))
                {
                    searchSpace = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("trial"u8))
                {
                    trial = MachineLearningTrialComponent.DeserializeMachineLearningTrialComponent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("componentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        componentId = null;
                        continue;
                    }
                    componentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("computeId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        computeId = null;
                        continue;
                    }
                    computeId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        displayName = null;
                        continue;
                    }
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("experimentName"u8))
                {
                    experimentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = MachineLearningIdentityConfiguration.DeserializeMachineLearningIdentityConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("isArchived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchived = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("jobType"u8))
                {
                    jobType = new JobType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("notificationSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        notificationSetting = null;
                        continue;
                    }
                    notificationSetting = NotificationSetting.DeserializeNotificationSetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("secretsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        secretsConfiguration = null;
                        continue;
                    }
                    Dictionary<string, SecretConfiguration> dictionary = new Dictionary<string, SecretConfiguration>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, SecretConfiguration.DeserializeSecretConfiguration(property0.Value, options));
                    }
                    secretsConfiguration = dictionary;
                    continue;
                }
                if (property.NameEquals("services"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        services = null;
                        continue;
                    }
                    Dictionary<string, MachineLearningJobService> dictionary = new Dictionary<string, MachineLearningJobService>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningJobService.DeserializeMachineLearningJobService(property0.Value, options));
                    }
                    services = dictionary;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MachineLearningJobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningSweepJob(description.Value, properties ?? new ChangeTrackingDictionary<string, string>(), tags ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData, componentId.Value, computeId.Value, displayName.Value, experimentName.Value, identity.Value, Optional.ToNullable(isArchived), jobType, notificationSetting.Value, secretsConfiguration ?? new ChangeTrackingDictionary<string, SecretConfiguration>(), services ?? new ChangeTrackingDictionary<string, MachineLearningJobService>(), Optional.ToNullable(status), earlyTermination.Value, inputs ?? new ChangeTrackingDictionary<string, MachineLearningJobInput>(), limits.Value, objective, outputs ?? new ChangeTrackingDictionary<string, MachineLearningJobOutput>(), queueSettings.Value, samplingAlgorithm, searchSpace, trial);
        }

        BinaryData IPersistableModel<MachineLearningSweepJob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSweepJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSweepJob)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningSweepJob IPersistableModel<MachineLearningSweepJob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSweepJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningSweepJob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSweepJob)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningSweepJob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
