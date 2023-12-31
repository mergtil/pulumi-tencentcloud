// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Monitor.Inputs
{

    public sealed class TmpTkeTemplateAttachmentTargetsArgs : global::Pulumi.ResourceArgs
    {
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        [Input("clusterName")]
        public Input<string>? ClusterName { get; set; }

        [Input("clusterType")]
        public Input<string>? ClusterType { get; set; }

        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("instanceName")]
        public Input<string>? InstanceName { get; set; }

        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        [Input("syncTime")]
        public Input<string>? SyncTime { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public TmpTkeTemplateAttachmentTargetsArgs()
        {
        }
        public static new TmpTkeTemplateAttachmentTargetsArgs Empty => new TmpTkeTemplateAttachmentTargetsArgs();
    }
}
