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
    public sealed class GetCvmInstancesInstanceSetResult
    {
        public readonly int Cpu;
        public readonly string CreatedTime;
        public readonly int EniIpLimit;
        public readonly int EniLimit;
        public readonly int InstanceEniCount;
        public readonly string InstanceId;
        public readonly string InstanceName;
        public readonly string InstanceState;
        public readonly string InstanceType;
        public readonly int Memory;
        public readonly string SubnetId;
        public readonly string VpcId;

        [OutputConstructor]
        private GetCvmInstancesInstanceSetResult(
            int cpu,

            string createdTime,

            int eniIpLimit,

            int eniLimit,

            int instanceEniCount,

            string instanceId,

            string instanceName,

            string instanceState,

            string instanceType,

            int memory,

            string subnetId,

            string vpcId)
        {
            Cpu = cpu;
            CreatedTime = createdTime;
            EniIpLimit = eniIpLimit;
            EniLimit = eniLimit;
            InstanceEniCount = instanceEniCount;
            InstanceId = instanceId;
            InstanceName = instanceName;
            InstanceState = instanceState;
            InstanceType = instanceType;
            Memory = memory;
            SubnetId = subnetId;
            VpcId = vpcId;
        }
    }
}
