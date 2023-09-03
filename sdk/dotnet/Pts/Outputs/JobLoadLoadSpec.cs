// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Pts.Outputs
{

    [OutputType]
    public sealed class JobLoadLoadSpec
    {
        public readonly Outputs.JobLoadLoadSpecConcurrency? Concurrency;
        public readonly Outputs.JobLoadLoadSpecRequestsPerSecond? RequestsPerSecond;
        public readonly Outputs.JobLoadLoadSpecScriptOrigin? ScriptOrigin;

        [OutputConstructor]
        private JobLoadLoadSpec(
            Outputs.JobLoadLoadSpecConcurrency? concurrency,

            Outputs.JobLoadLoadSpecRequestsPerSecond? requestsPerSecond,

            Outputs.JobLoadLoadSpecScriptOrigin? scriptOrigin)
        {
            Concurrency = concurrency;
            RequestsPerSecond = requestsPerSecond;
            ScriptOrigin = scriptOrigin;
        }
    }
}