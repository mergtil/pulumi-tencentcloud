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
    public sealed class GetTargetHealthLoadBalancerListenerResult
    {
        public readonly string ListenerId;
        public readonly string ListenerName;
        public readonly int Port;
        public readonly string Protocol;
        public readonly ImmutableArray<Outputs.GetTargetHealthLoadBalancerListenerRuleResult> Rules;

        [OutputConstructor]
        private GetTargetHealthLoadBalancerListenerResult(
            string listenerId,

            string listenerName,

            int port,

            string protocol,

            ImmutableArray<Outputs.GetTargetHealthLoadBalancerListenerRuleResult> rules)
        {
            ListenerId = listenerId;
            ListenerName = listenerName;
            Port = port;
            Protocol = protocol;
            Rules = rules;
        }
    }
}
