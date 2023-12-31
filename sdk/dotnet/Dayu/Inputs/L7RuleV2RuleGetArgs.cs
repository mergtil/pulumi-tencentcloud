// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dayu.Inputs
{

    public sealed class L7RuleV2RuleGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("ccEnable")]
        public Input<int>? CcEnable { get; set; }

        [Input("certType")]
        public Input<int>? CertType { get; set; }

        [Input("domain", required: true)]
        public Input<string> Domain { get; set; } = null!;

        [Input("httpsToHttpEnable")]
        public Input<int>? HttpsToHttpEnable { get; set; }

        [Input("keepEnable", required: true)]
        public Input<int> KeepEnable { get; set; } = null!;

        [Input("keeptime", required: true)]
        public Input<int> Keeptime { get; set; } = null!;

        [Input("lbType", required: true)]
        public Input<int> LbType { get; set; } = null!;

        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        [Input("sourceLists", required: true)]
        private InputList<Inputs.L7RuleV2RuleSourceListGetArgs>? _sourceLists;
        public InputList<Inputs.L7RuleV2RuleSourceListGetArgs> SourceLists
        {
            get => _sourceLists ?? (_sourceLists = new InputList<Inputs.L7RuleV2RuleSourceListGetArgs>());
            set => _sourceLists = value;
        }

        [Input("sourceType", required: true)]
        public Input<int> SourceType { get; set; } = null!;

        [Input("sslId")]
        public Input<string>? SslId { get; set; }

        public L7RuleV2RuleGetArgs()
        {
        }
        public static new L7RuleV2RuleGetArgs Empty => new L7RuleV2RuleGetArgs();
    }
}
