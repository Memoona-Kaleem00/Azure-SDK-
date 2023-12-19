// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Messages
{
    /// <summary> The template object used to create templates. </summary>
    internal partial class MessageTemplateInternal
    {
        /// <summary> Initializes a new instance of <see cref="MessageTemplateInternal"/>. </summary>
        /// <param name="name"> Name of the template. </param>
        /// <param name="language"> The codes for the supported languages for templates. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="language"/> is null. </exception>
        public MessageTemplateInternal(string name, string language)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(language, nameof(language));

            Name = name;
            Language = language;
            Values = new ChangeTrackingList<MessageTemplateValue>();
        }

        /// <summary> Initializes a new instance of <see cref="MessageTemplateInternal"/>. </summary>
        /// <param name="name"> Name of the template. </param>
        /// <param name="language"> The codes for the supported languages for templates. </param>
        /// <param name="values"> The template values. </param>
        /// <param name="bindings"> The binding object to link values to the template specific locations. </param>
        internal MessageTemplateInternal(string name, string language, IList<MessageTemplateValue> values, MessageTemplateBindingsInternal bindings)
        {
            Name = name;
            Language = language;
            Values = values;
            Bindings = bindings;
        }

        /// <summary> Name of the template. </summary>
        public string Name { get; }
        /// <summary> The codes for the supported languages for templates. </summary>
        public string Language { get; }
        /// <summary>
        /// The template values.
        /// Please note <see cref="MessageTemplateValue"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MessageTemplateText"/>, <see cref="MessageTemplateImage"/>, <see cref="MessageTemplateDocument"/>, <see cref="MessageTemplateVideo"/>, <see cref="MessageTemplateLocation"/> and <see cref="MessageTemplateQuickAction"/>.
        /// </summary>
        public IList<MessageTemplateValue> Values { get; }
        /// <summary>
        /// The binding object to link values to the template specific locations
        /// Please note <see cref="MessageTemplateBindingsInternal"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="WhatsAppMessageTemplateBindingsInternal"/>.
        /// </summary>
        public MessageTemplateBindingsInternal Bindings { get; set; }
    }
}
