// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tdmq.Outputs
{

    [OutputType]
    public sealed class GetPublishersPublisherResult
    {
        public readonly string Address;
        public readonly double AverageMsgSize;
        public readonly string ClientVersion;
        public readonly string ConnectedSince;
        public readonly double MsgRateIn;
        public readonly double MsgThroughputIn;
        public readonly int Partition;
        public readonly int ProducerId;
        public readonly string ProducerName;

        [OutputConstructor]
        private GetPublishersPublisherResult(
            string address,

            double averageMsgSize,

            string clientVersion,

            string connectedSince,

            double msgRateIn,

            double msgThroughputIn,

            int partition,

            int producerId,

            string producerName)
        {
            Address = address;
            AverageMsgSize = averageMsgSize;
            ClientVersion = clientVersion;
            ConnectedSince = connectedSince;
            MsgRateIn = msgRateIn;
            MsgThroughputIn = msgThroughputIn;
            Partition = partition;
            ProducerId = producerId;
            ProducerName = producerName;
        }
    }
}
