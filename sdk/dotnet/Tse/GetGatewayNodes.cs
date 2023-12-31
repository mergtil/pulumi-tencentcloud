// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tse
{
    public static class GetGatewayNodes
    {
        public static Task<GetGatewayNodesResult> InvokeAsync(GetGatewayNodesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetGatewayNodesResult>("tencentcloud:Tse/getGatewayNodes:getGatewayNodes", args ?? new GetGatewayNodesArgs(), options.WithDefaults());

        public static Output<GetGatewayNodesResult> Invoke(GetGatewayNodesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetGatewayNodesResult>("tencentcloud:Tse/getGatewayNodes:getGatewayNodes", args ?? new GetGatewayNodesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetGatewayNodesArgs : global::Pulumi.InvokeArgs
    {
        [Input("gatewayId", required: true)]
        public string GatewayId { get; set; } = null!;

        [Input("groupId")]
        public string? GroupId { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetGatewayNodesArgs()
        {
        }
        public static new GetGatewayNodesArgs Empty => new GetGatewayNodesArgs();
    }

    public sealed class GetGatewayNodesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("gatewayId", required: true)]
        public Input<string> GatewayId { get; set; } = null!;

        [Input("groupId")]
        public Input<string>? GroupId { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetGatewayNodesInvokeArgs()
        {
        }
        public static new GetGatewayNodesInvokeArgs Empty => new GetGatewayNodesInvokeArgs();
    }


    [OutputType]
    public sealed class GetGatewayNodesResult
    {
        public readonly string GatewayId;
        public readonly string? GroupId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetGatewayNodesNodeListResult> NodeLists;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetGatewayNodesResult(
            string gatewayId,

            string? groupId,

            string id,

            ImmutableArray<Outputs.GetGatewayNodesNodeListResult> nodeLists,

            string? resultOutputFile)
        {
            GatewayId = gatewayId;
            GroupId = groupId;
            Id = id;
            NodeLists = nodeLists;
            ResultOutputFile = resultOutputFile;
        }
    }
}
