// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Eb.Inputs
{

    public sealed class GetSearchFilterArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetSearchFilterFilterArgs>? _filters;
        public List<Inputs.GetSearchFilterFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetSearchFilterFilterArgs>());
            set => _filters = value;
        }

        [Input("key")]
        public string? Key { get; set; }

        [Input("operator")]
        public string? Operator { get; set; }

        [Input("type")]
        public string? Type { get; set; }

        [Input("value")]
        public string? Value { get; set; }

        public GetSearchFilterArgs()
        {
        }
        public static new GetSearchFilterArgs Empty => new GetSearchFilterArgs();
    }
}
