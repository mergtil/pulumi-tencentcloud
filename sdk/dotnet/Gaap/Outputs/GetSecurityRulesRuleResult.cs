// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Gaap.Outputs
{

    [OutputType]
    public sealed class GetSecurityRulesRuleResult
    {
        public readonly string Action;
        public readonly string CidrIp;
        public readonly string Id;
        public readonly string Name;
        public readonly string Port;
        public readonly string Protocol;

        [OutputConstructor]
        private GetSecurityRulesRuleResult(
            string action,

            string cidrIp,

            string id,

            string name,

            string port,

            string protocol)
        {
            Action = action;
            CidrIp = cidrIp;
            Id = id;
            Name = name;
            Port = port;
            Protocol = protocol;
        }
    }
}
