
// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  internal static partial class SdkInfo
  {
      public static IEnumerable<Tuple<string, string, string>> ApiInfo_RecoveryServicesBackupClient
      {
          get
          {
              return new Tuple<string, string, string>[]
              {
                new Tuple<string, string, string>("RecoveryServices", "AadProperties", "2018-12-20"),
                new Tuple<string, string, string>("RecoveryServices", "BMSPrepareDataMove", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BMSPrepareDataMoveOperationResult", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BMSTriggerDataMove", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupCrrJobDetails", "2018-12-20"),
                new Tuple<string, string, string>("RecoveryServices", "BackupCrrJobs", "2018-12-20"),
                new Tuple<string, string, string>("RecoveryServices", "BackupEngines", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupJobs", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupOperationResults", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupOperationStatuses", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupPolicies", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupProtectableItems", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupProtectedItems", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupProtectedItemsCrr", "2018-12-20"),
                new Tuple<string, string, string>("RecoveryServices", "BackupProtectionContainers", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupProtectionIntent", "2017-07-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupResourceEncryptionConfigs", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupResourceStorageConfigs", "2018-12-20"),
                new Tuple<string, string, string>("RecoveryServices", "BackupResourceVaultConfigs", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupStatus", "2017-07-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupUsageSummaries", "2017-07-01"),
                new Tuple<string, string, string>("RecoveryServices", "BackupWorkloadItems", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "Backups", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "CrossRegionRestore", "2018-12-20"),
                new Tuple<string, string, string>("RecoveryServices", "CrrOperationResults", "2018-12-20"),
                new Tuple<string, string, string>("RecoveryServices", "CrrOperationStatus", "2018-12-20"),
                new Tuple<string, string, string>("RecoveryServices", "ExportJobsOperationResults", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "FeatureSupport", "2017-07-01"),
                new Tuple<string, string, string>("RecoveryServices", "GetOperationStatus", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ItemLevelRecoveryConnections", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "JobCancellations", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "JobDetails", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "JobOperationResults", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "Jobs", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "Operation", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "Operations", "2016-08-10"),
                new Tuple<string, string, string>("RecoveryServices", "PrivateEndpoint", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "PrivateEndpointConnection", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectableContainers", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectedItemOperationResults", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectedItemOperationStatuses", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectedItems", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectionContainerOperationResults", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectionContainerRefreshOperationResults", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectionContainers", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectionIntent", "2017-07-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectionPolicies", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectionPolicyOperationResults", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "ProtectionPolicyOperationStatuses", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "RecoveryPoints", "2018-12-20"),
                new Tuple<string, string, string>("RecoveryServices", "RecoveryPoints", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "RecoveryPointsCrr", "2018-12-20"),
                new Tuple<string, string, string>("RecoveryServices", "Restores", "2020-12-01"),
                new Tuple<string, string, string>("RecoveryServices", "SecurityPINs", "2020-12-01"),
              }.AsEnumerable();
          }
      }
      // BEGIN: Code Generation Metadata Section
      public static readonly String AutoRestVersion = "v2";
      public static readonly String AutoRestBootStrapperVersion = "autorest@2.0.4413";
      public static readonly String AutoRestCmdExecuted = "cmd.exe /c autorest.cmd https://github.com/Azure/azure-rest-api-specs/blob/master/specification/recoveryservicesbackup/resource-manager/readme.md --csharp --version=v2 --reflect-api-versions --csharp-sdks-folder=D:\\one\\azure-sdk-for-net\\sdk";
      public static readonly String GithubForkName = "Azure";
      public static readonly String GithubBranchName = "master";
      public static readonly String GithubCommidId = "a2689b9f082a1d38437061aa94dd5eb2e612b7c0";
      public static readonly String CodeGenerationErrors = "";
      public static readonly String GithubRepoName = "azure-rest-api-specs";
      // END: Code Generation Metadata Section
  }
}

