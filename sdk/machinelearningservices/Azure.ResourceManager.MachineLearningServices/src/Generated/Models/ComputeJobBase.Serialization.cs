// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class ComputeJobBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ExperimentName))
            {
                writer.WritePropertyName("experimentName");
                writer.WriteStringValue(ExperimentName);
            }
            writer.WritePropertyName("computeBinding");
            writer.WriteObjectValue(ComputeBinding);
            if (Optional.IsDefined(Output))
            {
                writer.WritePropertyName("output");
                writer.WriteObjectValue(Output);
            }
            writer.WritePropertyName("jobType");
            writer.WriteStringValue(JobType.ToSerialString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ComputeJobBase DeserializeComputeJobBase(JsonElement element)
        {
            if (element.TryGetProperty("jobType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Command": return CommandJob.DeserializeCommandJob(element);
                    case "Sweep": return SweepJob.DeserializeSweepJob(element);
                }
            }
            Optional<string> experimentName = default;
            ComputeBinding computeBinding = default;
            Optional<JobOutput> output = default;
            JobType jobType = default;
            Optional<JobBaseInteractionEndpoints> interactionEndpoints = default;
            Optional<string> description = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IDictionary<string, string>> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("experimentName"))
                {
                    experimentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("computeBinding"))
                {
                    computeBinding = ComputeBinding.DeserializeComputeBinding(property.Value);
                    continue;
                }
                if (property.NameEquals("output"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    output = JobOutput.DeserializeJobOutput(property.Value);
                    continue;
                }
                if (property.NameEquals("jobType"))
                {
                    jobType = property.Value.GetString().ToJobType();
                    continue;
                }
                if (property.NameEquals("interactionEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    interactionEndpoints = JobBaseInteractionEndpoints.DeserializeJobBaseInteractionEndpoints(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
            }
            return new ComputeJobBase(jobType, interactionEndpoints.Value, description.Value, Optional.ToDictionary(tags), Optional.ToDictionary(properties), experimentName.Value, computeBinding, output.Value);
        }
    }
}
