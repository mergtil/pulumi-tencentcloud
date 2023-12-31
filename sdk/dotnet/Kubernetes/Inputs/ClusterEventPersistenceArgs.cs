// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Kubernetes.Inputs
{

    public sealed class ClusterEventPersistenceArgs : global::Pulumi.ResourceArgs
    {
        [Input("deleteEventLogAndTopic")]
        public Input<bool>? DeleteEventLogAndTopic { get; set; }

        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("logSetId")]
        public Input<string>? LogSetId { get; set; }

        [Input("topicId")]
        public Input<string>? TopicId { get; set; }

        public ClusterEventPersistenceArgs()
        {
        }
        public static new ClusterEventPersistenceArgs Empty => new ClusterEventPersistenceArgs();
    }
}
