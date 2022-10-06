// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> This class represents the manual action task details. </summary>
    public partial class ManualActionTaskDetails : TaskTypeDetails
    {
        /// <summary> Initializes a new instance of ManualActionTaskDetails. </summary>
        internal ManualActionTaskDetails()
        {
            InstanceType = "ManualActionTaskDetails";
        }

        /// <summary> Initializes a new instance of ManualActionTaskDetails. </summary>
        /// <param name="instanceType"> The type of task details. </param>
        /// <param name="name"> The name. </param>
        /// <param name="instructions"> The instructions. </param>
        /// <param name="observation"> The observation. </param>
        internal ManualActionTaskDetails(string instanceType, string name, string instructions, string observation) : base(instanceType)
        {
            Name = name;
            Instructions = instructions;
            Observation = observation;
            InstanceType = instanceType ?? "ManualActionTaskDetails";
        }

        /// <summary> The name. </summary>
        public string Name { get; }
        /// <summary> The instructions. </summary>
        public string Instructions { get; }
        /// <summary> The observation. </summary>
        public string Observation { get; }
    }
}
