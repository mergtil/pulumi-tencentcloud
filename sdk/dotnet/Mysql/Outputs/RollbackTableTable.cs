// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mysql.Outputs
{

    [OutputType]
    public sealed class RollbackTableTable
    {
        public readonly string NewTableName;
        public readonly string TableName;

        [OutputConstructor]
        private RollbackTableTable(
            string newTableName,

            string tableName)
        {
            NewTableName = newTableName;
            TableName = tableName;
        }
    }
}