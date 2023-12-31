// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cdn.Inputs
{

    public sealed class DomainCompressionArgs : global::Pulumi.ResourceArgs
    {
        [Input("compressionRules")]
        private InputList<Inputs.DomainCompressionCompressionRuleArgs>? _compressionRules;
        public InputList<Inputs.DomainCompressionCompressionRuleArgs> CompressionRules
        {
            get => _compressionRules ?? (_compressionRules = new InputList<Inputs.DomainCompressionCompressionRuleArgs>());
            set => _compressionRules = value;
        }

        [Input("switch", required: true)]
        public Input<string> Switch { get; set; } = null!;

        public DomainCompressionArgs()
        {
        }
        public static new DomainCompressionArgs Empty => new DomainCompressionArgs();
    }
}
