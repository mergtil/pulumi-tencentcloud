// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.ApiGateway.Inputs
{

    public sealed class ApiTargetServiceArgs : global::Pulumi.ResourceArgs
    {
        [Input("dockerIp")]
        public Input<string>? DockerIp { get; set; }

        [Input("hostIp", required: true)]
        public Input<string> HostIp { get; set; } = null!;

        [Input("vmIp", required: true)]
        public Input<string> VmIp { get; set; } = null!;

        [Input("vmPort", required: true)]
        public Input<int> VmPort { get; set; } = null!;

        [Input("vpcId", required: true)]
        public Input<string> VpcId { get; set; } = null!;

        public ApiTargetServiceArgs()
        {
        }
        public static new ApiTargetServiceArgs Empty => new ApiTargetServiceArgs();
    }
}