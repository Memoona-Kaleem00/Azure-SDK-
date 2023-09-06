// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Rules that can be defined for auto-heal. </summary>
    public partial class AutoHealRules
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutoHealRules"/>. </summary>
        public AutoHealRules()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutoHealRules"/>. </summary>
        /// <param name="triggers"> Conditions that describe when to execute the auto-heal actions. </param>
        /// <param name="actions"> Actions to be executed when a rule is triggered. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutoHealRules(AutoHealTriggers triggers, AutoHealActions actions, Dictionary<string, BinaryData> rawData)
        {
            Triggers = triggers;
            Actions = actions;
            _rawData = rawData;
        }

        /// <summary> Conditions that describe when to execute the auto-heal actions. </summary>
        public AutoHealTriggers Triggers { get; set; }
        /// <summary> Actions to be executed when a rule is triggered. </summary>
        public AutoHealActions Actions { get; set; }
    }
}
