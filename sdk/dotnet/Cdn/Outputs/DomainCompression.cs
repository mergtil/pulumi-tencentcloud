// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cdn.Outputs
{

    [OutputType]
    public sealed class DomainCompression
    {
        public readonly ImmutableArray<Outputs.DomainCompressionCompressionRule> CompressionRules;
        public readonly string Switch;

        [OutputConstructor]
        private DomainCompression(
            ImmutableArray<Outputs.DomainCompressionCompressionRule> compressionRules,

            string @switch)
        {
            CompressionRules = compressionRules;
            Switch = @switch;
        }
    }
}
