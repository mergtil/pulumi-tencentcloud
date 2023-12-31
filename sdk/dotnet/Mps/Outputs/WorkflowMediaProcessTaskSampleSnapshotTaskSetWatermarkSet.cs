// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mps.Outputs
{

    [OutputType]
    public sealed class WorkflowMediaProcessTaskSampleSnapshotTaskSetWatermarkSet
    {
        public readonly int Definition;
        public readonly double? EndTimeOffset;
        public readonly Outputs.WorkflowMediaProcessTaskSampleSnapshotTaskSetWatermarkSetRawParameter? RawParameter;
        public readonly double? StartTimeOffset;
        public readonly string? SvgContent;
        public readonly string? TextContent;

        [OutputConstructor]
        private WorkflowMediaProcessTaskSampleSnapshotTaskSetWatermarkSet(
            int definition,

            double? endTimeOffset,

            Outputs.WorkflowMediaProcessTaskSampleSnapshotTaskSetWatermarkSetRawParameter? rawParameter,

            double? startTimeOffset,

            string? svgContent,

            string? textContent)
        {
            Definition = definition;
            EndTimeOffset = endTimeOffset;
            RawParameter = rawParameter;
            StartTimeOffset = startTimeOffset;
            SvgContent = svgContent;
            TextContent = textContent;
        }
    }
}
