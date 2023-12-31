// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cynosdb.Outputs
{

    [OutputType]
    public sealed class RollBackClusterRollbackTable
    {
        public readonly string Database;
        public readonly ImmutableArray<Outputs.RollBackClusterRollbackTableTable> Tables;

        [OutputConstructor]
        private RollBackClusterRollbackTable(
            string database,

            ImmutableArray<Outputs.RollBackClusterRollbackTableTable> tables)
        {
            Database = database;
            Tables = tables;
        }
    }
}
