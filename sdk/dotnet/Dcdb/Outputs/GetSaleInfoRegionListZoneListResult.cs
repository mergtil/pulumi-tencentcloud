// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dcdb.Outputs
{

    [OutputType]
    public sealed class GetSaleInfoRegionListZoneListResult
    {
        public readonly bool OnSale;
        public readonly string Zone;
        public readonly int ZoneId;
        public readonly string ZoneName;

        [OutputConstructor]
        private GetSaleInfoRegionListZoneListResult(
            bool onSale,

            string zone,

            int zoneId,

            string zoneName)
        {
            OnSale = onSale;
            Zone = zone;
            ZoneId = zoneId;
            ZoneName = zoneName;
        }
    }
}
