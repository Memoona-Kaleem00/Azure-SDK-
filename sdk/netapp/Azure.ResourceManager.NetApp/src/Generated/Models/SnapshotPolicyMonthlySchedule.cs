// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Monthly Schedule properties. </summary>
    public partial class SnapshotPolicyMonthlySchedule
    {
        /// <summary> Initializes a new instance of <see cref="SnapshotPolicyMonthlySchedule"/>. </summary>
        public SnapshotPolicyMonthlySchedule()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotPolicyMonthlySchedule"/>. </summary>
        /// <param name="snapshotsToKeep"> Monthly snapshot count to keep. </param>
        /// <param name="daysOfMonth"> Indicates which days of the month snapshot should be taken. A comma delimited string. </param>
        /// <param name="hour"> Indicates which hour in UTC timezone a snapshot should be taken. </param>
        /// <param name="minute"> Indicates which minute snapshot should be taken. </param>
        /// <param name="usedBytes"> Resource size in bytes, current storage usage for the volume in bytes. </param>
        internal SnapshotPolicyMonthlySchedule(int? snapshotsToKeep, string daysOfMonth, int? hour, int? minute, long? usedBytes)
        {
            SnapshotsToKeep = snapshotsToKeep;
            DaysOfMonth = daysOfMonth;
            Hour = hour;
            Minute = minute;
            UsedBytes = usedBytes;
        }

        /// <summary> Monthly snapshot count to keep. </summary>
        public int? SnapshotsToKeep { get; set; }
        /// <summary> Indicates which days of the month snapshot should be taken. A comma delimited string. </summary>
        public string DaysOfMonth { get; set; }
        /// <summary> Indicates which hour in UTC timezone a snapshot should be taken. </summary>
        public int? Hour { get; set; }
        /// <summary> Indicates which minute snapshot should be taken. </summary>
        public int? Minute { get; set; }
        /// <summary> Resource size in bytes, current storage usage for the volume in bytes. </summary>
        public long? UsedBytes { get; set; }
    }
}
