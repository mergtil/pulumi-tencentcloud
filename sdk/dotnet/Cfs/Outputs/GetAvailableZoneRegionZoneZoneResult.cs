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
    public sealed class GetAvailableZoneRegionZoneZoneResult
    {
        public readonly ImmutableArray<Outputs.GetAvailableZoneRegionZoneZoneTypeResult> Types;
        public readonly string Zone;
        public readonly string ZoneCnName;
        public readonly int ZoneId;
        public readonly string ZoneName;

        [OutputConstructor]
        private GetAvailableZoneRegionZoneZoneResult(
            ImmutableArray<Outputs.GetAvailableZoneRegionZoneZoneTypeResult> types,

            string zone,

            string zoneCnName,

            int zoneId,

            string zoneName)
        {
            Types = types;
            Zone = zone;
            ZoneCnName = zoneCnName;
            ZoneId = zoneId;
            ZoneName = zoneName;
        }
    }
}
