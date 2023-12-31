// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.ApiGateway.Inputs
{

    public sealed class UpstreamNodeGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        [Input("host", required: true)]
        public Input<string> Host { get; set; } = null!;

        [Input("nameSpace")]
        public Input<string>? NameSpace { get; set; }

        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        [Input("serviceName")]
        public Input<string>? ServiceName { get; set; }

        [Input("source")]
        public Input<string>? Source { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("uniqueServiceName")]
        public Input<string>? UniqueServiceName { get; set; }

        [Input("vmInstanceId")]
        public Input<string>? VmInstanceId { get; set; }

        [Input("weight", required: true)]
        public Input<int> Weight { get; set; } = null!;

        public UpstreamNodeGetArgs()
        {
        }
        public static new UpstreamNodeGetArgs Empty => new UpstreamNodeGetArgs();
    }
}
