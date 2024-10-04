// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> The RuleEngineWorkerSelectorAttachment. </summary>
    public partial class RuleEngineWorkerSelectorAttachment : WorkerSelectorAttachment
    {
        /// <summary> Initializes a new instance of <see cref="RuleEngineWorkerSelectorAttachment"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="rule">
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="WebhookRouterRule"/>.
        /// </param>
        internal RuleEngineWorkerSelectorAttachment(WorkerSelectorAttachmentKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, RouterRule rule) : base(kind, serializedAdditionalRawData)
        {
            Rule = rule;
        }

        /// <summary> Initializes a new instance of <see cref="RuleEngineWorkerSelectorAttachment"/> for deserialization. </summary>
        internal RuleEngineWorkerSelectorAttachment()
        {
        }

        /// <summary>
        /// Gets the rule
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="WebhookRouterRule"/>.
        /// </summary>
        public RouterRule Rule { get; }
    }
}
