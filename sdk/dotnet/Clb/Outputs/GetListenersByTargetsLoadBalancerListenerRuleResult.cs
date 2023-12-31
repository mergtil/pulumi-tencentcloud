// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Clb.Outputs
{

    [OutputType]
    public sealed class GetListenersByTargetsLoadBalancerListenerRuleResult
    {
        public readonly string Domain;
        public readonly string LocationId;
        public readonly ImmutableArray<Outputs.GetListenersByTargetsLoadBalancerListenerRuleTargetResult> Targets;
        public readonly string Url;

        [OutputConstructor]
        private GetListenersByTargetsLoadBalancerListenerRuleResult(
            string domain,

            string locationId,

            ImmutableArray<Outputs.GetListenersByTargetsLoadBalancerListenerRuleTargetResult> targets,

            string url)
        {
            Domain = domain;
            LocationId = locationId;
            Targets = targets;
            Url = url;
        }
    }
}
