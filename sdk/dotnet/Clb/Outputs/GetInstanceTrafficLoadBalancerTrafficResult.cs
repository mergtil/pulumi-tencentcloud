// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Clb.Outputs
{

    [OutputType]
    public sealed class GetInstanceTrafficLoadBalancerTrafficResult
    {
        public readonly string Domain;
        public readonly string LoadBalancerId;
        public readonly string LoadBalancerName;
        public readonly double OutBandwidth;
        public readonly string Region;
        public readonly string Vip;

        [OutputConstructor]
        private GetInstanceTrafficLoadBalancerTrafficResult(
            string domain,

            string loadBalancerId,

            string loadBalancerName,

            double outBandwidth,

            string region,

            string vip)
        {
            Domain = domain;
            LoadBalancerId = loadBalancerId;
            LoadBalancerName = loadBalancerName;
            OutBandwidth = outBandwidth;
            Region = region;
            Vip = vip;
        }
    }
}
