// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Monitor.Outputs
{

    [OutputType]
    public sealed class GetPolicyConditionsListResult
    {
        public readonly ImmutableArray<Outputs.GetPolicyConditionsListEventMetricResult> EventMetrics;
        public readonly bool IsSupportMultiRegion;
        public readonly ImmutableArray<Outputs.GetPolicyConditionsListMetricResult> Metrics;
        public readonly string Name;
        public readonly string PolicyViewName;
        public readonly ImmutableArray<string> SupportRegions;

        [OutputConstructor]
        private GetPolicyConditionsListResult(
            ImmutableArray<Outputs.GetPolicyConditionsListEventMetricResult> eventMetrics,

            bool isSupportMultiRegion,

            ImmutableArray<Outputs.GetPolicyConditionsListMetricResult> metrics,

            string name,

            string policyViewName,

            ImmutableArray<string> supportRegions)
        {
            EventMetrics = eventMetrics;
            IsSupportMultiRegion = isSupportMultiRegion;
            Metrics = metrics;
            Name = name;
            PolicyViewName = policyViewName;
            SupportRegions = supportRegions;
        }
    }
}
