// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dayu.Inputs
{

    public sealed class DdosPolicyV2DdosSpeedLimitConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("bandwidth", required: true)]
        public Input<int> Bandwidth { get; set; } = null!;

        [Input("dstPortList", required: true)]
        public Input<string> DstPortList { get; set; } = null!;

        [Input("mode", required: true)]
        public Input<int> Mode { get; set; } = null!;

        [Input("packetRate", required: true)]
        public Input<int> PacketRate { get; set; } = null!;

        [Input("protocolList", required: true)]
        public Input<string> ProtocolList { get; set; } = null!;

        public DdosPolicyV2DdosSpeedLimitConfigGetArgs()
        {
        }
        public static new DdosPolicyV2DdosSpeedLimitConfigGetArgs Empty => new DdosPolicyV2DdosSpeedLimitConfigGetArgs();
    }
}
