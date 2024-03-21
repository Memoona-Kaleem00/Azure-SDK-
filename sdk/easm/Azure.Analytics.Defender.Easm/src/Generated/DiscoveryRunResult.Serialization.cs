// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class DiscoveryRunResult : IUtf8JsonSerializable, IJsonModel<DiscoveryRunResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiscoveryRunResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DiscoveryRunResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryRunResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiscoveryRunResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SubmittedDate))
            {
                writer.WritePropertyName("submittedDate"u8);
                writer.WriteStringValue(SubmittedDate.Value, "O");
            }
            if (Optional.IsDefined(StartedDate))
            {
                writer.WritePropertyName("startedDate"u8);
                writer.WriteStringValue(StartedDate.Value, "O");
            }
            if (Optional.IsDefined(CompletedDate))
            {
                writer.WritePropertyName("completedDate"u8);
                writer.WriteStringValue(CompletedDate.Value, "O");
            }
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(TotalAssetsFoundCount))
            {
                writer.WritePropertyName("totalAssetsFoundCount"u8);
                writer.WriteNumberValue(TotalAssetsFoundCount.Value);
            }
            if (Optional.IsCollectionDefined(Seeds))
            {
                writer.WritePropertyName("seeds"u8);
                writer.WriteStartArray();
                foreach (var item in Seeds)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Excludes))
            {
                writer.WritePropertyName("excludes"u8);
                writer.WriteStartArray();
                foreach (var item in Excludes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Names))
            {
                writer.WritePropertyName("names"u8);
                writer.WriteStartArray();
                foreach (var item in Names)
                {
                    writer.WriteStringValue(item);
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

        DiscoveryRunResult IJsonModel<DiscoveryRunResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryRunResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiscoveryRunResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiscoveryRunResult(document.RootElement, options);
        }

        internal static DiscoveryRunResult DeserializeDiscoveryRunResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? submittedDate = default;
            DateTimeOffset? startedDate = default;
            DateTimeOffset? completedDate = default;
            string tier = default;
            DiscoRunState? state = default;
            long? totalAssetsFoundCount = default;
            IReadOnlyList<DiscoverySource> seeds = default;
            IReadOnlyList<DiscoverySource> excludes = default;
            IReadOnlyList<string> names = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("submittedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    submittedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("completedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    completedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new DiscoRunState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalAssetsFoundCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalAssetsFoundCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("seeds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiscoverySource> array = new List<DiscoverySource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiscoverySource.DeserializeDiscoverySource(item, options));
                    }
                    seeds = array;
                    continue;
                }
                if (property.NameEquals("excludes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiscoverySource> array = new List<DiscoverySource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiscoverySource.DeserializeDiscoverySource(item, options));
                    }
                    excludes = array;
                    continue;
                }
                if (property.NameEquals("names"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    names = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DiscoveryRunResult(
                submittedDate,
                startedDate,
                completedDate,
                tier,
                state,
                totalAssetsFoundCount,
                seeds ?? new ChangeTrackingList<DiscoverySource>(),
                excludes ?? new ChangeTrackingList<DiscoverySource>(),
                names ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiscoveryRunResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryRunResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiscoveryRunResult)} does not support '{options.Format}' format.");
            }
        }

        DiscoveryRunResult IPersistableModel<DiscoveryRunResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryRunResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiscoveryRunResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiscoveryRunResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiscoveryRunResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DiscoveryRunResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDiscoveryRunResult(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
