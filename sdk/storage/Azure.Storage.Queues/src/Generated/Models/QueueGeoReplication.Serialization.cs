// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    public partial class QueueGeoReplication : IXmlSerializable, IPersistableModel<QueueGeoReplication>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "GeoReplication");
            writer.WriteStartElement("Status");
            writer.WriteValue(Status.ToSerialString());
            writer.WriteEndElement();
            if (LastSyncedOn != null)
            {
                writer.WriteStartElement("LastSyncTime");
                writer.WriteValue(LastSyncedOn.Value, "R");
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static QueueGeoReplication DeserializeQueueGeoReplication(XElement element, ModelReaderWriterOptions options = null)
        {
            QueueGeoReplicationStatus status = default;
            DateTimeOffset? lastSyncedOn = default;
            if (element.Element("Status") is XElement statusElement)
            {
                status = statusElement.Value.ToQueueGeoReplicationStatus();
            }
            if (element.Element("LastSyncTime") is XElement lastSyncTimeElement)
            {
                lastSyncedOn = lastSyncTimeElement.GetDateTimeOffsetValue("R");
            }
            return new QueueGeoReplication(status, lastSyncedOn, default);
        }

        BinaryData IPersistableModel<QueueGeoReplication>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<QueueGeoReplication>;
            bool isValid = options.Format == "J" && implementsJson || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using MemoryStream stream = new MemoryStream();
            using XmlWriter writer = XmlWriter.Create(stream);
            ((IXmlSerializable)this).Write(writer, null);
            writer.Flush();
            if (stream.Position > int.MaxValue)
            {
                return BinaryData.FromStream(stream);
            }
            else
            {
                return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
            }
        }

        QueueGeoReplication IPersistableModel<QueueGeoReplication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(QueueGeoReplication)} does not support '{options.Format}' format.");
            }

            return DeserializeQueueGeoReplication(XElement.Load(data.ToStream()), options);
        }

        string IPersistableModel<QueueGeoReplication>.GetWireFormat(ModelReaderWriterOptions options) => "X";
    }
}
