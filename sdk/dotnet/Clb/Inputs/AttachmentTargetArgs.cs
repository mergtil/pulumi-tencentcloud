// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Clb.Inputs
{

    public sealed class AttachmentTargetArgs : global::Pulumi.ResourceArgs
    {
        [Input("eniIp")]
        public Input<string>? EniIp { get; set; }

        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        [Input("weight")]
        public Input<int>? Weight { get; set; }

        public AttachmentTargetArgs()
        {
        }
        public static new AttachmentTargetArgs Empty => new AttachmentTargetArgs();
    }
}
