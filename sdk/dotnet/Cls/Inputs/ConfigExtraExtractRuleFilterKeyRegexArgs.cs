// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cls.Inputs
{

    public sealed class ConfigExtraExtractRuleFilterKeyRegexArgs : global::Pulumi.ResourceArgs
    {
        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("regex")]
        public Input<string>? Regex { get; set; }

        public ConfigExtraExtractRuleFilterKeyRegexArgs()
        {
        }
        public static new ConfigExtraExtractRuleFilterKeyRegexArgs Empty => new ConfigExtraExtractRuleFilterKeyRegexArgs();
    }
}