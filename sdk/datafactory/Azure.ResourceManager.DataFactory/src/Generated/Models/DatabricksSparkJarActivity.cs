// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// DatabricksSparkJar activity.
    /// Serialized Name: DatabricksSparkJarActivity
    /// </summary>
    public partial class DatabricksSparkJarActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of DatabricksSparkJarActivity. </summary>
        /// <param name="name">
        /// Activity name.
        /// Serialized Name: Activity.name
        /// </param>
        /// <param name="mainClassName">
        /// The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. Type: string (or Expression with resultType string).
        /// Serialized Name: DatabricksSparkJarActivity.typeProperties.mainClassName
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="mainClassName"/> is null. </exception>
        public DatabricksSparkJarActivity(string name, BinaryData mainClassName) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (mainClassName == null)
            {
                throw new ArgumentNullException(nameof(mainClassName));
            }

            MainClassName = mainClassName;
            Parameters = new ChangeTrackingList<BinaryData>();
            Libraries = new ChangeTrackingList<IDictionary<string, BinaryData>>();
            ActivityType = "DatabricksSparkJar";
        }

        /// <summary> Initializes a new instance of DatabricksSparkJarActivity. </summary>
        /// <param name="name">
        /// Activity name.
        /// Serialized Name: Activity.name
        /// </param>
        /// <param name="activityType">
        /// Type of activity.
        /// Serialized Name: Activity.type
        /// </param>
        /// <param name="description">
        /// Activity description.
        /// Serialized Name: Activity.description
        /// </param>
        /// <param name="dependsOn">
        /// Activity depends on condition.
        /// Serialized Name: Activity.dependsOn
        /// </param>
        /// <param name="userProperties">
        /// Activity user properties.
        /// Serialized Name: Activity.userProperties
        /// </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName">
        /// Linked service reference.
        /// Serialized Name: ExecutionActivity.linkedServiceName
        /// </param>
        /// <param name="policy">
        /// Activity policy.
        /// Serialized Name: ExecutionActivity.policy
        /// </param>
        /// <param name="mainClassName">
        /// The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. Type: string (or Expression with resultType string).
        /// Serialized Name: DatabricksSparkJarActivity.typeProperties.mainClassName
        /// </param>
        /// <param name="parameters">
        /// Parameters that will be passed to the main method.
        /// Serialized Name: DatabricksSparkJarActivity.typeProperties.parameters
        /// </param>
        /// <param name="libraries">
        /// A list of libraries to be installed on the cluster that will execute the job.
        /// Serialized Name: DatabricksSparkJarActivity.typeProperties.libraries
        /// </param>
        internal DatabricksSparkJarActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, FactoryLinkedServiceReference linkedServiceName, ActivityPolicy policy, BinaryData mainClassName, IList<BinaryData> parameters, IList<IDictionary<string, BinaryData>> libraries) : base(name, activityType, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            MainClassName = mainClassName;
            Parameters = parameters;
            Libraries = libraries;
            ActivityType = activityType ?? "DatabricksSparkJar";
        }

        /// <summary>
        /// The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. Type: string (or Expression with resultType string).
        /// Serialized Name: DatabricksSparkJarActivity.typeProperties.mainClassName
        /// </summary>
        public BinaryData MainClassName { get; set; }
        /// <summary>
        /// Parameters that will be passed to the main method.
        /// Serialized Name: DatabricksSparkJarActivity.typeProperties.parameters
        /// </summary>
        public IList<BinaryData> Parameters { get; }
        /// <summary>
        /// A list of libraries to be installed on the cluster that will execute the job.
        /// Serialized Name: DatabricksSparkJarActivity.typeProperties.libraries
        /// </summary>
        public IList<IDictionary<string, BinaryData>> Libraries { get; }
    }
}
