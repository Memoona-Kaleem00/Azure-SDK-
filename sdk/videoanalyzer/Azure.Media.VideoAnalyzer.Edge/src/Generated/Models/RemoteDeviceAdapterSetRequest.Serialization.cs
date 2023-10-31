// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class RemoteDeviceAdapterSetRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("remoteDeviceAdapter"u8);
            writer.WriteObjectValue(RemoteDeviceAdapter);
            writer.WritePropertyName("methodName"u8);
            writer.WriteStringValue(MethodName);
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("@apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            writer.WriteEndObject();
        }

        internal static RemoteDeviceAdapterSetRequest DeserializeRemoteDeviceAdapterSetRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RemoteDeviceAdapter remoteDeviceAdapter = default;
            string methodName = default;
            Optional<string> apiVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("remoteDeviceAdapter"u8))
                {
                    remoteDeviceAdapter = RemoteDeviceAdapter.DeserializeRemoteDeviceAdapter(property.Value);
                    continue;
                }
                if (property.NameEquals("methodName"u8))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
            }
            return new RemoteDeviceAdapterSetRequest(methodName, apiVersion.Value, remoteDeviceAdapter);
        }
    }
}
