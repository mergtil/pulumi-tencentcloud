// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tem.Inputs
{

    public sealed class WorkloadStorageConfGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("storageVolIp", required: true)]
        public Input<string> StorageVolIp { get; set; } = null!;

        [Input("storageVolName", required: true)]
        public Input<string> StorageVolName { get; set; } = null!;

        [Input("storageVolPath", required: true)]
        public Input<string> StorageVolPath { get; set; } = null!;

        public WorkloadStorageConfGetArgs()
        {
        }
        public static new WorkloadStorageConfGetArgs Empty => new WorkloadStorageConfGetArgs();
    }
}