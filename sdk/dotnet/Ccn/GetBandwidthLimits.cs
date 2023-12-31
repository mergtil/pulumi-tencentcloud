// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ccn
{
    public static class GetBandwidthLimits
    {
        public static Task<GetBandwidthLimitsResult> InvokeAsync(GetBandwidthLimitsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetBandwidthLimitsResult>("tencentcloud:Ccn/getBandwidthLimits:getBandwidthLimits", args ?? new GetBandwidthLimitsArgs(), options.WithDefaults());

        public static Output<GetBandwidthLimitsResult> Invoke(GetBandwidthLimitsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetBandwidthLimitsResult>("tencentcloud:Ccn/getBandwidthLimits:getBandwidthLimits", args ?? new GetBandwidthLimitsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBandwidthLimitsArgs : global::Pulumi.InvokeArgs
    {
        [Input("ccnId", required: true)]
        public string CcnId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetBandwidthLimitsArgs()
        {
        }
        public static new GetBandwidthLimitsArgs Empty => new GetBandwidthLimitsArgs();
    }

    public sealed class GetBandwidthLimitsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("ccnId", required: true)]
        public Input<string> CcnId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetBandwidthLimitsInvokeArgs()
        {
        }
        public static new GetBandwidthLimitsInvokeArgs Empty => new GetBandwidthLimitsInvokeArgs();
    }


    [OutputType]
    public sealed class GetBandwidthLimitsResult
    {
        public readonly string CcnId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetBandwidthLimitsLimitResult> Limits;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetBandwidthLimitsResult(
            string ccnId,

            string id,

            ImmutableArray<Outputs.GetBandwidthLimitsLimitResult> limits,

            string? resultOutputFile)
        {
            CcnId = ccnId;
            Id = id;
            Limits = limits;
            ResultOutputFile = resultOutputFile;
        }
    }
}
