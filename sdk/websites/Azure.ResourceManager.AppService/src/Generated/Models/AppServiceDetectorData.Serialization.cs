// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServiceDetectorData : IUtf8JsonSerializable, IModelJsonSerializable<AppServiceDetectorData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppServiceDetectorData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppServiceDetectorData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceDetectorData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                if (Metadata is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DetectorInfo>)Metadata).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Dataset))
            {
                writer.WritePropertyName("dataset"u8);
                writer.WriteStartArray();
                foreach (var item in Dataset)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DiagnosticDataset>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                if (Status is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AppServiceStatusInfo>)Status).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(DataProvidersMetadata))
            {
                writer.WritePropertyName("dataProvidersMetadata"u8);
                writer.WriteStartArray();
                foreach (var item in DataProvidersMetadata)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DataProviderMetadata>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SuggestedUtterances))
            {
                writer.WritePropertyName("suggestedUtterances"u8);
                if (SuggestedUtterances is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<QueryUtterancesResults>)SuggestedUtterances).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static AppServiceDetectorData DeserializeAppServiceDetectorData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DetectorInfo> metadata = default;
            Optional<IList<DiagnosticDataset>> dataset = default;
            Optional<AppServiceStatusInfo> status = default;
            Optional<IList<DataProviderMetadata>> dataProvidersMetadata = default;
            Optional<QueryUtterancesResults> suggestedUtterances = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metadata = DetectorInfo.DeserializeDetectorInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dataset"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DiagnosticDataset> array = new List<DiagnosticDataset>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DiagnosticDataset.DeserializeDiagnosticDataset(item));
                            }
                            dataset = array;
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = AppServiceStatusInfo.DeserializeAppServiceStatusInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dataProvidersMetadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataProviderMetadata> array = new List<DataProviderMetadata>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataProviderMetadata.DeserializeDataProviderMetadata(item));
                            }
                            dataProvidersMetadata = array;
                            continue;
                        }
                        if (property0.NameEquals("suggestedUtterances"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            suggestedUtterances = QueryUtterancesResults.DeserializeQueryUtterancesResults(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppServiceDetectorData(id, name, type, systemData.Value, metadata.Value, Optional.ToList(dataset), status.Value, Optional.ToList(dataProvidersMetadata), suggestedUtterances.Value, kind.Value, rawData);
        }

        AppServiceDetectorData IModelJsonSerializable<AppServiceDetectorData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceDetectorData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceDetectorData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppServiceDetectorData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceDetectorData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppServiceDetectorData IModelSerializable<AppServiceDetectorData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceDetectorData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppServiceDetectorData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppServiceDetectorData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppServiceDetectorData"/> to convert. </param>
        public static implicit operator RequestContent(AppServiceDetectorData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppServiceDetectorData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppServiceDetectorData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppServiceDetectorData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
