// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cat.Outputs
{

    [OutputType]
    public sealed class GetProbeDataDetailedSingleDataDefineResult
    {
        public readonly ImmutableArray<Outputs.GetProbeDataDetailedSingleDataDefineFieldResult> Fields;
        public readonly ImmutableArray<Outputs.GetProbeDataDetailedSingleDataDefineLabelResult> Labels;
        public readonly int ProbeTime;

        [OutputConstructor]
        private GetProbeDataDetailedSingleDataDefineResult(
            ImmutableArray<Outputs.GetProbeDataDetailedSingleDataDefineFieldResult> fields,

            ImmutableArray<Outputs.GetProbeDataDetailedSingleDataDefineLabelResult> labels,

            int probeTime)
        {
            Fields = fields;
            Labels = labels;
            ProbeTime = probeTime;
        }
    }
}