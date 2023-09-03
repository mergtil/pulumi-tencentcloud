// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Deprecatedcontainer
{
    public static class GetClusterInstances
    {
        public static Task<GetClusterInstancesResult> InvokeAsync(GetClusterInstancesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetClusterInstancesResult>("tencentcloud:Deprecatedcontainer/getClusterInstances:getClusterInstances", args ?? new GetClusterInstancesArgs(), options.WithDefaults());

        public static Output<GetClusterInstancesResult> Invoke(GetClusterInstancesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetClusterInstancesResult>("tencentcloud:Deprecatedcontainer/getClusterInstances:getClusterInstances", args ?? new GetClusterInstancesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetClusterInstancesArgs : global::Pulumi.InvokeArgs
    {
        [Input("clusterId", required: true)]
        public string ClusterId { get; set; } = null!;

        [Input("limit")]
        public int? Limit { get; set; }

        public GetClusterInstancesArgs()
        {
        }
        public static new GetClusterInstancesArgs Empty => new GetClusterInstancesArgs();
    }

    public sealed class GetClusterInstancesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        [Input("limit")]
        public Input<int>? Limit { get; set; }

        public GetClusterInstancesInvokeArgs()
        {
        }
        public static new GetClusterInstancesInvokeArgs Empty => new GetClusterInstancesInvokeArgs();
    }


    [OutputType]
    public sealed class GetClusterInstancesResult
    {
        public readonly string ClusterId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly int? Limit;
        public readonly ImmutableArray<Outputs.GetClusterInstancesNodeResult> Nodes;
        public readonly int TotalCount;

        [OutputConstructor]
        private GetClusterInstancesResult(
            string clusterId,

            string id,

            int? limit,

            ImmutableArray<Outputs.GetClusterInstancesNodeResult> nodes,

            int totalCount)
        {
            ClusterId = clusterId;
            Id = id;
            Limit = limit;
            Nodes = nodes;
            TotalCount = totalCount;
        }
    }
}