// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tcm.Outputs
{

    [OutputType]
    public sealed class MeshConfigTracing
    {
        public readonly Outputs.MeshConfigTracingApm? Apm;
        public readonly bool? Enable;
        public readonly double? Sampling;
        public readonly Outputs.MeshConfigTracingZipkin? Zipkin;

        [OutputConstructor]
        private MeshConfigTracing(
            Outputs.MeshConfigTracingApm? apm,

            bool? enable,

            double? sampling,

            Outputs.MeshConfigTracingZipkin? zipkin)
        {
            Apm = apm;
            Enable = enable;
            Sampling = sampling;
            Zipkin = zipkin;
        }
    }
}