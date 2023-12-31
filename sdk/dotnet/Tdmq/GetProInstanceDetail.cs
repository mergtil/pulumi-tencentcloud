// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tdmq
{
    public static class GetProInstanceDetail
    {
        public static Task<GetProInstanceDetailResult> InvokeAsync(GetProInstanceDetailArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetProInstanceDetailResult>("tencentcloud:Tdmq/getProInstanceDetail:getProInstanceDetail", args ?? new GetProInstanceDetailArgs(), options.WithDefaults());

        public static Output<GetProInstanceDetailResult> Invoke(GetProInstanceDetailInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetProInstanceDetailResult>("tencentcloud:Tdmq/getProInstanceDetail:getProInstanceDetail", args ?? new GetProInstanceDetailInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetProInstanceDetailArgs : global::Pulumi.InvokeArgs
    {
        [Input("clusterId", required: true)]
        public string ClusterId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetProInstanceDetailArgs()
        {
        }
        public static new GetProInstanceDetailArgs Empty => new GetProInstanceDetailArgs();
    }

    public sealed class GetProInstanceDetailInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetProInstanceDetailInvokeArgs()
        {
        }
        public static new GetProInstanceDetailInvokeArgs Empty => new GetProInstanceDetailInvokeArgs();
    }


    [OutputType]
    public sealed class GetProInstanceDetailResult
    {
        public readonly string ClusterId;
        public readonly ImmutableArray<Outputs.GetProInstanceDetailClusterInfoResult> ClusterInfos;
        public readonly ImmutableArray<Outputs.GetProInstanceDetailClusterSpecInfoResult> ClusterSpecInfos;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetProInstanceDetailNetworkAccessPointInfoResult> NetworkAccessPointInfos;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetProInstanceDetailResult(
            string clusterId,

            ImmutableArray<Outputs.GetProInstanceDetailClusterInfoResult> clusterInfos,

            ImmutableArray<Outputs.GetProInstanceDetailClusterSpecInfoResult> clusterSpecInfos,

            string id,

            ImmutableArray<Outputs.GetProInstanceDetailNetworkAccessPointInfoResult> networkAccessPointInfos,

            string? resultOutputFile)
        {
            ClusterId = clusterId;
            ClusterInfos = clusterInfos;
            ClusterSpecInfos = clusterSpecInfos;
            Id = id;
            NetworkAccessPointInfos = networkAccessPointInfos;
            ResultOutputFile = resultOutputFile;
        }
    }
}
