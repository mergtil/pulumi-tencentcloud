// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tem.Inputs
{

    public sealed class GatewayIngressRuleHttpArgs : global::Pulumi.ResourceArgs
    {
        [Input("paths", required: true)]
        private InputList<Inputs.GatewayIngressRuleHttpPathArgs>? _paths;
        public InputList<Inputs.GatewayIngressRuleHttpPathArgs> Paths
        {
            get => _paths ?? (_paths = new InputList<Inputs.GatewayIngressRuleHttpPathArgs>());
            set => _paths = value;
        }

        public GatewayIngressRuleHttpArgs()
        {
        }
        public static new GatewayIngressRuleHttpArgs Empty => new GatewayIngressRuleHttpArgs();
    }
}
