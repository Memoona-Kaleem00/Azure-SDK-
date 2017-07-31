// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Summarizes the state of a compute node.
    /// </summary>
    public partial class ComputeNode : IInheritedBehaviors, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<string> AffinityIdProperty;
            public readonly PropertyAccessor<DateTime?> AllocationTimeProperty;
            public readonly PropertyAccessor<IReadOnlyList<CertificateReference>> CertificateReferencesProperty;
            public readonly PropertyAccessor<ComputeNodeEndpointConfiguration> EndpointConfigurationProperty;
            public readonly PropertyAccessor<IReadOnlyList<ComputeNodeError>> ErrorsProperty;
            public readonly PropertyAccessor<string> IdProperty;
            public readonly PropertyAccessor<string> IPAddressProperty;
            public readonly PropertyAccessor<bool?> IsDedicatedProperty;
            public readonly PropertyAccessor<DateTime?> LastBootTimeProperty;
            public readonly PropertyAccessor<IReadOnlyList<TaskInformation>> RecentTasksProperty;
            public readonly PropertyAccessor<int?> RunningTasksCountProperty;
            public readonly PropertyAccessor<Common.SchedulingState?> SchedulingStateProperty;
            public readonly PropertyAccessor<StartTask> StartTaskProperty;
            public readonly PropertyAccessor<StartTaskInformation> StartTaskInformationProperty;
            public readonly PropertyAccessor<Common.ComputeNodeState?> StateProperty;
            public readonly PropertyAccessor<DateTime?> StateTransitionTimeProperty;
            public readonly PropertyAccessor<int?> TotalTasksRunProperty;
            public readonly PropertyAccessor<int?> TotalTasksSucceededProperty;
            public readonly PropertyAccessor<string> UrlProperty;
            public readonly PropertyAccessor<string> VirtualMachineSizeProperty;
            public PropertyContainer(Models.ComputeNode protocolObject) : base(BindingState.Bound)
            {
                this.AffinityIdProperty = this.CreatePropertyAccessor(
                    protocolObject.AffinityId,
                    "AffinityId",
                    BindingAccess.Read);
                this.AllocationTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.AllocationTime,
                    "AllocationTime",
                    BindingAccess.Read);
                this.CertificateReferencesProperty = this.CreatePropertyAccessor(
                    CertificateReference.ConvertFromProtocolCollectionReadOnly(protocolObject.CertificateReferences),
                    "CertificateReferences",
                    BindingAccess.Read);
                this.EndpointConfigurationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.EndpointConfiguration, o => new ComputeNodeEndpointConfiguration(o).Freeze()),
                    "EndpointConfiguration",
                    BindingAccess.Read);
                this.ErrorsProperty = this.CreatePropertyAccessor(
                    ComputeNodeError.ConvertFromProtocolCollectionReadOnly(protocolObject.Errors),
                    "Errors",
                    BindingAccess.Read);
                this.IdProperty = this.CreatePropertyAccessor(
                    protocolObject.Id,
                    "Id",
                    BindingAccess.Read);
                this.IPAddressProperty = this.CreatePropertyAccessor(
                    protocolObject.IpAddress,
                    "IPAddress",
                    BindingAccess.Read);
                this.IsDedicatedProperty = this.CreatePropertyAccessor(
                    protocolObject.IsDedicated,
                    "IsDedicated",
                    BindingAccess.Read);
                this.LastBootTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.LastBootTime,
                    "LastBootTime",
                    BindingAccess.Read);
                this.RecentTasksProperty = this.CreatePropertyAccessor(
                    TaskInformation.ConvertFromProtocolCollectionReadOnly(protocolObject.RecentTasks),
                    "RecentTasks",
                    BindingAccess.Read);
                this.RunningTasksCountProperty = this.CreatePropertyAccessor(
                    protocolObject.RunningTasksCount,
                    "RunningTasksCount",
                    BindingAccess.Read);
                this.SchedulingStateProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapNullableEnum<Models.SchedulingState, Common.SchedulingState>(protocolObject.SchedulingState),
                    "SchedulingState",
                    BindingAccess.Read);
                this.StartTaskProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.StartTask, o => new StartTask(o).Freeze()),
                    "StartTask",
                    BindingAccess.Read);
                this.StartTaskInformationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.StartTaskInfo, o => new StartTaskInformation(o).Freeze()),
                    "StartTaskInformation",
                    BindingAccess.Read);
                this.StateProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapNullableEnum<Models.ComputeNodeState, Common.ComputeNodeState>(protocolObject.State),
                    "State",
                    BindingAccess.Read);
                this.StateTransitionTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.StateTransitionTime,
                    "StateTransitionTime",
                    BindingAccess.Read);
                this.TotalTasksRunProperty = this.CreatePropertyAccessor(
                    protocolObject.TotalTasksRun,
                    "TotalTasksRun",
                    BindingAccess.Read);
                this.TotalTasksSucceededProperty = this.CreatePropertyAccessor(
                    protocolObject.TotalTasksSucceeded,
                    "TotalTasksSucceeded",
                    BindingAccess.Read);
                this.UrlProperty = this.CreatePropertyAccessor(
                    protocolObject.Url,
                    "Url",
                    BindingAccess.Read);
                this.VirtualMachineSizeProperty = this.CreatePropertyAccessor(
                    protocolObject.VmSize,
                    "VirtualMachineSize",
                    BindingAccess.Read);
            }
        }

        private PropertyContainer propertyContainer;

        private readonly BatchClient parentBatchClient;
        private readonly string parentPoolId;

        internal string ParentPoolId
        {
            get
            {
                return this.parentPoolId;
            }
        }

        #region Constructors

        internal ComputeNode(
            BatchClient parentBatchClient,
            string parentPoolId,
            Models.ComputeNode protocolObject,
            IEnumerable<BatchClientBehavior> baseBehaviors)
        {
            this.parentPoolId = parentPoolId;
            this.parentBatchClient = parentBatchClient;
            InheritUtil.InheritClientBehaviorsAndSetPublicProperty(this, baseBehaviors);
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region IInheritedBehaviors

        /// <summary>
        /// Gets or sets a list of behaviors that modify or customize requests to the Batch service
        /// made via this <see cref="ComputeNode"/>.
        /// </summary>
        /// <remarks>
        /// <para>These behaviors are inherited by child objects.</para>
        /// <para>Modifications are applied in the order of the collection. The last write wins.</para>
        /// </remarks>
        public IList<BatchClientBehavior> CustomBehaviors { get; set; }

        #endregion IInheritedBehaviors

        #region ComputeNode

        /// <summary>
        /// Gets an opaque string that contains information about the location of the compute node.
        /// </summary>
        public string AffinityId
        {
            get { return this.propertyContainer.AffinityIdProperty.Value; }
        }

        /// <summary>
        /// Gets the time at which this compute node was allocated to the pool.
        /// </summary>
        public DateTime? AllocationTime
        {
            get { return this.propertyContainer.AllocationTimeProperty.Value; }
        }

        /// <summary>
        /// Gets the list of certificates installed on this compute node. 
        /// </summary>
        public IReadOnlyList<CertificateReference> CertificateReferences
        {
            get { return this.propertyContainer.CertificateReferencesProperty.Value; }
        }

        /// <summary>
        /// Gets the endpoint configuration for the compute node.
        /// </summary>
        public ComputeNodeEndpointConfiguration EndpointConfiguration
        {
            get { return this.propertyContainer.EndpointConfigurationProperty.Value; }
        }

        /// <summary>
        /// Gets the list of errors that are currently being encountered by the compute node.
        /// </summary>
        public IReadOnlyList<ComputeNodeError> Errors
        {
            get { return this.propertyContainer.ErrorsProperty.Value; }
        }

        /// <summary>
        /// Gets the id of compute node.
        /// </summary>
        public string Id
        {
            get { return this.propertyContainer.IdProperty.Value; }
        }

        /// <summary>
        /// Gets the IP address associated with the compute node.
        /// </summary>
        public string IPAddress
        {
            get { return this.propertyContainer.IPAddressProperty.Value; }
        }

        /// <summary>
        /// Gets whether this compute node is a dedicated node. If false, the node is a low-priority node.
        /// </summary>
        public bool? IsDedicated
        {
            get { return this.propertyContainer.IsDedicatedProperty.Value; }
        }

        /// <summary>
        /// Gets the time at which the compute node was started.
        /// </summary>
        public DateTime? LastBootTime
        {
            get { return this.propertyContainer.LastBootTimeProperty.Value; }
        }

        /// <summary>
        /// Gets the execution information for the most recent tasks that ran on this compute node. Note that this element 
        /// is only returned if at least one task was run on this compute node since the time it was assigned to its current 
        /// pool.
        /// </summary>
        public IReadOnlyList<TaskInformation> RecentTasks
        {
            get { return this.propertyContainer.RecentTasksProperty.Value; }
        }

        /// <summary>
        /// Gets the total number of currently running tasks on the compute node. This includes Job Preparation, Job Release, 
        /// and Job Manager tasks, but not the pool start task.
        /// </summary>
        public int? RunningTasksCount
        {
            get { return this.propertyContainer.RunningTasksCountProperty.Value; }
        }

        /// <summary>
        /// Gets whether the node is available for task scheduling.
        /// </summary>
        public Common.SchedulingState? SchedulingState
        {
            get { return this.propertyContainer.SchedulingStateProperty.Value; }
        }

        /// <summary>
        /// Gets the start task associated with all compute nodes in this pool.
        /// </summary>
        public StartTask StartTask
        {
            get { return this.propertyContainer.StartTaskProperty.Value; }
        }

        /// <summary>
        /// Gets the detailed runtime information of the start task, including current state, error details, exit code, start 
        /// time, end time, etc.
        /// </summary>
        public StartTaskInformation StartTaskInformation
        {
            get { return this.propertyContainer.StartTaskInformationProperty.Value; }
        }

        /// <summary>
        /// Gets the current state of the compute node.
        /// </summary>
        public Common.ComputeNodeState? State
        {
            get { return this.propertyContainer.StateProperty.Value; }
        }

        /// <summary>
        /// Gets the time at which the compute node entered the current state.
        /// </summary>
        public DateTime? StateTransitionTime
        {
            get { return this.propertyContainer.StateTransitionTimeProperty.Value; }
        }

        /// <summary>
        /// Gets the number of tasks that have been run on this compute node from the time it was allocated to this pool. 
        /// This includes Job Preparation, Job Release, and Job Manager tasks, but not the pool start task.
        /// </summary>
        public int? TotalTasksRun
        {
            get { return this.propertyContainer.TotalTasksRunProperty.Value; }
        }

        /// <summary>
        /// Gets the total number of tasks which completed successfully (with exitCode 0) on the compute node. This includes 
        /// Job Preparation, Job Release, and Job Manager tasks, but not the pool start task.
        /// </summary>
        public int? TotalTasksSucceeded
        {
            get { return this.propertyContainer.TotalTasksSucceededProperty.Value; }
        }

        /// <summary>
        /// Gets the URL of compute node.
        /// </summary>
        public string Url
        {
            get { return this.propertyContainer.UrlProperty.Value; }
        }

        /// <summary>
        /// Gets the size of the virtual machine hosting the compute node.
        /// </summary>
        public string VirtualMachineSize
        {
            get { return this.propertyContainer.VirtualMachineSizeProperty.Value; }
        }

        #endregion // ComputeNode

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

    }
}