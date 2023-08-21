// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class MongoDBDataFeed : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dataSourceParameter"u8);
            writer.WriteObjectValue(DataSourceParameter);
            writer.WritePropertyName("dataSourceType"u8);
            writer.WriteStringValue(DataSourceType.ToString());
            writer.WritePropertyName("dataFeedName"u8);
            writer.WriteStringValue(DataFeedName);
            if (Core.Optional.IsDefined(DataFeedDescription))
            {
                writer.WritePropertyName("dataFeedDescription"u8);
                writer.WriteStringValue(DataFeedDescription);
            }
            writer.WritePropertyName("granularityName"u8);
            writer.WriteStringValue(GranularityName.ToString());
            if (Core.Optional.IsDefined(GranularityAmount))
            {
                if (GranularityAmount != null)
                {
                    writer.WritePropertyName("granularityAmount"u8);
                    writer.WriteNumberValue(GranularityAmount.Value);
                }
                else
                {
                    writer.WriteNull("granularityAmount");
                }
            }
            writer.WritePropertyName("metrics"u8);
            writer.WriteStartArray();
            foreach (var item in Metrics)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Core.Optional.IsCollectionDefined(Dimension))
            {
                writer.WritePropertyName("dimension"u8);
                writer.WriteStartArray();
                foreach (var item in Dimension)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(TimestampColumn))
            {
                writer.WritePropertyName("timestampColumn"u8);
                writer.WriteStringValue(TimestampColumn);
            }
            writer.WritePropertyName("dataStartFrom"u8);
            writer.WriteStringValue(DataStartFrom, "O");
            if (Core.Optional.IsDefined(StartOffsetInSeconds))
            {
                writer.WritePropertyName("startOffsetInSeconds"u8);
                writer.WriteNumberValue(StartOffsetInSeconds.Value);
            }
            if (Core.Optional.IsDefined(MaxConcurrency))
            {
                writer.WritePropertyName("maxConcurrency"u8);
                writer.WriteNumberValue(MaxConcurrency.Value);
            }
            if (Core.Optional.IsDefined(MinRetryIntervalInSeconds))
            {
                writer.WritePropertyName("minRetryIntervalInSeconds"u8);
                writer.WriteNumberValue(MinRetryIntervalInSeconds.Value);
            }
            if (Core.Optional.IsDefined(StopRetryAfterInSeconds))
            {
                writer.WritePropertyName("stopRetryAfterInSeconds"u8);
                writer.WriteNumberValue(StopRetryAfterInSeconds.Value);
            }
            if (Core.Optional.IsDefined(NeedRollup))
            {
                writer.WritePropertyName("needRollup"u8);
                writer.WriteStringValue(NeedRollup.Value.ToString());
            }
            if (Core.Optional.IsDefined(RollUpMethod))
            {
                writer.WritePropertyName("rollUpMethod"u8);
                writer.WriteStringValue(RollUpMethod.Value.ToString());
            }
            if (Core.Optional.IsCollectionDefined(RollUpColumns))
            {
                writer.WritePropertyName("rollUpColumns"u8);
                writer.WriteStartArray();
                foreach (var item in RollUpColumns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(AllUpIdentification))
            {
                writer.WritePropertyName("allUpIdentification"u8);
                writer.WriteStringValue(AllUpIdentification);
            }
            if (Core.Optional.IsDefined(FillMissingPointType))
            {
                writer.WritePropertyName("fillMissingPointType"u8);
                writer.WriteStringValue(FillMissingPointType.Value.ToString());
            }
            if (Core.Optional.IsDefined(FillMissingPointValue))
            {
                writer.WritePropertyName("fillMissingPointValue"u8);
                writer.WriteNumberValue(FillMissingPointValue.Value);
            }
            if (Core.Optional.IsDefined(ViewMode))
            {
                writer.WritePropertyName("viewMode"u8);
                writer.WriteStringValue(ViewMode.Value.ToString());
            }
            if (Core.Optional.IsCollectionDefined(Admins))
            {
                writer.WritePropertyName("admins"u8);
                writer.WriteStartArray();
                foreach (var item in Admins)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(Viewers))
            {
                writer.WritePropertyName("viewers"u8);
                writer.WriteStartArray();
                foreach (var item in Viewers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(ActionLinkTemplate))
            {
                writer.WritePropertyName("actionLinkTemplate"u8);
                writer.WriteStringValue(ActionLinkTemplate);
            }
            if (Core.Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Core.Optional.IsDefined(CredentialId))
            {
                writer.WritePropertyName("credentialId"u8);
                writer.WriteStringValue(CredentialId);
            }
            writer.WriteEndObject();
        }

        internal static MongoDBDataFeed DeserializeMongoDBDataFeed(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MongoDBParameter dataSourceParameter = default;
            DataFeedSourceKind dataSourceType = default;
            Core.Optional<string> dataFeedId = default;
            string dataFeedName = default;
            Core.Optional<string> dataFeedDescription = default;
            DataFeedGranularityType granularityName = default;
            Core.Optional<int?> granularityAmount = default;
            IList<DataFeedMetric> metrics = default;
            Core.Optional<IList<DataFeedDimension>> dimension = default;
            Core.Optional<string> timestampColumn = default;
            DateTimeOffset dataStartFrom = default;
            Core.Optional<long> startOffsetInSeconds = default;
            Core.Optional<int> maxConcurrency = default;
            Core.Optional<long> minRetryIntervalInSeconds = default;
            Core.Optional<long> stopRetryAfterInSeconds = default;
            Core.Optional<DataFeedRollupType> needRollup = default;
            Core.Optional<DataFeedAutoRollupMethod> rollUpMethod = default;
            Core.Optional<IList<string>> rollUpColumns = default;
            Core.Optional<string> allUpIdentification = default;
            Core.Optional<DataFeedMissingDataPointFillType> fillMissingPointType = default;
            Core.Optional<double> fillMissingPointValue = default;
            Core.Optional<DataFeedAccessMode> viewMode = default;
            Core.Optional<IList<string>> admins = default;
            Core.Optional<IList<string>> viewers = default;
            Core.Optional<bool> isAdmin = default;
            Core.Optional<string> creator = default;
            Core.Optional<DataFeedStatus> status = default;
            Core.Optional<DateTimeOffset> createdTime = default;
            Core.Optional<string> actionLinkTemplate = default;
            Core.Optional<AuthenticationTypeEnum> authenticationType = default;
            Core.Optional<string> credentialId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSourceParameter"u8))
                {
                    dataSourceParameter = MongoDBParameter.DeserializeMongoDBParameter(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourceType"u8))
                {
                    dataSourceType = new DataFeedSourceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataFeedId"u8))
                {
                    dataFeedId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFeedName"u8))
                {
                    dataFeedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFeedDescription"u8))
                {
                    dataFeedDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("granularityName"u8))
                {
                    granularityName = new DataFeedGranularityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("granularityAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        granularityAmount = null;
                        continue;
                    }
                    granularityAmount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("metrics"u8))
                {
                    List<DataFeedMetric> array = new List<DataFeedMetric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFeedMetric.DeserializeDataFeedMetric(item));
                    }
                    metrics = array;
                    continue;
                }
                if (property.NameEquals("dimension"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFeedDimension> array = new List<DataFeedDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFeedDimension.DeserializeDataFeedDimension(item));
                    }
                    dimension = array;
                    continue;
                }
                if (property.NameEquals("timestampColumn"u8))
                {
                    timestampColumn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataStartFrom"u8))
                {
                    dataStartFrom = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startOffsetInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startOffsetInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxConcurrency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minRetryIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minRetryIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("stopRetryAfterInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stopRetryAfterInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("needRollup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    needRollup = new DataFeedRollupType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rollUpMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rollUpMethod = new DataFeedAutoRollupMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rollUpColumns"u8))
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
                    rollUpColumns = array;
                    continue;
                }
                if (property.NameEquals("allUpIdentification"u8))
                {
                    allUpIdentification = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fillMissingPointType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fillMissingPointType = new DataFeedMissingDataPointFillType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fillMissingPointValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fillMissingPointValue = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("viewMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    viewMode = new DataFeedAccessMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("admins"u8))
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
                    admins = array;
                    continue;
                }
                if (property.NameEquals("viewers"u8))
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
                    viewers = array;
                    continue;
                }
                if (property.NameEquals("isAdmin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAdmin = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("creator"u8))
                {
                    creator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DataFeedStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("actionLinkTemplate"u8))
                {
                    actionLinkTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new AuthenticationTypeEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentialId"u8))
                {
                    credentialId = property.Value.GetString();
                    continue;
                }
            }
            return new MongoDBDataFeed(dataSourceType, dataFeedId.Value, dataFeedName, dataFeedDescription.Value, granularityName, Core.Optional.ToNullable(granularityAmount), metrics, Core.Optional.ToList(dimension), timestampColumn.Value, dataStartFrom, Core.Optional.ToNullable(startOffsetInSeconds), Core.Optional.ToNullable(maxConcurrency), Core.Optional.ToNullable(minRetryIntervalInSeconds), Core.Optional.ToNullable(stopRetryAfterInSeconds), Core.Optional.ToNullable(needRollup), Core.Optional.ToNullable(rollUpMethod), Core.Optional.ToList(rollUpColumns), allUpIdentification.Value, Core.Optional.ToNullable(fillMissingPointType), Core.Optional.ToNullable(fillMissingPointValue), Core.Optional.ToNullable(viewMode), Core.Optional.ToList(admins), Core.Optional.ToList(viewers), Core.Optional.ToNullable(isAdmin), creator.Value, Core.Optional.ToNullable(status), Core.Optional.ToNullable(createdTime), actionLinkTemplate.Value, Core.Optional.ToNullable(authenticationType), credentialId.Value, dataSourceParameter);
        }
    }
}
