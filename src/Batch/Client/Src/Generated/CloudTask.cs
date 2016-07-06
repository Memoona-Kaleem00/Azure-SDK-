//****************************************
// This file was autogenerated by a tool.
// Do not modify it.
//****************************************
namespace Microsoft.Azure.Batch
{
    using FileStaging;
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Batch task. A task is a piece of work that is associated with a job and runs on a compute node.
    /// </summary>
    public partial class CloudTask : ITransportObjectProvider<Models.TaskAddParameter>, IInheritedBehaviors, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<AffinityInformation> AffinityInformationProperty;
            public readonly PropertyAccessor<string> CommandLineProperty;
            public readonly PropertyAccessor<ComputeNodeInformation> ComputeNodeInformationProperty;
            public readonly PropertyAccessor<TaskConstraints> ConstraintsProperty;
            public readonly PropertyAccessor<DateTime?> CreationTimeProperty;
            public readonly PropertyAccessor<TaskDependencies> DependsOnProperty;
            public readonly PropertyAccessor<string> DisplayNameProperty;
            public readonly PropertyAccessor<IList<EnvironmentSetting>> EnvironmentSettingsProperty;
            public readonly PropertyAccessor<string> ETagProperty;
            public readonly PropertyAccessor<TaskExecutionInformation> ExecutionInformationProperty;
            public readonly PropertyAccessor<IList<IFileStagingProvider>> FilesToStageProperty;
            public readonly PropertyAccessor<string> IdProperty;
            public readonly PropertyAccessor<DateTime?> LastModifiedProperty;
            public readonly PropertyAccessor<MultiInstanceSettings> MultiInstanceSettingsProperty;
            public readonly PropertyAccessor<Common.TaskState?> PreviousStateProperty;
            public readonly PropertyAccessor<DateTime?> PreviousStateTransitionTimeProperty;
            public readonly PropertyAccessor<IList<ResourceFile>> ResourceFilesProperty;
            public readonly PropertyAccessor<bool?> RunElevatedProperty;
            public readonly PropertyAccessor<Common.TaskState?> StateProperty;
            public readonly PropertyAccessor<DateTime?> StateTransitionTimeProperty;
            public readonly PropertyAccessor<TaskStatistics> StatisticsProperty;
            public readonly PropertyAccessor<string> UrlProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.AffinityInformationProperty = this.CreatePropertyAccessor<AffinityInformation>("AffinityInformation", BindingAccess.Read | BindingAccess.Write);
                this.CommandLineProperty = this.CreatePropertyAccessor<string>("CommandLine", BindingAccess.Read | BindingAccess.Write);
                this.ComputeNodeInformationProperty = this.CreatePropertyAccessor<ComputeNodeInformation>("ComputeNodeInformation", BindingAccess.None);
                this.ConstraintsProperty = this.CreatePropertyAccessor<TaskConstraints>("Constraints", BindingAccess.Read | BindingAccess.Write);
                this.CreationTimeProperty = this.CreatePropertyAccessor<DateTime?>("CreationTime", BindingAccess.None);
                this.DependsOnProperty = this.CreatePropertyAccessor<TaskDependencies>("DependsOn", BindingAccess.Read | BindingAccess.Write);
                this.DisplayNameProperty = this.CreatePropertyAccessor<string>("DisplayName", BindingAccess.Read | BindingAccess.Write);
                this.EnvironmentSettingsProperty = this.CreatePropertyAccessor<IList<EnvironmentSetting>>("EnvironmentSettings", BindingAccess.Read | BindingAccess.Write);
                this.ETagProperty = this.CreatePropertyAccessor<string>("ETag", BindingAccess.None);
                this.ExecutionInformationProperty = this.CreatePropertyAccessor<TaskExecutionInformation>("ExecutionInformation", BindingAccess.None);
                this.FilesToStageProperty = this.CreatePropertyAccessor<IList<IFileStagingProvider>>("FilesToStage", BindingAccess.Read | BindingAccess.Write);
                this.IdProperty = this.CreatePropertyAccessor<string>("Id", BindingAccess.Read | BindingAccess.Write);
                this.LastModifiedProperty = this.CreatePropertyAccessor<DateTime?>("LastModified", BindingAccess.None);
                this.MultiInstanceSettingsProperty = this.CreatePropertyAccessor<MultiInstanceSettings>("MultiInstanceSettings", BindingAccess.Read | BindingAccess.Write);
                this.PreviousStateProperty = this.CreatePropertyAccessor<Common.TaskState?>("PreviousState", BindingAccess.None);
                this.PreviousStateTransitionTimeProperty = this.CreatePropertyAccessor<DateTime?>("PreviousStateTransitionTime", BindingAccess.None);
                this.ResourceFilesProperty = this.CreatePropertyAccessor<IList<ResourceFile>>("ResourceFiles", BindingAccess.Read | BindingAccess.Write);
                this.RunElevatedProperty = this.CreatePropertyAccessor<bool?>("RunElevated", BindingAccess.Read | BindingAccess.Write);
                this.StateProperty = this.CreatePropertyAccessor<Common.TaskState?>("State", BindingAccess.None);
                this.StateTransitionTimeProperty = this.CreatePropertyAccessor<DateTime?>("StateTransitionTime", BindingAccess.None);
                this.StatisticsProperty = this.CreatePropertyAccessor<TaskStatistics>("Statistics", BindingAccess.None);
                this.UrlProperty = this.CreatePropertyAccessor<string>("Url", BindingAccess.None);
            }

            public PropertyContainer(Models.CloudTask protocolObject) : base(BindingState.Bound)
            {
                this.AffinityInformationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.AffinityInfo, o => new AffinityInformation(o).Freeze()),
                    "AffinityInformation",
                    BindingAccess.Read);
                this.CommandLineProperty = this.CreatePropertyAccessor(
                    protocolObject.CommandLine,
                    "CommandLine",
                    BindingAccess.Read);
                this.ComputeNodeInformationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.NodeInfo, o => new ComputeNodeInformation(o).Freeze()),
                    "ComputeNodeInformation",
                    BindingAccess.Read);
                this.ConstraintsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Constraints, o => new TaskConstraints(o)),
                    "Constraints",
                    BindingAccess.Read | BindingAccess.Write);
                this.CreationTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.CreationTime,
                    "CreationTime",
                    BindingAccess.Read);
                this.DependsOnProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.DependsOn, o => new TaskDependencies(o).Freeze()),
                    "DependsOn",
                    BindingAccess.Read);
                this.DisplayNameProperty = this.CreatePropertyAccessor(
                    protocolObject.DisplayName,
                    "DisplayName",
                    BindingAccess.Read);
                this.EnvironmentSettingsProperty = this.CreatePropertyAccessor(
                    EnvironmentSetting.ConvertFromProtocolCollectionAndFreeze(protocolObject.EnvironmentSettings),
                    "EnvironmentSettings",
                    BindingAccess.Read);
                this.ETagProperty = this.CreatePropertyAccessor(
                    protocolObject.ETag,
                    "ETag",
                    BindingAccess.Read);
                this.ExecutionInformationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ExecutionInfo, o => new TaskExecutionInformation(o).Freeze()),
                    "ExecutionInformation",
                    BindingAccess.Read);
                this.FilesToStageProperty = this.CreatePropertyAccessor<IList<IFileStagingProvider>>(
                    "FilesToStage",
                    BindingAccess.None);
                this.IdProperty = this.CreatePropertyAccessor(
                    protocolObject.Id,
                    "Id",
                    BindingAccess.Read);
                this.LastModifiedProperty = this.CreatePropertyAccessor(
                    protocolObject.LastModified,
                    "LastModified",
                    BindingAccess.Read);
                this.MultiInstanceSettingsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.MultiInstanceSettings, o => new MultiInstanceSettings(o).Freeze()),
                    "MultiInstanceSettings",
                    BindingAccess.Read);
                this.PreviousStateProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapNullableEnum<Common.TaskState>(protocolObject.PreviousState),
                    "PreviousState",
                    BindingAccess.Read);
                this.PreviousStateTransitionTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.PreviousStateTransitionTime,
                    "PreviousStateTransitionTime",
                    BindingAccess.Read);
                this.ResourceFilesProperty = this.CreatePropertyAccessor(
                    ResourceFile.ConvertFromProtocolCollectionAndFreeze(protocolObject.ResourceFiles),
                    "ResourceFiles",
                    BindingAccess.Read);
                this.RunElevatedProperty = this.CreatePropertyAccessor(
                    protocolObject.RunElevated,
                    "RunElevated",
                    BindingAccess.Read);
                this.StateProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapNullableEnum<Common.TaskState>(protocolObject.State),
                    "State",
                    BindingAccess.Read);
                this.StateTransitionTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.StateTransitionTime,
                    "StateTransitionTime",
                    BindingAccess.Read);
                this.StatisticsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Stats, o => new TaskStatistics(o).Freeze()),
                    "Statistics",
                    BindingAccess.Read);
                this.UrlProperty = this.CreatePropertyAccessor(
                    protocolObject.Url,
                    "Url",
                    BindingAccess.Read);
            }
        }

        private PropertyContainer propertyContainer;

        private readonly BatchClient parentBatchClient;
        private readonly string parentJobId;

        internal string ParentJobId
        {
            get
            {
                return this.parentJobId;
            }
        }

        #region Constructors

        internal CloudTask(
            BatchClient parentBatchClient,
            string parentJobId,
            Models.CloudTask protocolObject,
            IEnumerable<BatchClientBehavior> baseBehaviors)
        {
            this.parentJobId = parentJobId;
            this.parentBatchClient = parentBatchClient;
            InheritUtil.InheritClientBehaviorsAndSetPublicProperty(this, baseBehaviors);
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region IInheritedBehaviors

        /// <summary>
        /// Gets or sets a list of behaviors that modify or customize requests to the Batch service
        /// made via this <see cref="CloudTask"/>.
        /// </summary>
        /// <remarks>
        /// <para>These behaviors are inherited by child objects.</para>
        /// <para>Modifications are applied in the order of the collection. The last write wins.</para>
        /// </remarks>
        public IList<BatchClientBehavior> CustomBehaviors { get; set; }

        #endregion IInheritedBehaviors

        #region CloudTask

        /// <summary>
        /// Gets or sets a locality hint that can be used by the Batch service to select a node on which to start the task.
        /// </summary>
        public AffinityInformation AffinityInformation
        {
            get { return this.propertyContainer.AffinityInformationProperty.Value; }
            set { this.propertyContainer.AffinityInformationProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the command line of the task.
        /// </summary>
        /// <remarks>
        /// The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment 
        /// variable expansion. If you want to take advantage of such features, you should invoke the shell in the command 
        /// line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux.
        /// </remarks>
        public string CommandLine
        {
            get { return this.propertyContainer.CommandLineProperty.Value; }
            set { this.propertyContainer.CommandLineProperty.Value = value; }
        }

        /// <summary>
        /// Gets information about the compute node on which the task ran.
        /// </summary>
        public ComputeNodeInformation ComputeNodeInformation
        {
            get { return this.propertyContainer.ComputeNodeInformationProperty.Value; }
        }

        /// <summary>
        /// Gets or sets the execution constraints that apply to this task.
        /// </summary>
        public TaskConstraints Constraints
        {
            get { return this.propertyContainer.ConstraintsProperty.Value; }
            set { this.propertyContainer.ConstraintsProperty.Value = value; }
        }

        /// <summary>
        /// Gets the creation time of the task.
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this.propertyContainer.CreationTimeProperty.Value; }
        }

        /// <summary>
        /// Gets or sets any other tasks that this <see cref="CloudTask"/> depends on. The task will not be scheduled until 
        /// all depended-on tasks have completed successfully.
        /// </summary>
        /// <remarks>
        /// The job must set <see cref="CloudJob.UsesTaskDependencies"/> to true in order to use task dependencies. If UsesTaskDependencies 
        /// is false (the default), adding a task with dependencies will fail with an error.
        /// </remarks>
        public TaskDependencies DependsOn
        {
            get { return this.propertyContainer.DependsOnProperty.Value; }
            set { this.propertyContainer.DependsOnProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the display name of the task.
        /// </summary>
        public string DisplayName
        {
            get { return this.propertyContainer.DisplayNameProperty.Value; }
            set { this.propertyContainer.DisplayNameProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of environment variable settings for the task.
        /// </summary>
        public IList<EnvironmentSetting> EnvironmentSettings
        {
            get { return this.propertyContainer.EnvironmentSettingsProperty.Value; }
            set
            {
                this.propertyContainer.EnvironmentSettingsProperty.Value = ConcurrentChangeTrackedModifiableList<EnvironmentSetting>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets the ETag for the task.
        /// </summary>
        public string ETag
        {
            get { return this.propertyContainer.ETagProperty.Value; }
        }

        /// <summary>
        /// Gets the execution information for the task.
        /// </summary>
        public TaskExecutionInformation ExecutionInformation
        {
            get { return this.propertyContainer.ExecutionInformationProperty.Value; }
        }

        /// <summary>
        /// Gets or sets a list of files to be staged for the task.
        /// </summary>
        public IList<IFileStagingProvider> FilesToStage
        {
            get { return this.propertyContainer.FilesToStageProperty.Value; }
            set
            {
                this.propertyContainer.FilesToStageProperty.Value = ConcurrentChangeTrackedList<IFileStagingProvider>.TransformEnumerableToConcurrentList(value);
            }
        }

        /// <summary>
        /// Gets or sets the id of the task.
        /// </summary>
        public string Id
        {
            get { return this.propertyContainer.IdProperty.Value; }
            set { this.propertyContainer.IdProperty.Value = value; }
        }

        /// <summary>
        /// Gets the last modified time of the task.
        /// </summary>
        public DateTime? LastModified
        {
            get { return this.propertyContainer.LastModifiedProperty.Value; }
        }

        /// <summary>
        /// Gets or sets information about how to run the multi-instance task.
        /// </summary>
        public MultiInstanceSettings MultiInstanceSettings
        {
            get { return this.propertyContainer.MultiInstanceSettingsProperty.Value; }
            set { this.propertyContainer.MultiInstanceSettingsProperty.Value = value; }
        }

        /// <summary>
        /// Gets the previous state of the task.
        /// </summary>
        /// <remarks>
        /// If the task is in its initial <see cref="Common.TaskState.Active"/> state, the PreviousState property is not 
        /// defined.
        /// </remarks>
        public Common.TaskState? PreviousState
        {
            get { return this.propertyContainer.PreviousStateProperty.Value; }
        }

        /// <summary>
        /// Gets the time at which the task entered its previous state.
        /// </summary>
        /// <remarks>
        /// If the task is in its initial <see cref="Common.TaskState.Active"/> state, the PreviousStateTransitionTime property 
        /// is not defined.
        /// </remarks>
        public DateTime? PreviousStateTransitionTime
        {
            get { return this.propertyContainer.PreviousStateTransitionTimeProperty.Value; }
        }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download to the compute node before running the command 
        /// line.
        /// </summary>
        public IList<ResourceFile> ResourceFiles
        {
            get { return this.propertyContainer.ResourceFilesProperty.Value; }
            set
            {
                this.propertyContainer.ResourceFilesProperty.Value = ConcurrentChangeTrackedModifiableList<ResourceFile>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets whether to run the task in elevated mode.
        /// </summary>
        public bool? RunElevated
        {
            get { return this.propertyContainer.RunElevatedProperty.Value; }
            set { this.propertyContainer.RunElevatedProperty.Value = value; }
        }

        /// <summary>
        /// Gets the current state of the task.
        /// </summary>
        public Common.TaskState? State
        {
            get { return this.propertyContainer.StateProperty.Value; }
        }

        /// <summary>
        /// Gets the time at which the task entered its current state.
        /// </summary>
        public DateTime? StateTransitionTime
        {
            get { return this.propertyContainer.StateTransitionTimeProperty.Value; }
        }

        /// <summary>
        /// Gets resource usage statistics for the task.
        /// </summary>
        /// <remarks>
        /// This property is populated only if the <see cref="CloudTask"/> was retrieved with an <see cref="ODATADetailLevel.ExpandClause"/> 
        /// including the 'stats' attribute; otherwise it is null.
        /// </remarks>
        public TaskStatistics Statistics
        {
            get { return this.propertyContainer.StatisticsProperty.Value; }
        }

        /// <summary>
        /// Gets the URL of the task.
        /// </summary>
        public string Url
        {
            get { return this.propertyContainer.UrlProperty.Value; }
        }

        #endregion // CloudTask

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

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.TaskAddParameter ITransportObjectProvider<Models.TaskAddParameter>.GetTransportObject()
        {
            Models.TaskAddParameter result = new Models.TaskAddParameter()
            {
                AffinityInfo = UtilitiesInternal.CreateObjectWithNullCheck(this.AffinityInformation, (o) => o.GetTransportObject()),
                CommandLine = this.CommandLine,
                Constraints = UtilitiesInternal.CreateObjectWithNullCheck(this.Constraints, (o) => o.GetTransportObject()),
                DependsOn = UtilitiesInternal.CreateObjectWithNullCheck(this.DependsOn, (o) => o.GetTransportObject()),
                DisplayName = this.DisplayName,
                EnvironmentSettings = UtilitiesInternal.ConvertToProtocolCollection(this.EnvironmentSettings),
                Id = this.Id,
                MultiInstanceSettings = UtilitiesInternal.CreateObjectWithNullCheck(this.MultiInstanceSettings, (o) => o.GetTransportObject()),
                ResourceFiles = UtilitiesInternal.ConvertToProtocolCollection(this.ResourceFiles),
                RunElevated = this.RunElevated,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}