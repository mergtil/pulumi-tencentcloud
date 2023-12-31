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
    public sealed class AlarmPolicyConditions
    {
        public readonly int? IsUnionRule;
        public readonly ImmutableArray<Outputs.AlarmPolicyConditionsRule> Rules;

        [OutputConstructor]
        private AlarmPolicyConditions(
            int? isUnionRule,

            ImmutableArray<Outputs.AlarmPolicyConditionsRule> rules)
        {
            IsUnionRule = isUnionRule;
            Rules = rules;
        }
    }
}
