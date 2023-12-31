// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dayu.Outputs
{

    [OutputType]
    public sealed class DdosPolicyV2DdosSpeedLimitConfig
    {
        public readonly int Bandwidth;
        public readonly string DstPortList;
        public readonly int Mode;
        public readonly int PacketRate;
        public readonly string ProtocolList;

        [OutputConstructor]
        private DdosPolicyV2DdosSpeedLimitConfig(
            int bandwidth,

            string dstPortList,

            int mode,

            int packetRate,

            string protocolList)
        {
            Bandwidth = bandwidth;
            DstPortList = dstPortList;
            Mode = mode;
            PacketRate = packetRate;
            ProtocolList = protocolList;
        }
    }
}
