// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Types of validations to run after the migration. </summary>
    public partial class MigrationValidationOptions
    {
        /// <summary> Initializes a new instance of <see cref="MigrationValidationOptions"/>. </summary>
        public MigrationValidationOptions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MigrationValidationOptions"/>. </summary>
        /// <param name="enableSchemaValidation"> Allows to compare the schema information between source and target. </param>
        /// <param name="enableDataIntegrityValidation"> Allows to perform a checksum based data integrity validation between source and target for the selected database / tables . </param>
        /// <param name="enableQueryAnalysisValidation"> Allows to perform a quick and intelligent query analysis by retrieving queries from the source database and executes them in the target. The result will have execution statistics for executions in source and target databases for the extracted queries. </param>
        internal MigrationValidationOptions(bool? enableSchemaValidation, bool? enableDataIntegrityValidation, bool? enableQueryAnalysisValidation)
        {
            EnableSchemaValidation = enableSchemaValidation;
            EnableDataIntegrityValidation = enableDataIntegrityValidation;
            EnableQueryAnalysisValidation = enableQueryAnalysisValidation;
        }

        /// <summary> Allows to compare the schema information between source and target. </summary>
        public bool? EnableSchemaValidation { get; set; }
        /// <summary> Allows to perform a checksum based data integrity validation between source and target for the selected database / tables . </summary>
        public bool? EnableDataIntegrityValidation { get; set; }
        /// <summary> Allows to perform a quick and intelligent query analysis by retrieving queries from the source database and executes them in the target. The result will have execution statistics for executions in source and target databases for the extracted queries. </summary>
        public bool? EnableQueryAnalysisValidation { get; set; }
    }
}
