// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cynosdb.Inputs
{

    public sealed class GetProxyNodeFilterArgs : global::Pulumi.InvokeArgs
    {
        [Input("exactMatch")]
        public bool? ExactMatch { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("names", required: true)]
        private List<string>? _names;
        public List<string> Names
        {
            get => _names ?? (_names = new List<string>());
            set => _names = value;
        }

        [Input("operator")]
        public string? Operator { get; set; }

        [Input("values", required: true)]
        private List<string>? _values;
        public List<string> Values
        {
            get => _values ?? (_values = new List<string>());
            set => _values = value;
        }

        public GetProxyNodeFilterArgs()
        {
        }
        public static new GetProxyNodeFilterArgs Empty => new GetProxyNodeFilterArgs();
    }
}
