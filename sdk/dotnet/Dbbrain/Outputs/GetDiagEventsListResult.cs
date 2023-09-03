// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dbbrain.Outputs
{

    [OutputType]
    public sealed class GetDiagEventsListResult
    {
        public readonly string DiagItem;
        public readonly string DiagType;
        public readonly string EndTime;
        public readonly int EventId;
        public readonly string InstanceId;
        public readonly string Metric;
        public readonly string Outline;
        public readonly string Region;
        public readonly int Severity;
        public readonly string StartTime;

        [OutputConstructor]
        private GetDiagEventsListResult(
            string diagItem,

            string diagType,

            string endTime,

            int eventId,

            string instanceId,

            string metric,

            string outline,

            string region,

            int severity,

            string startTime)
        {
            DiagItem = diagItem;
            DiagType = diagType;
            EndTime = endTime;
            EventId = eventId;
            InstanceId = instanceId;
            Metric = metric;
            Outline = outline;
            Region = region;
            Severity = severity;
            StartTime = startTime;
        }
    }
}