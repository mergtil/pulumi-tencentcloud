// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dts.Outputs
{

    [OutputType]
    public sealed class MigrateJobDstInfo
    {
        public readonly string AccessType;
        public readonly string DatabaseType;
        public readonly ImmutableArray<Outputs.MigrateJobDstInfoExtraAttr> ExtraAttrs;
        public readonly ImmutableArray<Outputs.MigrateJobDstInfoInfo> Infos;
        public readonly string NodeType;
        public readonly string Region;
        public readonly string? Supplier;

        [OutputConstructor]
        private MigrateJobDstInfo(
            string accessType,

            string databaseType,

            ImmutableArray<Outputs.MigrateJobDstInfoExtraAttr> extraAttrs,

            ImmutableArray<Outputs.MigrateJobDstInfoInfo> infos,

            string nodeType,

            string region,

            string? supplier)
        {
            AccessType = accessType;
            DatabaseType = databaseType;
            ExtraAttrs = extraAttrs;
            Infos = infos;
            NodeType = nodeType;
            Region = region;
            Supplier = supplier;
        }
    }
}
