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
    public sealed class PrivilegeTable
    {
        public readonly string DatabaseName;
        public readonly ImmutableArray<string> Privileges;
        public readonly string TableName;

        [OutputConstructor]
        private PrivilegeTable(
            string databaseName,

            ImmutableArray<string> privileges,

            string tableName)
        {
            DatabaseName = databaseName;
            Privileges = privileges;
            TableName = tableName;
        }
    }
}
