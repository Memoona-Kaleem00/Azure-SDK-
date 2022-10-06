// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    internal partial class ConnectToSourceOracleSyncTaskInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceConnectionInfo");
            writer.WriteObjectValue(SourceConnectionInfo);
            writer.WriteEndObject();
        }

        internal static ConnectToSourceOracleSyncTaskInput DeserializeConnectToSourceOracleSyncTaskInput(JsonElement element)
        {
            OracleConnectionInfo sourceConnectionInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceConnectionInfo"))
                {
                    sourceConnectionInfo = OracleConnectionInfo.DeserializeOracleConnectionInfo(property.Value);
                    continue;
                }
            }
            return new ConnectToSourceOracleSyncTaskInput(sourceConnectionInfo);
        }
    }
}
