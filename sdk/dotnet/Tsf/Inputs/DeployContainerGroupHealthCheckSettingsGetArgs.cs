// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tsf.Inputs
{

    public sealed class DeployContainerGroupHealthCheckSettingsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("livenessProbe")]
        public Input<Inputs.DeployContainerGroupHealthCheckSettingsLivenessProbeGetArgs>? LivenessProbe { get; set; }

        [Input("readinessProbe")]
        public Input<Inputs.DeployContainerGroupHealthCheckSettingsReadinessProbeGetArgs>? ReadinessProbe { get; set; }

        public DeployContainerGroupHealthCheckSettingsGetArgs()
        {
        }
        public static new DeployContainerGroupHealthCheckSettingsGetArgs Empty => new DeployContainerGroupHealthCheckSettingsGetArgs();
    }
}
