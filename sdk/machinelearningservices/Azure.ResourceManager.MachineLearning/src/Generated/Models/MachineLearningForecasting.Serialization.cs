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
    public partial class MachineLearningForecasting : IUtf8JsonSerializable, IJsonModel<MachineLearningForecasting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningForecasting>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningForecasting>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningForecasting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningForecasting)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryMetric))
            {
                writer.WritePropertyName("primaryMetric"u8);
                writer.WriteStringValue(PrimaryMetric.Value.ToString());
            }
            if (Optional.IsDefined(ForecastingSettings))
            {
                if (ForecastingSettings != null)
                {
                    writer.WritePropertyName("forecastingSettings"u8);
                    writer.WriteObjectValue(ForecastingSettings, options);
                }
                else
                {
                    writer.WriteNull("forecastingSettings");
                }
            }
            if (Optional.IsDefined(TrainingSettings))
            {
                if (TrainingSettings != null)
                {
                    writer.WritePropertyName("trainingSettings"u8);
                    writer.WriteObjectValue(TrainingSettings, options);
                }
                else
                {
                    writer.WriteNull("trainingSettings");
                }
            }
            if (Optional.IsDefined(LimitSettings))
            {
                if (LimitSettings != null)
                {
                    writer.WritePropertyName("limitSettings"u8);
                    writer.WriteObjectValue(LimitSettings, options);
                }
                else
                {
                    writer.WriteNull("limitSettings");
                }
            }
            if (Optional.IsDefined(NCrossValidations))
            {
                if (NCrossValidations != null)
                {
                    writer.WritePropertyName("nCrossValidations"u8);
                    writer.WriteObjectValue(NCrossValidations, options);
                }
                else
                {
                    writer.WriteNull("nCrossValidations");
                }
            }
            if (Optional.IsCollectionDefined(CvSplitColumnNames))
            {
                if (CvSplitColumnNames != null)
                {
                    writer.WritePropertyName("cvSplitColumnNames"u8);
                    writer.WriteStartArray();
                    foreach (var item in CvSplitColumnNames)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("cvSplitColumnNames");
                }
            }
            if (Optional.IsDefined(WeightColumnName))
            {
                if (WeightColumnName != null)
                {
                    writer.WritePropertyName("weightColumnName"u8);
                    writer.WriteStringValue(WeightColumnName);
                }
                else
                {
                    writer.WriteNull("weightColumnName");
                }
            }
            if (Optional.IsDefined(ValidationData))
            {
                if (ValidationData != null)
                {
                    writer.WritePropertyName("validationData"u8);
                    writer.WriteObjectValue(ValidationData, options);
                }
                else
                {
                    writer.WriteNull("validationData");
                }
            }
            if (Optional.IsDefined(TestData))
            {
                if (TestData != null)
                {
                    writer.WritePropertyName("testData"u8);
                    writer.WriteObjectValue(TestData, options);
                }
                else
                {
                    writer.WriteNull("testData");
                }
            }
            if (Optional.IsDefined(ValidationDataSize))
            {
                if (ValidationDataSize != null)
                {
                    writer.WritePropertyName("validationDataSize"u8);
                    writer.WriteNumberValue(ValidationDataSize.Value);
                }
                else
                {
                    writer.WriteNull("validationDataSize");
                }
            }
            if (Optional.IsDefined(TestDataSize))
            {
                if (TestDataSize != null)
                {
                    writer.WritePropertyName("testDataSize"u8);
                    writer.WriteNumberValue(TestDataSize.Value);
                }
                else
                {
                    writer.WriteNull("testDataSize");
                }
            }
            if (Optional.IsDefined(FeaturizationSettings))
            {
                if (FeaturizationSettings != null)
                {
                    writer.WritePropertyName("featurizationSettings"u8);
                    writer.WriteObjectValue(FeaturizationSettings, options);
                }
                else
                {
                    writer.WriteNull("featurizationSettings");
                }
            }
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
            if (Optional.IsDefined(LogVerbosity))
            {
                writer.WritePropertyName("logVerbosity"u8);
                writer.WriteStringValue(LogVerbosity.Value.ToString());
            }
            writer.WritePropertyName("trainingData"u8);
            writer.WriteObjectValue(TrainingData, options);
            if (Optional.IsDefined(TargetColumnName))
            {
                if (TargetColumnName != null)
                {
                    writer.WritePropertyName("targetColumnName"u8);
                    writer.WriteStringValue(TargetColumnName);
                }
                else
                {
                    writer.WriteNull("targetColumnName");
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

        MachineLearningForecasting IJsonModel<MachineLearningForecasting>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningForecasting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningForecasting)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningForecasting(document.RootElement, options);
        }

        internal static MachineLearningForecasting DeserializeMachineLearningForecasting(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ForecastingPrimaryMetric? primaryMetric = default;
            ForecastingSettings forecastingSettings = default;
            ForecastingTrainingSettings trainingSettings = default;
            TableVerticalLimitSettings limitSettings = default;
            NCrossValidations nCrossValidations = default;
            IList<string> cvSplitColumnNames = default;
            string weightColumnName = default;
            MachineLearningTableJobInput validationData = default;
            MachineLearningTableJobInput testData = default;
            double? validationDataSize = default;
            double? testDataSize = default;
            TableVerticalFeaturizationSettings featurizationSettings = default;
            TaskType taskType = default;
            MachineLearningLogVerbosity? logVerbosity = default;
            MachineLearningTableJobInput trainingData = default;
            string targetColumnName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryMetric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryMetric = new ForecastingPrimaryMetric(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("forecastingSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        forecastingSettings = null;
                        continue;
                    }
                    forecastingSettings = ForecastingSettings.DeserializeForecastingSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("trainingSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainingSettings = null;
                        continue;
                    }
                    trainingSettings = ForecastingTrainingSettings.DeserializeForecastingTrainingSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("limitSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        limitSettings = null;
                        continue;
                    }
                    limitSettings = TableVerticalLimitSettings.DeserializeTableVerticalLimitSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("nCrossValidations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nCrossValidations = null;
                        continue;
                    }
                    nCrossValidations = NCrossValidations.DeserializeNCrossValidations(property.Value, options);
                    continue;
                }
                if (property.NameEquals("cvSplitColumnNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cvSplitColumnNames = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    cvSplitColumnNames = array;
                    continue;
                }
                if (property.NameEquals("weightColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        weightColumnName = null;
                        continue;
                    }
                    weightColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationData = null;
                        continue;
                    }
                    validationData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("testData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        testData = null;
                        continue;
                    }
                    testData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validationDataSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationDataSize = null;
                        continue;
                    }
                    validationDataSize = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("testDataSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        testDataSize = null;
                        continue;
                    }
                    testDataSize = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("featurizationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        featurizationSettings = null;
                        continue;
                    }
                    featurizationSettings = TableVerticalFeaturizationSettings.DeserializeTableVerticalFeaturizationSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logVerbosity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logVerbosity = new MachineLearningLogVerbosity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trainingData"u8))
                {
                    trainingData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetColumnName = null;
                        continue;
                    }
                    targetColumnName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningForecasting(
                taskType,
                logVerbosity,
                trainingData,
                targetColumnName,
                serializedAdditionalRawData,
                primaryMetric,
                forecastingSettings,
                trainingSettings,
                limitSettings,
                nCrossValidations,
                cvSplitColumnNames ?? new ChangeTrackingList<string>(),
                weightColumnName,
                validationData,
                testData,
                validationDataSize,
                testDataSize,
                featurizationSettings);
        }

        BinaryData IPersistableModel<MachineLearningForecasting>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningForecasting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningForecasting)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningForecasting IPersistableModel<MachineLearningForecasting>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningForecasting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningForecasting(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningForecasting)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningForecasting>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
