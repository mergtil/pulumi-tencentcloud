// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Deprecatedeks.Outputs
{

    [OutputType]
    public sealed class ClusterPublicLb
    {
        public readonly ImmutableArray<string> AllowFromCidrs;
        public readonly bool Enabled;
        public readonly string? ExtraParam;
        public readonly string? SecurityGroup;
        public readonly ImmutableArray<string> SecurityPolicies;

        [OutputConstructor]
        private ClusterPublicLb(
            ImmutableArray<string> allowFromCidrs,

            bool enabled,

            string? extraParam,

            string? securityGroup,

            ImmutableArray<string> securityPolicies)
        {
            AllowFromCidrs = allowFromCidrs;
            Enabled = enabled;
            ExtraParam = extraParam;
            SecurityGroup = securityGroup;
            SecurityPolicies = securityPolicies;
        }
    }
}
