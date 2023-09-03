// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mariadb.Outputs
{

    [OutputType]
    public sealed class GetSaleInfoRegionListResult
    {
        public readonly ImmutableArray<Outputs.GetSaleInfoRegionListAvailableChoiceResult> AvailableChoices;
        public readonly string Region;
        public readonly int RegionId;
        public readonly string RegionName;
        public readonly ImmutableArray<Outputs.GetSaleInfoRegionListZoneListResult> ZoneLists;

        [OutputConstructor]
        private GetSaleInfoRegionListResult(
            ImmutableArray<Outputs.GetSaleInfoRegionListAvailableChoiceResult> availableChoices,

            string region,

            int regionId,

            string regionName,

            ImmutableArray<Outputs.GetSaleInfoRegionListZoneListResult> zoneLists)
        {
            AvailableChoices = availableChoices;
            Region = region;
            RegionId = regionId;
            RegionName = regionName;
            ZoneLists = zoneLists;
        }
    }
}