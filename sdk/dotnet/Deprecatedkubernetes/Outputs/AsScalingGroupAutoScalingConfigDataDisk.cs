// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Deprecatedkubernetes.Outputs
{

    [OutputType]
    public sealed class AsScalingGroupAutoScalingConfigDataDisk
    {
        public readonly int? DiskSize;
        public readonly string? DiskType;
        public readonly string? SnapshotId;

        [OutputConstructor]
        private AsScalingGroupAutoScalingConfigDataDisk(
            int? diskSize,

            string? diskType,

            string? snapshotId)
        {
            DiskSize = diskSize;
            DiskType = diskType;
            SnapshotId = snapshotId;
        }
    }
}
