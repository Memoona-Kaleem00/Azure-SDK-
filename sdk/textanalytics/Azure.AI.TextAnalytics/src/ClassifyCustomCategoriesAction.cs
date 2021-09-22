﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// Configurations that allow callers to specify details about how to execute
    /// a Classify Custom Categories action on a set of documents. This corresponds
    /// to a Multi Classification task in the text analytics service.
    /// For example, the target project and deployment names are required
    /// for a successful custom classification action.
    /// </summary>
    public class ClassifyCustomCategoriesAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyCustomCategoriesAction"/>
        /// class which allows callers to specify details about how to execute
        /// a Classify Custom Categories action on a set of documents.
        /// Sets the <see cref="ProjectName"/> and <see cref="DeploymentName"/> properties.
        /// </summary>
        public ClassifyCustomCategoriesAction(string projectName, string deploymentName)
        {
            DeploymentName = deploymentName;
            ProjectName = projectName;
        }

        /// <summary>
        /// Gets the value of the property corresponding to the name of the
        /// target project for this action. This property is set when calling
        /// the <see cref="ClassifyCustomCategoriesAction"/> constructor.
        /// </summary>
        public string ProjectName { get; }

        /// <summary>
        /// Gets the value of the property corresponding to the name of the
        /// deployment for this action. This property is set when calling
        /// the <see cref="ClassifyCustomCategoriesAction"/> constructor.
        /// </summary>
        public string DeploymentName { get; }

        /// <summary>
        /// The default value of this property is 'false'. This means, Text Analytics service logs your input text for 48 hours,
        /// solely to allow for troubleshooting issues.
        /// Setting this property to true, disables input logging and may limit our ability to investigate issues that occur.
        /// <para>
        /// Please see Cognitive Services Compliance and Privacy notes at <see href="https://aka.ms/cs-compliance"/> for additional details,
        /// and Microsoft Responsible AI principles at <see href="https://www.microsoft.com/ai/responsible-ai"/>.
        /// </para>
        /// </summary>
        public bool? DisableServiceLogs { get; set; }
    }
}
