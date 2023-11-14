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

namespace Azure.Data.Tables.Models
{
    public partial class TableServiceStatistics : IXmlSerializable, IPersistableModel<TableServiceStatistics>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "StorageServiceStats");
            if (Optional.IsDefined(GeoReplication))
            {
                writer.WriteObjectValue(GeoReplication, "GeoReplication");
            }
            writer.WriteEndElement();
        }

        internal static TableServiceStatistics DeserializeTableServiceStatistics(XElement element, ModelReaderWriterOptions options = null)
        {
            TableGeoReplicationInfo geoReplication = default;
            if (element.Element("GeoReplication") is XElement geoReplicationElement)
            {
                geoReplication = TableGeoReplicationInfo.DeserializeTableGeoReplicationInfo(geoReplicationElement);
            }
            return new TableServiceStatistics(geoReplication, default);
        }

        BinaryData IPersistableModel<TableServiceStatistics>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<TableServiceStatistics>;
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

        TableServiceStatistics IPersistableModel<TableServiceStatistics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TableServiceStatistics)} does not support '{options.Format}' format.");
            }

            return DeserializeTableServiceStatistics(XElement.Load(data.ToStream()), options);
        }

        string IPersistableModel<TableServiceStatistics>.GetWireFormat(ModelReaderWriterOptions options) => "X";
    }
}
