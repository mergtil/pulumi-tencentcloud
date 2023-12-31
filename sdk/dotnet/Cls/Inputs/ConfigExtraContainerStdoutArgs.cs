// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cls.Inputs
{

    public sealed class ConfigExtraContainerStdoutArgs : global::Pulumi.ResourceArgs
    {
        [Input("allContainers", required: true)]
        public Input<bool> AllContainers { get; set; } = null!;

        [Input("excludeLabels")]
        private InputList<string>? _excludeLabels;
        public InputList<string> ExcludeLabels
        {
            get => _excludeLabels ?? (_excludeLabels = new InputList<string>());
            set => _excludeLabels = value;
        }

        [Input("excludeNamespace")]
        public Input<string>? ExcludeNamespace { get; set; }

        [Input("includeLabels")]
        private InputList<string>? _includeLabels;
        public InputList<string> IncludeLabels
        {
            get => _includeLabels ?? (_includeLabels = new InputList<string>());
            set => _includeLabels = value;
        }

        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("workloads")]
        private InputList<Inputs.ConfigExtraContainerStdoutWorkloadArgs>? _workloads;
        public InputList<Inputs.ConfigExtraContainerStdoutWorkloadArgs> Workloads
        {
            get => _workloads ?? (_workloads = new InputList<Inputs.ConfigExtraContainerStdoutWorkloadArgs>());
            set => _workloads = value;
        }

        public ConfigExtraContainerStdoutArgs()
        {
        }
        public static new ConfigExtraContainerStdoutArgs Empty => new ConfigExtraContainerStdoutArgs();
    }
}
