// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Validation result for configuration service settings. </summary>
    public partial class ConfigurationServiceGitPropertyValidateResult
    {
        /// <summary> Initializes a new instance of ConfigurationServiceGitPropertyValidateResult. </summary>
        internal ConfigurationServiceGitPropertyValidateResult()
        {
            GitReposValidationResult = new ChangeTrackingList<ValidationMessages>();
        }

        /// <summary> Initializes a new instance of ConfigurationServiceGitPropertyValidateResult. </summary>
        /// <param name="isValid"> Indicate if the configuration service settings are valid. </param>
        /// <param name="gitReposValidationResult"> The detail validation results. </param>
        internal ConfigurationServiceGitPropertyValidateResult(bool? isValid, IReadOnlyList<ValidationMessages> gitReposValidationResult)
        {
            IsValid = isValid;
            GitReposValidationResult = gitReposValidationResult;
        }

        /// <summary> Indicate if the configuration service settings are valid. </summary>
        public bool? IsValid { get; }
        /// <summary> The detail validation results. </summary>
        public IReadOnlyList<ValidationMessages> GitReposValidationResult { get; }
    }
}
