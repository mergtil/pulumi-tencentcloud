// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Pts.Inputs
{

    public sealed class ScenarioLoadLoadSpecConcurrencyStageArgs : global::Pulumi.ResourceArgs
    {
        [Input("durationSeconds")]
        public Input<int>? DurationSeconds { get; set; }

        [Input("targetVirtualUsers")]
        public Input<int>? TargetVirtualUsers { get; set; }

        public ScenarioLoadLoadSpecConcurrencyStageArgs()
        {
        }
        public static new ScenarioLoadLoadSpecConcurrencyStageArgs Empty => new ScenarioLoadLoadSpecConcurrencyStageArgs();
    }
}
