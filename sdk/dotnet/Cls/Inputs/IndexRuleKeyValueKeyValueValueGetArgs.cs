// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cls.Inputs
{

    public sealed class IndexRuleKeyValueKeyValueValueGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("containZH")]
        public Input<bool>? ContainZH { get; set; }

        [Input("sqlFlag")]
        public Input<bool>? SqlFlag { get; set; }

        [Input("tokenizer")]
        public Input<string>? Tokenizer { get; set; }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public IndexRuleKeyValueKeyValueValueGetArgs()
        {
        }
        public static new IndexRuleKeyValueKeyValueValueGetArgs Empty => new IndexRuleKeyValueKeyValueValueGetArgs();
    }
}
