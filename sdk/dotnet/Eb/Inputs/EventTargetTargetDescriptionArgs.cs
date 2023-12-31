// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Eb.Inputs
{

    public sealed class EventTargetTargetDescriptionArgs : global::Pulumi.ResourceArgs
    {
        [Input("ckafkaTargetParams")]
        public Input<Inputs.EventTargetTargetDescriptionCkafkaTargetParamsArgs>? CkafkaTargetParams { get; set; }

        [Input("esTargetParams")]
        public Input<Inputs.EventTargetTargetDescriptionEsTargetParamsArgs>? EsTargetParams { get; set; }

        [Input("resourceDescription", required: true)]
        public Input<string> ResourceDescription { get; set; } = null!;

        [Input("scfParams")]
        public Input<Inputs.EventTargetTargetDescriptionScfParamsArgs>? ScfParams { get; set; }

        public EventTargetTargetDescriptionArgs()
        {
        }
        public static new EventTargetTargetDescriptionArgs Empty => new EventTargetTargetDescriptionArgs();
    }
}
