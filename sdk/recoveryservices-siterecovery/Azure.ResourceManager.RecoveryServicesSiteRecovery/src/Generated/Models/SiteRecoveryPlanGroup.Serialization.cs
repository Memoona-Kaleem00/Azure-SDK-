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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryPlanGroup : IUtf8JsonSerializable, IJsonModel<SiteRecoveryPlanGroup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryPlanGroup>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryPlanGroup>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryPlanGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryPlanGroup)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("groupType"u8);
            writer.WriteStringValue(GroupType.ToString());
            if (Optional.IsCollectionDefined(ReplicationProtectedItems))
            {
                writer.WritePropertyName("replicationProtectedItems"u8);
                writer.WriteStartArray();
                foreach (var item in ReplicationProtectedItems)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(StartGroupActions))
            {
                writer.WritePropertyName("startGroupActions"u8);
                writer.WriteStartArray();
                foreach (var item in StartGroupActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EndGroupActions))
            {
                writer.WritePropertyName("endGroupActions"u8);
                writer.WriteStartArray();
                foreach (var item in EndGroupActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        SiteRecoveryPlanGroup IJsonModel<SiteRecoveryPlanGroup>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryPlanGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryPlanGroup)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryPlanGroup(document.RootElement, options);
        }

        internal static SiteRecoveryPlanGroup DeserializeSiteRecoveryPlanGroup(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RecoveryPlanGroupType groupType = default;
            Optional<IList<RecoveryPlanProtectedItem>> replicationProtectedItems = default;
            Optional<IList<RecoveryPlanAction>> startGroupActions = default;
            Optional<IList<RecoveryPlanAction>> endGroupActions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupType"u8))
                {
                    groupType = new RecoveryPlanGroupType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationProtectedItems"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPlanProtectedItem> array = new List<RecoveryPlanProtectedItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPlanProtectedItem.DeserializeRecoveryPlanProtectedItem(item));
                    }
                    replicationProtectedItems = array;
                    continue;
                }
                if (property.NameEquals("startGroupActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPlanAction> array = new List<RecoveryPlanAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPlanAction.DeserializeRecoveryPlanAction(item));
                    }
                    startGroupActions = array;
                    continue;
                }
                if (property.NameEquals("endGroupActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPlanAction> array = new List<RecoveryPlanAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPlanAction.DeserializeRecoveryPlanAction(item));
                    }
                    endGroupActions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryPlanGroup(groupType, Optional.ToList(replicationProtectedItems), Optional.ToList(startGroupActions), Optional.ToList(endGroupActions), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(GroupType))
            {
                builder.Append("  groupType:");
                builder.AppendLine($" '{GroupType.ToString()}'");
            }

            if (Optional.IsCollectionDefined(ReplicationProtectedItems))
            {
                if (ReplicationProtectedItems.Any())
                {
                    builder.Append("  replicationProtectedItems:");
                    builder.AppendLine(" [");
                    foreach (var item in ReplicationProtectedItems)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(StartGroupActions))
            {
                if (StartGroupActions.Any())
                {
                    builder.Append("  startGroupActions:");
                    builder.AppendLine(" [");
                    foreach (var item in StartGroupActions)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(EndGroupActions))
            {
                if (EndGroupActions.Any())
                {
                    builder.Append("  endGroupActions:");
                    builder.AppendLine(" [");
                    foreach (var item in EndGroupActions)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
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

        BinaryData IPersistableModel<SiteRecoveryPlanGroup>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryPlanGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryPlanGroup)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryPlanGroup IPersistableModel<SiteRecoveryPlanGroup>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryPlanGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryPlanGroup(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryPlanGroup)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryPlanGroup>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
