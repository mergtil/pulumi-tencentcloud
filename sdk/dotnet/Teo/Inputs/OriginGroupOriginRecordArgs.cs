// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Teo.Inputs
{

    public sealed class OriginGroupOriginRecordArgs : global::Pulumi.ResourceArgs
    {
        [Input("areas")]
        private InputList<string>? _areas;
        public InputList<string> Areas
        {
            get => _areas ?? (_areas = new InputList<string>());
            set => _areas = value;
        }

        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        [Input("private")]
        public Input<bool>? Private { get; set; }

        [Input("privateParameters")]
        private InputList<Inputs.OriginGroupOriginRecordPrivateParameterArgs>? _privateParameters;
        public InputList<Inputs.OriginGroupOriginRecordPrivateParameterArgs> PrivateParameters
        {
            get => _privateParameters ?? (_privateParameters = new InputList<Inputs.OriginGroupOriginRecordPrivateParameterArgs>());
            set => _privateParameters = value;
        }

        [Input("record", required: true)]
        public Input<string> Record { get; set; } = null!;

        [Input("recordId")]
        public Input<string>? RecordId { get; set; }

        [Input("weight")]
        public Input<int>? Weight { get; set; }

        public OriginGroupOriginRecordArgs()
        {
        }
        public static new OriginGroupOriginRecordArgs Empty => new OriginGroupOriginRecordArgs();
    }
}