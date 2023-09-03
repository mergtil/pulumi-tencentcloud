// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ckafka.Outputs
{

    [OutputType]
    public sealed class DatahubTaskTargetResourcePostgreSqlParam
    {
        public readonly string? DataFormat;
        public readonly string? DataTargetInsertMode;
        public readonly string? DataTargetPrimaryKeyField;
        public readonly ImmutableArray<Outputs.DatahubTaskTargetResourcePostgreSqlParamDataTargetRecordMapping> DataTargetRecordMappings;
        public readonly string Database;
        public readonly bool? DropInvalidMessage;
        public readonly bool? IsTableRegular;
        public readonly string? KeyColumns;
        public readonly string PluginName;
        public readonly bool? RecordWithSchema;
        public readonly string Resource;
        public readonly string? SnapshotMode;
        public readonly string Table;

        [OutputConstructor]
        private DatahubTaskTargetResourcePostgreSqlParam(
            string? dataFormat,

            string? dataTargetInsertMode,

            string? dataTargetPrimaryKeyField,

            ImmutableArray<Outputs.DatahubTaskTargetResourcePostgreSqlParamDataTargetRecordMapping> dataTargetRecordMappings,

            string database,

            bool? dropInvalidMessage,

            bool? isTableRegular,

            string? keyColumns,

            string pluginName,

            bool? recordWithSchema,

            string resource,

            string? snapshotMode,

            string table)
        {
            DataFormat = dataFormat;
            DataTargetInsertMode = dataTargetInsertMode;
            DataTargetPrimaryKeyField = dataTargetPrimaryKeyField;
            DataTargetRecordMappings = dataTargetRecordMappings;
            Database = database;
            DropInvalidMessage = dropInvalidMessage;
            IsTableRegular = isTableRegular;
            KeyColumns = keyColumns;
            PluginName = pluginName;
            RecordWithSchema = recordWithSchema;
            Resource = resource;
            SnapshotMode = snapshotMode;
            Table = table;
        }
    }
}