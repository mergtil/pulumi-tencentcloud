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
    public sealed class GetZoneConfigListResult
    {
        public readonly int Cpu;
        public readonly string MachineType;
        public readonly int MaxIoBandwidth;
        public readonly int MaxStorageSize;
        public readonly int Memory;
        public readonly int MinStorageSize;
        public readonly ImmutableArray<Outputs.GetZoneConfigListZoneStockInfoResult> ZoneStockInfos;

        [OutputConstructor]
        private GetZoneConfigListResult(
            int cpu,

            string machineType,

            int maxIoBandwidth,

            int maxStorageSize,

            int memory,

            int minStorageSize,

            ImmutableArray<Outputs.GetZoneConfigListZoneStockInfoResult> zoneStockInfos)
        {
            Cpu = cpu;
            MachineType = machineType;
            MaxIoBandwidth = maxIoBandwidth;
            MaxStorageSize = maxStorageSize;
            Memory = memory;
            MinStorageSize = minStorageSize;
            ZoneStockInfos = zoneStockInfos;
        }
    }
}
