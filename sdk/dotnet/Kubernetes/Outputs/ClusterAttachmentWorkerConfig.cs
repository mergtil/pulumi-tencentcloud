// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Kubernetes.Outputs
{

    [OutputType]
    public sealed class ClusterAttachmentWorkerConfig
    {
        public readonly ImmutableArray<Outputs.ClusterAttachmentWorkerConfigDataDisk> DataDisks;
        public readonly int? DesiredPodNum;
        public readonly string? DockerGraphPath;
        public readonly ImmutableArray<string> ExtraArgs;
        public readonly Outputs.ClusterAttachmentWorkerConfigGpuArgs? GpuArgs;
        public readonly bool? IsSchedule;
        public readonly string? MountTarget;
        public readonly string? UserData;

        [OutputConstructor]
        private ClusterAttachmentWorkerConfig(
            ImmutableArray<Outputs.ClusterAttachmentWorkerConfigDataDisk> dataDisks,

            int? desiredPodNum,

            string? dockerGraphPath,

            ImmutableArray<string> extraArgs,

            Outputs.ClusterAttachmentWorkerConfigGpuArgs? gpuArgs,

            bool? isSchedule,

            string? mountTarget,

            string? userData)
        {
            DataDisks = dataDisks;
            DesiredPodNum = desiredPodNum;
            DockerGraphPath = dockerGraphPath;
            ExtraArgs = extraArgs;
            GpuArgs = gpuArgs;
            IsSchedule = isSchedule;
            MountTarget = mountTarget;
            UserData = userData;
        }
    }
}
