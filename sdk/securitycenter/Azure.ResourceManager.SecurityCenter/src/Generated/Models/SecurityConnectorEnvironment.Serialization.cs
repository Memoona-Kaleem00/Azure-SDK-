// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    [PersistableModelProxy(typeof(UnknownEnvironmentData))]
    public partial class SecurityConnectorEnvironment : IUtf8JsonSerializable, IJsonModel<SecurityConnectorEnvironment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityConnectorEnvironment>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityConnectorEnvironment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorEnvironment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityConnectorEnvironment)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("environmentType"u8);
            writer.WriteStringValue(EnvironmentType.ToString());
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

        SecurityConnectorEnvironment IJsonModel<SecurityConnectorEnvironment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorEnvironment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityConnectorEnvironment)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityConnectorEnvironment(document.RootElement, options);
        }

        internal static SecurityConnectorEnvironment DeserializeSecurityConnectorEnvironment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("environmentType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AwsAccount": return AwsEnvironment.DeserializeAwsEnvironment(element);
                    case "AzureDevOpsScope": return AzureDevOpsScopeEnvironment.DeserializeAzureDevOpsScopeEnvironment(element);
                    case "GcpProject": return GcpProjectEnvironment.DeserializeGcpProjectEnvironment(element);
                    case "GithubScope": return GithubScopeEnvironment.DeserializeGithubScopeEnvironment(element);
                    case "GitlabScope": return GitlabScopeEnvironment.DeserializeGitlabScopeEnvironment(element);
                }
            }
            return UnknownEnvironmentData.DeserializeUnknownEnvironmentData(element);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(EnvironmentType))
            {
                builder.Append("  environmentType:");
                builder.AppendLine($" '{EnvironmentType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            bool inMultilineString = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<SecurityConnectorEnvironment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorEnvironment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityConnectorEnvironment)} does not support '{options.Format}' format.");
            }
        }

        SecurityConnectorEnvironment IPersistableModel<SecurityConnectorEnvironment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorEnvironment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityConnectorEnvironment(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SecurityConnectorEnvironment)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityConnectorEnvironment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
