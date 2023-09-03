// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Deprecatedroute
{
    public static class GetTable
    {
        public static Task<GetTableResult> InvokeAsync(GetTableArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTableResult>("tencentcloud:Deprecatedroute/getTable:getTable", args ?? new GetTableArgs(), options.WithDefaults());

        public static Output<GetTableResult> Invoke(GetTableInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTableResult>("tencentcloud:Deprecatedroute/getTable:getTable", args ?? new GetTableInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTableArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public string? Name { get; set; }

        [Input("routeTableId", required: true)]
        public string RouteTableId { get; set; } = null!;

        public GetTableArgs()
        {
        }
        public static new GetTableArgs Empty => new GetTableArgs();
    }

    public sealed class GetTableInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("routeTableId", required: true)]
        public Input<string> RouteTableId { get; set; } = null!;

        public GetTableInvokeArgs()
        {
        }
        public static new GetTableInvokeArgs Empty => new GetTableInvokeArgs();
    }


    [OutputType]
    public sealed class GetTableResult
    {
        public readonly string CreateTime;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? Name;
        public readonly string RouteTableId;
        public readonly ImmutableArray<Outputs.GetTableRouteResult> Routes;
        public readonly int SubnetNum;
        public readonly string VpcId;

        [OutputConstructor]
        private GetTableResult(
            string createTime,

            string id,

            string? name,

            string routeTableId,

            ImmutableArray<Outputs.GetTableRouteResult> routes,

            int subnetNum,

            string vpcId)
        {
            CreateTime = createTime;
            Id = id;
            Name = name;
            RouteTableId = routeTableId;
            Routes = routes;
            SubnetNum = subnetNum;
            VpcId = vpcId;
        }
    }
}