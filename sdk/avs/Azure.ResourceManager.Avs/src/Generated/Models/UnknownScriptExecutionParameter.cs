// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The UnknownScriptExecutionParameter. </summary>
    internal partial class UnknownScriptExecutionParameter : ScriptExecutionParameter
    {
        /// <summary> Initializes a new instance of UnknownScriptExecutionParameter. </summary>
        /// <param name="name"> The parameter name. </param>
        /// <param name="parameterType"> The type of execution parameter. </param>
        internal UnknownScriptExecutionParameter(string name, ScriptExecutionParameterType parameterType) : base(name, parameterType)
        {
            ParameterType = parameterType;
        }
    }
}
