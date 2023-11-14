// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    public partial class BlockList : IXmlSerializable, IPersistableModel<BlockList>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "BlockList");
            if (Optional.IsCollectionDefined(CommittedBlocks))
            {
                writer.WriteStartElement("CommittedBlocks");
                foreach (var item in CommittedBlocks)
                {
                    writer.WriteObjectValue(item, "Block");
                }
                writer.WriteEndElement();
            }
            if (Optional.IsCollectionDefined(UncommittedBlocks))
            {
                writer.WriteStartElement("UncommittedBlocks");
                foreach (var item in UncommittedBlocks)
                {
                    writer.WriteObjectValue(item, "Block");
                }
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static BlockList DeserializeBlockList(XElement element, ModelReaderWriterOptions options = null)
        {
            IEnumerable<BlobBlock> committedBlocks = default;
            IEnumerable<BlobBlock> uncommittedBlocks = default;
            if (element.Element("CommittedBlocks") is XElement committedBlocksElement)
            {
                var array = new List<BlobBlock>();
                foreach (var e in committedBlocksElement.Elements("Block"))
                {
                    array.Add(BlobBlock.DeserializeBlobBlock(e));
                }
                committedBlocks = array;
            }
            if (element.Element("UncommittedBlocks") is XElement uncommittedBlocksElement)
            {
                var array = new List<BlobBlock>();
                foreach (var e in uncommittedBlocksElement.Elements("Block"))
                {
                    array.Add(BlobBlock.DeserializeBlobBlock(e));
                }
                uncommittedBlocks = array;
            }
            return new BlockList(committedBlocks, uncommittedBlocks, default);
        }

        BinaryData IPersistableModel<BlockList>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<BlockList>;
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

        BlockList IPersistableModel<BlockList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlockList)} does not support '{options.Format}' format.");
            }

            return DeserializeBlockList(XElement.Load(data.ToStream()), options);
        }

        string IPersistableModel<BlockList>.GetWireFormat(ModelReaderWriterOptions options) => "X";
    }
}
