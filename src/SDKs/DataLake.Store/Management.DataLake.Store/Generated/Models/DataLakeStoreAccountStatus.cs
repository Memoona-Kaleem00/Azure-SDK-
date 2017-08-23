// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Store;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DataLakeStoreAccountStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataLakeStoreAccountStatus
    {
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Creating")]
        Creating,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Patching")]
        Patching,
        [EnumMember(Value = "Suspending")]
        Suspending,
        [EnumMember(Value = "Resuming")]
        Resuming,
        [EnumMember(Value = "Deleting")]
        Deleting,
        [EnumMember(Value = "Deleted")]
        Deleted
    }
    internal static class DataLakeStoreAccountStatusEnumExtension
    {
        internal static string ToSerializedValue(this DataLakeStoreAccountStatus? value)  =>
            value == null ? null : ((DataLakeStoreAccountStatus)value).ToSerializedValue();

        internal static string ToSerializedValue(this DataLakeStoreAccountStatus value)
        {
            switch( value )
            {
                case DataLakeStoreAccountStatus.Failed:
                    return "Failed";
                case DataLakeStoreAccountStatus.Creating:
                    return "Creating";
                case DataLakeStoreAccountStatus.Running:
                    return "Running";
                case DataLakeStoreAccountStatus.Succeeded:
                    return "Succeeded";
                case DataLakeStoreAccountStatus.Patching:
                    return "Patching";
                case DataLakeStoreAccountStatus.Suspending:
                    return "Suspending";
                case DataLakeStoreAccountStatus.Resuming:
                    return "Resuming";
                case DataLakeStoreAccountStatus.Deleting:
                    return "Deleting";
                case DataLakeStoreAccountStatus.Deleted:
                    return "Deleted";
            }
            return null;
        }

        internal static DataLakeStoreAccountStatus? ParseDataLakeStoreAccountStatus(this string value)
        {
            switch( value )
            {
                case "Failed":
                    return DataLakeStoreAccountStatus.Failed;
                case "Creating":
                    return DataLakeStoreAccountStatus.Creating;
                case "Running":
                    return DataLakeStoreAccountStatus.Running;
                case "Succeeded":
                    return DataLakeStoreAccountStatus.Succeeded;
                case "Patching":
                    return DataLakeStoreAccountStatus.Patching;
                case "Suspending":
                    return DataLakeStoreAccountStatus.Suspending;
                case "Resuming":
                    return DataLakeStoreAccountStatus.Resuming;
                case "Deleting":
                    return DataLakeStoreAccountStatus.Deleting;
                case "Deleted":
                    return DataLakeStoreAccountStatus.Deleted;
            }
            return null;
        }
    }
}
