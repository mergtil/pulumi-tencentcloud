// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mongodb.Outputs
{

    [OutputType]
    public sealed class GetInstancesInstanceListResult
    {
        public readonly int AutoRenewFlag;
        public readonly string AvailableZone;
        public readonly string ChargeType;
        public readonly string ClusterType;
        public readonly int Cpu;
        public readonly string CreateTime;
        public readonly string EngineVersion;
        public readonly string InstanceId;
        public readonly string InstanceName;
        public readonly string MachineType;
        public readonly int Memory;
        public readonly int ProjectId;
        public readonly int ShardQuantity;
        public readonly int Status;
        public readonly string SubnetId;
        public readonly ImmutableDictionary<string, object> Tags;
        public readonly string Vip;
        public readonly int Volume;
        public readonly string VpcId;
        public readonly int Vport;

        [OutputConstructor]
        private GetInstancesInstanceListResult(
            int autoRenewFlag,

            string availableZone,

            string chargeType,

            string clusterType,

            int cpu,

            string createTime,

            string engineVersion,

            string instanceId,

            string instanceName,

            string machineType,

            int memory,

            int projectId,

            int shardQuantity,

            int status,

            string subnetId,

            ImmutableDictionary<string, object> tags,

            string vip,

            int volume,

            string vpcId,

            int vport)
        {
            AutoRenewFlag = autoRenewFlag;
            AvailableZone = availableZone;
            ChargeType = chargeType;
            ClusterType = clusterType;
            Cpu = cpu;
            CreateTime = createTime;
            EngineVersion = engineVersion;
            InstanceId = instanceId;
            InstanceName = instanceName;
            MachineType = machineType;
            Memory = memory;
            ProjectId = projectId;
            ShardQuantity = shardQuantity;
            Status = status;
            SubnetId = subnetId;
            Tags = tags;
            Vip = vip;
            Volume = volume;
            VpcId = vpcId;
            Vport = vport;
        }
    }
}
