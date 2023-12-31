// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dcdb.Outputs
{

    [OutputType]
    public sealed class GetShardSpecSpecConfigResult
    {
        public readonly string Machine;
        public readonly ImmutableArray<Outputs.GetShardSpecSpecConfigSpecConfigInfoResult> SpecConfigInfos;

        [OutputConstructor]
        private GetShardSpecSpecConfigResult(
            string machine,

            ImmutableArray<Outputs.GetShardSpecSpecConfigSpecConfigInfoResult> specConfigInfos)
        {
            Machine = machine;
            SpecConfigInfos = specConfigInfos;
        }
    }
}
