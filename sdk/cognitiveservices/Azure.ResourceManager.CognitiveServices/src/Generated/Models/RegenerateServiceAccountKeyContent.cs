// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Regenerate key parameters. </summary>
    public partial class RegenerateServiceAccountKeyContent
    {
        /// <summary> Initializes a new instance of <see cref="RegenerateServiceAccountKeyContent"/>. </summary>
        /// <param name="keyName"> key name to generate (Key1|Key2). </param>
        public RegenerateServiceAccountKeyContent(ServiceAccountKeyName keyName)
        {
            KeyName = keyName;
        }

        /// <summary> key name to generate (Key1|Key2). </summary>
        public ServiceAccountKeyName KeyName { get; }
    }
}
