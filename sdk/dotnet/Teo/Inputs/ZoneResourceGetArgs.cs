// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Teo.Inputs
{

    public sealed class ZoneResourceGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("area")]
        public Input<string>? Area { get; set; }

        [Input("autoRenewFlag")]
        public Input<int>? AutoRenewFlag { get; set; }

        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        [Input("enableTime")]
        public Input<string>? EnableTime { get; set; }

        [Input("expireTime")]
        public Input<string>? ExpireTime { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("payMode")]
        public Input<int>? PayMode { get; set; }

        [Input("planId")]
        public Input<string>? PlanId { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("svs")]
        private InputList<Inputs.ZoneResourceSvGetArgs>? _svs;
        public InputList<Inputs.ZoneResourceSvGetArgs> Svs
        {
            get => _svs ?? (_svs = new InputList<Inputs.ZoneResourceSvGetArgs>());
            set => _svs = value;
        }

        public ZoneResourceGetArgs()
        {
        }
        public static new ZoneResourceGetArgs Empty => new ZoneResourceGetArgs();
    }
}
