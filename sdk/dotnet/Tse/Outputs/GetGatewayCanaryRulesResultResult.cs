// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tse.Outputs
{

    [OutputType]
    public sealed class GetGatewayCanaryRulesResultResult
    {
        public readonly ImmutableArray<Outputs.GetGatewayCanaryRulesResultCanaryRuleListResult> CanaryRuleLists;
        public readonly int TotalCount;

        [OutputConstructor]
        private GetGatewayCanaryRulesResultResult(
            ImmutableArray<Outputs.GetGatewayCanaryRulesResultCanaryRuleListResult> canaryRuleLists,

            int totalCount)
        {
            CanaryRuleLists = canaryRuleLists;
            TotalCount = totalCount;
        }
    }
}
