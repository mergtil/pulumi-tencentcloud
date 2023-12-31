// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cynosdb.Inputs
{

    public sealed class GetProxyNodeFilterInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("exactMatch")]
        public Input<bool>? ExactMatch { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("names", required: true)]
        private InputList<string>? _names;
        public InputList<string> Names
        {
            get => _names ?? (_names = new InputList<string>());
            set => _names = value;
        }

        [Input("operator")]
        public Input<string>? Operator { get; set; }

        [Input("values", required: true)]
        private InputList<string>? _values;
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public GetProxyNodeFilterInputArgs()
        {
        }
        public static new GetProxyNodeFilterInputArgs Empty => new GetProxyNodeFilterInputArgs();
    }
}
