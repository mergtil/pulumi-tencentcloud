// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tsf.Inputs
{

    public sealed class DeployVmGroupHealthCheckSettingsLivenessProbeArgs : global::Pulumi.ResourceArgs
    {
        [Input("actionType", required: true)]
        public Input<string> ActionType { get; set; } = null!;

        [Input("commands")]
        private InputList<string>? _commands;
        public InputList<string> Commands
        {
            get => _commands ?? (_commands = new InputList<string>());
            set => _commands = value;
        }

        [Input("failureThreshold")]
        public Input<int>? FailureThreshold { get; set; }

        [Input("initialDelaySeconds")]
        public Input<int>? InitialDelaySeconds { get; set; }

        [Input("path")]
        public Input<string>? Path { get; set; }

        [Input("periodSeconds")]
        public Input<int>? PeriodSeconds { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("scheme")]
        public Input<string>? Scheme { get; set; }

        [Input("successThreshold")]
        public Input<int>? SuccessThreshold { get; set; }

        [Input("timeoutSeconds")]
        public Input<int>? TimeoutSeconds { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public DeployVmGroupHealthCheckSettingsLivenessProbeArgs()
        {
        }
        public static new DeployVmGroupHealthCheckSettingsLivenessProbeArgs Empty => new DeployVmGroupHealthCheckSettingsLivenessProbeArgs();
    }
}
