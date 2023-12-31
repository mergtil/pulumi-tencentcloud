// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Monitor.Inputs
{

    public sealed class TmpTkeAlertPolicyAlertRuleRuleGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputList<Inputs.TmpTkeAlertPolicyAlertRuleRuleAnnotationGetArgs>? _annotations;
        public InputList<Inputs.TmpTkeAlertPolicyAlertRuleRuleAnnotationGetArgs> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<Inputs.TmpTkeAlertPolicyAlertRuleRuleAnnotationGetArgs>());
            set => _annotations = value;
        }

        [Input("describe")]
        public Input<string>? Describe { get; set; }

        [Input("for", required: true)]
        public Input<string> For { get; set; } = null!;

        [Input("labels", required: true)]
        private InputList<Inputs.TmpTkeAlertPolicyAlertRuleRuleLabelGetArgs>? _labels;
        public InputList<Inputs.TmpTkeAlertPolicyAlertRuleRuleLabelGetArgs> Labels
        {
            get => _labels ?? (_labels = new InputList<Inputs.TmpTkeAlertPolicyAlertRuleRuleLabelGetArgs>());
            set => _labels = value;
        }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("rule", required: true)]
        public Input<string> Rule { get; set; } = null!;

        [Input("ruleState")]
        public Input<int>? RuleState { get; set; }

        [Input("template", required: true)]
        public Input<string> Template { get; set; } = null!;

        public TmpTkeAlertPolicyAlertRuleRuleGetArgs()
        {
        }
        public static new TmpTkeAlertPolicyAlertRuleRuleGetArgs Empty => new TmpTkeAlertPolicyAlertRuleRuleGetArgs();
    }
}
