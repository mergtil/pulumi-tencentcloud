// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Eb.Inputs
{

    public sealed class EventTransformTransformationArgs : global::Pulumi.ResourceArgs
    {
        [Input("etlFilter")]
        public Input<Inputs.EventTransformTransformationEtlFilterArgs>? EtlFilter { get; set; }

        [Input("extraction")]
        public Input<Inputs.EventTransformTransformationExtractionArgs>? Extraction { get; set; }

        [Input("transform")]
        public Input<Inputs.EventTransformTransformationTransformArgs>? Transform { get; set; }

        public EventTransformTransformationArgs()
        {
        }
        public static new EventTransformTransformationArgs Empty => new EventTransformTransformationArgs();
    }
}
