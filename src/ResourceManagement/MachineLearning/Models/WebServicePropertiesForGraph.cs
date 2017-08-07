// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearning.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.MachineLearning;
    using Microsoft.Azure.Management.MachineLearning.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties specific to a Graph based web service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Graph")]
    public partial class WebServicePropertiesForGraph : WebServiceProperties
    {
        /// <summary>
        /// Initializes a new instance of the WebServicePropertiesForGraph
        /// class.
        /// </summary>
        public WebServicePropertiesForGraph()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebServicePropertiesForGraph
        /// class.
        /// </summary>
        /// <param name="title">The title of the web service.</param>
        /// <param name="description">The description of the web
        /// service.</param>
        /// <param name="createdOn">Read Only: The date and time when the web
        /// service was created.</param>
        /// <param name="modifiedOn">Read Only: The date and time when the web
        /// service was last modified.</param>
        /// <param name="provisioningState">Read Only: The provision state of
        /// the web service. Valid values are Unknown, Provisioning, Succeeded,
        /// and Failed. Possible values include: 'Unknown', 'Provisioning',
        /// 'Succeeded', 'Failed'</param>
        /// <param name="keys">Contains the web service provisioning keys. If
        /// you do not specify provisioning keys, the Azure Machine Learning
        /// system generates them for you. Note: The keys are not returned from
        /// calls to GET operations.</param>
        /// <param name="readOnlyProperty">When set to true, indicates that the
        /// web service is read-only and can no longer be updated or patched,
        /// only removed. Default, is false. Note: Once set to true, you cannot
        /// change its value.</param>
        /// <param name="swaggerLocation">Read Only: Contains the URI of the
        /// swagger spec associated with this web service.</param>
        /// <param name="exposeSampleData">When set to true, sample data is
        /// included in the web service's swagger definition. The default value
        /// is true.</param>
        /// <param name="realtimeConfiguration">Contains the configuration
        /// settings for the web service endpoint.</param>
        /// <param name="diagnostics">Settings controlling the diagnostics
        /// traces collection for the web service.</param>
        /// <param name="storageAccount">Specifies the storage account that
        /// Azure Machine Learning uses to store information about the web
        /// service. Only the name of the storage account is returned from
        /// calls to GET operations. When updating the storage account
        /// information, you must ensure that all necessary assets are
        /// available in the new storage account or calls to your web service
        /// will fail.</param>
        /// <param name="machineLearningWorkspace">Specifies the Machine
        /// Learning workspace containing the experiment that is source for the
        /// web service.</param>
        /// <param name="commitmentPlan">Contains the commitment plan
        /// associated with this web service. Set at creation time. Once set,
        /// this value cannot be changed. Note: The commitment plan is not
        /// returned from calls to GET operations.</param>
        /// <param name="input">Contains the Swagger 2.0 schema describing one
        /// or more of the web service's inputs. For more information, see the
        /// Swagger specification.</param>
        /// <param name="output">Contains the Swagger 2.0 schema describing one
        /// or more of the web service's outputs. For more information, see the
        /// Swagger specification.</param>
        /// <param name="exampleRequest">Defines sample input data for one or
        /// more of the service's inputs.</param>
        /// <param name="assets">Contains user defined properties describing
        /// web service assets. Properties are expressed as Key/Value
        /// pairs.</param>
        /// <param name="parameters">The set of global parameters values
        /// defined for the web service, given as a global parameter name to
        /// default value map. If no default value is specified, the parameter
        /// is considered to be required.</param>
        /// <param name="payloadsInBlobStorage">When set to true, indicates
        /// that the payload size is larger than 3 MB. Otherwise false. If the
        /// payload size exceed 3 MB, the payload is stored in a blob and the
        /// PayloadsLocation parameter contains the URI of the blob. Otherwise,
        /// this will be set to false and Assets, Input, Output, Package,
        /// Parameters, ExampleRequest are inline. The Payload sizes is
        /// determined by adding the size of the Assets, Input, Output,
        /// Package, Parameters, and the ExampleRequest.</param>
        /// <param name="payloadsLocation">The URI of the payload blob. This
        /// paramater contains a value only if the payloadsInBlobStorage
        /// parameter is set to true. Otherwise is set to null.</param>
        /// <param name="package">The definition of the graph package making up
        /// this web service.</param>
        public WebServicePropertiesForGraph(string title = default(string), string description = default(string), System.DateTime? createdOn = default(System.DateTime?), System.DateTime? modifiedOn = default(System.DateTime?), string provisioningState = default(string), WebServiceKeysInner keys = default(WebServiceKeysInner), bool? readOnlyProperty = default(bool?), string swaggerLocation = default(string), bool? exposeSampleData = default(bool?), RealtimeConfiguration realtimeConfiguration = default(RealtimeConfiguration), DiagnosticsConfiguration diagnostics = default(DiagnosticsConfiguration), StorageAccount storageAccount = default(StorageAccount), MachineLearningWorkspace machineLearningWorkspace = default(MachineLearningWorkspace), CommitmentPlan commitmentPlan = default(CommitmentPlan), ServiceInputOutputSpecification input = default(ServiceInputOutputSpecification), ServiceInputOutputSpecification output = default(ServiceInputOutputSpecification), ExampleRequest exampleRequest = default(ExampleRequest), IDictionary<string, AssetItem> assets = default(IDictionary<string, AssetItem>), IDictionary<string, WebServiceParameter> parameters = default(IDictionary<string, WebServiceParameter>), bool? payloadsInBlobStorage = default(bool?), BlobLocation payloadsLocation = default(BlobLocation), GraphPackage package = default(GraphPackage))
            : base(title, description, createdOn, modifiedOn, provisioningState, keys, readOnlyProperty, swaggerLocation, exposeSampleData, realtimeConfiguration, diagnostics, storageAccount, machineLearningWorkspace, commitmentPlan, input, output, exampleRequest, assets, parameters, payloadsInBlobStorage, payloadsLocation)
        {
            Package = package;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the definition of the graph package making up this web
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "package")]
        public GraphPackage Package { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
