// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Scf.Inputs
{

    public sealed class ProvisionedConcurrencyConfigTriggerActionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("provisionedType")]
        public Input<string>? ProvisionedType { get; set; }

        [Input("triggerCronConfig", required: true)]
        public Input<string> TriggerCronConfig { get; set; } = null!;

        [Input("triggerName", required: true)]
        public Input<string> TriggerName { get; set; } = null!;

        [Input("triggerProvisionedConcurrencyNum", required: true)]
        public Input<int> TriggerProvisionedConcurrencyNum { get; set; } = null!;

        public ProvisionedConcurrencyConfigTriggerActionGetArgs()
        {
        }
        public static new ProvisionedConcurrencyConfigTriggerActionGetArgs Empty => new ProvisionedConcurrencyConfigTriggerActionGetArgs();
    }
}
