// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Messages.Models.Channels
{
    /// <summary> The WhatsAppMessageTemplateBindings. </summary>
    public partial class WhatsAppMessageTemplateBindings : MessageTemplateBindings
    {
        /// <summary> Initializes a new instance of <see cref="WhatsAppMessageTemplateBindings"/>. </summary>
        public WhatsAppMessageTemplateBindings()
        {
            Kind = MessageTemplateBindingsKind.WhatsApp;
            Header = new ChangeTrackingList<WhatsAppMessageTemplateBindingsComponent>();
            Body = new ChangeTrackingList<WhatsAppMessageTemplateBindingsComponent>();
            Footer = new ChangeTrackingList<WhatsAppMessageTemplateBindingsComponent>();
            Buttons = new ChangeTrackingList<WhatsAppMessageTemplateBindingsButton>();
        }

        /// <summary> Initializes a new instance of <see cref="WhatsAppMessageTemplateBindings"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="header"></param>
        /// <param name="body"></param>
        /// <param name="footer"></param>
        /// <param name="buttons"></param>
        internal WhatsAppMessageTemplateBindings(MessageTemplateBindingsKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<WhatsAppMessageTemplateBindingsComponent> header, IList<WhatsAppMessageTemplateBindingsComponent> body, IList<WhatsAppMessageTemplateBindingsComponent> footer, IList<WhatsAppMessageTemplateBindingsButton> buttons) : base(kind, serializedAdditionalRawData)
        {
            Header = header;
            Body = body;
            Footer = footer;
            Buttons = buttons;
        }

        /// <summary> Gets the header. </summary>
        public IList<WhatsAppMessageTemplateBindingsComponent> Header { get; }
        /// <summary> Gets the body. </summary>
        public IList<WhatsAppMessageTemplateBindingsComponent> Body { get; }
        /// <summary> Gets the footer. </summary>
        public IList<WhatsAppMessageTemplateBindingsComponent> Footer { get; }
        /// <summary> Gets the buttons. </summary>
        public IList<WhatsAppMessageTemplateBindingsButton> Buttons { get; }
    }
}
