// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mps.Inputs
{

    public sealed class WorkflowMediaProcessTaskSnapshotByTimeOffsetTaskSetOutputStorageGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("cosOutputStorage")]
        public Input<Inputs.WorkflowMediaProcessTaskSnapshotByTimeOffsetTaskSetOutputStorageCosOutputStorageGetArgs>? CosOutputStorage { get; set; }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public WorkflowMediaProcessTaskSnapshotByTimeOffsetTaskSetOutputStorageGetArgs()
        {
        }
        public static new WorkflowMediaProcessTaskSnapshotByTimeOffsetTaskSetOutputStorageGetArgs Empty => new WorkflowMediaProcessTaskSnapshotByTimeOffsetTaskSetOutputStorageGetArgs();
    }
}
