// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dayu.Inputs
{

    public sealed class CcPolicyV2CcPrecisionPolicyGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("domain", required: true)]
        public Input<string> Domain { get; set; } = null!;

        [Input("ip", required: true)]
        public Input<string> Ip { get; set; } = null!;

        [Input("policyAction", required: true)]
        public Input<string> PolicyAction { get; set; } = null!;

        [Input("policyId")]
        public Input<string>? PolicyId { get; set; }

        [Input("policys", required: true)]
        private InputList<Inputs.CcPolicyV2CcPrecisionPolicyPolicyGetArgs>? _policys;
        public InputList<Inputs.CcPolicyV2CcPrecisionPolicyPolicyGetArgs> Policys
        {
            get => _policys ?? (_policys = new InputList<Inputs.CcPolicyV2CcPrecisionPolicyPolicyGetArgs>());
            set => _policys = value;
        }

        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        public CcPolicyV2CcPrecisionPolicyGetArgs()
        {
        }
        public static new CcPolicyV2CcPrecisionPolicyGetArgs Empty => new CcPolicyV2CcPrecisionPolicyGetArgs();
    }
}
