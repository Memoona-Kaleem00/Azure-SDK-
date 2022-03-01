// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CdnOriginUpdateOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName");
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(HttpPort))
            {
                if (HttpPort != null)
                {
                    writer.WritePropertyName("httpPort");
                    writer.WriteNumberValue(HttpPort.Value);
                }
                else
                {
                    writer.WriteNull("httpPort");
                }
            }
            if (Optional.IsDefined(HttpsPort))
            {
                if (HttpsPort != null)
                {
                    writer.WritePropertyName("httpsPort");
                    writer.WriteNumberValue(HttpsPort.Value);
                }
                else
                {
                    writer.WriteNull("httpsPort");
                }
            }
            if (Optional.IsDefined(OriginHostHeader))
            {
                writer.WritePropertyName("originHostHeader");
                writer.WriteStringValue(OriginHostHeader);
            }
            if (Optional.IsDefined(Priority))
            {
                if (Priority != null)
                {
                    writer.WritePropertyName("priority");
                    writer.WriteNumberValue(Priority.Value);
                }
                else
                {
                    writer.WriteNull("priority");
                }
            }
            if (Optional.IsDefined(Weight))
            {
                if (Weight != null)
                {
                    writer.WritePropertyName("weight");
                    writer.WriteNumberValue(Weight.Value);
                }
                else
                {
                    writer.WriteNull("weight");
                }
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(PrivateLinkAlias))
            {
                writer.WritePropertyName("privateLinkAlias");
                writer.WriteStringValue(PrivateLinkAlias);
            }
            if (Optional.IsDefined(PrivateLinkResourceId))
            {
                writer.WritePropertyName("privateLinkResourceId");
                writer.WriteStringValue(PrivateLinkResourceId);
            }
            if (Optional.IsDefined(PrivateLinkLocation))
            {
                writer.WritePropertyName("privateLinkLocation");
                writer.WriteStringValue(PrivateLinkLocation);
            }
            if (Optional.IsDefined(PrivateLinkApprovalMessage))
            {
                writer.WritePropertyName("privateLinkApprovalMessage");
                writer.WriteStringValue(PrivateLinkApprovalMessage);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
