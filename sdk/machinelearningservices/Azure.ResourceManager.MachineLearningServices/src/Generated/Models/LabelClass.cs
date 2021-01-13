// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Label class definition. </summary>
    public partial class LabelClass
    {
        /// <summary> Initializes a new instance of LabelClass. </summary>
        public LabelClass()
        {
            Subclasses = new ChangeTrackingDictionary<string, LabelClass>();
        }

        /// <summary> Initializes a new instance of LabelClass. </summary>
        /// <param name="displayName"> Display name of the label class. </param>
        /// <param name="subclasses"> Dictionary of subclasses of the label class. </param>
        internal LabelClass(string displayName, IDictionary<string, LabelClass> subclasses)
        {
            DisplayName = displayName;
            Subclasses = subclasses;
        }

        /// <summary> Display name of the label class. </summary>
        public string DisplayName { get; set; }
        /// <summary> Dictionary of subclasses of the label class. </summary>
        public IDictionary<string, LabelClass> Subclasses { get; }
    }
}
