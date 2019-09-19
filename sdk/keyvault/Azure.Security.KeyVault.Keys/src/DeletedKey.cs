﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System;
using System.Text.Json;

namespace Azure.Security.KeyVault.Keys
{
    /// <summary>
    /// Represents a KeyVault key that has been deleted, allowing it to be recovered, if needed.
    /// </summary>
    public class DeletedKey : Key
    {
        /// <summary>
        /// The identifier of the deleted key. This is used to recover the key.
        /// </summary>
        public string RecoveryId { get; private set; }

        /// <summary>
        /// The time when the key was deleted, in UTC.
        /// </summary>
        public DateTimeOffset? DeletedDate { get; private set; }

        /// <summary>
        /// The time when the key is scheduled to be purged, in UTC
        /// </summary>
        public DateTimeOffset? ScheduledPurgeDate { get; private set; }

        internal DeletedKey() { }

        internal DeletedKey(string name) : base(name) { }

        private const string RecoveryIdPropertyName = "recoveryId";
        private static readonly JsonEncodedText s_recoveryIdPropertyNameBytes = JsonEncodedText.Encode(RecoveryIdPropertyName);
        private const string DeletedDatePropertyName = "deletedDate";
        private static readonly JsonEncodedText s_deletedDatePropertyNameBytes = JsonEncodedText.Encode(DeletedDatePropertyName);
        private const string ScheduledPurgeDatePropertyName = "scheduledPurgeDate";
        private static readonly JsonEncodedText s_scheduledPurgeDatePropertyNameBytes = JsonEncodedText.Encode(ScheduledPurgeDatePropertyName);

        internal override void WriteProperties(Utf8JsonWriter json)
        {
            base.WriteProperties(json);

            if (RecoveryId != null)
            {
                json.WriteString(s_recoveryIdPropertyNameBytes, RecoveryId);
            }

            if (DeletedDate.HasValue)
            {
                json.WriteNumber(s_deletedDatePropertyNameBytes, DeletedDate.Value.ToUnixTimeSeconds());
            }

            if (ScheduledPurgeDate.HasValue)
            {
                json.WriteNumber(s_scheduledPurgeDatePropertyNameBytes, ScheduledPurgeDate.Value.ToUnixTimeSeconds());
            }
        }

        internal override void ReadProperties(JsonElement json)
        {
            base.ReadProperties(json);
            foreach (JsonProperty prop in json.EnumerateObject())
            {
                switch (prop.Name)
                {
                    case RecoveryIdPropertyName:
                        RecoveryId = prop.Value.GetString();
                        break;
                    case DeletedDatePropertyName:
                        DeletedDate = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                        break;
                    case ScheduledPurgeDatePropertyName:
                        ScheduledPurgeDate = DateTimeOffset.FromUnixTimeSeconds(prop.Value.GetInt64());
                        break;
                }
            }
        }
    }
}
