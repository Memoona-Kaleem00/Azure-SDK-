// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The authentication keys. </summary>
    public partial class CreateServiceRequestKeys : AuthKeys
    {
        /// <summary> Initializes a new instance of CreateServiceRequestKeys. </summary>
        public CreateServiceRequestKeys()
        {
        }

        /// <summary> Initializes a new instance of CreateServiceRequestKeys. </summary>
        /// <param name="primaryKey"> The primary key. </param>
        /// <param name="secondaryKey"> The secondary key. </param>
        internal CreateServiceRequestKeys(string primaryKey, string secondaryKey) : base(primaryKey, secondaryKey)
        {
        }
    }
}
