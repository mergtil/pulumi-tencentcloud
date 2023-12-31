// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cdh.Inputs
{

    public sealed class InstanceHostResourceGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("cpuAvailableNum")]
        public Input<int>? CpuAvailableNum { get; set; }

        [Input("cpuTotalNum")]
        public Input<int>? CpuTotalNum { get; set; }

        [Input("diskAvailableSize")]
        public Input<int>? DiskAvailableSize { get; set; }

        [Input("diskTotalSize")]
        public Input<int>? DiskTotalSize { get; set; }

        [Input("diskType")]
        public Input<string>? DiskType { get; set; }

        [Input("memoryAvailableSize")]
        public Input<double>? MemoryAvailableSize { get; set; }

        [Input("memoryTotalSize")]
        public Input<double>? MemoryTotalSize { get; set; }

        public InstanceHostResourceGetArgs()
        {
        }
        public static new InstanceHostResourceGetArgs Empty => new InstanceHostResourceGetArgs();
    }
}
