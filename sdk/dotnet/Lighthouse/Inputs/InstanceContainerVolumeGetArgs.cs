// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Lighthouse.Inputs
{

    public sealed class InstanceContainerVolumeGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("containerPath", required: true)]
        public Input<string> ContainerPath { get; set; } = null!;

        [Input("hostPath", required: true)]
        public Input<string> HostPath { get; set; } = null!;

        public InstanceContainerVolumeGetArgs()
        {
        }
        public static new InstanceContainerVolumeGetArgs Empty => new InstanceContainerVolumeGetArgs();
    }
}
