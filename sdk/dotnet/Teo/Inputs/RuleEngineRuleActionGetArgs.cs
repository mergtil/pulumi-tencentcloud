// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Teo.Inputs
{

    public sealed class RuleEngineRuleActionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("codeAction")]
        public Input<Inputs.RuleEngineRuleActionCodeActionGetArgs>? CodeAction { get; set; }

        [Input("normalAction")]
        public Input<Inputs.RuleEngineRuleActionNormalActionGetArgs>? NormalAction { get; set; }

        [Input("rewriteAction")]
        public Input<Inputs.RuleEngineRuleActionRewriteActionGetArgs>? RewriteAction { get; set; }

        public RuleEngineRuleActionGetArgs()
        {
        }
        public static new RuleEngineRuleActionGetArgs Empty => new RuleEngineRuleActionGetArgs();
    }
}
