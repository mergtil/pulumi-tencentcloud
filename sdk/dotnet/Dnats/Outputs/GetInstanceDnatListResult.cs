// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dnats.Outputs
{

    [OutputType]
    public sealed class GetInstanceDnatListResult
    {
        public readonly string? Description;
        public readonly string ElasticIp;
        public readonly string ElasticPort;
        public readonly string NatId;
        public readonly string PrivateIp;
        public readonly string PrivatePort;
        public readonly string Protocol;
        public readonly string VpcId;

        [OutputConstructor]
        private GetInstanceDnatListResult(
            string? description,

            string elasticIp,

            string elasticPort,

            string natId,

            string privateIp,

            string privatePort,

            string protocol,

            string vpcId)
        {
            Description = description;
            ElasticIp = elasticIp;
            ElasticPort = elasticPort;
            NatId = natId;
            PrivateIp = privateIp;
            PrivatePort = privatePort;
            Protocol = protocol;
            VpcId = vpcId;
        }
    }
}
