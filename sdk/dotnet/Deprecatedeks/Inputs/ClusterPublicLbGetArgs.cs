// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Deprecatedeks.Inputs
{

    public sealed class ClusterPublicLbGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("allowFromCidrs")]
        private InputList<string>? _allowFromCidrs;
        public InputList<string> AllowFromCidrs
        {
            get => _allowFromCidrs ?? (_allowFromCidrs = new InputList<string>());
            set => _allowFromCidrs = value;
        }

        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("extraParam")]
        public Input<string>? ExtraParam { get; set; }

        [Input("securityGroup")]
        public Input<string>? SecurityGroup { get; set; }

        [Input("securityPolicies")]
        private InputList<string>? _securityPolicies;
        public InputList<string> SecurityPolicies
        {
            get => _securityPolicies ?? (_securityPolicies = new InputList<string>());
            set => _securityPolicies = value;
        }

        public ClusterPublicLbGetArgs()
        {
        }
        public static new ClusterPublicLbGetArgs Empty => new ClusterPublicLbGetArgs();
    }
}
