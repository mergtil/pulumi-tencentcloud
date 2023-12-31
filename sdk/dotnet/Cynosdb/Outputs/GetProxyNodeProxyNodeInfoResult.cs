// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cynosdb.Outputs
{

    [OutputType]
    public sealed class GetProxyNodeProxyNodeInfoResult
    {
        public readonly int AppId;
        public readonly string ClusterId;
        public readonly int Cpu;
        public readonly int Mem;
        public readonly string ProxyGroupId;
        public readonly int ProxyNodeConnections;
        public readonly string ProxyNodeId;
        public readonly string Region;
        public readonly string Status;
        public readonly string Zone;

        [OutputConstructor]
        private GetProxyNodeProxyNodeInfoResult(
            int appId,

            string clusterId,

            int cpu,

            int mem,

            string proxyGroupId,

            int proxyNodeConnections,

            string proxyNodeId,

            string region,

            string status,

            string zone)
        {
            AppId = appId;
            ClusterId = clusterId;
            Cpu = cpu;
            Mem = mem;
            ProxyGroupId = proxyGroupId;
            ProxyNodeConnections = proxyNodeConnections;
            ProxyNodeId = proxyNodeId;
            Region = region;
            Status = status;
            Zone = zone;
        }
    }
}
