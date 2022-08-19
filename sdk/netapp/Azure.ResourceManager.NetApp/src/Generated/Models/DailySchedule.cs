// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Daily Schedule properties. </summary>
    public partial class DailySchedule
    {
        /// <summary> Initializes a new instance of DailySchedule. </summary>
        public DailySchedule()
        {
        }

        /// <summary> Initializes a new instance of DailySchedule. </summary>
        /// <param name="snapshotsToKeep"> Daily snapshot count to keep. </param>
        /// <param name="hour"> Indicates which hour in UTC timezone a snapshot should be taken. </param>
        /// <param name="minute"> Indicates which minute snapshot should be taken. </param>
        /// <param name="usedBytes"> Resource size in bytes, current storage usage for the volume in bytes. </param>
        internal DailySchedule(int? snapshotsToKeep, int? hour, int? minute, long? usedBytes)
        {
            SnapshotsToKeep = snapshotsToKeep;
            Hour = hour;
            Minute = minute;
            UsedBytes = usedBytes;
        }

        /// <summary> Daily snapshot count to keep. </summary>
        public int? SnapshotsToKeep { get; set; }
        /// <summary> Indicates which hour in UTC timezone a snapshot should be taken. </summary>
        public int? Hour { get; set; }
        /// <summary> Indicates which minute snapshot should be taken. </summary>
        public int? Minute { get; set; }
        /// <summary> Resource size in bytes, current storage usage for the volume in bytes. </summary>
        public long? UsedBytes { get; set; }
    }
}
