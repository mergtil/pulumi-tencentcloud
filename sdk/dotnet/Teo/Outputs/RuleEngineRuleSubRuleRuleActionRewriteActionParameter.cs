// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Teo.Outputs
{

    [OutputType]
    public sealed class RuleEngineRuleSubRuleRuleActionRewriteActionParameter
    {
        public readonly string Action;
        public readonly string Name;
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private RuleEngineRuleSubRuleRuleActionRewriteActionParameter(
            string action,

            string name,

            ImmutableArray<string> values)
        {
            Action = action;
            Name = name;
            Values = values;
        }
    }
}
