// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Teo.Inputs
{

    public sealed class RuleEngineRuleActionNormalActionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        [Input("parameters", required: true)]
        private InputList<Inputs.RuleEngineRuleActionNormalActionParameterGetArgs>? _parameters;
        public InputList<Inputs.RuleEngineRuleActionNormalActionParameterGetArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Inputs.RuleEngineRuleActionNormalActionParameterGetArgs>());
            set => _parameters = value;
        }

        public RuleEngineRuleActionNormalActionGetArgs()
        {
        }
        public static new RuleEngineRuleActionNormalActionGetArgs Empty => new RuleEngineRuleActionNormalActionGetArgs();
    }
}
