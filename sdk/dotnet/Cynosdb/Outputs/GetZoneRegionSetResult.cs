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
    public sealed class GetZoneRegionSetResult
    {
        public readonly string DbType;
        public readonly ImmutableArray<Outputs.GetZoneRegionSetModuleResult> Modules;
        public readonly string Region;
        public readonly int RegionId;
        public readonly string RegionZh;
        public readonly ImmutableArray<Outputs.GetZoneRegionSetZoneSetResult> ZoneSets;

        [OutputConstructor]
        private GetZoneRegionSetResult(
            string dbType,

            ImmutableArray<Outputs.GetZoneRegionSetModuleResult> modules,

            string region,

            int regionId,

            string regionZh,

            ImmutableArray<Outputs.GetZoneRegionSetZoneSetResult> zoneSets)
        {
            DbType = dbType;
            Modules = modules;
            Region = region;
            RegionId = regionId;
            RegionZh = regionZh;
            ZoneSets = zoneSets;
        }
    }
}