// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Vpc.Outputs
{

    [OutputType]
    public sealed class GetSubnetResourceDashboardResourceStatisticsSetResourceStatisticsItemSetResult
    {
        public readonly int ResourceCount;
        public readonly string ResourceName;
        public readonly string ResourceType;

        [OutputConstructor]
        private GetSubnetResourceDashboardResourceStatisticsSetResourceStatisticsItemSetResult(
            int resourceCount,

            string resourceName,

            string resourceType)
        {
            ResourceCount = resourceCount;
            ResourceName = resourceName;
            ResourceType = resourceType;
        }
    }
}
