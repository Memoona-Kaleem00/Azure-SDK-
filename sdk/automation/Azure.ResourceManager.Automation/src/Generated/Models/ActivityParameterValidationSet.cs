// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the activity parameter validation set. </summary>
    public partial class ActivityParameterValidationSet
    {
        /// <summary> Initializes a new instance of ActivityParameterValidationSet. </summary>
        internal ActivityParameterValidationSet()
        {
        }

        /// <summary> Initializes a new instance of ActivityParameterValidationSet. </summary>
        /// <param name="memberValue"> Gets or sets the name of the activity parameter validation set member. </param>
        internal ActivityParameterValidationSet(string memberValue)
        {
            MemberValue = memberValue;
        }

        /// <summary> Gets or sets the name of the activity parameter validation set member. </summary>
        public string MemberValue { get; }
    }
}
