// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// Scheduling properties of a job.
/// </summary>
public partial class SqlServerJobSchedule : ProvisioningConstruct
{
    /// <summary>
    /// Schedule start time.
    /// </summary>
    public BicepValue<DateTimeOffset> StartOn { get => _startOn; set => _startOn.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _startOn;

    /// <summary>
    /// Schedule end time.
    /// </summary>
    public BicepValue<DateTimeOffset> EndOn { get => _endOn; set => _endOn.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _endOn;

    /// <summary>
    /// Schedule interval type.
    /// </summary>
    public BicepValue<SqlServerJobScheduleType> ScheduleType { get => _scheduleType; set => _scheduleType.Assign(value); }
    private readonly BicepValue<SqlServerJobScheduleType> _scheduleType;

    /// <summary>
    /// Whether or not the schedule is enabled.
    /// </summary>
    public BicepValue<bool> IsEnabled { get => _isEnabled; set => _isEnabled.Assign(value); }
    private readonly BicepValue<bool> _isEnabled;

    /// <summary>
    /// Value of the schedule&apos;s recurring interval, if the ScheduleType is
    /// recurring. ISO8601 duration format.
    /// </summary>
    public BicepValue<TimeSpan> Interval { get => _interval; set => _interval.Assign(value); }
    private readonly BicepValue<TimeSpan> _interval;

    /// <summary>
    /// Creates a new SqlServerJobSchedule.
    /// </summary>
    public SqlServerJobSchedule()
    {
        _startOn = BicepValue<DateTimeOffset>.DefineProperty(this, "StartOn", ["startTime"]);
        _endOn = BicepValue<DateTimeOffset>.DefineProperty(this, "EndOn", ["endTime"]);
        _scheduleType = BicepValue<SqlServerJobScheduleType>.DefineProperty(this, "ScheduleType", ["type"]);
        _isEnabled = BicepValue<bool>.DefineProperty(this, "IsEnabled", ["enabled"]);
        _interval = BicepValue<TimeSpan>.DefineProperty(this, "Interval", ["interval"]);
    }
}
