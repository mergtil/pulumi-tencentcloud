// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Emr.Outputs
{

    [OutputType]
    public sealed class GetNodesNodeMcMultiDiskResult
    {
        public readonly int Count;
        public readonly int Type;
        public readonly int Volume;

        [OutputConstructor]
        private GetNodesNodeMcMultiDiskResult(
            int count,

            int type,

            int volume)
        {
            Count = count;
            Type = type;
            Volume = volume;
        }
    }
}
