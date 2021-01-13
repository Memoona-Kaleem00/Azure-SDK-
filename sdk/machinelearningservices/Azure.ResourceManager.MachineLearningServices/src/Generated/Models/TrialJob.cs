// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The TrialJob. </summary>
    public partial class TrialJob
    {
        /// <summary> Initializes a new instance of TrialJob. </summary>
        public TrialJob()
        {
            DataBindings = new ChangeTrackingDictionary<string, DataBinding>();
        }

        /// <summary> Initializes a new instance of TrialJob. </summary>
        /// <param name="codeConfiguration"> . </param>
        /// <param name="environmentId"> Environment id of the job. </param>
        /// <param name="dataBindings"> Mapping of data bindings used in the job. </param>
        internal TrialJob(CodeConfiguration codeConfiguration, string environmentId, IDictionary<string, DataBinding> dataBindings)
        {
            CodeConfiguration = codeConfiguration;
            EnvironmentId = environmentId;
            DataBindings = dataBindings;
        }

        public CodeConfiguration CodeConfiguration { get; set; }
        /// <summary> Environment id of the job. </summary>
        public string EnvironmentId { get; set; }
        /// <summary> Mapping of data bindings used in the job. </summary>
        public IDictionary<string, DataBinding> DataBindings { get; }
    }
}
