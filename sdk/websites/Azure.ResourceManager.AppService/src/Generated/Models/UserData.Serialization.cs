// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class UserData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PublishingUserName))
            {
                writer.WritePropertyName("publishingUserName");
                writer.WriteStringValue(PublishingUserName);
            }
            if (Optional.IsDefined(PublishingPassword))
            {
                writer.WritePropertyName("publishingPassword");
                writer.WriteStringValue(PublishingPassword);
            }
            if (Optional.IsDefined(PublishingPasswordHash))
            {
                writer.WritePropertyName("publishingPasswordHash");
                writer.WriteStringValue(PublishingPasswordHash);
            }
            if (Optional.IsDefined(PublishingPasswordHashSalt))
            {
                writer.WritePropertyName("publishingPasswordHashSalt");
                writer.WriteStringValue(PublishingPasswordHashSalt);
            }
            if (Optional.IsDefined(ScmUri))
            {
                writer.WritePropertyName("scmUri");
                writer.WriteStringValue(ScmUri);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static UserData DeserializeUserData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> publishingUserName = default;
            Optional<string> publishingPassword = default;
            Optional<string> publishingPasswordHash = default;
            Optional<string> publishingPasswordHashSalt = default;
            Optional<string> scmUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("publishingUserName"))
                        {
                            publishingUserName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publishingPassword"))
                        {
                            publishingPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publishingPasswordHash"))
                        {
                            publishingPasswordHash = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publishingPasswordHashSalt"))
                        {
                            publishingPasswordHashSalt = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scmUri"))
                        {
                            scmUri = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new UserData(id, name, type, systemData, kind.Value, publishingUserName.Value, publishingPassword.Value, publishingPasswordHash.Value, publishingPasswordHashSalt.Value, scmUri.Value);
        }
    }
}
