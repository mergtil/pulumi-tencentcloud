// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tcaplus.Outputs
{

    [OutputType]
    public sealed class IdlTableInfo
    {
        public readonly string? Error;
        public readonly string? IndexKeySet;
        public readonly string? KeyFields;
        public readonly int? SumKeyFieldSize;
        public readonly int? SumValueFieldSize;
        public readonly string? TableName;
        public readonly string? ValueFields;

        [OutputConstructor]
        private IdlTableInfo(
            string? error,

            string? indexKeySet,

            string? keyFields,

            int? sumKeyFieldSize,

            int? sumValueFieldSize,

            string? tableName,

            string? valueFields)
        {
            Error = error;
            IndexKeySet = indexKeySet;
            KeyFields = keyFields;
            SumKeyFieldSize = sumKeyFieldSize;
            SumValueFieldSize = sumValueFieldSize;
            TableName = tableName;
            ValueFields = valueFields;
        }
    }
}