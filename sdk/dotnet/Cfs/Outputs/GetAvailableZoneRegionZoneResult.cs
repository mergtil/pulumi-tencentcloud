// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cfs.Outputs
{

    [OutputType]
    public sealed class GetAvailableZoneRegionZoneResult
    {
        public readonly string Region;
        public readonly string RegionCnName;
        public readonly string RegionName;
        public readonly string RegionStatus;
        public readonly ImmutableArray<Outputs.GetAvailableZoneRegionZoneZoneResult> Zones;

        [OutputConstructor]
        private GetAvailableZoneRegionZoneResult(
            string region,

            string regionCnName,

            string regionName,

            string regionStatus,

            ImmutableArray<Outputs.GetAvailableZoneRegionZoneZoneResult> zones)
        {
            Region = region;
            RegionCnName = regionCnName;
            RegionName = regionName;
            RegionStatus = regionStatus;
            Zones = zones;
        }
    }
}