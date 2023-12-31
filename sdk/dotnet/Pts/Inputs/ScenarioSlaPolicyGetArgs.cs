// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Pts.Inputs
{

    public sealed class ScenarioSlaPolicyGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("alertChannel")]
        public Input<Inputs.ScenarioSlaPolicyAlertChannelGetArgs>? AlertChannel { get; set; }

        [Input("slaRules")]
        private InputList<Inputs.ScenarioSlaPolicySlaRuleGetArgs>? _slaRules;
        public InputList<Inputs.ScenarioSlaPolicySlaRuleGetArgs> SlaRules
        {
            get => _slaRules ?? (_slaRules = new InputList<Inputs.ScenarioSlaPolicySlaRuleGetArgs>());
            set => _slaRules = value;
        }

        public ScenarioSlaPolicyGetArgs()
        {
        }
        public static new ScenarioSlaPolicyGetArgs Empty => new ScenarioSlaPolicyGetArgs();
    }
}
