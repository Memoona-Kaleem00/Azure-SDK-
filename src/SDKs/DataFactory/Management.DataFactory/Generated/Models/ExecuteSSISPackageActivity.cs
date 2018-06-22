// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Execute SSIS package activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ExecuteSSISPackage")]
    [Rest.Serialization.JsonTransformation]
    public partial class ExecuteSSISPackageActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the ExecuteSSISPackageActivity class.
        /// </summary>
        public ExecuteSSISPackageActivity()
        {
            ConnectVia = new IntegrationRuntimeReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExecuteSSISPackageActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="packageLocation">SSIS package location.</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        /// <param name="runtime">Specifies the runtime to execute SSIS
        /// package. Possible values include: 'x64', 'x86'</param>
        /// <param name="loggingLevel">The logging level of SSIS package
        /// execution.</param>
        /// <param name="environmentPath">The environment path to execute the
        /// SSIS package.</param>
        /// <param name="projectParameters">The project level parameters to
        /// execute the SSIS package.</param>
        /// <param name="packageParameters">The package level parameters to
        /// execute the SSIS package.</param>
        /// <param name="projectConnectionManagers">The project level
        /// connection managers to execute the SSIS package.</param>
        /// <param name="packageConnectionManagers">The package level
        /// connection managers to execute the SSIS package.</param>
        /// <param name="propertyOverrides">The property overrides to execute
        /// the SSIS package.</param>
        public ExecuteSSISPackageActivity(string name, SSISPackageLocation packageLocation, IntegrationRuntimeReference connectVia, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IDictionary<string, string> userProperties = default(IDictionary<string, string>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), string runtime = default(string), string loggingLevel = default(string), string environmentPath = default(string), IDictionary<string, SSISExecutionParameter> projectParameters = default(IDictionary<string, SSISExecutionParameter>), IDictionary<string, SSISExecutionParameter> packageParameters = default(IDictionary<string, SSISExecutionParameter>), IDictionary<string, IDictionary<string, SSISExecutionParameter>> projectConnectionManagers = default(IDictionary<string, IDictionary<string, SSISExecutionParameter>>), IDictionary<string, IDictionary<string, SSISExecutionParameter>> packageConnectionManagers = default(IDictionary<string, IDictionary<string, SSISExecutionParameter>>), IDictionary<string, SSISPropertyOverride> propertyOverrides = default(IDictionary<string, SSISPropertyOverride>))
            : base(name, additionalProperties, description, dependsOn, userProperties, linkedServiceName, policy)
        {
            PackageLocation = packageLocation;
            Runtime = runtime;
            LoggingLevel = loggingLevel;
            EnvironmentPath = environmentPath;
            ConnectVia = connectVia;
            ProjectParameters = projectParameters;
            PackageParameters = packageParameters;
            ProjectConnectionManagers = projectConnectionManagers;
            PackageConnectionManagers = packageConnectionManagers;
            PropertyOverrides = propertyOverrides;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SSIS package location.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.packageLocation")]
        public SSISPackageLocation PackageLocation { get; set; }

        /// <summary>
        /// Gets or sets specifies the runtime to execute SSIS package.
        /// Possible values include: 'x64', 'x86'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.runtime")]
        public string Runtime { get; set; }

        /// <summary>
        /// Gets or sets the logging level of SSIS package execution.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.loggingLevel")]
        public string LoggingLevel { get; set; }

        /// <summary>
        /// Gets or sets the environment path to execute the SSIS package.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.environmentPath")]
        public string EnvironmentPath { get; set; }

        /// <summary>
        /// Gets or sets the integration runtime reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.connectVia")]
        public IntegrationRuntimeReference ConnectVia { get; set; }

        /// <summary>
        /// Gets or sets the project level parameters to execute the SSIS
        /// package.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.projectParameters")]
        public IDictionary<string, SSISExecutionParameter> ProjectParameters { get; set; }

        /// <summary>
        /// Gets or sets the package level parameters to execute the SSIS
        /// package.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.packageParameters")]
        public IDictionary<string, SSISExecutionParameter> PackageParameters { get; set; }

        /// <summary>
        /// Gets or sets the project level connection managers to execute the
        /// SSIS package.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.projectConnectionManagers")]
        public IDictionary<string, IDictionary<string, SSISExecutionParameter>> ProjectConnectionManagers { get; set; }

        /// <summary>
        /// Gets or sets the package level connection managers to execute the
        /// SSIS package.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.packageConnectionManagers")]
        public IDictionary<string, IDictionary<string, SSISExecutionParameter>> PackageConnectionManagers { get; set; }

        /// <summary>
        /// Gets or sets the property overrides to execute the SSIS package.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.propertyOverrides")]
        public IDictionary<string, SSISPropertyOverride> PropertyOverrides { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (PackageLocation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PackageLocation");
            }
            if (ConnectVia == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectVia");
            }
            if (PackageLocation != null)
            {
                PackageLocation.Validate();
            }
            if (ConnectVia != null)
            {
                ConnectVia.Validate();
            }
            if (ProjectParameters != null)
            {
                foreach (var valueElement in ProjectParameters.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
            if (PackageParameters != null)
            {
                foreach (var valueElement1 in PackageParameters.Values)
                {
                    if (valueElement1 != null)
                    {
                        valueElement1.Validate();
                    }
                }
            }
            if (ProjectConnectionManagers != null)
            {
                foreach (var valueElement2 in ProjectConnectionManagers.Values)
                {
                    if (valueElement2 != null)
                    {
                        foreach (var valueElement3 in valueElement2.Values)
                        {
                            if (valueElement3 != null)
                            {
                                valueElement3.Validate();
                            }
                        }
                    }
                }
            }
            if (PackageConnectionManagers != null)
            {
                foreach (var valueElement4 in PackageConnectionManagers.Values)
                {
                    if (valueElement4 != null)
                    {
                        foreach (var valueElement5 in valueElement4.Values)
                        {
                            if (valueElement5 != null)
                            {
                                valueElement5.Validate();
                            }
                        }
                    }
                }
            }
            if (PropertyOverrides != null)
            {
                foreach (var valueElement6 in PropertyOverrides.Values)
                {
                    if (valueElement6 != null)
                    {
                        valueElement6.Validate();
                    }
                }
            }
        }
    }
}
