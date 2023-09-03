// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.As.Outputs
{

    [OutputType]
    public sealed class GetScalingConfigsConfigurationListDataDiskResult
    {
        public readonly bool DeleteWithInstance;
        public readonly int DiskSize;
        public readonly string DiskType;
        public readonly string SnapshotId;

        [OutputConstructor]
        private GetScalingConfigsConfigurationListDataDiskResult(
            bool deleteWithInstance,

            int diskSize,

            string diskType,

            string snapshotId)
        {
            DeleteWithInstance = deleteWithInstance;
            DiskSize = diskSize;
            DiskType = diskType;
            SnapshotId = snapshotId;
        }
    }
}