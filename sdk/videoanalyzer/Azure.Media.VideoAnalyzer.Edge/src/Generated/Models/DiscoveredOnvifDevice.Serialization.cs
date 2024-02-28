// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class DiscoveredOnvifDevice : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ServiceIdentifier != null)
            {
                writer.WritePropertyName("serviceIdentifier"u8);
                writer.WriteStringValue(ServiceIdentifier);
            }
            if (RemoteIPAddress != null)
            {
                writer.WritePropertyName("remoteIPAddress"u8);
                writer.WriteStringValue(RemoteIPAddress);
            }
            if (!(Scopes is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("scopes"u8);
                writer.WriteStartArray();
                foreach (var item in Scopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Endpoints is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static DiscoveredOnvifDevice DeserializeDiscoveredOnvifDevice(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serviceIdentifier = default;
            string remoteIPAddress = default;
            IList<string> scopes = default;
            IList<string> endpoints = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceIdentifier"u8))
                {
                    serviceIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteIPAddress"u8))
                {
                    remoteIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scopes"u8))
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
                    scopes = array;
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
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
                    endpoints = array;
                    continue;
                }
            }
            return new DiscoveredOnvifDevice(serviceIdentifier, remoteIPAddress, scopes ?? new ChangeTrackingList<string>(), endpoints ?? new ChangeTrackingList<string>());
        }
    }
}
