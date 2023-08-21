// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class ConnectionMonitorData
    {
        internal static ConnectionMonitorData DeserializeConnectionMonitorData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ETag> etag = default;
            Core.Optional<AzureLocation> location = default;
            Core.Optional<IReadOnlyDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<ConnectionMonitorSource> source = default;
            Core.Optional<ConnectionMonitorDestination> destination = default;
            Core.Optional<bool> autoStart = default;
            Core.Optional<int> monitoringIntervalInSeconds = default;
            Core.Optional<IReadOnlyList<ConnectionMonitorEndpoint>> endpoints = default;
            Core.Optional<IReadOnlyList<ConnectionMonitorTestConfiguration>> testConfigurations = default;
            Core.Optional<IReadOnlyList<ConnectionMonitorTestGroup>> testGroups = default;
            Core.Optional<IReadOnlyList<ConnectionMonitorOutput>> outputs = default;
            Core.Optional<string> notes = default;
            Core.Optional<NetworkProvisioningState> provisioningState = default;
            Core.Optional<DateTimeOffset> startTime = default;
            Core.Optional<string> monitoringStatus = default;
            Core.Optional<ConnectionMonitorType> connectionMonitorType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
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
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = ConnectionMonitorSource.DeserializeConnectionMonitorSource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("destination"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            destination = ConnectionMonitorDestination.DeserializeConnectionMonitorDestination(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("autoStart"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoStart = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("monitoringIntervalInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            monitoringIntervalInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("endpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectionMonitorEndpoint> array = new List<ConnectionMonitorEndpoint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectionMonitorEndpoint.DeserializeConnectionMonitorEndpoint(item));
                            }
                            endpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("testConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectionMonitorTestConfiguration> array = new List<ConnectionMonitorTestConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectionMonitorTestConfiguration.DeserializeConnectionMonitorTestConfiguration(item));
                            }
                            testConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("testGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectionMonitorTestGroup> array = new List<ConnectionMonitorTestGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectionMonitorTestGroup.DeserializeConnectionMonitorTestGroup(item));
                            }
                            testGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("outputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectionMonitorOutput> array = new List<ConnectionMonitorOutput>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectionMonitorOutput.DeserializeConnectionMonitorOutput(item));
                            }
                            outputs = array;
                            continue;
                        }
                        if (property0.NameEquals("notes"u8))
                        {
                            notes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("monitoringStatus"u8))
                        {
                            monitoringStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectionMonitorType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionMonitorType = new ConnectionMonitorType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConnectionMonitorData(id, name, type, systemData.Value, Core.Optional.ToNullable(etag), Core.Optional.ToNullable(location), Core.Optional.ToDictionary(tags), source.Value, destination.Value, Core.Optional.ToNullable(autoStart), Core.Optional.ToNullable(monitoringIntervalInSeconds), Core.Optional.ToList(endpoints), Core.Optional.ToList(testConfigurations), Core.Optional.ToList(testGroups), Core.Optional.ToList(outputs), notes.Value, Core.Optional.ToNullable(provisioningState), Core.Optional.ToNullable(startTime), monitoringStatus.Value, Core.Optional.ToNullable(connectionMonitorType));
        }
    }
}
