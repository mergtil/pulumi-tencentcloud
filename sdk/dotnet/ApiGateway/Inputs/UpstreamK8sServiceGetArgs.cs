// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.ApiGateway.Inputs
{

    public sealed class UpstreamK8sServiceGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        [Input("extraLabels", required: true)]
        private InputList<Inputs.UpstreamK8sServiceExtraLabelGetArgs>? _extraLabels;
        public InputList<Inputs.UpstreamK8sServiceExtraLabelGetArgs> ExtraLabels
        {
            get => _extraLabels ?? (_extraLabels = new InputList<Inputs.UpstreamK8sServiceExtraLabelGetArgs>());
            set => _extraLabels = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("namespace", required: true)]
        public Input<string> Namespace { get; set; } = null!;

        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        [Input("weight", required: true)]
        public Input<int> Weight { get; set; } = null!;

        public UpstreamK8sServiceGetArgs()
        {
        }
        public static new UpstreamK8sServiceGetArgs Empty => new UpstreamK8sServiceGetArgs();
    }
}
