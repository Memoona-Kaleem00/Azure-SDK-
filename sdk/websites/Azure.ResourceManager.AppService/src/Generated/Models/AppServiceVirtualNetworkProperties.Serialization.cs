// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceVirtualNetworkProperties : IUtf8JsonSerializable, IJsonModel<AppServiceVirtualNetworkProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceVirtualNetworkProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceVirtualNetworkProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceVirtualNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceVirtualNetworkProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VnetResourceId))
            {
                writer.WritePropertyName("vnetResourceId"u8);
                writer.WriteStringValue(VnetResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(CertThumbprintString))
            {
                writer.WritePropertyName("certThumbprint"u8);
                writer.WriteStringValue(CertThumbprintString);
            }
            if (Optional.IsDefined(CertBlob))
            {
                writer.WritePropertyName("certBlob"u8);
                writer.WriteStringValue(CertBlob);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Routes))
            {
                writer.WritePropertyName("routes"u8);
                writer.WriteStartArray();
                foreach (var item in Routes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(IsResyncRequired))
            {
                writer.WritePropertyName("resyncRequired"u8);
                writer.WriteBooleanValue(IsResyncRequired.Value);
            }
            if (Optional.IsDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStringValue(DnsServers);
            }
            if (Optional.IsDefined(IsSwift))
            {
                writer.WritePropertyName("isSwift"u8);
                writer.WriteBooleanValue(IsSwift.Value);
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

        AppServiceVirtualNetworkProperties IJsonModel<AppServiceVirtualNetworkProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceVirtualNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceVirtualNetworkProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceVirtualNetworkProperties(document.RootElement, options);
        }

        internal static AppServiceVirtualNetworkProperties DeserializeAppServiceVirtualNetworkProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> vnetResourceId = default;
            Optional<string> certThumbprint = default;
            Optional<string> certBlob = default;
            Optional<IReadOnlyList<AppServiceVirtualNetworkRoute>> routes = default;
            Optional<bool> resyncRequired = default;
            Optional<string> dnsServers = default;
            Optional<bool> isSwift = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vnetResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("certThumbprint"u8))
                {
                    certThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certBlob"u8))
                {
                    certBlob = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppServiceVirtualNetworkRoute> array = new List<AppServiceVirtualNetworkRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppServiceVirtualNetworkRoute.DeserializeAppServiceVirtualNetworkRoute(item));
                    }
                    routes = array;
                    continue;
                }
                if (property.NameEquals("resyncRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dnsServers"u8))
                {
                    dnsServers = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isSwift"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSwift = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceVirtualNetworkProperties(vnetResourceId.Value, certThumbprint.Value, certBlob.Value, Optional.ToList(routes), Optional.ToNullable(resyncRequired), dnsServers.Value, Optional.ToNullable(isSwift), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.ParameterOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VnetResourceId), out propertyOverride);
            if (Optional.IsDefined(VnetResourceId) || hasPropertyOverride)
            {
                builder.Append("  vnetResourceId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{VnetResourceId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CertThumbprintString), out propertyOverride);
            if (Optional.IsDefined(CertThumbprintString) || hasPropertyOverride)
            {
                builder.Append("  certThumbprint: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (CertThumbprintString.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CertThumbprintString}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CertThumbprintString}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CertBlob), out propertyOverride);
            if (Optional.IsDefined(CertBlob) || hasPropertyOverride)
            {
                builder.Append("  certBlob: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (CertBlob.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CertBlob}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CertBlob}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Routes), out propertyOverride);
            if (Optional.IsCollectionDefined(Routes) || hasPropertyOverride)
            {
                if (Routes.Any() || hasPropertyOverride)
                {
                    builder.Append("  routes: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in Routes)
                        {
                            AppendChildObject(builder, item, options, 4, true, "  routes: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsResyncRequired), out propertyOverride);
            if (Optional.IsDefined(IsResyncRequired) || hasPropertyOverride)
            {
                builder.Append("  resyncRequired: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var boolValue = IsResyncRequired.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DnsServers), out propertyOverride);
            if (Optional.IsDefined(DnsServers) || hasPropertyOverride)
            {
                builder.Append("  dnsServers: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (DnsServers.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DnsServers}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DnsServers}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsSwift), out propertyOverride);
            if (Optional.IsDefined(IsSwift) || hasPropertyOverride)
            {
                builder.Append("  isSwift: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var boolValue = IsSwift.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine, string formattedPropertyName)
        {
            string indent = new string(' ', spaces);
            int emptyObjectLength = 2 + spaces + Environment.NewLine.Length + Environment.NewLine.Length;
            int length = stringBuilder.Length;
            bool inMultilineString = false;

            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
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
                    stringBuilder.AppendLine($"{line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
            if (stringBuilder.Length == length + emptyObjectLength)
            {
                stringBuilder.Length = stringBuilder.Length - emptyObjectLength - formattedPropertyName.Length;
            }
        }

        BinaryData IPersistableModel<AppServiceVirtualNetworkProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceVirtualNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceVirtualNetworkProperties)} does not support '{options.Format}' format.");
            }
        }

        AppServiceVirtualNetworkProperties IPersistableModel<AppServiceVirtualNetworkProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceVirtualNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceVirtualNetworkProperties(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AppServiceVirtualNetworkProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceVirtualNetworkProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
