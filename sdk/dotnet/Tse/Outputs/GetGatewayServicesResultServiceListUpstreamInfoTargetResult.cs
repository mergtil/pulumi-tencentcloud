// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tse.Outputs
{

    [OutputType]
    public sealed class GetGatewayServicesResultServiceListUpstreamInfoTargetResult
    {
        public readonly string CreatedTime;
        public readonly string Health;
        public readonly string Host;
        public readonly int Port;
        public readonly string Source;
        public readonly int Weight;

        [OutputConstructor]
        private GetGatewayServicesResultServiceListUpstreamInfoTargetResult(
            string createdTime,

            string health,

            string host,

            int port,

            string source,

            int weight)
        {
            CreatedTime = createdTime;
            Health = health;
            Host = host;
            Port = port;
            Source = source;
            Weight = weight;
        }
    }
}
