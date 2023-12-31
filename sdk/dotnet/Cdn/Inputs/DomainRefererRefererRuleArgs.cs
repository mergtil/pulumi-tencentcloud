// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cdn.Inputs
{

    public sealed class DomainRefererRefererRuleArgs : global::Pulumi.ResourceArgs
    {
        [Input("allowEmpty", required: true)]
        public Input<bool> AllowEmpty { get; set; } = null!;

        [Input("refererType", required: true)]
        public Input<string> RefererType { get; set; } = null!;

        [Input("referers", required: true)]
        private InputList<string>? _referers;
        public InputList<string> Referers
        {
            get => _referers ?? (_referers = new InputList<string>());
            set => _referers = value;
        }

        [Input("rulePaths", required: true)]
        private InputList<string>? _rulePaths;
        public InputList<string> RulePaths
        {
            get => _rulePaths ?? (_rulePaths = new InputList<string>());
            set => _rulePaths = value;
        }

        [Input("ruleType", required: true)]
        public Input<string> RuleType { get; set; } = null!;

        public DomainRefererRefererRuleArgs()
        {
        }
        public static new DomainRefererRefererRuleArgs Empty => new DomainRefererRefererRuleArgs();
    }
}
