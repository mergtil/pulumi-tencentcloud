// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Vpc.Outputs
{

    [OutputType]
    public sealed class GetNetDetectStatesNetDetectStateSetNetDetectIpStateSetResult
    {
        public readonly int Delay;
        public readonly string DetectDestinationIp;
        public readonly int PacketLossRate;
        public readonly int State;

        [OutputConstructor]
        private GetNetDetectStatesNetDetectStateSetNetDetectIpStateSetResult(
            int delay,

            string detectDestinationIp,

            int packetLossRate,

            int state)
        {
            Delay = delay;
            DetectDestinationIp = detectDestinationIp;
            PacketLossRate = packetLossRate;
            State = state;
        }
    }
}
