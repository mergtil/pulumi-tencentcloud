// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Eb.Inputs
{

    public sealed class EventTransformTransformationTransformArgs : global::Pulumi.ResourceArgs
    {
        [Input("outputStructs", required: true)]
        private InputList<Inputs.EventTransformTransformationTransformOutputStructArgs>? _outputStructs;
        public InputList<Inputs.EventTransformTransformationTransformOutputStructArgs> OutputStructs
        {
            get => _outputStructs ?? (_outputStructs = new InputList<Inputs.EventTransformTransformationTransformOutputStructArgs>());
            set => _outputStructs = value;
        }

        public EventTransformTransformationTransformArgs()
        {
        }
        public static new EventTransformTransformationTransformArgs Empty => new EventTransformTransformationTransformArgs();
    }
}
