// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tsf.Outputs
{

    [OutputType]
    public sealed class DeployVmGroupHealthCheckSettings
    {
        public readonly Outputs.DeployVmGroupHealthCheckSettingsLivenessProbe? LivenessProbe;
        public readonly Outputs.DeployVmGroupHealthCheckSettingsReadinessProbe? ReadinessProbe;

        [OutputConstructor]
        private DeployVmGroupHealthCheckSettings(
            Outputs.DeployVmGroupHealthCheckSettingsLivenessProbe? livenessProbe,

            Outputs.DeployVmGroupHealthCheckSettingsReadinessProbe? readinessProbe)
        {
            LivenessProbe = livenessProbe;
            ReadinessProbe = readinessProbe;
        }
    }
}
