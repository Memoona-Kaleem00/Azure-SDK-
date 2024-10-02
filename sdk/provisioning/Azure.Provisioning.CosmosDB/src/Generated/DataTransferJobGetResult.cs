// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// DataTransferJobGetResult.
/// </summary>
public partial class DataTransferJobGetResult : Resource
{
    /// <summary>
    /// Name of the Data Transfer Job.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Data Transfer Create Job Properties.
    /// </summary>
    public BicepValue<DataTransferJobProperties> Properties { get => _properties; set => _properties.Assign(value); }
    private readonly BicepValue<DataTransferJobProperties> _properties;

    /// <summary>
    /// Destination DataStore details             Please note
    /// Azure.ResourceManager.CosmosDB.Models.DataTransferDataSourceSink is
    /// the base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.CosmosDB.Models.AzureBlobDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.BaseCosmosDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.CosmosCassandraDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.CosmosMongoDataTransferDataSourceSink
    /// and
    /// Azure.ResourceManager.CosmosDB.Models.CosmosSqlDataTransferDataSourceSink.
    /// </summary>
    public BicepValue<DataTransferDataSourceSink> Destination { get => _destination; }
    private readonly BicepValue<DataTransferDataSourceSink> _destination;

    /// <summary>
    /// Total Duration of Job.
    /// </summary>
    public BicepValue<TimeSpan> Duration { get => _duration; }
    private readonly BicepValue<TimeSpan> _duration;

    /// <summary>
    /// Error response for Faulted job.
    /// </summary>
    public BicepValue<ErrorResponse> Error { get => _error; }
    private readonly BicepValue<ErrorResponse> _error;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Job Name.
    /// </summary>
    public BicepValue<string> JobName { get => _jobName; }
    private readonly BicepValue<string> _jobName;

    /// <summary>
    /// Last Updated Time (ISO-8601 format).
    /// </summary>
    public BicepValue<DateTimeOffset> LastUpdatedUtcOn { get => _lastUpdatedUtcOn; }
    private readonly BicepValue<DateTimeOffset> _lastUpdatedUtcOn;

    /// <summary>
    /// Mode of job execution.
    /// </summary>
    public BicepValue<DataTransferJobMode> Mode { get => _mode; }
    private readonly BicepValue<DataTransferJobMode> _mode;

    /// <summary>
    /// Processed Count.
    /// </summary>
    public BicepValue<long> ProcessedCount { get => _processedCount; }
    private readonly BicepValue<long> _processedCount;

    /// <summary>
    /// Source DataStore details             Please note
    /// Azure.ResourceManager.CosmosDB.Models.DataTransferDataSourceSink is
    /// the base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.CosmosDB.Models.AzureBlobDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.BaseCosmosDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.CosmosCassandraDataTransferDataSourceSink,
    /// Azure.ResourceManager.CosmosDB.Models.CosmosMongoDataTransferDataSourceSink
    /// and
    /// Azure.ResourceManager.CosmosDB.Models.CosmosSqlDataTransferDataSourceSink.
    /// </summary>
    public BicepValue<DataTransferDataSourceSink> Source { get => _source; }
    private readonly BicepValue<DataTransferDataSourceSink> _source;

    /// <summary>
    /// Job Status.
    /// </summary>
    public BicepValue<string> Status { get => _status; }
    private readonly BicepValue<string> _status;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Total Count.
    /// </summary>
    public BicepValue<long> TotalCount { get => _totalCount; }
    private readonly BicepValue<long> _totalCount;

    /// <summary>
    /// Worker count.
    /// </summary>
    public BicepValue<int> WorkerCount { get => _workerCount; }
    private readonly BicepValue<int> _workerCount;

    /// <summary>
    /// Gets or sets a reference to the parent CosmosDBAccount.
    /// </summary>
    public CosmosDBAccount? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<CosmosDBAccount> _parent;

    /// <summary>
    /// Creates a new DataTransferJobGetResult.
    /// </summary>
    /// <param name="resourceName">Name of the DataTransferJobGetResult.</param>
    /// <param name="resourceVersion">Version of the DataTransferJobGetResult.</param>
    public DataTransferJobGetResult(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.DocumentDB/databaseAccounts/dataTransferJobs", resourceVersion ?? "2024-08-15")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _properties = BicepValue<DataTransferJobProperties>.DefineProperty(this, "Properties", ["properties"], isRequired: true);
        _destination = BicepValue<DataTransferDataSourceSink>.DefineProperty(this, "Destination", ["properties", "destination"], isOutput: true);
        _duration = BicepValue<TimeSpan>.DefineProperty(this, "Duration", ["properties", "duration"], isOutput: true);
        _error = BicepValue<ErrorResponse>.DefineProperty(this, "Error", ["properties", "error"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _jobName = BicepValue<string>.DefineProperty(this, "JobName", ["properties", "jobName"], isOutput: true);
        _lastUpdatedUtcOn = BicepValue<DateTimeOffset>.DefineProperty(this, "LastUpdatedUtcOn", ["properties", "lastUpdatedUtcTime"], isOutput: true);
        _mode = BicepValue<DataTransferJobMode>.DefineProperty(this, "Mode", ["properties", "mode"], isOutput: true);
        _processedCount = BicepValue<long>.DefineProperty(this, "ProcessedCount", ["properties", "processedCount"], isOutput: true);
        _source = BicepValue<DataTransferDataSourceSink>.DefineProperty(this, "Source", ["properties", "source"], isOutput: true);
        _status = BicepValue<string>.DefineProperty(this, "Status", ["properties", "status"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _totalCount = BicepValue<long>.DefineProperty(this, "TotalCount", ["properties", "totalCount"], isOutput: true);
        _workerCount = BicepValue<int>.DefineProperty(this, "WorkerCount", ["properties", "workerCount"], isOutput: true);
        _parent = ResourceReference<CosmosDBAccount>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported DataTransferJobGetResult resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-09-01-preview.
        /// </summary>
        public static readonly string V2024_09_01_preview = "2024-09-01-preview";

        /// <summary>
        /// 2024-08-15.
        /// </summary>
        public static readonly string V2024_08_15 = "2024-08-15";

        /// <summary>
        /// 2024-05-15.
        /// </summary>
        public static readonly string V2024_05_15 = "2024-05-15";

        /// <summary>
        /// 2023-11-15.
        /// </summary>
        public static readonly string V2023_11_15 = "2023-11-15";

        /// <summary>
        /// 2023-09-15.
        /// </summary>
        public static readonly string V2023_09_15 = "2023-09-15";

        /// <summary>
        /// 2023-04-15.
        /// </summary>
        public static readonly string V2023_04_15 = "2023-04-15";

        /// <summary>
        /// 2023-03-15.
        /// </summary>
        public static readonly string V2023_03_15 = "2023-03-15";

        /// <summary>
        /// 2022-11-15.
        /// </summary>
        public static readonly string V2022_11_15 = "2022-11-15";

        /// <summary>
        /// 2022-08-15.
        /// </summary>
        public static readonly string V2022_08_15 = "2022-08-15";

        /// <summary>
        /// 2022-05-15.
        /// </summary>
        public static readonly string V2022_05_15 = "2022-05-15";

        /// <summary>
        /// 2021-10-15.
        /// </summary>
        public static readonly string V2021_10_15 = "2021-10-15";

        /// <summary>
        /// 2021-06-15.
        /// </summary>
        public static readonly string V2021_06_15 = "2021-06-15";

        /// <summary>
        /// 2021-05-15.
        /// </summary>
        public static readonly string V2021_05_15 = "2021-05-15";

        /// <summary>
        /// 2021-04-15.
        /// </summary>
        public static readonly string V2021_04_15 = "2021-04-15";

        /// <summary>
        /// 2021-03-15.
        /// </summary>
        public static readonly string V2021_03_15 = "2021-03-15";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-04-01.
        /// </summary>
        public static readonly string V2020_04_01 = "2020-04-01";

        /// <summary>
        /// 2020-03-01.
        /// </summary>
        public static readonly string V2020_03_01 = "2020-03-01";

        /// <summary>
        /// 2019-12-12.
        /// </summary>
        public static readonly string V2019_12_12 = "2019-12-12";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2016-03-31.
        /// </summary>
        public static readonly string V2016_03_31 = "2016-03-31";

        /// <summary>
        /// 2016-03-19.
        /// </summary>
        public static readonly string V2016_03_19 = "2016-03-19";

        /// <summary>
        /// 2015-11-06.
        /// </summary>
        public static readonly string V2015_11_06 = "2015-11-06";

        /// <summary>
        /// 2015-04-08.
        /// </summary>
        public static readonly string V2015_04_08 = "2015-04-08";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing DataTransferJobGetResult.
    /// </summary>
    /// <param name="resourceName">Name of the DataTransferJobGetResult.</param>
    /// <param name="resourceVersion">Version of the DataTransferJobGetResult.</param>
    /// <returns>The existing DataTransferJobGetResult resource.</returns>
    public static DataTransferJobGetResult FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
