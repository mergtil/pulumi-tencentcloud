// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Monitor.Inputs
{

    public sealed class TmpTkeAlertPolicyAlertRuleGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("notification")]
        public Input<Inputs.TmpTkeAlertPolicyAlertRuleNotificationGetArgs>? Notification { get; set; }

        [Input("rules", required: true)]
        private InputList<Inputs.TmpTkeAlertPolicyAlertRuleRuleGetArgs>? _rules;
        public InputList<Inputs.TmpTkeAlertPolicyAlertRuleRuleGetArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.TmpTkeAlertPolicyAlertRuleRuleGetArgs>());
            set => _rules = value;
        }

        [Input("templateId")]
        public Input<string>? TemplateId { get; set; }

        [Input("updatedAt")]
        public Input<string>? UpdatedAt { get; set; }

        public TmpTkeAlertPolicyAlertRuleGetArgs()
        {
        }
        public static new TmpTkeAlertPolicyAlertRuleGetArgs Empty => new TmpTkeAlertPolicyAlertRuleGetArgs();
    }
}
