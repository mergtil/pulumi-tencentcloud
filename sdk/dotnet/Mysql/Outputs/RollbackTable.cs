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
    public sealed class RollbackTable
    {
        public readonly string Database;
        public readonly ImmutableArray<Outputs.RollbackTableTable> Tables;

        [OutputConstructor]
        private RollbackTable(
            string database,

            ImmutableArray<Outputs.RollbackTableTable> tables)
        {
            Database = database;
            Tables = tables;
        }
    }
}
