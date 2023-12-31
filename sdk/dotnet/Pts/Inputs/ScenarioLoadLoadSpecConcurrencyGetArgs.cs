// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Pts.Inputs
{

    public sealed class ScenarioLoadLoadSpecConcurrencyGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("gracefulStopSeconds")]
        public Input<int>? GracefulStopSeconds { get; set; }

        [Input("iterationCount")]
        public Input<int>? IterationCount { get; set; }

        [Input("maxRequestsPerSecond")]
        public Input<int>? MaxRequestsPerSecond { get; set; }

        [Input("stages")]
        private InputList<Inputs.ScenarioLoadLoadSpecConcurrencyStageGetArgs>? _stages;
        public InputList<Inputs.ScenarioLoadLoadSpecConcurrencyStageGetArgs> Stages
        {
            get => _stages ?? (_stages = new InputList<Inputs.ScenarioLoadLoadSpecConcurrencyStageGetArgs>());
            set => _stages = value;
        }

        public ScenarioLoadLoadSpecConcurrencyGetArgs()
        {
        }
        public static new ScenarioLoadLoadSpecConcurrencyGetArgs Empty => new ScenarioLoadLoadSpecConcurrencyGetArgs();
    }
}
