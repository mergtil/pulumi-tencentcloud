// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Reserved.Outputs
{

    [OutputType]
    public sealed class GetInstancesReservedInstanceListResult
    {
        public readonly string AvailabilityZone;
        public readonly string EndTime;
        public readonly int InstanceCount;
        public readonly string InstanceType;
        public readonly string ReservedInstanceId;
        public readonly string StartTime;
        public readonly string Status;

        [OutputConstructor]
        private GetInstancesReservedInstanceListResult(
            string availabilityZone,

            string endTime,

            int instanceCount,

            string instanceType,

            string reservedInstanceId,

            string startTime,

            string status)
        {
            AvailabilityZone = availabilityZone;
            EndTime = endTime;
            InstanceCount = instanceCount;
            InstanceType = instanceType;
            ReservedInstanceId = reservedInstanceId;
            StartTime = startTime;
            Status = status;
        }
    }
}