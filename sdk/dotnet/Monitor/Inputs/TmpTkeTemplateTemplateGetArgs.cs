// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Monitor.Inputs
{

    public sealed class TmpTkeTemplateTemplateGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("describe")]
        public Input<string>? Describe { get; set; }

        [Input("isDefault")]
        public Input<bool>? IsDefault { get; set; }

        [Input("level", required: true)]
        public Input<string> Level { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("podMonitors")]
        private InputList<Inputs.TmpTkeTemplateTemplatePodMonitorGetArgs>? _podMonitors;
        public InputList<Inputs.TmpTkeTemplateTemplatePodMonitorGetArgs> PodMonitors
        {
            get => _podMonitors ?? (_podMonitors = new InputList<Inputs.TmpTkeTemplateTemplatePodMonitorGetArgs>());
            set => _podMonitors = value;
        }

        [Input("rawJobs")]
        private InputList<Inputs.TmpTkeTemplateTemplateRawJobGetArgs>? _rawJobs;
        public InputList<Inputs.TmpTkeTemplateTemplateRawJobGetArgs> RawJobs
        {
            get => _rawJobs ?? (_rawJobs = new InputList<Inputs.TmpTkeTemplateTemplateRawJobGetArgs>());
            set => _rawJobs = value;
        }

        [Input("recordRules")]
        private InputList<Inputs.TmpTkeTemplateTemplateRecordRuleGetArgs>? _recordRules;
        public InputList<Inputs.TmpTkeTemplateTemplateRecordRuleGetArgs> RecordRules
        {
            get => _recordRules ?? (_recordRules = new InputList<Inputs.TmpTkeTemplateTemplateRecordRuleGetArgs>());
            set => _recordRules = value;
        }

        [Input("serviceMonitors")]
        private InputList<Inputs.TmpTkeTemplateTemplateServiceMonitorGetArgs>? _serviceMonitors;
        public InputList<Inputs.TmpTkeTemplateTemplateServiceMonitorGetArgs> ServiceMonitors
        {
            get => _serviceMonitors ?? (_serviceMonitors = new InputList<Inputs.TmpTkeTemplateTemplateServiceMonitorGetArgs>());
            set => _serviceMonitors = value;
        }

        [Input("templateId")]
        public Input<string>? TemplateId { get; set; }

        [Input("updateTime")]
        public Input<string>? UpdateTime { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public TmpTkeTemplateTemplateGetArgs()
        {
        }
        public static new TmpTkeTemplateTemplateGetArgs Empty => new TmpTkeTemplateTemplateGetArgs();
    }
}
