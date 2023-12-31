// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Deprecatedkubernetes.Inputs
{

    public sealed class AsScalingGroupAutoScalingGroupForwardBalancerIdGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("listenerId", required: true)]
        public Input<string> ListenerId { get; set; } = null!;

        [Input("loadBalancerId", required: true)]
        public Input<string> LoadBalancerId { get; set; } = null!;

        [Input("ruleId")]
        public Input<string>? RuleId { get; set; }

        [Input("targetAttributes", required: true)]
        private InputList<Inputs.AsScalingGroupAutoScalingGroupForwardBalancerIdTargetAttributeGetArgs>? _targetAttributes;
        public InputList<Inputs.AsScalingGroupAutoScalingGroupForwardBalancerIdTargetAttributeGetArgs> TargetAttributes
        {
            get => _targetAttributes ?? (_targetAttributes = new InputList<Inputs.AsScalingGroupAutoScalingGroupForwardBalancerIdTargetAttributeGetArgs>());
            set => _targetAttributes = value;
        }

        public AsScalingGroupAutoScalingGroupForwardBalancerIdGetArgs()
        {
        }
        public static new AsScalingGroupAutoScalingGroupForwardBalancerIdGetArgs Empty => new AsScalingGroupAutoScalingGroupForwardBalancerIdGetArgs();
    }
}
