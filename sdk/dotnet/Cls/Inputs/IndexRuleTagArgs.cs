// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cls.Inputs
{

    public sealed class IndexRuleTagArgs : global::Pulumi.ResourceArgs
    {
        [Input("caseSensitive", required: true)]
        public Input<bool> CaseSensitive { get; set; } = null!;

        [Input("keyValues")]
        private InputList<Inputs.IndexRuleTagKeyValueArgs>? _keyValues;
        public InputList<Inputs.IndexRuleTagKeyValueArgs> KeyValues
        {
            get => _keyValues ?? (_keyValues = new InputList<Inputs.IndexRuleTagKeyValueArgs>());
            set => _keyValues = value;
        }

        public IndexRuleTagArgs()
        {
        }
        public static new IndexRuleTagArgs Empty => new IndexRuleTagArgs();
    }
}
