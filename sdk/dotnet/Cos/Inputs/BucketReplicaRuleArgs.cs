// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cos.Inputs
{

    public sealed class BucketReplicaRuleArgs : global::Pulumi.ResourceArgs
    {
        [Input("destinationBucket", required: true)]
        public Input<string> DestinationBucket { get; set; } = null!;

        [Input("destinationStorageClass")]
        public Input<string>? DestinationStorageClass { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        public BucketReplicaRuleArgs()
        {
        }
        public static new BucketReplicaRuleArgs Empty => new BucketReplicaRuleArgs();
    }
}