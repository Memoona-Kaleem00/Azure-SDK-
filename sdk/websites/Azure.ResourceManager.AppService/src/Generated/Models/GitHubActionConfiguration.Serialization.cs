// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class GitHubActionConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CodeConfiguration))
            {
                writer.WritePropertyName("codeConfiguration");
                writer.WriteObjectValue(CodeConfiguration);
            }
            if (Optional.IsDefined(ContainerConfiguration))
            {
                writer.WritePropertyName("containerConfiguration");
                writer.WriteObjectValue(ContainerConfiguration);
            }
            if (Optional.IsDefined(IsLinux))
            {
                writer.WritePropertyName("isLinux");
                writer.WriteBooleanValue(IsLinux.Value);
            }
            if (Optional.IsDefined(IsGenerateWorkflowFile))
            {
                writer.WritePropertyName("generateWorkflowFile");
                writer.WriteBooleanValue(IsGenerateWorkflowFile.Value);
            }
            writer.WriteEndObject();
        }

        internal static GitHubActionConfiguration DeserializeGitHubActionConfiguration(JsonElement element)
        {
            Optional<GitHubActionCodeConfiguration> codeConfiguration = default;
            Optional<GitHubActionContainerConfiguration> containerConfiguration = default;
            Optional<bool> isLinux = default;
            Optional<bool> generateWorkflowFile = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("codeConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    codeConfiguration = GitHubActionCodeConfiguration.DeserializeGitHubActionCodeConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("containerConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    containerConfiguration = GitHubActionContainerConfiguration.DeserializeGitHubActionContainerConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("isLinux"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isLinux = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("generateWorkflowFile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    generateWorkflowFile = property.Value.GetBoolean();
                    continue;
                }
            }
            return new GitHubActionConfiguration(codeConfiguration.Value, containerConfiguration.Value, Optional.ToNullable(isLinux), Optional.ToNullable(generateWorkflowFile));
        }
    }
}
