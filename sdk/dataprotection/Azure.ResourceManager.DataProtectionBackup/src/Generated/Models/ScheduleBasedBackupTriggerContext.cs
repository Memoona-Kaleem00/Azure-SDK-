// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Schedule based trigger context. </summary>
    public partial class ScheduleBasedBackupTriggerContext : DataProtectionBackupTriggerContext
    {
        /// <summary> Initializes a new instance of <see cref="ScheduleBasedBackupTriggerContext"/>. </summary>
        /// <param name="schedule"> Schedule for this backup. </param>
        /// <param name="taggingCriteriaList"> List of tags that can be applicable for given schedule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schedule"/> or <paramref name="taggingCriteriaList"/> is null. </exception>
        public ScheduleBasedBackupTriggerContext(DataProtectionBackupSchedule schedule, IEnumerable<DataProtectionBackupTaggingCriteria> taggingCriteriaList)
        {
            Argument.AssertNotNull(schedule, nameof(schedule));
            Argument.AssertNotNull(taggingCriteriaList, nameof(taggingCriteriaList));

            Schedule = schedule;
            TaggingCriteriaList = taggingCriteriaList.ToList();
            ObjectType = "ScheduleBasedTriggerContext";
        }

        /// <summary> Initializes a new instance of <see cref="ScheduleBasedBackupTriggerContext"/>. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="schedule"> Schedule for this backup. </param>
        /// <param name="taggingCriteriaList"> List of tags that can be applicable for given schedule. </param>
        internal ScheduleBasedBackupTriggerContext(string objectType, DataProtectionBackupSchedule schedule, IList<DataProtectionBackupTaggingCriteria> taggingCriteriaList) : base(objectType)
        {
            Schedule = schedule;
            TaggingCriteriaList = taggingCriteriaList;
            ObjectType = objectType ?? "ScheduleBasedTriggerContext";
        }

        /// <summary> Schedule for this backup. </summary>
        public DataProtectionBackupSchedule Schedule { get; set; }
        /// <summary> List of tags that can be applicable for given schedule. </summary>
        public IList<DataProtectionBackupTaggingCriteria> TaggingCriteriaList { get; }
    }
}
