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

namespace Azure.Storage.Files.DataLake.Models
{
    internal partial class BlobPrefix : IXmlSerializable, IPersistableModel<BlobPrefix>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "BlobPrefix");
            writer.WriteStartElement("Name");
            writer.WriteValue(Name);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        internal static BlobPrefix DeserializeBlobPrefix(XElement element, ModelReaderWriterOptions options = null)
        {
            string name = default;
            if (element.Element("Name") is XElement nameElement)
            {
                name = (string)nameElement;
            }
            return new BlobPrefix(name, default);
        }

        BinaryData IPersistableModel<BlobPrefix>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<BlobPrefix>;
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

        BlobPrefix IPersistableModel<BlobPrefix>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobPrefix)} does not support '{options.Format}' format.");
            }

            return DeserializeBlobPrefix(XElement.Load(data.ToStream()), options);
        }

        string IPersistableModel<BlobPrefix>.GetWireFormat(ModelReaderWriterOptions options) => "X";
    }
}
