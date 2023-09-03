// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tem.Inputs
{

    public sealed class GatewayIngressRuleArgs : global::Pulumi.ResourceArgs
    {
        [Input("host")]
        public Input<string>? Host { get; set; }

        [Input("http", required: true)]
        public Input<Inputs.GatewayIngressRuleHttpArgs> Http { get; set; } = null!;

        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        public GatewayIngressRuleArgs()
        {
        }
        public static new GatewayIngressRuleArgs Empty => new GatewayIngressRuleArgs();
    }
}