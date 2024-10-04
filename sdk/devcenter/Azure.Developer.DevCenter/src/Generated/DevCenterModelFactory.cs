// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class DevCenterModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.DevCenterProject"/>. </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="maxDevBoxesPerUser"></param>
        /// <returns> A new <see cref="Models.DevCenterProject"/> instance for mocking. </returns>
        public static DevCenterProject DevCenterProject(string name = null, string description = null, int? maxDevBoxesPerUser = null)
        {
            return new DevCenterProject(name, description, maxDevBoxesPerUser, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBoxPool"/>. </summary>
        /// <param name="name"></param>
        /// <param name="location"></param>
        /// <param name="osType"></param>
        /// <param name="hardwareProfile"></param>
        /// <param name="hibernateSupport"></param>
        /// <param name="storageProfile"></param>
        /// <param name="imageReference"></param>
        /// <param name="localAdministratorStatus"></param>
        /// <param name="stopOnDisconnect"></param>
        /// <param name="healthStatus"></param>
        /// <returns> A new <see cref="Models.DevBoxPool"/> instance for mocking. </returns>
        public static DevBoxPool DevBoxPool(string name = null, AzureLocation location = default, DevBoxOSType? osType = null, DevBoxHardwareProfile hardwareProfile = null, HibernateSupport? hibernateSupport = null, DevBoxStorageProfile storageProfile = null, DevBoxImageReference imageReference = null, LocalAdministratorStatus? localAdministratorStatus = null, StopOnDisconnectConfiguration stopOnDisconnect = null, PoolHealthStatus healthStatus = default)
        {
            return new DevBoxPool(
                name,
                location,
                osType,
                hardwareProfile,
                hibernateSupport,
                storageProfile,
                imageReference,
                localAdministratorStatus,
                stopOnDisconnect,
                healthStatus,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBoxHardwareProfile"/>. </summary>
        /// <param name="skuName"></param>
        /// <param name="vcpUs"></param>
        /// <param name="memoryGB"></param>
        /// <returns> A new <see cref="Models.DevBoxHardwareProfile"/> instance for mocking. </returns>
        public static DevBoxHardwareProfile DevBoxHardwareProfile(SkuName? skuName = null, int? vcpUs = null, int? memoryGB = null)
        {
            return new DevBoxHardwareProfile(skuName, vcpUs, memoryGB, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.OSDisk"/>. </summary>
        /// <param name="diskSizeGB"></param>
        /// <returns> A new <see cref="Models.OSDisk"/> instance for mocking. </returns>
        public static OSDisk OSDisk(int? diskSizeGB = null)
        {
            return new OSDisk(diskSizeGB, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBoxImageReference"/>. </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="operatingSystem"></param>
        /// <param name="osBuildNumber"></param>
        /// <param name="publishedDate"></param>
        /// <returns> A new <see cref="Models.DevBoxImageReference"/> instance for mocking. </returns>
        public static DevBoxImageReference DevBoxImageReference(string name = null, string version = null, string operatingSystem = null, string osBuildNumber = null, DateTimeOffset? publishedDate = null)
        {
            return new DevBoxImageReference(
                name,
                version,
                operatingSystem,
                osBuildNumber,
                publishedDate,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.StopOnDisconnectConfiguration"/>. </summary>
        /// <param name="status"></param>
        /// <param name="gracePeriodMinutes"></param>
        /// <returns> A new <see cref="Models.StopOnDisconnectConfiguration"/> instance for mocking. </returns>
        public static StopOnDisconnectConfiguration StopOnDisconnectConfiguration(StopOnDisconnectStatus status = default, int? gracePeriodMinutes = null)
        {
            return new StopOnDisconnectConfiguration(status, gracePeriodMinutes, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBoxSchedule"/>. </summary>
        /// <param name="name"></param>
        /// <param name="scheduleType"></param>
        /// <param name="scheduleFrequency"></param>
        /// <param name="time"></param>
        /// <param name="timeZone"></param>
        /// <returns> A new <see cref="Models.DevBoxSchedule"/> instance for mocking. </returns>
        public static DevBoxSchedule DevBoxSchedule(string name = null, ScheduleType scheduleType = default, ScheduleFrequency scheduleFrequency = default, string time = null, string timeZone = null)
        {
            return new DevBoxSchedule(
                name,
                scheduleType,
                scheduleFrequency,
                time,
                timeZone,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBox"/>. </summary>
        /// <param name="name"></param>
        /// <param name="projectName"></param>
        /// <param name="poolName"></param>
        /// <param name="hibernateSupport"></param>
        /// <param name="provisioningState"></param>
        /// <param name="actionState"></param>
        /// <param name="powerState"></param>
        /// <param name="uniqueId"></param>
        /// <param name="error"></param>
        /// <param name="location"></param>
        /// <param name="osType"></param>
        /// <param name="userId"></param>
        /// <param name="hardwareProfile"></param>
        /// <param name="storageProfile"></param>
        /// <param name="imageReference"></param>
        /// <param name="createdTime"></param>
        /// <param name="localAdministratorStatus"></param>
        /// <returns> A new <see cref="Models.DevBox"/> instance for mocking. </returns>
        public static DevBox DevBox(string name = null, string projectName = null, string poolName = null, HibernateSupport? hibernateSupport = null, DevBoxProvisioningState? provisioningState = null, string actionState = null, PowerState? powerState = null, Guid? uniqueId = null, ResponseError error = null, AzureLocation? location = null, DevBoxOSType? osType = null, Guid? userId = null, DevBoxHardwareProfile hardwareProfile = null, DevBoxStorageProfile storageProfile = null, DevBoxImageReference imageReference = null, DateTimeOffset? createdTime = null, LocalAdministratorStatus? localAdministratorStatus = null)
        {
            return new DevBox(
                name,
                projectName,
                poolName,
                hibernateSupport,
                provisioningState,
                actionState,
                powerState,
                uniqueId,
                error,
                location,
                osType,
                userId,
                hardwareProfile,
                storageProfile,
                imageReference,
                createdTime,
                localAdministratorStatus,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.RemoteConnection"/>. </summary>
        /// <param name="webUri"></param>
        /// <param name="rdpConnectionUri"></param>
        /// <returns> A new <see cref="Models.RemoteConnection"/> instance for mocking. </returns>
        public static RemoteConnection RemoteConnection(Uri webUri = null, Uri rdpConnectionUri = null)
        {
            return new RemoteConnection(webUri, rdpConnectionUri, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBoxAction"/>. </summary>
        /// <param name="name"></param>
        /// <param name="actionType"></param>
        /// <param name="sourceId"></param>
        /// <param name="suspendedUntil"></param>
        /// <param name="nextAction"></param>
        /// <returns> A new <see cref="Models.DevBoxAction"/> instance for mocking. </returns>
        public static DevBoxAction DevBoxAction(string name = null, DevBoxActionType actionType = default, string sourceId = null, DateTimeOffset? suspendedUntil = null, DevBoxNextAction nextAction = null)
        {
            return new DevBoxAction(
                name,
                actionType,
                sourceId,
                suspendedUntil,
                nextAction,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBoxNextAction"/>. </summary>
        /// <param name="scheduledTime"></param>
        /// <returns> A new <see cref="Models.DevBoxNextAction"/> instance for mocking. </returns>
        public static DevBoxNextAction DevBoxNextAction(DateTimeOffset scheduledTime = default)
        {
            return new DevBoxNextAction(scheduledTime, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevBoxActionDelayResult"/>. </summary>
        /// <param name="actionName"></param>
        /// <param name="delayStatus"></param>
        /// <param name="action"></param>
        /// <param name="error"></param>
        /// <returns> A new <see cref="Models.DevBoxActionDelayResult"/> instance for mocking. </returns>
        public static DevBoxActionDelayResult DevBoxActionDelayResult(string actionName = null, DevBoxActionDelayStatus delayStatus = default, DevBoxAction action = null, ResponseError error = null)
        {
            return new DevBoxActionDelayResult(actionName, delayStatus, action, error, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevCenterEnvironment"/>. </summary>
        /// <param name="parameters"></param>
        /// <param name="name"></param>
        /// <param name="environmentTypeName"></param>
        /// <param name="userId"></param>
        /// <param name="provisioningState"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="catalogName"></param>
        /// <param name="environmentDefinitionName"></param>
        /// <param name="error"></param>
        /// <returns> A new <see cref="Models.DevCenterEnvironment"/> instance for mocking. </returns>
        public static DevCenterEnvironment DevCenterEnvironment(IDictionary<string, BinaryData> parameters = null, string name = null, string environmentTypeName = null, Guid? userId = null, EnvironmentProvisioningState? provisioningState = null, ResourceIdentifier resourceGroupId = null, string catalogName = null, string environmentDefinitionName = null, ResponseError error = null)
        {
            parameters ??= new Dictionary<string, BinaryData>();

            return new DevCenterEnvironment(
                parameters,
                name,
                environmentTypeName,
                userId,
                provisioningState,
                resourceGroupId,
                catalogName,
                environmentDefinitionName,
                error,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevCenterCatalog"/>. </summary>
        /// <param name="name"></param>
        /// <returns> A new <see cref="Models.DevCenterCatalog"/> instance for mocking. </returns>
        public static DevCenterCatalog DevCenterCatalog(string name = null)
        {
            return new DevCenterCatalog(name, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.EnvironmentDefinition"/>. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="catalogName"></param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="parametersSchema"></param>
        /// <param name="templatePath"></param>
        /// <returns> A new <see cref="Models.EnvironmentDefinition"/> instance for mocking. </returns>
        public static EnvironmentDefinition EnvironmentDefinition(string id = null, string name = null, string catalogName = null, string description = null, IEnumerable<EnvironmentDefinitionParameter> parameters = null, string parametersSchema = null, string templatePath = null)
        {
            parameters ??= new List<EnvironmentDefinitionParameter>();

            return new EnvironmentDefinition(
                id,
                name,
                catalogName,
                description,
                parameters?.ToList(),
                parametersSchema,
                templatePath,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.EnvironmentDefinitionParameter"/>. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultValue"></param>
        /// <param name="parameterType"></param>
        /// <param name="readOnly"></param>
        /// <param name="required"></param>
        /// <param name="allowed"></param>
        /// <returns> A new <see cref="Models.EnvironmentDefinitionParameter"/> instance for mocking. </returns>
        public static EnvironmentDefinitionParameter EnvironmentDefinitionParameter(string id = null, string name = null, string description = null, string defaultValue = null, EnvironmentDefinitionParameterType parameterType = default, bool? readOnly = null, bool required = default, IEnumerable<string> allowed = null)
        {
            allowed ??= new List<string>();

            return new EnvironmentDefinitionParameter(
                id,
                name,
                description,
                defaultValue,
                parameterType,
                readOnly,
                required,
                allowed?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DevCenterEnvironmentType"/>. </summary>
        /// <param name="name"></param>
        /// <param name="deploymentTargetId"></param>
        /// <param name="status"></param>
        /// <returns> A new <see cref="Models.DevCenterEnvironmentType"/> instance for mocking. </returns>
        public static DevCenterEnvironmentType DevCenterEnvironmentType(string name = null, ResourceIdentifier deploymentTargetId = null, EnvironmentTypeStatus status = default)
        {
            return new DevCenterEnvironmentType(name, deploymentTargetId, status, serializedAdditionalRawData: null);
        }
    }
}
