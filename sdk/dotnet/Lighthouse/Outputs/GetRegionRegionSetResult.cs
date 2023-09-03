// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Lighthouse.Outputs
{

    [OutputType]
    public sealed class GetRegionRegionSetResult
    {
        public readonly bool IsChinaMainland;
        public readonly string Region;
        public readonly string RegionName;
        public readonly string RegionState;

        [OutputConstructor]
        private GetRegionRegionSetResult(
            bool isChinaMainland,

            string region,

            string regionName,

            string regionState)
        {
            IsChinaMainland = isChinaMainland;
            Region = region;
            RegionName = regionName;
            RegionState = regionState;
        }
    }
}