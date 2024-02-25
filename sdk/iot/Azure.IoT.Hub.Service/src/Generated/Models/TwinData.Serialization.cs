// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class TwinData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (DeviceId != null)
            {
                writer.WritePropertyName("deviceId"u8);
                writer.WriteStringValue(DeviceId);
            }
            if (ModuleId != null)
            {
                writer.WritePropertyName("moduleId"u8);
                writer.WriteStringValue(ModuleId);
            }
            if (!(Tags is ChangeTrackingDictionary<string, object> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Properties != null)
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(Etag);
            }
            if (Version.HasValue)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteNumberValue(Version.Value);
            }
            if (DeviceEtag != null)
            {
                writer.WritePropertyName("deviceEtag"u8);
                writer.WriteStringValue(DeviceEtag);
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (StatusReason != null)
            {
                writer.WritePropertyName("statusReason"u8);
                writer.WriteStringValue(StatusReason);
            }
            if (StatusUpdateTime.HasValue)
            {
                writer.WritePropertyName("statusUpdateTime"u8);
                writer.WriteStringValue(StatusUpdateTime.Value, "O");
            }
            if (ConnectionState.HasValue)
            {
                writer.WritePropertyName("connectionState"u8);
                writer.WriteStringValue(ConnectionState.Value.ToString());
            }
            if (LastActivityTime.HasValue)
            {
                writer.WritePropertyName("lastActivityTime"u8);
                writer.WriteStringValue(LastActivityTime.Value, "O");
            }
            if (CloudToDeviceMessageCount.HasValue)
            {
                writer.WritePropertyName("cloudToDeviceMessageCount"u8);
                writer.WriteNumberValue(CloudToDeviceMessageCount.Value);
            }
            if (AuthenticationType.HasValue)
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (X509Thumbprint != null)
            {
                writer.WritePropertyName("x509Thumbprint"u8);
                writer.WriteObjectValue(X509Thumbprint);
            }
            if (Capabilities != null)
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteObjectValue(Capabilities);
            }
            if (DeviceScope != null)
            {
                writer.WritePropertyName("deviceScope"u8);
                writer.WriteStringValue(DeviceScope);
            }
            writer.WriteEndObject();
        }

        internal static TwinData DeserializeTwinData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deviceId = default;
            Optional<string> moduleId = default;
            IDictionary<string, object> tags = default;
            Optional<TwinProperties> properties = default;
            Optional<string> etag = default;
            Optional<long> version = default;
            Optional<string> deviceEtag = default;
            Optional<TwinStatus> status = default;
            Optional<string> statusReason = default;
            Optional<DateTimeOffset> statusUpdateTime = default;
            Optional<TwinConnectionState> connectionState = default;
            Optional<DateTimeOffset> lastActivityTime = default;
            Optional<int> cloudToDeviceMessageCount = default;
            Optional<TwinAuthenticationType> authenticationType = default;
            Optional<X509Thumbprint> x509Thumbprint = default;
            Optional<DeviceCapabilities> capabilities = default;
            Optional<string> deviceScope = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("moduleId"u8))
                {
                    moduleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = TwinProperties.DeserializeTwinProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("deviceEtag"u8))
                {
                    deviceEtag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new TwinStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusReason"u8))
                {
                    statusReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("connectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionState = new TwinConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastActivityTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastActivityTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cloudToDeviceMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudToDeviceMessageCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new TwinAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("x509Thumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    x509Thumbprint = X509Thumbprint.DeserializeX509Thumbprint(property.Value);
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capabilities = DeviceCapabilities.DeserializeDeviceCapabilities(property.Value);
                    continue;
                }
                if (property.NameEquals("deviceScope"u8))
                {
                    deviceScope = property.Value.GetString();
                    continue;
                }
            }
            return new TwinData(deviceId.Value, moduleId.Value, tags ?? new ChangeTrackingDictionary<string, object>(), properties.Value, etag.Value, Optional.ToNullable(version), deviceEtag.Value, Optional.ToNullable(status), statusReason.Value, Optional.ToNullable(statusUpdateTime), Optional.ToNullable(connectionState), Optional.ToNullable(lastActivityTime), Optional.ToNullable(cloudToDeviceMessageCount), Optional.ToNullable(authenticationType), x509Thumbprint.Value, capabilities.Value, deviceScope.Value);
        }
    }
}
